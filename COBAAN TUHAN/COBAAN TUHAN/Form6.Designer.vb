<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuUtamaKas = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.MenuKas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuPay = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuLogout = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBuka = New System.Windows.Forms.Button()
        Me.TbSelisih = New System.Windows.Forms.TextBox()
        Me.TbPengeluaran = New System.Windows.Forms.TextBox()
        Me.TbPendapatan = New System.Windows.Forms.TextBox()
        Me.TbAwal = New System.Windows.Forms.TextBox()
        Me.DtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TmMulai = New System.Windows.Forms.Timer(Me.components)
        Me.TmSelesai = New System.Windows.Forms.Timer(Me.components)
        Me.DtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbFisik = New System.Windows.Forms.TextBox()
        Me.MtbAkhir = New System.Windows.Forms.MaskedTextBox()
        CType(Me.MenuUtamaKas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuUtamaKas
        '
        Me.MenuUtamaKas.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.MenuUtamaKas.Appearance.AccordionControl.Options.UseBackColor = True
        Me.MenuUtamaKas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuUtamaKas.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuUtamaKas.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.MenuKas, Me.MenuPay, Me.MenuLogout})
        Me.MenuUtamaKas.Location = New System.Drawing.Point(0, 0)
        Me.MenuUtamaKas.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuUtamaKas.Name = "MenuUtamaKas"
        Me.MenuUtamaKas.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Overlay
        Me.MenuUtamaKas.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
        Me.MenuUtamaKas.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.MenuUtamaKas.Size = New System.Drawing.Size(48, 720)
        Me.MenuUtamaKas.TabIndex = 2
        Me.MenuUtamaKas.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'MenuKas
        '
        Me.MenuKas.Appearance.Disabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.MenuKas.Appearance.Disabled.Options.UseBackColor = True
        Me.MenuKas.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.MenuKas.Appearance.Hovered.Options.UseBackColor = True
        Me.MenuKas.Name = "MenuKas"
        Me.MenuKas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.MenuKas.Text = "Kas"
        '
        'MenuPay
        '
        Me.MenuPay.Appearance.Disabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.MenuPay.Appearance.Disabled.Options.UseBackColor = True
        Me.MenuPay.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.MenuPay.Appearance.Hovered.Options.UseBackColor = True
        Me.MenuPay.Name = "MenuPay"
        Me.MenuPay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.MenuPay.Text = "Payment"
        '
        'MenuLogout
        '
        Me.MenuLogout.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.MenuLogout.Appearance.Hovered.Options.UseBackColor = True
        Me.MenuLogout.ImageOptions.Image = Global.COBAAN_TUHAN.My.Resources.Resources.Logout1
        Me.MenuLogout.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze
        Me.MenuLogout.Name = "MenuLogout"
        Me.MenuLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.MenuLogout.Text = "Logout"
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(454, 118)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 67
        Me.BtnTutup.Text = "Tutup Kasir"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBuka
        '
        Me.BtnBuka.Location = New System.Drawing.Point(454, 80)
        Me.BtnBuka.Name = "BtnBuka"
        Me.BtnBuka.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuka.TabIndex = 66
        Me.BtnBuka.Text = "Buka Kasir"
        Me.BtnBuka.UseVisualStyleBackColor = True
        '
        'TbSelisih
        '
        Me.TbSelisih.Location = New System.Drawing.Point(251, 250)
        Me.TbSelisih.Name = "TbSelisih"
        Me.TbSelisih.Size = New System.Drawing.Size(130, 20)
        Me.TbSelisih.TabIndex = 65
        '
        'TbPengeluaran
        '
        Me.TbPengeluaran.Location = New System.Drawing.Point(251, 153)
        Me.TbPengeluaran.Name = "TbPengeluaran"
        Me.TbPengeluaran.Size = New System.Drawing.Size(130, 20)
        Me.TbPengeluaran.TabIndex = 62
        Me.TbPengeluaran.Text = "0"
        Me.TbPengeluaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPendapatan
        '
        Me.TbPendapatan.Location = New System.Drawing.Point(251, 120)
        Me.TbPendapatan.Name = "TbPendapatan"
        Me.TbPendapatan.Size = New System.Drawing.Size(130, 20)
        Me.TbPendapatan.TabIndex = 61
        Me.TbPendapatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbAwal
        '
        Me.TbAwal.Location = New System.Drawing.Point(251, 87)
        Me.TbAwal.Name = "TbAwal"
        Me.TbAwal.Size = New System.Drawing.Size(130, 20)
        Me.TbAwal.TabIndex = 60
        '
        'DtpMulai
        '
        Me.DtpMulai.CustomFormat = "dd-MM-yyyy   HH:mm"
        Me.DtpMulai.Enabled = False
        Me.DtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpMulai.Location = New System.Drawing.Point(251, 54)
        Me.DtpMulai.Name = "DtpMulai"
        Me.DtpMulai.Size = New System.Drawing.Size(130, 20)
        Me.DtpMulai.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Selisih"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Fisik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Saldo Akhir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Total Pengeluaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Total Pendapatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Saldo Awal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 52
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
        'DtpSelesai
        '
        Me.DtpSelesai.CustomFormat = "dd-MM-yyyy   HH:mm"
        Me.DtpSelesai.Enabled = False
        Me.DtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpSelesai.Location = New System.Drawing.Point(251, 290)
        Me.DtpSelesai.Name = "DtpSelesai"
        Me.DtpSelesai.Size = New System.Drawing.Size(130, 20)
        Me.DtpSelesai.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Selesai"
        '
        'TbFisik
        '
        Me.TbFisik.Location = New System.Drawing.Point(251, 217)
        Me.TbFisik.Name = "TbFisik"
        Me.TbFisik.Size = New System.Drawing.Size(130, 20)
        Me.TbFisik.TabIndex = 64
        '
        'MtbAkhir
        '
        Me.MtbAkhir.Location = New System.Drawing.Point(251, 187)
        Me.MtbAkhir.Name = "MtbAkhir"
        Me.MtbAkhir.Size = New System.Drawing.Size(130, 20)
        Me.MtbAkhir.TabIndex = 70
        Me.MtbAkhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.wallpaper_wiki_Download_Images_Food_HD_PIC_WPD006571
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.MtbAkhir)
        Me.Controls.Add(Me.DtpSelesai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBuka)
        Me.Controls.Add(Me.TbSelisih)
        Me.Controls.Add(Me.TbFisik)
        Me.Controls.Add(Me.TbPengeluaran)
        Me.Controls.Add(Me.TbPendapatan)
        Me.Controls.Add(Me.TbAwal)
        Me.Controls.Add(Me.DtpMulai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuUtamaKas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKas"
        Me.Text = "Form6"
        CType(Me.MenuUtamaKas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuUtamaKas As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents MenuKas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuPay As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuLogout As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnBuka As Button
    Friend WithEvents TbSelisih As TextBox
    Friend WithEvents TbPengeluaran As TextBox
    Friend WithEvents TbPendapatan As TextBox
    Friend WithEvents TbAwal As TextBox
    Friend WithEvents DtpMulai As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TmMulai As Timer
    Friend WithEvents TmSelesai As Timer
    Friend WithEvents DtpSelesai As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TbFisik As TextBox
    Friend WithEvents MtbAkhir As MaskedTextBox
End Class
