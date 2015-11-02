Public Class tools

    Private Sub tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NavigateWebURL(ByVal URL As String, Optional browser As String = "default")

        If Not (browser = "default") Then
            Try
                '// try set browser if there was an error (browser not installed)
                Process.Start(browser, URL)
            Catch ex As Exception
                '// use default browser
                Process.Start(URL)
            End Try

        Else
            '// use default browser
            Process.Start(URL)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NavigateWebURL("http://go.microsoft.com/fwlink/?LinkID=313782", "iexplore")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        scriptbuilder.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Process.Start("mfcmapi.exe")
        MsgBox("This tool will be added to EOCP in the next version")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Process.Start("EWSEditor.exe")
        MsgBox("This tool will be added to EOCP in the next version")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("This tool will be added to EOCP in the next version")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        scriptexplorer.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("This tool will be added to EOCP in the next version")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://community.office365.com/en-us/w/diagnostic_tools/default.aspx")
    End Sub
End Class