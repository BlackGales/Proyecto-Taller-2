<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TNombreBackup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.BBackup = New System.Windows.Forms.Button()
        Me.BRestaurar = New System.Windows.Forms.Button()
        Me.BSeleccionarRestaurar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Realizar Backup"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TNombreBackup
        '
        Me.TNombreBackup.Location = New System.Drawing.Point(168, 96)
        Me.TNombreBackup.Name = "TNombreBackup"
        Me.TNombreBackup.Size = New System.Drawing.Size(184, 20)
        Me.TNombreBackup.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre de backup"
        '
        'BSeleccionar
        '
        Me.BSeleccionar.Location = New System.Drawing.Point(40, 144)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(120, 23)
        Me.BSeleccionar.TabIndex = 10
        Me.BSeleccionar.Text = "Seleccionar Destino"
        Me.BSeleccionar.UseVisualStyleBackColor = True
        '
        'BBackup
        '
        Me.BBackup.Location = New System.Drawing.Point(368, 144)
        Me.BBackup.Name = "BBackup"
        Me.BBackup.Size = New System.Drawing.Size(120, 23)
        Me.BBackup.TabIndex = 11
        Me.BBackup.Text = "Realizar Backup"
        Me.BBackup.UseVisualStyleBackColor = True
        '
        'BRestaurar
        '
        Me.BRestaurar.Location = New System.Drawing.Point(360, 112)
        Me.BRestaurar.Name = "BRestaurar"
        Me.BRestaurar.Size = New System.Drawing.Size(120, 23)
        Me.BRestaurar.TabIndex = 16
        Me.BRestaurar.Text = "Restaurar Backup"
        Me.BRestaurar.UseVisualStyleBackColor = True
        '
        'BSeleccionarRestaurar
        '
        Me.BSeleccionarRestaurar.Location = New System.Drawing.Point(96, 112)
        Me.BSeleccionarRestaurar.Name = "BSeleccionarRestaurar"
        Me.BSeleccionarRestaurar.Size = New System.Drawing.Size(120, 23)
        Me.BSeleccionarRestaurar.TabIndex = 15
        Me.BSeleccionarRestaurar.Text = "Seleccionar Archivo"
        Me.BSeleccionarRestaurar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(364, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Restaurar Backup (Desconecta la Base de Datos)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.BBackup)
        Me.Panel1.Controls.Add(Me.BSeleccionar)
        Me.Panel1.Controls.Add(Me.TNombreBackup)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 528)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.BRestaurar)
        Me.Panel2.Controls.Add(Me.BSeleccionarRestaurar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(592, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 528)
        Me.Panel2.TabIndex = 18
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Backup"
        Me.Text = "Backup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TNombreBackup As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BSeleccionar As Button
    Friend WithEvents BBackup As Button
    Friend WithEvents BRestaurar As Button
    Friend WithEvents BSeleccionarRestaurar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
