<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroCheques
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.checkNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.checkValue = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.checkBank = New System.Windows.Forms.TextBox()
        Me.checkVc = New System.Windows.Forms.TextBox()
        Me.checkDate = New System.Windows.Forms.DateTimePicker()
        Me.lbCustomerName = New System.Windows.Forms.Label()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleName = "btnCancelar"
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(598, 151)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 35)
        Me.btnCancelar.TabIndex = 159
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
        Me.btnLocalizar.Location = New System.Drawing.Point(598, 192)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(83, 35)
        Me.btnLocalizar.TabIndex = 160
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
        Me.btnSair.Location = New System.Drawing.Point(598, 233)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 32)
        Me.btnSair.TabIndex = 161
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
        Me.btnAlterar.Location = New System.Drawing.Point(598, 110)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(83, 35)
        Me.btnAlterar.TabIndex = 158
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
        Me.btnGravar.Location = New System.Drawing.Point(598, 71)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(83, 33)
        Me.btnGravar.TabIndex = 157
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
        Me.btnNovo.Location = New System.Drawing.Point(598, 32)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(83, 33)
        Me.btnNovo.TabIndex = 156
        Me.btnNovo.Tag = "btnNovo"
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(84, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 18)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Numero:"
        '
        'checkNumber
        '
        Me.checkNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkNumber.Location = New System.Drawing.Point(153, 98)
        Me.checkNumber.Name = "checkNumber"
        Me.checkNumber.Size = New System.Drawing.Size(215, 24)
        Me.checkNumber.TabIndex = 2
        Me.checkNumber.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(98, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Banco:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(118, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 18)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "VC:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(103, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "Valor:"
        '
        'checkValue
        '
        Me.checkValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkValue.Location = New System.Drawing.Point(153, 158)
        Me.checkValue.Name = "checkValue"
        Me.checkValue.Size = New System.Drawing.Size(215, 24)
        Me.checkValue.TabIndex = 4
        Me.checkValue.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 18)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Data de Vencimento:"
        '
        'checkBank
        '
        Me.checkBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBank.Location = New System.Drawing.Point(153, 68)
        Me.checkBank.Name = "checkBank"
        Me.checkBank.Size = New System.Drawing.Size(285, 24)
        Me.checkBank.TabIndex = 1
        Me.checkBank.Tag = ""
        '
        'checkVc
        '
        Me.checkVc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkVc.Location = New System.Drawing.Point(153, 128)
        Me.checkVc.Name = "checkVc"
        Me.checkVc.Size = New System.Drawing.Size(215, 24)
        Me.checkVc.TabIndex = 3
        Me.checkVc.Tag = ""
        '
        'checkDate
        '
        Me.checkDate.Location = New System.Drawing.Point(153, 189)
        Me.checkDate.Name = "checkDate"
        Me.checkDate.Size = New System.Drawing.Size(236, 20)
        Me.checkDate.TabIndex = 5
        '
        'lbCustomerName
        '
        Me.lbCustomerName.AutoSize = True
        Me.lbCustomerName.Location = New System.Drawing.Point(153, 49)
        Me.lbCustomerName.Name = "lbCustomerName"
        Me.lbCustomerName.Size = New System.Drawing.Size(0, 13)
        Me.lbCustomerName.TabIndex = 164
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.AccessibleName = "btnSearchCustomer"
        Me.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnSearchCustomer.Location = New System.Drawing.Point(438, 29)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(128, 33)
        Me.btnSearchCustomer.TabIndex = 166
        Me.btnSearchCustomer.Tag = "btnSearchCustomer"
        Me.btnSearchCustomer.Text = "&Procurar Cliente"
        Me.btnSearchCustomer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Cliente Selecionado:"
        '
        'FormCadastroCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.lbCustomerName)
        Me.Controls.Add(Me.checkDate)
        Me.Controls.Add(Me.checkVc)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLocalizar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.checkNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.checkValue)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.checkBank)
        Me.MaximizeBox = False
        Me.Name = "FormCadastroCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCadastroCheques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents checkNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents checkValue As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents checkBank As System.Windows.Forms.TextBox
    Friend WithEvents checkVc As System.Windows.Forms.TextBox
    Friend WithEvents checkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbCustomerName As System.Windows.Forms.Label
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
