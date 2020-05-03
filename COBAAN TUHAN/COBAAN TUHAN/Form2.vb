Public Class formAdmin
    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Me.Close()
    End Sub

    Private Sub btLaporanpengeluaran_Click(sender As Object, e As EventArgs) Handles btLaporanpengeluaran.Click
        btPembelian.Visible = True
        btPenjualan.Visible = True

    End Sub

    Private Sub btInsertdata_Click(sender As Object, e As EventArgs) Handles btInsertdata.Click
        formInsert.MdiParent = formParent
        formInsert.Top = 0
        formInsert.Left = 0
        formInsert.Show()
    End Sub

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
    End Sub
End Class