Public Class formLogin
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        If tbUsername.Text = "Cashier" And tbPassword.Text = "cobaantuhan" Then
            FormPay.LbUser.Text = "Cashier"
            FormPay.MenuUtama.Visible = True
            FormUtamaKasir.MdiParent = formParent
            tbPassword.Text = ""
            tbUsername.Text = ""
            FormUtamaKasir.Show()
        ElseIf tbUsername.Text = "Waiter" And tbPassword.Text = "cobaantuhan" Then
            FormPay.LbUser.Text = "Waiter"
            FormPay.MenuUtama.Visible = False
            FormPay.MdiParent = formParent
            tbPassword.Text = ""
            tbUsername.Text = ""
            FormPay.Show()
        ElseIf tbUsername.Text = "Admin" And tbPassword.Text = "cobaantuhan" Then
            formAdmin.MdiParent = formParent
            formAdmin.Top = 0
            formAdmin.Left = 0
            tbPassword.Text = ""
            tbUsername.Text = ""
            formAdmin.Show()
        End If
    End Sub
End Class
