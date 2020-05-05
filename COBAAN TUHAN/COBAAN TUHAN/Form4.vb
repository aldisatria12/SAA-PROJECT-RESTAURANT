Public Class FormKas
    Dim C As String 'Angka full
    Dim B As Integer = 0 'Integer dr C
    Private Sub FormKas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnTutup.Enabled = False
        TmMulai.Enabled = True
        TmSelesai.Enabled = True
        TbPendapatan.Enabled = False
        TbPengeluaran.Enabled = False
        TbSelisih.Enabled = False
        TbAkhir.Enabled = False
        TbFisik.Enabled = False
        TbSelisih.Enabled = False
        DtpMulai.Value = Now
        DtpSelesai.Value = Now
    End Sub

    Private Sub TmMulai_Tick(sender As Object, e As EventArgs) Handles TmMulai.Tick
        DtpMulai.Value = Now
    End Sub

    Private Sub TmSelesai_Tick(sender As Object, e As EventArgs) Handles TmSelesai.Tick
        DtpSelesai.Value = Now
    End Sub

    Private Sub BtnBuka_Click(sender As Object, e As EventArgs) Handles BtnBuka.Click
        If TbAwal.Text <> "" Then
            BtnTutup.Enabled = True
            BtnBuka.Enabled = False
            TbAwal.Enabled = False
            TmMulai.Enabled = False
            TbPendapatan.Enabled = True
            TbPengeluaran.Enabled = True
            TbSelisih.Enabled = True
            TbAkhir.Enabled = True
            TbSelisih.Enabled = True
            TbFisik.Enabled = True
        Else
            MsgBox("Data belum diisi")
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If TbAkhir.Text <> "" And TbFisik.Text <> "" And TbPendapatan.Text <> "" And TbPengeluaran.Text <> "" And TbSelisih.Text <> "" Then
            MsgBox("Tutup Kasir Berhasil")
            BtnTutup.Enabled = False
            BtnBuka.Enabled = True
            TmMulai.Enabled = True
            TbPendapatan.Enabled = False
            TbPengeluaran.Enabled = False
            TbSelisih.Enabled = False
            TbAkhir.Enabled = False
            TbFisik.Enabled = False
            TbAwal.Enabled = True
            TbPendapatan.Text = ""
            TbPengeluaran.Text = ""
            TbSelisih.Text = ""
            TbAkhir.Text = ""
            TbFisik.Text = ""
            TbAwal.Text = ""
        Else
            MsgBox("Masih ada data yang kosong")
        End If
    End Sub

    Sub Textbox(sender As Object, e As EventArgs)
        Try
            C = ""
            Dim A = sender.Text.Split(".")
            For i = 0 To A.Length - 1
                C = C + A(i)
            Next
            B = CInt(C)
            If sender.Text.Length = 2 Then
                If sender.Text.Substring(0, 1) = "0" Then
                    sender.Text = sender.Text.Remove(sender.Text.Length - 1, 1)
                    MsgBox("Angka yang diinput salah")
                End If
            End If
        Catch ex As Exception
            If sender.Text.Length = 1 Then
                sender.Text = ""
                MsgBox("Input tidak berupa angka")
            ElseIf sender.Text.Length > 1 Then
                sender.Text = sender.Text.Substring(0, sender.Text.Length - 1)
                MsgBox("Input tidak berupa angka")
            End If
        End Try
    End Sub

    Private Sub TbAwal_TextChanged(sender As Object, e As EventArgs) Handles TbAwal.TextChanged
        Call Textbox(sender, e)
    End Sub

    Private Sub TbFisik_TextChanged(sender As Object, e As EventArgs) Handles TbFisik.TextChanged
        Call Textbox(sender, e)
    End Sub
End Class