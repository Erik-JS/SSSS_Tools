namespace TDBMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTdb2Xml = new System.Windows.Forms.Button();
            this.btnXml2Tdb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTdb2Xml
            // 
            this.btnTdb2Xml.Location = new System.Drawing.Point(12, 12);
            this.btnTdb2Xml.Name = "btnTdb2Xml";
            this.btnTdb2Xml.Size = new System.Drawing.Size(302, 42);
            this.btnTdb2Xml.TabIndex = 0;
            this.btnTdb2Xml.Text = "Convert TDB into XML";
            this.btnTdb2Xml.UseVisualStyleBackColor = true;
            this.btnTdb2Xml.Click += new System.EventHandler(this.btnTdb2Xml_Click);
            // 
            // btnXml2Tdb
            // 
            this.btnXml2Tdb.Location = new System.Drawing.Point(12, 63);
            this.btnXml2Tdb.Name = "btnXml2Tdb";
            this.btnXml2Tdb.Size = new System.Drawing.Size(302, 42);
            this.btnXml2Tdb.TabIndex = 1;
            this.btnXml2Tdb.Text = "Convert XML into TDB";
            this.btnXml2Tdb.UseVisualStyleBackColor = true;
            this.btnXml2Tdb.Click += new System.EventHandler(this.btnXml2Tdb_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click a button above or drag and drop one or more files into this window.";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXml2Tdb);
            this.Controls.Add(this.btnTdb2Xml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDB Maker by Erik JS";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTdb2Xml;
        private System.Windows.Forms.Button btnXml2Tdb;
        private System.Windows.Forms.Label label1;
    }
}

