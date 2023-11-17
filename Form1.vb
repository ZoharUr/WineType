Imports MySql.Data.MySqlClient
Public Class Form1

    Dim Conex As conexionSQL
    Public nombreDB As String = "SistemaComercial"
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
                                     CREATE TABLE Vendedor (ID_Vendedor TINYINT NOT NULL AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(30) NOT NULL, Telefono VARCHAR(15) NOT NULL UNIQUE, Mail VARCHAR(30) NOT NULL UNIQUE, Password VARCHAR(20) NOT NULL);
                                     CREATE TABLE Producto (ID_Producto TINYINT NOT NULL AUTO_INCREMENT PRIMARY KEY, Descripcion VARCHAR(50) NOT NULL, Precio INT NOT NULL, Stock SMALLINT NOT NULL);
                                     CREATE TABLE Cliente (ID_Cliente TINYINT NOT NULL AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(30) NOT NULL, Direccion VARCHAR(40) NOT NULL, Telefono VARCHAR(15) NOT NULL, Mail VARCHAR(30) NOT NULL);
                                     CREATE TABLE Venta (ID_Venta TINYINT NOT NULL AUTO_INCREMENT PRIMARY KEY, Fecha DATE, ID_Vendedor TINYINT, ID_Cliente TINYINT, FOREIGN KEY (ID_Vendedor) REFERENCES Vendedor(ID_Vendedor), FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente));
                                     CREATE TABLE VentaProducto(ID_VentaProducto TINYINT NOT NULL AUTO_INCREMENT, ID_Venta TINYINT NOT NULL, ID_Producto TINYINT NOT NULL, CantidadVendida INT NOT NULL, PRIMARY KEY (ID_VentaProducto, ID_Venta, ID_Producto), FOREIGN KEY(ID_Venta) References Venta(ID_Venta), FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto));"

                Try
                    Conex.EjecutarSQL(Sql)
                    MsgBox("Se creó la base de datos y las tablas.")

                    Sql = "INSERT INTO Cliente (Nombre, Direccion, Telefono, Mail) VALUES
                            ('Juan Pérez', 'Calle 123, Ciudad A', '555-1234', 'juan.perez@mail.com'),
                            ('Ana Gómez', 'Avenida XYZ, Ciudad B', '555-5678', 'ana.gomez@mail.com'),
                            ('Carlos Rodríguez', 'Calle ABC, Ciudad C', '555-9876', 'carlos.rodriguez@mail.com'),
                            ('María López', 'Avenida 456, Ciudad A', '555-4321', 'maria.lopez@mail.com'),
                            ('Pedro Martínez', 'Calle DEF, Ciudad B', '555-8765', 'pedro.martinez@mail.com'),
                            ('Laura Sánchez', 'Avenida 789, Ciudad C', '555-2345', 'laura.sanchez@mail.com'),
                            ('Roberto González', 'Calle GHI, Ciudad A', '555-7654', 'roberto.gonzalez@mail.com'),
                            ('Sofía Díaz', 'Avenida 012, Ciudad B', '555-3456', 'sofia.diaz@mail.com'),
                            ('Javier Ramírez', 'Calle JKL, Ciudad C', '555-6543', 'javier.ramirez@mail.com'),
                            ('Elena Castro', 'Avenida 345, Ciudad A', '555-8765', 'elena.castro@mail.com'),
                            ('Francisco Núñez', 'Calle MNO, Ciudad B', '555-3456', 'francisco.nunez@mail.com'),
                            ('Carmen Herrera', 'Avenida 678, Ciudad C', '555-9876', 'carmen.herrera@mail.com'),
                            ('Andrés Vargas', 'Calle PQR, Ciudad A', '555-2345', 'andres.vargas@mail.com'),
                            ('Isabel Guzmán', 'Avenida 901, Ciudad B', '555-8765', 'isabel.guzman@mail.com'),
                            ('Miguel Soto', 'Calle STU, Ciudad C', '555-4321', 'miguel.soto@mail.com'),
                            ('Patricia Ortega', 'Avenida 234, Ciudad A', '555-6543', 'patricia.ortega@mail.com'),
                            ('Fernando Reyes', 'Calle VWX, Ciudad B', '555-2345', 'fernando.reyes@mail.com'),
                            ('Raquel Jiménez', 'Avenida 567, Ciudad C', '555-9876', 'raquel.jimenez@mail.com'),
                            ('Alejandro Mendoza', 'Calle YZA, Ciudad A', '555-8765', 'alejandro.mendoza@mail.com'),
                            ('Gloria Torres', 'Avenida 890, Ciudad B', '555-3456', 'gloria.torres@mail.com');"

                    Conex.EjecutarSQL(Sql)

                    Sql = "INSERT INTO Producto (Descripcion, Precio, Stock) VALUES
                            ('Vino Tinto Reserva 2019', 25.99, 50),
                            ('Vino Blanco Seco 2020', 19.99, 40),
                            ('Cabernet Sauvignon 2018', 29.99, 30),
                            ('Chardonnay Premium 2019', 22.99, 25),
                            ('Malbec Roble 2021', 27.99, 35),
                            ('Sauvignon Blanc 2020', 18.99, 45),
                            ('Merlot Gran Reserva 2017', 32.99, 20),
                            ('Rosado Semi Seco 2021', 23.99, 30),
                            ('Vino Espumante Brut', 26.99, 15),
                            ('Vino Syrah 2018', 28.99, 28);"

                    Conex.EjecutarSQL(Sql)

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

                    Sql = $"SELECT ID_Vendedor FROM Vendedor WHERE Mail = '{txt_user.Text.Trim()}' AND Telefono = '{txt_user.Text.Trim()}'"
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
