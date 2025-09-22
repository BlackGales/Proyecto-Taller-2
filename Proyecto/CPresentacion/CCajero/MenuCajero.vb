Imports System.ComponentModel

Public Class MenuCajero
    Dim variable As String
    Dim objdusuario As DEmpleado = New DEmpleado()
    Dim nombreUsuario As String

    Public Sub prueba(ByVal nombre As String)
        variable = nombre
        nombreUsuario = objdusuario.getEmpleadoNombrePorNombreUsuario(variable)
    End Sub

    Private Sub MenuCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
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
        MyBase.Text = "Menu Ventas Cajero"
        formulario.Show()
        formulario.Label1.Text = "Usuario: " + nombreUsuario
        LTitulo.Text = "Inicio"
    End Sub

    Private Sub BVenta_Click(sender As Object, e As EventArgs) Handles BVenta.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New VentaProducto()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        formulario.setter(variable)
        MyBase.Text = "Menu Ventas Cajero - Realizar Venta"
        formulario.Show()
        LTitulo.Text = "Realizar Venta"
    End Sub

    Private Sub BListar_Click(sender As Object, e As EventArgs) Handles BListar.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New ListarVentas()
        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        formulario.setter(variable)
        MyBase.Text = "Menu Ventas Cajero - Listar Ventas"
        formulario.Show()
        LTitulo.Text = "Listar Ventas"
    End Sub

    Private Sub BCLienteAgregar_Click(sender As Object, e As EventArgs) Handles BCLienteAgregar.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New AgregarCliente()

        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Menu Ventas Cajero - Agregar Cliente"
        formulario.Show()
        LTitulo.Text = "Agregar Cliente"
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If PanelFormulario.Controls.Count > 0 Then
            PanelFormulario.Controls.RemoveAt(0)
        End If
        Dim formulario As New BuscarProducto()

        formulario.TopLevel = False
        formulario.TopMost = True
        PanelFormulario.Controls.Add(formulario)
        MyBase.Text = "Menu Ventas Cajero - Buscar Producto"
        formulario.Show()
        LTitulo.Text = "Buscar Producto"
    End Sub

    Private Sub BSesion_Click(sender As Object, e As EventArgs) Handles BSesion.Click
        Me.Close()
    End Sub

    Private Sub MenuCajero_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Esta seguro que cerrar sesión?", "Cerrar Sesion", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            e.Cancel = True
        Else
            Login.Show()
        End If
    End Sub
End Class