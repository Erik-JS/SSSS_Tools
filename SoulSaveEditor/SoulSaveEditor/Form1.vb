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
        ProgressToolStripMenuItem.Enabled = False
        lblBuild.Text = RetrieveAppLinkerTimestampString()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openDialog As New OpenFileDialog
        Dim IsPCVersion As Boolean = True

        openDialog.Filter = "PS3 (*.DAT)|*.DAT|PC (ssss-savedata*)|ssss-savedata*"

        If openDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub

        If System.IO.Path.GetExtension(openDialog.FileName).ToUpper() = ".DAT" Then IsPCVersion = False

        If Savedata.LoadFromFile(openDialog.FileName, IsPCVersion) Then
            CollectionToolStripMenuItem.Enabled = True
            StatsToolStripMenuItem.Enabled = True
            SaveToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem.Enabled = True
            ProgressToolStripMenuItem.Enabled = True
            lblFile.Text = openDialog.FileName
            lblFile.ForeColor = Color.Blue
            Savedata.IsLittleEndian = IsPCVersion
            lblPlatform.Text = If(IsPCVersion, "PC", "PS3")
        End If
    End Sub

    Private Sub CosmoPointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosmoPointsToolStripMenuItem.Click
        Dim intCP = Savedata.GetCosmoPointsCurrent()
        Dim Message As String = "Please enter ammount of cosmo points." & vbCrLf & "Current ammount: " & intCP
        Dim strCP As String = InputBox(Message, "Cosmo Points")
        If Not Integer.TryParse(strCP, intCP) Then Exit Sub
        If intCP < 0 Then
            MsgBox("Invalid ammount: negative number.")
            Exit Sub
        End If
        Savedata.AdjustCosmoPoints(intCP - Savedata.GetCosmoPointsCurrent())
        lblFile.ForeColor = Color.Red
    End Sub

    Private Sub PlayableCharactersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayableCharactersToolStripMenuItem.Click
        ShowCollectionEditForm(frmCollection.CollectionType.PlayableCharacters)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        AttemptSave(lblFile.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveDialog As New SaveFileDialog
        saveDialog.Filter = If(Savedata.IsLittleEndian, "ssss-savedata*|ssss-savedata*", "*.dat|*.dat")
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

    Private Sub PlayableStagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayableStagesToolStripMenuItem.Click
        ShowCollectionEditForm(frmCollection.CollectionType.PlayableStages)
    End Sub

    Private Sub ShowCollectionEditForm(ByVal CollectionType As frmCollection.CollectionType)
        Dim newform As New frmCollection(CollectionType)
        If newform.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then Exit Sub
        lblFile.ForeColor = Color.Red
    End Sub

    Private Sub BattleOfGoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BattleOfGoldToolStripMenuItem.Click
        Dim bogform As New frmBattleOfGold()
        If bogform.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then lblFile.ForeColor = Color.Red
    End Sub
End Class
