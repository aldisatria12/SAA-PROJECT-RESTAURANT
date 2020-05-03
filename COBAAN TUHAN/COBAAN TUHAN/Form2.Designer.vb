<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdmin
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
        Me.btInsertdata = New System.Windows.Forms.Button()
        Me.btLaporanpengeluaran = New System.Windows.Forms.Button()
        Me.btLogout = New System.Windows.Forms.Button()
        Me.btPenjualan = New System.Windows.Forms.Button()
        Me.btPembelian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btInsertdata
        '
        Me.btInsertdata.Location = New System.Drawing.Point(272, 321)
        Me.btInsertdata.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btInsertdata.Name = "btInsertdata"
        Me.btInsertdata.Size = New System.Drawing.Size(255, 99)
        Me.btInsertdata.TabIndex = 0
        Me.btInsertdata.Text = "INSERT DATA"
        Me.btInsertdata.UseVisualStyleBackColor = True
        '
        'btLaporanpengeluaran
        '
        Me.btLaporanpengeluaran.Location = New System.Drawing.Point(720, 321)
        Me.btLaporanpengeluaran.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btLaporanpengeluaran.Name = "btLaporanpengeluaran"
        Me.btLaporanpengeluaran.Size = New System.Drawing.Size(255, 99)
        Me.btLaporanpengeluaran.TabIndex = 1
        Me.btLaporanpengeluaran.Text = "LAPORAN PENGELUARAN"
        Me.btLaporanpengeluaran.UseVisualStyleBackColor = True
        '
        'btLogout
        '
        Me.btLogout.Location = New System.Drawing.Point(551, 610)
        Me.btLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(144, 40)
        Me.btLogout.TabIndex = 2
        Me.btLogout.Text = "LOG OUT"
        Me.btLogout.UseVisualStyleBackColor = True
        '
        'btPenjualan
        '
        Me.btPenjualan.Location = New System.Drawing.Point(720, 470)
        Me.btPenjualan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btPenjualan.Name = "btPenjualan"
        Me.btPenjualan.Size = New System.Drawing.Size(94, 59)
        Me.btPenjualan.TabIndex = 3
        Me.btPenjualan.Text = "PENJUALAN"
        Me.btPenjualan.UseVisualStyleBackColor = True
        Me.btPenjualan.Visible = False
        '
        'btPembelian
        '
        Me.btPembelian.Location = New System.Drawing.Point(881, 470)
        Me.btPembelian.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btPembelian.Name = "btPembelian"
        Me.btPembelian.Size = New System.Drawing.Size(94, 59)
        Me.btPembelian.TabIndex = 4
        Me.btPembelian.Text = "PEMBELIAN"
        Me.btPembelian.UseVisualStyleBackColor = True
        Me.btPembelian.Visible = False
        '
        'formAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.BG_Form_Admin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btPembelian)
        Me.Controls.Add(Me.btPenjualan)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.btLaporanpengeluaran)
        Me.Controls.Add(Me.btInsertdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formAdmin"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btInsertdata As Button
    Friend WithEvents btLaporanpengeluaran As Button
    Friend WithEvents btLogout As Button
    Friend WithEvents btPenjualan As Button
    Friend WithEvents btPembelian As Button
End Class
