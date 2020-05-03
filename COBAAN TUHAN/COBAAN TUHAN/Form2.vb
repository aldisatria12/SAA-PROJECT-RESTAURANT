Public Class formAdmin
    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Me.Close()
    End Sub

    Private Sub btLaporanpengeluaran_Click(sender As Object, e As EventArgs) Handles btLaporanpengeluaran.Click
        btPembelian.Visible = True
        btPenjualan.Visible = True

    End Sub

    Private Sub btInsertdata_Click(sender As Object, e As EventArgs) Handles btInsertdata.Click
        formInsert.Show()
    End Sub
End Class