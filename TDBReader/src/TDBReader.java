import javax.swing.*;
import javax.swing.filechooser.FileFilter;
import javax.swing.filechooser.FileNameExtensionFilter;

import java.awt.*;
import java.awt.event.*;
import java.io.File;



public class TDBReader extends JFrame {
	private static final long serialVersionUID = 1L;
	public static final String[] listLanguages = 
		{"English","French","Italian","Japanese","Portuguese","Spanish(1)","Spanish(2)","Chinese"};
	public JTextField txtFile;
	public JLabel lblFile;
	public JButton btnOpen;
	public JSeparator separator;
	public JComboBox cboLanguage;
	public JTextArea txtLines;
	public JFileChooser fileChooser;
	public File tdbFile;
	public JScrollPane scrollPane; 
	
	public TDBReader(){
		getContentPane().setLayout(null);
		ActionListener AL = new tdbActionListener();
		
		lblFile = new JLabel("File:");
		lblFile.setBounds(10, 11, 46, 14);
		getContentPane().add(lblFile);
		
		txtFile = new JTextField();
		txtFile.setEditable(false);
		txtFile.setBounds(10, 29, 461, 20);
		getContentPane().add(txtFile);
		txtFile.setColumns(10);
		
		btnOpen = new JButton("Open");
		btnOpen.setBounds(382, 57, 89, 23);
		btnOpen.addActionListener(AL);
		getContentPane().add(btnOpen);
		
		separator = new JSeparator();
		separator.setBounds(10, 91, 461, 2);
		getContentPane().add(separator);
		
		cboLanguage = new JComboBox(listLanguages);
		cboLanguage.setBounds(10, 112, 145, 20);
		cboLanguage.addActionListener(AL);
		getContentPane().add(cboLanguage);
		
		scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 143, 461, 211);
		getContentPane().add(scrollPane);
		
		txtLines = new JTextArea();
		txtLines.setFont(new Font("Meiryo",Font.PLAIN,13));
		txtLines.setEditable(false);
		scrollPane.setViewportView(txtLines);
		
		fileChooser = new JFileChooser();
		FileFilter filter = new FileNameExtensionFilter("TDB files", "tdb");
		fileChooser.addChoosableFileFilter(filter);
		fileChooser.setFileFilter(filter);
				
		setSize(new Dimension(490, 390));
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setTitle("TDB Reader");
		setResizable(false);
		centralizar();
		setVisible(true);
		
	}

	public static void main(String[] args) {
		new TDBReader();
	}
	
	private void centralizar(){
		Toolkit meuTk = Toolkit.getDefaultToolkit();
		Dimension dimFrame = new Dimension(this.getSize());
		Dimension dimTela = new Dimension(meuTk.getScreenSize());
		this.setLocation((dimTela.width-dimFrame.width)/2,(dimTela.height-dimFrame.height)/2);
	}
	
	class tdbActionListener implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent arg0) {
			Object o = arg0.getSource();
			if(o==cboLanguage){
				cboLanguage_changed(cboLanguage.getSelectedIndex());
				return;
			}
			if(o==btnOpen){
				btnOpen_clicked();
			}
		}
	} // fim myActionListener
	
	private void cboLanguage_changed(int selectedIndex){
		if (!TextDataBase.Status()) return;
		String ls = System.getProperty("line.separator");
		int lc = TextDataBase.GetLineCount();
		// initialize blank string
		String myStr = new String("");
		// first line is 1
		for(int i=1; i<=lc; i++){
			myStr += TextDataBase.GetLine(i, selectedIndex);
			// append new line marker, except if this is the last line
			if(i!=lc) myStr += ls;
		}
		// put the lines with goddamn breaks into txtLines
		txtLines.setText(myStr);
		// this should make scrollPane go back to the top
		txtLines.setCaretPosition(0);;
		
	}
	
	private void btnOpen_clicked(){
		int resp = fileChooser.showDialog(this,"Open");
		if (resp==JFileChooser.APPROVE_OPTION){
			tdbFile = fileChooser.getSelectedFile();
			if(TextDataBase.LoadTextFromFile(tdbFile)){
				// put filename in the text box if text load was successful
				txtFile.setText(tdbFile.toString());
				// load text based on current selection on the combo box
				cboLanguage_changed(cboLanguage.getSelectedIndex());
			}
		}
		
	}
}
