Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO
Public Class scriptexplorer
    Public mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim sb As New StringBuilder()
    Private Sub scriptexplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strFilePath = (mydocpath & "\PasswordNeverExpireForAll.ps1")
        If System.IO.File.Exists(strFilePath) Then

            Dim MyButton As New Button()

            With MyButton
                .Location = New Point(12, 12)
                .Size = New Size(150, 30)
                .TabIndex = 0
                .Text = "PasswordNeverExpireForAll"

            End With
            Controls.Add(MyButton)

            AddHandler MyButton.Click, AddressOf MyButton_Click

        Else
            MsgBox("No saved scripts!")
        End If


    End Sub

    Private Sub MyButton_Click(ByVal obj As Object, ByVal e As EventArgs)


        waituse.Label1.Text = "Running the script..."
        waituse.Show()

        waituse.Location = New Point(0, 0)
        waituse.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Try
            RichTextBox1.Text = Runcmd(mydocpath & "\PasswordNeverExpireForAll.ps1")
            RichTextBox1.Text = "success!"
            waituse.Close()

        Catch
            RichTextBox1.Text = "error"
            waituse.Close()

        End Try
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
End Class