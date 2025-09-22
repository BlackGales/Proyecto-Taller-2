Public Class DFactura
    Dim ctx As New BaseDeDatosProyectoEntities()

    Function Dguardar_factura(ByVal OFactura As Facturas, ByVal grid As DataGridView) As Boolean
        Try
            ctx.Facturas.Add(OFactura)
            For Each row As DataGridViewRow In grid.Rows
                If Not row.IsNewRow Then
                    Dim oDetalle = New Detalle_Factura

                    With oDetalle
                        .id_factura = OFactura.id_factura
                        .id_producto = row.Cells(5).Value
                        .cantidad = row.Cells(2).Value
                        .precio_detalle = row.Cells(3).Value * row.Cells(2).Value
                    End With

                    ctx.Detalle_Factura.Add(oDetalle)
                    Dim query = (From c In ctx.Productos
                                 Where c.id_producto = oDetalle.id_producto
                                 Select c).FirstOrDefault()

                    query.stock -= oDetalle.cantidad
                End If
            Next
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getFacturasFiltro(ByVal NombreProducto As String, ByVal CategoriaTipo As String, ByVal NombreCliente As String, ByVal DniCliente As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal Precio2 As Double, ByVal filtroNombreProducto As Boolean, ByVal filtroCategoria As Boolean, ByVal filtroNombreCliente As Boolean, ByVal filtroDniCliente As Boolean, ByVal filtroMayorOMenor As Boolean, ByVal filtroFecha As Boolean)
        Dim listaFacturasAll = (From c In ctx.Facturas
                                Select c)
        Dim listaDetallesAll = (From c In ctx.Detalle_Factura
                                Select c)


        If filtroNombreProducto Then
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Productos.nombre.Contains(NombreProducto))
        End If
        If filtroCategoria Then
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Productos.Categoria_Producto.descripcion_categoria.Contains(CategoriaTipo))
        End If
        If filtroNombreCliente Then
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Facturas.Clientes.nombre.Contains(NombreCliente))
        End If
        If filtroDniCliente Then
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Facturas.Clientes.dni = DniCliente)
        End If
        If filtroMayorOMenor Then
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Facturas.precio_total >= Precio2)
        Else
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Facturas.precio_total <= Precio2)
        End If
        If filtroFecha Then
            listaDetallesAll = (From c In listaDetallesAll
                                Where c.Facturas.fecha >= FechaDesde And c.Facturas.fecha <= FechaHasta)
        End If

        listaDetallesAll = (From c In listaDetallesAll
                            Select c.Facturas.id_factura, c.Facturas.fecha, c.Facturas.hora, c.Facturas.precio_total)
        Return listaDetallesAll.ToList()
    End Function

    Function getUltimaFactura()
        Dim idfactura = (From c In ctx.Facturas
                         Order By c.id_factura Descending
                         Select c.id_factura).FirstOrDefault()
        Return idfactura
    End Function


    Function getFacturasPorVendedor(ByVal idvendedor As Integer)
        Dim idfacturas = (From c In ctx.Facturas
                          Where c.id_empleado = idvendedor
                          Select c.id_factura, c.fecha, c.hora, c.precio_total).ToList()
        Return idfacturas
    End Function
End Class
