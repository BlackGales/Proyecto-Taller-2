<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuInventario
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BSesion = New System.Windows.Forms.Button()
        Me.BHome = New System.Windows.Forms.Button()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.BInforme = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LUsuarioNombre = New System.Windows.Forms.Label()
        Me.LUsuarioFecha = New System.Windows.Forms.Label()
        Me.LUsuarioMenu = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1184, 100)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'BAgregar
        '
        Me.BAgregar.BackgroundImage = Global.Proyecto.My.Resources.Resources.crud
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAgregar.Location = New System.Drawing.Point(216, 8)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(80, 80)
        Me.BAgregar.TabIndex = 4
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackgroundImage = Global.Proyecto.My.Resources.Resources.buscar
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(112, 8)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(80, 80)
        Me.BBuscar.TabIndex = 3
        Me.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBuscar.UseVisualStyleBackColor = True
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
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(424, 32)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(78, 31)
        Me.LTitulo.TabIndex = 8
        Me.LTitulo.Text = "Inicio"
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(0, 100)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(1184, 561)
        Me.PanelFormulario.TabIndex = 9
        '
        'BInforme
        '
        Me.BInforme.BackgroundImage = Global.Proyecto.My.Resources.Resources.listar
        Me.BInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BInforme.Location = New System.Drawing.Point(320, 8)
        Me.BInforme.Name = "BInforme"
        Me.BInforme.Size = New System.Drawing.Size(80, 80)
        Me.BInforme.TabIndex = 10
        Me.BInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BInforme.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LUsuarioNombre)
        Me.Panel1.Controls.Add(Me.LUsuarioFecha)
        Me.Panel1.Controls.Add(Me.LUsuarioMenu)
        Me.Panel1.Location = New System.Drawing.Point(832, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 80)
        Me.Panel1.TabIndex = 11
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
        'MenuInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BInforme)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.BSesion)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.BHome)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MenuInventario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents BAgregar As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents BHome As Button
    Friend WithEvents BSesion As Button
    Friend WithEvents LTitulo As Label
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents BInforme As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LUsuarioNombre As Label
    Friend WithEvents LUsuarioFecha As Label
    Friend WithEvents LUsuarioMenu As Label
End Class
