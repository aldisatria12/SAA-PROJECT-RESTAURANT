<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKas2
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

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
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
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
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.MenuKas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuPay = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuLogout = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        Me.TmMulai = New System.Windows.Forms.Timer(Me.components)
        Me.TmSelesai = New System.Windows.Forms.Timer(Me.components)
        Me.FluentDesignFormContainer1.SuspendLayout()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.wallpaper_wiki_Download_Images_Food_HD_PIC_WPD006571
        Me.FluentDesignFormContainer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FluentDesignFormContainer1.Controls.Add(Me.BtnTutup)
        Me.FluentDesignFormContainer1.Controls.Add(Me.BtnBuka)
        Me.FluentDesignFormContainer1.Controls.Add(Me.TbSelisih)
        Me.FluentDesignFormContainer1.Controls.Add(Me.TbFisik)
        Me.FluentDesignFormContainer1.Controls.Add(Me.TbAkhir)
        Me.FluentDesignFormContainer1.Controls.Add(Me.TbPengeluaran)
        Me.FluentDesignFormContainer1.Controls.Add(Me.TbPendapatan)
        Me.FluentDesignFormContainer1.Controls.Add(Me.TbAwal)
        Me.FluentDesignFormContainer1.Controls.Add(Me.DtpSelesai)
        Me.FluentDesignFormContainer1.Controls.Add(Me.DtpMulai)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label8)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label7)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label6)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label5)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label4)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label3)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label2)
        Me.FluentDesignFormContainer1.Controls.Add(Me.Label1)
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(48, 31)
        Me.FluentDesignFormContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(874, 480)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(408, 113)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 71
        Me.BtnTutup.Text = "Tutup Kasir"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBuka
        '
        Me.BtnBuka.Location = New System.Drawing.Point(408, 75)
        Me.BtnBuka.Name = "BtnBuka"
        Me.BtnBuka.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuka.TabIndex = 70
        Me.BtnBuka.Text = "Buka Kasir"
        Me.BtnBuka.UseVisualStyleBackColor = True
        '
        'TbSelisih
        '
        Me.TbSelisih.Location = New System.Drawing.Point(190, 245)
        Me.TbSelisih.Name = "TbSelisih"
        Me.TbSelisih.Size = New System.Drawing.Size(130, 21)
        Me.TbSelisih.TabIndex = 69
        '
        'TbFisik
        '
        Me.TbFisik.Location = New System.Drawing.Point(190, 212)
        Me.TbFisik.Name = "TbFisik"
        Me.TbFisik.Size = New System.Drawing.Size(130, 21)
        Me.TbFisik.TabIndex = 68
        '
        'TbAkhir
        '
        Me.TbAkhir.Location = New System.Drawing.Point(190, 179)
        Me.TbAkhir.Name = "TbAkhir"
        Me.TbAkhir.Size = New System.Drawing.Size(130, 21)
        Me.TbAkhir.TabIndex = 67
        '
        'TbPengeluaran
        '
        Me.TbPengeluaran.Location = New System.Drawing.Point(190, 148)
        Me.TbPengeluaran.Name = "TbPengeluaran"
        Me.TbPengeluaran.Size = New System.Drawing.Size(130, 21)
        Me.TbPengeluaran.TabIndex = 66
        '
        'TbPendapatan
        '
        Me.TbPendapatan.Location = New System.Drawing.Point(190, 115)
        Me.TbPendapatan.Name = "TbPendapatan"
        Me.TbPendapatan.Size = New System.Drawing.Size(130, 21)
        Me.TbPendapatan.TabIndex = 65
        '
        'TbAwal
        '
        Me.TbAwal.Location = New System.Drawing.Point(190, 82)
        Me.TbAwal.Name = "TbAwal"
        Me.TbAwal.Size = New System.Drawing.Size(130, 21)
        Me.TbAwal.TabIndex = 64
        '
        'DtpSelesai
        '
        Me.DtpSelesai.CustomFormat = "dd-MM-yyyy   HH:mm"
        Me.DtpSelesai.Enabled = False
        Me.DtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpSelesai.Location = New System.Drawing.Point(190, 278)
        Me.DtpSelesai.Name = "DtpSelesai"
        Me.DtpSelesai.Size = New System.Drawing.Size(130, 21)
        Me.DtpSelesai.TabIndex = 63
        '
        'DtpMulai
        '
        Me.DtpMulai.CustomFormat = "dd-MM-yyyy   HH:mm"
        Me.DtpMulai.Enabled = False
        Me.DtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpMulai.Location = New System.Drawing.Point(190, 49)
        Me.DtpMulai.Name = "DtpMulai"
        Me.DtpMulai.Size = New System.Drawing.Size(130, 21)
        Me.DtpMulai.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Selesai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Selisih"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Fisik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Saldo Akhir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Total Pengeluaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Total Pendapatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Saldo Awal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Mulai"
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.AccordionControl1.Appearance.AccordionControl.Options.UseBackColor = True
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.MenuKas, Me.MenuPay, Me.MenuLogout})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 31)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.AccordionControl1.Size = New System.Drawing.Size(48, 480)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
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
        Me.MenuLogout.Name = "MenuLogout"
        Me.MenuLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.MenuLogout.Text = "Logout"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(922, 31)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.DockingEnabled = False
        Me.FluentFormDefaultManager1.Form = Me
        '
        'TmMulai
        '
        Me.TmMulai.Enabled = True
        '
        'TmSelesai
        '
        Me.TmSelesai.Enabled = True
        '
        'FormKas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 511)
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormKas2"
        Me.NavigationControl = Me.AccordionControl1
        Me.Text = "FluentDesignForm2"
        Me.FluentDesignFormContainer1.ResumeLayout(False)
        Me.FluentDesignFormContainer1.PerformLayout()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents MenuKas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents FluentFormDefaultManager1 As DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager
    Friend WithEvents MenuPay As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuLogout As DevExpress.XtraBars.Navigation.AccordionControlElement
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
