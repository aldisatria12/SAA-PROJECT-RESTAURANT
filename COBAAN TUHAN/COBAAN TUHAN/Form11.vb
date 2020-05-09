Public Class FormKeterangan
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If RtbKet.Text <> "" Then
            FormMenu.DgvMenu.Rows(FormMenu.R).Cells(1).Value = RtbKet.Text
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class