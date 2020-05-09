Public Class FormUtamaKasir
    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        Me.Close()
        FormKas.MdiParent = formParent
        FormKas.Show()
    End Sub

    Private Sub FormUtamaKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub MenuPay_Click(sender As Object, e As EventArgs) Handles MenuPay.Click
        If FormKas.Buka = 1 Then
            Me.Close()
            FormPay.MdiParent = formParent
            FormPay.Show()
        ElseIf FormKas.Buka = 0 Then
            MsgBox("Kas Belum Dibuka")
        End If
    End Sub


End Class