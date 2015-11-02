Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO
Public Class mdgeneral
    Public mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim sb As New StringBuilder()
    Private Sub mdgeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ActiveControl = Button1
        waituse.Label1.Text = "Trying to get the general proeprties for the usermailbox..."
        waituse.Show()

        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'firstname


        sb.Append("$upn= get-mailbox -Identity " + mailboxpop.TextBox1.Text + " | select *userprincipalname* ")
        sb.Append(vbNewLine)
        sb.Append("Get-Msoluser | where {$_.UserPrincipalName -eq $upn.UserPrincipalName} | format-wide *First* ")

        sb.AppendLine()

        Dim strFilePath = (mydocpath & "\firstname.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\firstname.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\firstname.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\firstname.txt"), (mydocpath & "\firstname.ps1"))

        TextBox6.Text = Runcmd(mydocpath & "\firstname.ps1")

        'initials
        Dim len1 As Integer
        len1 = sb.Length
        sb.Remove(0, len1)

        sb.Append("Get-user -Identity " + mailboxpop.TextBox1.Text + " | Format-Wide *ini* ")

        sb.AppendLine()

        strFilePath = (mydocpath & "\initials.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\initials.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\initials.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\initials.txt"), (mydocpath & "\initials.ps1"))

        TextBox5.Text = Runcmd(mydocpath & "\initials.ps1")

        'whencreated

        len1 = sb.Length
        sb.Remove(0, len1)

        sb.Append("Get-Mailbox -Identity " + mailboxpop.TextBox1.Text + " | Format-Wide *WhenMailboxCreated* ")

        sb.AppendLine()

        strFilePath = (mydocpath & "\create.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\create.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\create.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\create.txt"), (mydocpath & "\create.ps1"))

        TextBox14.Text = Runcmd(mydocpath & "\create.ps1")

        'LastName

        Dim len2 As Integer
        len2 = sb.Length
        sb.Remove(0, len2)

        sb.Append("$upn= get-mailbox -Identity " + mailboxpop.TextBox1.Text + " | select *userprincipalname* ")
        sb.Append(vbNewLine)
        sb.Append("Get-Msoluser | where {$_.UserPrincipalName -eq $upn.UserPrincipalName} | format-wide *LastName* ")

        sb.AppendLine()

        strFilePath = (mydocpath & "\lastname.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\lastname.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\lastname.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\lastname.txt"), (mydocpath & "\lastname.ps1"))

        TextBox4.Text = Runcmd(mydocpath & "\lastname.ps1")

        'display name

        Dim len3 As Integer
        len3 = sb.Length
        sb.Remove(0, len3)

        sb.Append("$upn= get-mailbox -Identity " + mailboxpop.TextBox1.Text + " | select *userprincipalname* ")
        sb.Append(vbNewLine)
        sb.Append("Get-Msoluser | where {$_.UserPrincipalName -eq $upn.UserPrincipalName} | format-wide *DisplayName* ")

        sb.AppendLine()

        strFilePath = (mydocpath & "\DisplayName.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\DisplayName.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\DisplayName.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\DisplayName.txt"), (mydocpath & "\DisplayName.ps1"))

        TextBox3.Text = Runcmd(mydocpath & "\DisplayName.ps1")

        'Alias

        Dim len4 As Integer
        len4 = sb.Length
        sb.Remove(0, len4)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *Alias* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\Alias.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\Alias.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\Alias.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\Alias.txt"), (mydocpath & "\Alias.ps1"))

        TextBox2.Text = Runcmd(mydocpath & "\Alias.ps1")

        'UserID

        Dim len5 As Integer
        len5 = sb.Length
        sb.Remove(0, len5)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *UserPrincipalName* ")

        sb.AppendLine()

        strFilePath = (mydocpath & "\upn.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\upn.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\upn.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\upn.txt"), (mydocpath & "\upn.ps1"))

        TextBox1.Text = Runcmd(mydocpath & "\upn.ps1")

        'custom att 1

        Dim len6 As Integer
        len6 = sb.Length
        sb.Remove(0, len6)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *CustomAttribute1* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\CustomAttribute1.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\CustomAttribute1.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\CustomAttribute1.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\CustomAttribute1.txt"), (mydocpath & "\CustomAttribute1.ps1"))

        TextBox7.Text = Runcmd(mydocpath & "\CustomAttribute1.ps1")

        'cust att 2

        Dim len7 As Integer
        len7 = sb.Length
        sb.Remove(0, len7)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *CustomAttribute2* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\CustomAttribute2.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\CustomAttribute2.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\CustomAttribute2.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\CustomAttribute2.txt"), (mydocpath & "\CustomAttribute2.ps1"))

        TextBox8.Text = Runcmd(mydocpath & "\CustomAttribute2.ps1")

        'cust att 3

        Dim len8 As Integer
        len8 = sb.Length
        sb.Remove(0, len8)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *CustomAttribute3* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\CustomAttribute3.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\CustomAttribute3.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\CustomAttribute3.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\CustomAttribute3.txt"), (mydocpath & "\CustomAttribute3.ps1"))

        TextBox9.Text = Runcmd(mydocpath & "\CustomAttribute3.ps1")

        'cust att 4
        Dim len9 As Integer
        len9 = sb.Length
        sb.Remove(0, len9)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *CustomAttribute4* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\CustomAttribute4.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\CustomAttribute4.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\CustomAttribute4.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\CustomAttribute4.txt"), (mydocpath & "\CustomAttribute4.ps1"))

        TextBox10.Text = Runcmd(mydocpath & "\CustomAttribute4.ps1")

        'cust att 5
        Dim len10 As Integer
        len10 = sb.Length
        sb.Remove(0, len10)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *CustomAttribute5* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\CustomAttribute5.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\CustomAttribute5.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\CustomAttribute5.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\CustomAttribute5.txt"), (mydocpath & "\CustomAttribute5.ps1"))

        TextBox11.Text = Runcmd(mydocpath & "\CustomAttribute5.ps1")

        'hide from GAL

        Dim len11 As Integer
        len11 = sb.Length
        sb.Remove(0, len11)

        sb.Append("get-mailbox -Identity " + mailboxpop.TextBox1.Text + " |format-wide *HiddenFromAddressListsEnabled* ")
        sb.Append(vbNewLine)

        sb.AppendLine()

        strFilePath = (mydocpath & "\HiddenFromAddressList.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\HiddenFromAddressList.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\HiddenFromAddressList.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\HiddenFromAddressList.txt"), (mydocpath & "\HiddenFromAddressList.ps1"))


        TextBox12.Text = Runcmd(mydocpath & "\HiddenFromAddressList.ps1")

        waituse.Close()



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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waituse.Label1.Text = "Executing PowerShell cmdlets:  Set-Msoluser,Set-User"
        waituse.Show()
        waituse.Location = New Point(50, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Dim len12 As Integer
        len12 = sb.Length
        sb.Remove(0, len12)

        sb.Append("$upn= get-mailbox -Identity " + mailboxpop.TextBox1.Text + " | select *userprincipalname* ")
        sb.Append(vbNewLine)

        Dim fchangecmd As String

        Dim upn As String = TextBox1.Text.Trim

        Dim fn As String = TextBox6.Text.Trim

        fchangecmd = "Set-Msoluser -UserPrincipalName " + upn + " -FirstName " + fn + " -Verbose"

        sb.AppendLine(fchangecmd)

        Dim strFilePath = (mydocpath & "\savefn.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\savefn.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\savefn.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\savefn.txt"), (mydocpath & "\savefn.ps1"))

        Try
            TextBox13.Text = Runcmd(mydocpath & "\savefn.ps1")

        Catch
            MsgBox("There was an error updating the information for this mailbox")
        End Try

        len12 = sb.Length
        sb.Remove(0, len12)

        Dim ini As String = TextBox5.Text.Trim

        sb.AppendLine("Set-User -Identity " + mailboxpop.TextBox1.Text + " -Initials " + ini + " -Verbose")
        sb.Append(vbNewLine)

        strFilePath = (mydocpath & "\savein.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\savein.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\savein.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\savein.txt"), (mydocpath & "\savein.ps1"))

        Try
            TextBox13.Text = Runcmd(mydocpath & "\savein.ps1")
            waituse.Close()

            MsgBox("Done!")

        Catch
            MsgBox("There was an error updating the information for this mailbox")
        End Try


    End Sub

End Class