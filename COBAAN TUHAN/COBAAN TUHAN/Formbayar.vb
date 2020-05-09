Public Class Formbayar
    Dim simpan As Integer
    Private Sub BTsubmit_Click(sender As Object, e As EventArgs) Handles BTsubmit.Click
        If CInt(Form_pembelian.LLangkatotal.Text) > NUDangka.Value Then
            MsgBox("Uang masih kurang oi!!!")
        Else
            Form_pembelian.penyimpan = NUDangka.Value - Form_pembelian.penyimpan
            Form_pembelian.LLangkabayar.Text = NUDangka.Value
            Form_pembelian.LLangkakembalian.Text = Form_pembelian.penyimpan
            Me.Close()
        End If
    End Sub
End Class