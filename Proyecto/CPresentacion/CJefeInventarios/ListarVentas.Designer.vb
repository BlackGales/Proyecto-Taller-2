<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarVentas
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
        Me.components = New System.ComponentModel.Container()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNombreCliente = New System.Windows.Forms.TextBox()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.CBCLiente = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBFecha = New System.Windows.Forms.CheckBox()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.DGVFactura = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TDniCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBNombreCliente = New System.Windows.Forms.CheckBox()
        Me.CategoriaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet8 = New Proyecto.BaseDeDatosProyectoDataSet8()
        Me.Categoria_ProductoTableAdapter = New Proyecto.BaseDeDatosProyectoDataSet8TableAdapters.Categoria_ProductoTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBDniCliente = New System.Windows.Forms.CheckBox()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.LDniEmpleado = New System.Windows.Forms.Label()
        Me.CBDniEmpleado = New System.Windows.Forms.CheckBox()
        Me.LNombreEmpleado = New System.Windows.Forms.Label()
        Me.CBNombreEmpleado = New System.Windows.Forms.CheckBox()
        Me.TDniEmpleado = New System.Windows.Forms.TextBox()
        Me.CBEmpleado = New System.Windows.Forms.CheckBox()
        Me.TNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.LEmpleado = New System.Windows.Forms.Label()
        Me.LENumeros = New System.Windows.Forms.Label()
        CType(Me.DGVFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BImprimir
        '
        Me.BImprimir.Location = New System.Drawing.Point(1048, 48)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(108, 23)
        Me.BImprimir.TabIndex = 1
        Me.BImprimir.Text = "Imprimir Factura"
        Me.BImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'TNombreCliente
        '
        Me.TNombreCliente.Location = New System.Drawing.Point(192, 16)
        Me.TNombreCliente.Name = "TNombreCliente"
        Me.TNombreCliente.Size = New System.Drawing.Size(152, 20)
        Me.TNombreCliente.TabIndex = 3
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(752, 16)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(37, 13)
        Me.LFecha.TabIndex = 5
        Me.LFecha.Text = "Fecha"
        '
        'FechaDesde
        '
        Me.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDesde.Location = New System.Drawing.Point(776, 56)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(84, 20)
        Me.FechaDesde.TabIndex = 6
        '
        'CBCLiente
        '
        Me.CBCLiente.AutoSize = True
        Me.CBCLiente.Location = New System.Drawing.Point(16, 16)
        Me.CBCLiente.Name = "CBCLiente"
        Me.CBCLiente.Size = New System.Drawing.Size(15, 14)
        Me.CBCLiente.TabIndex = 7
        Me.CBCLiente.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(1048, 8)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(108, 23)
        Me.BBuscar.TabIndex = 10
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'CBFecha
        '
        Me.CBFecha.AutoSize = True
        Me.CBFecha.Location = New System.Drawing.Point(728, 16)
        Me.CBFecha.Name = "CBFecha"
        Me.CBFecha.Size = New System.Drawing.Size(15, 14)
        Me.CBFecha.TabIndex = 15
        Me.CBFecha.UseVisualStyleBackColor = True
        '
        'FechaHasta
        '
        Me.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaHasta.Location = New System.Drawing.Point(912, 56)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(77, 20)
        Me.FechaHasta.TabIndex = 16
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(736, 56)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(38, 13)
        Me.LDesde.TabIndex = 17
        Me.LDesde.Text = "Desde"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(872, 56)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(35, 13)
        Me.LHasta.TabIndex = 18
        Me.LHasta.Text = "Hasta"
        '
        'DGVFactura
        '
        Me.DGVFactura.AllowUserToAddRows = False
        Me.DGVFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVFactura.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFactura.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVFactura.Location = New System.Drawing.Point(0, 48)
        Me.DGVFactura.Name = "DGVFactura"
        Me.DGVFactura.RowHeadersVisible = False
        Me.DGVFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFactura.Size = New System.Drawing.Size(560, 344)
        Me.DGVFactura.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Factura"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.DGVFactura)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(8, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 392)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.DGVDetalle)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(608, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 392)
        Me.Panel2.TabIndex = 23
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        Me.DGVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDetalle.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVDetalle.Location = New System.Drawing.Point(0, 48)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersVisible = False
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(568, 344)
        Me.DGVDetalle.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Detalle Factura"
        '
        'TDniCliente
        '
        Me.TDniCliente.Location = New System.Drawing.Point(192, 48)
        Me.TDniCliente.Name = "TDniCliente"
        Me.TDniCliente.Size = New System.Drawing.Size(152, 20)
        Me.TDniCliente.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nombre"
        '
        'CBNombreCliente
        '
        Me.CBNombreCliente.AutoSize = True
        Me.CBNombreCliente.Location = New System.Drawing.Point(104, 16)
        Me.CBNombreCliente.Name = "CBNombreCliente"
        Me.CBNombreCliente.Size = New System.Drawing.Size(15, 14)
        Me.CBNombreCliente.TabIndex = 29
        Me.CBNombreCliente.UseVisualStyleBackColor = True
        '
        'CategoriaProductoBindingSource
        '
        Me.CategoriaProductoBindingSource.DataMember = "Categoria_Producto"
        Me.CategoriaProductoBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet8
        '
        'BaseDeDatosProyectoDataSet8
        '
        Me.BaseDeDatosProyectoDataSet8.DataSetName = "BaseDeDatosProyectoDataSet8"
        Me.BaseDeDatosProyectoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Categoria_ProductoTableAdapter
        '
        Me.Categoria_ProductoTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "DNI"
        '
        'CBDniCliente
        '
        Me.CBDniCliente.AutoSize = True
        Me.CBDniCliente.Location = New System.Drawing.Point(104, 48)
        Me.CBDniCliente.Name = "CBDniCliente"
        Me.CBDniCliente.Size = New System.Drawing.Size(15, 14)
        Me.CBDniCliente.TabIndex = 32
        Me.CBDniCliente.UseVisualStyleBackColor = True
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(1048, 88)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(108, 23)
        Me.BLimpiar.TabIndex = 39
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'LDniEmpleado
        '
        Me.LDniEmpleado.AutoSize = True
        Me.LDniEmpleado.Location = New System.Drawing.Point(496, 48)
        Me.LDniEmpleado.Name = "LDniEmpleado"
        Me.LDniEmpleado.Size = New System.Drawing.Size(26, 13)
        Me.LDniEmpleado.TabIndex = 47
        Me.LDniEmpleado.Text = "DNI"
        '
        'CBDniEmpleado
        '
        Me.CBDniEmpleado.AutoSize = True
        Me.CBDniEmpleado.Location = New System.Drawing.Point(472, 48)
        Me.CBDniEmpleado.Name = "CBDniEmpleado"
        Me.CBDniEmpleado.Size = New System.Drawing.Size(15, 14)
        Me.CBDniEmpleado.TabIndex = 46
        Me.CBDniEmpleado.UseVisualStyleBackColor = True
        '
        'LNombreEmpleado
        '
        Me.LNombreEmpleado.AutoSize = True
        Me.LNombreEmpleado.Location = New System.Drawing.Point(496, 16)
        Me.LNombreEmpleado.Name = "LNombreEmpleado"
        Me.LNombreEmpleado.Size = New System.Drawing.Size(44, 13)
        Me.LNombreEmpleado.TabIndex = 45
        Me.LNombreEmpleado.Text = "Nombre"
        '
        'CBNombreEmpleado
        '
        Me.CBNombreEmpleado.AutoSize = True
        Me.CBNombreEmpleado.Location = New System.Drawing.Point(472, 16)
        Me.CBNombreEmpleado.Name = "CBNombreEmpleado"
        Me.CBNombreEmpleado.Size = New System.Drawing.Size(15, 14)
        Me.CBNombreEmpleado.TabIndex = 44
        Me.CBNombreEmpleado.UseVisualStyleBackColor = True
        '
        'TDniEmpleado
        '
        Me.TDniEmpleado.Location = New System.Drawing.Point(560, 48)
        Me.TDniEmpleado.Name = "TDniEmpleado"
        Me.TDniEmpleado.Size = New System.Drawing.Size(152, 20)
        Me.TDniEmpleado.TabIndex = 43
        '
        'CBEmpleado
        '
        Me.CBEmpleado.AutoSize = True
        Me.CBEmpleado.Location = New System.Drawing.Point(384, 16)
        Me.CBEmpleado.Name = "CBEmpleado"
        Me.CBEmpleado.Size = New System.Drawing.Size(15, 14)
        Me.CBEmpleado.TabIndex = 42
        Me.CBEmpleado.UseVisualStyleBackColor = True
        '
        'TNombreEmpleado
        '
        Me.TNombreEmpleado.Location = New System.Drawing.Point(560, 16)
        Me.TNombreEmpleado.Name = "TNombreEmpleado"
        Me.TNombreEmpleado.Size = New System.Drawing.Size(152, 20)
        Me.TNombreEmpleado.TabIndex = 41
        '
        'LEmpleado
        '
        Me.LEmpleado.AutoSize = True
        Me.LEmpleado.Location = New System.Drawing.Point(408, 16)
        Me.LEmpleado.Name = "LEmpleado"
        Me.LEmpleado.Size = New System.Drawing.Size(54, 13)
        Me.LEmpleado.TabIndex = 40
        Me.LEmpleado.Text = "Empleado"
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Crimson
        Me.LENumeros.Location = New System.Drawing.Point(352, 72)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(128, 13)
        Me.LENumeros.TabIndex = 48
        Me.LENumeros.Text = "Solo se permiten números"
        '
        'ListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.LENumeros)
        Me.Controls.Add(Me.LDniEmpleado)
        Me.Controls.Add(Me.CBDniEmpleado)
        Me.Controls.Add(Me.LNombreEmpleado)
        Me.Controls.Add(Me.CBNombreEmpleado)
        Me.Controls.Add(Me.TDniEmpleado)
        Me.Controls.Add(Me.CBEmpleado)
        Me.Controls.Add(Me.TNombreEmpleado)
        Me.Controls.Add(Me.LEmpleado)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBDniCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBNombreCliente)
        Me.Controls.Add(Me.TDniCliente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.FechaHasta)
        Me.Controls.Add(Me.CBFecha)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.CBCLiente)
        Me.Controls.Add(Me.FechaDesde)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.TNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BImprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarVentas"
        Me.Text = "ListarVentas"
        CType(Me.DGVFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BImprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TNombreCliente As TextBox
    Friend WithEvents LFecha As Label
    Friend WithEvents FechaDesde As DateTimePicker
    Friend WithEvents CBCLiente As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBFecha As CheckBox
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents LDesde As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents DGVFactura As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TDniCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBNombreCliente As CheckBox
    Friend WithEvents BaseDeDatosProyectoDataSet8 As BaseDeDatosProyectoDataSet8
    Friend WithEvents CategoriaProductoBindingSource As BindingSource
    Friend WithEvents Categoria_ProductoTableAdapter As BaseDeDatosProyectoDataSet8TableAdapters.Categoria_ProductoTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents CBDniCliente As CheckBox
    Friend WithEvents BLimpiar As Button
    Friend WithEvents LDniEmpleado As Label
    Friend WithEvents CBDniEmpleado As CheckBox
    Friend WithEvents LNombreEmpleado As Label
    Friend WithEvents CBNombreEmpleado As CheckBox
    Friend WithEvents TDniEmpleado As TextBox
    Friend WithEvents CBEmpleado As CheckBox
    Friend WithEvents TNombreEmpleado As TextBox
    Friend WithEvents LEmpleado As Label
    Friend WithEvents LENumeros As Label
End Class
