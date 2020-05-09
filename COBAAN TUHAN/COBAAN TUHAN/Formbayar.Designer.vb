<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formbayar
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
        Me.LLinput = New System.Windows.Forms.Label()
        Me.BTsubmit = New System.Windows.Forms.Button()
        Me.NUDangka = New System.Windows.Forms.NumericUpDown()
        CType(Me.NUDangka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LLinput
        '
        Me.LLinput.AutoSize = True
        Me.LLinput.Location = New System.Drawing.Point(192, 55)
        Me.LLinput.Name = "LLinput"
        Me.LLinput.Size = New System.Drawing.Size(166, 13)
        Me.LLinput.TabIndex = 1
        Me.LLinput.Text = "Silahkan Input Uang Pembayaran"
        '
        'BTsubmit
        '
        Me.BTsubmit.Location = New System.Drawing.Point(225, 158)
        Me.BTsubmit.Name = "BTsubmit"
        Me.BTsubmit.Size = New System.Drawing.Size(92, 57)
        Me.BTsubmit.TabIndex = 2
        Me.BTsubmit.Text = "Submit"
        Me.BTsubmit.UseVisualStyleBackColor = True
        '
        'NUDangka
        '
        Me.NUDangka.Increment = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.NUDangka.Location = New System.Drawing.Point(188, 101)
        Me.NUDangka.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NUDangka.Name = "NUDangka"
        Me.NUDangka.Size = New System.Drawing.Size(170, 20)
        Me.NUDangka.TabIndex = 3
        '
        'Formbayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 271)
        Me.Controls.Add(Me.NUDangka)
        Me.Controls.Add(Me.BTsubmit)
        Me.Controls.Add(Me.LLinput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formbayar"
        Me.Text = "Formbayar"
        CType(Me.NUDangka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LLinput As Label
    Friend WithEvents BTsubmit As Button
    Friend WithEvents NUDangka As NumericUpDown
End Class
