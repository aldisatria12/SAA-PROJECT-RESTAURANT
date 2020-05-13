<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngredients
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
        Me.dgIngredients = New System.Windows.Forms.DataGridView()
        Me.btApply = New System.Windows.Forms.Button()
        CType(Me.dgIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgIngredients
        '
        Me.dgIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIngredients.Location = New System.Drawing.Point(213, 69)
        Me.dgIngredients.Name = "dgIngredients"
        Me.dgIngredients.Size = New System.Drawing.Size(542, 336)
        Me.dgIngredients.TabIndex = 0
        '
        'btApply
        '
        Me.btApply.Location = New System.Drawing.Point(659, 427)
        Me.btApply.Name = "btApply"
        Me.btApply.Size = New System.Drawing.Size(96, 23)
        Me.btApply.TabIndex = 11
        Me.btApply.Text = "Apply"
        Me.btApply.UseVisualStyleBackColor = True
        '
        'FormIngredients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COBAAN_TUHAN.My.Resources.Resources._444634_PEMTQB_849
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 515)
        Me.Controls.Add(Me.btApply)
        Me.Controls.Add(Me.dgIngredients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormIngredients"
        Me.Text = "FormIngredients"
        CType(Me.dgIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgIngredients As DataGridView
    Friend WithEvents btApply As Button
End Class
