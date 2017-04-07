Public Class Consulta
    Dim objBanco As New DataBaseConnection
    Dim objControle As New Controle
    Dim destinoConsulta As String
    Public caller As String
    Dim sql As String

    Private Sub mskBuscar_EnabledChanged(sender As Object, e As EventArgs) Handles mskBuscar.EnabledChanged
        If mskBuscar.Enabled Then
            mskBuscar_TextChanged(e, e)
        End If
    End Sub

    Private Sub mskBuscar_TextChanged(sender As Object, e As EventArgs) Handles mskBuscar.TextChanged
        If gbxOpcoesClientes.Enabled Then
            If rbtClienteNome.Checked Then
                sql = "SELECT CLIE_ID AS [CÓDIGO]" & _
                        ",CLIE_Nome AS NOME" & _
                        ",CLIE_CNPJ_CPF AS [CPF/CNPJ]" & _
                        ",CLIE_INSC_RG AS [INSC/RG]" & _
                        ",CLIE_EMAIL AS [E-MAIL]" & _
                        ",CLIE_TIPO_JD AS [JURÍDICO]" & _
                        ",CLIE_Tel AS TELEFONE" & _
                        ",CLIE_Cel AS CELULAR" & _
                        ",CLIE_LOGRADOURO AS LOGRADOURO" & _
                        ",CLIE_Num AS [NÚMERO]" & _
                        ",CLIE_Bairro AS BAIRRO" & _
                        ",CLIE_CEP AS CEP" & _
                        ",CLIE_MUNICIPIO AS [MUNICÍPIO]" & _
                        ",CLIE_ESTADO AS ESTADO" & _
                        " FROM CLIENTES WHERE UCASE(CLIE_NOME) LIKE UCASE('%" & mskBuscar.Text & "%')"

            ElseIf rbtClienteCPF.Checked Then
                sql = "SELECT CLIE_ID AS [CÓDIGO]" & _
                        ",CLIE_Nome AS NOME" & _
                        ",CLIE_CNPJ_CPF AS [CPF/CNPJ]" & _
                        ",CLIE_INSC_RG AS [INSC/RG]" & _
                        ",CLIE_EMAIL AS [E-MAIL]" & _
                        ",CLIE_TIPO_JD AS [JURÍDICO]" & _
                        ",CLIE_Tel AS TELEFONE" & _
                        ",CLIE_Cel AS CELULAR" & _
                        ",CLIE_LOGRADOURO AS LOGRADOURO" & _
                        ",CLIE_Num AS [NÚMERO]" & _
                        ",CLIE_Bairro AS BAIRRO" & _
                        ",CLIE_CEP AS CEP" & _
                        ",CLIE_MUNICIPIO AS [MUNICÍPIO]" & _
                        ",CLIE_ESTADO AS ESTADO" & _
                        " FROM CLIENTES WHERE CLIE_CNPJ_CPF LIKE '%" & mskBuscar.Text & "%'"
            End If
        End If

        DgdGrade.DataSource = objBanco.search(sql)
    End Sub

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If caller = "Cliente" Then
            rbtClientes.Checked = True
            rbtClienteNome.Checked = True
        End If
    End Sub

    Private Sub limpar_tela()
        objControle.limpar_tela(Me.gbxOpcoesClientes)
    End Sub

    Private Sub rbtClientes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtClientes.CheckedChanged
        destinoConsulta = "Clientes"
        limpar_tela()
        objControle.alternarOpcoesConsulta(gbxOpcoesClientes.Name, Me)
        mskBuscar.Text = ""
        mskBuscar.Enabled = False

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If caller = "Cliente" Then
            If DgdGrade.CurrentRow.Cells(5).Value Then
                FormCadastroClientes.RbtJuridico.Checked = True
            Else
                FormCadastroClientes.RbtFisico.Checked = True
            End If
            FormCadastroClientes.TxtClienteNome.Text = DgdGrade.CurrentRow.Cells(1).Value
            FormCadastroClientes.MskClienteTel.Text = DgdGrade.CurrentRow.Cells(6).Value
            FormCadastroClientes.MskClienteCelular.Text = DgdGrade.CurrentRow.Cells(7).Value
            FormCadastroClientes.MskCliente_CPF_CNPJ.Text = DgdGrade.CurrentRow.Cells(2).Value
            FormCadastroClientes.MskClienteRG.Text = DgdGrade.CurrentRow.Cells(3).Value
            FormCadastroClientes.TxtClienteEmail.Text = IIf(IsDBNull(DgdGrade.CurrentRow.Cells(4).Value), "", DgdGrade.CurrentRow.Cells(4).Value)
            FormCadastroClientes.MskClienteCEP.Text = DgdGrade.CurrentRow.Cells(11).Value
            FormCadastroClientes.TxtClienteLogradouro.Text = DgdGrade.CurrentRow.Cells(8).Value
            FormCadastroClientes.TxtClienteBairro.Text = DgdGrade.CurrentRow.Cells(10).Value
            FormCadastroClientes.MskClieteNumero.Text = DgdGrade.CurrentRow.Cells(9).Value

            FormCadastroClientes.btnAlterar.Enabled = True
            FormCadastroClientes.btnCheques.Enabled = True

            FormCadastroClientes.codigoCliente = DgdGrade.CurrentRow.Cells(0).Value
        End If

        caller = ""
        limpar_tela()
        Me.Close()
    End Sub

    Private Sub rbtClienteNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbtClienteNome.CheckedChanged
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub rbtClienteCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbtClienteCPF.CheckedChanged
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub rbtPlanoContasDescricao_CheckedChanged(sender As Object, e As EventArgs)
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub rbtPlanoContasNumeroReduzido_CheckedChanged(sender As Object, e As EventArgs)
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub rbtPlanoContasNumeroConta_CheckedChanged(sender As Object, e As EventArgs)
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub
    Private Sub rbtOpcLancCodCli_CheckedChanged(sender As Object, e As EventArgs)
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub rbtOpcLancDebito_CheckedChanged(sender As Object, e As EventArgs)
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub rbtOpcLancCredito_CheckedChanged(sender As Object, e As EventArgs)
        mskBuscar.Enabled = True
        mskBuscar.Text = ""
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click

        If rbtClientes.Checked = True Then

            Dim rpt As New rptClientes1
            rpt.SetDataSource(DgdGrade.DataSource)
            ImpElaborada.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportTitle = "DeskSystems"
            rpt.SummaryInfo.ReportComments = "Relatório de clientes"
            ImpElaborada.ShowDialog()
        ElseIf rbtLancamentos.Checked = True Then
            Dim rpt As New rptLancamentos
            rpt.SetDataSource(DgdGrade.DataSource)
            ImpElaborada.CrystalReportViewer1.ReportSource = rpt
            rpt.SummaryInfo.ReportTitle = "DeskSystems"
            rpt.SummaryInfo.ReportTitle = "Relatório de lançamentos"
            ImpElaborada.ShowDialog()
        End If

        ' ImpElaborada.ShowDialog()

    End Sub
End Class
