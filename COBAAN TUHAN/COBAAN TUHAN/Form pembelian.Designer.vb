<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_pembelian
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
        Me.MenuUtama = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.MenuKas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuPay = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuLogout = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.DGVpembelian = New System.Windows.Forms.DataGridView()
        Me.LLsubtotal = New System.Windows.Forms.Label()
        Me.LLdisc = New System.Windows.Forms.Label()
        Me.LLtax = New System.Windows.Forms.Label()
        Me.LLtotal = New System.Windows.Forms.Label()
        Me.LLbayar = New System.Windows.Forms.Label()
        Me.LLkembalian = New System.Windows.Forms.Label()
        Me.LLangkasubtotal = New System.Windows.Forms.Label()
        Me.LLangkadisc = New System.Windows.Forms.Label()
        Me.LLangkatax = New System.Windows.Forms.Label()
        Me.LLangkatotal = New System.Windows.Forms.Label()
        Me.LLangkabayar = New System.Windows.Forms.Label()
        Me.LLangkakembalian = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LLline = New System.Windows.Forms.Label()
        Me.BTbayar = New System.Windows.Forms.Button()
        Me.BTback = New System.Windows.Forms.Button()
        Me.BTselesai = New System.Windows.Forms.Button()
        CType(Me.MenuUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuUtama
        '
        Me.MenuUtama.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.MenuUtama.Appearance.AccordionControl.Options.UseBackColor = True
        Me.MenuUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuUtama.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuUtama.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.MenuKas, Me.MenuPay, Me.MenuLogout})
        Me.MenuUtama.Location = New System.Drawing.Point(0, 0)
        Me.MenuUtama.Name = "MenuUtama"
        Me.MenuUtama.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Overlay
        Me.MenuUtama.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
        Me.MenuUtama.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.MenuUtama.Size = New System.Drawing.Size(72, 692)
        Me.MenuUtama.TabIndex = 5
        Me.MenuUtama.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
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
        'DGVpembelian
        '
        Me.DGVpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpembelian.Location = New System.Drawing.Point(192, 62)
        Me.DGVpembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGVpembelian.Name = "DGVpembelian"
        Me.DGVpembelian.RowHeadersWidth = 62
        Me.DGVpembelian.Size = New System.Drawing.Size(591, 534)
        Me.DGVpembelian.TabIndex = 6
        '
        'LLsubtotal
        '
        Me.LLsubtotal.AutoSize = True
        Me.LLsubtotal.Location = New System.Drawing.Point(868, 108)
        Me.LLsubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLsubtotal.Name = "LLsubtotal"
        Me.LLsubtotal.Size = New System.Drawing.Size(77, 20)
        Me.LLsubtotal.TabIndex = 7
        Me.LLsubtotal.Text = "Sub Total"
        '
        'LLdisc
        '
        Me.LLdisc.AutoSize = True
        Me.LLdisc.Location = New System.Drawing.Point(868, 148)
        Me.LLdisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLdisc.Name = "LLdisc"
        Me.LLdisc.Size = New System.Drawing.Size(40, 20)
        Me.LLdisc.TabIndex = 8
        Me.LLdisc.Text = "Disc"
        '
        'LLtax
        '
        Me.LLtax.AutoSize = True
        Me.LLtax.Location = New System.Drawing.Point(868, 189)
        Me.LLtax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLtax.Name = "LLtax"
        Me.LLtax.Size = New System.Drawing.Size(34, 20)
        Me.LLtax.TabIndex = 9
        Me.LLtax.Text = "Tax"
        '
        'LLtotal
        '
        Me.LLtotal.AutoSize = True
        Me.LLtotal.Location = New System.Drawing.Point(868, 237)
        Me.LLtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLtotal.Name = "LLtotal"
        Me.LLtotal.Size = New System.Drawing.Size(44, 20)
        Me.LLtotal.TabIndex = 10
        Me.LLtotal.Text = "Total"
        '
        'LLbayar
        '
        Me.LLbayar.AutoSize = True
        Me.LLbayar.Location = New System.Drawing.Point(868, 271)
        Me.LLbayar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLbayar.Name = "LLbayar"
        Me.LLbayar.Size = New System.Drawing.Size(50, 20)
        Me.LLbayar.TabIndex = 11
        Me.LLbayar.Text = "Bayar"
        '
        'LLkembalian
        '
        Me.LLkembalian.AutoSize = True
        Me.LLkembalian.Location = New System.Drawing.Point(868, 306)
        Me.LLkembalian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLkembalian.Name = "LLkembalian"
        Me.LLkembalian.Size = New System.Drawing.Size(83, 20)
        Me.LLkembalian.TabIndex = 12
        Me.LLkembalian.Text = "Kembalian"
        '
        'LLangkasubtotal
        '
        Me.LLangkasubtotal.AutoSize = True
        Me.LLangkasubtotal.Location = New System.Drawing.Point(1022, 108)
        Me.LLangkasubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkasubtotal.Name = "LLangkasubtotal"
        Me.LLangkasubtotal.Size = New System.Drawing.Size(57, 20)
        Me.LLangkasubtotal.TabIndex = 13
        Me.LLangkasubtotal.Text = "Label7"
        '
        'LLangkadisc
        '
        Me.LLangkadisc.AutoSize = True
        Me.LLangkadisc.Location = New System.Drawing.Point(1022, 148)
        Me.LLangkadisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkadisc.Name = "LLangkadisc"
        Me.LLangkadisc.Size = New System.Drawing.Size(57, 20)
        Me.LLangkadisc.TabIndex = 14
        Me.LLangkadisc.Text = "Label8"
        '
        'LLangkatax
        '
        Me.LLangkatax.AutoSize = True
        Me.LLangkatax.Location = New System.Drawing.Point(1022, 189)
        Me.LLangkatax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkatax.Name = "LLangkatax"
        Me.LLangkatax.Size = New System.Drawing.Size(57, 20)
        Me.LLangkatax.TabIndex = 15
        Me.LLangkatax.Text = "Label9"
        '
        'LLangkatotal
        '
        Me.LLangkatotal.AutoSize = True
        Me.LLangkatotal.Location = New System.Drawing.Point(1022, 237)
        Me.LLangkatotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkatotal.Name = "LLangkatotal"
        Me.LLangkatotal.Size = New System.Drawing.Size(66, 20)
        Me.LLangkatotal.TabIndex = 16
        Me.LLangkatotal.Text = "Label10"
        '
        'LLangkabayar
        '
        Me.LLangkabayar.AutoSize = True
        Me.LLangkabayar.Location = New System.Drawing.Point(1022, 271)
        Me.LLangkabayar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkabayar.Name = "LLangkabayar"
        Me.LLangkabayar.Size = New System.Drawing.Size(66, 20)
        Me.LLangkabayar.TabIndex = 17
        Me.LLangkabayar.Text = "Label11"
        '
        'LLangkakembalian
        '
        Me.LLangkakembalian.AutoSize = True
        Me.LLangkakembalian.Location = New System.Drawing.Point(1022, 306)
        Me.LLangkakembalian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkakembalian.Name = "LLangkakembalian"
        Me.LLangkakembalian.Size = New System.Drawing.Size(66, 20)
        Me.LLangkakembalian.TabIndex = 18
        Me.LLangkakembalian.Text = "Label12"
        '
        'LLline
        '
        Me.LLline.AutoSize = True
        Me.LLline.Location = New System.Drawing.Point(868, 209)
        Me.LLline.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLline.Name = "LLline"
        Me.LLline.Size = New System.Drawing.Size(252, 20)
        Me.LLline.TabIndex = 20
        Me.LLline.Text = "___________________________"
        '
        'BTbayar
        '
        Me.BTbayar.Location = New System.Drawing.Point(962, 368)
        Me.BTbayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTbayar.Name = "BTbayar"
        Me.BTbayar.Size = New System.Drawing.Size(128, 63)
        Me.BTbayar.TabIndex = 21
        Me.BTbayar.Text = "Bayar"
        Me.BTbayar.UseVisualStyleBackColor = True
        '
        'BTback
        '
        Me.BTback.Location = New System.Drawing.Point(1026, 537)
        Me.BTback.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTback.Name = "BTback"
        Me.BTback.Size = New System.Drawing.Size(128, 45)
        Me.BTback.TabIndex = 22
        Me.BTback.Text = "Back"
        Me.BTback.UseVisualStyleBackColor = True
        '
        'BTselesai
        '
        Me.BTselesai.Location = New System.Drawing.Point(962, 368)
        Me.BTselesai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTselesai.Name = "BTselesai"
        Me.BTselesai.Size = New System.Drawing.Size(128, 63)
        Me.BTselesai.TabIndex = 23
        Me.BTselesai.Text = "Selesai"
        Me.BTselesai.UseVisualStyleBackColor = True
        Me.BTselesai.Visible = False
        '
        'Form_pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.BTselesai)
        Me.Controls.Add(Me.BTback)
        Me.Controls.Add(Me.BTbayar)
        Me.Controls.Add(Me.LLline)
        Me.Controls.Add(Me.LLangkakembalian)
        Me.Controls.Add(Me.LLangkabayar)
        Me.Controls.Add(Me.LLangkatotal)
        Me.Controls.Add(Me.LLangkatax)
        Me.Controls.Add(Me.LLangkadisc)
        Me.Controls.Add(Me.LLangkasubtotal)
        Me.Controls.Add(Me.LLkembalian)
        Me.Controls.Add(Me.LLbayar)
        Me.Controls.Add(Me.LLtotal)
        Me.Controls.Add(Me.LLtax)
        Me.Controls.Add(Me.LLdisc)
        Me.Controls.Add(Me.LLsubtotal)
        Me.Controls.Add(Me.DGVpembelian)
        Me.Controls.Add(Me.MenuUtama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_pembelian"
        Me.Text = "Form_pembelian"
        CType(Me.MenuUtama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuUtama As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents MenuKas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuPay As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuLogout As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents DGVpembelian As DataGridView
    Friend WithEvents LLsubtotal As Label
    Friend WithEvents LLdisc As Label
    Friend WithEvents LLtax As Label
    Friend WithEvents LLtotal As Label
    Friend WithEvents LLbayar As Label
    Friend WithEvents LLkembalian As Label
    Friend WithEvents LLangkasubtotal As Label
    Friend WithEvents LLangkadisc As Label
    Friend WithEvents LLangkatax As Label
    Friend WithEvents LLangkatotal As Label
    Friend WithEvents LLangkabayar As Label
    Friend WithEvents LLangkakembalian As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LLline As Label
    Friend WithEvents BTbayar As Button
    Friend WithEvents BTback As Button
    Friend WithEvents BTselesai As Button
End Class
