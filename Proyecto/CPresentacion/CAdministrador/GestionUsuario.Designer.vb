<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionUsuario
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
        Me.LENombre = New System.Windows.Forms.Label()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.LTipo = New System.Windows.Forms.Label()
        Me.DroplistTipo = New System.Windows.Forms.ComboBox()
        Me.TipoUsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet6 = New Proyecto.BaseDeDatosProyectoDataSet6()
        Me.TipoUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet = New Proyecto.BaseDeDatosProyectoDataSet()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.TContraseña = New System.Windows.Forms.TextBox()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.ODSeleccionarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.LHabilitado = New System.Windows.Forms.Label()
        Me.CBHabilitado = New System.Windows.Forms.CheckBox()
        Me.Tipo_UsuarioTableAdapter = New Proyecto.BaseDeDatosProyectoDataSetTableAdapters.Tipo_UsuarioTableAdapter()
        Me.BaseDeDatosProyectoDataSet1 = New Proyecto.BaseDeDatosProyectoDataSet1()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New Proyecto.BaseDeDatosProyectoDataSet1TableAdapters.EmpleadosTableAdapter()
        Me.Tipo_UsuarioTableAdapter1 = New Proyecto.BaseDeDatosProyectoDataSet6TableAdapters.Tipo_UsuarioTableAdapter()
        Me.LEContraseña = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LENombre
        '
        Me.LENombre.AutoSize = True
        Me.LENombre.ForeColor = System.Drawing.Color.Red
        Me.LENombre.Location = New System.Drawing.Point(286, 31)
        Me.LENombre.Name = "LENombre"
        Me.LENombre.Size = New System.Drawing.Size(113, 13)
        Me.LENombre.TabIndex = 34
        Me.LENombre.Text = "Solo se permiten letras"
        Me.LENombre.Visible = False
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BEditar.Location = New System.Drawing.Point(218, 228)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(149, 23)
        Me.BEditar.TabIndex = 9
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 272)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1184, 289)
        Me.DataGridView1.TabIndex = 28
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.LimeGreen
        Me.BAgregar.Location = New System.Drawing.Point(37, 228)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(149, 23)
        Me.BAgregar.TabIndex = 8
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'LTipo
        '
        Me.LTipo.AutoSize = True
        Me.LTipo.Location = New System.Drawing.Point(33, 188)
        Me.LTipo.Name = "LTipo"
        Me.LTipo.Size = New System.Drawing.Size(67, 13)
        Me.LTipo.TabIndex = 24
        Me.LTipo.Text = "Tipo Usuario"
        '
        'DroplistTipo
        '
        Me.DroplistTipo.DataSource = Me.TipoUsuarioBindingSource1
        Me.DroplistTipo.DisplayMember = "descripcion_tipo"
        Me.DroplistTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistTipo.FormattingEnabled = True
        Me.DroplistTipo.Location = New System.Drawing.Point(111, 185)
        Me.DroplistTipo.Name = "DroplistTipo"
        Me.DroplistTipo.Size = New System.Drawing.Size(158, 21)
        Me.DroplistTipo.TabIndex = 6
        Me.DroplistTipo.ValueMember = "descripcion_tipo"
        '
        'TipoUsuarioBindingSource1
        '
        Me.TipoUsuarioBindingSource1.DataMember = "Tipo_Usuario"
        Me.TipoUsuarioBindingSource1.DataSource = Me.BaseDeDatosProyectoDataSet6
        '
        'BaseDeDatosProyectoDataSet6
        '
        Me.BaseDeDatosProyectoDataSet6.DataSetName = "BaseDeDatosProyectoDataSet6"
        Me.BaseDeDatosProyectoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoUsuarioBindingSource
        '
        Me.TipoUsuarioBindingSource.DataMember = "Tipo_Usuario"
        Me.TipoUsuarioBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet
        '
        'BaseDeDatosProyectoDataSet
        '
        Me.BaseDeDatosProyectoDataSet.DataSetName = "BaseDeDatosProyectoDataSet"
        Me.BaseDeDatosProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(111, 11)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(158, 20)
        Me.TNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(32, 121)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LUsuario.TabIndex = 35
        Me.LUsuario.Text = "Usuario"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(109, 118)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(158, 20)
        Me.TUsuario.TabIndex = 4
        '
        'TContraseña
        '
        Me.TContraseña.Location = New System.Drawing.Point(109, 152)
        Me.TContraseña.Name = "TContraseña"
        Me.TContraseña.Size = New System.Drawing.Size(158, 20)
        Me.TContraseña.TabIndex = 5
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Location = New System.Drawing.Point(31, 155)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(61, 13)
        Me.LContraseña.TabIndex = 37
        Me.LContraseña.Text = "Contraseña"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(110, 46)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(158, 20)
        Me.TApellido.TabIndex = 2
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(32, 49)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 39
        Me.LApellido.Text = "Apellido"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(110, 82)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(158, 20)
        Me.TDni.TabIndex = 3
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(32, 85)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 41
        Me.LDni.Text = "DNI"
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(286, 85)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(187, 13)
        Me.LENumeros.TabIndex = 43
        Me.LENumeros.Text = "Solo se permiten números (Sin puntos)"
        Me.LENumeros.Visible = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.Crimson
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BCancelar.Location = New System.Drawing.Point(398, 228)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(149, 23)
        Me.BCancelar.TabIndex = 10
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'ODSeleccionarImagen
        '
        Me.ODSeleccionarImagen.FileName = "OpenFileDialog1"
        '
        'LHabilitado
        '
        Me.LHabilitado.AutoSize = True
        Me.LHabilitado.Location = New System.Drawing.Point(432, 192)
        Me.LHabilitado.Name = "LHabilitado"
        Me.LHabilitado.Size = New System.Drawing.Size(54, 13)
        Me.LHabilitado.TabIndex = 45
        Me.LHabilitado.Text = "Habilitado"
        '
        'CBHabilitado
        '
        Me.CBHabilitado.AutoSize = True
        Me.CBHabilitado.Checked = True
        Me.CBHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHabilitado.Location = New System.Drawing.Point(405, 192)
        Me.CBHabilitado.Name = "CBHabilitado"
        Me.CBHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.CBHabilitado.TabIndex = 7
        Me.CBHabilitado.UseVisualStyleBackColor = True
        '
        'Tipo_UsuarioTableAdapter
        '
        Me.Tipo_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'BaseDeDatosProyectoDataSet1
        '
        Me.BaseDeDatosProyectoDataSet1.DataSetName = "BaseDeDatosProyectoDataSet1"
        Me.BaseDeDatosProyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet1
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Tipo_UsuarioTableAdapter1
        '
        Me.Tipo_UsuarioTableAdapter1.ClearBeforeFill = True
        '
        'LEContraseña
        '
        Me.LEContraseña.AutoSize = True
        Me.LEContraseña.ForeColor = System.Drawing.Color.Red
        Me.LEContraseña.Location = New System.Drawing.Point(296, 152)
        Me.LEContraseña.Name = "LEContraseña"
        Me.LEContraseña.Size = New System.Drawing.Size(272, 13)
        Me.LEContraseña.TabIndex = 46
        Me.LEContraseña.Text = "Dejar vacio si no quiere realizar cambios a la contraseña"
        Me.LEContraseña.Visible = False
        '
        'GestionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.LEContraseña)
        Me.Controls.Add(Me.CBHabilitado)
        Me.Controls.Add(Me.LHabilitado)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.LENumeros)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.TContraseña)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.LENombre)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.LTipo)
        Me.Controls.Add(Me.DroplistTipo)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionUsuario"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LENombre As Label
    Friend WithEvents BEditar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BAgregar As Button
    Friend WithEvents LTipo As Label
    Friend WithEvents DroplistTipo As ComboBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents TContraseña As TextBox
    Friend WithEvents LContraseña As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LENumeros As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents ODSeleccionarImagen As OpenFileDialog
    Friend WithEvents LHabilitado As Label
    Friend WithEvents CBHabilitado As CheckBox
    Friend WithEvents BaseDeDatosProyectoDataSet As BaseDeDatosProyectoDataSet
    Friend WithEvents TipoUsuarioBindingSource As BindingSource
    Friend WithEvents Tipo_UsuarioTableAdapter As BaseDeDatosProyectoDataSetTableAdapters.Tipo_UsuarioTableAdapter
    Friend WithEvents BaseDeDatosProyectoDataSet1 As BaseDeDatosProyectoDataSet1
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As BaseDeDatosProyectoDataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents BaseDeDatosProyectoDataSet6 As BaseDeDatosProyectoDataSet6
    Friend WithEvents TipoUsuarioBindingSource1 As BindingSource
    Friend WithEvents Tipo_UsuarioTableAdapter1 As BaseDeDatosProyectoDataSet6TableAdapters.Tipo_UsuarioTableAdapter
    Friend WithEvents LEContraseña As Label
End Class
