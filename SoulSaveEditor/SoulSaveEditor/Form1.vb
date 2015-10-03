Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text &= " " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
        CollectionToolStripMenuItem.Enabled = False
        StatsToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Enabled = False
        lblBuild.Text = RetrieveAppLinkerTimestampString()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openDialog As New OpenFileDialog

        openDialog.Filter = "*.DAT|*.DAT"
        If openDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub

        If Savedata.LoadFromFile(openDialog.FileName) Then
            CollectionToolStripMenuItem.Enabled = True
            StatsToolStripMenuItem.Enabled = True
            SaveToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem.Enabled = True
            lblFile.Text = openDialog.FileName
            lblFile.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub CosmoPointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosmoPointsToolStripMenuItem.Click
        Dim intCP = Savedata.GetCosmoPoints()
        Dim Message As String = "Please enter ammount of cosmo points." & vbCrLf & "Current ammount: " & intCP
        Dim strCP As String = InputBox(Message, "Cosmo Points")
        If Integer.TryParse(strCP, intCP) Then
            Savedata.SetCosmoPoints(intCP)
            lblFile.ForeColor = Color.Red
        End If
    End Sub

    Private Sub PlayableCharactersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayableCharactersToolStripMenuItem.Click
        Dim newform As New frmCollection(frmCollection.CollectionType.PlayableCharacters)
        If newform.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then Exit Sub
        lblFile.ForeColor = Color.Red
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        AttemptSave(lblFile.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveDialog As New SaveFileDialog
        saveDialog.Filter = "*.dat|*.dat"
        If saveDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
        AttemptSave(saveDialog.FileName)
    End Sub

    Private Sub AttemptSave(ByVal file As String)
        Do
            If Savedata.SaveToFile(file) Then
                MessageBox.Show("Savedata written to file.")
                lblFile.Text = file
                lblFile.ForeColor = Color.Green
                Exit Do
            End If
            Dim msg As String = file & vbCrLf & vbCrLf & "Write to file failed. Try again?"
            If MessageBox.Show(msg, "Save", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Do
        Loop While True
    End Sub
End Class
