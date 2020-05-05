Public Class formLogin
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        If tbUsername.Text = "Aku" Then
            FormMainKasir.MdiParent = formParent
            FormMainKasir.Show()
        Else
            formAdmin.MdiParent = formParent
            formAdmin.Top = 0
            formAdmin.Left = 0
            formAdmin.Show()
        End If
    End Sub
End Class
