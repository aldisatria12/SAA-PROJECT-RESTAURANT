<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBuka = New System.Windows.Forms.Button()
        Me.TbSelisih = New System.Windows.Forms.TextBox()
        Me.TbFisik = New System.Windows.Forms.TextBox()
        Me.TbAkhir = New System.Windows.Forms.TextBox()
        Me.TbPengeluaran = New System.Windows.Forms.TextBox()
        Me.TbPendapatan = New System.Windows.Forms.TextBox()
        Me.TbAwal = New System.Windows.Forms.TextBox()
        Me.DtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.DtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TmMulai = New System.Windows.Forms.Timer(Me.components)
        Me.TmSelesai = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(490, 125)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 53
        Me.BtnTutup.Text = "Tutup Kasir"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBuka
        '
        Me.BtnBuka.Location = New System.Drawing.Point(490, 87)
        Me.BtnBuka.Name = "BtnBuka"
        Me.BtnBuka.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuka.TabIndex = 52
        Me.BtnBuka.Text = "Buka Kasir"
        Me.BtnBuka.UseVisualStyleBackColor = True
        '
        'TbSelisih
        '
        Me.TbSelisih.Location = New System.Drawing.Point(272, 257)
        Me.TbSelisih.Name = "TbSelisih"
        Me.TbSelisih.Size = New System.Drawing.Size(130, 20)
        Me.TbSelisih.TabIndex = 51
        '
        'TbFisik
        '
        Me.TbFisik.Location = New System.Drawing.Point(272, 224)
        Me.TbFisik.Name = "TbFisik"
        Me.TbFisik.Size = New System.Drawing.Size(130, 20)
        Me.TbFisik.TabIndex = 50
        '
        'TbAkhir
        '
        Me.TbAkhir.Location = New System.Drawing.Point(272, 191)
        Me.TbAkhir.Name = "TbAkhir"
        Me.TbAkhir.Size = New System.Drawing.Size(130, 20)
        Me.TbAkhir.TabIndex = 49
        '
        'TbPengeluaran
        '
        Me.TbPengeluaran.Location = New System.Drawing.Point(272, 160)
        Me.TbPengeluaran.Name = "TbPengeluaran"
        Me.TbPengeluaran.Size = New System.Drawing.Size(130, 20)
        Me.TbPengeluaran.TabIndex = 48
        '
        'TbPendapatan
        '
        Me.TbPendapatan.Location = New System.Drawing.Point(272, 127)
        Me.TbPendapatan.Name = "TbPendapatan"
        Me.TbPendapatan.Size = New System.Drawing.Size(130, 20)
        Me.TbPendapatan.TabIndex = 47
        '
        'TbAwal
        '
        Me.TbAwal.Location = New System.Drawing.Point(272, 94)
        Me.TbAwal.Name = "TbAwal"
        Me.TbAwal.Size = New System.Drawing.Size(130, 20)
        Me.TbAwal.TabIndex = 46
        '
        'DtpSelesai
        '
        Me.DtpSelesai.CustomFormat = "dd-MM-yyyy   HH:mm"
        Me.DtpSelesai.Enabled = False
        Me.DtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpSelesai.Location = New System.Drawing.Point(272, 290)
        Me.DtpSelesai.Name = "DtpSelesai"
        Me.DtpSelesai.Size = New System.Drawing.Size(130, 20)
        Me.DtpSelesai.TabIndex = 45
        '
        'DtpMulai
        '
        Me.DtpMulai.CustomFormat = "dd-MM-yyyy   HH:mm"
        Me.DtpMulai.Enabled = False
        Me.DtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpMulai.Location = New System.Drawing.Point(272, 61)
        Me.DtpMulai.Name = "DtpMulai"
        Me.DtpMulai.Size = New System.Drawing.Size(130, 20)
        Me.DtpMulai.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Selesai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Selisih"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(164, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Fisik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Saldo Akhir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Total Pengeluaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Total Pendapatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Saldo Awal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Mulai"
        '
        'TmMulai
        '
        Me.TmMulai.Enabled = True
        '
        'TmSelesai
        '
        Me.TmSelesai.Enabled = True
        '
        'FormKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBuka)
        Me.Controls.Add(Me.TbSelisih)
        Me.Controls.Add(Me.TbFisik)
        Me.Controls.Add(Me.TbAkhir)
        Me.Controls.Add(Me.TbPengeluaran)
        Me.Controls.Add(Me.TbPendapatan)
        Me.Controls.Add(Me.TbAwal)
        Me.Controls.Add(Me.DtpSelesai)
        Me.Controls.Add(Me.DtpMulai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKas"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnBuka As Button
    Friend WithEvents TbSelisih As TextBox
    Friend WithEvents TbFisik As TextBox
    Friend WithEvents TbAkhir As TextBox
    Friend WithEvents TbPengeluaran As TextBox
    Friend WithEvents TbPendapatan As TextBox
    Friend WithEvents TbAwal As TextBox
    Friend WithEvents DtpSelesai As DateTimePicker
    Friend WithEvents DtpMulai As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TmMulai As Timer
    Friend WithEvents TmSelesai As Timer
End Class
