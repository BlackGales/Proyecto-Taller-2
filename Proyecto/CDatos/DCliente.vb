Public Class DCliente
    Dim ctx As New BaseDeDatosProyectoEntities()

    Function Dguardar_cliente(ByVal OCLiente As Clientes) As Boolean
        Try
            ctx.Clientes.Add(OCLiente)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getClientesAll()
        Dim Cliente = (From c In ctx.Clientes
                       Select Nombre = c.nombre, Dni = c.dni, c.id_cliente).ToList()
        Return Cliente
    End Function

    Function editarCliente(ByVal id_cliente As Integer, ByVal Nombre2 As String, ByVal Dni2 As Integer)
        Dim Cliente = (From c In ctx.Clientes
                       Where c.id_cliente = id_cliente
                       Select c).FirstOrDefault
        Cliente.nombre = Nombre2
        Cliente.dni = Dni2

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getClientesFiltro(ByVal Nombre2 As String, ByVal Dni2 As Integer, ByVal filtroNombre As Boolean, ByVal filtroDni As Boolean)
        Dim ListaClientesAll = (From c In ctx.Clientes
                                Select Nombre = c.nombre, Dni = c.dni, c.id_cliente)

        If filtroNombre Then
            ListaClientesAll = (From c In ListaClientesAll
                                Where c.Nombre.Contains(Nombre2))
        End If
        If filtroDni Then
            ListaClientesAll = (From c In ListaClientesAll
                                Where c.Dni = Dni2)
        End If

        Return ListaClientesAll.ToList()
    End Function
End Class
