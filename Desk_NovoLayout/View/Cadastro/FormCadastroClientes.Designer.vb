<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroClientes
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
        Me.RbtJuridico = New System.Windows.Forms.RadioButton()
        Me.RbtFisico = New System.Windows.Forms.RadioButton()
        Me.MskClieteNumero = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.CbxClienteCidade = New System.Windows.Forms.ComboBox()
        Me.CbxClienteEstado = New System.Windows.Forms.ComboBox()
        Me.MskClienteRG = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtClienteBairro = New System.Windows.Forms.TextBox()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.TxtClienteEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MskCliente_CPF_CNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MskClienteCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.TxtClienteLogradouro = New System.Windows.Forms.TextBox()
        Me.MskClienteTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.MskClienteCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TxtClienteNome = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.btnCheques = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RbtJuridico
        '
        Me.RbtJuridico.AutoSize = True
        Me.RbtJuridico.Location = New System.Drawing.Point(181, 13)
        Me.RbtJuridico.Name = "RbtJuridico"
        Me.RbtJuridico.Size = New System.Drawing.Size(63, 17)
        Me.RbtJuridico.TabIndex = 130
        Me.RbtJuridico.TabStop = True
        Me.RbtJuridico.Text = "Jurídico"
        Me.RbtJuridico.UseVisualStyleBackColor = True
        '
        'RbtFisico
        '
        Me.RbtFisico.AutoSize = True
        Me.RbtFisico.Location = New System.Drawing.Point(114, 12)
        Me.RbtFisico.Name = "RbtFisico"
        Me.RbtFisico.Size = New System.Drawing.Size(54, 17)
        Me.RbtFisico.TabIndex = 129
        Me.RbtFisico.TabStop = True
        Me.RbtFisico.Text = "Físico"
        Me.RbtFisico.UseVisualStyleBackColor = True
        '
        'MskClieteNumero
        '
        Me.MskClieteNumero.Location = New System.Drawing.Point(343, 226)
        Me.MskClieteNumero.Mask = "09999"
        Me.MskClieteNumero.Name = "MskClieteNumero"
        Me.MskClieteNumero.Size = New System.Drawing.Size(35, 20)
        Me.MskClieteNumero.TabIndex = 109
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleName = "btnCancelar"
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(595, 132)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 35)
        Me.btnCancelar.TabIndex = 126
        Me.btnCancelar.Tag = "btnCancelar"
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnLocalizar
        '
        Me.btnLocalizar.AccessibleName = "btnLocalizar"
        Me.btnLocalizar.BackColor = System.Drawing.Color.Transparent
        Me.btnLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalizar.ForeColor = System.Drawing.Color.Black
        Me.btnLocalizar.Location = New System.Drawing.Point(595, 173)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(83, 35)
        Me.btnLocalizar.TabIndex = 127
        Me.btnLocalizar.Tag = "btnLocalizar"
        Me.btnLocalizar.Text = "&Localizar"
        Me.btnLocalizar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.AccessibleName = "btnSair"
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Location = New System.Drawing.Point(595, 255)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 32)
        Me.btnSair.TabIndex = 128
        Me.btnSair.Tag = "btnSair"
        Me.btnSair.Text = "Sai&r"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.AccessibleName = "btnAlterar"
        Me.btnAlterar.BackColor = System.Drawing.Color.Transparent
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(595, 91)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(83, 35)
        Me.btnAlterar.TabIndex = 124
        Me.btnAlterar.Tag = "btnAlterar"
        Me.btnAlterar.Text = "&Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnGravar
        '
        Me.btnGravar.AccessibleName = "btnGravar"
        Me.btnGravar.BackColor = System.Drawing.Color.Transparent
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.Color.Black
        Me.btnGravar.Location = New System.Drawing.Point(595, 52)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(83, 33)
        Me.btnGravar.TabIndex = 123
        Me.btnGravar.Tag = "btnGravar"
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.AccessibleName = "btnNovo"
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Location = New System.Drawing.Point(595, 13)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(83, 33)
        Me.btnNovo.TabIndex = 122
        Me.btnNovo.Tag = "btnNovo"
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'CbxClienteCidade
        '
        Me.CbxClienteCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxClienteCidade.FormattingEnabled = True
        Me.CbxClienteCidade.Items.AddRange(New Object() {"", "São Paulo", "Mairiporã", "Belo Horizonte"})
        Me.CbxClienteCidade.Location = New System.Drawing.Point(343, 252)
        Me.CbxClienteCidade.Name = "CbxClienteCidade"
        Me.CbxClienteCidade.Size = New System.Drawing.Size(170, 21)
        Me.CbxClienteCidade.TabIndex = 111
        '
        'CbxClienteEstado
        '
        Me.CbxClienteEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxClienteEstado.FormattingEnabled = True
        Me.CbxClienteEstado.Items.AddRange(New Object() {"Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA) ", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)"})
        Me.CbxClienteEstado.Location = New System.Drawing.Point(99, 252)
        Me.CbxClienteEstado.Name = "CbxClienteEstado"
        Me.CbxClienteEstado.Size = New System.Drawing.Size(171, 21)
        Me.CbxClienteEstado.Sorted = True
        Me.CbxClienteEstado.TabIndex = 110
        '
        'MskClienteRG
        '
        Me.MskClienteRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskClienteRG.Location = New System.Drawing.Point(343, 106)
        Me.MskClienteRG.Mask = "000,000,000-&"
        Me.MskClienteRG.Name = "MskClienteRG"
        Me.MskClienteRG.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MskClienteRG.Size = New System.Drawing.Size(169, 24)
        Me.MskClienteRG.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 18)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Email:"
        '
        'TxtClienteBairro
        '
        Me.TxtClienteBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClienteBairro.Location = New System.Drawing.Point(99, 222)
        Me.TxtClienteBairro.Name = "TxtClienteBairro"
        Me.TxtClienteBairro.Size = New System.Drawing.Size(169, 24)
        Me.TxtClienteBairro.TabIndex = 108
        Me.TxtClienteBairro.Tag = ""
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(309, 110)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(30, 18)
        Me.lblRG.TabIndex = 121
        Me.lblRG.Text = "RG:"
        '
        'TxtClienteEmail
        '
        Me.TxtClienteEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClienteEmail.Location = New System.Drawing.Point(99, 132)
        Me.TxtClienteEmail.Name = "TxtClienteEmail"
        Me.TxtClienteEmail.Size = New System.Drawing.Size(215, 24)
        Me.TxtClienteEmail.TabIndex = 105
        Me.TxtClienteEmail.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 18)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Nome:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(63, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 18)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "CEP:"
        '
        'MskCliente_CPF_CNPJ
        '
        Me.MskCliente_CPF_CNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCliente_CPF_CNPJ.Location = New System.Drawing.Point(99, 101)
        Me.MskCliente_CPF_CNPJ.Mask = "000,000,000-00"
        Me.MskCliente_CPF_CNPJ.Name = "MskCliente_CPF_CNPJ"
        Me.MskCliente_CPF_CNPJ.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MskCliente_CPF_CNPJ.Size = New System.Drawing.Size(169, 24)
        Me.MskCliente_CPF_CNPJ.TabIndex = 103
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 18)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Logradouro:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 18)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Telefone:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(47, 255)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 18)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "Estado:"
        '
        'MskClienteCEP
        '
        Me.MskClienteCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskClienteCEP.Location = New System.Drawing.Point(99, 162)
        Me.MskClienteCEP.Mask = "00000-000"
        Me.MskClienteCEP.Name = "MskClienteCEP"
        Me.MskClienteCEP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MskClienteCEP.Size = New System.Drawing.Size(169, 24)
        Me.MskClienteCEP.TabIndex = 106
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(277, 229)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(63, 18)
        Me.lblNumero.TabIndex = 120
        Me.lblNumero.Text = "Número:"
        '
        'TxtClienteLogradouro
        '
        Me.TxtClienteLogradouro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClienteLogradouro.Location = New System.Drawing.Point(99, 192)
        Me.TxtClienteLogradouro.Name = "TxtClienteLogradouro"
        Me.TxtClienteLogradouro.Size = New System.Drawing.Size(413, 24)
        Me.TxtClienteLogradouro.TabIndex = 107
        Me.TxtClienteLogradouro.Tag = ""
        '
        'MskClienteTel
        '
        Me.MskClienteTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskClienteTel.Location = New System.Drawing.Point(99, 71)
        Me.MskClienteTel.Mask = "(99) 0000-0000"
        Me.MskClienteTel.Name = "MskClienteTel"
        Me.MskClienteTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MskClienteTel.Size = New System.Drawing.Size(169, 24)
        Me.MskClienteTel.TabIndex = 101
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(47, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 18)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Bairro:"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(61, 105)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(35, 18)
        Me.lblCPF.TabIndex = 112
        Me.lblCPF.Text = "CPF:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(284, 75)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(56, 18)
        Me.lblCelular.TabIndex = 119
        Me.lblCelular.Text = "Celular:"
        '
        'MskClienteCelular
        '
        Me.MskClienteCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskClienteCelular.Location = New System.Drawing.Point(343, 71)
        Me.MskClienteCelular.Mask = "(99) 90000-0000"
        Me.MskClienteCelular.Name = "MskClienteCelular"
        Me.MskClienteCelular.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MskClienteCelular.Size = New System.Drawing.Size(169, 24)
        Me.MskClienteCelular.TabIndex = 102
        '
        'TxtClienteNome
        '
        Me.TxtClienteNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClienteNome.Location = New System.Drawing.Point(99, 41)
        Me.TxtClienteNome.Name = "TxtClienteNome"
        Me.TxtClienteNome.Size = New System.Drawing.Size(413, 24)
        Me.TxtClienteNome.TabIndex = 99
        Me.TxtClienteNome.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(288, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = "Cidade:"
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.Location = New System.Drawing.Point(54, 105)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(42, 18)
        Me.lblCNPJ.TabIndex = 131
        Me.lblCNPJ.Text = "CNPJ:"
        Me.lblCNPJ.Visible = False
        '
        'btnCheques
        '
        Me.btnCheques.AccessibleName = "btnCheques"
        Me.btnCheques.BackColor = System.Drawing.Color.Transparent
        Me.btnCheques.Enabled = False
        Me.btnCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheques.ForeColor = System.Drawing.Color.Black
        Me.btnCheques.Location = New System.Drawing.Point(595, 214)
        Me.btnCheques.Name = "btnCheques"
        Me.btnCheques.Size = New System.Drawing.Size(83, 35)
        Me.btnCheques.TabIndex = 132
        Me.btnCheques.Tag = "btnCheque"
        Me.btnCheques.Text = "&Cheques"
        Me.btnCheques.UseVisualStyleBackColor = False
        '
        'FormCadastroClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 305)
        Me.Controls.Add(Me.btnCheques)
        Me.Controls.Add(Me.lblCNPJ)
        Me.Controls.Add(Me.RbtJuridico)
        Me.Controls.Add(Me.RbtFisico)
        Me.Controls.Add(Me.MskClieteNumero)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLocalizar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.CbxClienteCidade)
        Me.Controls.Add(Me.CbxClienteEstado)
        Me.Controls.Add(Me.MskClienteRG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtClienteBairro)
        Me.Controls.Add(Me.lblRG)
        Me.Controls.Add(Me.TxtClienteEmail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MskCliente_CPF_CNPJ)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.MskClienteCEP)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.TxtClienteLogradouro)
        Me.Controls.Add(Me.MskClienteTel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.MskClienteCelular)
        Me.Controls.Add(Me.TxtClienteNome)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormCadastroClientes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RbtJuridico As System.Windows.Forms.RadioButton
    Friend WithEvents RbtFisico As System.Windows.Forms.RadioButton
    Friend WithEvents MskClieteNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents CbxClienteCidade As System.Windows.Forms.ComboBox
    Friend WithEvents CbxClienteEstado As System.Windows.Forms.ComboBox
    Friend WithEvents MskClienteRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtClienteBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents TxtClienteEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MskCliente_CPF_CNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MskClienteCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents TxtClienteLogradouro As System.Windows.Forms.TextBox
    Friend WithEvents MskClienteTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents MskClienteCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtClienteNome As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents btnCheques As System.Windows.Forms.Button
End Class
