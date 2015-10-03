import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;

import javax.swing.JOptionPane;

// bunch of static shit here, folks
// the program reads one file at a time, so I don't need to create multiple
// instances of TextDataBase.
// TextDataBase's properties and methods updates themselves first by calling LoadTextFromFile 

public class TextDataBase {
	private static boolean isReady = false;
	private static int lineCount = 0;
	private static int rIndex = 0;
	private static ByteBuffer bb;
	private static String[] JapaneseLines;
	private static String[] EnglishLines;
	private static String[] FrenchLines;
	private static String[] ItalianLines;
	private static String[] SpanishLines;
	private static String[] PortugueseLines;
	private static String[] NewLanguage1Lines;
	private static String[] NewLanguage2Lines;
	public static final int SIGNATURE_BIGENDIAN = 592725058; 
	public static final int LANG_ENGLISH = 0;
	public static final int LANG_FRENCH = 1;
	public static final int LANG_ITALIAN = 2;
	public static final int LANG_JAPANESE = 3;
	public static final int LANG_PORTUGUESE = 4;
	public static final int LANG_SPANISH = 5;
	public static final int LANG_NEW1 = 6;
	public static final int LANG_NEW2 = 7;
	public static final int COUNT_LANGUAGES = 8;
	
	public static boolean Status(){
		return isReady;
	}
	public static int GetLineCount(){
		return lineCount;
	}
	public static String GetLine(int lineNumber, int langCode){
		if (lineNumber>lineCount||lineNumber<=0) return null;
		if ( langCode >= COUNT_LANGUAGES || langCode < 0) return null;
		lineNumber--;
		switch(langCode){
		case(LANG_ENGLISH): // 0
			return EnglishLines[lineNumber];
		case(LANG_FRENCH): // 1
			return FrenchLines[lineNumber];
		case(LANG_ITALIAN): // 2
			return ItalianLines[lineNumber];
		case(LANG_JAPANESE): // 3
			return JapaneseLines[lineNumber];
		case(LANG_PORTUGUESE): // 4
			return PortugueseLines[lineNumber];
		case(LANG_SPANISH):
			return SpanishLines[lineNumber];
		case(LANG_NEW1):
			return NewLanguage1Lines[lineNumber];
		}
		
		return NewLanguage2Lines[lineNumber];
	
	}
	
	public static boolean LoadTextFromFile(File f) {
		//ByteBuffer bb = ByteBuffer.wrap(readFileInputStream(f));
		// buffer has to be shared (static), so the read string function can work
		bb = ByteBuffer.wrap(readFileInputStream(f));
		bb.order(ByteOrder.BIG_ENDIAN);
		if (bb.getInt(0)!= SIGNATURE_BIGENDIAN) {
			JOptionPane.showMessageDialog(null, "Invalid file. Missing signature.");
			return false;
		}
		int lc = bb.getInt(4);
		if(lc==0) {
			JOptionPane.showMessageDialog(null, "File seems valid, but line count is zero.");
			return false;
		}
		lineCount = lc;
		// Initialize all language arrays with x lines.
		// No missing languages in SS, they were between Spanish and Portuguese
		// Italian and French switched places...
		JapaneseLines = new String[lc];
		EnglishLines = new String[lc];
		FrenchLines = new String[lc];
		ItalianLines = new String[lc];
		SpanishLines = new String[lc];
		PortugueseLines = new String[lc];
		NewLanguage1Lines = new String[lc];
		NewLanguage2Lines = new String[lc];
		// Set initial value for read index
		rIndex = 0x10;
		// Start looping through lines
		for (int line = 0; line<lc; line++){
			// read line id
			// int lineID = bb.getInt(rIndex); // but it's not needed currently
			// (lineID==line) should return true anyway
			// Now, increase rIndex by sizeOf(lineID)
			// for the record, sizeOf doesn't exist here because anything in Java is an object
			rIndex += 4;
			// the fun starts...
			// 1) Bandai moved 2 null languages from between Spanish and Portuguese
			// and now they count
			// 2) Strings have to be instantiated from a byte or char array. BUT there is
			// no "cutting corners" for that (stuff like int* or &p from C doesn't exist here).

			JapaneseLines[line] = GetStringFromBuffer();
			EnglishLines[line] = GetStringFromBuffer();
			FrenchLines[line] = GetStringFromBuffer();
			ItalianLines[line] = GetStringFromBuffer();
			SpanishLines[line] = GetStringFromBuffer();
			PortugueseLines[line] = GetStringFromBuffer();
			NewLanguage1Lines[line] = GetStringFromBuffer();
			NewLanguage2Lines[line] = GetStringFromBuffer();
		}
		// with everything (supposedly) loaded, set ready flag to true
		isReady = true;
		return true;
		
		//System.out.println("0x0082: " + bb.getShort(0x82));
		//System.out.println("Limit: " + bb.limit());
	}
	private static String GetStringFromBuffer() {
		// this function is not really necessary, I'm doing this for readability
		// this function returns String *and* updates rIndex
		// rIndex and bb are perfectly accessible here (static)
		// char array should have ((size of string) / 2) elements
		// Each unicode char uses 2 bytes (Java char is unicode, thank God)
		int charCount = bb.getInt(rIndex)/2; // includes null char (default end of string marker)
		charCount -= 1; // skip last char (null char)
		char[] chars = new char[charCount];
		rIndex += 4;
		// fill up the char array
		for (int i=0; i<charCount; i++){
			chars[i] = bb.getChar(rIndex);
			rIndex += 2;
		}
		rIndex += 2; // to make up for the skipped null char
		// create a String based on the char array, and return it
		return new String(chars);
	}
	private static byte[] readFileInputStream(File a_file) {  
		 byte[] buffer = null;  
		 String filename = a_file.toString();  
		 try  
		 {  
		   FileInputStream fis = new FileInputStream(filename);  
		   int length = (int)a_file.length();  
		   buffer = new byte[length];  
		   fis.read(buffer);  
		   fis.close();  
		 }  
		 catch(IOException e)  
		 {  
		   e.printStackTrace();  
		 }  
		 return buffer;
	}
	


}
