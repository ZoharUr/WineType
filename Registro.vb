Imports System.Security.Policy

Public Class Registro

    Dim Conex As conexionSQL
    Dim nombreDB As String = "SistemaComercial"

    Dim id As String

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_registrarte_Click(sender As Object, e As EventArgs) Handles btn_registrarte.Click
        Dim SQL As String
        Conex = New conexionSQL(nombreDB)
        Try
            SQL = "INSERT INTO Vendedor VALUES('" + id + "','" + txt_nombre.Text + "','" + txt_telefono.Text + "','" + txt_mail.Text + "','" + txt_password.Text + "')"
            Conex.EjecutarSQL(SQL)
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