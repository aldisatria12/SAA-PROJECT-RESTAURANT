Public Class formAdd
    'Used by all
    Dim lbID As New Label
    Dim lbName As New Label
    Dim lbStat As New Label
    Dim tbID As New TextBox
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
    Dim cmSeat As New ComboBox

    Private Sub formAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateObj()
    End Sub

    Sub generateObj()
        '''      VISIBILITY      '''
        lbID.Visible = False
        tbID.Visible = False
        lbName.Visible = False
        tbName.Visible = False
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

        ''''''''''''''''''''''''''''
        If formInsert.mode = "menu" Then

        End If
    End Sub
End Class