Imports MySql.Data.MySqlClient
Public Class Form_pembelian
    Dim sqlconnect As New MySqlConnection("server = localhost; uid = root; password =; database = restaurant")
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim dt_menu As New DataTable

    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        'Me.Hide()
        FormKas.MdiParent = formParent
        FormKas.Show()
    End Sub

    Private Sub MenuPay_Click(sender As Object, e As EventArgs) Handles MenuPay.Click
        'Me.Hide()
        FormPay.MdiParent = formParent
        FormPay.Show()
    End Sub

    Private Sub BTback_Click(sender As Object, e As EventArgs) Handles BTback.Click
        FormPay.MdiParent = formParent
        FormPay.Show()
    End Sub

    Private Sub BTbayar_Click(sender As Object, e As EventArgs) Handles BTbayar.Click
        BTbayar.Visible = False
        BTselesai.Visible = True
    End Sub

    Private Sub BTselesai_Click(sender As Object, e As EventArgs) Handles BTselesai.Click
        FormPay.MdiParent = formParent
        FormPay.Show()
    End Sub

    Private Sub Form_pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt_menu = New DataTable
            sqlQuery = "select menu_name, amount, sell_price `harga Satuan` from dselling d, selling s, menu m, customer c, `table` t where s.invoice_id=d.invoice_id and m.menu_id=d.menu_id and s.table_id=t.table_id and s.customer_id=c.customer_id and s.table_id='" + FormPay.tekan + "';"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(dt_menu)
        Catch ex As Exception

        End Try
    End Sub
End Class