Public Class DataBaseConnection
    Dim conexao As String = "provider=microsoft.ace.oledb.12.0;data source=BDATCC.accdb"
    Public Connection As New OleDb.OleDbConnection(conexao)

    Private Sub openConnection()
        Try
            Connection.Open()
        Catch e As Exception
            MessageBox.Show("Erro: " & e.Message, "AVISO")
        End Try

    End Sub

    Private Sub closeConnection()

        If ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub

    Public Sub execute(sql As String)
        Dim Command As New OleDb.OleDbCommand(sql, Connection)

        openConnection()
        Command.ExecuteNonQuery()
        closeConnection()
    End Sub

    Public Function searchLast(sql As String) As Integer
        Dim DataAdapter As New OleDb.OleDbDataAdapter(sql, Connection)
        Dim DataSet As New DataSet

        DataAdapter.Fill(DataSet)

        Return DataSet.Tables(0).Rows(0).Item(0)
    End Function

    Public Function search(sql As String) As DataTable
        Dim DataAdapter As New OleDb.OleDbDataAdapter(sql, Connection)
        Dim DataSet As New DataSet

        DataAdapter.Fill(DataSet)

        Return DataSet.Tables(0)
    End Function
End Class
