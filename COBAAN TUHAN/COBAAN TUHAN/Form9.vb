Imports MySql.Data.MySqlClient
Public Class FormCustomer
    Dim sqlconnect As New MySqlConnection("server = localhost; uid = root; password =; database = restaurant")
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim query As String
    Public dtCustomer As New DataTable
    Public G As String 'Customer id
    Dim H As Integer 'Counter
    Public Q As String 'Table ID
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G = ""
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        If TbCust.Text <> "" Then
            Try
                sqlconnect.Open()
                query = "Update `table` SET table_status = 0 WHERE table_id = '" + Q + "';"
                sqlcommand = New MySqlCommand(query, sqlconnect)
                sqlcommand.ExecuteNonQuery()
                sqlconnect.Close()
            Catch ex As Exception
                sqlconnect.Close()
                MsgBox(ex.Message)
            End Try
            For i = 0 To dtCustomer.Rows.Count - 1
                If TbCust.Text = dtCustomer.Rows(i).Item(1).ToString Then
                    G = dtCustomer.Rows(i).Item(0).ToString
                    H = 1
                End If
            Next
            If H = 0 Then
                G = "C"
                If dtCustomer.Rows.Count < 10 Then
                    G += "00" + (dtCustomer.Rows.Count + 1).ToString
                ElseIf dtCustomer.Rows.Count < 100 Then
                    G += "0" + (dtCustomer.Rows.Count + 1).ToString
                ElseIf dtCustomer.Rows.Count < 1000 Then
                    G += (dtCustomer.Rows.Count + 1).ToString
                End If
                Try
                    sqlconnect.Open()
                    query = "insert into customer values ('" + G + "', '" + TbCust.Text + "', 'Non-Regular', 1, 0);"
                    sqlcommand = New MySqlCommand(query, sqlconnect)
                    sqlcommand.ExecuteNonQuery()
                    sqlconnect.Close()
                Catch ex As Exception
                    sqlconnect.Close()
                    MsgBox(ex.Message)
                End Try
            End If
            'Call FormPay.refrespb()
            'Call FormPay.refreshlb()
            FormMenu.LbTable.Text = LbTable.Text
            FormMenu.LbCust.Text = TbCust.Text
            FormMenu.MdiParent = formParent
            FormMenu.Show()
            Me.Hide()
        Else
            MsgBox("Nama belum diisi")
        End If
    End Sub

    Private Sub PbExit_Click(sender As Object, e As EventArgs) Handles PbExit.Click
        TbCust.Text = ""

        Me.Hide()
    End Sub
End Class