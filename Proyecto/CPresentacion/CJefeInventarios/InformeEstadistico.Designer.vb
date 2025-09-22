<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeEstadistico
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(40, 88)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ventas Por Periodo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(696, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ventas"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(184, 56)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(35, 13)
        Me.LHasta.TabIndex = 22
        Me.LHasta.Text = "Hasta"
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(48, 56)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(38, 13)
        Me.LDesde.TabIndex = 21
        Me.LDesde.Text = "Desde"
        '
        'FechaHasta
        '
        Me.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaHasta.Location = New System.Drawing.Point(224, 56)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(77, 20)
        Me.FechaHasta.TabIndex = 20
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(88, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(84, 20)
        Me.DateTimePicker2.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InformeEstadistico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.FechaHasta)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "InformeEstadistico"
        Me.Text = "InformeEstadistico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents LDesde As Label
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
