﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.LbCust = New System.Windows.Forms.Label()
        Me.LbTable = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvMenu = New System.Windows.Forms.DataGridView()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.PbBack = New System.Windows.Forms.PictureBox()
        CType(Me.DgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbCust
        '
        Me.LbCust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbCust.AutoSize = True
        Me.LbCust.Location = New System.Drawing.Point(353, 138)
        Me.LbCust.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCust.Name = "LbCust"
        Me.LbCust.Size = New System.Drawing.Size(57, 20)
        Me.LbCust.TabIndex = 9
        Me.LbCust.Text = "Label4"
        '
        'LbTable
        '
        Me.LbTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTable.AutoSize = True
        Me.LbTable.Location = New System.Drawing.Point(353, 85)
        Me.LbTable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbTable.Name = "LbTable"
        Me.LbTable.Size = New System.Drawing.Size(57, 20)
        Me.LbTable.TabIndex = 8
        Me.LbTable.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(758, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Customer Name    :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(758, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Table                    :"
        '
        'DgvMenu
        '
        Me.DgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMenu.Location = New System.Drawing.Point(454, 191)
        Me.DgvMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvMenu.Name = "DgvMenu"
        Me.DgvMenu.ReadOnly = True
        Me.DgvMenu.RowHeadersWidth = 62
        Me.DgvMenu.Size = New System.Drawing.Size(848, 374)
        Me.DgvMenu.TabIndex = 5
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(820, 682)
        Me.BtnCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(112, 35)
        Me.BtnCheck.TabIndex = 10
        Me.BtnCheck.Text = "Checkout"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'PbBack
        '
        Me.PbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PbBack.Image = Global.COBAAN_TUHAN.My.Resources.Resources.how_to_make_a_png_an_icon_2
        Me.PbBack.Location = New System.Drawing.Point(56, 43)
        Me.PbBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbBack.Name = "PbBack"
        Me.PbBack.Size = New System.Drawing.Size(64, 62)
        Me.PbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbBack.TabIndex = 16
        Me.PbBack.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PbBack)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.LbCust)
        Me.Controls.Add(Me.LbTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormMenu"
        Me.Text = "Form10"
        CType(Me.DgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCust As Label
    Friend WithEvents LbTable As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvMenu As DataGridView
    Friend WithEvents BtnCheck As Button
    Friend WithEvents PbBack As PictureBox
End Class