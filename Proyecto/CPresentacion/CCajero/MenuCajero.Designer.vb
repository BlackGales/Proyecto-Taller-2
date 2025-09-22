<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCajero
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.BCLienteAgregar = New System.Windows.Forms.Button()
        Me.BListar = New System.Windows.Forms.Button()
        Me.BVenta = New System.Windows.Forms.Button()
        Me.BSesion = New System.Windows.Forms.Button()
        Me.BHome = New System.Windows.Forms.Button()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LUsuarioNombre = New System.Windows.Forms.Label()
        Me.LUsuarioFecha = New System.Windows.Forms.Label()
        Me.LUsuarioMenu = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1184, 100)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'BCLienteAgregar
        '
        Me.BCLienteAgregar.BackgroundImage = Global.Proyecto.My.Resources.Resources.UsuarioAnonimo
        Me.BCLienteAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCLienteAgregar.Location = New System.Drawing.Point(320, 8)
        Me.BCLienteAgregar.Name = "BCLienteAgregar"
        Me.BCLienteAgregar.Size = New System.Drawing.Size(80, 80)
        Me.BCLienteAgregar.TabIndex = 31
        Me.BCLienteAgregar.UseVisualStyleBackColor = True
        '
        'BListar
        '
        Me.BListar.BackgroundImage = Global.Proyecto.My.Resources.Resources.listar
        Me.BListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BListar.Location = New System.Drawing.Point(216, 8)
        Me.BListar.Name = "BListar"
        Me.BListar.Size = New System.Drawing.Size(80, 80)
        Me.BListar.TabIndex = 4
        Me.BListar.UseVisualStyleBackColor = True
        '
        'BVenta
        '
        Me.BVenta.BackgroundImage = Global.Proyecto.My.Resources.Resources.sell
        Me.BVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BVenta.Location = New System.Drawing.Point(112, 8)
        Me.BVenta.Name = "BVenta"
        Me.BVenta.Size = New System.Drawing.Size(80, 80)
        Me.BVenta.TabIndex = 3
        Me.BVenta.UseVisualStyleBackColor = True
        '
        'BSesion
        '
        Me.BSesion.BackgroundImage = Global.Proyecto.My.Resources.Resources.logout1
        Me.BSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BSesion.Location = New System.Drawing.Point(1096, 8)
        Me.BSesion.Name = "BSesion"
        Me.BSesion.Size = New System.Drawing.Size(80, 80)
        Me.BSesion.TabIndex = 3
        Me.BSesion.UseVisualStyleBackColor = True
        '
        'BHome
        '
        Me.BHome.BackgroundImage = Global.Proyecto.My.Resources.Resources.home
        Me.BHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BHome.Location = New System.Drawing.Point(8, 8)
        Me.BHome.Name = "BHome"
        Me.BHome.Size = New System.Drawing.Size(80, 80)
        Me.BHome.TabIndex = 2
        Me.BHome.UseVisualStyleBackColor = True
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(0, 100)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(1184, 561)
        Me.PanelFormulario.TabIndex = 32
        '
        'BBuscar
        '
        Me.BBuscar.BackgroundImage = Global.Proyecto.My.Resources.Resources.buscar
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBuscar.Location = New System.Drawing.Point(424, 8)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(80, 80)
        Me.BBuscar.TabIndex = 33
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LUsuarioNombre)
        Me.Panel1.Controls.Add(Me.LUsuarioFecha)
        Me.Panel1.Controls.Add(Me.LUsuarioMenu)
        Me.Panel1.Location = New System.Drawing.Point(832, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 80)
        Me.Panel1.TabIndex = 34
        '
        'LUsuarioNombre
        '
        Me.LUsuarioNombre.AutoSize = True
        Me.LUsuarioNombre.Location = New System.Drawing.Point(8, 32)
        Me.LUsuarioNombre.Name = "LUsuarioNombre"
        Me.LUsuarioNombre.Size = New System.Drawing.Size(47, 13)
        Me.LUsuarioNombre.TabIndex = 2
        Me.LUsuarioNombre.Text = "Nombre:"
        '
        'LUsuarioFecha
        '
        Me.LUsuarioFecha.AutoSize = True
        Me.LUsuarioFecha.Location = New System.Drawing.Point(8, 56)
        Me.LUsuarioFecha.Name = "LUsuarioFecha"
        Me.LUsuarioFecha.Size = New System.Drawing.Size(40, 13)
        Me.LUsuarioFecha.TabIndex = 1
        Me.LUsuarioFecha.Text = "Fecha:"
        '
        'LUsuarioMenu
        '
        Me.LUsuarioMenu.AutoSize = True
        Me.LUsuarioMenu.Location = New System.Drawing.Point(8, 8)
        Me.LUsuarioMenu.Name = "LUsuarioMenu"
        Me.LUsuarioMenu.Size = New System.Drawing.Size(46, 13)
        Me.LUsuarioMenu.TabIndex = 0
        Me.LUsuarioMenu.Text = "Usuario:"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(528, 32)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(78, 31)
        Me.LTitulo.TabIndex = 35
        Me.LTitulo.Text = "Inicio"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.BCLienteAgregar)
        Me.Controls.Add(Me.BListar)
        Me.Controls.Add(Me.BVenta)
        Me.Controls.Add(Me.BSesion)
        Me.Controls.Add(Me.BHome)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MenuCajero"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Ventas Cajero"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents BVenta As Button
    Friend WithEvents BHome As Button
    Friend WithEvents BSesion As Button
    Friend WithEvents BListar As Button
    Friend WithEvents BCLienteAgregar As Button
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents BBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LUsuarioNombre As Label
    Friend WithEvents LUsuarioFecha As Label
    Friend WithEvents LUsuarioMenu As Label
    Friend WithEvents LTitulo As Label
End Class
