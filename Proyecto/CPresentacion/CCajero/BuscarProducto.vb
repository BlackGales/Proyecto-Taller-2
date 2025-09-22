Imports System.ComponentModel
Imports System.Net.Security

Public Class BuscarProducto
    Dim objProducto As NProducto = New NProducto()

    Private Sub BuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet4.Categoria_Producto' Puede moverla o quitarla según sea necesario.
        Me.Categoria_ProductoTableAdapter.Fill(Me.BaseDeDatosProyectoDataSet4.Categoria_Producto)
        objProducto.cargarGrid(DataGridView1)
        LENumeros.Visible = False

        CBCodigo.Checked = True
        CBNombre.Checked = True
        CBCategoria.Checked = True
        CBTalle.Checked = True
        CBMarca.Checked = True
        CBPrecio.Checked = True
        CBStock.Checked = True

        Limpiar()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (String.IsNullOrWhiteSpace(TNombre.Text) And CBNombre.Checked) Or (String.IsNullOrWhiteSpace(DroplistCategoria.Text) And CBCategoria.Checked) Or (String.IsNullOrWhiteSpace(TPrecio.Text) And CBPrecio.Checked) Or (String.IsNullOrWhiteSpace(TStock.Text) And CBStock.Checked) Or (DroplistPrecio.SelectedIndex = -1 And CBPrecio.Checked) Or (DroplistStock.SelectedIndex = -1 And CBStock.Checked) Then
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
            DataGridView1.DataSource = objDProducto.getProductosFiltro(TNombre.Text, DroplistCategoria.SelectedValue, CDbl(TPrecio.Text), CInt(TStock.Text), CBHabilitado.Checked, CBNombre.Checked, CBCategoria.Checked, CBPrecio.Checked, CBStock.Checked, PrecioMayorOMenor, StockMayorOMenor)
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
    End Sub

    Private number As Double
    Private entero As Integer

    Private Sub TPrecio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TPrecio.Validating
        If Not Decimal.TryParse(TPrecio.Text, Number) Then
            LENumeros.Visible = True
            e.Cancel = True
        Else
            TPrecio.Text = String.Format("{0:n2}", Number)
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, TPrecio.KeyPress, TStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub


    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CBCodigo.CheckedChanged, CBNombre.CheckedChanged, CBCategoria.CheckedChanged, CBTalle.CheckedChanged, CBMarca.CheckedChanged, CBPrecio.CheckedChanged, CBStock.CheckedChanged
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
        If CBPrecio.Checked Then
            DroplistPrecio.Enabled = True
            TPrecio.Enabled = True
        Else
            DroplistPrecio.Enabled = False
            TPrecio.Enabled = False
        End If
        If CBStock.Checked Then
            DroplistStock.Enabled = True
            TStock.Enabled = True
        Else
            DroplistStock.Enabled = False
            TStock.Enabled = False
        End If
    End Sub

    Private Sub Limpiar()
        TCodigo.Clear()
        TNombre.Clear()
        DroplistCategoria.SelectedItem = Nothing
        DroplistTalle.SelectedItem = Nothing
        DroplistMarca.SelectedItem = Nothing
        TPrecio.Clear()
        TStock.Clear()

        CBCodigo.Checked = False
        CBNombre.Checked = False
        CBCategoria.Checked = False
        CBTalle.Checked = False
        CBMarca.Checked = False
        CBPrecio.Checked = False
        CBStock.Checked = False
        CBHabilitado.Checked = True

        DataGridView1.ClearSelection()
    End Sub
End Class