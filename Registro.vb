Imports MySql.Data.MySqlClient

Public Class Registro

    Dim Conex As conexionSQL
    Dim nombreDB As String = "SistemaComercial"
    Dim IdVendedor As String


    Private Sub btn_registrarte_Click(sender As Object, e As EventArgs) Handles btn_registrarte.Click
        Dim Sql As String
        Conex = New conexionSQL(nombreDB)
        Try
            Sql = "INSERT INTO Vendedor VALUES('" + IdVendedor + "','" + txt_nombre.Text.Trim() + "','" + txt_telefono.Text.Trim() + "','" + txt_mail.Text.Trim() + "','" + txt_password.Text.Trim() + "')"
            Conex.EjecutarSQL(Sql)
            Conex.Dispose()
            MsgBox("Los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
        Catch ex As Exception
            MsgBox("Error al insertar el registro." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
        LimpiarRegistro()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub link_iniciarSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_iniciarSesion.LinkClicked
        LimpiarRegistro()
        Me.Hide()
        Form1.Show()
    End Sub

    Sub LimpiarRegistro()
        txt_telefono.Text = ""
        txt_mail.Text = ""
        txt_nombre.Text = ""
        txt_password.Text = ""
    End Sub
End Class