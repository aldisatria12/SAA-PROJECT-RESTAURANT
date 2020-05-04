Public Class Formpembelian
    Private Sub BTback_Click(sender As Object, e As EventArgs) Handles BTback.Click
        BTback.Visible = False
        DGVpenjualan.Visible = False
        BTcetak.Visible = True
        BTcancel.Visible = True
    End Sub

    Private Sub BTcetak_Click(sender As Object, e As EventArgs) Handles BTcetak.Click
        BTback.Visible = True
        DGVpenjualan.Visible = True
        BTcetak.Visible = False
        BTcancel.Visible = False
    End Sub

    Private Sub BTcancel_Click(sender As Object, e As EventArgs) Handles BTcancel.Click
        Me.Close()
        formAdmin.Show()
    End Sub
End Class