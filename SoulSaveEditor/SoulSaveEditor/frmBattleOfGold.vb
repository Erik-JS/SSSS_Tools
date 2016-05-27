Public Class frmBattleOfGold

    Private ExitCode As Windows.Forms.DialogResult = Windows.Forms.DialogResult.Cancel

    Public ComboBoxes() As ComboBox

    Public CheckBoxes() As CheckBox

    Public FormIsReady As Boolean = False

    Public Sub New()
        InitializeComponent()
        ComboBoxes = New ComboBox() {cboAries1, cboAries2, cboAries3, cboTaurus1, cboTaurus2, cboTaurus3, cboGemini1, cboGemini2, cboGemini3,
                                     cboCancer1, cboCancer2, cboCancer3, cboLeo1, cboLeo2, cboLeo3, cboVirgo1, cboVirgo2, cboVirgo3,
                                     cboLibra1, cboLibra2, cboLibra3, cboScorpio1, cboScorpio2, cboScorpio3, cboSagit1, cboSagit2, cboSagit3,
                                     cboCapri1, cboCapri2, cboCapri3, cboAqu1, cboAqu2, cboAqu3, cboPisces1, cboPisces2, cboPisces3}
        CheckBoxes = New CheckBox() {CheckBox1, CheckBox2, CheckBox3}
        For I As Integer = 0 To ComboBoxes.Length - 1
            ComboBoxes(I).Tag = I
            ComboBoxes(I).SelectedIndex = Savedata.GetBattleOfGoldVar(I)
            AddHandler ComboBoxes(I).SelectedIndexChanged, AddressOf ComboBoxSelectedIndexChanged
        Next I
        For I As Integer = 0 To CheckBoxes.Length - 1
            CheckBoxes(I).Tag = ComboBoxes.Length + I
            CheckBoxes(I).Checked = (Savedata.GetBattleOfGoldVar(CheckBoxes(I).Tag) = 1)
            AddHandler CheckBoxes(I).CheckedChanged, AddressOf CheckBoxCheckedChanged
        Next I
        Button1.Text = "Torches: " & Savedata.GetTorches()
        Button2.Text = "Point Bursts: " & Savedata.GetPointBursts()
        FormIsReady = True
    End Sub

    Private Sub ComboBoxSelectedIndexChanged(sender As Object, e As EventArgs)
        If Not FormIsReady Then Exit Sub
        Dim cb As ComboBox = sender
        Savedata.SetBattleOfGoldVar(cb.Tag, cb.SelectedIndex)
        ExitCode = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub CheckBoxCheckedChanged(sender As Object, e As EventArgs)
        If Not FormIsReady Then Exit Sub
        Dim chk As CheckBox = sender
        Savedata.SetBattleOfGoldVar(chk.Tag, If(chk.Checked, 1, 0))
        ExitCode = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmBattleOfGold_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = ExitCode
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = InputBox("Enter a number between 0 and 127", "Torches")
        Dim qtd As Integer
        If Not Integer.TryParse(s, qtd) Then Exit Sub
        If qtd > 127 Or qtd < 0 Then Exit Sub
        Savedata.SetTorches(qtd)
        Button1.Text = "Torches: " & qtd
        ExitCode = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As String = InputBox("Enter a number between 0 and 127", "Point Bursts")
        Dim qtd As Integer
        If Not Integer.TryParse(s, qtd) Then Exit Sub
        If qtd > 127 Or qtd < 0 Then Exit Sub
        Savedata.SetPointBursts(qtd)
        Button2.Text = "Point Bursts: " & qtd
        ExitCode = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmBattleOfGold_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.NumPad0
                ChangeAllComboBoxes(0)
            Case Keys.NumPad1
                ChangeAllComboBoxes(1)
            Case Keys.NumPad2
                ChangeAllComboBoxes(2)
            Case Keys.NumPad3
                ChangeAllComboBoxes(3)
            Case Keys.NumPad4
                ChangeAllComboBoxes(4)
        End Select
    End Sub

    Private Sub ChangeAllComboBoxes(ByVal index As Integer)
        For I As Integer = 0 To ComboBoxes.Length - 1
            ComboBoxes(I).SelectedIndex = index
        Next I
    End Sub

End Class