Public Class Games
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim FILE_NAME As String = "D:\Games\paths.txt"

            If System.IO.File.Exists(FILE_NAME) = True Then
                Dim objReader As New System.IO.StreamReader(FILE_NAME)

                Do While objReader.Peek() <> -1
                    GetPictureFields(objReader.ReadLine)
                Loop
                objReader.Close()
            Else
                MessageBox.Show("File Does Not Exist")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetPictureFields(ByVal path As String)
        For Each ctrl As Control In GroupBox1.Controls
            If (ctrl.GetType() Is GetType(PictureBox)) And CType(ctrl, PictureBox).Image Is Nothing Then
                Dim r As Icon = System.Drawing.Icon.ExtractAssociatedIcon(path)
                CType(ctrl, PictureBox).Image = r.ToBitmap
                AddHandler CType(ctrl, PictureBox).DoubleClick, Function(sender, e) startProcess(path)
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Form_Exit(ByVal sender As Object, ByVal e As EventArgs) Handles btnexit.Click
        Environment.Exit(0)
        Application.Exit()
    End Sub

    Private Function startProcess(ByVal path As String)
        Try
            Dim procStartInfo As New ProcessStartInfo
            Dim procExecuting As New Process

            With procStartInfo
                .UseShellExecute = True
                .FileName = path
                .WindowStyle = ProcessWindowStyle.Normal
                .WorkingDirectory = path.Substring(0, path.LastIndexOf("\"))
                .Verb = "runas" 'add this to prompt for elevation
            End With

            procExecuting = Process.Start(procStartInfo)
            Environment.Exit(0)
            Application.Exit()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btngoback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngoback.Click
        Me.Hide()
        Check.Show()
    End Sub
End Class
