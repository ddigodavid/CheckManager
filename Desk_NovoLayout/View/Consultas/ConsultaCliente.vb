Public Class ConsultaCliente
    Dim objBanco As New DataBaseConnection
    Dim objControle As New Controle
    Public caller As Integer

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If rbtCodigo.Checked Then
            e.Handled = objControle.TestarNumero(e.KeyChar)
        Else
            e.Handled = objControle.TestarLetra(e.KeyChar)
        End If
    End Sub

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String = "SELECT * FROM CLIENTES"

        If txtSearch.Text <> "" Then
            If rbtCodigo.Checked And Not objControle.TestarNumero(txtSearch.Text) Then
                sql += " WHERE CLIE_ID = " & txtSearch.Text
            ElseIf rbtNome.Checked Then
                sql += " WHERE CLIE_NOME LIKE '%" & txtSearch.Text & "%'"
            End If
        End If



        dgdResults.DataSource = objBanco.search(sql)
    End Sub

    Private Sub FrmConClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtCodigo.Checked = True
        txtSearch.Focus()

        txtCampo_TextChanged(e, e)
    End Sub

    Private Sub dgdResults_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdResults.CellContentDoubleClick
        If caller = 1 Then
            FormCadastroCheques.CustomerId = dgdResults.CurrentRow.Cells(0).Value
            FormCadastroCheques.lbCustomerName.Text = dgdResults.CurrentRow.Cells(1).Value
        End If

        Me.Close()
    End Sub

    Private Sub ConsultaCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        rbtCodigo.Checked = True
        txtSearch.Focus()

        objBanco.search("SELECT * FROM CLIENTES")
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim rptCli As New rptClientes1
        rptCli.SetDataSource(dgdResults.DataSource)
        ImpElaborada.CrystalReportViewer1.ReportSource = rptCli
        rptCli.SummaryInfo.ReportTitle = "COASFI LTDA"
        rptCli.SummaryInfo.ReportComments = "Clientes"
        ImpElaborada.ShowDialog()
    End Sub
End Class