Imports System.Data.Entity.Core.Common.EntitySql

Public Class DEmpleado
    Dim ctx As New BaseDeDatosProyectoEntities()
    Function Dguardar_empleado(ByVal OEmpleado As Empleados) As Boolean
        Try
            ctx.Empleados.Add(OEmpleado)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function editEmpleado(ByVal id_empleado As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal usuario As String, ByVal contraseña As String, ByVal id_tipo As Integer, ByVal habilitado As String)
        Dim query = (From c In ctx.Empleados
                     Where c.id_empleado = id_empleado
                     Select c).FirstOrDefault()

        query.nombre = nombre
        query.apellido = apellido
        query.id_tipo = id_tipo
        query.dni = dni
        query.nombre_usuario = usuario
        query.contraseña = Encryption.HashString(contraseña)
        query.habilitado = habilitado

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Function editEmpleadoSinContraseña(ByVal id_empleado As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal usuario As String, ByVal id_tipo As Integer, ByVal habilitado As String)
        Dim query = (From c In ctx.Empleados
                     Where c.id_empleado = id_empleado
                     Select c).FirstOrDefault()

        query.nombre = nombre
        query.apellido = apellido
        query.id_tipo = id_tipo
        query.dni = dni
        query.nombre_usuario = usuario
        query.habilitado = habilitado

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Function getEmpleadoTipoPorNombreUsuario(ByVal nombreusuario As String)
        Dim tipo = (From c In ctx.Empleados
                    Where c.nombre_usuario = nombreusuario
                    Select c.id_tipo).FirstOrDefault

        Return CInt(tipo)
    End Function


    Function getEmpleadoContraseña(ByVal nombreusuario As String)
        Dim contraseña2 = (From c In ctx.Empleados
                           Where c.nombre_usuario = nombreusuario
                           Select c.contraseña).FirstOrDefault()
        Return contraseña2
    End Function

    Function getEmpleadoNombrePorNombreUsuario(ByVal nombreusuario As String)
        Dim NombreEmpleado = (From c In ctx.Empleados
                              Where c.nombre_usuario = nombreusuario
                              Select c.nombre + " " + c.apellido).FirstOrDefault
        Return NombreEmpleado
    End Function


    Function getEmpleadoId(ByVal nombreusuario As String)
        Dim NombreEmpleado = (From c In ctx.Empleados
                              Where c.nombre_usuario = nombreusuario
                              Select c.id_empleado).FirstOrDefault
        Return NombreEmpleado
    End Function

    Function getEmpleadoHabilitado(ByVal nombreusuario As String)
        Dim NombreEmpleado = (From c In ctx.Empleados
                              Where c.nombre_usuario = nombreusuario
                              Select c.habilitado).FirstOrDefault
        Return NombreEmpleado
    End Function

    Function getEmpleadoAll()
        Dim listaEmpleado = (From c In ctx.Empleados
                             Select Tipo_de_Usuario = c.Tipo_Usuario.descripcion_tipo, DNI = c.dni, Nombre_de_Empleado = c.nombre, Apellido_de_Empleado = c.apellido, Nombre_de_Usuario = c.nombre_usuario, Habilitado = c.habilitado, c.id_empleado).ToList

        Return listaEmpleado
    End Function

    Function getEmpleadosFiltro(ByVal Nombre2 As String, ByVal Apellido2 As String, ByVal Usuario As String, ByVal Tipo As String, ByVal Habilitado2 As Boolean, ByVal filtroNombre As Boolean, ByVal filtroApellido As Boolean, ByVal filtroUsuario As Boolean, ByVal filtroTipo As Boolean)
        Dim listaEmpleadosAll = (From c In ctx.Empleados
                                 Select Tipo_de_Usuario = c.Tipo_Usuario.descripcion_tipo, DNI = c.dni, Nombre_de_Empleado = c.nombre, Apellido_de_Empleado = c.apellido, Nombre_de_Usuario = c.nombre_usuario, Habilitado = c.habilitado, c.id_empleado)

        If Habilitado2 Then
            listaEmpleadosAll = (From c In listaEmpleadosAll
                                 Where c.Habilitado = "SI")
        Else
            listaEmpleadosAll = (From c In listaEmpleadosAll
                                 Where c.Habilitado = "NO")
        End If
        If filtroNombre Then
            listaEmpleadosAll = (From c In listaEmpleadosAll
                                 Where c.Nombre_de_Empleado.Contains(Nombre2))
        End If
        If filtroApellido Then
            listaEmpleadosAll = (From c In listaEmpleadosAll
                                 Where c.Apellido_de_Empleado.Contains(Apellido2))
        End If
        If filtroUsuario Then
            listaEmpleadosAll = (From c In listaEmpleadosAll
                                 Where c.Nombre_de_Usuario.Contains(Usuario))
        End If
        If filtroTipo Then
            listaEmpleadosAll = (From c In listaEmpleadosAll
                                 Where c.Tipo_de_Usuario.Contains(Tipo))
        End If

        Return listaEmpleadosAll.ToList()
    End Function
End Class
