Public Class NEmpleado
    Function agregar_empleado(ByVal id_tipo As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal nombre_usuario As String, ByVal contraseña As String, ByVal habilitado As String) As Boolean
        Dim oEmpleado = New Empleados

        With oEmpleado
            .id_tipo = id_tipo
            .nombre = nombre
            .apellido = apellido
            .dni = dni
            .nombre_usuario = nombre_usuario
            .contraseña = Encryption.HashString(contraseña)
            .habilitado = habilitado
        End With

        Dim objdEmpleado = New DEmpleado

        If objdEmpleado.Dguardar_empleado(oEmpleado) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim user As DEmpleado = New DEmpleado

        grid.DataSource = user.getEmpleadoAll()
        grid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
End Class
