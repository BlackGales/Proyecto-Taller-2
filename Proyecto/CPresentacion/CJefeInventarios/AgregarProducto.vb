Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AgregarProducto
    Dim objProducto As NProducto = New NProducto()
    Dim dproducto As DProducto = New DProducto()
    Dim index As Integer
    Dim nombre As String

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet2.Categoria_Producto' Puede moverla o quitarla según sea necesario.
        Me.Categoria_ProductoTableAdapter.Fill(Me.BaseDeDatosProyectoDataSet2.Categoria_Producto)
        objProducto.cargarGrid(DataGridView1)
        BEditar.Enabled = False

        CBCodigo.Checked = True
        CBNombre.Checked = True
        CBCategoria.Checked = True
        CBTalle.Checked = True
        CBMarca.Checked = True
        CBPrecio.Checked = True
        CBStock.Checked = True

        Limpiar()
        LENumeros2.Visible = False
        LENumeros.Visible = False
    End Sub

    Private Sub datagridview1_cellmouseclick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If DataGridView1.RowCount > 0 Then
            nombre = DataGridView1.CurrentRow.Cells(0).Value
            index = DataGridView1.CurrentRow.Index

            TNombre.Text = DataGridView1.CurrentRow.Cells(0).Value
            DroplistCategoria.SelectedIndex = DataGridView1.CurrentRow.Cells(6).Value - 1
            TStock.Text = DataGridView1.CurrentRow.Cells(2).Value
            TStockMin.Text = DataGridView1.CurrentRow.Cells(3).Value
            TPrecio.Text = DataGridView1.CurrentRow.Cells(4).Value
            If DataGridView1.CurrentRow.Cells(5).Value = "SI" Then
                CBHabilitado.Checked = True
            Else
                CBHabilitado.Checked = False
            End If
            BAgregar.Enabled = False
            BEditar.Enabled = True
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(DroplistCategoria.Text) Or String.IsNullOrWhiteSpace(TPrecio.Text) Or String.IsNullOrWhiteSpace(TStock.Text) Or String.IsNullOrWhiteSpace(TStockMin.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar un nuevo Producto", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar insercion")
            If ask = MsgBoxResult.Yes Then
                nombre = TNombre.Text
                Dim Habilitado As String
                If CBHabilitado.Checked Then
                    Habilitado = "SI"
                Else
                    Habilitado = "NO"
                End If
                If objProducto.agregar_producto(DroplistCategoria.SelectedIndex + 1, TNombre.Text, CInt(TStock.Text), CInt(TStockMin.Text), CDbl(TPrecio.Text), Habilitado) Then
                    objProducto.cargarGrid(DataGridView1)
                    Limpiar()
                    MsgBox("El Producto: " + nombre + " se insertó correctamente", MsgBoxStyle.Information, "Guardar Producto")
                Else
                    MsgBox("El Producto: " + nombre + " se ya existe", MsgBoxStyle.Critical, "Error Usuario")
                End If
            End If
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        If DataGridView1.RowCount > 0 Then
            If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(DroplistCategoria.Text) Or String.IsNullOrWhiteSpace(TPrecio.Text) Or String.IsNullOrWhiteSpace(TStock.Text) Or String.IsNullOrWhiteSpace(TStockMin.Text) Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
            Else
                Dim ask As MsgBoxResult
                ask = MsgBox("Seguro que desea editar los valores del producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar edición")
                If ask = MsgBoxResult.Yes Then
                    Dim Habilitado As String
                    If CBHabilitado.Checked Then
                        Habilitado = "SI"
                    Else
                        Habilitado = "NO"
                    End If
                    If dproducto.editProducto(DroplistCategoria.SelectedIndex + 1, TNombre.Text, CInt(TStock.Text), CInt(TStockMin.Text), CDbl(TPrecio.Text), Habilitado, DataGridView1.Rows(index).Cells(7).Value) Then
                        objProducto.cargarGrid(DataGridView1)
                        Limpiar()
                        MsgBox("El Producto: " + nombre + " se editó correctamente", MsgBoxStyle.Information, "Editar Producto")
                        BEditar.Enabled = False
                        BAgregar.Enabled = True
                    End If
                End If
            End If
        Else
            MsgBox("No hay productos que editar", MsgBoxStyle.Critical, "Error Seleccion")
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If DataGridView1.RowCount > 0 Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea editar los valores del producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar edición")
            If ask = MsgBoxResult.Yes Then
                Dim Habilitado As String
                If CBHabilitado.Checked Then
                    Habilitado = "SI"
                Else
                    Habilitado = "NO"
                End If
                If dproducto.editProducto(DroplistCategoria.SelectedIndex + 1, TNombre.Text, CInt(TStock.Text), CInt(TStockMin.Text), CDbl(TPrecio.Text), Habilitado, DataGridView1.Rows(index).Cells(7).Value) Then
                    objProducto.cargarGrid(DataGridView1)
                    Limpiar()
                    MsgBox("El Producto: " + nombre + " se editó correctamente", MsgBoxStyle.Information, "Editar Producto")
                    BEditar.Enabled = False
                    BAgregar.Enabled = True
                End If
            End If
        Else
            MsgBox("No hay productos que editar", MsgBoxStyle.Critical, "Error Seleccion")
        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (String.IsNullOrWhiteSpace(TNombreBuscar.Text) And CBNombre.Checked) Or (String.IsNullOrWhiteSpace(DroplistCategoriaBuscar.Text) And CBCategoria.Checked) Or (String.IsNullOrWhiteSpace(TPrecioBuscar.Text) And CBPrecio.Checked) Or (String.IsNullOrWhiteSpace(TStockBuscar.Text) And CBStock.Checked) Or (DroplistPrecio.SelectedIndex = -1 And CBPrecio.Checked) Or (DroplistStock.SelectedIndex = -1 And CBStock.Checked) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim objDProducto As DProducto = New DProducto()

            Dim PrecioMayorOMenor As Boolean
            Dim StockMayorOMenor As Boolean
            If DroplistPrecio.SelectedIndex = 0 And CBPrecio.Checked Then
                PrecioMayorOMenor = False
            ElseIf DroplistPrecio.SelectedIndex = 1 And CBPrecio.Checked Then
                PrecioMayorOMenor = True
            End If

            If DroplistStock.SelectedIndex = 0 And CBStock.Checked Then
                StockMayorOMenor = False
            ElseIf DroplistStock.SelectedIndex = 1 And CBStock.Checked Then
                StockMayorOMenor = True
            End If
            DataGridView1.DataSource = objDProducto.getProductosFiltro(TNombreBuscar.Text, DroplistCategoriaBuscar.SelectedValue, CDbl(TPrecioBuscar.Text), CInt(TStockBuscar.Text), CBHabilitadoBuscar.Checked, CBNombre.Checked, CBCategoria.Checked, CBPrecio.Checked, CBStock.Checked, PrecioMayorOMenor, StockMayorOMenor)
        End If
    End Sub

    Private number As Double
    Private entero As Integer

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TPrecio.Validating, TPrecioBuscar.Validating
        If Not Decimal.TryParse(TPrecio.Text, number) Then
            LENumeros.Visible = True
            e.Cancel = True
        Else
            TPrecio.Text = String.Format("{0:n2}", number)
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress, TNombreBuscar.KeyPress
        With TNombre
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, TPrecio.KeyPress, TStockMin.KeyPress, TStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub ValidarNumeros_KeyPress2(sender As Object, e As KeyPressEventArgs) Handles TPrecioBuscar.KeyPress, TStockBuscar.KeyPress, MyBase.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros2.Visible = True
            e.Handled = True
        Else
            LENumeros2.Visible = False
        End If
    End Sub

    Private Sub agregarproducto_mouseleave(sender As Object, e As EventArgs) Handles MyBase.Click
        LENumeros.Visible = False
    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CBCodigo.CheckedChanged, CBNombre.CheckedChanged, CBCategoria.CheckedChanged, CBTalle.CheckedChanged, CBMarca.CheckedChanged, CBPrecio.CheckedChanged, CBStock.CheckedChanged
        If CBCodigo.Checked Then
            TCodigoBuscar.Enabled = True
        Else
            TCodigoBuscar.Enabled = False
        End If
        If CBNombre.Checked Then
            TNombreBuscar.Enabled = True
        Else
            TNombreBuscar.Enabled = False
        End If
        If CBCategoria.Checked Then
            DroplistCategoriaBuscar.Enabled = True
        Else
            DroplistCategoriaBuscar.Enabled = False
        End If
        If CBTalle.Checked Then
            DroplistTalleBuscar.Enabled = True
        Else
            DroplistTalleBuscar.Enabled = False
        End If
        If CBMarca.Checked Then
            DroplistMarcaBuscar.Enabled = True
        Else
            DroplistMarcaBuscar.Enabled = False
        End If
        If CBPrecio.Checked Then
            DroplistPrecio.Enabled = True
            TPrecioBuscar.Enabled = True
        Else
            DroplistPrecio.Enabled = False
            TPrecioBuscar.Enabled = False
        End If
        If CBStock.Checked Then
            DroplistStock.Enabled = True
            TStockBuscar.Enabled = True
        Else
            DroplistStock.Enabled = False
            TStockBuscar.Enabled = False
        End If
    End Sub

    Private Sub Limpiar()
        TCodigo.Clear()
        TNombre.Clear()
        DroplistCategoria.SelectedItem = Nothing
        DroplistMarca.SelectedItem = Nothing
        DroplistTalle.SelectedItem = Nothing
        TPrecio.Clear()
        TStockMin.Clear()
        TStock.Clear()
        DataGridView1.ClearSelection()
        LimpiarBuscar()
    End Sub

    Private Sub LimpiarBuscar()
        TCodigoBuscar.Clear()
        TNombreBuscar.Clear()
        DroplistCategoriaBuscar.SelectedItem = Nothing
        DroplistMarcaBuscar.SelectedItem = Nothing
        DroplistTalleBuscar.SelectedItem = Nothing
        DroplistPrecio.SelectedItem = Nothing
        DroplistStock.SelectedItem = Nothing
        TPrecioBuscar.Clear()
        TStockBuscar.Clear()

        CBCodigo.Checked = False
        CBNombre.Checked = False
        CBCategoria.Checked = False
        CBTalle.Checked = False
        CBMarca.Checked = False
        CBPrecio.Checked = False
        CBStock.Checked = False
    End Sub
End Class