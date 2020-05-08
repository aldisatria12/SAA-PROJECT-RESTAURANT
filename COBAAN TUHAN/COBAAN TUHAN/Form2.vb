Public Class formAdmin
    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Me.Close()
    End Sub

    Private Sub btLaporanpengeluaran_Click(sender As Object, e As EventArgs) Handles btLaporanpengeluaran.Click
        BTstock.Visible = True
        BTcustomer.Visible = True
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

    Private Sub btPenjualan_Click(sender As Object, e As EventArgs) Handles btPenjualan.Click
        Form_Report_Penjualan.Show()
    End Sub

    Private Sub BTstock_Click(sender As Object, e As EventArgs) Handles BTstock.Click
        Form_report_stock.ShowDialog()
    End Sub

    Private Sub BTcustomer_Click(sender As Object, e As EventArgs) Handles BTcustomer.Click
        Form_Report_Customer.ShowDialog()
    End Sub
End Class