Public Class CustomerChecksChoice
    Public CustomerId As Integer
    Public CustomerName As String

    Private Sub btnNewCheck_Click(sender As Object, e As EventArgs) Handles btnNewCheck.Click
        FormCadastroCheques.CustomerId = CustomerId
        FormCadastroCheques.lbCustomerName.Text = CustomerName
        FormCadastroCheques.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnChecksCleared_Click(sender As Object, e As EventArgs) Handles btnChecksCleared.Click
        VisaoGeralCheques.ShowDialog()
        Me.Close()
    End Sub
End Class