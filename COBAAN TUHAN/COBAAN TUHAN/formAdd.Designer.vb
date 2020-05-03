<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdd
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbAdd = New System.Windows.Forms.PictureBox()
        Me.lbAdd = New System.Windows.Forms.Label()
        Me.lbIDdd = New System.Windows.Forms.Label()
        Me.lbNamaa = New System.Windows.Forms.Label()
        Me.lbCatd = New System.Windows.Forms.Label()
        Me.lbPriced = New System.Windows.Forms.Label()
        Me.lbStatusd = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbIDd = New System.Windows.Forms.TextBox()
        Me.tbNamad = New System.Windows.Forms.TextBox()
        Me.tbPricde = New System.Windows.Forms.TextBox()
        Me.cmStatussd = New System.Windows.Forms.ComboBox()
        Me.dsdsdsdd = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-141, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pbAdd
        '
        Me.pbAdd.BackColor = System.Drawing.Color.Transparent
        Me.pbAdd.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.btTemplate
        Me.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAdd.Location = New System.Drawing.Point(622, 12)
        Me.pbAdd.Name = "pbAdd"
        Me.pbAdd.Size = New System.Drawing.Size(227, 73)
        Me.pbAdd.TabIndex = 1
        Me.pbAdd.TabStop = False
        '
        'lbAdd
        '
        Me.lbAdd.AutoSize = True
        Me.lbAdd.BackColor = System.Drawing.Color.White
        Me.lbAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdd.Location = New System.Drawing.Point(652, 37)
        Me.lbAdd.Name = "lbAdd"
        Me.lbAdd.Size = New System.Drawing.Size(144, 21)
        Me.lbAdd.TabIndex = 2
        Me.lbAdd.Text = "Form Insert Menu"
        '
        'lbIDdd
        '
        Me.lbIDdd.AutoSize = True
        Me.lbIDdd.BackColor = System.Drawing.Color.Transparent
        Me.lbIDdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDdd.ForeColor = System.Drawing.Color.White
        Me.lbIDdd.Location = New System.Drawing.Point(327, 135)
        Me.lbIDdd.Name = "lbIDdd"
        Me.lbIDdd.Size = New System.Drawing.Size(23, 19)
        Me.lbIDdd.TabIndex = 3
        Me.lbIDdd.Text = "ID"
        '
        'lbNamaa
        '
        Me.lbNamaa.AutoSize = True
        Me.lbNamaa.BackColor = System.Drawing.Color.Transparent
        Me.lbNamaa.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamaa.ForeColor = System.Drawing.Color.White
        Me.lbNamaa.Location = New System.Drawing.Point(327, 173)
        Me.lbNamaa.Name = "lbNamaa"
        Me.lbNamaa.Size = New System.Drawing.Size(49, 19)
        Me.lbNamaa.TabIndex = 4
        Me.lbNamaa.Text = "Nama"
        '
        'lbCatd
        '
        Me.lbCatd.AutoSize = True
        Me.lbCatd.BackColor = System.Drawing.Color.Transparent
        Me.lbCatd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCatd.ForeColor = System.Drawing.Color.White
        Me.lbCatd.Location = New System.Drawing.Point(327, 209)
        Me.lbCatd.Name = "lbCatd"
        Me.lbCatd.Size = New System.Drawing.Size(72, 19)
        Me.lbCatd.TabIndex = 5
        Me.lbCatd.Text = "Category"
        '
        'lbPriced
        '
        Me.lbPriced.AutoSize = True
        Me.lbPriced.BackColor = System.Drawing.Color.Transparent
        Me.lbPriced.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPriced.ForeColor = System.Drawing.Color.White
        Me.lbPriced.Location = New System.Drawing.Point(327, 247)
        Me.lbPriced.Name = "lbPriced"
        Me.lbPriced.Size = New System.Drawing.Size(43, 19)
        Me.lbPriced.TabIndex = 6
        Me.lbPriced.Text = "Price"
        '
        'lbStatusd
        '
        Me.lbStatusd.AutoSize = True
        Me.lbStatusd.BackColor = System.Drawing.Color.Transparent
        Me.lbStatusd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatusd.ForeColor = System.Drawing.Color.White
        Me.lbStatusd.Location = New System.Drawing.Point(327, 283)
        Me.lbStatusd.Name = "lbStatusd"
        Me.lbStatusd.Size = New System.Drawing.Size(49, 19)
        Me.lbStatusd.TabIndex = 7
        Me.lbStatusd.Text = "Status"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(566, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbIDd
        '
        Me.tbIDd.Location = New System.Drawing.Point(431, 135)
        Me.tbIDd.Name = "tbIDd"
        Me.tbIDd.Size = New System.Drawing.Size(139, 20)
        Me.tbIDd.TabIndex = 11
        '
        'tbNamad
        '
        Me.tbNamad.Location = New System.Drawing.Point(431, 173)
        Me.tbNamad.Name = "tbNamad"
        Me.tbNamad.Size = New System.Drawing.Size(139, 20)
        Me.tbNamad.TabIndex = 12
        '
        'tbPricde
        '
        Me.tbPricde.Location = New System.Drawing.Point(431, 247)
        Me.tbPricde.Name = "tbPricde"
        Me.tbPricde.Size = New System.Drawing.Size(139, 20)
        Me.tbPricde.TabIndex = 13
        '
        'cmStatussd
        '
        Me.cmStatussd.FormattingEnabled = True
        Me.cmStatussd.Location = New System.Drawing.Point(431, 283)
        Me.cmStatussd.Name = "cmStatussd"
        Me.cmStatussd.Size = New System.Drawing.Size(139, 21)
        Me.cmStatussd.TabIndex = 14
        '
        'dsdsdsdd
        '
        Me.dsdsdsdd.FormattingEnabled = True
        Me.dsdsdsdd.Location = New System.Drawing.Point(431, 209)
        Me.dsdsdsdd.Name = "dsdsdsdd"
        Me.dsdsdsdd.Size = New System.Drawing.Size(139, 21)
        Me.dsdsdsdd.TabIndex = 15
        '
        'formAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources._444634_PEMTQB_849
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 520)
        Me.Controls.Add(Me.dsdsdsdd)
        Me.Controls.Add(Me.cmStatussd)
        Me.Controls.Add(Me.tbPricde)
        Me.Controls.Add(Me.tbNamad)
        Me.Controls.Add(Me.tbIDd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbStatusd)
        Me.Controls.Add(Me.lbPriced)
        Me.Controls.Add(Me.lbCatd)
        Me.Controls.Add(Me.lbNamaa)
        Me.Controls.Add(Me.lbIDdd)
        Me.Controls.Add(Me.lbAdd)
        Me.Controls.Add(Me.pbAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formAdd"
        Me.Text = "formAdd"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbAdd As PictureBox
    Friend WithEvents lbAdd As Label
    Friend WithEvents lbIDdd As Label
    Friend WithEvents lbNamaa As Label
    Friend WithEvents lbCatd As Label
    Friend WithEvents lbPriced As Label
    Friend WithEvents lbStatusd As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbIDd As TextBox
    Friend WithEvents tbNamad As TextBox
    Friend WithEvents tbPricde As TextBox
    Friend WithEvents cmStatussd As ComboBox
    Friend WithEvents dsdsdsdd As ComboBox
End Class
