<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuConsultas
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
        Me.btnConsultaClientes = New System.Windows.Forms.Button()
        Me.btnChecksCleared = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsultaClientes
        '
        Me.btnConsultaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaClientes.Location = New System.Drawing.Point(64, 27)
        Me.btnConsultaClientes.Name = "btnConsultaClientes"
        Me.btnConsultaClientes.Size = New System.Drawing.Size(217, 42)
        Me.btnConsultaClientes.TabIndex = 8
        Me.btnConsultaClientes.Text = "Clientes"
        Me.btnConsultaClientes.UseVisualStyleBackColor = True
        '
        'btnChecksCleared
        '
        Me.btnChecksCleared.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChecksCleared.Location = New System.Drawing.Point(64, 75)
        Me.btnChecksCleared.Name = "btnChecksCleared"
        Me.btnChecksCleared.Size = New System.Drawing.Size(217, 42)
        Me.btnChecksCleared.TabIndex = 10
        Me.btnChecksCleared.Text = "Planilha de Cheques"
        Me.btnChecksCleared.UseVisualStyleBackColor = True
        '
        'MenuConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 157)
        Me.Controls.Add(Me.btnChecksCleared)
        Me.Controls.Add(Me.btnConsultaClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MenuConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuConsultas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsultaClientes As System.Windows.Forms.Button
    Friend WithEvents btnChecksCleared As System.Windows.Forms.Button
End Class
