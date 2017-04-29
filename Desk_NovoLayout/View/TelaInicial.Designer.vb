<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaInicial
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCadastroClientes = New System.Windows.Forms.ToolStripButton()
        Me.tsbCadastroCheques = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultas = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCadastroClientes, Me.tsbCadastroCheques, Me.tsbConsultas, Me.tssSeparador, Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(715, 70)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCadastroClientes
        '
        Me.tsbCadastroClientes.Image = Global.tela_inicial.My.Resources.Resources.Botão_Cli1
        Me.tsbCadastroClientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCadastroClientes.Name = "tsbCadastroClientes"
        Me.tsbCadastroClientes.Size = New System.Drawing.Size(114, 67)
        Me.tsbCadastroClientes.Text = "Cadastro de Cliente"
        Me.tsbCadastroClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCadastroCheques
        '
        Me.tsbCadastroCheques.Image = Global.tela_inicial.My.Resources.Resources.Botão_Lan1
        Me.tsbCadastroCheques.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCadastroCheques.Name = "tsbCadastroCheques"
        Me.tsbCadastroCheques.Size = New System.Drawing.Size(123, 67)
        Me.tsbCadastroCheques.Text = "Cadastro de Cheques"
        Me.tsbCadastroCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbConsultas
        '
        Me.tsbConsultas.Image = Global.tela_inicial.My.Resources.Resources.Btn_Cons1
        Me.tsbConsultas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultas.Name = "tsbConsultas"
        Me.tsbConsultas.Size = New System.Drawing.Size(63, 67)
        Me.tsbConsultas.Text = "Consultas"
        Me.tsbConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tssSeparador
        '
        Me.tssSeparador.Name = "tssSeparador"
        Me.tssSeparador.Size = New System.Drawing.Size(6, 70)
        '
        'tsbSair
        '
        Me.tsbSair.Image = Global.tela_inicial.My.Resources.Resources.Botão_Porta1
        Me.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(52, 67)
        Me.tsbSair.Text = "Sair"
        Me.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 557)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "TelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeskFaturamentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCadastroClientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsultas As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCadastroCheques As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
