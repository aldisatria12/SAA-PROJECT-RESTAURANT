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
        Me.DGVpembelian = New System.Windows.Forms.DataGridView()
        Me.LBpembelian = New System.Windows.Forms.Label()
        Me.PBpembelian = New System.Windows.Forms.PictureBox()
        Me.BTback = New System.Windows.Forms.Button()
        Me.BTcancel = New System.Windows.Forms.Button()
        Me.BTcetak = New System.Windows.Forms.Button()
        Me.DTPsampaiperiode = New System.Windows.Forms.DateTimePicker()
        Me.DTPperiode = New System.Windows.Forms.DateTimePicker()
        Me.PBsampaiperiode = New System.Windows.Forms.PictureBox()
        Me.PBperiode = New System.Windows.Forms.PictureBox()
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBsampaiperiode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVpembelian
        '
        Me.DGVpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpembelian.Location = New System.Drawing.Point(12, 218)
        Me.DGVpembelian.Name = "DGVpembelian"
        Me.DGVpembelian.Size = New System.Drawing.Size(1231, 374)
        Me.DGVpembelian.TabIndex = 19
        Me.DGVpembelian.Visible = False
        '
        'LBpembelian
        '
        Me.LBpembelian.AutoSize = True
        Me.LBpembelian.BackColor = System.Drawing.Color.White
        Me.LBpembelian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBpembelian.Location = New System.Drawing.Point(1092, 82)
        Me.LBpembelian.Name = "LBpembelian"
        Me.LBpembelian.Size = New System.Drawing.Size(135, 21)
        Me.LBpembelian.TabIndex = 18
        Me.LBpembelian.Text = "Form Pembelian"
        '
        'PBpembelian
        '
        Me.PBpembelian.BackColor = System.Drawing.Color.Transparent
        Me.PBpembelian.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.btTemplate
        Me.PBpembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBpembelian.Location = New System.Drawing.Point(1062, 57)
        Me.PBpembelian.Name = "PBpembelian"
        Me.PBpembelian.Size = New System.Drawing.Size(227, 73)
        Me.PBpembelian.TabIndex = 17
        Me.PBpembelian.TabStop = False
        '
        'BTback
        '
        Me.BTback.Location = New System.Drawing.Point(85, 615)
        Me.BTback.Name = "BTback"
        Me.BTback.Size = New System.Drawing.Size(98, 48)
        Me.BTback.TabIndex = 16
        Me.BTback.Text = "Back"
        Me.BTback.UseVisualStyleBackColor = True
        Me.BTback.Visible = False
        '
        'BTcancel
        '
        Me.BTcancel.Location = New System.Drawing.Point(238, 615)
        Me.BTcancel.Name = "BTcancel"
        Me.BTcancel.Size = New System.Drawing.Size(98, 48)
        Me.BTcancel.TabIndex = 15
        Me.BTcancel.Text = "Cancel"
        Me.BTcancel.UseVisualStyleBackColor = True
        '
        'BTcetak
        '
        Me.BTcetak.Location = New System.Drawing.Point(85, 615)
        Me.BTcetak.Name = "BTcetak"
        Me.BTcetak.Size = New System.Drawing.Size(98, 48)
        Me.BTcetak.TabIndex = 14
        Me.BTcetak.Text = "Cetak"
        Me.BTcetak.UseVisualStyleBackColor = True
        '
        'DTPsampaiperiode
        '
        Me.DTPsampaiperiode.Location = New System.Drawing.Point(406, 161)
        Me.DTPsampaiperiode.Name = "DTPsampaiperiode"
        Me.DTPsampaiperiode.Size = New System.Drawing.Size(200, 20)
        Me.DTPsampaiperiode.TabIndex = 13
        '
        'DTPperiode
        '
        Me.DTPperiode.Location = New System.Drawing.Point(406, 110)
        Me.DTPperiode.Name = "DTPperiode"
        Me.DTPperiode.Size = New System.Drawing.Size(200, 20)
        Me.DTPperiode.TabIndex = 12
        '
        'PBsampaiperiode
        '
        Me.PBsampaiperiode.Image = CType(resources.GetObject("PBsampaiperiode.Image"), System.Drawing.Image)
        Me.PBsampaiperiode.Location = New System.Drawing.Point(270, 151)
        Me.PBsampaiperiode.Name = "PBsampaiperiode"
        Me.PBsampaiperiode.Size = New System.Drawing.Size(98, 30)
        Me.PBsampaiperiode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBsampaiperiode.TabIndex = 11
        Me.PBsampaiperiode.TabStop = False
        '
        'PBperiode
        '
        Me.PBperiode.Image = CType(resources.GetObject("PBperiode.Image"), System.Drawing.Image)
        Me.PBperiode.Location = New System.Drawing.Point(270, 101)
        Me.PBperiode.Name = "PBperiode"
        Me.PBperiode.Size = New System.Drawing.Size(98, 30)
        Me.PBperiode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBperiode.TabIndex = 10
        Me.PBperiode.TabStop = False
        '
        'Formpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.DGVpembelian)
        Me.Controls.Add(Me.LBpembelian)
        Me.Controls.Add(Me.PBpembelian)
        Me.Controls.Add(Me.BTback)
        Me.Controls.Add(Me.BTcancel)
        Me.Controls.Add(Me.BTcetak)
        Me.Controls.Add(Me.DTPsampaiperiode)
        Me.Controls.Add(Me.DTPperiode)
        Me.Controls.Add(Me.PBsampaiperiode)
        Me.Controls.Add(Me.PBperiode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formpembelian"
        Me.Text = "Form5"
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBsampaiperiode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBperiode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVpembelian As DataGridView
    Friend WithEvents LBpembelian As Label
    Friend WithEvents PBpembelian As PictureBox
    Friend WithEvents BTback As Button
    Friend WithEvents BTcancel As Button
    Friend WithEvents BTcetak As Button
    Friend WithEvents DTPsampaiperiode As DateTimePicker
    Friend WithEvents DTPperiode As DateTimePicker
    Friend WithEvents PBsampaiperiode As PictureBox
    Friend WithEvents PBperiode As PictureBox
End Class
