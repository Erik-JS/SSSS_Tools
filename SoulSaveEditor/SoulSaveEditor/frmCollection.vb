Public Class frmCollection

    ' default value must be not none
    ' if it's none, then the form won't close
    Private ExitCode As Windows.Forms.DialogResult = Windows.Forms.DialogResult.Cancel
    ' description list
    Private CollectionItems() As String

    Private Target As CollectionType

    Private FormIsReady As Boolean = False

    Public Enum CollectionType
        PlayableCharacters
        AssistPhrases
        PlayableStages
        CharacterModels
    End Enum

    Public Sub New(ByVal CollectionTarget As CollectionType)
        InitializeComponent()
        Select Case CollectionTarget
            Case CollectionType.PlayableCharacters
                Me.Text &= " - Playable Characters"
                CollectionItems = Descriptions.PlayableCharacters
            Case CollectionType.AssistPhrases
                Me.Text &= " - Assist Phrases"
                Dim AssistPhraseList As New List(Of String)
                For I As Integer = 0 To Descriptions.AssistPhrases.Length - 1
                    AssistPhraseList.Add((I + 1).ToString("D3") & ": " & Descriptions.AssistPhrases(I).Quote)
                Next I
                CollectionItems = AssistPhraseList.ToArray()
            Case CollectionType.PlayableStages
                Me.Text &= " - Playable Stages"
                CollectionItems = Descriptions.PlayableStages
            Case CollectionType.CharacterModels
                Me.Text &= " - Character Models"
                CollectionItems = Descriptions.PlayableCharacters
        End Select
        Target = CollectionTarget
    End Sub

    Private Sub frmCollection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' form is closing, pass the exitcode
        Me.DialogResult = ExitCode
    End Sub

    Private Sub frmCollection_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chklist1.Items.Clear() ' form is starting from 'new', this thing should be empty already

        ' fill the list
        For Each Item As String In CollectionItems
            chklist1.Items.Add(Item)
        Next Item

        ' check/uncheck things
        VerifyAllItems()

        FormIsReady = True
    End Sub

    Private Sub VerifyAllItems()
        ' default state for items is unchecked, so we'll need to know what to *CHECK*
        Dim UnlockedIndexes As New List(Of Integer)

        For I As Integer = 0 To CollectionItems.Length - 1
            Select Case Target
                Case CollectionType.PlayableCharacters
                    If Savedata.IsLockedPlayableCharacter(I) Then Continue For
                    UnlockedIndexes.Add(I)
                Case CollectionType.AssistPhrases
                    If Savedata.GetAssistPhraseState(I) = Savedata.AssistPhraseState.Locked Then Continue For
                    UnlockedIndexes.Add(I)
                Case CollectionType.PlayableStages
                    If Savedata.IsLockedPlayableStage(I) Then Continue For
                    UnlockedIndexes.Add(I)
                Case CollectionType.CharacterModels
                    If Savedata.GetGalleryCharModelState(I) = 0 Then Continue For
                    UnlockedIndexes.Add(I)
            End Select
        Next I

        For Each Index As Integer In UnlockedIndexes
            chklist1.SetItemChecked(Index, True)
        Next Index

    End Sub

    Private Sub chklist1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chklist1.ItemCheck

        'the startup code which verifies what should be checked or unchecked may trigger this sub
        'this makes sure exit code won't be set up due to items changing in VerifyAllItems
        If Not FormIsReady Then Exit Sub

        ' this shit looked hard at first, but it's easily guessable via intellisense :)
        ' 'e' contains a reference to the item which is supposed to change
        If e.NewValue = CheckState.Unchecked Then
            ' item is going from checked to unchecked
            LockItem(e.Index)
        Else
            ' item is going from unchecked to checked
            UnlockItem(e.Index)
        End If
        ' an item has changed, set exitcode
        ExitCode = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub LockItem(ByVal ItemIdx As Integer)
        Select Case Target
            Case CollectionType.PlayableCharacters
                Savedata.LockPlayableCharacter(ItemIdx)
            Case CollectionType.AssistPhrases
                Savedata.SetAssistPhraseState(ItemIdx, Savedata.AssistPhraseState.Locked)
            Case CollectionType.PlayableStages
                Savedata.LockPlayableStage(ItemIdx)
            Case CollectionType.CharacterModels
                Savedata.SetGalleryCharModelState(ItemIdx, 0)
        End Select
    End Sub

    Private Sub UnlockItem(ByVal ItemIdx As Integer)
        Select Case Target
            Case CollectionType.PlayableCharacters
                Savedata.UnlockPlayableCharacter(ItemIdx)
            Case CollectionType.AssistPhrases
                Savedata.SetAssistPhraseState(ItemIdx, Savedata.AssistPhraseState.UnlockedNotSeen)
            Case CollectionType.PlayableStages
                Savedata.UnlockPlayableStage(ItemIdx)
            Case CollectionType.CharacterModels
                Savedata.SetGalleryCharModelState(ItemIdx, 3)
        End Select
    End Sub

    Private Sub btnEnableAll_Click(sender As Object, e As EventArgs) Handles btnEnableAll.Click
        For I As Integer = 0 To chklist1.Items.Count - 1
            chklist1.SetItemChecked(I, True)
        Next I
    End Sub

    Private Sub btnDisableAll_Click(sender As Object, e As EventArgs) Handles btnDisableAll.Click
        For I As Integer = 0 To chklist1.Items.Count - 1
            chklist1.SetItemChecked(I, False)
        Next I
    End Sub

    Private Sub btnInvertAll_Click(sender As Object, e As EventArgs) Handles btnInvertAll.Click
        For I As Integer = 0 To chklist1.Items.Count - 1
            chklist1.SetItemChecked(I, Not chklist1.GetItemChecked(I))
        Next I
    End Sub
End Class