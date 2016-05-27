<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayableCharactersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayableStagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CosmoPointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.ProgressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BattleOfGoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CollectionToolStripMenuItem, Me.StatsToolStripMenuItem, Me.ProgressToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(527, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.mnuSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as..."
        '
        'mnuSeparator1
        '
        Me.mnuSeparator1.Name = "mnuSeparator1"
        Me.mnuSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CollectionToolStripMenuItem
        '
        Me.CollectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayableCharactersToolStripMenuItem, Me.PlayableStagesToolStripMenuItem})
        Me.CollectionToolStripMenuItem.Name = "CollectionToolStripMenuItem"
        Me.CollectionToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.CollectionToolStripMenuItem.Text = "Collection"
        '
        'PlayableCharactersToolStripMenuItem
        '
        Me.PlayableCharactersToolStripMenuItem.Name = "PlayableCharactersToolStripMenuItem"
        Me.PlayableCharactersToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PlayableCharactersToolStripMenuItem.Text = "Playable Characters"
        '
        'PlayableStagesToolStripMenuItem
        '
        Me.PlayableStagesToolStripMenuItem.Name = "PlayableStagesToolStripMenuItem"
        Me.PlayableStagesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PlayableStagesToolStripMenuItem.Text = "Playable Stages"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CosmoPointsToolStripMenuItem})
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.StatsToolStripMenuItem.Text = "Stats"
        '
        'CosmoPointsToolStripMenuItem
        '
        Me.CosmoPointsToolStripMenuItem.Name = "CosmoPointsToolStripMenuItem"
        Me.CosmoPointsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CosmoPointsToolStripMenuItem.Text = "Cosmo Points"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File:"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.BackColor = System.Drawing.Color.White
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.ForeColor = System.Drawing.Color.Blue
        Me.lblFile.Location = New System.Drawing.Point(12, 50)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(247, 13)
        Me.lblFile.TabIndex = 2
        Me.lblFile.Text = "Please go to File -> Open, or press Ctrl+O."
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.Location = New System.Drawing.Point(12, 192)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(75, 13)
        Me.lblBuild.TabIndex = 3
        Me.lblBuild.Text = "Build date......."
        '
        'lblPlatform
        '
        Me.lblPlatform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(434, 187)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(93, 30)
        Me.lblPlatform.TabIndex = 4
        Me.lblPlatform.Text = "..."
        Me.lblPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ProgressToolStripMenuItem
        '
        Me.ProgressToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BattleOfGoldToolStripMenuItem})
        Me.ProgressToolStripMenuItem.Name = "ProgressToolStripMenuItem"
        Me.ProgressToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ProgressToolStripMenuItem.Text = "Progress"
        '
        'BattleOfGoldToolStripMenuItem
        '
        Me.BattleOfGoldToolStripMenuItem.Name = "BattleOfGoldToolStripMenuItem"
        Me.BattleOfGoldToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BattleOfGoldToolStripMenuItem.Text = "Battle of Gold"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 214)
        Me.Controls.Add(Me.lblPlatform)
        Me.Controls.Add(Me.lblBuild)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soul Save Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayableCharactersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CosmoPointsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents lblBuild As System.Windows.Forms.Label
    Friend WithEvents lblPlatform As System.Windows.Forms.Label
    Friend WithEvents PlayableStagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BattleOfGoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
