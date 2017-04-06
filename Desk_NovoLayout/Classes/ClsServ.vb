Public Class ClsServ

    Dim m_cod As Integer
    Dim m_nom As String
    Dim m_preco As Single
    Dim sql As String

    Dim objbanco As New ClsConexao


    Public Property codigo As Integer
        Get
            Return m_cod
        End Get
        Set(value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return m_nom
        End Get
        Set(value As String)
            m_nom = value
        End Set
    End Property

    Public Property preco As String
        Get
            Return m_preco
        End Get
        Set(value As String)
            m_preco = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "INSERT INTO SERVICOS " & _
                "(SERV_NOME" & _
                ",SERV_PRECO" & _
                ") VALUES  " & _
                "('" & m_nom & "'" & _
                ",'" & m_preco & "'" & _
                ")"

            objbanco.executarComando(sql)
            sql = "SELECT MAX(SERV_COD) FROM SERVICOS"
            m_cod = objbanco.BuscarUltimo(sql)

        Else
            sql = "UPDATE SERVICOS SET " & _
            " SERV_NOME='" & m_nom & "'" & _
            ",SERV_PRECO='" & m_preco & "'" & _
            " WHERE SERV_COD = " & m_cod
            objbanco.executarComando(sql)
        End If
    End Sub
    Public Function excluir(codigo As Integer) As Boolean
        Dim excluido As Boolean = False

        If MessageBox.Show("Deseja excluir", _
                           "Aviso", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DELETE FROM SERVICOS WHERE SERV_COD = " & m_cod
            objbanco.executarComando(sql)
            excluido = True
        Else
            excluido = False
        End If

        Return excluido
    End Function

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "SELECT * FROM SERVICOS WHERE SERV_COD = " & campo
        Else
            sql = "SELECT * FROM SERVICOS WHERE SERV_NOME='" & campo & "'"
        End If
        Dim objdt As New DataTable
        objdt = objbanco.ConsultarSQL(sql)
        If objdt.Rows.Count = 0 Then
            Return False
        Else
            m_cod = objdt.Rows(0).Item(0)
            m_nom = objdt.Rows(0).Item(1)
            m_preco = objdt.Rows(0).Item(2)
            Return True
        End If
    End Function

    'Public Function localizarRetornaTabela(campo As String) As DataTable
    '   If IsNumeric(campo) Then
    '      sql = "select * from servico where serv_cod=" & campo
    ' Else
    '    sql = "select * from servico where serv_nome like '" & campo & "%'"
    'End If
    'Return objbanco.ConsultarSQL(sql)

    'End Function
End Class
