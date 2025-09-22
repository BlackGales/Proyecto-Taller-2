<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.DroplistCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet2 = New Proyecto.BaseDeDatosProyectoDataSet2()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.ODSeleccionarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TStockMin = New System.Windows.Forms.TextBox()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.Categoria_ProductoTableAdapter = New Proyecto.BaseDeDatosProyectoDataSet2TableAdapters.Categoria_ProductoTableAdapter()
        Me.CBHabilitado = New System.Windows.Forms.CheckBox()
        Me.LENumeros2 = New System.Windows.Forms.Label()
        Me.CBHabilitadoBuscar = New System.Windows.Forms.CheckBox()
        Me.LHabilitado = New System.Windows.Forms.Label()
        Me.DroplistStock = New System.Windows.Forms.ComboBox()
        Me.CBStock = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TStockBuscar = New System.Windows.Forms.TextBox()
        Me.DroplistPrecio = New System.Windows.Forms.ComboBox()
        Me.CBPrecio = New System.Windows.Forms.CheckBox()
        Me.CBCategoria = New System.Windows.Forms.CheckBox()
        Me.CBNombre = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TPrecioBuscar = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DroplistCategoriaBuscar = New System.Windows.Forms.ComboBox()
        Me.TNombreBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.DroplistTalle = New System.Windows.Forms.ComboBox()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.DroplistMarca = New System.Windows.Forms.ComboBox()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.TDescripcion = New System.Windows.Forms.RichTextBox()
        Me.DroplistMarcaBuscar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DroplistTalleBuscar = New System.Windows.Forms.ComboBox()
        Me.CBMarca = New System.Windows.Forms.CheckBox()
        Me.CBTalle = New System.Windows.Forms.CheckBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.TCodigoBuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBCodigo = New System.Windows.Forms.CheckBox()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(80, 40)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(158, 20)
        Me.TNombre.TabIndex = 1
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(272, 8)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LPrecio.TabIndex = 2
        Me.LPrecio.Text = "Precio"
        '
        'TPrecio
        '
        Me.TPrecio.Location = New System.Drawing.Point(344, 8)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(158, 20)
        Me.TPrecio.TabIndex = 3
        '
        'DroplistCategoria
        '
        Me.DroplistCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistCategoria.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistCategoria.DisplayMember = "descripcion_categoria"
        Me.DroplistCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistCategoria.FormattingEnabled = True
        Me.DroplistCategoria.Location = New System.Drawing.Point(80, 72)
        Me.DroplistCategoria.Name = "DroplistCategoria"
        Me.DroplistCategoria.Size = New System.Drawing.Size(158, 21)
        Me.DroplistCategoria.TabIndex = 2
        Me.DroplistCategoria.ValueMember = "id_categoria"
        '
        'CategoriaProductoBindingSource
        '
        Me.CategoriaProductoBindingSource.DataMember = "Categoria_Producto"
        Me.CategoriaProductoBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet2
        '
        'BaseDeDatosProyectoDataSet2
        '
        Me.BaseDeDatosProyectoDataSet2.DataSetName = "BaseDeDatosProyectoDataSet2"
        Me.BaseDeDatosProyectoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(8, 72)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(52, 13)
        Me.LCategoria.TabIndex = 6
        Me.LCategoria.Text = "Categoria"
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.LimeGreen
        Me.BAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAgregar.FlatAppearance.BorderSize = 10
        Me.BAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BAgregar.Location = New System.Drawing.Point(528, 72)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(144, 24)
        Me.BAgregar.TabIndex = 7
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(0, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1184, 281)
        Me.DataGridView1.TabIndex = 10
        '
        'TStockMin
        '
        Me.TStockMin.Location = New System.Drawing.Point(424, 72)
        Me.TStockMin.Name = "TStockMin"
        Me.TStockMin.Size = New System.Drawing.Size(80, 20)
        Me.TStockMin.TabIndex = 5
        '
        'TStock
        '
        Me.TStock.Location = New System.Drawing.Point(424, 40)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(80, 20)
        Me.TStock.TabIndex = 4
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(272, 40)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(35, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'LStockMin
        '
        Me.LStockMin.AutoSize = True
        Me.LStockMin.Location = New System.Drawing.Point(272, 72)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(71, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Stock Minimo"
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BEditar.Location = New System.Drawing.Point(528, 152)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(144, 24)
        Me.BEditar.TabIndex = 8
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(272, 104)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(128, 13)
        Me.LENumeros.TabIndex = 18
        Me.LENumeros.Text = "Solo se permiten números"
        Me.LENumeros.Visible = False
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.Gold
        Me.BLimpiar.Location = New System.Drawing.Point(528, 112)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(144, 24)
        Me.BLimpiar.TabIndex = 9
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'Categoria_ProductoTableAdapter
        '
        Me.Categoria_ProductoTableAdapter.ClearBeforeFill = True
        '
        'CBHabilitado
        '
        Me.CBHabilitado.AutoSize = True
        Me.CBHabilitado.Checked = True
        Me.CBHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHabilitado.Location = New System.Drawing.Point(272, 136)
        Me.CBHabilitado.Name = "CBHabilitado"
        Me.CBHabilitado.Size = New System.Drawing.Size(73, 17)
        Me.CBHabilitado.TabIndex = 6
        Me.CBHabilitado.Text = "Habilitado"
        Me.CBHabilitado.UseVisualStyleBackColor = True
        '
        'LENumeros2
        '
        Me.LENumeros2.AutoSize = True
        Me.LENumeros2.ForeColor = System.Drawing.Color.Red
        Me.LENumeros2.Location = New System.Drawing.Point(1000, 232)
        Me.LENumeros2.Name = "LENumeros2"
        Me.LENumeros2.Size = New System.Drawing.Size(111, 13)
        Me.LENumeros2.TabIndex = 55
        Me.LENumeros2.Text = "Solo ingresar numeros"
        '
        'CBHabilitadoBuscar
        '
        Me.CBHabilitadoBuscar.AutoSize = True
        Me.CBHabilitadoBuscar.Checked = True
        Me.CBHabilitadoBuscar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHabilitadoBuscar.Location = New System.Drawing.Point(872, 232)
        Me.CBHabilitadoBuscar.Name = "CBHabilitadoBuscar"
        Me.CBHabilitadoBuscar.Size = New System.Drawing.Size(15, 14)
        Me.CBHabilitadoBuscar.TabIndex = 54
        Me.CBHabilitadoBuscar.UseVisualStyleBackColor = True
        '
        'LHabilitado
        '
        Me.LHabilitado.AutoSize = True
        Me.LHabilitado.Location = New System.Drawing.Point(896, 232)
        Me.LHabilitado.Name = "LHabilitado"
        Me.LHabilitado.Size = New System.Drawing.Size(54, 13)
        Me.LHabilitado.TabIndex = 53
        Me.LHabilitado.Text = "Habilitado"
        '
        'DroplistStock
        '
        Me.DroplistStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistStock.FormattingEnabled = True
        Me.DroplistStock.Items.AddRange(New Object() {"Menor a", "Mayor a"})
        Me.DroplistStock.Location = New System.Drawing.Point(960, 200)
        Me.DroplistStock.Name = "DroplistStock"
        Me.DroplistStock.Size = New System.Drawing.Size(80, 21)
        Me.DroplistStock.TabIndex = 42
        '
        'CBStock
        '
        Me.CBStock.AutoSize = True
        Me.CBStock.Location = New System.Drawing.Point(872, 200)
        Me.CBStock.Name = "CBStock"
        Me.CBStock.Size = New System.Drawing.Size(15, 14)
        Me.CBStock.TabIndex = 52
        Me.CBStock.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(896, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Stock"
        '
        'TStockBuscar
        '
        Me.TStockBuscar.Location = New System.Drawing.Point(1056, 200)
        Me.TStockBuscar.Name = "TStockBuscar"
        Me.TStockBuscar.Size = New System.Drawing.Size(72, 20)
        Me.TStockBuscar.TabIndex = 43
        Me.TStockBuscar.Text = "0"
        '
        'DroplistPrecio
        '
        Me.DroplistPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistPrecio.FormattingEnabled = True
        Me.DroplistPrecio.Items.AddRange(New Object() {"Menor a", "Mayor a"})
        Me.DroplistPrecio.Location = New System.Drawing.Point(960, 168)
        Me.DroplistPrecio.Name = "DroplistPrecio"
        Me.DroplistPrecio.Size = New System.Drawing.Size(80, 21)
        Me.DroplistPrecio.TabIndex = 40
        '
        'CBPrecio
        '
        Me.CBPrecio.AutoSize = True
        Me.CBPrecio.Location = New System.Drawing.Point(872, 168)
        Me.CBPrecio.Name = "CBPrecio"
        Me.CBPrecio.Size = New System.Drawing.Size(15, 14)
        Me.CBPrecio.TabIndex = 50
        Me.CBPrecio.UseVisualStyleBackColor = True
        '
        'CBCategoria
        '
        Me.CBCategoria.AutoSize = True
        Me.CBCategoria.Location = New System.Drawing.Point(872, 72)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(15, 14)
        Me.CBCategoria.TabIndex = 49
        Me.CBCategoria.UseVisualStyleBackColor = True
        '
        'CBNombre
        '
        Me.CBNombre.AutoSize = True
        Me.CBNombre.Location = New System.Drawing.Point(872, 40)
        Me.CBNombre.Name = "CBNombre"
        Me.CBNombre.Size = New System.Drawing.Size(15, 14)
        Me.CBNombre.TabIndex = 48
        Me.CBNombre.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(896, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Precio"
        '
        'TPrecioBuscar
        '
        Me.TPrecioBuscar.Location = New System.Drawing.Point(1056, 168)
        Me.TPrecioBuscar.Name = "TPrecioBuscar"
        Me.TPrecioBuscar.Size = New System.Drawing.Size(72, 20)
        Me.TPrecioBuscar.TabIndex = 41
        Me.TPrecioBuscar.Text = "0"
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(960, 256)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(168, 23)
        Me.BBuscar.TabIndex = 44
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(896, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Categoria"
        '
        'DroplistCategoriaBuscar
        '
        Me.DroplistCategoriaBuscar.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistCategoriaBuscar.DisplayMember = "descripcion_categoria"
        Me.DroplistCategoriaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistCategoriaBuscar.FormattingEnabled = True
        Me.DroplistCategoriaBuscar.Location = New System.Drawing.Point(960, 72)
        Me.DroplistCategoriaBuscar.Name = "DroplistCategoriaBuscar"
        Me.DroplistCategoriaBuscar.Size = New System.Drawing.Size(168, 21)
        Me.DroplistCategoriaBuscar.TabIndex = 39
        Me.DroplistCategoriaBuscar.ValueMember = "descripcion_categoria"
        '
        'TNombreBuscar
        '
        Me.TNombreBuscar.Location = New System.Drawing.Point(960, 40)
        Me.TNombreBuscar.Name = "TNombreBuscar"
        Me.TNombreBuscar.Size = New System.Drawing.Size(168, 20)
        Me.TNombreBuscar.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(896, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Nombre"
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BEliminar.Location = New System.Drawing.Point(528, 192)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(144, 24)
        Me.BEliminar.TabIndex = 56
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'DroplistTalle
        '
        Me.DroplistTalle.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistTalle.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistTalle.DisplayMember = "descripcion_categoria"
        Me.DroplistTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistTalle.FormattingEnabled = True
        Me.DroplistTalle.Location = New System.Drawing.Point(80, 104)
        Me.DroplistTalle.Name = "DroplistTalle"
        Me.DroplistTalle.Size = New System.Drawing.Size(158, 21)
        Me.DroplistTalle.TabIndex = 57
        Me.DroplistTalle.ValueMember = "id_categoria"
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.Location = New System.Drawing.Point(8, 104)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(30, 13)
        Me.LTalle.TabIndex = 58
        Me.LTalle.Text = "Talle"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Location = New System.Drawing.Point(8, 136)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(37, 13)
        Me.LMarca.TabIndex = 59
        Me.LMarca.Text = "Marca"
        '
        'DroplistMarca
        '
        Me.DroplistMarca.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistMarca.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistMarca.DisplayMember = "descripcion_categoria"
        Me.DroplistMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistMarca.FormattingEnabled = True
        Me.DroplistMarca.Location = New System.Drawing.Point(80, 136)
        Me.DroplistMarca.Name = "DroplistMarca"
        Me.DroplistMarca.Size = New System.Drawing.Size(158, 21)
        Me.DroplistMarca.TabIndex = 60
        Me.DroplistMarca.ValueMember = "id_categoria"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Location = New System.Drawing.Point(8, 176)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LDescripcion.TabIndex = 61
        Me.LDescripcion.Text = "Descripcion"
        '
        'TDescripcion
        '
        Me.TDescripcion.Location = New System.Drawing.Point(80, 168)
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.Size = New System.Drawing.Size(424, 96)
        Me.TDescripcion.TabIndex = 62
        Me.TDescripcion.Text = ""
        '
        'DroplistMarcaBuscar
        '
        Me.DroplistMarcaBuscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistMarcaBuscar.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistMarcaBuscar.DisplayMember = "descripcion_categoria"
        Me.DroplistMarcaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistMarcaBuscar.FormattingEnabled = True
        Me.DroplistMarcaBuscar.Location = New System.Drawing.Point(960, 136)
        Me.DroplistMarcaBuscar.Name = "DroplistMarcaBuscar"
        Me.DroplistMarcaBuscar.Size = New System.Drawing.Size(168, 21)
        Me.DroplistMarcaBuscar.TabIndex = 66
        Me.DroplistMarcaBuscar.ValueMember = "id_categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(896, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Marca"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(896, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Talle"
        '
        'DroplistTalleBuscar
        '
        Me.DroplistTalleBuscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistTalleBuscar.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistTalleBuscar.DisplayMember = "descripcion_categoria"
        Me.DroplistTalleBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistTalleBuscar.FormattingEnabled = True
        Me.DroplistTalleBuscar.Location = New System.Drawing.Point(960, 104)
        Me.DroplistTalleBuscar.Name = "DroplistTalleBuscar"
        Me.DroplistTalleBuscar.Size = New System.Drawing.Size(168, 21)
        Me.DroplistTalleBuscar.TabIndex = 63
        Me.DroplistTalleBuscar.ValueMember = "id_categoria"
        '
        'CBMarca
        '
        Me.CBMarca.AutoSize = True
        Me.CBMarca.Location = New System.Drawing.Point(872, 136)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(15, 14)
        Me.CBMarca.TabIndex = 67
        Me.CBMarca.UseVisualStyleBackColor = True
        '
        'CBTalle
        '
        Me.CBTalle.AutoSize = True
        Me.CBTalle.Location = New System.Drawing.Point(872, 104)
        Me.CBTalle.Name = "CBTalle"
        Me.CBTalle.Size = New System.Drawing.Size(15, 14)
        Me.CBTalle.TabIndex = 67
        Me.CBTalle.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(80, 8)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(158, 20)
        Me.TCodigo.TabIndex = 69
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Location = New System.Drawing.Point(8, 8)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LCodigo.TabIndex = 68
        Me.LCodigo.Text = "Codigo"
        '
        'TCodigoBuscar
        '
        Me.TCodigoBuscar.Location = New System.Drawing.Point(960, 8)
        Me.TCodigoBuscar.Name = "TCodigoBuscar"
        Me.TCodigoBuscar.Size = New System.Drawing.Size(168, 20)
        Me.TCodigoBuscar.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(896, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Codigo"
        '
        'CBCodigo
        '
        Me.CBCodigo.AutoSize = True
        Me.CBCodigo.Location = New System.Drawing.Point(872, 8)
        Me.CBCodigo.Name = "CBCodigo"
        Me.CBCodigo.Size = New System.Drawing.Size(15, 14)
        Me.CBCodigo.TabIndex = 72
        Me.CBCodigo.UseVisualStyleBackColor = True
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBCodigo)
        Me.Controls.Add(Me.TCodigoBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.CBTalle)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.DroplistMarcaBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DroplistTalleBuscar)
        Me.Controls.Add(Me.TDescripcion)
        Me.Controls.Add(Me.LDescripcion)
        Me.Controls.Add(Me.DroplistMarca)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LTalle)
        Me.Controls.Add(Me.DroplistTalle)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.LENumeros2)
        Me.Controls.Add(Me.CBHabilitadoBuscar)
        Me.Controls.Add(Me.LHabilitado)
        Me.Controls.Add(Me.DroplistStock)
        Me.Controls.Add(Me.CBStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TStockBuscar)
        Me.Controls.Add(Me.DroplistPrecio)
        Me.Controls.Add(Me.CBPrecio)
        Me.Controls.Add(Me.CBCategoria)
        Me.Controls.Add(Me.CBNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TPrecioBuscar)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DroplistCategoriaBuscar)
        Me.Controls.Add(Me.TNombreBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBHabilitado)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.LENumeros)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.LStockMin)
        Me.Controls.Add(Me.LStock)
        Me.Controls.Add(Me.TStock)
        Me.Controls.Add(Me.TStockMin)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.DroplistCategoria)
        Me.Controls.Add(Me.TPrecio)
        Me.Controls.Add(Me.LPrecio)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarProducto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LPrecio As Label
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents DroplistCategoria As ComboBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents ODSeleccionarImagen As OpenFileDialog
    Friend WithEvents BAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TStockMin As TextBox
    Friend WithEvents TStock As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents LStockMin As Label
    Friend WithEvents BEditar As Button
    Friend WithEvents LENumeros As Label
    Friend WithEvents BLimpiar As Button
    Friend WithEvents BaseDeDatosProyectoDataSet2 As BaseDeDatosProyectoDataSet2
    Friend WithEvents CategoriaProductoBindingSource As BindingSource
    Friend WithEvents Categoria_ProductoTableAdapter As BaseDeDatosProyectoDataSet2TableAdapters.Categoria_ProductoTableAdapter
    Friend WithEvents CBHabilitado As CheckBox
    Friend WithEvents LENumeros2 As Label
    Friend WithEvents CBHabilitadoBuscar As CheckBox
    Friend WithEvents LHabilitado As Label
    Friend WithEvents DroplistStock As ComboBox
    Friend WithEvents CBStock As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TStockBuscar As TextBox
    Friend WithEvents DroplistPrecio As ComboBox
    Friend WithEvents CBPrecio As CheckBox
    Friend WithEvents CBCategoria As CheckBox
    Friend WithEvents CBNombre As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TPrecioBuscar As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DroplistCategoriaBuscar As ComboBox
    Friend WithEvents TNombreBuscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BEliminar As Button
    Friend WithEvents DroplistTalle As ComboBox
    Friend WithEvents LTalle As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents DroplistMarca As ComboBox
    Friend WithEvents LDescripcion As Label
    Friend WithEvents TDescripcion As RichTextBox
    Friend WithEvents DroplistMarcaBuscar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DroplistTalleBuscar As ComboBox
    Friend WithEvents CBMarca As CheckBox
    Friend WithEvents CBTalle As CheckBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents LCodigo As Label
    Friend WithEvents TCodigoBuscar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CBCodigo As CheckBox
End Class
