Imports DevExpress.CodeParser
Imports MySql.Data.MySqlClient
Public Class FormCheck
    Dim sqlconnect As New MySqlConnection("server = localhost; uid = root; password =; database = restaurant")
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim query As String
    Dim dtInvoice As New DataTable
    Dim dtMenu2 As New DataTable
    Dim dtCek As New DataTable
    Dim D As String 'Auto generate invoice id
    Dim F As String 'Data table value
    Dim amount As Integer
    Dim ada As Integer 'True False
    Private Sub FormCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select menu_id, menu_name from menu"
        sqlcommand = New MySqlCommand(query, sqlconnect)
        sqladapter = New MySqlDataAdapter(sqlcommand)
        sqladapter.Fill(dtMenu2)
        If FormPay.tambah = 1 Then
            TmIn.Enabled = False
        ElseIf FormPay.tambah = 0 Then
            TmIn.Enabled = True
        End If
        Call Invoice()
    End Sub

    Sub Invoice()
        If FormPay.tambah = 1 Then
            D = FormPay.dtTambah.Rows(0).Item(0).ToString
        ElseIf FormPay.tambah = 0 Then
            Try
                dtInvoice = New DataTable
                D = ""
                query = "select invoice_id from selling"
                sqlcommand = New MySqlCommand(query, sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(dtInvoice)
                D = "I"
                If dtInvoice.Rows.Count < 10 Then
                    D += "00" + (dtInvoice.Rows.Count + 1).ToString
                ElseIf dtInvoice.Rows.Count < 100 Then
                    D += "0" + (dtInvoice.Rows.Count + 1).ToString
                ElseIf dtInvoice.Rows.Count < 1000 Then
                    D += (dtInvoice.Rows.Count + 1).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TmIn_Tick(sender As Object, e As EventArgs) Handles TmIn.Tick
        Call Invoice()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try
            sqlconnect.Open()
            If FormPay.tambah = 0 Then
                query = "insert into selling values ('" + D + "', '" + FormCustomer.G + "','" + FormCustomer.Q + "', 0, 0, 0);"
                sqlcommand = New MySqlCommand(query, sqlconnect)
                sqlcommand.ExecuteNonQuery()
                For i = 0 To DgvCheck.Rows.Count - 2
                    For j = 0 To dtMenu2.Rows.Count - 1
                        If DgvCheck.Rows(i).Cells(0).Value.ToString = dtMenu2.Rows(j).Item(1).ToString Then
                            F = dtMenu2.Rows(j).Item(0).ToString
                        End If
                    Next
                    query = "insert into dselling values ('" + D + "', '" + F + "', " + DgvCheck.Rows(i).Cells(1).Value.ToString + ");"
                    sqlcommand = New MySqlCommand(query, sqlconnect)
                    sqlcommand.ExecuteNonQuery()
                Next
                For i = 0 To DgvCheck.Rows.Count - 2
                    Call isiDselling(i)
                Next
            ElseIf FormPay.tambah = 1 Then
                dtCek = New DataTable
                query = "select d.menu_id, menu_name, amount
                        from menu m, dselling d
                        where m.menu_id = d.menu_id and d.invoice_id = '" + D + "'"
                sqlcommand = New MySqlCommand(query, sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(dtCek)
                For i = 0 To DgvCheck.Rows.Count - 2
                    ada = 0
                    For j = 0 To dtCek.Rows.Count - 1
                        If DgvCheck.Rows(i).Cells(0).Value.ToString = dtCek.Rows(j).Item(1).ToString Then
                            amount = CInt(dtCek.Rows(j).Item(2))
                            amount += CInt(DgvCheck.Rows(i).Cells(1).Value)
                            query = "update dselling set amount = " + amount.ToString + " where invoice_id = '" + D + "' and menu_id = '" + dtCek.Rows(j).Item(0).ToString + "';"
                            sqlcommand = New MySqlCommand(query, sqlconnect)
                            sqlcommand.ExecuteNonQuery()
                            ada = 1
                        End If
                    Next
                    If ada = 0 Then
                        Call isiDselling(i)
                    End If
                Next
            End If
            sqlconnect.Close()
            FormPay.tambah = 0
            MsgBox("Success")
            'Call FormPay.refrespb()
            'Call FormPay.refreshlb()
            FormMenu.Hide()
            Me.Hide()
        Catch ex As Exception
            sqlconnect.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PbBack_Click(sender As Object, e As EventArgs) Handles PbBack.Click
        Me.Hide()
    End Sub

    Sub isiDselling(i)
        Try
            For j = 0 To dtMenu2.Rows.Count - 1
                If DgvCheck.Rows(i).Cells(0).Value.ToString = dtMenu2.Rows(j).Item(1).ToString Then
                    F = dtMenu2.Rows(j).Item(0).ToString
                End If
            Next
            query = "insert into dselling values ('" + D + "', '" + F + "', " + DgvCheck.Rows(i).Cells(1).Value.ToString + ");"
            sqlcommand = New MySqlCommand(query, sqlconnect)
            sqlcommand.ExecuteNonQuery()
        Catch ex As Exception
            sqlconnect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class