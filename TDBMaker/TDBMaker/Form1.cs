using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDBMaker
{
    public partial class Form1 : Form
    {

        private static int ConversionDoneCount;
        private static int IgnoreCount;

        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            bool suppress = false;
            if (droppedFiles.Length >= 10)
            {
                DialogResult dr = MessageBox.Show("You dropped " + droppedFiles.Length + " items into TDB Maker. Individual messages about overwriting and conversion result for all items will be suppressed.", "TDB Maker", MessageBoxButtons.OKCancel);
                if (dr == System.Windows.Forms.DialogResult.Cancel)
                    return;
                suppress = true;
            }
            ConvertItems(droppedFiles, suppress);
        }

        private void ConvertItems(string[] itemArray, bool suppress)
        {
            ConversionDoneCount = 0;
            IgnoreCount = 0;
            Cursor.Current = Cursors.WaitCursor;
            foreach (string file in itemArray)
            {
                if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                {
                    IgnoreCount++;
                    if (!suppress)
                        MessageBox.Show(file + "\n\nThis item cannot be processed because it is a directory.");
                    continue;
                }
                string ext = Path.GetExtension(file).ToLower();
                string dir = Path.GetDirectoryName(file);
                string nameonly = Path.GetFileNameWithoutExtension(file);
                if (ext == ".tdb")
                {
                    ConvertToXML(file, Path.Combine(dir, nameonly + ".xml"), !suppress, suppress);
                }
                else if (ext == ".xml")
                {
                    ConvertToTDB(file, Path.Combine(dir, nameonly + ".tdb"), !suppress, suppress);
                }
                else
                {
                    IgnoreCount++;
                    if (!suppress)
                        MessageBox.Show(file + "\n\nThis item cannot be processed because it has no .tdb or .xml extension!");
                }
            }
            Cursor.Current = Cursors.Default;
            if (itemArray.Length <= 1)
                return;
            string strReport = "Item count: " + itemArray.Length + "\n";
            strReport += "Conversions done: " + ConversionDoneCount + "\n";
            strReport += "Conversions failed: " + (itemArray.Length - ConversionDoneCount - IgnoreCount) + "\n";
            strReport += "Ignored: " + IgnoreCount;
            MessageBox.Show(strReport, "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void btnTdb2Xml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TDB|*.tdb";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            sfd.FileName = Path.GetFileNameWithoutExtension(ofd.FileName) + ".xml";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            ConvertToXML(ofd.FileName, sfd.FileName);
        }

        private void btnXml2Tdb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TDB|*.tdb";
            sfd.FileName = Path.GetFileNameWithoutExtension(ofd.FileName) + ".tdb";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            ConvertToTDB(ofd.FileName, sfd.FileName);
        }

        public static void ConvertToTDB(string source, string destination, bool overwritewarning = false, bool suppressendmessage = false)
        {
            if (overwritewarning && File.Exists(destination))
            {
                DialogResult dr = MessageBox.Show(destination + "\n\nThis file is about to be overwritten. Proceed?", "Overwrite file", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;
            }
            if (TDBHandler.Xml2Tdb(source, destination))
            {
                if (!suppressendmessage)
                    MessageBox.Show("Done: " + Path.GetFileName(source) + " => " + Path.GetFileName(destination), "Xml2Tdb");
                ConversionDoneCount++;
            }
            else
            {
                if (!suppressendmessage)
                    MessageBox.Show("Failed: " + Path.GetFileName(source) + " => " + Path.GetFileName(destination), "Xml2Tdb");
            }
        }

        public static void ConvertToXML(string source, string destination, bool overwritewarning = false, bool suppressendmessage = false)
        {
            if (overwritewarning && File.Exists(destination))
            {
                DialogResult dr = MessageBox.Show(destination + "\n\nThis file is about to be overwritten. Proceed?", "Overwrite file", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;
            }
            if (TDBHandler.Tdb2Xml(source, destination))
            {
                if(!suppressendmessage)
                    MessageBox.Show("Done: " + Path.GetFileName(source) + " => " + Path.GetFileName(destination), "Tdb2Xml");
                ConversionDoneCount++;
            }
            else
            {
                if(!suppressendmessage)
                    MessageBox.Show("Failed: " + Path.GetFileName(source) + " => " + Path.GetFileName(destination), "Tdb2Xml");
            }
        }

    }
}
