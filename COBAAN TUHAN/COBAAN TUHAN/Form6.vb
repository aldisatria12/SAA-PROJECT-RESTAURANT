Public Class FormKas
    Dim C As String 'Angka full
    Dim B As Integer = 0 'Integer dr C


    Private Sub FormKas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.MdiParent = formParent
        MenuKas.Enabled = False
        BtnTutup.Enabled = False
        TmMulai.Enabled = True
        TmSelesai.Enabled = True
        TbPendapatan.Enabled = False
        TbPengeluaran.Enabled = False
        TbSelisih.Enabled = False
        MtbAkhir.Enabled = False
        TbFisik.Enabled = False
        TbSelisih.Enabled = False
        DtpMulai.Value = Now
        DtpSelesai.Value = Now
        If formParent.Buka = 1 Then
            TbAwal.Text = formParent.Pendapatan
            BtnTutup.Enabled = True
            BtnBuka.Enabled = False
            TbAwal.Enabled = False
            TmMulai.Enabled = False
            TbPendapatan.Enabled = False
            TbPengeluaran.Enabled = False
            TbSelisih.Enabled = False
            MtbAkhir.Enabled = False
            TbFisik.Enabled = True
        End If
    End Sub
    Private Sub TmMulai_Tick(sender As Object, e As EventArgs) Handles TmMulai.Tick
        DtpMulai.Value = Now
    End Sub

    Private Sub TmSelesai_Tick(sender As Object, e As EventArgs) Handles TmSelesai.Tick
        TbPendapatan.Text = formParent.Pendapatan.ToString
        DtpSelesai.Value = Now
    End Sub

    Private Sub BtnBuka_Click(sender As Object, e As EventArgs) Handles BtnBuka.Click
        If TbAwal.Text <> "" Then
            formParent.Buka = 1
            formParent.Pendapatan = CInt(TbAwal.Text)
            BtnTutup.Enabled = True
            BtnBuka.Enabled = False
            TbAwal.Enabled = False
            TmMulai.Enabled = False
            TbPendapatan.Enabled = False
            TbPengeluaran.Enabled = False
            TbSelisih.Enabled = False
            MtbAkhir.Enabled = False
            TbFisik.Enabled = True
        Else
            MsgBox("Data belum diisi")
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If MtbAkhir.Text <> "" And TbFisik.Text <> "" And TbPendapatan.Text <> "" And TbPengeluaran.Text <> "" And TbSelisih.Text <> "" Then
            MsgBox("Tutup Kasir Berhasil")
            formParent.Buka = 0
            formParent.Pendapatan = 0
            BtnTutup.Enabled = False
            BtnBuka.Enabled = True
            TmMulai.Enabled = True
            TbPendapatan.Enabled = False
            TbPengeluaran.Enabled = False
            TbSelisih.Enabled = False
            MtbAkhir.Enabled = False
            TbFisik.Enabled = False
            TbAwal.Enabled = True
            TbPendapatan.Text = ""
            TbPengeluaran.Text = ""
            TbSelisih.Text = ""
            MtbAkhir.Text = ""
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
        If TbFisik.Text.Length > 0 Then
            If formParent.Buka = 1 Then
                TbSelisih.Text = CInt(TbFisik.Text) - CInt(MtbAkhir.Text)
            End If
        Else
            TbSelisih.Text = ""
        End If
    End Sub

    Private Sub MenuPay_Click(sender As Object, e As EventArgs) Handles MenuPay.Click
        If formParent.Buka = 1 Then
            FormPay.MdiParent = formParent
            FormPay.Left = 0
            FormPay.Top = 0
            FormPay.Show()
            Me.Close()
        ElseIf formParent.Buka = 0 Then
            MsgBox("Kas Belum Dibuka")
        End If
    End Sub

    Private Sub MenuLogout_Click(sender As Object, e As EventArgs) Handles MenuLogout.Click
        Me.Close()
    End Sub

    Private Sub TbPendapatan_TextChanged(sender As Object, e As EventArgs) Handles TbPendapatan.TextChanged
        MtbAkhir.Text = TbPendapatan.Text
    End Sub

End Class