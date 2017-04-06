Public Class Cliente
    Dim banco As New DataBaseConnection
    Dim client_id As Integer
    Dim client_name As String
    Dim client_telephone As String
    Dim client_celphone As String
    Dim client_cpf_cnpj As String
    Dim client_rg_insc As String
    Dim client_email As String
    Dim client_logradouro As String
    Dim client_number As Integer
    Dim client_city As String
    Dim client_state As String
    Dim client_district As String
    Dim client_zip_code As String

    Dim sql As String

    Dim objBanco As New DataBaseConnection

    Public Property codigo As Integer
        Get
            Return client_id
        End Get
        Set(value As Integer)
            client_id = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return client_name
        End Get
        Set(value As String)
            client_name = value
        End Set
    End Property

    Public Property telefone As String
        Get
            Return client_telephone
        End Get
        Set(value As String)
            client_telephone = value
        End Set
    End Property

    Public Property celular As String
        Get
            Return client_celphone
        End Get
        Set(value As String)
            client_celphone = value
        End Set
    End Property

    Public Property cpf_cnpj As String
        Get
            Return client_cpf_cnpj
        End Get
        Set(value As String)
            client_cpf_cnpj = value
        End Set
    End Property

    Public Property rg_inscricao As String
        Get
            Return client_rg_insc
        End Get
        Set(value As String)
            client_rg_insc = value
        End Set
    End Property

    Public Property email As String
        Get
            Return client_email
        End Get
        Set(value As String)
            client_email = value
        End Set
    End Property

    Public Property logradouro As String
        Get
            Return client_logradouro
        End Get
        Set(value As String)
            client_logradouro = value
        End Set
    End Property

    Public Property numero As Integer
        Get
            Return client_number
        End Get
        Set(value As Integer)
            client_number = value
        End Set
    End Property

    Public Property cidade As String
        Get
            Return client_city
        End Get
        Set(value As String)
            client_city = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return client_state
        End Get
        Set(value As String)
            client_state = value
        End Set
    End Property

    Public Property bairro As String
        Get
            Return client_district
        End Get
        Set(value As String)
            client_district = value
        End Set
    End Property

    Public Property cep As String
        Get
            Return client_zip_code
        End Get
        Set(value As String)
            client_zip_code = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean, tipo As Boolean)
        If novo Then
            sql = "INSERT INTO CLIENTES " & _
                    "(CLIE_Nome" & _
                    ",CLIE_CNPJ_CPF" & _
                    ",CLIE_INSC_RG" & _
                    ",CLIE_EMAIL" & _
                    ",CLIE_TIPO_JD" & _
                    ",CLIE_Tel" & _
                    ",CLIE_Cel" & _
                    ",CLIE_LOGRADOURO" & _
                    ",CLIE_Num" & _
                    ",CLIE_Bairro" & _
                    ",CLIE_CEP" & _
                    ",CLIE_MUNICIPIO" & _
                    ",CLIE_ESTADO)" & _
                    "VALUES" & _
                    "('" & client_name & "'" & _
                    ",'" & client_cpf_cnpj & "'" & _
                    ",'" & client_rg_insc & "'" & _
                    ",'" & client_email & "'" & _
                    "," & tipo & _
                    ",'" & client_telephone & "'" & _
                    ",'" & client_celphone & "'" & _
                    ",'" & client_logradouro & "'" & _
                    "," & client_number & _
                    ",'" & client_district & "'" & _
                    ",'" & client_zip_code & "'" & _
                    ",'" & client_city & "'" & _
                    ",'" & client_state & "')"

            objBanco.execute(sql)

            sql = "SELECT MAX(CLIE_ID) FROM CLIENTES"
            client_id = objBanco.searchLast(sql)

        Else
            sql = "UPDATE CLIENTES SET " & _
                    " CLIE_Nome='" & client_name & "'" & _
                    ",CLIE_CNPJ_CPF='" & client_cpf_cnpj & "'" & _
                    ",CLIE_INSC_RG='" & client_rg_insc & "'" & _
                    ",CLIE_EMAIL='" & client_email & "'" & _
                    ",CLIE_TIPO_JD=" & tipo & _
                    ",CLIE_Tel='" & client_telephone & "'" & _
                    ",CLIE_Cel='" & client_celphone & "'" & _
                    ",CLIE_LOGRADOURO='" & client_logradouro & "'" & _
                    ",CLIE_Num=" & client_number & _
                    ",CLIE_Bairro='" & client_district & "'" & _
                    ",CLIE_CEP='" & client_zip_code & "'" & _
                    ",CLIE_MUNICIPIO='" & client_city & "'" & _
                    ",CLIE_ESTADO='" & client_state & "'" & _
                    " WHERE CLIE_ID=" & client_id

            objBanco.execute(sql)
            MessageBox.Show("Alterado com sucesso!")
        End If

    End Sub

    Public Function excluir(cod As Integer) As Boolean
        Dim result As Boolean
        If (MessageBox.Show("Tem certeza que deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            sql = "DELETE FROM CLIENTES WHERE CLIE_ID=" & cod

            objBanco.execute(sql)
            result = True
        Else
            result = False
        End If

        Return result
    End Function

    Public Function selectCliente(cod As Integer) As Boolean
        sql = "SELECT CLIE_Nome FROM CLIENTES WHERE CLIE_ID = " & cod

        Dim nome = objBanco.search(sql)

        If nome.Rows().Count() = 1 Then
            client_name = nome.Rows(0).Item(0)
            Return True
        Else
            MessageBox.Show("Cliente não existe", "Aviso")
            Return False

        End If
    End Function
End Class
