Imports System.Net.Security

Public Class BuscarUsuario
    Dim objdusuario As DEmpleado = New DEmpleado()

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENombre.Visible = True
            e.Handled = True
        Else
            LENombre.Visible = False
            With TNombre
                Dim ss As Integer = .SelectionStart
                Dim sl As Integer = .SelectionLength
                .Text = StrConv(.Text, VbStrConv.ProperCase)
                .SelectionStart = ss
                .SelectionLength = sl
            End With
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENombre.Visible = True
            e.Handled = True
        Else
            LENombre.Visible = False
            With TApellido
                Dim ss As Integer = .SelectionStart
                Dim sl As Integer = .SelectionLength
                .Text = StrConv(.Text, VbStrConv.ProperCase)
                .SelectionStart = ss
                .SelectionLength = sl
            End With
        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (String.IsNullOrWhiteSpace(TNombre.Text) And CBNombre.Checked) Or (String.IsNullOrWhiteSpace(TApellido.Text) And CBApellido.Checked) Or (String.IsNullOrWhiteSpace(TUsuario.Text) And CBUsuario.Checked) Or (String.IsNullOrWhiteSpace(DroplistTipo.Text) And CBTipo.Checked) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            DataGridView1.DataSource = objdusuario.getEmpleadosFiltro(TNombre.Text, TApellido.Text, TUsuario.Text, DroplistTipo.SelectedValue, CBHabilitado.Checked, CBNombre.Checked, CBApellido.Checked, CBUsuario.Checked, CBTipo.Checked)
        End If
    End Sub

    Private Sub BuscarClienteCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet.Tipo_Usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_UsuarioTableAdapter.Fill(Me.BaseDeDatosProyectoDataSet.Tipo_Usuario)
        DataGridView1.DataSource = objdusuario.getEmpleadoAll()
        TNombre.Enabled = False
        TApellido.Enabled = False
        TUsuario.Enabled = False
        DroplistTipo.Enabled = False
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub CBNombre_CheckedChanged(sender As Object, e As EventArgs) Handles CBNombre.CheckedChanged, CBApellido.CheckedChanged, CBUsuario.CheckedChanged, CBTipo.CheckedChanged
        If CBNombre.Checked Then
            TNombre.Enabled = True
        Else
            TNombre.Enabled = False
        End If
        If CBApellido.Checked Then
            TApellido.Enabled = True
        Else
            TApellido.Enabled = False
        End If
        If CBUsuario.Checked Then
            TUsuario.Enabled = True
        Else
            TUsuario.Enabled = False
        End If
        If CBTipo.Checked Then
            DroplistTipo.Enabled = True
        Else
            DroplistTipo.Enabled = False
        End If
    End Sub
End Class