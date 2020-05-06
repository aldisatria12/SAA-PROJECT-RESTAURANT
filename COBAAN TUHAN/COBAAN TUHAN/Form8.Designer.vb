<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPay
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
        Me.numArea = New System.Windows.Forms.NumericUpDown()
        CType(Me.MenuUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numArea, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuUtama.Size = New System.Drawing.Size(72, 720)
        Me.MenuUtama.TabIndex = 4
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
        'numArea
        '
        Me.numArea.Location = New System.Drawing.Point(1099, 46)
        Me.numArea.Name = "numArea"
        Me.numArea.Size = New System.Drawing.Size(155, 26)
        Me.numArea.TabIndex = 5
        Me.numArea.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FormPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.numArea)
        Me.Controls.Add(Me.MenuUtama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPay"
        Me.Text = "Form8"
        CType(Me.MenuUtama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuUtama As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents MenuKas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuPay As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuLogout As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents numArea As NumericUpDown
End Class
