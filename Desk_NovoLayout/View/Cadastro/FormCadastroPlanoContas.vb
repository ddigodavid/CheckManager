Public Class FormCadastroPlanoContas
    Dim objControle As New ClsControle
    Dim objPlanoContas As New ClsPlanoContas
    Dim codigoPlanoContas As Integer
    Dim novo As Boolean = False

    Private Sub BtnNovoPlanLan_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        objControle.limpar_tela(Me)

        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)

        txtPlanoNumeroReduzido.Focus()

        BtnExcluir.Enabled = False
        BtnAlterar.Enabled = False
        novo = True
    End Sub

    Sub AtribuirValoresPlanoContas()
        objPlanoContas.numeroReduzido = txtPlanoNumeroReduzido.Text
        objPlanoContas.descricao = TxtPlanoDescricao.Text
        objPlanoContas.numeroPlanoConta = MskPlanoNumConta.Text
    End Sub

    Private Sub BtnGravarPlanLan_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click
        If Not objControle.Testar_Vazio(Me) Then
            AtribuirValoresPlanoContas()

            If objPlanoContas.gravar(novo, cbxTipo.Text) Then
                codigoPlanoContas = objPlanoContas.codigo

                objControle.habilitar_tela(Me, False)
                objControle.habilitar_botoes(Me, True)
                BtnExcluir.Enabled = True
                BtnAlterar.Enabled = True
            End If
        Else
            MessageBox.Show("Por favor, preencha todos os campos!")
        End If

    End Sub

    Private Sub BtnAlterarPlanLan_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)

        novo = False
    End Sub

    Private Sub BtnExcluirPlanLan_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

    End Sub

    Private Sub BtnCancelarPlanLan_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)

        objControle.limpar_tela(Me)
    End Sub

    Private Sub BtnLocalizarPlanLan_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        Consulta.caller = "Plano de Contas"
        Consulta.ShowDialog()
    End Sub

    Private Sub BtnPlanLanSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FormCadastroPlanoContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Números reduzidos disponíveis: " & objPlanoContas.selectLastPlano + 1 & ", " & objPlanoContas.numeroReduzido + 2 & " e " & objPlanoContas.numeroReduzido + 3

        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)

    End Sub
End Class