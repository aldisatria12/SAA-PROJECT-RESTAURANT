Imports MySql.Data.MySqlClient

Public Class FormIngredients
    Dim constring As String = "server=localhost;uid=root;password=;database=restaurant"
    Dim sqlConnect As New MySqlConnection(constring)
    Dim sqlCommand As New MySqlCommand
    Dim sqlAdapter As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim dt_Ingredients As New DataTable
    Dim dt_edtIng
    Dim pbAdd As New DataGridViewImageColumn
    Dim pbMin As New DataGridViewImageColumn
    Dim qty As Integer
    Dim menuID As String
    Dim edited As Boolean
    Private Sub FormIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuID = formAdd.tbID.Text.ToString
        Me.Top = formAdd.Top
        Me.Left = formAdd.Left
        pbMin.Name = "pbMin"
        pbMin.HeaderText = ""
        pbMin.Width = 35
        pbMin.Image = My.Resources.minus
        pbMin.ImageLayout = DataGridViewImageCellLayout.Zoom

        pbAdd.Name = "pbAdd"
        pbAdd.HeaderText = ""
        pbAdd.Width = 35
        pbAdd.Image = My.Resources.plus
        pbAdd.ImageLayout = DataGridViewImageCellLayout.Zoom

        ''' FILLING INGREDIENTS DATATABLE
        Try
            dt_Ingredients = New DataTable
            sqlQuery = "SELECT ingredients_id `ID`, ingredients_name `Name`, '0' `Amount` FROM ingredients i WHERE ingredients_delete = 0"
            sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlAdapter.Fill(dt_Ingredients)
            With dgIngredients
                .DataSource = dt_Ingredients
                .Columns.Add(pbAdd)
                .Columns.Add(pbMin)
            End With
        Catch ex As Exception

        End Try

        ''' FILLING EDIT INGREDIENTS DATATABLE
        Try
            dt_edtIng = New DataTable
            sqlQuery = "SELECT * FROM dmenu d WHERE menu_id = '" + menuID + "';"
            sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
            sqlAdapter = New MySqlDataAdapter(sqlCommand)
            sqlAdapter.Fill(dt_edtIng)

        Catch ex As Exception

        End Try


        If formInsert.editmode = True Then
            For i = 0 To dt_edtIng.Rows.Count - 1
                For j = 0 To dgIngredients.Rows.Count - 1
                    If dt_edtIng.rows(i)("ingredients_id").ToString = dgIngredients.Rows(j).Cells(0).Value Then
                        dgIngredients.Rows(j).Cells(2).Value = dt_edtIng.rows(i)("amount_used").ToString
                    End If
                Next
            Next
        End If

    End Sub

    Private Sub btApply_Click(sender As Object, e As EventArgs) Handles btApply.Click
        If formInsert.editmode = True Then
            For i = 0 To dgIngredients.Rows.Count - 1
                edited = False
                If dgIngredients.Rows(i).Cells(2).Value <> 0 Then
                    For k = 0 To dt_edtIng.Rows.Count - 1
                        If dt_edtIng.rows(k)("ingredients_id").ToString = dgIngredients.Rows(i).Cells(0).Value Then
                            sqlConnect.Open()
                            sqlQuery = "UPDATE dmenu SET amount_used = '" + dgIngredients.Rows(i).Cells(2).Value.ToString + "' WHERE menu_id = '" + menuID.ToString + "' AND ingredients_id = '" + dgIngredients.Rows(i).Cells(0).Value.ToString + "';"
                            sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                            sqlCommand.ExecuteNonQuery()
                            sqlConnect.Close()
                            edited = True
                        End If
                    Next
                    If edited = False Then
                        sqlConnect.Open()
                        sqlQuery = "INSERT INTO dmenu VALUES ('" + menuID.ToString + "','" + dgIngredients.Rows(i).Cells(0).Value.ToString + "','" + dgIngredients.Rows(i).Cells(2).Value.ToString + "');"
                        sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                        sqlCommand.ExecuteNonQuery()
                        sqlConnect.Close()
                    End If
                End If
            Next
        ElseIf formInsert.editmode = False Then
            For i = 0 To dgIngredients.Rows.Count - 1
                If dgIngredients.Rows(i).Cells(2).Value <> 0 Then
                    sqlConnect.Open()
                    sqlQuery = "INSERT INTO dmenu VALUES ('" + menuID.ToString + "','" + dgIngredients.Rows(i).Cells(0).Value.ToString + "','" + dgIngredients.Rows(i).Cells(2).Value.ToString + "');"
                    sqlCommand = New MySqlCommand(sqlQuery, sqlConnect)
                    sqlCommand.ExecuteNonQuery()
                    sqlConnect.Close()
                End If
            Next
        End If
        Me.Close()
    End Sub

    Private Sub dgIngredients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgIngredients.CellClick
        If dgIngredients.CurrentCell.OwningColumn.Name = "pbMin" Then
            qty = CInt(dgIngredients.Rows(e.RowIndex).Cells(2).Value)
            qty -= 1
            dgIngredients.Rows(e.RowIndex).Cells(2).Value = qty.ToString
        ElseIf dgIngredients.CurrentCell.OwningColumn.Name = "pbAdd" Then
            qty = CInt(dgIngredients.Rows(e.RowIndex).Cells(2).Value)
            qty += 1
            dgIngredients.Rows(e.RowIndex).Cells(2).Value = qty.ToString
        End If
    End Sub

End Class