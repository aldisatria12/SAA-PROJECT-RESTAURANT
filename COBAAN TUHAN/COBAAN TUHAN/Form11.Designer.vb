<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeterangan
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
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.RtbKet = New System.Windows.Forms.RichTextBox()
        Me.LbMenu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(270, 262)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(112, 35)
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'RtbKet
        '
        Me.RtbKet.Location = New System.Drawing.Point(188, 82)
        Me.RtbKet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RtbKet.Name = "RtbKet"
        Me.RtbKet.Size = New System.Drawing.Size(382, 146)
        Me.RtbKet.TabIndex = 8
        Me.RtbKet.Text = ""
        '
        'LbMenu
        '
        Me.LbMenu.AutoSize = True
        Me.LbMenu.BackColor = System.Drawing.Color.Transparent
        Me.LbMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMenu.Location = New System.Drawing.Point(183, 35)
        Me.LbMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbMenu.Name = "LbMenu"
        Me.LbMenu.Size = New System.Drawing.Size(77, 25)
        Me.LbMenu.TabIndex = 7
        Me.LbMenu.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Keterangan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(66, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Menu          :"
        '
        'FormKeterangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources.coffee_core_texture_caffeine
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 335)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.RtbKet)
        Me.Controls.Add(Me.LbMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormKeterangan"
        Me.Text = "Form11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOk As Button
    Friend WithEvents RtbKet As RichTextBox
    Friend WithEvents LbMenu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
