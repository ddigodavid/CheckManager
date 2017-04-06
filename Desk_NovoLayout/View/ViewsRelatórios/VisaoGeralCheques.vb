Public Class VisaoGeralCheques
    Dim sql As String

    Dim Check As New Check
    Dim objBanco As New DataBaseConnection

    Private Sub VisaoGeralRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT CLIENTES.CLIE_ID, CLIENTES.CLIE_NOME FROM CLIENTES"
        dgvClientes.DataSource = objBanco.search(sql)
    End Sub

    'Private Sub btnGerarRecibo_Click(sender As Object, e As EventArgs) Handles btnGerarRecibo.Click
    'Dim rpt As New RptRecibosGeral
    '    rpt.SetDataSource(dgvCheckSheet.DataSource)
    '    ImpElaborada.CrystalReportViewer1.ReportSource = rpt
    '    rpt.SummaryInfo.ReportTitle = "COASFI LTDA"
    '    rpt.SummaryInfo.ReportComments = "Recibo Nº " & dgvCheckSheet.Rows(0).Cells(5).Value
    '    ImpElaborada.ShowDialog()
    'End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        dgvCheckSheet.DataSource = Check.search(dgvClientes.CurrentRow.Cells(0).Value)
        If dgvCheckSheet.Rows.Count > 0 Then
            txtTotal.Text = "R$ " & Check.searchTotal(dgvClientes.CurrentRow.Cells(0).Value)
        Else
            txtTotal.Text = "R$ 0,00"
        End If
    End Sub
End Class