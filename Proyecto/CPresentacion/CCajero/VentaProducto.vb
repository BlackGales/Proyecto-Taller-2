Imports System.Net.Sockets
Imports System.Windows
Imports System.Linq
Imports System.Windows.Forms.DataFormats
Imports System.Runtime.InteropServices
Imports System.DateTime.Today
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Net.Security

Public Class VentaProducto
    Dim idvendedor As String

    Public Sub setter(ByVal valor As String)
        idvendedor = valor
    End Sub

    Private Sub BusquedaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim empleado As DEmpleado = New DEmpleado()
        Dim factura As DFactura = New DFactura()
        TNroFactura.Text = factura.getUltimaFactura() + 1
        TNombreVendedor.Text = empleado.getEmpleadoNombrePorNombreUsuario(idvendedor)
        TFecha.Text = Today().ToShortDateString
        TCliente.Enabled = False
        BComprar.Enabled = False
        BProductoAñadir.Enabled = False
        BProductoEliminar.Enabled = False
        BEditarProducto.Enabled = False
        BDeseleccionar.Enabled = False
        LENumeros.Visible = False
        BComprar.Enabled = True
    End Sub

    Private Sub BProductoBuscar_Click(sender As Object, e As EventArgs) Handles BProductoBuscar.Click
        If Not (Application.OpenForms().OfType(Of BuscarProductoCajero).Any) Then
            Dim formulario As New BuscarProductoCajero()
            formulario.TopLevel = True
            'formulario.TopMost = True
            formulario.GetData(Me)
            formulario.Show()
        End If
    End Sub

    Private Sub BClienteBuscar_Click(sender As Object, e As EventArgs) Handles BClienteBuscar.Click
        If Not (Application.OpenForms().OfType(Of BuscarClienteCajero).Any) Then
            Dim formulario As New BuscarClienteCajero()
            formulario.TopLevel = True
            'formulario.TopMost = True
            formulario.GetData(Me)
            formulario.Show()
        End If
        BEditarProducto.Enabled = False
        BProductoEliminar.Enabled = False
    End Sub

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCantidad.KeyPress, TPrecio.KeyPress, TTotal.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub BProductoAñadir_Click(sender As Object, e As EventArgs) Handles BProductoAñadir.Click
        Dim objdproducto As DProducto = New DProducto()
        If TCantidad.Text > objdproducto.getStock(idproducto) Then
            MsgBox("Cantidad mayor a stock", MsgBoxStyle.Critical, "Error Stock")
        ElseIf TCantidad.Text <= 0 Then
            MsgBox("Debe ser un valor mayor a 0", MsgBoxStyle.Critical, "Error valor negativo")
        Else
            DataGridView1.Rows.Add(TNombreProducto.Text, TCategoria.Text, TCantidad.Text, TPrecio.Text, (TCantidad.Text * TPrecio.Text), idproducto)
            DataGridView1.Columns(5).Visible = False
            BComprar.Enabled = True
            limpiar()
        End If
    End Sub

    Private Sub limpiar()
        TNombreProducto.Clear()
        TCategoria.Clear()
        TPrecio.Clear()
        TCantidad.Clear()
        BProductoAñadir.Enabled = False
        BEditarProducto.Enabled = False
        BProductoEliminar.Enabled = False
        actualizarTotal()
        idproducto = Nothing
        LENumeros.Visible = False
    End Sub

    Dim index As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = DataGridView1.CurrentRow.Index
        TNombreProducto.Text = DataGridView1.CurrentRow.Cells(0).Value
        TCategoria.Text = DataGridView1.CurrentRow.Cells(1).Value
        TCantidad.Text = DataGridView1.CurrentRow.Cells(2).Value
        TPrecio.Text = DataGridView1.CurrentRow.Cells(3).Value
        BEditarProducto.Enabled = True
        BProductoEliminar.Enabled = True
    End Sub

    Private Sub BEditarProducto_Click(sender As Object, e As EventArgs) Handles BEditarProducto.Click
        DataGridView1.Rows(index).Cells(0).Value = TNombreProducto.Text
        DataGridView1.Rows(index).Cells(1).Value = TCategoria.Text
        DataGridView1.Rows(index).Cells(2).Value = TCantidad.Text
        DataGridView1.Rows(index).Cells(3).Value = TPrecio.Text
        DataGridView1.Rows(index).Cells(4).Value = (TCantidad.Text * TPrecio.Text)
        limpiar()
    End Sub

    Private Sub BProductoEliminar_Click(sender As Object, e As EventArgs) Handles BProductoEliminar.Click
        DataGridView1.Rows.Remove(DataGridView1.Rows(index))
        limpiar()
        If DataGridView1.RowCount < 1 Then
            BComprar.Enabled = False
        End If
    End Sub

    Public Sub actualizarTotal()
        Dim total As Double

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                total += row.Cells(4).Value
            End If
        Next

        TTotal.Text = total
    End Sub
    Public idproducto As Integer
    Dim idcliente As Integer
    Public Sub idproductoFunc(ByVal valor As Integer)
        idproducto = valor
    End Sub

    Public Sub idclienteFunc(ByVal valor As Integer)
        idcliente = valor
    End Sub

    Private Sub BComprar_Click(sender As Object, e As EventArgs) Handles BComprar.Click
        Dim objnfactura As NFactura = New NFactura()
        Dim myDateResult As TimeSpan = DateTime.Now.TimeOfDay
        Dim objdempleado As DEmpleado = New DEmpleado()

        myDateResult = New TimeSpan(myDateResult.Hours, myDateResult.Minutes, myDateResult.Seconds)

        Dim ask As MsgBoxResult

        ask = MsgBox("Seguro que desea realizar una venta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar venta")
        If ask = MsgBoxResult.Yes Then
            If TCliente.Text = "Consumidor Final" Then
                idcliente = 1
            End If
            If objnfactura.agregar_factura(idcliente, objdempleado.getEmpleadoId(idvendedor), TFecha.Text, myDateResult.ToString, TTotal.Text, DataGridView1) Then
                MsgBox("Compra realizada con exito", MsgBoxStyle.Information, "Compra realizada")
                reiniciar()
            Else
                MsgBox("Error al realizar compra", MsgBoxStyle.Critical, "Compra Error")
            End If
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        reiniciar()
    End Sub

    Public Sub reiniciar()
        TFecha.Text = Date.Today()
        limpiar()
        DataGridView1.Rows.Clear()
        TCliente.Text = "Consumidor Final"
        TDni.Clear()
        TTotal.Clear()
        BComprar.Enabled = False
        idproducto = Nothing
        LENumeros.Visible = False
    End Sub

    Private Sub BDeseleccionar_Click(sender As Object, e As EventArgs) Handles BDeseleccionar.Click
        TCliente.Text = "Consumidor Final"
        TDni.Clear()
        BDeseleccionar.Enabled = False
    End Sub
End Class