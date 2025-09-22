<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TNombreProducto = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproductos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.TCategoria = New System.Windows.Forms.TextBox()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.TCliente = New System.Windows.Forms.TextBox()
        Me.LCompra = New System.Windows.Forms.Label()
        Me.BComprar = New System.Windows.Forms.Button()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BProductoBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.BEditarProducto = New System.Windows.Forms.Button()
        Me.BProductoEliminar = New System.Windows.Forms.Button()
        Me.BProductoAñadir = New System.Windows.Forms.Button()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.TCantidad = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BDeseleccionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.BClienteBuscar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TNombreVendedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TNroFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TNombreProducto
        '
        Me.TNombreProducto.Enabled = False
        Me.TNombreProducto.Location = New System.Drawing.Point(88, 56)
        Me.TNombreProducto.Name = "TNombreProducto"
        Me.TNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.TNombreProducto.TabIndex = 0
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(16, 56)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Categoria, Me.Cantidad, Me.Precio_Unitario, Me.Precio_Total, Me.idproductos})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1168, 288)
        Me.DataGridView1.TabIndex = 2
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio_Unitario
        '
        Me.Precio_Unitario.HeaderText = "Precio_Unitario"
        Me.Precio_Unitario.Name = "Precio_Unitario"
        '
        'Precio_Total
        '
        Me.Precio_Total.HeaderText = "Precio_Total"
        Me.Precio_Total.Name = "Precio_Total"
        '
        'idproductos
        '
        Me.idproductos.HeaderText = "idproductos"
        Me.idproductos.Name = "idproductos"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(208, 56)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(52, 13)
        Me.LCategoria.TabIndex = 3
        Me.LCategoria.Text = "Categoria"
        '
        'TCategoria
        '
        Me.TCategoria.Enabled = False
        Me.TCategoria.Location = New System.Drawing.Point(280, 56)
        Me.TCategoria.Name = "TCategoria"
        Me.TCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TCategoria.TabIndex = 4
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.Location = New System.Drawing.Point(32, 48)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(39, 13)
        Me.LCliente.TabIndex = 5
        Me.LCliente.Text = "Cliente"
        '
        'TCliente
        '
        Me.TCliente.Location = New System.Drawing.Point(80, 48)
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(120, 20)
        Me.TCliente.TabIndex = 6
        Me.TCliente.Text = "Consumidor Final"
        '
        'LCompra
        '
        Me.LCompra.AutoSize = True
        Me.LCompra.Location = New System.Drawing.Point(176, 8)
        Me.LCompra.Name = "LCompra"
        Me.LCompra.Size = New System.Drawing.Size(43, 13)
        Me.LCompra.TabIndex = 12
        Me.LCompra.Text = "Compra"
        '
        'BComprar
        '
        Me.BComprar.Location = New System.Drawing.Point(248, 40)
        Me.BComprar.Name = "BComprar"
        Me.BComprar.Size = New System.Drawing.Size(117, 23)
        Me.BComprar.TabIndex = 14
        Me.BComprar.Text = "Finalizar Compra"
        Me.BComprar.UseVisualStyleBackColor = True
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Location = New System.Drawing.Point(32, 40)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(48, 13)
        Me.LTotal.TabIndex = 21
        Me.LTotal.Text = "TOTAL: "
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(248, 80)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(117, 23)
        Me.BCancelar.TabIndex = 22
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BProductoBuscar
        '
        Me.BProductoBuscar.Location = New System.Drawing.Point(400, 56)
        Me.BProductoBuscar.Name = "BProductoBuscar"
        Me.BProductoBuscar.Size = New System.Drawing.Size(166, 23)
        Me.BProductoBuscar.TabIndex = 23
        Me.BProductoBuscar.Text = "Buscar Producto"
        Me.BProductoBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.LENumeros)
        Me.Panel1.Controls.Add(Me.BEditarProducto)
        Me.Panel1.Controls.Add(Me.BProductoEliminar)
        Me.Panel1.Controls.Add(Me.BProductoAñadir)
        Me.Panel1.Controls.Add(Me.LProducto)
        Me.Panel1.Controls.Add(Me.BProductoBuscar)
        Me.Panel1.Controls.Add(Me.TPrecio)
        Me.Panel1.Controls.Add(Me.LPrecio)
        Me.Panel1.Controls.Add(Me.TNombreProducto)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LCategoria)
        Me.Panel1.Controls.Add(Me.TCategoria)
        Me.Panel1.Controls.Add(Me.TCantidad)
        Me.Panel1.Controls.Add(Me.LCantidad)
        Me.Panel1.Location = New System.Drawing.Point(8, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 121)
        Me.Panel1.TabIndex = 24
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(424, 88)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(111, 13)
        Me.LENumeros.TabIndex = 55
        Me.LENumeros.Text = "Solo ingresar numeros"
        '
        'BEditarProducto
        '
        Me.BEditarProducto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BEditarProducto.Location = New System.Drawing.Point(576, 24)
        Me.BEditarProducto.Name = "BEditarProducto"
        Me.BEditarProducto.Size = New System.Drawing.Size(166, 23)
        Me.BEditarProducto.TabIndex = 28
        Me.BEditarProducto.Text = "Editar Producto de Carrito"
        Me.BEditarProducto.UseVisualStyleBackColor = False
        '
        'BProductoEliminar
        '
        Me.BProductoEliminar.BackColor = System.Drawing.Color.LightCoral
        Me.BProductoEliminar.Location = New System.Drawing.Point(576, 88)
        Me.BProductoEliminar.Name = "BProductoEliminar"
        Me.BProductoEliminar.Size = New System.Drawing.Size(163, 23)
        Me.BProductoEliminar.TabIndex = 27
        Me.BProductoEliminar.Text = "Eliminar Producto de Carrito"
        Me.BProductoEliminar.UseVisualStyleBackColor = False
        '
        'BProductoAñadir
        '
        Me.BProductoAñadir.BackColor = System.Drawing.Color.LimeGreen
        Me.BProductoAñadir.Location = New System.Drawing.Point(576, 56)
        Me.BProductoAñadir.Name = "BProductoAñadir"
        Me.BProductoAñadir.Size = New System.Drawing.Size(163, 23)
        Me.BProductoAñadir.TabIndex = 26
        Me.BProductoAñadir.Text = "Añadir Producto a Carrito"
        Me.BProductoAñadir.UseVisualStyleBackColor = False
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Location = New System.Drawing.Point(352, 8)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(50, 13)
        Me.LProducto.TabIndex = 25
        Me.LProducto.Text = "Producto"
        '
        'TPrecio
        '
        Me.TPrecio.Enabled = False
        Me.TPrecio.Location = New System.Drawing.Point(280, 88)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TPrecio.TabIndex = 20
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(208, 88)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LPrecio.TabIndex = 19
        Me.LPrecio.Text = "Precio"
        '
        'TCantidad
        '
        Me.TCantidad.Enabled = False
        Me.TCantidad.Location = New System.Drawing.Point(88, 88)
        Me.TCantidad.Name = "TCantidad"
        Me.TCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TCantidad.TabIndex = 18
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.Location = New System.Drawing.Point(16, 88)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LCantidad.TabIndex = 17
        Me.LCantidad.Text = "Cantidad"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.BDeseleccionar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TDni)
        Me.Panel2.Controls.Add(Me.BClienteBuscar)
        Me.Panel2.Controls.Add(Me.LCliente)
        Me.Panel2.Controls.Add(Me.TCliente)
        Me.Panel2.Location = New System.Drawing.Point(632, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 80)
        Me.Panel2.TabIndex = 25
        '
        'BDeseleccionar
        '
        Me.BDeseleccionar.Location = New System.Drawing.Point(416, 48)
        Me.BDeseleccionar.Name = "BDeseleccionar"
        Me.BDeseleccionar.Size = New System.Drawing.Size(120, 23)
        Me.BDeseleccionar.TabIndex = 30
        Me.BDeseleccionar.Text = "Deseleccionar Cliente"
        Me.BDeseleccionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "DNI"
        '
        'TDni
        '
        Me.TDni.Enabled = False
        Me.TDni.Location = New System.Drawing.Point(296, 48)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(104, 20)
        Me.TDni.TabIndex = 28
        '
        'BClienteBuscar
        '
        Me.BClienteBuscar.Location = New System.Drawing.Point(416, 16)
        Me.BClienteBuscar.Name = "BClienteBuscar"
        Me.BClienteBuscar.Size = New System.Drawing.Size(120, 23)
        Me.BClienteBuscar.TabIndex = 26
        Me.BClienteBuscar.Text = "Buscar Cliente"
        Me.BClienteBuscar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Controls.Add(Me.TTotal)
        Me.Panel3.Controls.Add(Me.LTotal)
        Me.Panel3.Controls.Add(Me.BComprar)
        Me.Panel3.Controls.Add(Me.LCompra)
        Me.Panel3.Controls.Add(Me.BCancelar)
        Me.Panel3.Location = New System.Drawing.Point(792, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(384, 120)
        Me.Panel3.TabIndex = 26
        '
        'TTotal
        '
        Me.TTotal.Location = New System.Drawing.Point(96, 40)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(100, 20)
        Me.TTotal.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.TFecha)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.TNombreVendedor)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TNroFactura)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(8, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(544, 76)
        Me.Panel4.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Factura"
        '
        'TFecha
        '
        Me.TFecha.Enabled = False
        Me.TFecha.Location = New System.Drawing.Point(432, 48)
        Me.TFecha.Name = "TFecha"
        Me.TFecha.Size = New System.Drawing.Size(100, 20)
        Me.TFecha.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha"
        '
        'TNombreVendedor
        '
        Me.TNombreVendedor.Enabled = False
        Me.TNombreVendedor.Location = New System.Drawing.Point(256, 48)
        Me.TNombreVendedor.Name = "TNombreVendedor"
        Me.TNombreVendedor.Size = New System.Drawing.Size(100, 20)
        Me.TNombreVendedor.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Vendedor"
        '
        'TNroFactura
        '
        Me.TNroFactura.Enabled = False
        Me.TNroFactura.Location = New System.Drawing.Point(80, 48)
        Me.TNroFactura.Name = "TNroFactura"
        Me.TNroFactura.Size = New System.Drawing.Size(100, 20)
        Me.TNroFactura.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nro Factura"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Location = New System.Drawing.Point(8, 240)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1168, 312)
        Me.Panel5.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Productos en Factura"
        '
        'VentaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentaProducto"
        Me.ShowIcon = False
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TNombreProducto As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LCategoria As Label
    Friend WithEvents TCategoria As TextBox
    Friend WithEvents LCliente As Label
    Friend WithEvents TCliente As TextBox
    Friend WithEvents LCompra As Label
    Friend WithEvents BComprar As Button
    Friend WithEvents LTotal As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BProductoBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LProducto As Label
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents LPrecio As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents BClienteBuscar As Button
    Friend WithEvents BProductoAñadir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TTotal As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TNombreVendedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TNroFactura As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TCantidad As TextBox
    Friend WithEvents LCantidad As Label
    Friend WithEvents BProductoEliminar As Button
    Friend WithEvents BEditarProducto As Button
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Unitario As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Total As DataGridViewTextBoxColumn
    Friend WithEvents idproductos As DataGridViewTextBoxColumn
    Friend WithEvents BDeseleccionar As Button
    Friend WithEvents LENumeros As Label
End Class
