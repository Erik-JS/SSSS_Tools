<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chklist1 = New System.Windows.Forms.CheckedListBox()
        Me.btnEnableAll = New System.Windows.Forms.Button()
        Me.btnDisableAll = New System.Windows.Forms.Button()
        Me.btnInvertAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 483)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You may press ESC to close this window."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(469, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Changes are automatically saved to memory. To undo everything, please reopen the " & _
    "savedata file."
        '
        'chklist1
        '
        Me.chklist1.FormattingEnabled = True
        Me.chklist1.Location = New System.Drawing.Point(12, 12)
        Me.chklist1.Name = "chklist1"
        Me.chklist1.ScrollAlwaysVisible = True
        Me.chklist1.Size = New System.Drawing.Size(488, 424)
        Me.chklist1.TabIndex = 2
        '
        'btnEnableAll
        '
        Me.btnEnableAll.Location = New System.Drawing.Point(129, 442)
        Me.btnEnableAll.Name = "btnEnableAll"
        Me.btnEnableAll.Size = New System.Drawing.Size(75, 23)
        Me.btnEnableAll.TabIndex = 3
        Me.btnEnableAll.Text = "Enable All"
        Me.btnEnableAll.UseVisualStyleBackColor = True
        '
        'btnDisableAll
        '
        Me.btnDisableAll.Location = New System.Drawing.Point(210, 442)
        Me.btnDisableAll.Name = "btnDisableAll"
        Me.btnDisableAll.Size = New System.Drawing.Size(75, 23)
        Me.btnDisableAll.TabIndex = 4
        Me.btnDisableAll.Text = "Disable All"
        Me.btnDisableAll.UseVisualStyleBackColor = True
        '
        'btnInvertAll
        '
        Me.btnInvertAll.Location = New System.Drawing.Point(291, 442)
        Me.btnInvertAll.Name = "btnInvertAll"
        Me.btnInvertAll.Size = New System.Drawing.Size(75, 23)
        Me.btnInvertAll.TabIndex = 5
        Me.btnInvertAll.Text = "Invert All"
        Me.btnInvertAll.UseVisualStyleBackColor = True
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 503)
        Me.Controls.Add(Me.btnInvertAll)
        Me.Controls.Add(Me.btnDisableAll)
        Me.Controls.Add(Me.btnEnableAll)
        Me.Controls.Add(Me.chklist1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCollection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Collection Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chklist1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnEnableAll As System.Windows.Forms.Button
    Friend WithEvents btnDisableAll As System.Windows.Forms.Button
    Friend WithEvents btnInvertAll As System.Windows.Forms.Button
End Class
