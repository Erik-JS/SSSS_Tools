Public Class frmAssistPhrases

    Private ExitCode As DialogResult = DialogResult.Cancel

    Private numPhraseArray() As NumericUpDown
    Private lblDescArray() As Label
    Private lblCostArray() As Label
    Private IsComboBoxChangingNumValue As Boolean = False
    Private ToolTipControl As New ToolTip

    Private Sub frmAssistPhrases_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmAssistPhrases_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = ExitCode
    End Sub

    Public Sub New()
        InitializeComponent()
        numPhraseArray = {numPhrase1, numPhrase2, numPhrase3, numPhrase4, numPhrase5, numPhrase6, numPhrase7, numPhrase8}
        lblDescArray = {lblDesc1, lblDesc2, lblDesc3, lblDesc4, lblDesc5, lblDesc6, lblDesc7, lblDesc8}
        lblCostArray = {lblCost1, lblCost2, lblCost3, lblCost4, lblCost5, lblCost6, lblCost7, lblCost8}
        For I As Integer = 0 To 7 Step 1
            numPhraseArray(I).Tag = I
        Next I
        UpdateLabels()
    End Sub

    Private Sub NumPhrase_ValueChanged(sender As Object, e As EventArgs) Handles numPhrase1.ValueChanged, numPhrase2.ValueChanged,
    numPhrase3.ValueChanged, numPhrase4.ValueChanged, numPhrase5.ValueChanged, numPhrase6.ValueChanged, numPhrase7.ValueChanged, numPhrase8.ValueChanged
        Dim num = DirectCast(sender, NumericUpDown)
        Dim index = DirectCast(num.Tag, Integer)
        UpdateLabels()
        If IsComboBoxChangingNumValue Then Exit Sub
        Savedata.SetEquippedAssistPhrase(cboCharacter.SelectedIndex, index, num.Value)
        ExitCode = DialogResult.OK
    End Sub

    Private Sub UpdateLabels()
        Dim TotalCost() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}
        For Each num As NumericUpDown In numPhraseArray
            Dim index = DirectCast(num.Tag, Integer)
            If num.Value = 0 Then
                lblDescArray(index).Text = "«none»"
                ToolTipControl.SetToolTip(lblDescArray(index), Nothing)
                lblCostArray(index).Text = "0"
            Else
                lblDescArray(index).Text = Descriptions.AssistPhrases(num.Value - 1).ShortDescription
                ToolTipControl.SetToolTip(lblDescArray(index), Descriptions.AssistPhrases(num.Value - 1).Description)
                lblCostArray(index).Text = Descriptions.AssistPhrases(num.Value - 1).Cost.ToString()
                TotalCost(index) = Descriptions.AssistPhrases(num.Value - 1).Cost
            End If
        Next num
        lblCostTotal.Text = "Total cost: " & TotalCost.Sum().ToString()
    End Sub

    Private Sub cboCharacter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCharacter.SelectedIndexChanged
        IsComboBoxChangingNumValue = True
        For I As Integer = 0 To numPhraseArray.Length - 1 Step 1
            numPhraseArray(I).Value = Savedata.GetEquippedAssistPhrase(cboCharacter.SelectedIndex, I)
            numPhraseArray(I).Enabled = True
        Next I
        numCapacity.Value = Savedata.GetCharAssistPhraseSlotCapacity(cboCharacter.SelectedIndex)
        numCapacity.Enabled = True
        btnReplicateAssist.Enabled = True
        btnReplicateCapacity.Enabled = True
        IsComboBoxChangingNumValue = False
    End Sub

    Private Sub numCapacity_ValueChanged(sender As Object, e As EventArgs) Handles numCapacity.ValueChanged
        If IsComboBoxChangingNumValue Then Exit Sub
        Savedata.SetCharAssistPhraseSlotCapacity(cboCharacter.SelectedIndex, numCapacity.Value)
        ExitCode = DialogResult.OK
    End Sub

    Private Sub btnReplicateCapacity_Click(sender As Object, e As EventArgs) Handles btnReplicateCapacity.Click
        Dim MB = MessageBox.Show("This will apply current character's slot capacity to all characters, new capacity will be " & numCapacity.Value.ToString() & vbCrLf & "Proceed?", "Replicate capacity", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MB = DialogResult.No Then Exit Sub
        For I As Integer = 0 To cboCharacter.Items.Count - 1 Step 1
            Savedata.SetCharAssistPhraseSlotCapacity(I, numCapacity.Value)
        Next I
        ExitCode = DialogResult.OK
    End Sub

    Private Sub btnReplicateAssist_Click(sender As Object, e As EventArgs) Handles btnReplicateAssist.Click
        Dim MB = MessageBox.Show("The current set of assist phrases will be applied to all characters." & vbCrLf & "Proceed?", "Replicate assist phrases", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MB = DialogResult.No Then Exit Sub
        For C As Integer = 0 To cboCharacter.Items.Count - 1 Step 1
            For I As Integer = 0 To 7 Step 1
                Savedata.SetEquippedAssistPhrase(C, I, numPhraseArray(I).Value)
            Next I
        Next C
        ExitCode = DialogResult.OK
    End Sub
End Class