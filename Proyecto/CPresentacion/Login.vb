Imports System.Net.Security
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Private Sub BIngresar_Click() Handles BIngresar.Click
        Dim usuario As DEmpleado = New DEmpleado()
        Dim tipo As Integer
        tipo = usuario.getEmpleadoTipoPorNombreUsuario(TUsuario.Text)

        If String.IsNullOrWhiteSpace(TUsuario.Text) Or String.IsNullOrWhiteSpace(TContraseña.Text) Then
            MsgBox("Ingrese Usuario y contraseña", MsgBoxStyle.Critical, "Error")
        Else
            If usuario.getEmpleadoId(TUsuario.Text) Is Nothing Then
                MsgBox("El Usuario no se encuentra registrado", MsgBoxStyle.Critical, "Error")
            Else
                If Not (usuario.getEmpleadoContraseña(TUsuario.Text) = Encryption.HashString(TContraseña.Text)) Then
                    MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Error")
                Else
                    If usuario.getEmpleadoHabilitado(TUsuario.Text) = "SI" Then
                        Select Case tipo
                            Case "1"
                                Dim formulario As New MenuCajero()
                                formulario.Show()
                                formulario.prueba(TUsuario.Text)
                                TUsuario.Text = ""
                                TContraseña.Text = ""
                                Me.Hide()
                            Case "2"
                                Dim formulario As New MenuAdministrador()
                                formulario.Show()
                                formulario.prueba(TUsuario.Text)
                                TUsuario.Text = ""
                                TContraseña.Text = ""
                                Me.Hide()
                            Case "4"
                                Dim formulario As New MenuInventario()
                                formulario.Show()
                                formulario.prueba(TUsuario.Text)
                                TUsuario.Text = ""
                                TContraseña.Text = ""
                                Me.Hide()
                            Case Else
                                MsgBox("Error", MsgBoxStyle.Critical, "Error")
                        End Select
                    Else
                        MsgBox("Usuario no se encuentra habilitado", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, TUsuario.KeyDown, TContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            BIngresar_Click()
        End If
    End Sub
End Class
