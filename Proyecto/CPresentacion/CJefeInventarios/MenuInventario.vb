Imports System.ComponentModel

Public Class MenuInventario
    Dim variable As String
    Dim objdusuario As DEmpleado = New DEmpleado()
    Dim nombreUsuario As String

    Public Sub prueba(ByVal nombre As String)
        variable = nombre
        nombreUsuario = objdusuario.getEmpleadoNombrePorNombreUsuario(variable)
    End Sub

    Private Sub MenuInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
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
        MyBase.Text = "Gestion de Productos"
        formulario.Show()
        formulario.Label1.Text = "Usuario: " + nombreUsuario
        LTitulo.Text = "Inicio"
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New ListarVentas()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Productos - Listar Ventas"
        formulario.Show()
        LTitulo.Text = "Listar Ventas"
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New AgregarProducto()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Productos - Gestionar Productos"
        formulario.Show()
        LTitulo.Text = "Gestionar Productos"
    End Sub

    Private Sub BInforme_Click(sender As Object, e As EventArgs) Handles BInforme.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New InformeEstadistico()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Gestion de Productos - Informe Estadistico"
        formulario.Show()
        LTitulo.Text = "Informe Estadistico"
    End Sub

    Private Sub BSesion_Click(sender As Object, e As EventArgs) Handles BSesion.Click
        Me.Close()
    End Sub

    Private Sub MenuInventario_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Esta seguro que cerrar sesión?", "Cerrar Sesion", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            e.Cancel = True
        Else
            Login.Show()
        End If
    End Sub
End Class