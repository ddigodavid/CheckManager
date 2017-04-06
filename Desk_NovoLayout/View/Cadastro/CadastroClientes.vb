Public Class CadastroClientes
    Dim objControle As New ClsControle
    Dim objCliente As New ClsCliente
    Public codigoCliente As Integer
    Dim novo As Boolean = False

    Private Sub btnNovoCli_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.limpar_tela(Me)

        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        RbtFisico.Checked = True
        TxtClienteNome.Focus()
        btnAlterar.Enabled = False

        novo = True
    End Sub

    Private Sub btnCancelarCli_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)

        objControle.limpar_tela(Me)
    End Sub

    Private Sub btnGravarCli_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        If objControle.Testar_Vazio(Me) Then

        ElseIf MskClienteTel.Text = "(  )     -" And MskClienteCelular.Text = "(  )     -" Then
            MessageBox.Show("O telefone deve ser obrigatório")
        Else

            objCliente.codigo = Val(codigoCliente)
            objCliente.nome = TxtClienteNome.Text
            objCliente.telefone = MskClienteTel.Text
            objCliente.celular = MskClienteCelular.Text
            objCliente.email = TxtClienteEmail.Text
            objCliente.cpf_cnpj = MskCliente_CPF_CNPJ.Text
            objCliente.logradouro = TxtClienteLogradouro.Text
            objCliente.rg_inscricao = MskClienteRG.Text
            objCliente.estado = CboClienteEstado.Text
            objCliente.cidade = CboClienteCidade.Text
            objCliente.bairro = TxtClienteBairro.Text
            objCliente.cep = MskClienteCEP.Text
            objCliente.numero = MskClieteNumero.Text

            objCliente.gravar(novo, RbtJuridico.Checked)
            codigoCliente = objCliente.codigo

            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
            btnAlterar.Enabled = True
        End If
    End Sub

    Private Sub btnAlterarCli_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtClienteNome.Focus()
        novo = False
    End Sub

    Private Sub btnLocalizarCli_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Consulta.caller = "Cliente"
        Consulta.ShowDialog()
    End Sub

    Private Sub CadastroClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub RbtJuridico_CheckedChanged(sender As Object, e As EventArgs) Handles RbtJuridico.CheckedChanged
        lblCPF.Visible = False
        lblCNPJ.Visible = True
        MskCliente_CPF_CNPJ.Mask = "00,000,000/0000-00"
        MskClienteRG.Visible = False
        lblRG.Visible = False

    End Sub

    Private Sub RbtFisico_CheckedChanged(sender As Object, e As EventArgs) Handles RbtFisico.CheckedChanged
        lblCPF.Visible = True
        lblCNPJ.Visible = False
        MskCliente_CPF_CNPJ.Mask = "000,000,000-00"
        MskClienteRG.Visible = True
        lblRG.Visible = True

    End Sub

    Private Sub TxtClienteNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClienteNome.KeyPress
        e.Handled = objControle.TestarLetra(e.KeyChar)

    End Sub

    Private Sub MskClienteTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MskClienteTel.KeyPress, MskClienteCelular.KeyPress, MskCliente_CPF_CNPJ.KeyPress, MskClienteCEP.KeyPress, MskClienteRG.KeyPress, MskClieteNumero.KeyPress
        e.Handled = objControle.TestarNumero(e.KeyChar)

    End Sub

    Private Sub TxtClienteNome_TextChanged(sender As Object, e As EventArgs) Handles TxtClienteNome.TextChanged

    End Sub
End Class