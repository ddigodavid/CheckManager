Public Class MenuConsultas

    Private Sub btnConsultaClientes_Click(sender As Object, e As EventArgs) Handles btnConsultaClientes.Click
        ConsultaCliente.ShowDialog()
    End Sub

    Private Sub btnChecksCleared_Click(sender As Object, e As EventArgs) Handles btnChecksCleared.Click
        VisaoGeralCheques.ShowDialog()
    End Sub
End Class