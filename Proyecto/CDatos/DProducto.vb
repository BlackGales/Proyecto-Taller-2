Imports System.Data.Entity.Infrastructure
Imports System.Net.Security

Public Class DProducto
    Dim ctx As New BaseDeDatosProyectoEntities()
    Function Dguardar_producto(ByVal OProducto As Productos) As Boolean
        Try
            ctx.Productos.Add(OProducto)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Function editProducto(ByVal id_categoria As Integer, ByVal nombre As String, ByVal stock As Integer, ByVal stock_min As Integer, ByVal precio As Double, ByVal habilitado As String, ByVal idProducto As Integer)
        Dim query = (From c In ctx.Productos
                     Where c.id_producto = idProducto
                     Select c).FirstOrDefault()

        query.nombre = nombre
        query.id_categoria = id_categoria
        query.stock = stock
        query.stock_min = stock_min
        query.precio = precio
        query.habilitado = habilitado

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function
    Function getStock(ByVal id_producto As Integer)
        Dim listaProducto = (From c In ctx.Productos
                             Where c.id_producto = id_producto
                             Select Stock = c.stock).FirstOrDefault

        Return listaProducto
    End Function

    Function getProductoAll()
        Dim listaProducto = (From c In ctx.Productos
                             Select Nombre = c.nombre, Categoria = c.Categoria_Producto.descripcion_categoria, Stock = c.stock, Stock_Minimo = c.stock_min, Precio = c.precio, Habilitado = c.habilitado, c.id_categoria, c.id_producto).ToList

        Return listaProducto
    End Function
    Function getProductoCategoria(ByVal CategoriaTipo As Integer)
        Dim listaProductoCategoria = (From c In ctx.Productos
                                      Where c.id_categoria = CategoriaTipo
                                      Select Nombre = c.nombre, Categoria = c.Categoria_Producto.descripcion_categoria, Stock = c.stock, Stock_Minimo = c.stock_min, Precio = c.precio, Habilitado = c.habilitado).ToList

        Return listaProductoCategoria
    End Function

    Function getProductosFiltro(ByVal Nombre2 As String, ByVal CategoriaTipo As String, ByVal Precio2 As Double, ByVal Stock2 As Integer, ByVal Habilitado2 As Boolean, ByVal filtroNombre As Boolean, ByVal filtroCategoria As Boolean, ByVal filtroPrecio As Boolean, ByVal filtroStock As Boolean, ByVal PrecioMayorOMenor As Boolean, ByVal StockMayorOMenor As Boolean)
        Dim ListaProductosAll = (From c In ctx.Productos
                                 Select Nombre = c.nombre, Categoria = c.Categoria_Producto.descripcion_categoria, Stock = c.stock, Stock_Minimo = c.stock_min, Precio = c.precio, Habilitado = c.habilitado, c.id_producto)
        If Habilitado2 Then
            ListaProductosAll = (From c In ListaProductosAll
                                 Where c.Habilitado = "SI")
        Else
            ListaProductosAll = (From c In ListaProductosAll
                                 Where c.Habilitado = "NO")
        End If
        If filtroNombre Then
            ListaProductosAll = (From c In ListaProductosAll
                                 Where c.Nombre.Contains(Nombre2))
        End If
        If filtroCategoria Then
            ListaProductosAll = (From c In ListaProductosAll
                                 Where c.Categoria.Contains(CategoriaTipo))
        End If
        If filtroPrecio Then
            If PrecioMayorOMenor Then
                ListaProductosAll = (From c In ListaProductosAll
                                     Where c.Precio >= Precio2)
            Else
                ListaProductosAll = (From c In ListaProductosAll
                                     Where c.Precio <= Precio2)
            End If
        End If
        If filtroStock Then
            If StockMayorOMenor Then
                ListaProductosAll = (From c In ListaProductosAll
                                     Where c.Stock >= Stock2)
            Else
                ListaProductosAll = (From c In ListaProductosAll
                                     Where c.Stock <= Stock2)
            End If
        End If

        Return ListaProductosAll.ToList()
    End Function

    Function getProductosCarrito(ByVal Nombre2 As String, ByVal CategoriaTipo As String, ByVal Precio2 As Double)
        Dim ListaProductosAll = (From c In ctx.Productos
                                 Where c.nombre.Contains(Nombre2)
                                 Select c.id_producto).First()
        Return ListaProductosAll
    End Function

End Class
