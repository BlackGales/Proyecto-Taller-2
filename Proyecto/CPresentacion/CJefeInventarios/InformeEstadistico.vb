Public Class InformeEstadistico
    Private Sub InformeEstadistico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FechaDesde_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class