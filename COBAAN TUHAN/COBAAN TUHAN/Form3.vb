﻿Imports MySql.Data.MySqlClient

Public Class formInsert
    Dim constring As String = "server=localhost;uid=root;password=;database=restaurant"
    Dim sqlConnect As New MySqlConnection(constring)
    Dim sqlCommand As New MySqlCommand
    Dim sqlAdapter As New MySqlDataAdapter
    Dim sqlQuery As String
    Public dt_View As New DataTable
    Public mode As String
    Dim pbDel As New DataGridViewImageColumn
    Dim pbEdt As New DataGridViewImageColumn
    Public editmode As Boolean
    Private Sub formInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        ctMenu.Checked = True

        pbDel.Name = "pbDel"
        pbDel.HeaderText = ""
        pbDel.Width = 25
        pbDel.Image = My.Resources.delete
        pbDel.ImageLayout = DataGridViewImageCellLayout.Zoom

        pbEdt.Name = "pbDel"
        pbEdt.HeaderText = ""
        pbEdt.Width = 25
        pbEdt.Image = My.Resources.edit2
        pbEdt.ImageLayout = DataGridViewImageCellLayout.Zoom

        dgAdmin.BackgroundColor = Color.White
    End Sub
    Sub buttonradio(sender As Object, e As EventArgs) Handles ctKategorimenu.CheckedChanged, ctKursimeja.CheckedChanged, ctMenu.CheckedChanged, ctStokbahan.CheckedChanged
        If sender Is ctMenu And ctMenu.Checked = True Then
            ctKategorimenu.Checked = False
            ctKursimeja.Checked = False
            ctStokbahan.Checked = False
            ctMenu.Checked = True
            mode = "menu"
        ElseIf sender Is ctStokbahan And ctStokbahan.Checked = True Then
            ctKategorimenu.Checked = False
            ctKursimeja.Checked = False
            ctMenu.Checked = False
            ctStokbahan.Checked = True
            mode = "ingredients"
        ElseIf sender Is ctKursimeja And ctKursimeja.Checked = True Then
            ctKategorimenu.Checked = False
            ctMenu.Checked = False
            ctStokbahan.Checked = False
            ctKursimeja.Checked = True
            mode = "table"
        ElseIf sender Is ctKategorimenu And ctKategorimenu.Checked = True Then
            ctKursimeja.Checked = False
            ctMenu.Checked = False
            ctStokbahan.Checked = False
            ctKategorimenu.Checked = True
            mode = "category"
        End If
        refreshDGV()
    End Sub

    Sub refreshDGV()
        Try
            dt_View = New DataTable
            If mode = "menu" Then
                sqlQuery = "SELECT menu_id `ID`, menu_name `Name`, category_name `Category`, sell_price `Price`, IF(menu_status = 1,'Active','Non-Active') `Status` FROM category c, menu m WHERE c.category_id = m.category_id AND menu_delete = 0"
            ElseIf mode = "ingredients" Then
                sqlQuery = "SELECT ingredients_id `ID`, ingredients_name `Name`, stocks `Stock`, IF(ingredients_status = 1,'Active','Non-Active') `Status` FROM ingredients i WHERE ingredients_delete = 0"
            ElseIf mode = "table" Then
                sqlQuery = "SELECT table_id `ID`, table_name `Name`, seats_available `Seats Available`, IF(table_status = 1,'Active','Non-Active') `Status` FROM `table` t WHERE table_delete = 0"
            ElseIf mode = "category" Then
                sqlQuery = "SELECT category_id `ID`, category_name `Name`, IF(category_status = 1,'Active','Non-Active') `Status` FROM `category` c WHERE category_delete = 0"
            End If
            If mode <> "" Then
                If cbAktif.Checked = True Then
                    sqlQuery += " AND `" + mode.ToString + "_status` = 1"
                ElseIf cbAktif.Checked = False Then
                    sqlQuery += " AND `" + mode.ToString + "_status` = 0"
                End If
                If tbSearch.Text <> "" Then
                    sqlQuery += " HAVING (`Name` LIKE '%" + tbSearch.Text + "%' OR `Name` LIKE '" + tbSearch.Text + "%')"
                End If
            End If
            sqlQuery += ";"
            sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlAdapter.Fill(dt_View)
            With dgAdmin
                .DataSource = dt_View
                .Columns("ID").DisplayIndex = 0
                .Columns("Name").DisplayIndex = 1
                If mode = "menu" Then
                    .Columns("Category").DisplayIndex = 2
                    .Columns("Price").DisplayIndex = 3
                    .Columns("Status").DisplayIndex = 4
                ElseIf mode = "ingredients" Then
                    .Columns("Stock").DisplayIndex = 2
                    .Columns("Status").DisplayIndex = 3
                ElseIf mode = "table" Then
                    .Columns("Seats Available").DisplayIndex = 2
                    .Columns("Status").DisplayIndex = 3
                ElseIf mode = "category" Then
                    .Columns("Status").DisplayIndex = 2
                End If
                .Columns.Add(pbEdt)
                .Columns.Add(pbDel)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbAktif_CheckedChanged(sender As Object, e As EventArgs) Handles cbAktif.CheckedChanged
        refreshDGV()
    End Sub

    Private Sub dgAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAdmin.CellClick
        If dgAdmin.CurrentCell.OwningColumn.Name = "btEdt" Then
            editmode = True
            formAdd.Show()
        ElseIf dgAdmin.CurrentCell.OwningColumn.Name = "btDel" Then
            If MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    sqlConnect.Open()
                    sqlQuery = "UPDATE `" + mode.ToString + "` SET `" + mode.ToString + "_delete` = 1 WHERE `" + mode.ToString + "_id` = '" + dt_View.Rows(dgAdmin.CurrentRow.Index).Item(0).ToString + "';"
                    sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                    sqlCommand.ExecuteNonQuery()
                    MsgBox("Berhasil!")
                    sqlConnect.Close()
                Catch ex As Exception
                    sqlConnect.Close()
                    MsgBox(ex.Message)
                End Try
                refreshDGV()
            End If
        End If
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        formAdd.Show()
        editmode = False
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Me.Close()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        refreshDGV()
    End Sub
End Class