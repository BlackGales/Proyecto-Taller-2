Public Class DDetalleFactura
    Dim ctx As New BaseDeDatosProyectoEntities()

    Function Dguardar_detalle_factura(ByVal ODetalle As Detalle_Factura) As Boolean
        Try
            ctx.Detalle_Factura.Add(ODetalle)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function editProducto(ByVal id_producto As Integer, ByVal cantidad As Integer)
        Dim query = (From c In ctx.Productos
                     Where c.id_producto = id_producto
                     Select c).FirstOrDefault()

        query.stock -= cantidad
        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Function getVentasFactura(ByVal idfactura As Integer)
        Dim detalles = (From c In ctx.Detalle_Factura
                        Where c.id_factura = idfactura
                        Select c.id_detalle, c.Productos.nombre, c.Productos.Categoria_Producto.descripcion_categoria, c.cantidad, c.precio_detalle).ToList
        Return detalles
    End Function

    Function getVentasVendedor(ByVal idvendedor As Integer)
        Dim detalles = (From c In ctx.Detalle_Factura
                        Where c.Facturas.id_empleado = idvendedor
                        Select c.id_detalle, c.cantidad, c.precio_detalle).ToList
        Return detalles
    End Function
End Class
