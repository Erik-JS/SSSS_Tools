<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssistPhrases
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCharacter = New System.Windows.Forms.Label()
        Me.cboCharacter = New System.Windows.Forms.ComboBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.numCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lblPhrase1 = New System.Windows.Forms.Label()
        Me.numPhrase1 = New System.Windows.Forms.NumericUpDown()
        Me.lblDesc1 = New System.Windows.Forms.Label()
        Me.lblCost1 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCost2 = New System.Windows.Forms.Label()
        Me.lblDesc2 = New System.Windows.Forms.Label()
        Me.numPhrase2 = New System.Windows.Forms.NumericUpDown()
        Me.lblPhrase2 = New System.Windows.Forms.Label()
        Me.lblCost3 = New System.Windows.Forms.Label()
        Me.lblDesc3 = New System.Windows.Forms.Label()
        Me.numPhrase3 = New System.Windows.Forms.NumericUpDown()
        Me.lblPhrase3 = New System.Windows.Forms.Label()
        Me.lblCost4 = New System.Windows.Forms.Label()
        Me.lblDesc4 = New System.Windows.Forms.Label()
        Me.numPhrase4 = New System.Windows.Forms.NumericUpDown()
        Me.lblPhrase4 = New System.Windows.Forms.Label()
        Me.lblCost8 = New System.Windows.Forms.Label()
        Me.lblDesc8 = New System.Windows.Forms.Label()
        Me.numPhrase8 = New System.Windows.Forms.NumericUpDown()
        Me.lblCost7 = New System.Windows.Forms.Label()
        Me.lblDesc7 = New System.Windows.Forms.Label()
        Me.numPhrase7 = New System.Windows.Forms.NumericUpDown()
        Me.lblCost6 = New System.Windows.Forms.Label()
        Me.lblDesc6 = New System.Windows.Forms.Label()
        Me.numPhrase6 = New System.Windows.Forms.NumericUpDown()
        Me.lblCost5 = New System.Windows.Forms.Label()
        Me.lblDesc5 = New System.Windows.Forms.Label()
        Me.numPhrase5 = New System.Windows.Forms.NumericUpDown()
        Me.lblPhrase8 = New System.Windows.Forms.Label()
        Me.lblPhrase7 = New System.Windows.Forms.Label()
        Me.lblPhrase6 = New System.Windows.Forms.Label()
        Me.lblPhrase5 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnReplicateCapacity = New System.Windows.Forms.Button()
        Me.btnReplicateAssist = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblCostTotal = New System.Windows.Forms.Label()
        CType(Me.numCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhrase5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharacter
        '
        Me.lblCharacter.AutoSize = True
        Me.lblCharacter.Location = New System.Drawing.Point(24, 19)
        Me.lblCharacter.Name = "lblCharacter"
        Me.lblCharacter.Size = New System.Drawing.Size(56, 13)
        Me.lblCharacter.TabIndex = 0
        Me.lblCharacter.Text = "Character:"
        '
        'cboCharacter
        '
        Me.cboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCharacter.FormattingEnabled = True
        Me.cboCharacter.Items.AddRange(New Object() {"Pegasus Seiya [Bronze Cloth]", "Sagittarius Seiya", "(unused)", "Pegasus Seiya [God Cloth]", "Odin Seiya", "Dragon Shiryu [Bronze Cloth]", "Libra Shiryu", "Dragon Shiryu [God Cloth]", "Cygnus Hyoga [Bronze Cloth]", "Aquarius Hyoga", "Cygnus Hyoga [God Cloth]", "Andromeda Shun [Bronze Cloth]", "Virgo Shun", "Andromeda Shun [God Cloth]", "Phoenix Ikki [Bronze Cloth]", "Leo Ikki", "Phoenix Ikki [God Cloth]", "Unicorn Jabu", "Hydra Ichi", "Eagle Marin", "Ophiuchus Shaina", "Lyra Orphee", "Aries Mu [Gold Cloth]", "Aries Mu [God Cloth]", "Taurus Aldebaran [Gold Cloth]", "Taurus Aldebaran [God Cloth]", "Gemini ???", "Gemini Saga [Gold Cloth]", "Gemini Saga [God Cloth]", "Cancer Deathmask [Gold Cloth]", "Cancer Deathmask [God Cloth]", "Leo Aiolia [Gold Cloth]", "Leo Aiolia [God Cloth]", "Virgo Shaka [Gold Cloth]", "Virgo Shaka [God Cloth]", "Libra Dohko [Gold Cloth]", "Libra Dohko [God Cloth]", "Scorpio Miro [Gold Cloth]", "Scorpio Miro [God Cloth]", "Sagittarius Aiolos [Gold Cloth]", "Sagittarius Aiolos [God Cloth]", "Capricorn Shura [Gold Cloth]", "Capricorn Shura [God Cloth]", "Aquarius Camus [Gold Cloth]", "Aquarius Camus [God Cloth]", "Pisces Aphrodite [Gold Cloth]", "Pisces Aphrodite [God Cloth]", "Aries Shion [Gold Cloth]", "Gemini Kanon", "Sea Dragon Kanon", "Siren Sorento", "Seahorse Baian", "Skylla Io", "Lyumnades Kaasa", "Kraken Isaac", "Chrysaor Krishna", "Sea God Poseidon", "Duhbe Siegfried", "Merak Hägen", "Phecda Thor", "Megrez Alberich", "Alioth Fenrir", "Mizar Syd", "Alcor Bud", "Benetnasch Mime", "Polaris Hilda", "Garuda Aiacos", "Wyvern Rhadamanthys", "Gryphon Minos", "God of Sleep Hypnos", "God of Death Thanatos", "The Underworld God Hades", "The Goddess Athena"})
        Me.cboCharacter.Location = New System.Drawing.Point(27, 35)
        Me.cboCharacter.Name = "cboCharacter"
        Me.cboCharacter.Size = New System.Drawing.Size(326, 21)
        Me.cboCharacter.TabIndex = 1
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(510, 71)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 2
        Me.lblCapacity.Text = "Capacity:"
        '
        'numCapacity
        '
        Me.numCapacity.Enabled = False
        Me.numCapacity.Location = New System.Drawing.Point(567, 69)
        Me.numCapacity.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.numCapacity.Name = "numCapacity"
        Me.numCapacity.Size = New System.Drawing.Size(53, 20)
        Me.numCapacity.TabIndex = 3
        '
        'lblPhrase1
        '
        Me.lblPhrase1.AutoSize = True
        Me.lblPhrase1.Location = New System.Drawing.Point(21, 162)
        Me.lblPhrase1.Name = "lblPhrase1"
        Me.lblPhrase1.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase1.TabIndex = 4
        Me.lblPhrase1.Text = "Phrase 1:"
        '
        'numPhrase1
        '
        Me.numPhrase1.Enabled = False
        Me.numPhrase1.Location = New System.Drawing.Point(93, 160)
        Me.numPhrase1.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase1.Name = "numPhrase1"
        Me.numPhrase1.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase1.TabIndex = 5
        '
        'lblDesc1
        '
        Me.lblDesc1.BackColor = System.Drawing.Color.White
        Me.lblDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc1.ForeColor = System.Drawing.Color.Black
        Me.lblDesc1.Location = New System.Drawing.Point(165, 160)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc1.TabIndex = 6
        Me.lblDesc1.Text = "- - - - -"
        Me.lblDesc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCost1
        '
        Me.lblCost1.BackColor = System.Drawing.Color.White
        Me.lblCost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost1.ForeColor = System.Drawing.Color.Black
        Me.lblCost1.Location = New System.Drawing.Point(625, 160)
        Me.lblCost1.Name = "lblCost1"
        Me.lblCost1.Size = New System.Drawing.Size(27, 18)
        Me.lblCost1.TabIndex = 7
        Me.lblCost1.Text = "0"
        Me.lblCost1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(162, 133)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(89, 13)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Short description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(622, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cost:"
        '
        'lblCost2
        '
        Me.lblCost2.BackColor = System.Drawing.Color.White
        Me.lblCost2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost2.ForeColor = System.Drawing.Color.Black
        Me.lblCost2.Location = New System.Drawing.Point(625, 190)
        Me.lblCost2.Name = "lblCost2"
        Me.lblCost2.Size = New System.Drawing.Size(27, 18)
        Me.lblCost2.TabIndex = 13
        Me.lblCost2.Text = "0"
        Me.lblCost2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc2
        '
        Me.lblDesc2.BackColor = System.Drawing.Color.White
        Me.lblDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc2.ForeColor = System.Drawing.Color.Black
        Me.lblDesc2.Location = New System.Drawing.Point(165, 190)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc2.TabIndex = 12
        Me.lblDesc2.Text = "- - - - -"
        Me.lblDesc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase2
        '
        Me.numPhrase2.Enabled = False
        Me.numPhrase2.Location = New System.Drawing.Point(93, 190)
        Me.numPhrase2.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase2.Name = "numPhrase2"
        Me.numPhrase2.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase2.TabIndex = 11
        '
        'lblPhrase2
        '
        Me.lblPhrase2.AutoSize = True
        Me.lblPhrase2.Location = New System.Drawing.Point(21, 192)
        Me.lblPhrase2.Name = "lblPhrase2"
        Me.lblPhrase2.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase2.TabIndex = 10
        Me.lblPhrase2.Text = "Phrase 2:"
        '
        'lblCost3
        '
        Me.lblCost3.BackColor = System.Drawing.Color.White
        Me.lblCost3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost3.ForeColor = System.Drawing.Color.Black
        Me.lblCost3.Location = New System.Drawing.Point(625, 220)
        Me.lblCost3.Name = "lblCost3"
        Me.lblCost3.Size = New System.Drawing.Size(27, 18)
        Me.lblCost3.TabIndex = 17
        Me.lblCost3.Text = "0"
        Me.lblCost3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc3
        '
        Me.lblDesc3.BackColor = System.Drawing.Color.White
        Me.lblDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc3.ForeColor = System.Drawing.Color.Black
        Me.lblDesc3.Location = New System.Drawing.Point(165, 220)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc3.TabIndex = 16
        Me.lblDesc3.Text = "- - - - -"
        Me.lblDesc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase3
        '
        Me.numPhrase3.Enabled = False
        Me.numPhrase3.Location = New System.Drawing.Point(93, 220)
        Me.numPhrase3.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase3.Name = "numPhrase3"
        Me.numPhrase3.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase3.TabIndex = 15
        '
        'lblPhrase3
        '
        Me.lblPhrase3.AutoSize = True
        Me.lblPhrase3.Location = New System.Drawing.Point(21, 222)
        Me.lblPhrase3.Name = "lblPhrase3"
        Me.lblPhrase3.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase3.TabIndex = 14
        Me.lblPhrase3.Text = "Phrase 3:"
        '
        'lblCost4
        '
        Me.lblCost4.BackColor = System.Drawing.Color.White
        Me.lblCost4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost4.ForeColor = System.Drawing.Color.Black
        Me.lblCost4.Location = New System.Drawing.Point(626, 250)
        Me.lblCost4.Name = "lblCost4"
        Me.lblCost4.Size = New System.Drawing.Size(27, 18)
        Me.lblCost4.TabIndex = 21
        Me.lblCost4.Text = "0"
        Me.lblCost4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc4
        '
        Me.lblDesc4.BackColor = System.Drawing.Color.White
        Me.lblDesc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc4.ForeColor = System.Drawing.Color.Black
        Me.lblDesc4.Location = New System.Drawing.Point(165, 250)
        Me.lblDesc4.Name = "lblDesc4"
        Me.lblDesc4.Size = New System.Drawing.Size(455, 18)
        Me.lblDesc4.TabIndex = 20
        Me.lblDesc4.Text = "- - - - -"
        Me.lblDesc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase4
        '
        Me.numPhrase4.Enabled = False
        Me.numPhrase4.Location = New System.Drawing.Point(93, 250)
        Me.numPhrase4.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase4.Name = "numPhrase4"
        Me.numPhrase4.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase4.TabIndex = 19
        '
        'lblPhrase4
        '
        Me.lblPhrase4.AutoSize = True
        Me.lblPhrase4.Location = New System.Drawing.Point(21, 252)
        Me.lblPhrase4.Name = "lblPhrase4"
        Me.lblPhrase4.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase4.TabIndex = 18
        Me.lblPhrase4.Text = "Phrase 4:"
        '
        'lblCost8
        '
        Me.lblCost8.BackColor = System.Drawing.Color.White
        Me.lblCost8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost8.ForeColor = System.Drawing.Color.Black
        Me.lblCost8.Location = New System.Drawing.Point(625, 370)
        Me.lblCost8.Name = "lblCost8"
        Me.lblCost8.Size = New System.Drawing.Size(27, 18)
        Me.lblCost8.TabIndex = 33
        Me.lblCost8.Text = "0"
        Me.lblCost8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc8
        '
        Me.lblDesc8.BackColor = System.Drawing.Color.White
        Me.lblDesc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc8.ForeColor = System.Drawing.Color.Black
        Me.lblDesc8.Location = New System.Drawing.Point(165, 370)
        Me.lblDesc8.Name = "lblDesc8"
        Me.lblDesc8.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc8.TabIndex = 32
        Me.lblDesc8.Text = "- - - - -"
        Me.lblDesc8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase8
        '
        Me.numPhrase8.Enabled = False
        Me.numPhrase8.Location = New System.Drawing.Point(93, 370)
        Me.numPhrase8.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase8.Name = "numPhrase8"
        Me.numPhrase8.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase8.TabIndex = 31
        '
        'lblCost7
        '
        Me.lblCost7.BackColor = System.Drawing.Color.White
        Me.lblCost7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost7.ForeColor = System.Drawing.Color.Black
        Me.lblCost7.Location = New System.Drawing.Point(625, 340)
        Me.lblCost7.Name = "lblCost7"
        Me.lblCost7.Size = New System.Drawing.Size(27, 18)
        Me.lblCost7.TabIndex = 30
        Me.lblCost7.Text = "0"
        Me.lblCost7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc7
        '
        Me.lblDesc7.BackColor = System.Drawing.Color.White
        Me.lblDesc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc7.ForeColor = System.Drawing.Color.Black
        Me.lblDesc7.Location = New System.Drawing.Point(165, 340)
        Me.lblDesc7.Name = "lblDesc7"
        Me.lblDesc7.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc7.TabIndex = 29
        Me.lblDesc7.Text = "- - - - -"
        Me.lblDesc7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase7
        '
        Me.numPhrase7.Enabled = False
        Me.numPhrase7.Location = New System.Drawing.Point(93, 340)
        Me.numPhrase7.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase7.Name = "numPhrase7"
        Me.numPhrase7.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase7.TabIndex = 28
        '
        'lblCost6
        '
        Me.lblCost6.BackColor = System.Drawing.Color.White
        Me.lblCost6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost6.ForeColor = System.Drawing.Color.Black
        Me.lblCost6.Location = New System.Drawing.Point(625, 310)
        Me.lblCost6.Name = "lblCost6"
        Me.lblCost6.Size = New System.Drawing.Size(27, 18)
        Me.lblCost6.TabIndex = 27
        Me.lblCost6.Text = "0"
        Me.lblCost6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc6
        '
        Me.lblDesc6.BackColor = System.Drawing.Color.White
        Me.lblDesc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc6.ForeColor = System.Drawing.Color.Black
        Me.lblDesc6.Location = New System.Drawing.Point(165, 310)
        Me.lblDesc6.Name = "lblDesc6"
        Me.lblDesc6.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc6.TabIndex = 26
        Me.lblDesc6.Text = "- - - - -"
        Me.lblDesc6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase6
        '
        Me.numPhrase6.Enabled = False
        Me.numPhrase6.Location = New System.Drawing.Point(93, 310)
        Me.numPhrase6.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase6.Name = "numPhrase6"
        Me.numPhrase6.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase6.TabIndex = 25
        '
        'lblCost5
        '
        Me.lblCost5.BackColor = System.Drawing.Color.White
        Me.lblCost5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost5.ForeColor = System.Drawing.Color.Black
        Me.lblCost5.Location = New System.Drawing.Point(625, 280)
        Me.lblCost5.Name = "lblCost5"
        Me.lblCost5.Size = New System.Drawing.Size(27, 18)
        Me.lblCost5.TabIndex = 24
        Me.lblCost5.Text = "0"
        Me.lblCost5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc5
        '
        Me.lblDesc5.BackColor = System.Drawing.Color.White
        Me.lblDesc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc5.ForeColor = System.Drawing.Color.Black
        Me.lblDesc5.Location = New System.Drawing.Point(165, 280)
        Me.lblDesc5.Name = "lblDesc5"
        Me.lblDesc5.Size = New System.Drawing.Size(454, 18)
        Me.lblDesc5.TabIndex = 23
        Me.lblDesc5.Text = "- - - - -"
        Me.lblDesc5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numPhrase5
        '
        Me.numPhrase5.Enabled = False
        Me.numPhrase5.Location = New System.Drawing.Point(93, 280)
        Me.numPhrase5.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
        Me.numPhrase5.Name = "numPhrase5"
        Me.numPhrase5.Size = New System.Drawing.Size(60, 20)
        Me.numPhrase5.TabIndex = 22
        '
        'lblPhrase8
        '
        Me.lblPhrase8.AutoSize = True
        Me.lblPhrase8.Location = New System.Drawing.Point(21, 372)
        Me.lblPhrase8.Name = "lblPhrase8"
        Me.lblPhrase8.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase8.TabIndex = 37
        Me.lblPhrase8.Text = "Phrase 8:"
        '
        'lblPhrase7
        '
        Me.lblPhrase7.AutoSize = True
        Me.lblPhrase7.Location = New System.Drawing.Point(21, 342)
        Me.lblPhrase7.Name = "lblPhrase7"
        Me.lblPhrase7.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase7.TabIndex = 36
        Me.lblPhrase7.Text = "Phrase 7:"
        '
        'lblPhrase6
        '
        Me.lblPhrase6.AutoSize = True
        Me.lblPhrase6.Location = New System.Drawing.Point(21, 312)
        Me.lblPhrase6.Name = "lblPhrase6"
        Me.lblPhrase6.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase6.TabIndex = 35
        Me.lblPhrase6.Text = "Phrase 6:"
        '
        'lblPhrase5
        '
        Me.lblPhrase5.AutoSize = True
        Me.lblPhrase5.Location = New System.Drawing.Point(21, 282)
        Me.lblPhrase5.Name = "lblPhrase5"
        Me.lblPhrase5.Size = New System.Drawing.Size(52, 13)
        Me.lblPhrase5.TabIndex = 34
        Me.lblPhrase5.Text = "Phrase 5:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(90, 133)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 38
        Me.lblID.Text = "ID:"
        '
        'btnReplicateCapacity
        '
        Me.btnReplicateCapacity.Enabled = False
        Me.btnReplicateCapacity.Location = New System.Drawing.Point(501, 95)
        Me.btnReplicateCapacity.Name = "btnReplicateCapacity"
        Me.btnReplicateCapacity.Size = New System.Drawing.Size(119, 23)
        Me.btnReplicateCapacity.TabIndex = 39
        Me.btnReplicateCapacity.Text = "Replicate capacity"
        Me.btnReplicateCapacity.UseVisualStyleBackColor = True
        '
        'btnReplicateAssist
        '
        Me.btnReplicateAssist.Enabled = False
        Me.btnReplicateAssist.Location = New System.Drawing.Point(187, 400)
        Me.btnReplicateAssist.Name = "btnReplicateAssist"
        Me.btnReplicateAssist.Size = New System.Drawing.Size(168, 25)
        Me.btnReplicateAssist.TabIndex = 40
        Me.btnReplicateAssist.Text = "Replicate assist phrases"
        Me.btnReplicateAssist.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(24, 59)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(16, 13)
        Me.lblCategory.TabIndex = 41
        Me.lblCategory.Text = "..."
        '
        'lblCostTotal
        '
        Me.lblCostTotal.AutoSize = True
        Me.lblCostTotal.Location = New System.Drawing.Point(587, 406)
        Me.lblCostTotal.Name = "lblCostTotal"
        Me.lblCostTotal.Size = New System.Drawing.Size(66, 13)
        Me.lblCostTotal.TabIndex = 42
        Me.lblCostTotal.Text = "Total cost: 0"
        '
        'frmAssistPhrases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 458)
        Me.Controls.Add(Me.lblCostTotal)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.btnReplicateAssist)
        Me.Controls.Add(Me.btnReplicateCapacity)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblPhrase8)
        Me.Controls.Add(Me.lblPhrase7)
        Me.Controls.Add(Me.lblPhrase6)
        Me.Controls.Add(Me.lblPhrase5)
        Me.Controls.Add(Me.lblCost8)
        Me.Controls.Add(Me.lblDesc8)
        Me.Controls.Add(Me.numPhrase8)
        Me.Controls.Add(Me.lblCost7)
        Me.Controls.Add(Me.lblDesc7)
        Me.Controls.Add(Me.numPhrase7)
        Me.Controls.Add(Me.lblCost6)
        Me.Controls.Add(Me.lblDesc6)
        Me.Controls.Add(Me.numPhrase6)
        Me.Controls.Add(Me.lblCost5)
        Me.Controls.Add(Me.lblDesc5)
        Me.Controls.Add(Me.numPhrase5)
        Me.Controls.Add(Me.lblCost4)
        Me.Controls.Add(Me.lblDesc4)
        Me.Controls.Add(Me.numPhrase4)
        Me.Controls.Add(Me.lblPhrase4)
        Me.Controls.Add(Me.lblCost3)
        Me.Controls.Add(Me.lblDesc3)
        Me.Controls.Add(Me.numPhrase3)
        Me.Controls.Add(Me.lblPhrase3)
        Me.Controls.Add(Me.lblCost2)
        Me.Controls.Add(Me.lblDesc2)
        Me.Controls.Add(Me.numPhrase2)
        Me.Controls.Add(Me.lblPhrase2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblCost1)
        Me.Controls.Add(Me.lblDesc1)
        Me.Controls.Add(Me.numPhrase1)
        Me.Controls.Add(Me.lblPhrase1)
        Me.Controls.Add(Me.numCapacity)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.cboCharacter)
        Me.Controls.Add(Me.lblCharacter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAssistPhrases"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assist Phrases - Equip"
        CType(Me.numCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhrase5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCharacter As Label
    Friend WithEvents cboCharacter As ComboBox
    Friend WithEvents lblCapacity As Label
    Friend WithEvents numCapacity As NumericUpDown
    Friend WithEvents lblPhrase1 As Label
    Friend WithEvents numPhrase1 As NumericUpDown
    Friend WithEvents lblDesc1 As Label
    Friend WithEvents lblCost1 As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCost2 As Label
    Friend WithEvents lblDesc2 As Label
    Friend WithEvents numPhrase2 As NumericUpDown
    Friend WithEvents lblPhrase2 As Label
    Friend WithEvents lblCost3 As Label
    Friend WithEvents lblDesc3 As Label
    Friend WithEvents numPhrase3 As NumericUpDown
    Friend WithEvents lblPhrase3 As Label
    Friend WithEvents lblCost4 As Label
    Friend WithEvents lblDesc4 As Label
    Friend WithEvents numPhrase4 As NumericUpDown
    Friend WithEvents lblPhrase4 As Label
    Friend WithEvents lblCost8 As Label
    Friend WithEvents lblDesc8 As Label
    Friend WithEvents numPhrase8 As NumericUpDown
    Friend WithEvents lblCost7 As Label
    Friend WithEvents lblDesc7 As Label
    Friend WithEvents numPhrase7 As NumericUpDown
    Friend WithEvents lblCost6 As Label
    Friend WithEvents lblDesc6 As Label
    Friend WithEvents numPhrase6 As NumericUpDown
    Friend WithEvents lblCost5 As Label
    Friend WithEvents lblDesc5 As Label
    Friend WithEvents numPhrase5 As NumericUpDown
    Friend WithEvents lblPhrase8 As Label
    Friend WithEvents lblPhrase7 As Label
    Friend WithEvents lblPhrase6 As Label
    Friend WithEvents lblPhrase5 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnReplicateCapacity As Button
    Friend WithEvents btnReplicateAssist As Button
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblCostTotal As Label
End Class
