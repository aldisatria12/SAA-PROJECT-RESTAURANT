Imports MySql.Data.MySqlClient
Public Class Form_pembelian
    Dim sqlconnect As New MySqlConnection("server = localhost; uid = root; password =; database = restaurant")
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim dt_menu As New DataTable
    Public penyimpan As New Integer
    Dim penyimpan2 As New Integer
    Dim penyimpankali As Integer
    Dim invoice_id As String
    Dim supdate As Integer
    Dim dtdmenu As New DataTable


    Private Sub MenuKas_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormKas.MdiParent = formParent
        FormKas.Show()
    End Sub

    Private Sub MenuPay_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormPay.MdiParent = formParent
        FormPay.Show()
    End Sub

    Private Sub BTback_Click(sender As Object, e As EventArgs) Handles BTback.Click
        Me.Close()
    End Sub

    Private Sub BTbayar_Click(sender As Object, e As EventArgs) Handles BTbayar.Click
        BTbayar.Visible = False
        BTselesai.Visible = True
        Formbayar.ShowDialog()

    End Sub

    Private Sub BTselesai_Click(sender As Object, e As EventArgs) Handles BTselesai.Click
        Try
            sqlconnect.Open()
            sqlQuery = "Update `table` SET table_status = 1 WHERE table_id = '" + FormPay.tekan + "';"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
            sqlcommand.ExecuteNonQuery()
            sqlconnect.Close()
            FormPay.refrespb()
            FormPay.refreshlb()
        Catch ex As Exception
            sqlconnect.Close()
            MsgBox(ex.Message)
        End Try

        Try
            sqlconnect.Open()
            sqlQuery = "Update selling SET total_sell_price = " + LLangkatotal.Text + " WHERE invoice_id = '" + dt_menu.Rows(0).Item(0).ToString + "';"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
            sqlcommand.ExecuteNonQuery()
            sqlQuery = "Update selling SET selling_status = 1 WHERE invoice_id = '" + dt_menu.Rows(0).Item(0).ToString + "';"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
            sqlcommand.ExecuteNonQuery()
            sqlconnect.Close()
        Catch ex As Exception
            sqlconnect.Close()
            MsgBox(ex.Message)
        End Try
        Try
            sqlconnect.Open()
            For i = 0 To DGVpembelian.Rows.Count - 2
                dtdmenu = New DataTable
                sqlQuery = "select d.menu_id, menu_name, d.ingredients_id, amount_used, stocks
                from dmenu d, menu m, ingredients i
                where m.menu_id = d.menu_id and m.menu_name = '" + DGVpembelian.Rows(i).Cells(1).Value.ToString + "' and d.ingredients_id = i.ingredients_id;"
                sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(dtdmenu)
                For j = 0 To dtdmenu.Rows.Count - 1
                    supdate = CInt(dtdmenu.Rows(j).Item(4)) - CInt(dtdmenu.Rows(j).Item(3))
                    sqlQuery = "Update ingredients SET stocks = " + supdate.ToString + " WHERE ingredients_id = '" + dtdmenu.Rows(j).Item(2).ToString + "';"
                    sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
                    sqlcommand.ExecuteNonQuery()
                Next
            Next
            sqlconnect.Close()
        Catch ex As Exception
            sqlconnect.Close()
            MsgBox(ex.Message)
        End Try
        formParent.Pendapatan += CInt(LLangkatotal.Text)
        Me.Close()
    End Sub

    Private Sub Form_pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.MdiParent = formParent
        Try
            dt_menu = New DataTable
            sqlQuery = "select s.invoice_id, menu_name, amount, sell_price `harga Satuan`
from dselling d, selling s, menu m, customer c, `table` t
where s.invoice_id=d.invoice_id and m.menu_id=d.menu_id and s.table_id=t.table_id and s.customer_id=c.customer_id
and s.table_id= '" + FormPay.tekan + "' and s.selling_status = 0 ;"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconnect)
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(dt_menu)
            DGVpembelian.DataSource = dt_menu
            penyimpan = 0
            DGVpembelian.Columns("invoice_id").Visible = False
            invoice_id = (dt_menu.Rows(0)("invoice_id")).ToString
            For i = 0 To DGVpembelian.Rows.Count - 1
                penyimpankali = 0
                penyimpankali = DGVpembelian.Rows(i).Cells(3).Value * DGVpembelian.Rows(i).Cells(2).Value
                penyimpan = penyimpan + penyimpankali
            Next
            LLangkasubtotal.Text = penyimpan.ToString
            penyimpan2 = penyimpan * 0.1
            LLangkatax.Text = penyimpan2
            penyimpan = penyimpan + penyimpan2
            LLangkatotal.Text = penyimpan
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PbBack_Click(sender As Object, e As EventArgs) Handles PbBack.Click
        Me.Close()
    End Sub

    Private Sub LLline_Click(sender As Object, e As EventArgs) Handles LLline.Click

    End Sub
End Class