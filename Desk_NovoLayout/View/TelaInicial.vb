Public Class TelaInicial

    Private Sub tsbCadastroClientes_Click_1(sender As Object, e As EventArgs) Handles tsbCadastroClientes.Click
        FormCadastroClientes.ShowDialog()
    End Sub

    Private Sub tsbCadastroServiços_Click(sender As Object, e As EventArgs) Handles tsbCadastroCheques.Click
        FormCadastroCheques.ShowDialog()
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub tsbConsultas_Click(sender As Object, e As EventArgs) Handles tsbConsultas.Click
        MenuConsultas.ShowDialog()
    End Sub
End Class
