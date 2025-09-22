<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClienteCajero
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LENumeros = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LENombre = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBNombre = New System.Windows.Forms.CheckBox()
        Me.CBDni = New System.Windows.Forms.CheckBox()
        Me.BSeleccionarCliente = New System.Windows.Forms.Button()
        Me.CBTelefono = New System.Windows.Forms.CheckBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.BLimpiar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(800, 338)
        Me.DataGridView1.TabIndex = 0
        '
        'LENumeros
        '
        Me.LENumeros.AutoSize = True
        Me.LENumeros.ForeColor = System.Drawing.Color.Red
        Me.LENumeros.Location = New System.Drawing.Point(272, 48)
        Me.LENumeros.Name = "LENumeros"
        Me.LENumeros.Size = New System.Drawing.Size(187, 13)
        Me.LENumeros.TabIndex = 71
        Me.LENumeros.Text = "Solo se permiten números (Sin puntos)"
        Me.LENumeros.Visible = False
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(104, 48)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(160, 20)
        Me.TDni.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "DNI"
        '
        'LENombre
        '
        Me.LENombre.AutoSize = True
        Me.LENombre.ForeColor = System.Drawing.Color.Red
        Me.LENombre.Location = New System.Drawing.Point(272, 16)
        Me.LENombre.Name = "LENombre"
        Me.LENombre.Size = New System.Drawing.Size(113, 13)
        Me.LENombre.TabIndex = 68
        Me.LENombre.Text = "Solo se permiten letras"
        Me.LENombre.Visible = False
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(104, 16)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(160, 20)
        Me.TNombre.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Nombre"
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(656, 16)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(112, 23)
        Me.BBuscar.TabIndex = 72
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'CBNombre
        '
        Me.CBNombre.AutoSize = True
        Me.CBNombre.Location = New System.Drawing.Point(16, 16)
        Me.CBNombre.Name = "CBNombre"
        Me.CBNombre.Size = New System.Drawing.Size(15, 14)
        Me.CBNombre.TabIndex = 73
        Me.CBNombre.UseVisualStyleBackColor = True
        '
        'CBDni
        '
        Me.CBDni.AutoSize = True
        Me.CBDni.Location = New System.Drawing.Point(16, 48)
        Me.CBDni.Name = "CBDni"
        Me.CBDni.Size = New System.Drawing.Size(15, 14)
        Me.CBDni.TabIndex = 74
        Me.CBDni.UseVisualStyleBackColor = True
        '
        'BSeleccionarCliente
        '
        Me.BSeleccionarCliente.Location = New System.Drawing.Point(656, 48)
        Me.BSeleccionarCliente.Name = "BSeleccionarCliente"
        Me.BSeleccionarCliente.Size = New System.Drawing.Size(116, 23)
        Me.BSeleccionarCliente.TabIndex = 75
        Me.BSeleccionarCliente.Text = "Seleccionar Cliente"
        Me.BSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'CBTelefono
        '
        Me.CBTelefono.AutoSize = True
        Me.CBTelefono.Location = New System.Drawing.Point(16, 80)
        Me.CBTelefono.Name = "CBTelefono"
        Me.CBTelefono.Size = New System.Drawing.Size(15, 14)
        Me.CBTelefono.TabIndex = 78
        Me.CBTelefono.UseVisualStyleBackColor = True
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(104, 80)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(160, 20)
        Me.TTelefono.TabIndex = 77
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(40, 80)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 76
        Me.LTelefono.Text = "Telefono"
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(656, 80)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(116, 23)
        Me.BLimpiar.TabIndex = 79
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'BuscarClienteCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.CBTelefono)
        Me.Controls.Add(Me.TTelefono)
        Me.Controls.Add(Me.LTelefono)
        Me.Controls.Add(Me.BSeleccionarCliente)
        Me.Controls.Add(Me.CBDni)
        Me.Controls.Add(Me.CBNombre)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LENumeros)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LENombre)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscarClienteCajero"
        Me.ShowIcon = False
        Me.Text = "Buscar Cliente Cajero"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LENumeros As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LENombre As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBNombre As CheckBox
    Friend WithEvents CBDni As CheckBox
    Friend WithEvents BSeleccionarCliente As Button
    Friend WithEvents CBTelefono As CheckBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents BLimpiar As Button
End Class
