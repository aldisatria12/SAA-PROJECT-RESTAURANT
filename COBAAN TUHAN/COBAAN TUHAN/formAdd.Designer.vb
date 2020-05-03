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
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
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
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(331, 327)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 8
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(566, 327)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(75, 23)
        Me.btBack.TabIndex = 9
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'formAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources._444634_PEMTQB_849
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 520)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.lbAdd)
        Me.Controls.Add(Me.pbAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formAdd"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbAdd As PictureBox
    Friend WithEvents lbAdd As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btBack As Button
End Class
