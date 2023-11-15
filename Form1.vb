Imports MySql.Data.MySqlClient
Public Class Form1

    Dim Conex As conexionSQL
    Dim nombreDB As String = "SistemaComercial"
    Public idUsuarioActual As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gb_iniciarSesion.Enabled = False
        gb_crearCuenta.Enabled = False

        Conex = New conexionSQL

        If Conex.Conexion_Error <> "" Then
            MsgBox(Conex.Conexion_Error)
        Else
            Try
                Dim Sql As String = $"USE {nombreDB}; SELECT * FROM Vendedor;"
                Conex.EjecutarSQL(Sql)
                Conex.Dispose()
                'MsgBox("La base de datos ya existe.")
                gb_iniciarSesion.Enabled = True
                gb_crearCuenta.Enabled = True
            Catch ex As Exception
                MsgBox("No se encontró la base de datos. Intentaré crearla.")

                ' Intenta crear la base de datos y las tablas.
                Dim Sql As String = $"CREATE DATABASE {nombreDB}; USE {nombreDB};
                                     CREATE TABLE Vendedor (ID_Vendedor TINYINT AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(30), Telefono VARCHAR(15) UNIQUE, Mail VARCHAR(30) UNIQUE, Password VARCHAR(20));
                                     CREATE TABLE Producto (ID_Producto TINYINT AUTO_INCREMENT PRIMARY KEY, Descripcion VARCHAR(50), Precio INT, Stock SMALLINT);
                                     CREATE TABLE Cliente (ID_Cliente TINYINT AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(30), Direccion VARCHAR(40), Telefono VARCHAR(15), Mail VARCHAR(30));
                                     CREATE TABLE Ventas (ID_Venta TINYINT AUTO_INCREMENT PRIMARY KEY, Fecha DATETIME, ID_Vendedor TINYINT, ID_Cliente TINYINT, ID_Producto TINYINT, Cantidad INT, PrecioUnitario INT, MontoTotal DECIMAL(10, 2), FOREIGN KEY (ID_Vendedor) REFERENCES Vendedor(ID_Vendedor), FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente), FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto));"

                Try
                    Conex.EjecutarSQL(Sql)
                    MsgBox("Se creó la base de datos y las tablas.")
                    gb_iniciarSesion.Enabled = True
                    gb_crearCuenta.Enabled = True
                Catch ex2 As Exception
                    MsgBox("Error al crear la base de datos y las tablas." & vbCrLf & ex2.Message, MsgBoxStyle.Critical, "Error en la creación de la base de datos")
                End Try
                Conex.Dispose()
            End Try
        End If
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            Conex = New conexionSQL
            Dim Sql As String = $"USE {nombreDB};"
            Conex.EjecutarSQL(Sql)

            If txt_user.Text = "" Or txt_password.Text = "" Then
                MessageBox.Show("Ingrese el mail o teléfono y la contraseña.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Conex.VerificarCredenciales(txt_user.Text.Trim(), txt_password.Text.Trim()) Then
                    MessageBox.Show("Inicio de sesión exitoso.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Sql = $"SELECT ID_Vendedor FROM Vendedor WHERE Mail = '{txt_user.Text.Trim()}' OR Telefono = '{txt_user.Text.Trim()}'"
                    Conex.miComando = New MySqlCommand(Sql, Conex.miConexion)
                    Dim resultado As Object = Conex.miComando.ExecuteScalar()
                    idUsuarioActual = Convert.ToInt32(resultado)

                    'MsgBox(idUsuarioActual)

                    LimpiarSesion()
                    vistaVendedor.Show()
                    Me.Hide()
                Else
                    LimpiarSesion()
                    MessageBox.Show("Credenciales incorrectas. Verifique el mail o teléfono y la contraseña.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conex.Dispose()
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub link_registro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_registro.LinkClicked
        Registro.Show()
        LimpiarSesion()
        Me.Hide()
    End Sub

    Sub LimpiarSesion()
        txt_user.Text = ""
        txt_password.Text = ""
    End Sub

End Class
