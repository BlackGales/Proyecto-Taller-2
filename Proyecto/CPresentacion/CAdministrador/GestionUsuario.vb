Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Linq.Expressions
Imports System.Net.Security
Imports System.Reflection

Public Class GestionUsuario
    Dim objNusuario As NEmpleado = New NEmpleado()
    Dim objDusuario As DEmpleado = New DEmpleado()
    Dim objNTipo_Usuario As NTipo_Usuario = New NTipo_Usuario()
    Dim index As Integer
    Dim nombre As String

    Private Sub GestionUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet6.Tipo_Usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_UsuarioTableAdapter1.Fill(Me.BaseDeDatosProyectoDataSet6.Tipo_Usuario)
        'TODO: esta línea de código carga datos en la tabla 'BaseDeDatosProyectoDataSet.Tipo_Usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_UsuarioTableAdapter.Fill(Me.BaseDeDatosProyectoDataSet.Tipo_Usuario)
        objNusuario.cargarGrid(DataGridView1)
        LEContraseña.Visible = False
    End Sub

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

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TApellido.Text) Or String.IsNullOrWhiteSpace(TDni.Text) Or String.IsNullOrWhiteSpace(TUsuario.Text) Or String.IsNullOrWhiteSpace(TContraseña.Text) Or String.IsNullOrWhiteSpace(DroplistTipo.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim ask As MsgBoxResult

            ask = MsgBox("Seguro que desea insertar un nuevo Usuario", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar insercion")
            If ask = MsgBoxResult.Yes Then
                Dim nombre As String
                Dim habilitado As String
                nombre = TNombre.Text
                If CBHabilitado.Checked Then
                    habilitado = "SI"
                Else
                    habilitado = "NO"
                End If
                If objNusuario.agregar_empleado(DroplistTipo.SelectedIndex + 1, TNombre.Text, TApellido.Text, CInt(TDni.Text), TUsuario.Text, TContraseña.Text, habilitado) Then
                    objNusuario.cargarGrid(DataGridView1)
                    borrar()
                    MsgBox("El Usuario: " + nombre + " se insertó correctamente", MsgBoxStyle.Information, "Guardar Usuario")
                Else
                    MsgBox("El Nombre de Usuario: '" + TUsuario.Text + "' ya existe", MsgBoxStyle.Critical, "Error Nombre de Usuario")
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If DataGridView1.RowCount > 0 Then
            nombre = DataGridView1.CurrentRow.Cells(2).Value
            index = DataGridView1.CurrentRow.Index

            DroplistTipo.SelectedValue = DataGridView1.CurrentRow.Cells(0).Value
            TDni.Text = DataGridView1.CurrentRow.Cells(1).Value
            TNombre.Text = DataGridView1.CurrentRow.Cells(2).Value
            TApellido.Text = DataGridView1.CurrentRow.Cells(3).Value
            TUsuario.Text = DataGridView1.CurrentRow.Cells(4).Value

            If DataGridView1.CurrentRow.Cells(5).Value = "SI" Then
                CBHabilitado.Checked = True
            Else
                CBHabilitado.Checked = False
            End If
            BAgregar.Enabled = False
            BEditar.Enabled = True
            LEContraseña.Visible = True
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        Dim nombre As String
        nombre = TNombre.Text
        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TApellido.Text) Or String.IsNullOrWhiteSpace(TDni.Text) Or String.IsNullOrWhiteSpace(TUsuario.Text) Or String.IsNullOrWhiteSpace(DroplistTipo.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea editar el usuario: " + nombre + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar insercion")
            If ask = MsgBoxResult.Yes Then
                Dim habilitado As String
                If CBHabilitado.Checked Then
                    habilitado = "SI"
                Else
                    habilitado = "NO"
                End If

                If String.IsNullOrWhiteSpace(TContraseña.Text) Then
                    If objDusuario.editEmpleadoSinContraseña(DataGridView1.CurrentRow.Cells(6).Value, TNombre.Text, TApellido.Text, CInt(TDni.Text), TUsuario.Text, DroplistTipo.SelectedIndex + 1, habilitado) Then
                        objNusuario.cargarGrid(DataGridView1)
                        borrar()
                        MsgBox("El Usuario: " + nombre + " se edito correctamente", MsgBoxStyle.Information, "Editar Usuario")
                        LEContraseña.Visible = False
                    Else
                        MsgBox("El Nombre de Usuario: '" + TUsuario.Text + "' ya existe", MsgBoxStyle.Critical, "Error Nombre de Usuario")
                    End If
                Else
                    If objDusuario.editEmpleado(DataGridView1.CurrentRow.Cells(6).Value, TNombre.Text, TApellido.Text, CInt(TDni.Text), TUsuario.Text, TContraseña.Text, DroplistTipo.SelectedIndex + 1, habilitado) Then
                        objNusuario.cargarGrid(DataGridView1)
                        borrar()
                        MsgBox("El Usuario: " + nombre + " se edito correctamente", MsgBoxStyle.Information, "Editar Usuario")
                        LEContraseña.Visible = False
                    Else
                        MsgBox("El Nombre de Usuario: '" + TUsuario.Text + "' ya existe", MsgBoxStyle.Critical, "Error Nombre de Usuario")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub borrar() Handles BCancelar.Click
        TNombre.Clear()
        TApellido.Clear()
        TDni.Clear()
        DroplistTipo.SelectedItem = Nothing
        TUsuario.Clear()
        TContraseña.Clear()
        DataGridView1.ClearSelection()
        BAgregar.Enabled = True
        BEditar.Enabled = False
    End Sub
    ' verificar email
    'If emailAddress.IndexOf("@") > -1 Then
    'If (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@")) Then
    '  errorMessage = "" 
    '   Return True
    'End If
    'End If
End Class