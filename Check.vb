Imports System.IO
Public Class Check
    Dim moSearch As Management.ManagementObjectSearcher
    Dim psBattery As PowerStatus = SystemInformation.PowerStatus
    Dim perFull As Single = psBattery.BatteryLifePercent
    Dim FILE_NAME As String = "D:\Games\paths.txt"

    Function DetectDevice(DeviceName As String) As Boolean
        ' See if the desired device shows up in the device manager.'
        rtb.Text = "Checking Xbox Controller Connection Status ............."

        Dim search As System.Management.ManagementObjectSearcher
        Dim Name As String
        search = New System.Management.ManagementObjectSearcher("SELECT * From Win32_PnPEntity")

        For Each m As Management.ManagementObject In search.Get()
            ' Go through each device detected.'
            Name = CType(m("Name"), String) ' Get the name of the device.'
            If InStr(Name, DeviceName, CompareMethod.Text) > 0 Then     'compare input name with name in list
                rtb.Text = rtb.Text + vbNewLine + "Controller CONNECTED!!!"
                Return True
            End If
        Next

        'We did not find the device we were looking for'
        rtb.Text = rtb.Text + vbNewLine + "Controller NOT CONNECTED"
        Return False
    End Function

    Private Function checkBattery()
        rtb.Text = rtb.Text + vbNewLine + vbNewLine + "Checking Laptop Charging Status ............."
        If psBattery.PowerLineStatus = PowerLineStatus.Online Then
            rtb.Text = rtb.Text + vbNewLine + "Laptop IS CHARGING"
            Return True
        Else
            rtb.Text = rtb.Text + vbNewLine + "Laptop NOT CHARGING"
            Return False
        End If
    End Function

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If System.IO.File.Exists(FILE_NAME) = True Then
                If txtpath.Text.StartsWith("D:\Games\") Or txtpath.Text.StartsWith("""D:\Games\") Then
                    Dim objWriter = New StreamWriter(FILE_NAME, True)
                    objWriter.WriteLine(txtpath.Text.Replace("""", ""))
                    objWriter.Close()
                    MsgBox("Successfully added", MsgBoxStyle.Information)
                Else
                    MsgBox("Please enter a game path!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("File Does Not Exist", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form_Exit(sender As Object, e As EventArgs) Handles btnexit.Click
        Environment.Exit(0)
        Application.Exit()
    End Sub

    Private Sub Check_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If DetectDevice("Xbox One Controller") = False Or checkBattery() = False Then
            rtb.Text = rtb.Text + vbNewLine + vbNewLine + "ERROR: Pre-Requisites NOT SATISFIED!!"
        Else
            rtb.Text = rtb.Text + vbNewLine + vbNewLine + "You're all set to game!!"
            btngames.Enabled = True
            btngames.Visible = True
        End If
        Me.AcceptButton = btnexit
    End Sub

    Private Sub btngames_Click(sender As Object, e As EventArgs) Handles btngames.Click
        Me.Hide()
        Games.Show()
    End Sub

    Private Sub btnpathfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpathfile.Click
        Process.Start(FILE_NAME)
    End Sub
End Class