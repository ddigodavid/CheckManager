Public Class Check
    Dim check_id As Integer
    Dim check_bank As String
    Dim check_number As Integer
    Dim check_vc As Integer
    Dim check_value As Integer
    Dim check_expirationDate As Date
    Dim check_customer As Integer

    Dim DataBaseConnection As New DataBaseConnection

    Public Property Id As Integer
        Get
            Return check_id
        End Get
        Set(value As Integer)
            check_id = value
        End Set
    End Property

    Public Property Bank As String
        Get
            Return check_bank
        End Get
        Set(value As String)
            check_bank = value
        End Set
    End Property

    Public Property Number As Integer
        Get
            Return check_number
        End Get
        Set(value As Integer)
            check_number = value
        End Set
    End Property

    Public Property Vc As Integer
        Get
            Return check_vc
        End Get
        Set(value As Integer)
            check_vc = value
        End Set
    End Property

    Public Property Value As Integer
        Get
            Return check_value
        End Get
        Set(valueToSet As Integer)
            check_value = valueToSet
        End Set
    End Property

    Public Property ExpirationDate As Date
        Get
            Return check_expirationDate
        End Get
        Set(value As Date)
            check_expirationDate = value
        End Set
    End Property

    Public Property customer As Integer
        Get
            Return check_customer
        End Get
        Set(value As Integer)
            check_customer = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        Dim query As String

        If novo Then
            query = "INSERT INTO CHECKS " & _
                    "(BANK" & _
                    ",CHECK_NUMBER" & _
                    ",VC" & _
                    ",CHECK_VALUE" & _
                    ",EXPIRATION_DATE" & _
                    ",CUSTOMER_ID)" & _
                    " VALUES " & _
                    "('" & check_bank & "'" & _
                    "," & check_number & _
                    "," & check_vc & _
                    "," & check_value & _
                    ",'" & check_expirationDate & "'" & _
                    "," & check_customer & ")"
            MessageBox.Show(query)
            DataBaseConnection.execute(query)

            query = "SELECT MAX(CHECK_ID) FROM CHECKS"
            check_id = DataBaseConnection.searchLast(query)

        Else
            query = "UPDATE CHECKS SET " & _
                    " BANK='" & check_bank & "'" & _
                    ",NUMBER='" & check_number & "'" & _
                    ",VC='" & check_vc & "'" & _
                    ",VALUE='" & check_value & "'" & _
                    ",EXPIRATION_DATE=" & check_expirationDate & _
                    ",CUSTOMER_ID=" & check_customer & _
                    " WHERE ID=" & check_id

            DataBaseConnection.execute(query)
            MessageBox.Show("Alterado com sucesso!")
        End If
    End Sub
    Public Function search(ByVal customer_id)
        Dim sql = "SELECT * FROM CHECKS WHERE CUSTOMER_ID = " & customer_id
        Return DataBaseConnection.search(sql)
    End Function

    Public Function searchTotal(ByVal customer_id)
        Return "2000.00"
    End Function
End Class
