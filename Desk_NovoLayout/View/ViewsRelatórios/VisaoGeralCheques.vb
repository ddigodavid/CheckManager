Public Class VisaoGeralCheques
    Dim sql As String

    Dim Check As New Check
    Dim objBanco As New DataBaseConnection
    Public caller

    Private Sub VisaoGeralRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT CLIENTES.CLIE_ID AS ID, CLIENTES.CLIE_NOME AS NOME FROM CLIENTES"
        dgvClientes.DataSource = objBanco.search(sql)
    End Sub

    Private Sub dgvCheckSheet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckSheet.CellDoubleClick
        If caller = FormCadastroCheques.caller Then

            FormCadastroCheques.CheckId = dgvCheckSheet.CurrentRow.Cells(0).Value
            FormCadastroCheques.CustomerId = dgvClientes.CurrentRow.Cells(0).Value

            FormCadastroCheques.lbCustomerName.Text = dgvClientes.CurrentRow.Cells(1).Value
            FormCadastroCheques.checkBank.Text = dgvCheckSheet.CurrentRow.Cells(1).Value
            FormCadastroCheques.checkNumber.Text = dgvCheckSheet.CurrentRow.Cells(2).Value
            FormCadastroCheques.checkVc.Text = dgvCheckSheet.CurrentRow.Cells(3).Value
            FormCadastroCheques.checkValue.Text = dgvCheckSheet.CurrentRow.Cells(5).Value
            FormCadastroCheques.checkDate.Text = dgvCheckSheet.CurrentRow.Cells(4).Value
            FormCadastroCheques.cbxCleared.Checked = dgvCheckSheet.CurrentRow.Cells(6).Value

            FormCadastroCheques.btnAlterar.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        dgvCheckSheet.DataSource = Check.search(dgvClientes.CurrentRow.Cells(0).Value)
        If dgvCheckSheet.Rows.Count > 0 Then
            txtTotal.Text = "R$ " & Check.searchTotal(dgvClientes.CurrentRow.Cells(0).Value)
        Else
            txtTotal.Text = "R$ 0,00"
        End If
    End Sub
End Class