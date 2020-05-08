Public Class formLogin
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        If tbUsername.Text = "Aku" Then
            FormPay.LbUser.Text = "Cashier"
            FormPay.MenuUtama.Visible = True
            FormUtamaKasir.MdiParent = formParent
            FormUtamaKasir.Show()
        ElseIf tbUsername.Text = "A" Then
            FormPay.LbUser.Text = "Waiter"
            FormPay.MenuUtama.Visible = False
            FormPay.MdiParent = formParent
            FormPay.Show()
        Else
            formAdmin.MdiParent = formParent
            formAdmin.Top = 0
            formAdmin.Left = 0
            formAdmin.Show()
        End If
    End Sub
End Class
