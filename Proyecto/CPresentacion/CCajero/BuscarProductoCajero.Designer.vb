<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProductoCajero
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.CBCodigo = New System.Windows.Forms.CheckBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.CBTalle = New System.Windows.Forms.CheckBox()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.DroplistTalle = New System.Windows.Forms.ComboBox()
        Me.CategoriaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet5 = New Proyecto.BaseDeDatosProyectoDataSet5()
        Me.CBMarca = New System.Windows.Forms.CheckBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.DroplistMarca = New System.Windows.Forms.ComboBox()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.CBHabilitado = New System.Windows.Forms.CheckBox()
        Me.LHabilitado = New System.Windows.Forms.Label()
        Me.DroplistPrecio = New System.Windows.Forms.ComboBox()
        Me.CBPrecioProducto = New System.Windows.Forms.CheckBox()
        Me.CBCategoria = New System.Windows.Forms.CheckBox()
        Me.CBNombre = New System.Windows.Forms.CheckBox()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.DroplistCategoria = New System.Windows.Forms.ComboBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Categoria_ProductoTableAdapter = New Proyecto.BaseDeDatosProyectoDataSet5TableAdapters.Categoria_ProductoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(800, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BLimpiar)
        Me.Panel1.Controls.Add(Me.CBCodigo)
        Me.Panel1.Controls.Add(Me.TCodigo)
        Me.Panel1.Controls.Add(Me.LCodigo)
        Me.Panel1.Controls.Add(Me.CBTalle)
        Me.Panel1.Controls.Add(Me.LTalle)
        Me.Panel1.Controls.Add(Me.DroplistTalle)
        Me.Panel1.Controls.Add(Me.CBMarca)
        Me.Panel1.Controls.Add(Me.LMarca)
        Me.Panel1.Controls.Add(Me.DroplistMarca)
        Me.Panel1.Controls.Add(Me.BSeleccionar)
        Me.Panel1.Controls.Add(Me.LENumeros)
        Me.Panel1.Controls.Add(Me.CBHabilitado)
        Me.Panel1.Controls.Add(Me.LHabilitado)
        Me.Panel1.Controls.Add(Me.DroplistPrecio)
        Me.Panel1.Controls.Add(Me.CBPrecioProducto)
        Me.Panel1.Controls.Add(Me.CBCategoria)
        Me.Panel1.Controls.Add(Me.CBNombre)
        Me.Panel1.Controls.Add(Me.LPrecio)
        Me.Panel1.Controls.Add(Me.TPrecio)
        Me.Panel1.Controls.Add(Me.BBuscar)
        Me.Panel1.Controls.Add(Me.LCategoria)
        Me.Panel1.Controls.Add(Me.DroplistCategoria)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(624, 80)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(158, 23)
        Me.BLimpiar.TabIndex = 65
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'CBCodigo
        '
        Me.CBCodigo.AutoSize = True
        Me.CBCodigo.Location = New System.Drawing.Point(312, 48)
        Me.CBCodigo.Name = "CBCodigo"
        Me.CBCodigo.Size = New System.Drawing.Size(15, 14)
        Me.CBCodigo.TabIndex = 64
        Me.CBCodigo.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(400, 48)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(160, 20)
        Me.TCodigo.TabIndex = 63
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Location = New System.Drawing.Point(336, 48)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LCodigo.TabIndex = 62
        Me.LCodigo.Text = "Codigo"
        '
        'CBTalle
        '
        Me.CBTalle.AutoSize = True
        Me.CBTalle.Location = New System.Drawing.Point(16, 80)
        Me.CBTalle.Name = "CBTalle"
        Me.CBTalle.Size = New System.Drawing.Size(15, 14)
        Me.CBTalle.TabIndex = 61
        Me.CBTalle.UseVisualStyleBackColor = True
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.Location = New System.Drawing.Point(40, 80)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(30, 13)
        Me.LTalle.TabIndex = 60
        Me.LTalle.Text = "Talle"
        '
        'DroplistTalle
        '
        Me.DroplistTalle.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "descripcion_categoria", True))
        Me.DroplistTalle.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistTalle.DisplayMember = "descripcion_categoria"
        Me.DroplistTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistTalle.FormattingEnabled = True
        Me.DroplistTalle.Location = New System.Drawing.Point(104, 80)
        Me.DroplistTalle.Name = "DroplistTalle"
        Me.DroplistTalle.Size = New System.Drawing.Size(160, 21)
        Me.DroplistTalle.TabIndex = 59
        Me.DroplistTalle.ValueMember = "descripcion_categoria"
        '
        'CategoriaProductoBindingSource
        '
        Me.CategoriaProductoBindingSource.DataMember = "Categoria_Producto"
        Me.CategoriaProductoBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet5
        '
        'BaseDeDatosProyectoDataSet5
        '
        Me.BaseDeDatosProyectoDataSet5.DataSetName = "BaseDeDatosProyectoDataSet5"
        Me.BaseDeDatosProyectoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBMarca
        '
        Me.CBMarca.AutoSize = True
        Me.CBMarca.Location = New System.Drawing.Point(16, 48)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(15, 14)
        Me.CBMarca.TabIndex = 58
        Me.CBMarca.UseVisualStyleBackColor = True
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Location = New System.Drawing.Point(40, 48)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(37, 13)
        Me.LMarca.TabIndex = 57
        Me.LMarca.Text = "Marca"
        '
        'DroplistMarca
        '
        Me.DroplistMarca.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "descripcion_categoria", True))
        Me.DroplistMarca.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistMarca.DisplayMember = "descripcion_categoria"
        Me.DroplistMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistMarca.FormattingEnabled = True
        Me.DroplistMarca.Location = New System.Drawing.Point(104, 48)
        Me.DroplistMarca.Name = "DroplistMarca"
        Me.DroplistMarca.Size = New System.Drawing.Size(158, 21)
        Me.DroplistMarca.TabIndex = 56
        Me.DroplistMarca.ValueMember = "descripcion_categoria"
        '
        'BSeleccionar
        '
        Me.BSeleccionar.Location = New System.Drawing.Point(624, 48)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(158, 23)
        Me.BSeleccionar.TabIndex = 55
        Me.BSeleccionar.Text = "Seleccionar Producto"
        Me.BSeleccionar.UseVisualStyleBackColor = True
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(408, 104)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(111, 13)
        Me.LENumeros.TabIndex = 54
        Me.LENumeros.Text = "Solo ingresar numeros"
        '
        'CBHabilitado
        '
        Me.CBHabilitado.AutoSize = True
        Me.CBHabilitado.Checked = True
        Me.CBHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHabilitado.Location = New System.Drawing.Point(16, 104)
        Me.CBHabilitado.Name = "CBHabilitado"
        Me.CBHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.CBHabilitado.TabIndex = 53
        Me.CBHabilitado.UseVisualStyleBackColor = True
        '
        'LHabilitado
        '
        Me.LHabilitado.AutoSize = True
        Me.LHabilitado.Location = New System.Drawing.Point(48, 104)
        Me.LHabilitado.Name = "LHabilitado"
        Me.LHabilitado.Size = New System.Drawing.Size(54, 13)
        Me.LHabilitado.TabIndex = 52
        Me.LHabilitado.Text = "Habilitado"
        '
        'DroplistPrecio
        '
        Me.DroplistPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistPrecio.FormattingEnabled = True
        Me.DroplistPrecio.Items.AddRange(New Object() {"Menor a", "Mayor a"})
        Me.DroplistPrecio.Location = New System.Drawing.Point(400, 80)
        Me.DroplistPrecio.Name = "DroplistPrecio"
        Me.DroplistPrecio.Size = New System.Drawing.Size(76, 21)
        Me.DroplistPrecio.TabIndex = 47
        '
        'CBPrecioProducto
        '
        Me.CBPrecioProducto.AutoSize = True
        Me.CBPrecioProducto.Location = New System.Drawing.Point(312, 80)
        Me.CBPrecioProducto.Name = "CBPrecioProducto"
        Me.CBPrecioProducto.Size = New System.Drawing.Size(15, 14)
        Me.CBPrecioProducto.TabIndex = 46
        Me.CBPrecioProducto.UseVisualStyleBackColor = True
        '
        'CBCategoria
        '
        Me.CBCategoria.AutoSize = True
        Me.CBCategoria.Location = New System.Drawing.Point(16, 16)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(15, 14)
        Me.CBCategoria.TabIndex = 45
        Me.CBCategoria.UseVisualStyleBackColor = True
        '
        'CBNombre
        '
        Me.CBNombre.AutoSize = True
        Me.CBNombre.Location = New System.Drawing.Point(312, 16)
        Me.CBNombre.Name = "CBNombre"
        Me.CBNombre.Size = New System.Drawing.Size(15, 14)
        Me.CBNombre.TabIndex = 44
        Me.CBNombre.UseVisualStyleBackColor = True
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(336, 80)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LPrecio.TabIndex = 43
        Me.LPrecio.Text = "Precio"
        '
        'TPrecio
        '
        Me.TPrecio.Location = New System.Drawing.Point(480, 80)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(80, 20)
        Me.TPrecio.TabIndex = 42
        Me.TPrecio.Text = "0"
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(624, 16)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(158, 23)
        Me.BBuscar.TabIndex = 41
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(40, 16)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(52, 13)
        Me.LCategoria.TabIndex = 40
        Me.LCategoria.Text = "Categoria"
        '
        'DroplistCategoria
        '
        Me.DroplistCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "descripcion_categoria", True))
        Me.DroplistCategoria.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistCategoria.DisplayMember = "descripcion_categoria"
        Me.DroplistCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistCategoria.FormattingEnabled = True
        Me.DroplistCategoria.Location = New System.Drawing.Point(104, 16)
        Me.DroplistCategoria.Name = "DroplistCategoria"
        Me.DroplistCategoria.Size = New System.Drawing.Size(158, 21)
        Me.DroplistCategoria.TabIndex = 39
        Me.DroplistCategoria.ValueMember = "id_categoria"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(400, 16)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(158, 20)
        Me.TNombre.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre"
        '
        'Categoria_ProductoTableAdapter
        '
        Me.Categoria_ProductoTableAdapter.ClearBeforeFill = True
        '
        'BuscarProductoCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscarProductoCajero"
        Me.ShowIcon = False
        Me.Text = "Buscar Producto Cajero"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBHabilitado As CheckBox
    Friend WithEvents LHabilitado As Label
    Friend WithEvents DroplistPrecio As ComboBox
    Friend WithEvents CBPrecioProducto As CheckBox
    Friend WithEvents CBCategoria As CheckBox
    Friend WithEvents CBNombre As CheckBox
    Friend WithEvents LPrecio As Label
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents LCategoria As Label
    Friend WithEvents DroplistCategoria As ComboBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BaseDeDatosProyectoDataSet5 As BaseDeDatosProyectoDataSet5
    Friend WithEvents CategoriaProductoBindingSource As BindingSource
    Friend WithEvents Categoria_ProductoTableAdapter As BaseDeDatosProyectoDataSet5TableAdapters.Categoria_ProductoTableAdapter
    Friend WithEvents LENumeros As Label
    Friend WithEvents BSeleccionar As Button
    Friend WithEvents CBCodigo As CheckBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents LCodigo As Label
    Friend WithEvents CBTalle As CheckBox
    Friend WithEvents LTalle As Label
    Friend WithEvents DroplistTalle As ComboBox
    Friend WithEvents CBMarca As CheckBox
    Friend WithEvents LMarca As Label
    Friend WithEvents DroplistMarca As ComboBox
    Friend WithEvents BLimpiar As Button
End Class
