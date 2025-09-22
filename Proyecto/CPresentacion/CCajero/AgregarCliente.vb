Imports System.Net.Security
Imports System.Reflection

Public Class AgregarCliente
    Dim objNcliente As NCliente = New NCliente()
    Dim objdcliente As DCliente = New DCliente()
    Dim nombre As String

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = objdcliente.getClientesAll()
        BEditar.Enabled = False
        TNombreBuscar.Enabled = False
        TDniBuscar.Enabled = False
        BBuscar.Enabled = False
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        With TNombre
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub ValidarNumeros2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDniBuscar.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumerosBuscar.Visible = True
            e.Handled = True
        Else
            LENumerosBuscar.Visible = False
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TDni.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar un nuevo Cliente", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar insercion")
            If ask = MsgBoxResult.Yes Then
                nombre = TNombre.Text
                If objNcliente.agregar_cliente(TNombre.Text, TDni.Text) Then
                    DataGridView1.DataSource = objdcliente.getClientesAll()
                    BCancelar_Click()
                    MsgBox("El cliente: " + nombre + " se insertó correctamente", MsgBoxStyle.Information, "Guardar Cliente")
                Else
                    MsgBox("El cliente: " + nombre + " se ya existe", MsgBoxStyle.Critical, "Error Cliente")
                End If
            End If
        End If
    End Sub

    Private Sub BCancelar_Click() Handles BCancelar.Click
        TNombre.Clear()
        TDni.Clear()
        TDniBuscar.Clear()
        TNombreBuscar.Clear()
        DataGridView1.ClearSelection()
        BAgregar.Enabled = True
        BEditar.Enabled = False
        DataGridView1.DataSource = objdcliente.getClientesAll()
    End Sub


    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (String.IsNullOrWhiteSpace(TNombreBuscar.Text) And CBNombre.Checked) Or (String.IsNullOrWhiteSpace(TDniBuscar.Text) And CBDni.Checked) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            If TDniBuscar.Text = "" Then
                TDniBuscar.Text = 0
            End If
            DataGridView1.DataSource = objdcliente.getClientesFiltro(TNombreBuscar.Text, CInt(TDniBuscar.Text), CBNombre.Checked, CBDni.Checked)
            DataGridView1.Columns(2).Visible = False
            TDniBuscar.Text = ""
        End If
    End Sub

    Private Sub BEditar_Click(sender As Object, e As EventArgs) Handles BEditar.Click
        If DataGridView1.RowCount > 0 Then
            If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TDni.Text) Then
                MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
            Else
                Dim ask As MsgBoxResult
                ask = MsgBox("Seguro que desea editar los valores del cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Confirmar edición")
                If ask = MsgBoxResult.Yes Then
                    If objdcliente.editarCliente(DataGridView1.CurrentRow.Cells(2).Value, TNombre.Text, TDni.Text) Then
                        DataGridView1.DataSource = objdcliente.getClientesAll()
                        BCancelar_Click()
                        MsgBox("El Cliente: " + nombre + " se editó correctamente", MsgBoxStyle.Information, "Editar Cliente")
                        BEditar.Enabled = False
                        BAgregar.Enabled = True
                    End If
                End If
            End If
        Else
            MsgBox("No hay clientes que editar", MsgBoxStyle.Critical, "Error Seleccion")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TNombre.Text = DataGridView1.CurrentRow.Cells(0).Value
        TDni.Text = DataGridView1.CurrentRow.Cells(1).Value
        BEditar.Enabled = True
        BAgregar.Enabled = False
    End Sub

    Private Sub CBNombre_CheckedChanged(sender As Object, e As EventArgs) Handles CBNombre.CheckedChanged, CBDni.CheckedChanged
        If CBNombre.Checked Then
            TNombreBuscar.Enabled = True
        Else
            TNombreBuscar.Enabled = False
        End If
        If CBDni.Checked Then
            TDniBuscar.Enabled = True
        Else
            TDniBuscar.Enabled = False
        End If
        If CBNombre.Checked Or CBDni.Checked Then
            BBuscar.Enabled = True
        Else
            BBuscar.Enabled = False
        End If
    End Sub
End Class