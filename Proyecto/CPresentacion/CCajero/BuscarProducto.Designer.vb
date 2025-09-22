<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarProducto
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.DroplistCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet4 = New Proyecto.BaseDeDatosProyectoDataSet4()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.CBNombre = New System.Windows.Forms.CheckBox()
        Me.CBCategoria = New System.Windows.Forms.CheckBox()
        Me.DroplistPrecio = New System.Windows.Forms.ComboBox()
        Me.DroplistStock = New System.Windows.Forms.ComboBox()
        Me.CBStock = New System.Windows.Forms.CheckBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LHabilitado = New System.Windows.Forms.Label()
        Me.CBHabilitado = New System.Windows.Forms.CheckBox()
        Me.CBPrecio = New System.Windows.Forms.CheckBox()
        Me.BaseDeDatosProyectoDataSet3 = New Proyecto.BaseDeDatosProyectoDataSet3()
        Me.TipoUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_UsuarioTableAdapter = New Proyecto.BaseDeDatosProyectoDataSet3TableAdapters.Tipo_UsuarioTableAdapter()
        Me.Categoria_ProductoTableAdapter = New Proyecto.BaseDeDatosProyectoDataSet4TableAdapters.Categoria_ProductoTableAdapter()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.CBTalle = New System.Windows.Forms.CheckBox()
        Me.CBMarca = New System.Windows.Forms.CheckBox()
        Me.DroplistMarca = New System.Windows.Forms.ComboBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.DroplistTalle = New System.Windows.Forms.ComboBox()
        Me.CBCodigo = New System.Windows.Forms.CheckBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.LCodigo = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(304, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(880, 561)
        Me.DataGridView1.TabIndex = 11
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(40, 216)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LPrecio.TabIndex = 26
        Me.LPrecio.Text = "Precio"
        '
        'TPrecio
        '
        Me.TPrecio.Location = New System.Drawing.Point(192, 216)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(80, 20)
        Me.TPrecio.TabIndex = 4
        Me.TPrecio.Text = "0"
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(64, 336)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(158, 23)
        Me.BBuscar.TabIndex = 7
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(40, 96)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(52, 13)
        Me.LCategoria.TabIndex = 22
        Me.LCategoria.Text = "Categoria"
        '
        'DroplistCategoria
        '
        Me.DroplistCategoria.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistCategoria.DisplayMember = "descripcion_categoria"
        Me.DroplistCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistCategoria.FormattingEnabled = True
        Me.DroplistCategoria.Location = New System.Drawing.Point(112, 96)
        Me.DroplistCategoria.Name = "DroplistCategoria"
        Me.DroplistCategoria.Size = New System.Drawing.Size(160, 21)
        Me.DroplistCategoria.TabIndex = 2
        Me.DroplistCategoria.ValueMember = "descripcion_categoria"
        '
        'CategoriaProductoBindingSource
        '
        Me.CategoriaProductoBindingSource.DataMember = "Categoria_Producto"
        Me.CategoriaProductoBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet4
        '
        'BaseDeDatosProyectoDataSet4
        '
        Me.BaseDeDatosProyectoDataSet4.DataSetName = "BaseDeDatosProyectoDataSet4"
        Me.BaseDeDatosProyectoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(112, 56)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(160, 20)
        Me.TNombre.TabIndex = 1
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(40, 56)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 17
        Me.LNombre.Text = "Nombre"
        '
        'CBNombre
        '
        Me.CBNombre.AutoSize = True
        Me.CBNombre.Location = New System.Drawing.Point(16, 56)
        Me.CBNombre.Name = "CBNombre"
        Me.CBNombre.Size = New System.Drawing.Size(15, 14)
        Me.CBNombre.TabIndex = 27
        Me.CBNombre.UseVisualStyleBackColor = True
        '
        'CBCategoria
        '
        Me.CBCategoria.AutoSize = True
        Me.CBCategoria.Location = New System.Drawing.Point(16, 96)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(15, 14)
        Me.CBCategoria.TabIndex = 28
        Me.CBCategoria.UseVisualStyleBackColor = True
        '
        'DroplistPrecio
        '
        Me.DroplistPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistPrecio.FormattingEnabled = True
        Me.DroplistPrecio.Items.AddRange(New Object() {"Menor a", "Mayor a"})
        Me.DroplistPrecio.Location = New System.Drawing.Point(112, 216)
        Me.DroplistPrecio.Name = "DroplistPrecio"
        Me.DroplistPrecio.Size = New System.Drawing.Size(64, 21)
        Me.DroplistPrecio.TabIndex = 3
        '
        'DroplistStock
        '
        Me.DroplistStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistStock.FormattingEnabled = True
        Me.DroplistStock.Items.AddRange(New Object() {"Menor a", "Mayor a"})
        Me.DroplistStock.Location = New System.Drawing.Point(112, 256)
        Me.DroplistStock.Name = "DroplistStock"
        Me.DroplistStock.Size = New System.Drawing.Size(64, 21)
        Me.DroplistStock.TabIndex = 5
        '
        'CBStock
        '
        Me.CBStock.AutoSize = True
        Me.CBStock.Location = New System.Drawing.Point(16, 256)
        Me.CBStock.Name = "CBStock"
        Me.CBStock.Size = New System.Drawing.Size(15, 14)
        Me.CBStock.TabIndex = 33
        Me.CBStock.UseVisualStyleBackColor = True
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(40, 256)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(35, 13)
        Me.LStock.TabIndex = 32
        Me.LStock.Text = "Stock"
        '
        'TStock
        '
        Me.TStock.Location = New System.Drawing.Point(192, 256)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(80, 20)
        Me.TStock.TabIndex = 6
        Me.TStock.Text = "0"
        '
        'LHabilitado
        '
        Me.LHabilitado.AutoSize = True
        Me.LHabilitado.Location = New System.Drawing.Point(40, 296)
        Me.LHabilitado.Name = "LHabilitado"
        Me.LHabilitado.Size = New System.Drawing.Size(54, 13)
        Me.LHabilitado.TabIndex = 35
        Me.LHabilitado.Text = "Habilitado"
        '
        'CBHabilitado
        '
        Me.CBHabilitado.AutoSize = True
        Me.CBHabilitado.Checked = True
        Me.CBHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHabilitado.Location = New System.Drawing.Point(16, 296)
        Me.CBHabilitado.Name = "CBHabilitado"
        Me.CBHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.CBHabilitado.TabIndex = 36
        Me.CBHabilitado.UseVisualStyleBackColor = True
        '
        'CBPrecio
        '
        Me.CBPrecio.AutoSize = True
        Me.CBPrecio.Location = New System.Drawing.Point(16, 216)
        Me.CBPrecio.Name = "CBPrecio"
        Me.CBPrecio.Size = New System.Drawing.Size(15, 14)
        Me.CBPrecio.TabIndex = 29
        Me.CBPrecio.UseVisualStyleBackColor = True
        '
        'BaseDeDatosProyectoDataSet3
        '
        Me.BaseDeDatosProyectoDataSet3.DataSetName = "BaseDeDatosProyectoDataSet3"
        Me.BaseDeDatosProyectoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoUsuarioBindingSource
        '
        Me.TipoUsuarioBindingSource.DataMember = "Tipo_Usuario"
        Me.TipoUsuarioBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet3
        '
        'Tipo_UsuarioTableAdapter
        '
        Me.Tipo_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Categoria_ProductoTableAdapter
        '
        Me.Categoria_ProductoTableAdapter.ClearBeforeFill = True
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(144, 296)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(111, 13)
        Me.LENumeros.TabIndex = 37
        Me.LENumeros.Text = "Solo ingresar numeros"
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BLimpiar.Location = New System.Drawing.Point(64, 376)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(158, 23)
        Me.BLimpiar.TabIndex = 38
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'CBTalle
        '
        Me.CBTalle.AutoSize = True
        Me.CBTalle.Location = New System.Drawing.Point(16, 136)
        Me.CBTalle.Name = "CBTalle"
        Me.CBTalle.Size = New System.Drawing.Size(15, 14)
        Me.CBTalle.TabIndex = 87
        Me.CBTalle.UseVisualStyleBackColor = True
        '
        'CBMarca
        '
        Me.CBMarca.AutoSize = True
        Me.CBMarca.Location = New System.Drawing.Point(16, 176)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(15, 14)
        Me.CBMarca.TabIndex = 86
        Me.CBMarca.UseVisualStyleBackColor = True
        '
        'DroplistMarca
        '
        Me.DroplistMarca.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistMarca.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistMarca.DisplayMember = "descripcion_categoria"
        Me.DroplistMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistMarca.FormattingEnabled = True
        Me.DroplistMarca.Location = New System.Drawing.Point(112, 176)
        Me.DroplistMarca.Name = "DroplistMarca"
        Me.DroplistMarca.Size = New System.Drawing.Size(160, 21)
        Me.DroplistMarca.TabIndex = 85
        Me.DroplistMarca.ValueMember = "id_categoria"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Location = New System.Drawing.Point(40, 176)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(37, 13)
        Me.LMarca.TabIndex = 84
        Me.LMarca.Text = "Marca"
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.Location = New System.Drawing.Point(40, 136)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(30, 13)
        Me.LTalle.TabIndex = 83
        Me.LTalle.Text = "Talle"
        '
        'DroplistTalle
        '
        Me.DroplistTalle.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoriaProductoBindingSource, "id_categoria", True))
        Me.DroplistTalle.DataSource = Me.CategoriaProductoBindingSource
        Me.DroplistTalle.DisplayMember = "descripcion_categoria"
        Me.DroplistTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistTalle.FormattingEnabled = True
        Me.DroplistTalle.Location = New System.Drawing.Point(112, 136)
        Me.DroplistTalle.Name = "DroplistTalle"
        Me.DroplistTalle.Size = New System.Drawing.Size(160, 21)
        Me.DroplistTalle.TabIndex = 82
        Me.DroplistTalle.ValueMember = "id_categoria"
        '
        'CBCodigo
        '
        Me.CBCodigo.AutoSize = True
        Me.CBCodigo.Location = New System.Drawing.Point(16, 16)
        Me.CBCodigo.Name = "CBCodigo"
        Me.CBCodigo.Size = New System.Drawing.Size(15, 14)
        Me.CBCodigo.TabIndex = 90
        Me.CBCodigo.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(112, 16)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(160, 20)
        Me.TCodigo.TabIndex = 89
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Location = New System.Drawing.Point(40, 16)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LCodigo.TabIndex = 88
        Me.LCodigo.Text = "Codigo"
        '
        'BuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBCodigo)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.CBTalle)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.DroplistMarca)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LTalle)
        Me.Controls.Add(Me.DroplistTalle)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.LENumeros)
        Me.Controls.Add(Me.CBHabilitado)
        Me.Controls.Add(Me.LHabilitado)
        Me.Controls.Add(Me.DroplistStock)
        Me.Controls.Add(Me.CBStock)
        Me.Controls.Add(Me.LStock)
        Me.Controls.Add(Me.TStock)
        Me.Controls.Add(Me.DroplistPrecio)
        Me.Controls.Add(Me.CBPrecio)
        Me.Controls.Add(Me.CBCategoria)
        Me.Controls.Add(Me.CBNombre)
        Me.Controls.Add(Me.LPrecio)
        Me.Controls.Add(Me.TPrecio)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.DroplistCategoria)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarProducto"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LPrecio As Label
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents LCategoria As Label
    Friend WithEvents DroplistCategoria As ComboBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents CBNombre As CheckBox
    Friend WithEvents CBCategoria As CheckBox
    Friend WithEvents DroplistPrecio As ComboBox
    Friend WithEvents DroplistStock As ComboBox
    Friend WithEvents CBStock As CheckBox
    Friend WithEvents LStock As Label
    Friend WithEvents TStock As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents LHabilitado As Label
    Friend WithEvents CBHabilitado As CheckBox
    Friend WithEvents CBPrecio As CheckBox
    Friend WithEvents BaseDeDatosProyectoDataSet3 As BaseDeDatosProyectoDataSet3
    Friend WithEvents TipoUsuarioBindingSource As BindingSource
    Friend WithEvents Tipo_UsuarioTableAdapter As BaseDeDatosProyectoDataSet3TableAdapters.Tipo_UsuarioTableAdapter
    Friend WithEvents BaseDeDatosProyectoDataSet4 As BaseDeDatosProyectoDataSet4
    Friend WithEvents CategoriaProductoBindingSource As BindingSource
    Friend WithEvents Categoria_ProductoTableAdapter As BaseDeDatosProyectoDataSet4TableAdapters.Categoria_ProductoTableAdapter
    Friend WithEvents LENumeros As Label
    Friend WithEvents BLimpiar As Button
    Friend WithEvents CBTalle As CheckBox
    Friend WithEvents CBMarca As CheckBox
    Friend WithEvents DroplistMarca As ComboBox
    Friend WithEvents LMarca As Label
    Friend WithEvents LTalle As Label
    Friend WithEvents DroplistTalle As ComboBox
    Friend WithEvents CBCodigo As CheckBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents LCodigo As Label
End Class
