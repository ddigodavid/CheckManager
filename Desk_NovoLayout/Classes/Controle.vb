Public Class Controle

    Public Sub alternarOpcoesConsulta(groupName As String, content As Object)
        For Each controle In content.controls
            If TypeOf controle Is GroupBox Then
                If controle.Tag <> "x" Then
                    If controle.Name <> groupName Then
                        controle.Enabled = False
                    Else
                        controle.Enabled = True
                    End If
                End If
            End If

        Next
    End Sub

    Public Sub habilitarBotoesGravar(tela As Object)
        For Each controle In tela.controls
            If TypeOf controle Is Button Then
                If controle.Tag.ToUpper = "BTNALTERAR" Or controle.tag.ToUpper = "BTNEXCLUIR" Or controle.tag.ToUpper = "BTNLOCALIZAR" Then
                    controle.Enabled = True
                End If
            End If
        Next
    End Sub

    Public Sub alternarTelas(groupName As String, content As Object)
        For Each controle In content.controls
            If TypeOf controle Is GroupBox Then
                If controle.Name <> groupName Then
                    If controle.name <> "gbxMenu" Then
                        controle.Visible = False
                    End If
                Else
                    controle.Visible = True
                End If
            End If
        Next
    End Sub

    Public Sub limpar_tela(tela As Object)
        For Each controle In tela.controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Or TypeOf controle Is ComboBox Then
                controle.Text = ""
            ElseIf TypeOf controle Is RadioButton Then
                controle.Checked = False
            End If
        Next
    End Sub

    Public Sub habilitar_tela(tela As Object, tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.controls
            If (TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Or TypeOf controle Is ComboBox) And controle.Name.ToUpper <> "TXTCODIGO" Then
                controle.Enabled = tipo
            ElseIf TypeOf controle Is RadioButton Then
                controle.Enabled = tipo
            ElseIf TypeOf controle Is ComboBox Then
                controle.Enabled = tipo
            ElseIf TypeOf controle Is DateTimePicker Then
                controle.Enabled = tipo
            End If
        Next
    End Sub

    Public Sub habilitar_botoes(tela As Object, tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.controls
            If TypeOf controle Is Button Then
                If controle.Name.ToUpper = "BTNGRAVAR" Or controle.Name.ToUpper = "BTNEXCLUIR" Or controle.Name.ToUpper = "BTNALTERAR" Or controle.Name.ToUpper = "BTNLANCAR" Or controle.Name.ToUpper = "BTNCHEQUES" Then
                    controle.Enabled = Not tipo
                ElseIf controle.Name.ToUpper = "BTNSAIR" Then
                    controle.Enabled = True
                ElseIf controle.Name.ToUpper = "BTNCANCELAR" Then
                    controle.Enabled = Not tipo
                Else
                    controle.Enabled = tipo
                End If
            End If
        Next
    End Sub

    Public Function Testar_Vazio(tela As Object) As Boolean
        Dim result As Boolean
        Dim campos As String = ""
        Dim controle As Control
        For Each controle In tela.controls
            If TypeOf controle Is TextBox Or TypeOf controle Is ComboBox Then
                If controle.Text = "" And controle.Tag <> "x" Then
                    result = True
                Else
                    result = False
                End If
            End If
        Next

        Return result
    End Function

    Public Function TestarNumero(tecla As String) As Boolean
        Dim result As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Then
            result = False  'false destrava o teclado
        ElseIf Asc(tecla) < 48 Or Asc(tecla) > 57 Then
            result = True  'true vai travar o teclado
        End If
        Return result
    End Function
    Public Function TestarNumeroeVirgula(tecla As String) As Boolean
        Dim result As Boolean

        If Asc(tecla) = 8 Or Asc(tecla) = 13 Or Asc(tecla) = Asc(",") Then
            result = False  'false destrava o teclado
        ElseIf Asc(tecla) < 48 Or Asc(tecla) > 57 Then
            result = True  'true vai travar o teclado
        End If

        Return result
    End Function

    Public Function TestarLetra(tecla As String) As Boolean
        Dim result As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Or Asc(tecla) = 32 Then
            result = False  'false destrava o teclado   
        ElseIf Asc(tecla) < 65 Or Asc(tecla) > 122 Then
            result = True   'true vai travar o teclado 
        End If

        Return result
    End Function

End Class

