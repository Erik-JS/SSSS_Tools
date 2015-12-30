using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TDBMaker
{
    class TDBHandler
    {
        public static bool Tdb2Xml(string srcfile, string dstfile)
        {
            TextDataBase tdb = TextDataBase.LoadFromFile(srcfile);
            if (tdb == null)
                return false;
            XmlDocument xmldoc = new XmlDocument();
            XmlNode tdbnode = xmldoc.CreateElement("TextDataBase");
            XmlNode plat = xmldoc.CreateElement("Platform");
            plat.InnerText = tdb.IsBigEndian ? "PS3" : "PC";
            tdbnode.AppendChild(plat);
            XmlNode linecount = xmldoc.CreateElement("StringCount");
            linecount.InnerText = tdb.LineCount.ToString();
            tdbnode.AppendChild(linecount);
            XmlNode languagecount = xmldoc.CreateElement("LanguageCount");
            languagecount.InnerText = tdb.LangCount.ToString();
            tdbnode.AppendChild(languagecount);
            XmlNode unknownval = xmldoc.CreateElement("Unknown");
            unknownval.InnerText = tdb.Unknown.ToString();
            tdbnode.AppendChild(unknownval);
            // fun starts here...
            for (int LangIndex = 0; LangIndex < tdb.LangCount; LangIndex++)
            {
                XmlNode langnode = xmldoc.CreateElement("Language" + LangIndex);
                for (int LineIndex = 0; LineIndex < tdb.LineCount; LineIndex++)
                {
                    XmlNode linenode = xmldoc.CreateElement("String" + LineIndex);
                    linenode.InnerText = tdb.Languages[LangIndex][LineIndex];
                    langnode.AppendChild(linenode);
                }
                tdbnode.AppendChild(langnode);
            }
            xmldoc.AppendChild(tdbnode);
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true, NewLineChars = "\n" };
            XmlWriter writer = XmlWriter.Create(dstfile, settings);
            xmldoc.Save(writer);
            writer.Close();
            return true;
        }

        public static bool Xml2Tdb(string srcfile, string dstfile, string overrideplatform = null)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(srcfile);
            TextDataBase tdb = new TextDataBase();
            string platform = "";

            if (overrideplatform != null)
            {
                platform = overrideplatform;
            }
            else
            {
                XmlNode plat = xmldoc.SelectSingleNode("//TextDataBase/Platform");
                if (plat != null)
                    platform = plat.InnerText;
            }

            if (platform.ToUpper() == "PS3")
            {
                tdb.IsBigEndian = true;
            }
            else if (platform.ToUpper() == "PC")
            {
                tdb.IsBigEndian = false;
            }
            else
            {
                System.Diagnostics.Debug.Print("Xml2Tdb: missing or invalid platform.");
                return false;
            }

            XmlNode lcnode = xmldoc.SelectSingleNode("//TextDataBase/StringCount");
            if (lcnode == null || !int.TryParse(lcnode.InnerText, out tdb.LineCount))
            {
                System.Diagnostics.Debug.Print("Xml2Tdb: missing or invalid string count.");
                return false;
            }

            XmlNode lgnode = xmldoc.SelectSingleNode("//TextDataBase/LanguageCount");
            if (lgnode == null || !int.TryParse(lgnode.InnerText, out tdb.LangCount))
            {
                System.Diagnostics.Debug.Print("Xml2Tdb: missing or invalid language count.");
                return false;
            }

            XmlNode unode = xmldoc.SelectSingleNode("//TextDataBase/Unknown");
            if (unode == null || !int.TryParse(unode.InnerText, out tdb.Unknown))
            {
                System.Diagnostics.Debug.Print("Xml2Tdb: missing or invalid 'unknown' value.");
                return false;
            }

            tdb.InitializeArrayOfLanguages();

            for (int LangIndex = 0; LangIndex < tdb.LangCount; LangIndex++)
            {
                for (int LineIndex = 0; LineIndex < tdb.LineCount; LineIndex++)
                {
                    XmlNode CurrentLineNode = xmldoc.SelectSingleNode("//TextDataBase/Language" + LangIndex + "/String" + LineIndex);
                    if (CurrentLineNode != null)
                    {
                        tdb.Languages[LangIndex].Add(CurrentLineNode.InnerText);
                    }
                    else
                        tdb.Languages[LangIndex].Add("");
                }
            }
            return tdb.SaveToFile(dstfile);
        }
    }

    class TextDataBase
    {
        public List<string>[] Languages;
        public int LineCount = 0;
        public bool IsBigEndian = false;
        public int LangCount = 0;
        public int Unknown = 1;

        public static TextDataBase LoadFromFile(string tdbfile)
        {
            TextDataBase tdb = new TextDataBase();
            FileStream fs = null;
            try
            {
                fs = new FileStream(tdbfile, FileMode.Open);
                byte[] buff = new byte[4];
                fs.Seek(0, SeekOrigin.Begin);
                fs.Read(buff, 0, 4);
                if (System.Text.Encoding.ASCII.GetString(buff) != "#TDB")
                {
                    System.Diagnostics.Debug.Print("TextDataBase.CreateFromFile | Missing #TDB signature.");
                    fs.Close();
                    return null;
                }
                int lcl = ReadInteger(fs, 4, false);
                int lcb = ReadInteger(fs, 4, true);
                lcl &= 0x0000FFFF;
                lcb &= 0x0000FFFF;
                if (lcl == lcb && lcb == 0)
                {
                    System.Diagnostics.Debug.Print("TextDataBase.CreateFromFile | TDB file is empty. LineCount = 0");
                    fs.Close();
                    return null;
                }
                if (lcl == 0)
                {
                    tdb.IsBigEndian = true;
                    tdb.LineCount = lcb;
                }
                else
                    tdb.LineCount = lcl;

                tdb.LangCount = ReadInteger(fs, 8, tdb.IsBigEndian);
                tdb.InitializeArrayOfLanguages();

                tdb.Unknown = ReadInteger(fs, 0xC, tdb.IsBigEndian);

                int rIndex = 0x10;

                for (int i = 0; i < tdb.LineCount; i++)
                {
                    int lineID = ReadInteger(fs, rIndex, tdb.IsBigEndian); // This is not used, but is counted.
                    System.Diagnostics.Debug.Print("TDB Line #" + lineID);
                    rIndex += 4;
                    //
                    for (int j = 0; j < tdb.LangCount; j++)
                    {
                        rIndex = GetStringFromStreamToList(fs, rIndex, tdb.Languages[j], tdb.IsBigEndian);
                    }
                }
                fs.Close();
                return tdb;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("TextDataBase.CreateFromFile | " + ex.GetType().Name + ": " + ex.Message);
                if(fs != null)
                    fs.Close();
                return null;
            }
        }

        private static int ReadInteger(FileStream fs, int index, bool bigendian)
        {
            fs.Seek(index, SeekOrigin.Begin);
            byte[] buff = new byte[4];
            fs.Read(buff, 0, 4);
            if (bigendian)
                Array.Reverse(buff);
            return BitConverter.ToInt32(buff, 0);
        }

        private static char ReadChar(FileStream fs, int index, bool bigendian)
        {
            fs.Seek(index, SeekOrigin.Begin);
            byte[] buff = new byte[2];
            fs.Read(buff, 0, 2);
            if (bigendian)
                Array.Reverse(buff);
            return BitConverter.ToChar(buff, 0);
        }

        private static string ReadString(FileStream fs, int index, int charlen, bool bigendian)
        {
            string str = "";
            for (int i = 0; i < charlen; i++)
            {
                str += ReadChar(fs, index + (i * 2), bigendian);
            }
            return str;
        }

        private static int GetStringFromStreamToList(FileStream fs, int rIndex, List<string> list, bool bigendian)
        {
            int bytelen = ReadInteger(fs, rIndex, bigendian);
            list.Add(ReadString(fs, rIndex + 4, (bytelen / 2) - 1, bigendian));
            return rIndex + 4 + bytelen;
        }

        public bool SaveToFile(string dstfile)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(dstfile, FileMode.Create);
                string signature = "#TDB";
                fs.WriteByte((byte)signature[0]);
                fs.WriteByte((byte)signature[1]);
                fs.WriteByte((byte)signature[2]);
                fs.WriteByte((byte)signature[3]);
                WriteInteger(fs, 0x4, LineCount, IsBigEndian);
                WriteInteger(fs, 0x8, LangCount, IsBigEndian);
                WriteInteger(fs, 0xC, Unknown, IsBigEndian);
                int wIndex = 0x10;
                for (int i = 0; i < LineCount; i++)
                {
                    WriteInteger(fs, wIndex, i, IsBigEndian);
                    wIndex += 4;
                    for (int j = 0; j < LangCount; j++)
                    {
                        wIndex = PutStringIntoStream(fs, wIndex, Languages[j][i], IsBigEndian);
                    }
                }
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("TextDataBase.SaveToFile | " + ex.GetType().Name + ": " + ex.Message);
                if (fs != null)
                    fs.Close();
                return false;
            }
        }

        private static void WriteString(FileStream fs, int wIndex, string str, bool bigendian)
        {
            for (int i = 0; i < str.Length; i++)
            {
                WriteChar(fs, wIndex + (i * 2), str[i], bigendian);
            }
        }

        private static void WriteChar(FileStream fs, int wIndex, char c, bool bigendian)
        {
            byte[] buff = BitConverter.GetBytes(c);
            if (bigendian)
                Array.Reverse(buff);
            fs.Seek(wIndex, SeekOrigin.Begin);
            fs.Write(buff, 0, 2);
        }

        private static void WriteInteger(FileStream fs, int wIndex, int value, bool bigendian)
        {
            byte[] buff = BitConverter.GetBytes(value);
            if (bigendian)
                Array.Reverse(buff);
            fs.Seek(wIndex, SeekOrigin.Begin);
            fs.Write(buff, 0, 4);
        }

        private static int PutStringIntoStream(FileStream fs, int wIndex, string str, bool bigendian)
        {
            WriteInteger(fs, wIndex, (str.Length * 2) + 2, bigendian); // size
            WriteString(fs, wIndex + 4, str, bigendian); // string
            WriteChar(fs, wIndex + 4 + (str.Length * 2), (char)0, bigendian); // null terminator
            return wIndex + 4 + (str.Length * 2) + 2;
        }

        public void InitializeArrayOfLanguages()
        {
            Languages = new List<string>[LangCount];
            for (int i = 0; i < LangCount; i++)
                Languages[i] = new List<string>();
        }

    }
}
