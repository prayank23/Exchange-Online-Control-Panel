Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO
Public Class mboxdetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
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
  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NewMDIChild As New mdgeneral

        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        NewMDIChild.Height = 375
        NewMDIChild.Width = 550
        NewMDIChild.Location = New Point(150, 0)
        NewMDIChild.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub


End Class