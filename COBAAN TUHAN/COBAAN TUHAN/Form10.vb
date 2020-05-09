Imports MySql.Data.MySqlClient
Public Class FormMenu
    Dim sqlconnect As New MySqlConnection("server = localhost; uid = root; password =; database = restaurant")
    Dim sqlcommand As New MySqlCommand
    Dim sqladapter As New MySqlDataAdapter
    Dim query As String
    Dim dtmenu As New DataTable
    Dim ImgDg As New DataGridViewImageColumn
    Dim ImgDg2 As New DataGridViewImageColumn
    Dim dtSimpan As New DataTable
    Dim A As Integer 'Quantity
    Public R As Integer 'simpan row
    Dim C As String() 'rows insert datatable
    Dim P As Integer 'true false
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 0
        Try
            dtmenu = New DataTable
            query = "select menu_name, sell_price from menu where menu_status = 1"
            sqlcommand = New MySqlCommand(query, sqlconnect)
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(dtmenu)
            DgvMenu.DataSource = dtmenu
            DgvMenu.Columns.Add("Quantity", "Quantity")
            DgvMenu.Columns.Add("Keterangan", "Keterangan")
            DgvMenu.Columns.Add(ImgDg)
            ImgDg.HeaderText = "Action"
            ImgDg.Image = My.Resources.plus
            ImgDg.ImageLayout = ImageLayout.Stretch
            ImgDg.Name = "ImgDg"
            DgvMenu.Columns.Add(ImgDg2)
            ImgDg2.HeaderText = "Action"
            ImgDg2.Image = My.Resources.minus
            ImgDg2.ImageLayout = ImageLayout.Stretch
            ImgDg2.Name = "ImgDg2"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMenu.CellClick
        If e.ColumnIndex = 2 Then
            If DgvMenu.Rows(e.RowIndex).Cells(0).Value <> "" Then
                A = CInt(DgvMenu.Rows(e.RowIndex).Cells(0).Value)
                A += 1
                DgvMenu.Rows(e.RowIndex).Cells(0).Value = A.ToString
            ElseIf DgvMenu.Rows(e.RowIndex).Cells(0).Value = "" Then
                DgvMenu.Rows(e.RowIndex).Cells(0).Value = "1"
            End If
        ElseIf e.ColumnIndex = 3 Then
            If DgvMenu.Rows(e.RowIndex).Cells(0).Value = "1" Then
                DgvMenu.Rows(e.RowIndex).Cells(0).Value = ""
            ElseIf DgvMenu.Rows(e.RowIndex).Cells(0).Value <> "" Then
                A = CInt(DgvMenu.Rows(e.RowIndex).Cells(0).Value)
                A -= 1
                DgvMenu.Rows(e.RowIndex).Cells(0).Value = A.ToString
            End If
        ElseIf e.ColumnIndex = 1 Then
            If DgvMenu.Rows(e.RowIndex).Cells(0).Value <> "" Then
                R = e.RowIndex
                If DgvMenu.Rows(e.RowIndex).Cells(1).Value = "" Then
                    FormKeterangan.RtbKet.Text = ""
                Else
                    FormKeterangan.RtbKet.Text = DgvMenu.Rows(e.RowIndex).Cells(1).Value.ToString
                End If
                FormKeterangan.LbMenu.Text = DgvMenu.Rows(e.RowIndex).Cells(4).Value.ToString
                FormKeterangan.ShowDialog()
            End If
        End If
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Try
            dtSimpan = New DataTable
            dtSimpan.Columns.Add("Menu")
            dtSimpan.Columns.Add("Quantity")
            dtSimpan.Columns.Add("Keterangan")
            For i = 0 To DgvMenu.Rows.Count - 1
                If DgvMenu.Rows(i).Cells(0).Value <> "" Then
                    P = 1
                    If DgvMenu.Rows(i).Cells(1).Value <> "" Then
                        C = New String() {DgvMenu.Rows(i).Cells(4).Value.ToString, DgvMenu.Rows(i).Cells(0).Value.ToString, DgvMenu.Rows(i).Cells(1).Value.ToString}
                    Else
                        C = New String() {DgvMenu.Rows(i).Cells(4).Value.ToString, DgvMenu.Rows(i).Cells(0).Value.ToString, ""}
                    End If
                    dtSimpan.Rows.Add(C)
                End If
            Next
            If P = 1 Then
                FormCheck.LbCust.Text = LbCust.Text
                FormCheck.LbTable.Text = LbTable.Text
                FormCheck.DgvCheck.DataSource = dtSimpan
                FormCheck.MdiParent = formParent
                FormCheck.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PbBack_Click(sender As Object, e As EventArgs) Handles PbBack.Click
        If FormPay.tambah = 0 Then
            Try
                sqlconnect.Open()
                query = "Update `table` SET table_status = 1 WHERE table_id = '" + FormCustomer.Q + "';"
                sqlcommand = New MySqlCommand(query, sqlconnect)
                sqlcommand.ExecuteNonQuery()
                FormPay.refrespb()
                FormPay.refreshlb()
                sqlconnect.Close()
            Catch ex As Exception
                sqlconnect.Close()
                MsgBox(ex.Message)
            End Try
        End If
        Me.Hide()
    End Sub
End Class