Public Class frmTime

    Private ExitCode As DialogResult = DialogResult.Cancel

    Public NumUpDowns() As NumericUpDown

    Public FormIsReady As Boolean = False

    Private Sub frmTime_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = ExitCode
    End Sub

    Public Sub New()
        InitializeComponent()
        NumUpDowns = New NumericUpDown() {numTotalHours, numTotalMinutes, numTotalSeconds, numOnlineHours, numOnlineMinutes, numOnlineSeconds}
        For Each nud In NumUpDowns
            AddHandler nud.ValueChanged, AddressOf NumericUpDown_ValueChanged
        Next
        Dim GameSeconds As Integer = Savedata.GetTimeGameTotal()
        ConvertSecondsToTime(GameSeconds, numTotalHours.Value, numTotalMinutes.Value, numTotalSeconds.Value)
        Dim OnlineSeconds As Integer = Savedata.GetTimeOnlinePlay()
        ConvertSecondsToTime(OnlineSeconds, numOnlineHours.Value, numOnlineMinutes.Value, numOnlineSeconds.Value)
        FormIsReady = True
    End Sub

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs)
        If Not FormIsReady Then Exit Sub
        Savedata.SetTimeGameTotal(numTotalHours.Value * 3600 + numTotalMinutes.Value * 60 + numTotalSeconds.Value)
        Savedata.SetTimeOnlinePlay(numOnlineHours.Value * 3600 + numOnlineMinutes.Value * 60 + numOnlineSeconds.Value)
        ExitCode = DialogResult.OK
    End Sub

    Private Sub ConvertSecondsToTime(ByVal timeseconds As Integer, ByRef n_hours As Decimal, ByRef n_minutes As Decimal, ByRef n_seconds As Decimal)
        n_hours = timeseconds \ 3600
        n_minutes = (timeseconds Mod 3600) \ 60
        n_seconds = timeseconds Mod 60
    End Sub

End Class