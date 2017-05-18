Public Class FormCadastroCheques
    Dim Controle As New Controle
    Dim Check As New Check
    Dim novo As Boolean = False
    Public CustomerId As Integer = 0
    Public CheckId As Integer = 0
    Public caller As String = "CadastroCheques"

    Private Sub FormCadastroCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controle.habilitar_tela(Me, False)
        Controle.habilitar_botoes(Me, True)

        If CustomerId = 0 Then
            lbCustomerName.Text = "Nenhum cliente selecionado"
        End If
    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Controle.limpar_tela(Me)

        Controle.habilitar_tela(Me, True)
        Controle.habilitar_botoes(Me, False)
        checkBank.Focus()
        btnAlterar.Enabled = False

        novo = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        If (CustomerId = 0) Then
            MessageBox.Show("Um cliente precisa ser selecionado!")
        Else
            Check.id = Val(CheckId)
            Check.Bank = checkBank.Text
            Check.Number = checkNumber.Text
            Check.Vc = checkVc.Text
            Check.Value = checkValue.Text
            Check.ExpirationDate = checkDate.Value
            Check.customer = CustomerId
            Check.cleared = cbxCleared.Checked
            Check.gravar(novo)

            btnAlterar.Enabled = True

            Controle.habilitar_tela(Me, False)
            Controle.habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Controle.habilitar_tela(Me, True)
        Controle.habilitar_botoes(Me, False)
        checkBank.Focus()
        novo = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Controle.habilitar_tela(Me, False)
        Controle.habilitar_botoes(Me, True)

        Controle.limpar_tela(Me)
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        VisaoGeralCheques.caller = caller
        VisaoGeralCheques.ShowDialog()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        ConsultaCliente.caller = 1
        ConsultaCliente.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class