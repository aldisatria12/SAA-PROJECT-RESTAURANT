Public Class FormUtamaKasir
    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        'Me.Hide()
        FormKas.MdiParent = formParent
        FormKas.Show()
    End Sub

    Private Sub FormUtamaKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub MenuPay_Click(sender As Object, e As EventArgs) Handles MenuPay.Click
        'Me.Hide()
        FormPay.MdiParent = formParent
        FormPay.Show()
    End Sub
End Class