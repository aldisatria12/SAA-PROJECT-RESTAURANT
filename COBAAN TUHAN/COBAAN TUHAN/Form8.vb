Public Class FormPay
    Private Sub FormPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPay.Enabled = False
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        'Me.Hide()
        FormKas.MdiParent = formParent
        FormKas.Show()
    End Sub
End Class