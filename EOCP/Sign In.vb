Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO


Public Class login
   
    Public mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()


    Public Function Runcmd1(ByVal scriptText As String) As String

        Dim MyStringBuilder As New StringBuilder()



        MyRunSpace.Open()

        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        MyPipeline.Commands.AddScript(scriptText)


        MyPipeline.Commands.Add("Out-String")


        Dim results As Collection(Of PSObject) = MyPipeline.Invoke()


        For Each obj As PSObject In results
            MyStringBuilder.AppendLine(obj.ToString())
        Next

        Return MyStringBuilder.ToString()



    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        RichTextBox1.Text = "Please wait.. Trying to connect.."

        Dim sb As New StringBuilder()

        '1
        sb.Append("$Office365Username=" + "'" + TextBox1.Text + "'")

        sb.AppendLine()
        Dim strFilePath = (mydocpath & "\LoginCred1.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred1.txt")
            outfile.Write(sb.ToString())
        End Using


        '2

        sb.Append("$Office365Password=" + "'" + TextBox2.Text + "'")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred2.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        Using outfile As New StreamWriter(mydocpath & "\LoginCred2.txt")
            outfile.Write(sb.ToString())
        End Using


        '3

        sb.Append("$SecurePassword = $Office365Password | ConvertTo-SecureString -AsPlainText -Force")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred3.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred3.txt")
            outfile.Write(sb.ToString())
        End Using


        '4

        sb.Append("$cred= New-Object System.Management.Automation.PSCredential -ArgumentList $Office365Username, $SecurePassword")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred4.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred4.txt")
            outfile.Write(sb.ToString())
        End Using


        '5

        sb.Append("Import-Module msonline")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred5.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred5.txt")
            outfile.Write(sb.ToString())
        End Using



        '6

        sb.Append("Connect-MsolService -Credential $cred")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred6.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred6.txt")
            outfile.Write(sb.ToString())
        End Using



        '7

        sb.Append("$session = New-PSSession -ConfigurationName Microsoft.Exchange -ConnectionUri 'https://ps.outlook.com/powershell/' -Credential $cred -Authentication Basic -AllowRedirection")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred7.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred7.txt")
            outfile.Write(sb.ToString())
        End Using


        '8

        sb.Append("Import-PSSession $session -AllowClobber")
        sb.AppendLine()
        strFilePath = (mydocpath & "\LoginCred8.txt")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If
        Using outfile As New StreamWriter(mydocpath & "\LoginCred8.txt")
            outfile.Write(sb.ToString())
        End Using

        strFilePath = (mydocpath & "\LoginCred8.ps1")
        If System.IO.File.Exists(strFilePath) Then
            System.IO.File.Delete(strFilePath)
        End If

        System.IO.File.Move((mydocpath & "\LoginCred8.txt"), (mydocpath & "\LoginCred8.ps1"))

        Try

            RichTextBox1.Text = Runcmd1(mydocpath & "\LoginCred8.ps1")

            Button3.Enabled = True

            Button3.BackColor = Color.DeepSkyBlue

        Catch
            RichTextBox1.Text = "error! :( please check the username and password"
        End Try


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
        MsgBox("GoodBye! :)")
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ecp.Show()
        Me.Hide()

    End Sub

    Public Function Runcmd2(ByVal scriptText1 As String) As String

        Dim MyStringBuilder As New StringBuilder()

        Dim MyPipeline1 As Pipeline = MyRunSpace.CreatePipeline()

        MyPipeline1.Commands.AddScript(scriptText1)

        MyPipeline1.Commands.Add("Out-String")


        Dim results As Collection(Of PSObject) = MyPipeline1.Invoke()


        For Each obj As PSObject In results
            MyStringBuilder.AppendLine(obj.ToString())
        Next

        Return MyStringBuilder.ToString()

    End Function



    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False

    End Sub
End Class


