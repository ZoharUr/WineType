Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Public Class conexionSQL

    Public miConexion As New MySqlConnection
    Public miComando As New MySqlCommand
    Public miDataAdapter As MySqlDataAdapter
    Public miDataTable As DataTable
    Public Conexion_Error As String

    Public Sub New(Nombre As String)
        Try
            miConexion.ConnectionString = "Server=127.0.0.1;Database=" + Nombre + ";Uid=root"
            miConexion.Open()
            miComando.Connection = miConexion
            Conexion_Error = ""
        Catch ex As Exception
            Conexion_Error = ex.Message
        End Try
    End Sub

    Public Sub New()
        Try
            miConexion.ConnectionString = "Server=127.0.0.1;Uid=root;"
            miConexion.Open()
            miComando.Connection = miConexion
            Conexion_Error = ""
        Catch ex As Exception
            Conexion_Error = ex.Message
        End Try
    End Sub

    Public Sub EjecutarSQL(SentenciaSQL As String)
        miComando.CommandText = SentenciaSQL
        miComando.ExecuteNonQuery()
    End Sub

    Public Function EjecutarSQLResp(SentenciaSQL As String)
        miComando.CommandText = SentenciaSQL
        Return miComando.ExecuteScalar()
    End Function

    Public Sub Dispose()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()
    End Sub

    Public Function VerificarCredenciales(mailOtelefono As String, password As String) As Boolean
        Dim sql As String = $"SELECT COUNT(*) FROM Vendedor WHERE (Mail = '{mailOtelefono}' OR Telefono = '{mailOtelefono}') AND Password = '{password}'"
        Try
            miComando.CommandText = sql
            Dim count As Integer = Convert.ToInt32(miComando.ExecuteScalar())

            Return count > 0
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
