Public Class ecp
   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewMDIChild As New recipients()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        NewMDIChild.Height = 450
        NewMDIChild.Width = 800
        NewMDIChild.Location = New Point(150, 0)
        NewMDIChild.FormBorderStyle = Windows.Forms.FormBorderStyle.None

    End Sub

    Private Sub ecp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 500
        Me.Width = 1000
    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim NewMDIChild As New tools()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        NewMDIChild.Height = 450
        NewMDIChild.Width = 800
        NewMDIChild.Location = New Point(150, 0)
        NewMDIChild.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NewMDIChild As New Migration()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
        NewMDIChild.Height = 450
        NewMDIChild.Width = 800
        NewMDIChild.Location = New Point(150, 0)
        NewMDIChild.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub
End Class