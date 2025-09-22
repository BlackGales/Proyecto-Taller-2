Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Interfaces
Imports Microsoft.SqlServer
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Dim ctx As BaseDeDatosProyectoEntities = New BaseDeDatosProyectoEntities()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim path = System.IO.Directory.GetCurrentDirectory + "\..\..\CPresentacion\Report1.rdlc"
        'ReportViewer1.LocalReport.ReportPath = path

        Dim datasource As New ReportDataSource("DataSet1", ctx.obtenerProductosVendidosCategoria("23/11/2022", "24/11/2022"))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(datasource)

        Me.ReportViewer1.RefreshReport()

    End Sub



    'Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    If Not IsPostBack Then
    '        ReportViewer1.ProcessingMode = ProcessingMode.Local
    '        ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc")
    '        Dim dsCustomers As Customers = GetData("select top 20 * from customers")
    '        Dim datasource As New ReportDataSource("Customers", dsCustomers.Tables(0))
    '        ReportViewer1.LocalReport.DataSources.Clear()
    '        ReportViewer1.LocalReport.DataSources.Add(datasource)
    '    End If
    'End Sub

    'Private Function GetData(query As String) As Customers
    '    Dim conString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Dim cmd As New SqlCommand(query)
    '    Using con As New SqlConnection(conString)
    '        Using sda As New SqlDataAdapter()
    '            cmd.Connection = con

    '            sda.SelectCommand = cmd
    '            Using dsCustomers As New Customers()
    '                sda.Fill(dsCustomers, "DataTable1")
    '                Return dsCustomers
    '            End Using
    '        End Using
    '    End Using
    'End Function

End Class