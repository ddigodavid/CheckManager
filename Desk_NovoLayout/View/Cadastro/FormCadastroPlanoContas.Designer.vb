<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroPlanoContas
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
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtPlanoNumeroReduzido = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLocalizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.MskPlanoNumConta = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPlanoDescricao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"", "S", "A"})
        Me.cbxTipo.Location = New System.Drawing.Point(15, 221)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbxTipo.TabIndex = 33
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(12, 200)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 18)
        Me.lblTipo.TabIndex = 44
        Me.lblTipo.Text = "Tipo:"
        '
        'txtPlanoNumeroReduzido
        '
        Me.txtPlanoNumeroReduzido.Location = New System.Drawing.Point(15, 50)
        Me.txtPlanoNumeroReduzido.Name = "txtPlanoNumeroReduzido"
        Me.txtPlanoNumeroReduzido.Size = New System.Drawing.Size(114, 20)
        Me.txtPlanoNumeroReduzido.TabIndex = 30
        Me.txtPlanoNumeroReduzido.Tag = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(12, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 18)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Número Reduzido:"
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleName = "btnSair"
        Me.BtnSair.BackColor = System.Drawing.Color.Transparent
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Black
        Me.BtnSair.Location = New System.Drawing.Point(256, 265)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(83, 32)
        Me.BtnSair.TabIndex = 42
        Me.BtnSair.Tag = "btnSair"
        Me.BtnSair.Text = "Sai&r"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnLocalizar
        '
        Me.BtnLocalizar.AccessibleName = "btnLocalizar"
        Me.BtnLocalizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocalizar.ForeColor = System.Drawing.Color.Black
        Me.BtnLocalizar.Location = New System.Drawing.Point(256, 224)
        Me.BtnLocalizar.Name = "BtnLocalizar"
        Me.BtnLocalizar.Size = New System.Drawing.Size(83, 35)
        Me.BtnLocalizar.TabIndex = 41
        Me.BtnLocalizar.Tag = "btnLocalizar"
        Me.BtnLocalizar.Text = "&Localizar"
        Me.BtnLocalizar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleName = "btnCancelar"
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(256, 183)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(83, 35)
        Me.BtnCancelar.TabIndex = 40
        Me.BtnCancelar.Tag = "btnCancelar"
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.AccessibleName = "btnExcluir"
        Me.BtnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Black
        Me.BtnExcluir.Location = New System.Drawing.Point(256, 140)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(83, 37)
        Me.BtnExcluir.TabIndex = 39
        Me.BtnExcluir.Tag = "btnExcluir"
        Me.BtnExcluir.Text = "&Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnAlterar
        '
        Me.BtnAlterar.AccessibleName = "btnAlterar"
        Me.BtnAlterar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.ForeColor = System.Drawing.Color.Black
        Me.BtnAlterar.Location = New System.Drawing.Point(256, 99)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(83, 35)
        Me.BtnAlterar.TabIndex = 38
        Me.BtnAlterar.Tag = "btnAlterar"
        Me.BtnAlterar.Text = "&Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = False
        '
        'BtnGravar
        '
        Me.BtnGravar.AccessibleName = "btnGravar"
        Me.BtnGravar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGravar.ForeColor = System.Drawing.Color.Black
        Me.BtnGravar.Location = New System.Drawing.Point(256, 60)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(83, 33)
        Me.BtnGravar.TabIndex = 37
        Me.BtnGravar.Tag = "btnGravar"
        Me.BtnGravar.Text = "&Gravar"
        Me.BtnGravar.UseVisualStyleBackColor = False
        '
        'BtnNovo
        '
        Me.BtnNovo.AccessibleName = ""
        Me.BtnNovo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Black
        Me.BtnNovo.Location = New System.Drawing.Point(256, 21)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(83, 33)
        Me.BtnNovo.TabIndex = 36
        Me.BtnNovo.Tag = "btnNovo"
        Me.BtnNovo.Text = "&Novo"
        Me.BtnNovo.UseVisualStyleBackColor = False
        '
        'MskPlanoNumConta
        '
        Me.MskPlanoNumConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPlanoNumConta.Location = New System.Drawing.Point(15, 173)
        Me.MskPlanoNumConta.Mask = "0,0,0,00,0000"
        Me.MskPlanoNumConta.Name = "MskPlanoNumConta"
        Me.MskPlanoNumConta.Size = New System.Drawing.Size(114, 20)
        Me.MskPlanoNumConta.TabIndex = 32
        Me.MskPlanoNumConta.Tag = "-"
        '
        'TxtPlanoDescricao
        '
        Me.TxtPlanoDescricao.Location = New System.Drawing.Point(15, 129)
        Me.TxtPlanoDescricao.Name = "TxtPlanoDescricao"
        Me.TxtPlanoDescricao.Size = New System.Drawing.Size(114, 20)
        Me.TxtPlanoDescricao.TabIndex = 31
        Me.TxtPlanoDescricao.Tag = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Número da Conta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Descrição:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 45
        '
        'FormCadastroPlanoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 318)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtPlanoNumeroReduzido)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnLocalizar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.BtnGravar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.MskPlanoNumConta)
        Me.Controls.Add(Me.TxtPlanoDescricao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormCadastroPlanoContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Serviço"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtPlanoNumeroReduzido As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents BtnLocalizar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnExcluir As System.Windows.Forms.Button
    Friend WithEvents BtnAlterar As System.Windows.Forms.Button
    Friend WithEvents BtnGravar As System.Windows.Forms.Button
    Friend WithEvents BtnNovo As System.Windows.Forms.Button
    Friend WithEvents MskPlanoNumConta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtPlanoDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
