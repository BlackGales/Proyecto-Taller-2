<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.TContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(336, 24)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(98, 13)
        Me.LUsuario.TabIndex = 0
        Me.LUsuario.Text = "Nombre de Usuario"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(456, 24)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(149, 20)
        Me.TUsuario.TabIndex = 1
        Me.TUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BIngresar
        '
        Me.BIngresar.Location = New System.Drawing.Point(336, 96)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresar.TabIndex = 3
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = True
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Location = New System.Drawing.Point(336, 56)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(61, 13)
        Me.LContraseña.TabIndex = 3
        Me.LContraseña.Text = "Contraseña"
        '
        'TContraseña
        '
        Me.TContraseña.Location = New System.Drawing.Point(456, 56)
        Me.TContraseña.Name = "TContraseña"
        Me.TContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TContraseña.Size = New System.Drawing.Size(149, 20)
        Me.TContraseña.TabIndex = 2
        Me.TContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TContraseña.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 72)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(624, 199)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TContraseña)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.BIngresar)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.LUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUsuario As Label
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents BIngresar As Button
    Friend WithEvents LContraseña As Label
    Friend WithEvents TContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
