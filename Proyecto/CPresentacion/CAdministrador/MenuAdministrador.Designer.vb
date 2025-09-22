<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdministrador
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
        Me.MenuArriba = New System.Windows.Forms.Splitter()
        Me.BBackup = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.BSesion = New System.Windows.Forms.Button()
        Me.BHome = New System.Windows.Forms.Button()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LUsuarioNombre = New System.Windows.Forms.Label()
        Me.LUsuarioFecha = New System.Windows.Forms.Label()
        Me.LUsuarioMenu = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuArriba
        '
        Me.MenuArriba.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MenuArriba.CausesValidation = False
        Me.MenuArriba.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MenuArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuArriba.Location = New System.Drawing.Point(0, 0)
        Me.MenuArriba.Name = "MenuArriba"
        Me.MenuArriba.Size = New System.Drawing.Size(1184, 100)
        Me.MenuArriba.TabIndex = 0
        Me.MenuArriba.TabStop = False
        '
        'BBackup
        '
        Me.BBackup.BackgroundImage = Global.Proyecto.My.Resources.Resources.backup
        Me.BBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBackup.Location = New System.Drawing.Point(320, 8)
        Me.BBackup.Name = "BBackup"
        Me.BBackup.Size = New System.Drawing.Size(80, 80)
        Me.BBackup.TabIndex = 4
        Me.BBackup.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackgroundImage = Global.Proyecto.My.Resources.Resources.buscar
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBuscar.Location = New System.Drawing.Point(112, 8)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(80, 80)
        Me.BBuscar.TabIndex = 1
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'BUsuarios
        '
        Me.BUsuarios.BackgroundImage = Global.Proyecto.My.Resources.Resources.crud
        Me.BUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BUsuarios.Location = New System.Drawing.Point(216, 8)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Size = New System.Drawing.Size(80, 80)
        Me.BUsuarios.TabIndex = 0
        Me.BUsuarios.UseVisualStyleBackColor = True
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
        Me.BHome.Text = "Home"
        Me.BHome.UseVisualStyleBackColor = True
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(0, 100)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(1184, 561)
        Me.PanelFormulario.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LUsuarioNombre)
        Me.Panel1.Controls.Add(Me.LUsuarioFecha)
        Me.Panel1.Controls.Add(Me.LUsuarioMenu)
        Me.Panel1.Location = New System.Drawing.Point(832, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 80)
        Me.Panel1.TabIndex = 12
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
        Me.LTitulo.Location = New System.Drawing.Point(424, 32)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(78, 31)
        Me.LTitulo.TabIndex = 13
        Me.LTitulo.Text = "Inicio"
        '
        'MenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.BBackup)
        Me.Controls.Add(Me.BUsuarios)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.BSesion)
        Me.Controls.Add(Me.BHome)
        Me.Controls.Add(Me.MenuArriba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "MenuAdministrador"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuArriba As Splitter
    Friend WithEvents BUsuarios As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents BHome As Button
    Friend WithEvents BSesion As Button
    Friend WithEvents BBackup As Button
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LUsuarioNombre As Label
    Friend WithEvents LUsuarioFecha As Label
    Friend WithEvents LUsuarioMenu As Label
    Friend WithEvents LTitulo As Label
End Class
