Public Class FormKeterangan
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If RtbKet.Text <> "" Then
            FormMenu.DgvMenu.Rows(FormMenu.R).Cells(1).Value = RtbKet.Text
            Me.Hide()
        Else
            Me.Hide()
        End If
    End Sub
End Class