Imports System.Collections.ObjectModel
Imports System.Data.Entity.Core
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Configuration
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.Sql
Imports System.ComponentModel

Public Class MenuAdministrador
    Dim variable As String
    Dim objdusuario As DEmpleado = New DEmpleado()
    Dim nombreUsuario As String

    Public Sub prueba(ByVal nombre As String)
        variable = nombre
        nombreUsuario = objdusuario.getEmpleadoNombrePorNombreUsuario(variable)
    End Sub

    Private Sub MenuInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim formulario As New Bienvenida()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        formulario.prueba(variable)
        formulario.Show()
        formulario.Label1.Text = "Usuario: " + nombreUsuario
        LTitulo.Text = "Inicio"
        LUsuarioMenu.Text = "Usuario: " + variable
        LUsuarioNombre.Text = "Nombre: " + nombreUsuario
        LUsuarioFecha.Text = "Fecha: " + Today().ToShortDateString
    End Sub

    Private Sub BHome_Click(sender As Object, e As EventArgs) Handles BHome.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New Bienvenida()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Usuarios"
        formulario.Show()
        formulario.Label1.Text = "Usuario: " + nombreUsuario
        LTitulo.Text = "Inicio"
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New BuscarUsuario()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Usuarios - Buscar Usuario"
        formulario.Show()
        LTitulo.Text = "Buscar Usuario"
    End Sub

    Private Sub BUsuarios_Click(sender As Object, e As EventArgs) Handles BUsuarios.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New GestionUsuario()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Usuarios - Gestionar Usuarios"
        formulario.Show()
        LTitulo.Text = "Gestionar Usuarios"
    End Sub

    Private Sub BBackup_Click(sender As Object, e As EventArgs) Handles BBackup.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New Backup()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Usuarios - Backup"
        formulario.Show()
        LTitulo.Text = "Backup"
    End Sub

    Private Sub BSesion_Click(sender As Object, e As EventArgs) Handles BSesion.Click
        Me.Close()
    End Sub

    Private Sub MenuAdministrador_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Esta seguro que cerrar sesión?", "Cerrar Sesion", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            e.Cancel = True
        Else
            Login.Show()
        End If
    End Sub
End Class