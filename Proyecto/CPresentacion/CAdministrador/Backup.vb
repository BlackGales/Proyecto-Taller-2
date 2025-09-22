Imports System.Data.SqlClient

Public Class Backup
    Dim sSelectedPath As String
    Dim sSelectedFile As String

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BBackup.Enabled = False
    End Sub

    Public Function backup(ByVal p_direccion As String, ByVal p_nombreResguardo As String)
        Try
            Dim conexion As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BaseDeDatosProyecto;Integrated Security=True")

            Dim cmd As SqlCommand = New SqlCommand("BACKUP DATABASE [BaseDeDatosProyecto] TO  DISK = N'" & p_direccion & p_nombreResguardo & ".bak' WITH NOFORMAT, NOINIT,  NAME = N'BaseDeDatosProyecto-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function restaurarDatos(p_nombreResguardo As String)
        Try
            Dim conexion As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BaseDeDatosProyecto;Integrated Security=True")
            Using conexion
                conexion.Open()
                Dim cmd As New SqlCommand("ALTER DATABASE [BaseDeDatosProyecto] SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [BaseDeDatosProyecto] FROM disk='" & p_nombreResguardo & "'", conexion)
                cmd.ExecuteNonQuery()
                conexion.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub BSeleccionar_Click(sender As Object, e As EventArgs) Handles BSeleccionar.Click
        Dim fbd = New FolderBrowserDialog()
        fbd.Description = "Custom Description"
        If (fbd.ShowDialog() = DialogResult.OK) Then
            sSelectedPath = fbd.SelectedPath
            BBackup.Enabled = True
        Else
            MsgBox("Debe seleccionar un destino")
        End If
    End Sub

    Private Sub BBackup_Click(sender As Object, e As EventArgs) Handles BBackup.Click
        If String.IsNullOrEmpty(TNombreBackup.Text) Then
            MsgBox("Debe ponerle un nombre al archivo", MsgBoxStyle.Critical, "Error Nombre Archivo")
        Else
            If backup(sSelectedPath, "\" + TNombreBackup.Text) Then
                MsgBox("Backup realizado")
            Else
                MsgBox("Error al realizar backup")
            End If
        End If
    End Sub

    Private Sub BRestaurar_Click(sender As Object, e As EventArgs) Handles BRestaurar.Click
        If String.IsNullOrEmpty(sSelectedFile) Then
            MsgBox("Debe seleccionar un archivo para restaurar", MsgBoxStyle.Critical, "Error Nombre Archivo")
        Else
            If restaurarDatos(sSelectedFile) Then
                MsgBox("Restauracion realizada")
            Else
                MsgBox("Error al realizar restauracion")
            End If
        End If
    End Sub

    Private Sub BSeleccionarRestaurar_Click(sender As Object, e As EventArgs) Handles BSeleccionarRestaurar.Click
        OpenFileDialog1.InitialDirectory = "C:\\"
        OpenFileDialog1.Filter = "Todos los Archivos (*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            sSelectedFile = OpenFileDialog1.FileName.ToString()
        Else
            MsgBox("Debe seleccionar un archivo para restaurar", MsgBoxStyle.Critical, "Error Nombre Archivo")
        End If
    End Sub
End Class