Imports DevExpress.XtraEditors.Senders
Imports MySql.Data.MySqlClient
Public Class FormPay
    Dim constring As String = "server=localhost;uid=root;password=;database=restaurant"
    Dim sqlconnect As New MySqlConnection(constring)
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim sqlquery As String
    Dim pb(4, 1) As PictureBox
    Dim lb(4, 1) As Label
    Dim dt_table As New DataTable
    Sub FormPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPay.Enabled = False
        Me.Left = 0
        Me.Top = 0
        Try
            dt_table = New DataTable
            sqlquery = "select * from `table`"
            sqlcommand = New MySqlCommand(sqlquery, sqlconnect)
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(dt_table)
        Catch ex As Exception

        End Try
        If dt_table.Rows.Count Mod 10 = 0 Then
            numArea.Minimum = 1
            numArea.Maximum = (dt_table.Rows.Count \ 10)
        Else
            numArea.Minimum = 1
            numArea.Maximum = (dt_table.Rows.Count \ 10) + 1
        End If



        For i = 0 To 4
            pb(i, 0) = New PictureBox
            pb(i, 0).Top = 100
            pb(i, 0).Width = 100
            pb(i, 0).Height = 50
            pb(i, 0).Left = (110 * i) + 300
            pb(i, 0).BackColor = Color.Red
            pb(i, 0).Parent = Me
            pb(i, 1) = New PictureBox
            pb(i, 1).Visible = True
            pb(i, 1).Top = 200
            pb(i, 1).Width = 100
            pb(i, 1).Height = 50
            pb(i, 1).Left = (110 * i) + 300
            pb(i, 1).BackColor = Color.Red
            pb(i, 1).Parent = Me
            AddHandler pb(i, 0).Click, AddressOf clickpb
            AddHandler pb(i, 1).Click, AddressOf clickpb
        Next
        For i = 0 To 4
            lb(i, 0) = New Label
            lb(i, 0).Top = 150
            lb(i, 0).Width = 100
            lb(i, 0).Height = 50
            lb(i, 0).Left = (110 * i) + 320
            lb(i, 0).Font = New Font("Segoe UI", 10, FontStyle.Bold)
            lb(i, 0).Text = "available"
            lb(i, 0).Parent = Me
            lb(i, 1) = New Label
            lb(i, 1).Visible = True
            lb(i, 1).Top = 270
            lb(i, 1).Width = 100
            lb(i, 1).Height = 50
            lb(i, 1).Left = (110 * i) + 320
            lb(i, 1).Font = New Font("Segoe UI", 10, FontStyle.Bold)
            lb(i, 1).Text = "available"
            lb(i, 1).Parent = Me
        Next
        refrespb()
        refreshlb()

    End Sub

    Sub clickpb(sender As Object, e As EventArgs)
        If LbUser.Text = "Waiter" Then
            Try
                FormCustomer.Q = sender.tag.ToString
                FormCustomer.dtCustomer = New DataTable
                sqlquery = "select customer_id, customer_name from customer"
                sqlcommand = New MySqlCommand(sqlquery, sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(FormCustomer.dtCustomer)
                FormCustomer.LbTable.Text = sender.tag.ToString.Substring(2, 2)
                FormCustomer.TbCust.Text = ""
                FormCustomer.ShowDialog()
            Catch ex As Exception
                sqlconnect.Close()
                MsgBox(ex.Message)
            End Try

        End If
        refrespb()
        refreshlb()
    End Sub


    Sub refrespb()
        If dt_table.Rows.Count <> 0 Then
            For i = 0 To 4
                lb(i, 0).Visible = False
                lb(i, 1).Visible = False
                pb(i, 0).Visible = False
                pb(i, 1).Visible = False
            Next
        End If
        Try
            For i = 0 To 9
                If dt_table.Rows.Count > 0 Then
                    If dt_table.Rows(i + (10 * (numArea.Value - 1)))("table_status").ToString = "1" Then
                        If i < 5 Then
                            pb(i, 0).BackColor = Color.Green
                            pb(i, 0).Visible = True
                            pb(i, 0).Tag = dt_table.Rows(i + (10 * (numArea.Value - 1)))("table_id").ToString
                        Else
                            pb(i - 5, 1).BackColor = Color.Green
                            pb(i - 5, 1).Visible = True
                            pb(i - 5, 1).Tag = dt_table.Rows(i + (10 * (numArea.Value - 1)))("table_id").ToString
                        End If
                    ElseIf dt_table.Rows(i + (10 * (numArea.Value - 1)))("table_status").ToString = "0" Then
                        If i < 5 Then
                            pb(i, 0).BackColor = Color.Red
                            pb(i, 0).Visible = True
                            pb(i, 0).Tag = dt_table.Rows(i + (10 * (numArea.Value - 1)))("table_id").ToString
                        Else
                            pb(i - 5, 1).BackColor = Color.Red
                            pb(i - 5, 1).Visible = True
                            pb(i - 5, 1).Tag = dt_table.Rows(i + (10 * (numArea.Value - 1)))("table_id").ToString
                        End If
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub refreshlb()
        Try
            For i = 0 To 9
                If dt_table.Rows.Count > 0 Then
                    If i < 5 Then
                        lb(i, 0).ForeColor = Color.Blue
                        lb(i, 0).Visible = True
                        lb(i, 0).Text = "seats" + dt_table.Rows(i + (10 * (numArea.Value - 1)))("seats_available").ToString
                    Else
                        lb(i - 5, 1).ForeColor = Color.Blue
                        lb(i - 5, 1).Visible = True
                        lb(i - 5, 1).Text = "seats" + dt_table.Rows(i + (10 * (numArea.Value - 1)))("seats_available").ToString
                    End If
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub MenuKas_Click(sender As Object, e As EventArgs) Handles MenuKas.Click
        'Me.Hide()
        FormKas.MdiParent = formParent
        FormKas.Show()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numArea.ValueChanged
        refrespb()
        refreshlb()
    End Sub

    Sub isiDatatable()
        Try
            dt_table = New DataTable
            sqlquery = "select * from `table`"
            sqlcommand = New MySqlCommand(sqlquery, sqlconnect)
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(dt_table)
        Catch ex As Exception

        End Try
    End Sub
End Class