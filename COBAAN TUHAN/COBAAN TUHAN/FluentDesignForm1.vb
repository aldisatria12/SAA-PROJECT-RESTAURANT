Public Class FormMainKasir
    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        FormKas2.Show()
        FormKas2.MdiParent = formParent
    End Sub
End Class
