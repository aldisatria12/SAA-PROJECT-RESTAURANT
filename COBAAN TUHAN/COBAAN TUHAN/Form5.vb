Public Class Formpembelian
    Private Sub BTback_Click(sender As Object, e As EventArgs) Handles BTback.Click
        BTback.Visible = False
        BTcancel.Visible = True
        BTcetak.Visible = True
        DGVpembelian.Visible = False
    End Sub

    Private Sub BTcetak_Click(sender As Object, e As EventArgs) Handles BTcetak.Click
        BTback.Visible = True
        BTcancel.Visible = False
        BTcetak.Visible = False
        DGVpembelian.Visible = True
    End Sub

    Private Sub BTcancel_Click(sender As Object, e As EventArgs) Handles BTcancel.Click
        formAdmin.Show()
        Me.Close()
    End Sub
End Class