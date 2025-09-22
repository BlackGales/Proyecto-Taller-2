Public Class NTipo_Usuario
    Function agregar_tipo_usuario(ByVal descripcion_tipo As String) As Boolean
        Dim oTipo_Usuario = New Tipo_Usuario

        With oTipo_Usuario
            .descripcion_tipo = descripcion_tipo
        End With

        Dim objdTipoUsuario = New DTipo_Usuario

        If objdTipoUsuario.Dguardar_tipo_usuario(oTipo_Usuario) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarCombobox(ByVal combobox As ComboBox)
        Dim user As DTipo_Usuario = New DTipo_Usuario

        combobox.DataSource = user.getTipoUsuarioAll()
    End Sub
End Class
