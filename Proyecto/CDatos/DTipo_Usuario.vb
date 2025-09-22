Public Class DTipo_Usuario
    Dim ctx As New BaseDeDatosProyectoEntities()

    Function Dguardar_tipo_usuario(ByVal OTipoUsuario As Tipo_Usuario) As Boolean
        Try
            ctx.Tipo_Usuario.Add(OTipoUsuario)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function getTipoUsuarioAll() As List(Of Tipo_Usuario)
        Dim listaTipo = (From c In ctx.Tipo_Usuario Select c).ToList

        Return listaTipo
    End Function
End Class
