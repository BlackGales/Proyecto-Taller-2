Public Class Bienvenida
    Public Sub prueba(ByVal nombre As String)
        Dim empleado As DEmpleado = New DEmpleado()
        Label1.Text = ("Bienvenido/a " + empleado.getEmpleadoNombrePorNombreUsuario(nombre))
    End Sub
End Class