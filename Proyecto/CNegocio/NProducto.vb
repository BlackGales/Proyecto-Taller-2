Imports System.Data.Common

Public Class NProducto
    Function agregar_producto(ByVal id_categoria As Integer, ByVal nombre As String, ByVal stock As Integer, ByVal stock_min As Integer, ByVal precio As Double, ByVal habilitado As String) As Boolean
        Dim oProducto = New Productos

        With oProducto
            .id_categoria = id_categoria
            .nombre = nombre
            .stock = stock
            .stock_min = stock_min
            .precio = precio
            .habilitado = habilitado
        End With

        Dim objdProducto = New DProducto

        If objdProducto.Dguardar_producto(oProducto) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim user As DProducto = New DProducto

        grid.DataSource = user.getProductoAll()

        grid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Columns(6).Visible = False
        grid.Columns(7).Visible = False
    End Sub
End Class
