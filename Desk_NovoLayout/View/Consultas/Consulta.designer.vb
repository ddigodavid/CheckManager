<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtClientes = New System.Windows.Forms.RadioButton()
        Me.rbtLancamentos = New System.Windows.Forms.RadioButton()
        Me.gbxDestinoConsulta = New System.Windows.Forms.GroupBox()
        Me.gbxOpcoesClientes = New System.Windows.Forms.GroupBox()
        Me.rbtClienteCPF = New System.Windows.Forms.RadioButton()
        Me.rbtClienteNome = New System.Windows.Forms.RadioButton()
        Me.mskBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.btnImp = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDestinoConsulta.SuspendLayout()
        Me.gbxOpcoesClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 210)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(694, 282)
        Me.DgdGrade.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(166, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        '
        'rbtClientes
        '
        Me.rbtClientes.AutoSize = True
        Me.rbtClientes.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.rbtClientes.ForeColor = System.Drawing.Color.Black
        Me.rbtClientes.Location = New System.Drawing.Point(6, 19)
        Me.rbtClientes.Name = "rbtClientes"
        Me.rbtClientes.Size = New System.Drawing.Size(77, 22)
        Me.rbtClientes.TabIndex = 11
        Me.rbtClientes.TabStop = True
        Me.rbtClientes.Text = "Clientes"
        Me.rbtClientes.UseVisualStyleBackColor = True
        '
        'rbtLancamentos
        '
        Me.rbtLancamentos.AutoSize = True
        Me.rbtLancamentos.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.rbtLancamentos.ForeColor = System.Drawing.Color.Black
        Me.rbtLancamentos.Location = New System.Drawing.Point(6, 75)
        Me.rbtLancamentos.Name = "rbtLancamentos"
        Me.rbtLancamentos.Size = New System.Drawing.Size(107, 22)
        Me.rbtLancamentos.TabIndex = 13
        Me.rbtLancamentos.TabStop = True
        Me.rbtLancamentos.Text = "Lançamentos"
        Me.rbtLancamentos.UseVisualStyleBackColor = True
        '
        'gbxDestinoConsulta
        '
        Me.gbxDestinoConsulta.Controls.Add(Me.rbtClientes)
        Me.gbxDestinoConsulta.Controls.Add(Me.rbtLancamentos)
        Me.gbxDestinoConsulta.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.gbxDestinoConsulta.ForeColor = System.Drawing.Color.Black
        Me.gbxDestinoConsulta.Location = New System.Drawing.Point(12, 12)
        Me.gbxDestinoConsulta.Name = "gbxDestinoConsulta"
        Me.gbxDestinoConsulta.Size = New System.Drawing.Size(145, 117)
        Me.gbxDestinoConsulta.TabIndex = 15
        Me.gbxDestinoConsulta.TabStop = False
        Me.gbxDestinoConsulta.Tag = "x"
        Me.gbxDestinoConsulta.Text = "Destino da Consulta"
        '
        'gbxOpcoesClientes
        '
        Me.gbxOpcoesClientes.Controls.Add(Me.rbtClienteCPF)
        Me.gbxOpcoesClientes.Controls.Add(Me.rbtClienteNome)
        Me.gbxOpcoesClientes.Enabled = False
        Me.gbxOpcoesClientes.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.gbxOpcoesClientes.ForeColor = System.Drawing.Color.Black
        Me.gbxOpcoesClientes.Location = New System.Drawing.Point(163, 12)
        Me.gbxOpcoesClientes.Name = "gbxOpcoesClientes"
        Me.gbxOpcoesClientes.Size = New System.Drawing.Size(132, 80)
        Me.gbxOpcoesClientes.TabIndex = 16
        Me.gbxOpcoesClientes.TabStop = False
        Me.gbxOpcoesClientes.Tag = "-"
        Me.gbxOpcoesClientes.Text = "Opções Clientes"
        '
        'rbtClienteCPF
        '
        Me.rbtClienteCPF.AutoSize = True
        Me.rbtClienteCPF.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.rbtClienteCPF.ForeColor = System.Drawing.Color.Black
        Me.rbtClienteCPF.Location = New System.Drawing.Point(6, 47)
        Me.rbtClienteCPF.Name = "rbtClienteCPF"
        Me.rbtClienteCPF.Size = New System.Drawing.Size(49, 22)
        Me.rbtClienteCPF.TabIndex = 16
        Me.rbtClienteCPF.TabStop = True
        Me.rbtClienteCPF.Text = "CPF"
        Me.rbtClienteCPF.UseVisualStyleBackColor = True
        '
        'rbtClienteNome
        '
        Me.rbtClienteNome.AutoSize = True
        Me.rbtClienteNome.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.rbtClienteNome.ForeColor = System.Drawing.Color.Black
        Me.rbtClienteNome.Location = New System.Drawing.Point(6, 19)
        Me.rbtClienteNome.Name = "rbtClienteNome"
        Me.rbtClienteNome.Size = New System.Drawing.Size(64, 22)
        Me.rbtClienteNome.TabIndex = 15
        Me.rbtClienteNome.TabStop = True
        Me.rbtClienteNome.Text = "Nome"
        Me.rbtClienteNome.UseVisualStyleBackColor = True
        '
        'mskBuscar
        '
        Me.mskBuscar.Enabled = False
        Me.mskBuscar.Location = New System.Drawing.Point(169, 172)
        Me.mskBuscar.Name = "mskBuscar"
        Me.mskBuscar.Size = New System.Drawing.Size(327, 20)
        Me.mskBuscar.TabIndex = 18
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(506, 169)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 20
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(718, 504)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.mskBuscar)
        Me.Controls.Add(Me.gbxOpcoesClientes)
        Me.Controls.Add(Me.gbxDestinoConsulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDestinoConsulta.ResumeLayout(False)
        Me.gbxDestinoConsulta.PerformLayout()
        Me.gbxOpcoesClientes.ResumeLayout(False)
        Me.gbxOpcoesClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtClientes As System.Windows.Forms.RadioButton
    Friend WithEvents rbtLancamentos As System.Windows.Forms.RadioButton
    Friend WithEvents gbxDestinoConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents gbxOpcoesClientes As System.Windows.Forms.GroupBox
    Friend WithEvents rbtClienteNome As System.Windows.Forms.RadioButton
    Friend WithEvents rbtClienteCPF As System.Windows.Forms.RadioButton
    Friend WithEvents mskBuscar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnImp As System.Windows.Forms.Button

End Class
