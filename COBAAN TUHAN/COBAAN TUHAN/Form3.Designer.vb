﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInsert
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
        Me.ctMenu = New DevExpress.XtraEditors.CheckButton()
        Me.ctKategorimenu = New DevExpress.XtraEditors.CheckButton()
        Me.ctKursimeja = New DevExpress.XtraEditors.CheckButton()
        Me.ctStokbahan = New DevExpress.XtraEditors.CheckButton()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.dgAdmin = New System.Windows.Forms.DataGridView()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbAktif = New System.Windows.Forms.CheckBox()
        Me.btHome = New System.Windows.Forms.Button()
        CType(Me.dgAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctMenu
        '
        Me.ctMenu.Location = New System.Drawing.Point(9, 8)
        Me.ctMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.ctMenu.Name = "ctMenu"
        Me.ctMenu.Size = New System.Drawing.Size(59, 49)
        Me.ctMenu.TabIndex = 0
        Me.ctMenu.Text = "MENU"
        '
        'ctKategorimenu
        '
        Me.ctKategorimenu.Location = New System.Drawing.Point(199, 8)
        Me.ctKategorimenu.Margin = New System.Windows.Forms.Padding(2)
        Me.ctKategorimenu.Name = "ctKategorimenu"
        Me.ctKategorimenu.Size = New System.Drawing.Size(59, 49)
        Me.ctKategorimenu.TabIndex = 1
        Me.ctKategorimenu.Text = "KATEGORI " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MENU"
        '
        'ctKursimeja
        '
        Me.ctKursimeja.Location = New System.Drawing.Point(135, 8)
        Me.ctKursimeja.Margin = New System.Windows.Forms.Padding(2)
        Me.ctKursimeja.Name = "ctKursimeja"
        Me.ctKursimeja.Size = New System.Drawing.Size(59, 49)
        Me.ctKursimeja.TabIndex = 2
        Me.ctKursimeja.Text = "KURSI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MEJA"
        '
        'ctStokbahan
        '
        Me.ctStokbahan.Location = New System.Drawing.Point(72, 8)
        Me.ctStokbahan.Margin = New System.Windows.Forms.Padding(2)
        Me.ctStokbahan.Name = "ctStokbahan"
        Me.ctStokbahan.Size = New System.Drawing.Size(59, 49)
        Me.ctStokbahan.TabIndex = 3
        Me.ctStokbahan.Text = "STOK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BAHAN"
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(9, 70)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(695, 29)
        Me.tbSearch.TabIndex = 4
        '
        'dgAdmin
        '
        Me.dgAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAdmin.Location = New System.Drawing.Point(9, 163)
        Me.dgAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.dgAdmin.Name = "dgAdmin"
        Me.dgAdmin.RowHeadersWidth = 62
        Me.dgAdmin.RowTemplate.Height = 28
        Me.dgAdmin.Size = New System.Drawing.Size(799, 551)
        Me.dgAdmin.TabIndex = 5
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(626, 103)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(78, 40)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "ADD"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'cbAktif
        '
        Me.cbAktif.AutoSize = True
        Me.cbAktif.BackColor = System.Drawing.Color.Transparent
        Me.cbAktif.Checked = True
        Me.cbAktif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAktif.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAktif.ForeColor = System.Drawing.Color.White
        Me.cbAktif.Location = New System.Drawing.Point(9, 111)
        Me.cbAktif.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAktif.Name = "cbAktif"
        Me.cbAktif.Size = New System.Drawing.Size(80, 24)
        Me.cbAktif.TabIndex = 7
        Me.cbAktif.Text = "ACTIVE"
        Me.cbAktif.UseVisualStyleBackColor = False
        '
        'btHome
        '
        Me.btHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btHome.Location = New System.Drawing.Point(1146, 12)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(122, 112)
        Me.btHome.TabIndex = 8
        Me.btHome.Text = "HOME"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'formInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.khot_dog_sosiski_bulki_ketchup_sous_sousy_tomaty_zelen_stol
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.cbAktif)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.dgAdmin)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.ctStokbahan)
        Me.Controls.Add(Me.ctKursimeja)
        Me.Controls.Add(Me.ctKategorimenu)
        Me.Controls.Add(Me.ctMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formInsert"
        Me.Text = "Form3"
        CType(Me.dgAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ctMenu As DevExpress.XtraEditors.CheckButton
    Friend WithEvents ctKategorimenu As DevExpress.XtraEditors.CheckButton
    Friend WithEvents ctKursimeja As DevExpress.XtraEditors.CheckButton
    Friend WithEvents ctStokbahan As DevExpress.XtraEditors.CheckButton
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents dgAdmin As DataGridView
    Friend WithEvents btAdd As Button
    Friend WithEvents cbAktif As CheckBox
    Friend WithEvents btHome As Button
End Class
