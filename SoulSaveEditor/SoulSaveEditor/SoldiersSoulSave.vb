Module SoldiersSoulSave

    Public Class Savedata

        Public Const EXPECTEDFILESIZE As Integer = 25336
        Public Const PLAYABLECHARACTERCOUNT As Integer = 147
        Public Const PLAYABLESTAGECOUNT As Integer = 40

        Public Shared Content() As Byte = Nothing
        Public Shared IsLittleEndian As Boolean

        Public Shared Function LoadFromFile(ByVal file As String, ByVal flagPC As Boolean) As Boolean
            ' it's called from form1, so file probably exists...
            Try
                Dim b() As Byte = IO.File.ReadAllBytes(file)
                If BitConverter.ToInt32(b, 0) <> &H56415323 Then
                    Dim strMsg As String = "Missing #SAV identifier."
                    ' make sure the part about decrypting the file only appears if the file is supposed to be from PS3
                    If Not flagPC Then strMsg &= vbCrLf & vbCrLf & "If you think this is the correct file, make sure it has been decrypted first."
                    MessageBox.Show(strMsg, "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
                If b.Length <> EXPECTEDFILESIZE Then
                    MessageBox.Show("Read filesize = " & b.Length & vbCrLf & "Expected filesize = " & EXPECTEDFILESIZE, "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
                Content = b
                Return True
            Catch ex As Exception
                MessageBox.Show("Exception in LoadFromFile" & vbCrLf & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function SaveToFile(ByVal file As String) As Boolean
            Try
                IO.File.WriteAllBytes(file, Content)
                Return True
            Catch ex As Exception
                MessageBox.Show("Exception in SaveToFile" & vbCrLf & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function GetInt32(ByVal Index As Integer) As Integer
            Dim tempValue As Integer = BitConverter.ToInt32(Content, Index)
            If IsLittleEndian Then Return tempValue
            Dim bytes() As Byte = BitConverter.GetBytes(tempValue)
            Array.Reverse(bytes)
            Return BitConverter.ToInt32(bytes, 0)
        End Function

        Public Shared Sub SetInt32(ByVal Index As Integer, ByVal Value As Integer)
            Dim bytes() As Byte = BitConverter.GetBytes(Value)
            If IsLittleEndian Then
                Content(Index) = bytes(0)
                Content(Index + 1) = bytes(1)
                Content(Index + 2) = bytes(2)
                Content(Index + 3) = bytes(3)
            Else
                Content(Index) = bytes(3)
                Content(Index + 1) = bytes(2)
                Content(Index + 2) = bytes(1)
                Content(Index + 3) = bytes(0)
            End If
        End Sub

        Public Shared Function GetCosmoPoints() As Integer
            Return GetInt32(&H6190)
        End Function

        Public Shared Sub SetCosmoPoints(ByVal value As Integer)
            SetInt32(&H6190, value)
            SetInt32(&H6194, value)
        End Sub

        Public Shared Sub LockPlayableCharacter(ByVal index As Integer)
            SetInt32(index * 4 + &HF4, 0)
        End Sub

        Public Shared Sub UnlockPlayableCharacter(ByVal index As Integer)
            SetInt32(index * 4 + &HF4, 1)
        End Sub

        Public Shared Function IsLockedPlayableCharacter(ByVal index As Integer) As Boolean
            Return GetInt32(index * 4 + &HF4) = 0
        End Function

        Public Shared Sub LockPlayableStage(ByVal index As Integer)
            SetInt32(index * 4 + &H1614, 0)
        End Sub

        Public Shared Sub UnlockPlayableStage(ByVal index As Integer)
            SetInt32(index * 4 + &H1614, 1)
        End Sub

        Public Shared Function IsLockedPlayableStage(ByVal index As Integer) As Boolean
            Return GetInt32(index * 4 + &H1614) = 0
        End Function

    End Class

    ' XHashtable = Hashtable + List
    ' Hashtable by itself doesn't care about order of items
    ' KeyList will keep track of the order
    Public Class XHashtable
        Inherits Hashtable
        Public KeysList As List(Of Object)

        Public Sub New()
            KeysList = New List(Of Object)
        End Sub

        Public Overrides Sub Add(key As Object, value As Object)
            MyBase.Add(key, value)
            KeysList.Add(key)
        End Sub
    End Class

    'http://blog.codinghorror.com/determining-build-date-the-hard-way/
    Public Function RetrieveAppLinkerTimestampString() As String
        Const PeHeaderOffset As Integer = 60
        Const LinkerTimestampOffset As Integer = 8
        Dim b(2047) As Byte
        Dim s As IO.Stream
        Try
            s = New IO.FileStream(Application.ExecutablePath, IO.FileMode.Open, IO.FileAccess.Read)
            s.Read(b, 0, 2048)
        Finally
            If Not s Is Nothing Then s.Close()
        End Try
        Dim i As Integer = BitConverter.ToInt32(b, PeHeaderOffset)
        Dim SecondsSince1970 As Integer = BitConverter.ToInt32(b, i + LinkerTimestampOffset)
        Dim dt As New DateTime(1970, 1, 1, 0, 0, 0)
        dt = dt.AddSeconds(SecondsSince1970)
        Return dt.ToString("MMM d yyyy HH:mm:ss UTC")
    End Function


End Module
