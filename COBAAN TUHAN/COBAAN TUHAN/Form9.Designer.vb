<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.TbCust = New System.Windows.Forms.TextBox()
        Me.LbTable = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbExit = New System.Windows.Forms.PictureBox()
        CType(Me.PbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(163, 152)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrder.TabIndex = 15
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'TbCust
        '
        Me.TbCust.Location = New System.Drawing.Point(194, 88)
        Me.TbCust.Name = "TbCust"
        Me.TbCust.Size = New System.Drawing.Size(119, 20)
        Me.TbCust.TabIndex = 14
        '
        'LbTable
        '
        Me.LbTable.AutoSize = True
        Me.LbTable.Location = New System.Drawing.Point(300, 56)
        Me.LbTable.Name = "LbTable"
        Me.LbTable.Size = New System.Drawing.Size(13, 13)
        Me.LbTable.TabIndex = 13
        Me.LbTable.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Customer Name    :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Table                    :"
        '
        'PbExit
        '
        Me.PbExit.Image = Global.COBAAN_TUHAN.My.Resources.Resources.close
        Me.PbExit.Location = New System.Drawing.Point(387, 17)
        Me.PbExit.Name = "PbExit"
        Me.PbExit.Size = New System.Drawing.Size(42, 30)
        Me.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbExit.TabIndex = 16
        Me.PbExit.TabStop = False
        '
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 213)
        Me.Controls.Add(Me.PbExit)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.TbCust)
        Me.Controls.Add(Me.LbTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        CType(Me.PbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbExit As PictureBox
    Friend WithEvents BtnOrder As Button
    Friend WithEvents TbCust As TextBox
    Friend WithEvents LbTable As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
