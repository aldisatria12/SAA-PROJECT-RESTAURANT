﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheck
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
        Me.components = New System.ComponentModel.Container()
        Me.LbCust = New System.Windows.Forms.Label()
        Me.LbTable = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvCheck = New System.Windows.Forms.DataGridView()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TmIn = New System.Windows.Forms.Timer(Me.components)
        Me.PbBack = New System.Windows.Forms.PictureBox()
        CType(Me.DgvCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbCust
        '
        Me.LbCust.AutoSize = True
        Me.LbCust.BackColor = System.Drawing.Color.Transparent
        Me.LbCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCust.Location = New System.Drawing.Point(435, 97)
        Me.LbCust.Name = "LbCust"
        Me.LbCust.Size = New System.Drawing.Size(45, 13)
        Me.LbCust.TabIndex = 13
        Me.LbCust.Text = "Label4"
        '
        'LbTable
        '
        Me.LbTable.AutoSize = True
        Me.LbTable.BackColor = System.Drawing.Color.Transparent
        Me.LbTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTable.Location = New System.Drawing.Point(435, 62)
        Me.LbTable.Name = "LbTable"
        Me.LbTable.Size = New System.Drawing.Size(45, 13)
        Me.LbTable.TabIndex = 12
        Me.LbTable.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Customer Name    :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Table                    :"
        '
        'DgvCheck
        '
        Me.DgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCheck.Location = New System.Drawing.Point(297, 151)
        Me.DgvCheck.Name = "DgvCheck"
        Me.DgvCheck.RowHeadersWidth = 62
        Me.DgvCheck.Size = New System.Drawing.Size(801, 367)
        Me.DgvCheck.TabIndex = 9
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(647, 551)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(101, 39)
        Me.BtnSubmit.TabIndex = 14
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'TmIn
        '
        Me.TmIn.Enabled = True
        '
        'PbBack
        '
        Me.PbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PbBack.Image = Global.COBAAN_TUHAN.My.Resources.Resources.how_to_make_a_png_an_icon_2
        Me.PbBack.Location = New System.Drawing.Point(12, 12)
        Me.PbBack.Name = "PbBack"
        Me.PbBack.Size = New System.Drawing.Size(85, 85)
        Me.PbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBack.TabIndex = 15
        Me.PbBack.TabStop = False
        '
        'FormCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.red_tomatoes_tomatoes_wallpaper_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PbBack)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LbCust)
        Me.Controls.Add(Me.LbTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCheck"
        Me.Text = "Form12"
        CType(Me.DgvCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCust As Label
    Friend WithEvents LbTable As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvCheck As DataGridView
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TmIn As Timer
    Friend WithEvents PbBack As PictureBox
End Class
