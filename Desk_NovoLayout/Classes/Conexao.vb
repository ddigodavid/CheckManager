Public Class Conexao

    Dim conexao As String = "provider=microsoft.ace.oledb.12.0;data source=BDATCC.accdb"
    Dim objcon As New OleDb.OleDbConnection(conexao)

    Public Sub abrir_banco()
        Try
            objcon.Open()
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message, "AVISO")
        End Try

    End Sub

    Public Sub fechar_banco()
        If ConnectionState.Open Then
            objcon.Close()
        End If

    End Sub

    Public Sub executarComando(sql As String)
        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        Call abrir_banco()
        objcmd.ExecuteNonQuery()
        Call fechar_banco()
    End Sub

    Public Function BuscarUltimo(sql As String) As Integer
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon) 'OleDbDataAdapter = se adapta aos dados, se conecta ao banco
        Dim objds As New DataSet 'DataSet = onde fica os dados
        objda.Fill(objds) 'fill = preencher
        Return objds.Tables(0).Rows(0).Item(0) 'o item é a coluna
    End Function

    Public Function ConsultarSQL(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
