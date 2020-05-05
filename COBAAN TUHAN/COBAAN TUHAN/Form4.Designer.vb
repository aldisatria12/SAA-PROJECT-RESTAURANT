<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpenjualan))
        Me.DTPperiode = New System.Windows.Forms.DateTimePicker()
        Me.DTPsampaiperiode = New System.Windows.Forms.DateTimePicker()
        Me.BTcetak = New System.Windows.Forms.Button()
        Me.BTcancel = New System.Windows.Forms.Button()
        Me.BTback = New System.Windows.Forms.Button()
        Me.LBpenjualan = New System.Windows.Forms.Label()
        Me.DGVpenjualan = New System.Windows.Forms.DataGridView()
        Me.PBpembelian = New System.Windows.Forms.PictureBox()
        Me.PBsampaiperiode = New System.Windows.Forms.PictureBox()
        Me.PBperiode = New System.Windows.Forms.PictureBox()
        CType(Me.DGVpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBsampaiperiode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPperiode
        '
        Me.DTPperiode.Location = New System.Drawing.Point(427, 99)
        Me.DTPperiode.Name = "DTPperiode"
        Me.DTPperiode.Size = New System.Drawing.Size(200, 20)
        Me.DTPperiode.TabIndex = 2
        '
        'DTPsampaiperiode
        '
        Me.DTPsampaiperiode.Location = New System.Drawing.Point(427, 150)
        Me.DTPsampaiperiode.Name = "DTPsampaiperiode"
        Me.DTPsampaiperiode.Size = New System.Drawing.Size(200, 20)
        Me.DTPsampaiperiode.TabIndex = 3
        '
        'BTcetak
        '
        Me.BTcetak.Location = New System.Drawing.Point(106, 604)
        Me.BTcetak.Name = "BTcetak"
        Me.BTcetak.Size = New System.Drawing.Size(98, 48)
        Me.BTcetak.TabIndex = 4
        Me.BTcetak.Text = "Cetak"
        Me.BTcetak.UseVisualStyleBackColor = True
        '
        'BTcancel
        '
        Me.BTcancel.Location = New System.Drawing.Point(259, 604)
        Me.BTcancel.Name = "BTcancel"
        Me.BTcancel.Size = New System.Drawing.Size(98, 48)
        Me.BTcancel.TabIndex = 5
        Me.BTcancel.Text = "Cancel"
        Me.BTcancel.UseVisualStyleBackColor = True
        '
        'BTback
        '
        Me.BTback.Location = New System.Drawing.Point(106, 604)
        Me.BTback.Name = "BTback"
        Me.BTback.Size = New System.Drawing.Size(98, 48)
        Me.BTback.TabIndex = 6
        Me.BTback.Text = "Back"
        Me.BTback.UseVisualStyleBackColor = True
        Me.BTback.Visible = False
        '
        'LBpenjualan
        '
        Me.LBpenjualan.AutoSize = True
        Me.LBpenjualan.BackColor = System.Drawing.Color.White
        Me.LBpenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBpenjualan.Location = New System.Drawing.Point(1113, 71)
        Me.LBpenjualan.Name = "LBpenjualan"
        Me.LBpenjualan.Size = New System.Drawing.Size(130, 21)
        Me.LBpenjualan.TabIndex = 8
        Me.LBpenjualan.Text = "Form Penjualan"
        '
        'DGVpenjualan
        '
        Me.DGVpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpenjualan.Location = New System.Drawing.Point(12, 207)
        Me.DGVpenjualan.Name = "DGVpenjualan"
        Me.DGVpenjualan.Size = New System.Drawing.Size(1231, 374)
        Me.DGVpenjualan.TabIndex = 9
        Me.DGVpenjualan.Visible = False
        '
        'PBpembelian
        '
        Me.PBpembelian.BackColor = System.Drawing.Color.Transparent
        Me.PBpembelian.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.btTemplate
        Me.PBpembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBpembelian.Location = New System.Drawing.Point(1083, 46)
        Me.PBpembelian.Name = "PBpembelian"
        Me.PBpembelian.Size = New System.Drawing.Size(227, 73)
        Me.PBpembelian.TabIndex = 7
        Me.PBpembelian.TabStop = False
        '
        'PBsampaiperiode
        '
        Me.PBsampaiperiode.Image = CType(resources.GetObject("PBsampaiperiode.Image"), System.Drawing.Image)
        Me.PBsampaiperiode.Location = New System.Drawing.Point(291, 140)
        Me.PBsampaiperiode.Name = "PBsampaiperiode"
        Me.PBsampaiperiode.Size = New System.Drawing.Size(98, 30)
        Me.PBsampaiperiode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBsampaiperiode.TabIndex = 1
        Me.PBsampaiperiode.TabStop = False
        '
        'PBperiode
        '
        Me.PBperiode.Image = CType(resources.GetObject("PBperiode.Image"), System.Drawing.Image)
        Me.PBperiode.Location = New System.Drawing.Point(291, 90)
        Me.PBperiode.Name = "PBperiode"
        Me.PBperiode.Size = New System.Drawing.Size(98, 30)
        Me.PBperiode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBperiode.TabIndex = 0
        Me.PBperiode.TabStop = False
        '
        'Formpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.DGVpenjualan)
        Me.Controls.Add(Me.LBpenjualan)
        Me.Controls.Add(Me.PBpembelian)
        Me.Controls.Add(Me.BTback)
        Me.Controls.Add(Me.BTcancel)
        Me.Controls.Add(Me.BTcetak)
        Me.Controls.Add(Me.DTPsampaiperiode)
        Me.Controls.Add(Me.DTPperiode)
        Me.Controls.Add(Me.PBsampaiperiode)
        Me.Controls.Add(Me.PBperiode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formpenjualan"
        Me.Text = "Form4"
        CType(Me.DGVpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBsampaiperiode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBperiode As PictureBox
    Friend WithEvents PBsampaiperiode As PictureBox
    Friend WithEvents DTPperiode As DateTimePicker
    Friend WithEvents DTPsampaiperiode As DateTimePicker
    Friend WithEvents BTcetak As Button
    Friend WithEvents BTcancel As Button
    Friend WithEvents BTback As Button
    Friend WithEvents LBpenjualan As Label
    Friend WithEvents PBpembelian As PictureBox
    Friend WithEvents DGVpenjualan As DataGridView
End Class
