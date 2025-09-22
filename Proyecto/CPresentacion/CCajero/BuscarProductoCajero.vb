Imports System.Net.Security
Imports System.Security.Cryptography
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BuscarProductoCajero
    Dim objProducto As NProducto = New NProducto()
    Dim formulario As VentaProducto = New VentaProducto()

    Public Sub GetData(ByVal form As VentaProducto)
        formulario = form
    End Sub

    Private Sub BuscarProductoCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet5.Categoria_Producto' Puede moverla o quitarla según sea necesario.
        Me.Categoria_ProductoTableAdapter.Fill(Me.BaseDeDatosProyectoDataSet5.Categoria_Producto)
        BSeleccionar.Enabled = False
        LENumeros.Visible = False

        Limpiar()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        BSeleccionar.Enabled = True
    End Sub

    Function estaEnCarrito(ByVal grid As DataGridView)
        For Each row As DataGridViewRow In grid.Rows
            If Not row.IsNewRow Then
                If row.Cells(5).Value = DataGridView1.CurrentRow.Cells(6).Value Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (String.IsNullOrWhiteSpace(TNombre.Text) And CBNombre.Checked) Or (String.IsNullOrWhiteSpace(DroplistCategoria.Text) And CBCategoria.Checked) Or (String.IsNullOrWhiteSpace(TPrecio.Text) And CBPrecioProducto.Checked) Or (DroplistPrecio.SelectedIndex = -1 And CBPrecioProducto.Checked) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim objDProducto As DProducto = New DProducto()

            Dim PrecioMayorOMenor As Boolean
            Dim StockMayorOMenor As Boolean
            StockMayorOMenor = False
            If DroplistPrecio.SelectedIndex = 0 And CBPrecioProducto.Checked Then
                PrecioMayorOMenor = False
            ElseIf DroplistPrecio.SelectedIndex = 1 And CBPrecioProducto.Checked Then
                PrecioMayorOMenor = True
            End If
            DataGridView1.DataSource = objDProducto.getProductosFiltro(TNombre.Text, DroplistCategoria.SelectedValue, CDbl(TPrecio.Text), CInt(0), CBHabilitado.Checked, CBNombre.Checked, CBCategoria.Checked, CBPrecioProducto.Checked, False, PrecioMayorOMenor, StockMayorOMenor)
            DataGridView1.Columns(6).Visible = False
        End If
    End Sub


    Private Sub BSeleccionar_Click(sender As Object, e As EventArgs) Handles BSeleccionar.Click
        If estaEnCarrito(formulario.DataGridView1) Then
            MsgBox("El producto ya se encuentra en el carrito", MsgBoxStyle.Critical, "Producto en el carrito")
        Else
            If DataGridView1.CurrentRow.Cells(5).Value = "SI" Then
                formulario.TNombreProducto.Text = DataGridView1.CurrentRow.Cells(0).Value
                formulario.TCategoria.Text = DataGridView1.CurrentRow.Cells(1).Value
                formulario.TPrecio.Text = DataGridView1.CurrentRow.Cells(4).Value
                formulario.TCantidad.Text = 1

                formulario.TPrecio.Enabled = True
                formulario.TCantidad.Enabled = True
                formulario.BProductoAñadir.Enabled = True
                formulario.idproductoFunc(DataGridView1.CurrentRow.Cells(6).Value)
                Me.Close()
            Else
                MsgBox("El producto no se encuentra habilitado para la venta", MsgBoxStyle.Critical, "Producto no habilitado")
            End If
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, TPrecio.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CBCodigo.CheckedChanged, CBNombre.CheckedChanged, CBCategoria.CheckedChanged, CBTalle.CheckedChanged, CBMarca.CheckedChanged, CBPrecioProducto.CheckedChanged
        If CBCodigo.Checked Then
            TCodigo.Enabled = True
        Else
            TCodigo.Enabled = False
        End If
        If CBNombre.Checked Then
            TNombre.Enabled = True
        Else
            TNombre.Enabled = False
        End If
        If CBCategoria.Checked Then
            DroplistCategoria.Enabled = True
        Else
            DroplistCategoria.Enabled = False
        End If
        If CBTalle.Checked Then
            DroplistTalle.Enabled = True
        Else
            DroplistTalle.Enabled = False
        End If
        If CBMarca.Checked Then
            DroplistMarca.Enabled = True
        Else
            DroplistMarca.Enabled = False
        End If
        If CBPrecioProducto.Checked Then
            DroplistPrecio.Enabled = True
            TPrecio.Enabled = True
        Else
            DroplistPrecio.Enabled = False
            TPrecio.Enabled = False
        End If
    End Sub

    Private Sub Limpiar()
        CBCodigo.Checked = False
        CBNombre.Checked = False
        CBCategoria.Checked = False
        CBTalle.Checked = False
        CBMarca.Checked = False
        CBPrecioProducto.Checked = False

        TCodigo.Clear()
        TNombre.Clear()
        DroplistCategoria.SelectedItem = Nothing
        DroplistTalle.SelectedItem = Nothing
        DroplistMarca.SelectedItem = Nothing
        DroplistPrecio.SelectedItem = Nothing
        TPrecio.Clear()
    End Sub
End Class