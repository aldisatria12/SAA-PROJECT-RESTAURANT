<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpembelian))
        Me.BTback = New System.Windows.Forms.Button()
        Me.DGVpenjualan = New System.Windows.Forms.DataGridView()
        Me.LBpembelian = New System.Windows.Forms.Label()
        Me.pbpembelian = New System.Windows.Forms.PictureBox()
        Me.DTPsampaiperiode = New System.Windows.Forms.DateTimePicker()
        Me.DTPperiode = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PBperiode = New System.Windows.Forms.PictureBox()
        Me.BTcancel = New System.Windows.Forms.Button()
        Me.BTcetak = New System.Windows.Forms.Button()
        CType(Me.DGVpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTback
        '
        Me.BTback.Location = New System.Drawing.Point(67, 594)
        Me.BTback.Name = "BTback"
        Me.BTback.Size = New System.Drawing.Size(92, 44)
        Me.BTback.TabIndex = 20
        Me.BTback.Text = "Back"
        Me.BTback.UseVisualStyleBackColor = True
        Me.BTback.Visible = False
        '
        'DGVpenjualan
        '
        Me.DGVpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpenjualan.Location = New System.Drawing.Point(-20, 191)
        Me.DGVpenjualan.Name = "DGVpenjualan"
        Me.DGVpenjualan.Size = New System.Drawing.Size(1240, 378)
        Me.DGVpenjualan.TabIndex = 19
        Me.DGVpenjualan.Visible = False
        '
        'LBpembelian
        '
        Me.LBpembelian.AutoSize = True
        Me.LBpembelian.BackColor = System.Drawing.Color.White
        Me.LBpembelian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBpembelian.Location = New System.Drawing.Point(1154, 67)
        Me.LBpembelian.Name = "LBpembelian"
        Me.LBpembelian.Size = New System.Drawing.Size(92, 21)
        Me.LBpembelian.TabIndex = 18
        Me.LBpembelian.Text = "Pembelian"
        '
        'pbpembelian
        '
        Me.pbpembelian.BackColor = System.Drawing.Color.Transparent
        Me.pbpembelian.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.btTemplate
        Me.pbpembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpembelian.Location = New System.Drawing.Point(1120, 42)
        Me.pbpembelian.Name = "pbpembelian"
        Me.pbpembelian.Size = New System.Drawing.Size(227, 73)
        Me.pbpembelian.TabIndex = 17
        Me.pbpembelian.TabStop = False
        '
        'DTPsampaiperiode
        '
        Me.DTPsampaiperiode.Location = New System.Drawing.Point(265, 142)
        Me.DTPsampaiperiode.Name = "DTPsampaiperiode"
        Me.DTPsampaiperiode.Size = New System.Drawing.Size(182, 20)
        Me.DTPsampaiperiode.TabIndex = 16
        '
        'DTPperiode
        '
        Me.DTPperiode.Location = New System.Drawing.Point(265, 95)
        Me.DTPperiode.Name = "DTPperiode"
        Me.DTPperiode.Size = New System.Drawing.Size(182, 20)
        Me.DTPperiode.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(139, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PBperiode
        '
        Me.PBperiode.Image = CType(resources.GetObject("PBperiode.Image"), System.Drawing.Image)
        Me.PBperiode.Location = New System.Drawing.Point(139, 83)
        Me.PBperiode.Name = "PBperiode"
        Me.PBperiode.Size = New System.Drawing.Size(94, 32)
        Me.PBperiode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBperiode.TabIndex = 13
        Me.PBperiode.TabStop = False
        '
        'BTcancel
        '
        Me.BTcancel.Location = New System.Drawing.Point(211, 594)
        Me.BTcancel.Name = "BTcancel"
        Me.BTcancel.Size = New System.Drawing.Size(92, 44)
        Me.BTcancel.TabIndex = 12
        Me.BTcancel.Text = "Cancel"
        Me.BTcancel.UseVisualStyleBackColor = True
        '
        'BTcetak
        '
        Me.BTcetak.Location = New System.Drawing.Point(67, 594)
        Me.BTcetak.Name = "BTcetak"
        Me.BTcetak.Size = New System.Drawing.Size(92, 44)
        Me.BTcetak.TabIndex = 11
        Me.BTcetak.Text = "Cetak"
        Me.BTcetak.UseVisualStyleBackColor = True
        '
        'Formpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.BTback)
        Me.Controls.Add(Me.DGVpenjualan)
        Me.Controls.Add(Me.LBpembelian)
        Me.Controls.Add(Me.pbpembelian)
        Me.Controls.Add(Me.DTPsampaiperiode)
        Me.Controls.Add(Me.DTPperiode)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PBperiode)
        Me.Controls.Add(Me.BTcancel)
        Me.Controls.Add(Me.BTcetak)
        Me.Name = "Formpembelian"
        Me.Text = "Form5"
        CType(Me.DGVpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTback As Button
    Friend WithEvents DGVpenjualan As DataGridView
    Friend WithEvents LBpembelian As Label
    Friend WithEvents pbpembelian As PictureBox
    Friend WithEvents DTPsampaiperiode As DateTimePicker
    Friend WithEvents DTPperiode As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PBperiode As PictureBox
    Friend WithEvents BTcancel As Button
    Friend WithEvents BTcetak As Button
End Class
