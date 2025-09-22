Public Class NFactura
    Function agregar_factura(ByVal id_cliente As Integer, ByVal id_empleado As Integer, ByVal fecha As String, ByVal hora As String, ByVal precio_total As Double, ByVal grid As DataGridView) As Boolean
        Dim oFactura = New Facturas
        Dim dfactura = New DFactura

        With oFactura
            .id_factura = dfactura.getUltimaFactura() + 1
            .id_cliente = id_cliente
            .id_empleado = id_empleado
            .fecha = fecha
            .hora = hora
            .precio_total = precio_total
        End With

        Dim objdFactura = New DFactura

        If objdFactura.Dguardar_factura(oFactura, grid) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
