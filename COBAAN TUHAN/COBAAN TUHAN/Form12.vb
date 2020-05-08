Imports MySql.Data.MySqlClient
Public Class FormCheck
    Dim sqlconnect As New MySqlConnection("server = localhost; uid = root; password =; database = restaurant")
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim query As String
    Dim dtInvoice As New DataTable
    Dim dtMenu2 As New DataTable
    Dim D As String 'Auto generate invoice id
    Dim F As String 'Data table value
    Private Sub FormCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select menu_id, menu_name from menu"
        sqlcommand = New MySqlCommand(query, sqlconnect)
        sqladapter = New MySqlDataAdapter(sqlcommand)
        sqladapter.Fill(dtMenu2)
        Call Invoice()
    End Sub

    Sub Invoice()
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
    End Sub

    Private Sub TmIn_Tick(sender As Object, e As EventArgs) Handles TmIn.Tick
        Call Invoice()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try
            sqlconnect.Open()
            query = "insert into selling values ('" + D + "', '" + FormCustomer.G + "', 0, 0, 0);"
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
            sqlconnect.Close()
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
End Class