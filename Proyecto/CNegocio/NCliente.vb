Public Class NCliente
    Function agregar_cliente(ByVal nombre As String, ByVal dni As Integer) As Boolean
        Dim oCliente = New Clientes

        With oCliente
            .nombre = nombre
            .dni = dni
        End With

        Dim objdCLiente = New DCliente

        If objdCLiente.Dguardar_cliente(oCliente) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
