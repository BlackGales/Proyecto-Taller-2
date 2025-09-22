<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarUsuario
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
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LENombre = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LTipo = New System.Windows.Forms.Label()
        Me.DroplistTipo = New System.Windows.Forms.ComboBox()
        Me.TipoUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDeDatosProyectoDataSet = New Proyecto.BaseDeDatosProyectoDataSet()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBNombre = New System.Windows.Forms.CheckBox()
        Me.CBApellido = New System.Windows.Forms.CheckBox()
        Me.CBUsuario = New System.Windows.Forms.CheckBox()
        Me.CBTipo = New System.Windows.Forms.CheckBox()
        Me.CBHabilitado = New System.Windows.Forms.CheckBox()
        Me.LHabilitado = New System.Windows.Forms.Label()
        Me.Tipo_UsuarioTableAdapter = New Proyecto.BaseDeDatosProyectoDataSetTableAdapters.Tipo_UsuarioTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDeDatosProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(88, 48)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(158, 20)
        Me.TApellido.TabIndex = 4
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(32, 48)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 55
        Me.LApellido.Text = "Apellido"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(504, 8)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(158, 20)
        Me.TUsuario.TabIndex = 6
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(424, 8)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LUsuario.TabIndex = 51
        Me.LUsuario.Text = "Usuario"
        '
        'LENombre
        '
        Me.LENombre.AutoSize = True
        Me.LENombre.ForeColor = System.Drawing.Color.Red
        Me.LENombre.Location = New System.Drawing.Point(120, 32)
        Me.LENombre.Name = "LENombre"
        Me.LENombre.Size = New System.Drawing.Size(113, 13)
        Me.LENombre.TabIndex = 50
        Me.LENombre.Text = "Solo se permiten letras"
        Me.LENombre.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1184, 471)
        Me.DataGridView1.TabIndex = 48
        Me.DataGridView1.TabStop = False
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(832, 48)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(149, 23)
        Me.BBuscar.TabIndex = 10
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LTipo
        '
        Me.LTipo.AutoSize = True
        Me.LTipo.Location = New System.Drawing.Point(424, 48)
        Me.LTipo.Name = "LTipo"
        Me.LTipo.Size = New System.Drawing.Size(67, 13)
        Me.LTipo.TabIndex = 44
        Me.LTipo.Text = "Tipo Usuario"
        '
        'DroplistTipo
        '
        Me.DroplistTipo.DataSource = Me.TipoUsuarioBindingSource
        Me.DroplistTipo.DisplayMember = "descripcion_tipo"
        Me.DroplistTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DroplistTipo.FormattingEnabled = True
        Me.DroplistTipo.Location = New System.Drawing.Point(504, 48)
        Me.DroplistTipo.Name = "DroplistTipo"
        Me.DroplistTipo.Size = New System.Drawing.Size(158, 21)
        Me.DroplistTipo.TabIndex = 8
        Me.DroplistTipo.ValueMember = "descripcion_tipo"
        '
        'TipoUsuarioBindingSource
        '
        Me.TipoUsuarioBindingSource.DataMember = "Tipo_Usuario"
        Me.TipoUsuarioBindingSource.DataSource = Me.BaseDeDatosProyectoDataSetBindingSource
        '
        'BaseDeDatosProyectoDataSetBindingSource
        '
        Me.BaseDeDatosProyectoDataSetBindingSource.DataSource = Me.BaseDeDatosProyectoDataSet
        Me.BaseDeDatosProyectoDataSetBindingSource.Position = 0
        '
        'BaseDeDatosProyectoDataSet
        '
        Me.BaseDeDatosProyectoDataSet.DataSetName = "BaseDeDatosProyectoDataSet"
        Me.BaseDeDatosProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(88, 8)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(158, 20)
        Me.TNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nombre"
        '
        'CBNombre
        '
        Me.CBNombre.AutoSize = True
        Me.CBNombre.Location = New System.Drawing.Point(8, 8)
        Me.CBNombre.Name = "CBNombre"
        Me.CBNombre.Size = New System.Drawing.Size(15, 14)
        Me.CBNombre.TabIndex = 1
        Me.CBNombre.UseVisualStyleBackColor = True
        '
        'CBApellido
        '
        Me.CBApellido.AutoSize = True
        Me.CBApellido.Location = New System.Drawing.Point(8, 48)
        Me.CBApellido.Name = "CBApellido"
        Me.CBApellido.Size = New System.Drawing.Size(15, 14)
        Me.CBApellido.TabIndex = 3
        Me.CBApellido.UseVisualStyleBackColor = True
        '
        'CBUsuario
        '
        Me.CBUsuario.AutoSize = True
        Me.CBUsuario.Location = New System.Drawing.Point(400, 8)
        Me.CBUsuario.Name = "CBUsuario"
        Me.CBUsuario.Size = New System.Drawing.Size(15, 14)
        Me.CBUsuario.TabIndex = 5
        Me.CBUsuario.UseVisualStyleBackColor = True
        '
        'CBTipo
        '
        Me.CBTipo.AutoSize = True
        Me.CBTipo.Location = New System.Drawing.Point(400, 48)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(15, 14)
        Me.CBTipo.TabIndex = 7
        Me.CBTipo.UseVisualStyleBackColor = True
        '
        'CBHabilitado
        '
        Me.CBHabilitado.AutoSize = True
        Me.CBHabilitado.Checked = True
        Me.CBHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBHabilitado.Location = New System.Drawing.Point(832, 8)
        Me.CBHabilitado.Name = "CBHabilitado"
        Me.CBHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.CBHabilitado.TabIndex = 9
        Me.CBHabilitado.UseVisualStyleBackColor = True
        '
        'LHabilitado
        '
        Me.LHabilitado.AutoSize = True
        Me.LHabilitado.Location = New System.Drawing.Point(856, 8)
        Me.LHabilitado.Name = "LHabilitado"
        Me.LHabilitado.Size = New System.Drawing.Size(54, 13)
        Me.LHabilitado.TabIndex = 61
        Me.LHabilitado.Text = "Habilitado"
        '
        'Tipo_UsuarioTableAdapter
        '
        Me.Tipo_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'BuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.CBHabilitado)
        Me.Controls.Add(Me.LHabilitado)
        Me.Controls.Add(Me.CBTipo)
        Me.Controls.Add(Me.CBUsuario)
        Me.Controls.Add(Me.CBApellido)
        Me.Controls.Add(Me.CBNombre)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.LENombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LTipo)
        Me.Controls.Add(Me.DroplistTipo)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarUsuario"
        Me.Text = "BuscarUsuario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDeDatosProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TApellido As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents LENombre As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BBuscar As Button
    Friend WithEvents LTipo As Label
    Friend WithEvents DroplistTipo As ComboBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBNombre As CheckBox
    Friend WithEvents CBApellido As CheckBox
    Friend WithEvents CBUsuario As CheckBox
    Friend WithEvents CBTipo As CheckBox
    Friend WithEvents CBHabilitado As CheckBox
    Friend WithEvents LHabilitado As Label
    Friend WithEvents BaseDeDatosProyectoDataSetBindingSource As BindingSource
    Friend WithEvents BaseDeDatosProyectoDataSet As BaseDeDatosProyectoDataSet
    Friend WithEvents TipoUsuarioBindingSource As BindingSource
    Friend WithEvents Tipo_UsuarioTableAdapter As BaseDeDatosProyectoDataSetTableAdapters.Tipo_UsuarioTableAdapter
End Class
