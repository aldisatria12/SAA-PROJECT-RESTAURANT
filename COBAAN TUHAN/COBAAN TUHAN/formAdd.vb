Imports MySql.Data.MySqlClient


Public Class formAdd
    'SQL
    Dim constring As String = "server=localhost;uid=root;password=;database=restaurant"
    Dim sqlConnect As New MySqlConnection(constring)
    Dim sqlCommand As New MySqlCommand
    Dim sqlAdapter As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim dt_Datacount As New DataTable
    Dim dt_Category As New DataTable
    Dim autogenerateID As String
    'Used by all
    Dim lbID As New Label
    Dim lbName As New Label
    Dim lbStat As New Label
    Public tbID As New TextBox
    Dim tbName As New TextBox
    Dim cmStat As New ComboBox
    'Menu
    Dim lbCat As New Label
    Dim lbPrice As New Label
    Dim cmCat As New ComboBox
    Dim tbPrice As New TextBox
    'Ingredient
    Dim lbStock As New Label
    Dim tbStock As New TextBox
    'Table
    Dim lbSeat As New Label
    Dim cmSeat As New NumericUpDown
    'Location
    Dim locy(5) As Integer


    Private Sub formAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        locy(0) = 95
        For i = 0 To 5
            If i > 0 Then
                locy(i) = locy(i - 1) + 40
            End If
        Next

        If formInsert.mode = "menu" And formInsert.editmode = True Then
            btIngredient.Visible = True
        Else
            btIngredient.Visible = False
        End If

        If formInsert.mode = "menu" Then
            lbAdd.Text = "Form Menu"
            lbAdd.BackColor = Color.FromArgb(238, 194, 100)
        ElseIf formInsert.mode = "ingredients" Then
            lbAdd.Text = "Form Ingredients"
            lbAdd.BackColor = Color.FromArgb(238, 194, 100)
        ElseIf formInsert.mode = "table" Then
            lbAdd.Text = "Form Table"
            lbAdd.BackColor = Color.FromArgb(238, 194, 100)
        ElseIf formInsert.mode = "category" Then
            lbAdd.Text = "Form Category"
            lbAdd.BackColor = Color.FromArgb(238, 194, 100)
        End If
        AddHandler tbName.TextChanged, AddressOf autoID
        ''' VALUE MEMBER
        dt_Category = New DataTable
        sqlQuery = "SELECT * FROM category c;"
        sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
        sqlAdapter = New MySqlDataAdapter(sqlCommand)
        sqlAdapter.Fill(dt_Category)
        cmCat.DataSource = dt_Category
        cmCat.DisplayMember = "category_name"
        cmCat.ValueMember = "category_id"
        ''''
        generateObj()
        If formInsert.editmode = True Then
            fillingData()
            btAdd.Text = "Edit"
        Else
            btAdd.Text = "Add"
        End If
    End Sub


    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Close()
    End Sub
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        If formInsert.mode = "menu" And (tbID.Text = "" Or tbName.Text = "" Or cmStat.Text = "" Or cmCat.Text = "" Or tbPrice.Text = "") Then
            MsgBox("Fill all the blank(s)")
        ElseIf formInsert.mode = "ingredients" And (tbID.Text = "" Or tbName.Text = "" Or cmStat.Text = "" Or tbStock.Text = "") Then
            MsgBox("Fill all the blank(s)")
        ElseIf formInsert.mode = "table" And (tbID.Text = "" Or tbName.Text = "" Or cmStat.Text = "" Or cmSeat.Text = "") Then
            MsgBox("Fill all the blank(s)")
        ElseIf formInsert.mode = "category" And (tbID.Text = "" Or tbName.Text = "" Or cmStat.Text = "") Then
            MsgBox("Fill all the blank(s)")
        Else
            If btAdd.Text = "Add" Then
                Try
                    sqlConnect.Open()
                    If formInsert.mode = "menu" Then
                        sqlQuery = "INSERT INTO menu VALUES ('" + tbID.Text + "','" + tbName.Text + "','" + cmCat.SelectedValue.ToString + "','" + tbPrice.Text.ToString + "','" + cmStat.SelectedIndex.ToString + "', 0);"
                    ElseIf formInsert.mode = "ingredients" Then
                        sqlQuery = "INSERT INTO ingredients VALUES ('" + tbID.Text + "','" + tbName.Text + "','" + tbStock.Text.ToString + "','" + cmStat.SelectedIndex.ToString + "', 0);"
                    ElseIf formInsert.mode = "table" Then
                        sqlQuery = "INSERT INTO `table` VALUES ('" + tbID.Text + "','" + tbName.Text + "','" + cmSeat.Text.ToString + "','" + cmStat.SelectedIndex.ToString + "', 0);"
                    ElseIf formInsert.mode = "category" Then
                        sqlQuery = "INSERT INTO category VALUES ('" + tbID.Text + "','" + tbName.Text + "','" + cmStat.SelectedIndex.ToString + "', 0);"
                    End If
                    sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                    sqlCommand.ExecuteNonQuery()
                    MsgBox("Inserting new " + formInsert.mode + " : '" + tbID.Text + "' Success!")
                    sqlConnect.Close()
                Catch ex As Exception
                    sqlConnect.Close()
                    MsgBox(ex.Message)
                End Try
            ElseIf btAdd.Text = "Edit" Then
                Try
                    sqlConnect.Open()
                    sqlQuery = "UPDATE `" + formInsert.mode.ToString + "` SET " + formInsert.mode.ToString + "_name = '" + tbName.Text.ToString + "', " + formInsert.mode.ToString + "_status = '" + cmStat.SelectedIndex.ToString + "'"
                    If formInsert.mode = "menu" Then
                        sqlQuery += ", category_id = '" + cmCat.SelectedValue.ToString + "', sell_price = '" + tbPrice.Text.ToString + "'"
                    ElseIf formInsert.mode = "ingredients" Then
                        sqlQuery += ", `stocks` = '" + tbStock.Text.ToString + "'"
                    ElseIf formInsert.mode = "table" Then
                        sqlQuery += ", seats_available = '" + cmSeat.Value.ToString + "'"
                    End If
                    sqlQuery += " WHERE " + formInsert.mode.ToString + "_id = '" + tbID.Text.ToString + "';"
                    sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                    sqlCommand.ExecuteNonQuery()
                    MsgBox("Updating " + formInsert.mode + " data : '" + tbID.Text + "' Success!")
                    sqlConnect.Close()
                Catch ex As Exception
                    sqlConnect.Close()
                    MsgBox(ex.Message)
                End Try
            End If
            formInsert.refreshDGV()
            If btAdd.Text = "Add" Then
                If formInsert.mode = "menu" Then
                    FormIngredients.Show()
                End If
            End If
            Me.Close()
        End If
    End Sub

    Sub autoID()
        If formInsert.editmode = False Then
            Try
                'Auto Generate ID
                autogenerateID = ""
                dt_Datacount = New DataTable
                sqlQuery = "SELECT * FROM `" + formInsert.mode.ToString + "`;"
                sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                sqlAdapter = New MySqlDataAdapter(sqlCommand)
                sqlAdapter.Fill(dt_Datacount)
                'IF MEMBER IS CHECKED AND NOT
                autogenerateID = formInsert.mode.ToString.Substring(0, 1).ToUpper
                'For Putting Zeroes
                If dt_Datacount.Rows.Count >= 99 Then
                    autogenerateID = autogenerateID + ((dt_Datacount.Rows.Count + 1).ToString)
                ElseIf dt_Datacount.Rows.Count >= 9 Then
                    autogenerateID = autogenerateID + "0" + ((dt_Datacount.Rows.Count + 1).ToString)
                ElseIf dt_Datacount.Rows.Count >= 0 Then
                    autogenerateID = autogenerateID + "00" + ((dt_Datacount.Rows.Count + 1).ToString)
                End If
                tbID.Text = autogenerateID
            Catch ex As Exception
                If tbName.Text.Length <> 0 Then
                    MsgBox(ex.Message)
                End If
            End Try
        End If
    End Sub

    Sub eraseData()
        tbID.Text = ""
        tbName.Text = ""
        cmStat.Text = ""
        ''' Menu
        If formInsert.mode = "menu" Then
            cmCat.Text = ""
            tbPrice.Text = ""
        ElseIf formInsert.mode = "ingredients" Then
            ''' Ingredient
            tbStock.Text = ""
        ElseIf formInsert.mode = "table" Then
            ''' Table
            cmSeat.Value = ""
        End If
    End Sub
    Sub fillingData()
        tbID.Text = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("ID")).ToString
        tbName.Text = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("Name")).ToString
        cmStat.Text = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("Status")).ToString
        ''' Menu
        If formInsert.mode = "menu" Then
            cmCat.Text = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("Category")).ToString
            tbPrice.Text = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("Price")).ToString
        ElseIf formInsert.mode = "ingredients" Then
            ''' Ingredient
            tbStock.Text = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("Stock")).ToString
        ElseIf formInsert.mode = "table" Then
            ''' Table
            cmSeat.Value = (formInsert.dt_View.Rows(formInsert.dgAdmin.CurrentRow.Index)("Seats Available")).ToString
        End If
    End Sub
    Sub generateObj()
        '''      VISIBILITY      '''
        lbID.Visible = True
        tbID.Visible = True
        tbID.Enabled = False
        lbName.Visible = True
        tbName.Visible = True
        lbStat.Visible = False
        cmStat.Visible = False
        lbCat.Visible = False
        cmCat.Visible = False
        lbPrice.Visible = False
        tbPrice.Visible = False
        lbStock.Visible = False
        tbStock.Visible = False
        lbSeat.Visible = False
        cmSeat.Visible = False
        ''''''''''''''''''''''''''''
        '''       OBJPROPS       '''
        With lbID
            .Parent = Me
            .Location = New Point(330, locy(1))
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .BackColor = Color.Transparent
            .ForeColor = Color.White
            .Text = "ID"
        End With
        With tbID
            .Parent = Me
            .Location = New Point(432, locy(1))
            .Width = 139
        End With
        With lbName
            .Parent = Me
            .Location = New Point(330, locy(2))
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .BackColor = Color.Transparent
            .ForeColor = Color.White
            .Text = "Name"
        End With
        With tbName
            .Parent = Me
            .Location = New Point(432, locy(2))
            .Width = 139
        End With
        With cmStat
            .Items.Add("Non-Active")
            .Items.Add("Active")
        End With
        ''''''''''''''''''''''''''''
        '''      OBJPROPSEL      '''
        If formInsert.mode = "menu" Then
            With lbCat
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(3))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Category"
            End With
            With cmCat
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(3))
                .Width = 139
            End With
            With lbPrice
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(4))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Price"
            End With
            With tbPrice
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(4))
                .Width = 139
            End With
            With lbStat
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(5))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Status"
            End With
            With cmStat
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(5))
                .Width = 139
            End With
        ElseIf formInsert.mode = "ingredients" Then
            With lbStock
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(3))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Stock"
            End With
            With tbStock
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(3))
                .Width = 139
            End With
            With lbStat
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(4))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Status"
            End With
            With cmStat
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(4))
                .Width = 139
            End With
        ElseIf formInsert.mode = "table" Then
            With lbSeat
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(3))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Seat Available"
            End With
            With cmSeat
                .Parent = Me
                .Visible = True
                .TextAlign = 0
                .Location = New Point(432, locy(3))
                .Width = 139
            End With
            With lbStat
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(4))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Status"
            End With
            With cmStat
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(4))
                .Width = 139
            End With
        ElseIf formInsert.mode = "category" Then
            With lbStat
                .Parent = Me
                .Visible = True
                .Location = New Point(330, locy(3))
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.Transparent
                .ForeColor = Color.White
                .Text = "Status"
            End With
            With cmStat
                .Parent = Me
                .Visible = True
                .Location = New Point(432, locy(3))
                .Width = 139
            End With
        End If
        ''''''''''''''''''''''''''''
    End Sub

    Private Sub btIngredient_Click(sender As Object, e As EventArgs) Handles btIngredient.Click
        FormIngredients.Show()
    End Sub
End Class