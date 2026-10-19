<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTime
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
        Me.numTotalMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numTotalHours = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numTotalSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numOnlineSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numOnlineHours = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numOnlineMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.numTotalMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOnlineSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOnlineHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOnlineMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Time Played:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hours:"
        '
        'numTotalMinutes
        '
        Me.numTotalMinutes.Location = New System.Drawing.Point(110, 54)
        Me.numTotalMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numTotalMinutes.Name = "numTotalMinutes"
        Me.numTotalMinutes.Size = New System.Drawing.Size(55, 20)
        Me.numTotalMinutes.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Minutes:"
        '
        'numTotalHours
        '
        Me.numTotalHours.Location = New System.Drawing.Point(49, 54)
        Me.numTotalHours.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numTotalHours.Name = "numTotalHours"
        Me.numTotalHours.Size = New System.Drawing.Size(55, 20)
        Me.numTotalHours.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Seconds:"
        '
        'numTotalSeconds
        '
        Me.numTotalSeconds.Location = New System.Drawing.Point(171, 54)
        Me.numTotalSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numTotalSeconds.Name = "numTotalSeconds"
        Me.numTotalSeconds.Size = New System.Drawing.Size(55, 20)
        Me.numTotalSeconds.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Online Time Played:"
        '
        'numOnlineSeconds
        '
        Me.numOnlineSeconds.Location = New System.Drawing.Point(171, 131)
        Me.numOnlineSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numOnlineSeconds.Name = "numOnlineSeconds"
        Me.numOnlineSeconds.Size = New System.Drawing.Size(55, 20)
        Me.numOnlineSeconds.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Seconds:"
        '
        'numOnlineHours
        '
        Me.numOnlineHours.Location = New System.Drawing.Point(49, 131)
        Me.numOnlineHours.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numOnlineHours.Name = "numOnlineHours"
        Me.numOnlineHours.Size = New System.Drawing.Size(55, 20)
        Me.numOnlineHours.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Minutes:"
        '
        'numOnlineMinutes
        '
        Me.numOnlineMinutes.Location = New System.Drawing.Point(110, 131)
        Me.numOnlineMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numOnlineMinutes.Name = "numOnlineMinutes"
        Me.numOnlineMinutes.Size = New System.Drawing.Size(55, 20)
        Me.numOnlineMinutes.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Hours:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Press ESC to close this window."
        '
        'frmTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 197)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.numOnlineSeconds)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numOnlineHours)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numOnlineMinutes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numTotalSeconds)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numTotalHours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numTotalMinutes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Time Played"
        CType(Me.numTotalMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOnlineSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOnlineHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOnlineMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numTotalMinutes As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents numTotalHours As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numTotalSeconds As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numOnlineSeconds As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numOnlineHours As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents numOnlineMinutes As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
