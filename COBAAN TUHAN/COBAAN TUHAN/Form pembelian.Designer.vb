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
        Me.LLline = New System.Windows.Forms.Label()
        Me.BTbayar = New System.Windows.Forms.Button()
        Me.BTback = New System.Windows.Forms.Button()
        Me.BTselesai = New System.Windows.Forms.Button()
        Me.PbBack = New System.Windows.Forms.PictureBox()
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LLsubtotal.BackColor = System.Drawing.Color.Transparent
        Me.LLsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLsubtotal.ForeColor = System.Drawing.Color.White
        Me.LLsubtotal.Location = New System.Drawing.Point(865, 108)
        Me.LLsubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLsubtotal.Name = "LLsubtotal"
        Me.LLsubtotal.Size = New System.Drawing.Size(86, 20)
        Me.LLsubtotal.TabIndex = 7
        Me.LLsubtotal.Text = "Sub Total"
        '
        'LLdisc
        '
        Me.LLdisc.AutoSize = True
        Me.LLdisc.BackColor = System.Drawing.Color.Transparent
        Me.LLdisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLdisc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLdisc.Location = New System.Drawing.Point(868, 148)
        Me.LLdisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLdisc.Name = "LLdisc"
        Me.LLdisc.Size = New System.Drawing.Size(44, 20)
        Me.LLdisc.TabIndex = 8
        Me.LLdisc.Text = "Disc"
        '
        'LLtax
        '
        Me.LLtax.AutoSize = True
        Me.LLtax.BackColor = System.Drawing.Color.Transparent
        Me.LLtax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLtax.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLtax.Location = New System.Drawing.Point(868, 189)
        Me.LLtax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLtax.Name = "LLtax"
        Me.LLtax.Size = New System.Drawing.Size(37, 20)
        Me.LLtax.TabIndex = 9
        Me.LLtax.Text = "Tax"
        '
        'LLtotal
        '
        Me.LLtotal.AutoSize = True
        Me.LLtotal.BackColor = System.Drawing.Color.Transparent
        Me.LLtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLtotal.Location = New System.Drawing.Point(868, 237)
        Me.LLtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLtotal.Name = "LLtotal"
        Me.LLtotal.Size = New System.Drawing.Size(49, 20)
        Me.LLtotal.TabIndex = 10
        Me.LLtotal.Text = "Total"
        '
        'LLbayar
        '
        Me.LLbayar.AutoSize = True
        Me.LLbayar.BackColor = System.Drawing.Color.Transparent
        Me.LLbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLbayar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLbayar.Location = New System.Drawing.Point(868, 271)
        Me.LLbayar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLbayar.Name = "LLbayar"
        Me.LLbayar.Size = New System.Drawing.Size(55, 20)
        Me.LLbayar.TabIndex = 11
        Me.LLbayar.Text = "Bayar"
        '
        'LLkembalian
        '
        Me.LLkembalian.AutoSize = True
        Me.LLkembalian.BackColor = System.Drawing.Color.Transparent
        Me.LLkembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLkembalian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLkembalian.Location = New System.Drawing.Point(868, 306)
        Me.LLkembalian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLkembalian.Name = "LLkembalian"
        Me.LLkembalian.Size = New System.Drawing.Size(92, 20)
        Me.LLkembalian.TabIndex = 12
        Me.LLkembalian.Text = "Kembalian"
        '
        'LLangkasubtotal
        '
        Me.LLangkasubtotal.AutoSize = True
        Me.LLangkasubtotal.BackColor = System.Drawing.Color.Transparent
        Me.LLangkasubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLangkasubtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLangkasubtotal.Location = New System.Drawing.Point(1022, 108)
        Me.LLangkasubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkasubtotal.Name = "LLangkasubtotal"
        Me.LLangkasubtotal.Size = New System.Drawing.Size(63, 20)
        Me.LLangkasubtotal.TabIndex = 13
        Me.LLangkasubtotal.Text = "Label7"
        '
        'LLangkadisc
        '
        Me.LLangkadisc.AutoSize = True
        Me.LLangkadisc.BackColor = System.Drawing.Color.Transparent
        Me.LLangkadisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LLangkadisc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLangkadisc.Location = New System.Drawing.Point(1022, 148)
        Me.LLangkadisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkadisc.Name = "LLangkadisc"
        Me.LLangkadisc.Size = New System.Drawing.Size(18, 20)
        Me.LLangkadisc.TabIndex = 14
        Me.LLangkadisc.Text = "0"
        '
        'LLangkatax
        '
        Me.LLangkatax.AutoSize = True
        Me.LLangkatax.BackColor = System.Drawing.Color.Transparent
        Me.LLangkatax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLangkatax.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLangkatax.Location = New System.Drawing.Point(1022, 189)
        Me.LLangkatax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkatax.Name = "LLangkatax"
        Me.LLangkatax.Size = New System.Drawing.Size(63, 20)
        Me.LLangkatax.TabIndex = 15
        Me.LLangkatax.Text = "Label9"
        '
        'LLangkatotal
        '
        Me.LLangkatotal.AutoSize = True
        Me.LLangkatotal.BackColor = System.Drawing.Color.Transparent
        Me.LLangkatotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLangkatotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLangkatotal.Location = New System.Drawing.Point(1022, 237)
        Me.LLangkatotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkatotal.Name = "LLangkatotal"
        Me.LLangkatotal.Size = New System.Drawing.Size(73, 20)
        Me.LLangkatotal.TabIndex = 16
        Me.LLangkatotal.Text = "Label10"
        '
        'LLangkabayar
        '
        Me.LLangkabayar.AutoSize = True
        Me.LLangkabayar.BackColor = System.Drawing.Color.Transparent
        Me.LLangkabayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLangkabayar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLangkabayar.Location = New System.Drawing.Point(1022, 271)
        Me.LLangkabayar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkabayar.Name = "LLangkabayar"
        Me.LLangkabayar.Size = New System.Drawing.Size(19, 20)
        Me.LLangkabayar.TabIndex = 17
        Me.LLangkabayar.Text = "0"
        '
        'LLangkakembalian
        '
        Me.LLangkakembalian.AutoSize = True
        Me.LLangkakembalian.BackColor = System.Drawing.Color.Transparent
        Me.LLangkakembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLangkakembalian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLangkakembalian.Location = New System.Drawing.Point(1022, 306)
        Me.LLangkakembalian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLangkakembalian.Name = "LLangkakembalian"
        Me.LLangkakembalian.Size = New System.Drawing.Size(19, 20)
        Me.LLangkakembalian.TabIndex = 18
        Me.LLangkakembalian.Text = "0"
        '
        'LLline
        '
        Me.LLline.AutoSize = True
        Me.LLline.BackColor = System.Drawing.Color.Transparent
        Me.LLline.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLline.Location = New System.Drawing.Point(857, 209)
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
        'PbBack
        '
        Me.PbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PbBack.Image = Global.COBAAN_TUHAN.My.Resources.Resources.how_to_make_a_png_an_icon_2
        Me.PbBack.Location = New System.Drawing.Point(44, 32)
        Me.PbBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbBack.Name = "PbBack"
        Me.PbBack.Size = New System.Drawing.Size(64, 62)
        Me.PbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBack.TabIndex = 24
        Me.PbBack.TabStop = False
        '
        'Form_pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources._2813122
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.PbBack)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_pembelian"
        Me.Text = "Form_pembelian"
        CType(Me.DGVpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents LLline As Label
    Friend WithEvents BTbayar As Button
    Friend WithEvents BTback As Button
    Friend WithEvents BTselesai As Button
    Friend WithEvents PbBack As PictureBox
End Class
