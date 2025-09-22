Public Class ListarVentas
    Dim idvendedor As String
    Dim objddetalle As DDetalleFactura = New DDetalleFactura()
    Dim objdfactura As DFactura = New DFactura()
    Dim objdempleado As DEmpleado = New DEmpleado()

    Private Sub ListarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet8.Categoria_Producto' Puede moverla o quitarla según sea necesario.
        Me.Categoria_ProductoTableAdapter.Fill(Me.BaseDeDatosProyectoDataSet8.Categoria_Producto)

        'DGVFactura.DataSource = objdfactura.getFacturasPorVendedor(objdempleado.getEmpleadoId(idvendedor))

        LENumeros.Visible = False

        CBEmpleado.Checked = True
        CBCLiente.Checked = True
        CBFecha.Checked = True

        BLimpiar_Click()
    End Sub

    Public Sub setter(ByVal valor As String)
        idvendedor = valor
    End Sub

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, TDniCliente.KeyPress, TDniEmpleado.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub DGVFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFactura.CellClick
        DGVDetalle.DataSource = objddetalle.getVentasFactura(DGVFactura.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        MsgBox(FechaDesde.Value.ToShortDateString)
    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CBCLiente.CheckedChanged, CBFecha.CheckedChanged, CBDniCliente.CheckedChanged, CBNombreCliente.CheckedChanged
        If CBEmpleado.Checked Then
            CBNombreEmpleado.Enabled = True
            CBDniEmpleado.Enabled = True
        Else
            CBNombreEmpleado.Enabled = False
            CBDniEmpleado.Enabled = False

            CBNombreEmpleado.Checked = False
            CBDniEmpleado.Checked = False
        End If
        If CBCLiente.Checked Then
            CBNombreCliente.Enabled = True
            CBDniCliente.Enabled = True
        Else
            CBNombreCliente.Enabled = False
            CBDniCliente.Enabled = False

            CBNombreCliente.Checked = False
            CBDniCliente.Checked = False
        End If
        If CBFecha.Checked Then
            FechaDesde.Enabled = True
            FechaHasta.Enabled = True
        Else
            FechaDesde.Enabled = False
            FechaHasta.Enabled = False
        End If


        If CBNombreEmpleado.Checked Then
            TNombreEmpleado.Enabled = True
        Else
            TNombreEmpleado.Enabled = False
        End If
        If CBDniEmpleado.Checked Then
            TDniEmpleado.Enabled = True
        Else
            TDniEmpleado.Enabled = False
        End If


        If CBNombreCliente.Checked Then
            TNombreCliente.Enabled = True
        Else
            TNombreCliente.Enabled = False
        End If
        If CBDniCliente.Checked Then
            TDniCliente.Enabled = True
        Else
            TDniCliente.Enabled = False
        End If
    End Sub

    Private Sub BLimpiar_Click() Handles BLimpiar.Click
        CBEmpleado.Checked = False
        CBCLiente.Checked = False
        CBFecha.Checked = False
    End Sub

    'Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
    '    If (String.IsNullOrWhiteSpace(TProducto.Text) And CBProducto.Checked) Or (String.IsNullOrWhiteSpace(TCliente.Text) And CBCLiente.Checked) Or (String.IsNullOrWhiteSpace(TPrecio.Text) And CBPrecio.Checked And String.IsNullOrWhiteSpace(DroplistMayorO.SelectedIndex = -1)) Then
    '        MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
    '    Else
    '        Dim objDProducto As DProducto = New DProducto()

    '        Dim PrecioMayor As Boolean
    '        If DroplistMayorO.SelectedIndex = 0 And CBPrecio.Checked Then
    '            PrecioMayor = False
    '        Else
    '            PrecioMayor = True
    '        End If

    '        DataGridView1.DataSource = objDProducto.getProductosFiltro(TProducto.Text, DroplistCategoria.SelectedValue, CDbl(TPrecio.Text), CInt(TStock.Text), CBHabilitado.Checked, CBNombre.Checked, CBCategoria.Checked, CBPrecio.Checked, CBStock.Checked, PrecioMayorOMenor, StockMayorOMenor)
    '    End If
    'End Sub

    'Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, TPrecio.KeyPress, TStock.KeyPress
    '    If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
    '        LENumeros.Visible = True
    '        e.Handled = True
    '    Else
    '        LENumeros.Visible = False
    '    End If
    'End Sub
End Class