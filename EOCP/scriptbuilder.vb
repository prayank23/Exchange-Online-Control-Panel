Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO
Public Class scriptbuilder
    Public mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim sb As New StringBuilder()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim len1 As Integer
        len1 = sb.Length
        sb.Remove(0, len1)

        If ListBox1.SelectedIndex = 0 Then
            sb.Append("Get-MsolUser |")


        ElseIf ListBox1.SelectedIndex = 1 Then
            sb.Append("Get-Mailbox |")
        End If

        If ListBox2.SelectedIndex = 0 Then
            sb.Append("Set-MsolUser -PasswordNeverExpires $true")
        End If

        Dim strFilePath = (mydocpath & "\PasswordNeverExpireForAll.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\PasswordNeverExpireForAll.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\PasswordNeverExpireForAll.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\PasswordNeverExpireForAll.txt"), (mydocpath & "\PasswordNeverExpireForAll.ps1"))

        MsgBox("OK")
    End Sub

    Private Function Runcmd(ByVal scriptText2 As String) As String

        Dim MyStringBuilder1 As New StringBuilder()

        Dim MyPipeline1 As Pipeline = login.MyRunSpace.CreatePipeline()

        MyPipeline1.Commands.AddScript(scriptText2)

        MyPipeline1.Commands.Add("Out-String")

        Dim results As Collection(Of PSObject) = MyPipeline1.Invoke()

        For Each obj As PSObject In results
            MyStringBuilder1.AppendLine(obj.ToString())
        Next

        Return MyStringBuilder1.ToString()

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        waituse.Label1.Text = "Running the script..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Try
            RichTextBox1.Text = Runcmd(mydocpath & "\PasswordNeverExpireForAll.ps1")
            RichTextBox1.Text = "Success! (Get-MsolUser |Set-MsolUser -PasswordNeverExpires $true)"
            waituse.Close()

        Catch
            RichTextBox1.Text = "error"
            waituse.Close()

        End Try


    End Sub
End Class