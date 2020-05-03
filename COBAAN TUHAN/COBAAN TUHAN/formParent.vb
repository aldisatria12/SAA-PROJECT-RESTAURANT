Public Class formParent
    Private Sub formParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLogin.MdiParent = Me
        formInsert.Top = 0
        formInsert.Left = 0
        formLogin.Show()
    End Sub
End Class