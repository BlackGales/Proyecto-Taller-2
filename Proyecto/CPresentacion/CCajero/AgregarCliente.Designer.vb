<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCliente
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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LENombre = New System.Windows.Forms.Label()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBDni = New System.Windows.Forms.CheckBox()
        Me.CBNombre = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LENumerosBuscar = New System.Windows.Forms.Label()
        Me.TDniBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LENombreBuscar = New System.Windows.Forms.Label()
        Me.TNombreBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TDomicilio = New System.Windows.Forms.TextBox()
        Me.LDomicilio = New System.Windows.Forms.Label()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.CBTelefono = New System.Windows.Forms.CheckBox()
        Me.TTelefonoBuscar = New System.Windows.Forms.TextBox()
        Me.LTelefonoBuscar = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.Crimson
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BCancelar.Location = New System.Drawing.Point(280, 136)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(149, 23)
        Me.BCancelar.TabIndex = 63
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(266, 48)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(187, 13)
        Me.LENumeros.TabIndex = 62
        Me.LENumeros.Text = "Solo se permiten números (Sin puntos)"
        Me.LENumeros.Visible = False
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(88, 40)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(158, 20)
        Me.TDni.TabIndex = 61
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(16, 40)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 60
        Me.LDni.Text = "DNI"
        '
        'LENombre
        '
        Me.LENombre.AutoSize = True
        Me.LENombre.ForeColor = System.Drawing.Color.Red
        Me.LENombre.Location = New System.Drawing.Point(266, 13)
        Me.LENombre.Name = "LENombre"
        Me.LENombre.Size = New System.Drawing.Size(113, 13)
        Me.LENombre.TabIndex = 53
        Me.LENombre.Text = "Solo se permiten letras"
        Me.LENombre.Visible = False
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BEditar.Location = New System.Drawing.Point(280, 104)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(149, 23)
        Me.BEditar.TabIndex = 52
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.LimeGreen
        Me.BAgregar.Location = New System.Drawing.Point(280, 72)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(149, 23)
        Me.BAgregar.TabIndex = 51
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(88, 8)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(158, 20)
        Me.TNombre.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nombre"
        '
        'CBDni
        '
        Me.CBDni.AutoSize = True
        Me.CBDni.Location = New System.Drawing.Point(728, 40)
        Me.CBDni.Name = "CBDni"
        Me.CBDni.Size = New System.Drawing.Size(15, 14)
        Me.CBDni.TabIndex = 85
        Me.CBDni.UseVisualStyleBackColor = True
        '
        'CBNombre
        '
        Me.CBNombre.AutoSize = True
        Me.CBNombre.Location = New System.Drawing.Point(728, 8)
        Me.CBNombre.Name = "CBNombre"
        Me.CBNombre.Size = New System.Drawing.Size(15, 14)
        Me.CBNombre.TabIndex = 84
        Me.CBNombre.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(1024, 72)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BBuscar.TabIndex = 83
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LENumerosBuscar
        '
        Me.LENumerosBuscar.AutoSize = True
        Me.LENumerosBuscar.ForeColor = System.Drawing.Color.Red
        Me.LENumerosBuscar.Location = New System.Drawing.Point(976, 48)
        Me.LENumerosBuscar.Name = "LENumerosBuscar"
        Me.LENumerosBuscar.Size = New System.Drawing.Size(187, 13)
        Me.LENumerosBuscar.TabIndex = 82
        Me.LENumerosBuscar.Text = "Solo se permiten números (Sin puntos)"
        Me.LENumerosBuscar.Visible = False
        '
        'TDniBuscar
        '
        Me.TDniBuscar.Location = New System.Drawing.Point(808, 40)
        Me.TDniBuscar.Name = "TDniBuscar"
        Me.TDniBuscar.Size = New System.Drawing.Size(160, 20)
        Me.TDniBuscar.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(752, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "DNI"
        '
        'LENombreBuscar
        '
        Me.LENombreBuscar.AutoSize = True
        Me.LENombreBuscar.ForeColor = System.Drawing.Color.Red
        Me.LENombreBuscar.Location = New System.Drawing.Point(976, 16)
        Me.LENombreBuscar.Name = "LENombreBuscar"
        Me.LENombreBuscar.Size = New System.Drawing.Size(113, 13)
        Me.LENombreBuscar.TabIndex = 79
        Me.LENombreBuscar.Text = "Solo se permiten letras"
        Me.LENombreBuscar.Visible = False
        '
        'TNombreBuscar
        '
        Me.TNombreBuscar.Location = New System.Drawing.Point(808, 8)
        Me.TNombreBuscar.Name = "TNombreBuscar"
        Me.TNombreBuscar.Size = New System.Drawing.Size(160, 20)
        Me.TNombreBuscar.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(752, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1184, 377)
        Me.DataGridView1.TabIndex = 76
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(88, 72)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(158, 20)
        Me.TTelefono.TabIndex = 87
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(16, 72)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 86
        Me.LTelefono.Text = "Telefono"
        '
        'TDomicilio
        '
        Me.TDomicilio.Location = New System.Drawing.Point(88, 104)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.Size = New System.Drawing.Size(158, 20)
        Me.TDomicilio.TabIndex = 89
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Location = New System.Drawing.Point(16, 104)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LDomicilio.TabIndex = 88
        Me.LDomicilio.Text = "Domicilio"
        '
        'TCorreo
        '
        Me.TCorreo.Location = New System.Drawing.Point(88, 136)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(158, 20)
        Me.TCorreo.TabIndex = 91
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Location = New System.Drawing.Point(16, 136)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(38, 13)
        Me.LCorreo.TabIndex = 90
        Me.LCorreo.Text = "Correo"
        '
        'CBTelefono
        '
        Me.CBTelefono.AutoSize = True
        Me.CBTelefono.Location = New System.Drawing.Point(728, 72)
        Me.CBTelefono.Name = "CBTelefono"
        Me.CBTelefono.Size = New System.Drawing.Size(15, 14)
        Me.CBTelefono.TabIndex = 96
        Me.CBTelefono.UseVisualStyleBackColor = True
        '
        'TTelefonoBuscar
        '
        Me.TTelefonoBuscar.Location = New System.Drawing.Point(808, 72)
        Me.TTelefonoBuscar.Name = "TTelefonoBuscar"
        Me.TTelefonoBuscar.Size = New System.Drawing.Size(160, 20)
        Me.TTelefonoBuscar.TabIndex = 93
        '
        'LTelefonoBuscar
        '
        Me.LTelefonoBuscar.AutoSize = True
        Me.LTelefonoBuscar.Location = New System.Drawing.Point(752, 72)
        Me.LTelefonoBuscar.Name = "LTelefonoBuscar"
        Me.LTelefonoBuscar.Size = New System.Drawing.Size(49, 13)
        Me.LTelefonoBuscar.TabIndex = 92
        Me.LTelefonoBuscar.Text = "Telefono"
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.CBTelefono)
        Me.Controls.Add(Me.TTelefonoBuscar)
        Me.Controls.Add(Me.LTelefonoBuscar)
        Me.Controls.Add(Me.TCorreo)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.TDomicilio)
        Me.Controls.Add(Me.LDomicilio)
        Me.Controls.Add(Me.TTelefono)
        Me.Controls.Add(Me.LTelefono)
        Me.Controls.Add(Me.CBDni)
        Me.Controls.Add(Me.CBNombre)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LENumerosBuscar)
        Me.Controls.Add(Me.TDniBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LENombreBuscar)
        Me.Controls.Add(Me.TNombreBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.LENumeros)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LENombre)
        Me.Controls.Add(Me.BEditar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarCliente"
        Me.Text = "AgregarCliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCancelar As Button
    Friend WithEvents LENumeros As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LENombre As Label
    Friend WithEvents BEditar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBDni As CheckBox
    Friend WithEvents CBNombre As CheckBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents LENumerosBuscar As Label
    Friend WithEvents TDniBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LENombreBuscar As Label
    Friend WithEvents TNombreBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents TDomicilio As TextBox
    Friend WithEvents LDomicilio As Label
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents CBTelefono As CheckBox
    Friend WithEvents TTelefonoBuscar As TextBox
    Friend WithEvents LTelefonoBuscar As Label
End Class
