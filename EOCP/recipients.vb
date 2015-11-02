Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO
Public Class recipients
    Public mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim sb As New StringBuilder()

    Private Function Runcmd(ByVal scriptText2 As String) As String

        Dim MyStringBuilder1 As New StringBuilder()

        Dim MyPipeline1 As Pipeline = login.MyRunSpace.CreatePipeline()

        MyPipeline1.Commands.AddScript(scriptText2)

        Dim results As Collection(Of PSObject) = MyPipeline1.Invoke()

        For Each obj As PSObject In results
            MyStringBuilder1.AppendLine(obj.ToString())
        Next

        Return MyStringBuilder1.ToString()

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waituse.Label1.Text = "Retrieving the list of User Mailboxes..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'mailboxes


        sb.Append("get-mailbox | where {  $_.RecipientTypeDetails -eq 'UserMailbox' } | select displayname,primarysmtpaddress")
        sb.AppendLine()

        Dim strFilePath = (mydocpath & "\mbx.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\mbx.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\mbx.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\mbx.txt"), (mydocpath & "\mbx.ps1"))

        RichTextBox1.Text = Runcmd(mydocpath & "\mbx.ps1")
        waituse.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        waituse.Label1.Text = "Retrieving the list of Security Groups and Distribution Groups..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'groups

        Dim len1 As Integer
        len1 = sb.Length
        sb.Remove(0, len1)
        sb.Append("Get-DistributionGroup | select displayname,grouptype,primarysmtpaddress")
        sb.AppendLine()

        Dim strFilePath = (mydocpath & "\groups.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\groups.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\groups.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\groups.txt"), (mydocpath & "\groups.ps1"))

        RichTextBox1.Text = Runcmd(mydocpath & "\groups.ps1")
        waituse.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waituse.Label1.Text = "Retrieving the list of Room Mailboxes and Equipment Mailboxes..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Resources
        Dim len1 As Integer
        len1 = sb.Length
        sb.Remove(0, len1)

        sb.Append("get-mailbox | where {  $_.RecipientTypeDetails -eq 'RoomMailbox' } | select displayname,primarysmtpaddress,resourcetype")
        sb.AppendLine()
        sb.Append("get-mailbox | where {  $_.RecipientTypeDetails -eq 'EquipmentMailbox' } | select displayname,primarysmtpaddress,resourcetype")
        sb.AppendLine()

        Dim strFilePath = (mydocpath & "\resources.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\resources.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\resources.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\resources.txt"), (mydocpath & "\resources.ps1"))

        RichTextBox1.Text = Runcmd(mydocpath & "\resources.ps1")
        waituse.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        waituse.Label1.Text = "Retrieving the list of Mail Contacts and Mail Users..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Resources
        Dim len1 As Integer
        len1 = sb.Length
        sb.Remove(0, len1)

        sb.Append("Get-MailContact | select name,externalemailaddress,recipienttype")
        sb.AppendLine()
        sb.Append("Get-Mailuser | select name,externalemailaddress,recipienttype")
        sb.AppendLine()

        Dim strFilePath = (mydocpath & "\contacts.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\contacts.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\contacts.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\contacts.txt"), (mydocpath & "\contacts.ps1"))

        RichTextBox1.Text = Runcmd(mydocpath & "\contacts.ps1")
        waituse.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        waituse.Label1.Text = "Retrieving the list of Shared Mailboxes..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Resources
        Dim len1 As Integer
        len1 = sb.Length
        sb.Remove(0, len1)

        sb.Append(" Get-Mailbox -RecipientTypeDetails shared | select name,primarysmtpaddress")
        sb.AppendLine()

        Dim strFilePath = (mydocpath & "\shared.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\shared.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\shared.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\shared.txt"), (mydocpath & "\shared.ps1"))

        RichTextBox1.Text = Runcmd(mydocpath & "\shared.ps1")
        waituse.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        MsgBox("GoodBye! :)")

        Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mailboxpop.Show()

    End Sub
End Class