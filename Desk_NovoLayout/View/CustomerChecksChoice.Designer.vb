<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerChecksChoice
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
        Me.btnChecksCleared = New System.Windows.Forms.Button()
        Me.btnNewCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChecksCleared
        '
        Me.btnChecksCleared.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChecksCleared.Location = New System.Drawing.Point(98, 84)
        Me.btnChecksCleared.Name = "btnChecksCleared"
        Me.btnChecksCleared.Size = New System.Drawing.Size(217, 42)
        Me.btnChecksCleared.TabIndex = 12
        Me.btnChecksCleared.Text = "Cheques compensados"
        Me.btnChecksCleared.UseVisualStyleBackColor = True
        '
        'btnNewCheck
        '
        Me.btnNewCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCheck.Location = New System.Drawing.Point(98, 36)
        Me.btnNewCheck.Name = "btnNewCheck"
        Me.btnNewCheck.Size = New System.Drawing.Size(217, 42)
        Me.btnNewCheck.TabIndex = 11
        Me.btnNewCheck.Text = "Novo Cheque"
        Me.btnNewCheck.UseVisualStyleBackColor = True
        '
        'CustomerChecksChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 168)
        Me.Controls.Add(Me.btnChecksCleared)
        Me.Controls.Add(Me.btnNewCheck)
        Me.MaximizeBox = False
        Me.Name = "CustomerChecksChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerChecksChoice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChecksCleared As System.Windows.Forms.Button
    Friend WithEvents btnNewCheck As System.Windows.Forms.Button
End Class
