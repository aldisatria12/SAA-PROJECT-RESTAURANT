Public Class formLogin
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        formAdmin.MdiParent = formParent
        formAdmin.Top = 0
        formAdmin.Left = 0
        formAdmin.Show()
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
