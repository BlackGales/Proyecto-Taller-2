Imports System.Data.Entity.ModelConfiguration.Configuration
Imports System.Reflection

Public Class BuscarClienteCajero
    Dim objdcliente As DCliente = New DCliente()

    Dim formulario As VentaProducto = New VentaProducto()

    Public Sub GetData(ByVal form As VentaProducto)
        formulario = form
    End Sub

    Private Sub BuscarClienteCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBNombre.Checked = True
        CBNombre.Checked = True
        CBTelefono.Checked = True

        Limpiar()

        DataGridView1.DataSource = objdcliente.getClientesAll()
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TNombre.Text = DataGridView1.CurrentRow.Cells(0).Value
        TDni.Text = DataGridView1.CurrentRow.Cells(1).Value

        CBNombre.Checked = False
        CBNombre.Checked = False
        CBTelefono.Checked = False

        BSeleccionarCliente.Enabled = True
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (String.IsNullOrWhiteSpace(TNombre.Text) And CBNombre.Checked) Or (String.IsNullOrWhiteSpace(TDni.Text) And CBDni.Checked) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            If TDni.Text = "" Then
                TDni.Text = 0
            End If
            DataGridView1.DataSource = objdcliente.getClientesFiltro(TNombre.Text, CInt(TDni.Text), CBNombre.Checked, CBDni.Checked)
            DataGridView1.Columns(2).Visible = False
            TDni.Text = ""
        End If
    End Sub

    Private Sub BSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles BSeleccionarCliente.Click
        formulario.TCliente.Text = DataGridView1.CurrentRow.Cells(0).Value
        formulario.TDni.Text = DataGridView1.CurrentRow.Cells(1).Value
        formulario.idclienteFunc(DataGridView1.CurrentRow.Cells(2).Value)
        formulario.BDeseleccionar.Enabled = True
        Me.Close()
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
        DataGridView1.DataSource = objdcliente.getClientesAll()
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

    Private Sub ValidarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            LENumeros.Visible = True
            e.Handled = True
        Else
            LENumeros.Visible = False
        End If
    End Sub

    Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles CBNombre.CheckedChanged, CBDni.CheckedChanged, CBTelefono.CheckedChanged
        If CBNombre.Checked Then
            TNombre.Enabled = True
        Else
            TNombre.Enabled = False
        End If
        If CBDni.Checked Then
            TDni.Enabled = True
        Else
            TDni.Enabled = False
        End If
        If CBTelefono.Checked Then
            TTelefono.Enabled = True
        Else
            TTelefono.Enabled = False
        End If
    End Sub

    Private Sub Limpiar()
        TNombre.Clear()
        TDni.Clear()
        TTelefono.Clear()

        CBNombre.Checked = False
        CBNombre.Checked = False
        CBTelefono.Checked = False

        BSeleccionarCliente.Enabled = False
    End Sub
End Class