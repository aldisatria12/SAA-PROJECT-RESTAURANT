<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpenjualan))
        Me.BTcetak = New System.Windows.Forms.Button()
        Me.BTcancel = New System.Windows.Forms.Button()
        Me.DTPperiode = New System.Windows.Forms.DateTimePicker()
        Me.DTPsampaiperiode = New System.Windows.Forms.DateTimePicker()
        Me.LBpenjualan = New System.Windows.Forms.Label()
        Me.DGVpembelian = New System.Windows.Forms.DataGridView()
        Me.BTback = New System.Windows.Forms.Button()
        Me.pbpembelian = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PBperiode = New System.Windows.Forms.PictureBox()
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTcetak
        '
        Me.BTcetak.Location = New System.Drawing.Point(99, 613)
        Me.BTcetak.Name = "BTcetak"
        Me.BTcetak.Size = New System.Drawing.Size(92, 44)
        Me.BTcetak.TabIndex = 0
        Me.BTcetak.Text = "Cetak"
        Me.BTcetak.UseVisualStyleBackColor = True
        '
        'BTcancel
        '
        Me.BTcancel.Location = New System.Drawing.Point(243, 613)
        Me.BTcancel.Name = "BTcancel"
        Me.BTcancel.Size = New System.Drawing.Size(92, 44)
        Me.BTcancel.TabIndex = 1
        Me.BTcancel.Text = "Cancel"
        Me.BTcancel.UseVisualStyleBackColor = True
        '
        'DTPperiode
        '
        Me.DTPperiode.Location = New System.Drawing.Point(297, 114)
        Me.DTPperiode.Name = "DTPperiode"
        Me.DTPperiode.Size = New System.Drawing.Size(182, 20)
        Me.DTPperiode.TabIndex = 4
        '
        'DTPsampaiperiode
        '
        Me.DTPsampaiperiode.Location = New System.Drawing.Point(297, 161)
        Me.DTPsampaiperiode.Name = "DTPsampaiperiode"
        Me.DTPsampaiperiode.Size = New System.Drawing.Size(182, 20)
        Me.DTPsampaiperiode.TabIndex = 5
        '
        'LBpenjualan
        '
        Me.LBpenjualan.AutoSize = True
        Me.LBpenjualan.BackColor = System.Drawing.Color.White
        Me.LBpenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBpenjualan.Location = New System.Drawing.Point(1165, 83)
        Me.LBpenjualan.Name = "LBpenjualan"
        Me.LBpenjualan.Size = New System.Drawing.Size(87, 21)
        Me.LBpenjualan.TabIndex = 8
        Me.LBpenjualan.Text = "Penjualan"
        '
        'DGVpembelian
        '
        Me.DGVpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpembelian.Location = New System.Drawing.Point(12, 210)
        Me.DGVpembelian.Name = "DGVpembelian"
        Me.DGVpembelian.Size = New System.Drawing.Size(1240, 378)
        Me.DGVpembelian.TabIndex = 9
        Me.DGVpembelian.Visible = False
        '
        'BTback
        '
        Me.BTback.Location = New System.Drawing.Point(99, 613)
        Me.BTback.Name = "BTback"
        Me.BTback.Size = New System.Drawing.Size(92, 44)
        Me.BTback.TabIndex = 10
        Me.BTback.Text = "Back"
        Me.BTback.UseVisualStyleBackColor = True
        Me.BTback.Visible = False
        '
        'pbpembelian
        '
        Me.pbpembelian.BackColor = System.Drawing.Color.Transparent
        Me.pbpembelian.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.btTemplate
        Me.pbpembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpembelian.Location = New System.Drawing.Point(1133, 61)
        Me.pbpembelian.Name = "pbpembelian"
        Me.pbpembelian.Size = New System.Drawing.Size(227, 73)
        Me.pbpembelian.TabIndex = 6
        Me.pbpembelian.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(171, 149)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PBperiode
        '
        Me.PBperiode.Image = CType(resources.GetObject("PBperiode.Image"), System.Drawing.Image)
        Me.PBperiode.Location = New System.Drawing.Point(171, 102)
        Me.PBperiode.Name = "PBperiode"
        Me.PBperiode.Size = New System.Drawing.Size(94, 32)
        Me.PBperiode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBperiode.TabIndex = 2
        Me.PBperiode.TabStop = False
        '
        'formpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.BTback)
        Me.Controls.Add(Me.DGVpembelian)
        Me.Controls.Add(Me.LBpenjualan)
        Me.Controls.Add(Me.pbpembelian)
        Me.Controls.Add(Me.DTPsampaiperiode)
        Me.Controls.Add(Me.DTPperiode)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PBperiode)
        Me.Controls.Add(Me.BTcancel)
        Me.Controls.Add(Me.BTcetak)
        Me.Name = "formpenjualan"
        Me.Text = "Form4"
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTcetak As Button
    Friend WithEvents BTcancel As Button
    Friend WithEvents PBperiode As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DTPperiode As DateTimePicker
    Friend WithEvents DTPsampaiperiode As DateTimePicker
    Friend WithEvents pbpembelian As PictureBox
    Friend WithEvents LBpenjualan As Label
    Friend WithEvents DGVpembelian As DataGridView
    Friend WithEvents BTback As Button
End Class
