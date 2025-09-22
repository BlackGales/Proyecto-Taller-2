Public Class NDetalleFactura
    Function agregar_detalle_factura(ByVal id_factura As Integer, ByVal id_producto As Integer, ByVal cantidad As Integer, ByVal precio_unitario As Double) As Boolean
        Dim oDetalle = New Detalle_Factura

        With oDetalle
            .id_factura = id_factura
            .id_producto = id_producto
            .cantidad = cantidad
            .precio_detalle = precio_unitario
        End With

        Dim objdDetalle = New DDetalleFactura

        If objdDetalle.Dguardar_detalle_factura(oDetalle) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
