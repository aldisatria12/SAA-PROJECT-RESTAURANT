Public Class FormUtamaKasir
    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        FormKas.MdiParent = formParent
        FormKas.Left = 0
        FormKas.Top = 0
        Me.Close()
        FormKas.Show()
    End Sub

    Private Sub FormUtamaKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
        Me.MdiParent = formParent
    End Sub

    Private Sub MenuPay_Click(sender As Object, e As EventArgs) Handles MenuPay.Click
        If formParent.Buka = 1 Then
            FormPay.MdiParent = formParent
            FormPay.Left = 0
            FormPay.Top = 0
            Me.Close()
            FormPay.Show()
        ElseIf formParent.Buka = 0 Then
            MsgBox("Kas Belum Dibuka")
        End If
    End Sub

    Private Sub MenuLogout_Click(sender As Object, e As EventArgs) Handles MenuLogout.Click
        Me.Close()
    End Sub
End Class