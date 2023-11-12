Imports MySql.Data.MySqlClient
Public Class conexionSQL
    Private miConexion As New MySqlConnection
    Public miComando As New MySqlCommand
    Public miDataAdapter As MySqlDataAdapter
    Public miDataSet As DataSet
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

    Public Sub Dispose()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()
    End Sub

    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(miConexion.ConnectionString)
    End Function

    ' Método para verificar las credenciales del vendedor
    Public Function VerificarCredenciales(mailOtelefono As String, password As String) As Boolean
        Try
            Using con As MySqlConnection = ObtenerConexion()
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM Vendedor WHERE (Mail = @MailOtelefono OR Telefono = @MailOtelefono) AND Password = @Password"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MailOtelefono", mailOtelefono)
                    cmd.Parameters.AddWithValue("@Password", password)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            ' Manejar errores relacionados con la verificación de credenciales
            Conexion_Error = ex.Message
            Return False
        End Try
    End Function

End Class
