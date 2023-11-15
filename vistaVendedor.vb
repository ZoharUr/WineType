Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class vistaVendedor

    Dim Conex As conexionSQL
    Dim nombreDB As String = "SistemaComercial"
    Dim IdProducto As String
    Dim IdVenta As String

    Private Sub vistaVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NOmostrarProductos()

        NOmostrarVenta()
        NOmostrarHistorial()

        Dim Sql As String
        Conex = New conexionSQL(nombreDB)

        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_productos.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try
        Try
            Sql = "SELECT * FROM Ventas;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_historialVentas.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar las ventas")
        End Try

        Try
            Sql = $"SELECT ID_Cliente,Fecha,ID_Producto,Cantidad,MontoTotal FROM Ventas WHERE ID_Vendedor = {Form1.idUsuarioActual} ;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_historialVentas.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar el historial de ventas")
        End Try
        Conex.Dispose()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesion.Click

        Me.Hide()
        Form1.Show()
        Conex = New conexionSQL
        Try
            Conex.EjecutarSQL($"USE {nombreDB};")
            MessageBox.Show("Sesión cerrada correctamente.", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Dispose()

    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        'MsgBox("Apartado productos")
        mostrarProductos()
        NOmostrarVenta()
        NOmostrarHistorial()

        Dim Sql As String
        Conex = New conexionSQL(nombreDB)
        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_productos.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try

        Conex.Dispose()

    End Sub

    Private Sub btn_agregarProductos_Click(sender As Object, e As EventArgs) Handles btn_agregarProductos.Click
        gb_producto.Show()
        txt_idProducto.Hide()
        txt_descripcion.Show()
        txt_precio.Show()
        txt_stock.Show()
        btn_agregar.Show()
        btn_modificar.Hide()
        btn_eliminar.Hide()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If Val(txt_precio.Text) < 1 Or Val(txt_stock.Text) < 1 Then
            MsgBox("ERROR: Asegurate de que le precio y el stock sean mayores a 0")
        Else
            Dim Sql As String
            Conex = New conexionSQL(nombreDB)
            Try
                Sql = "INSERT INTO Producto VALUES('" + IdProducto + "','" + txt_descripcion.Text.Trim() + "','" + txt_precio.Text.Trim() + "','" + txt_stock.Text.Trim() + "')"
                Conex.EjecutarSQL(Sql)
                Try
                    Sql = "SELECT * FROM Producto;"
                    Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                    Conex.miDataTable = New DataTable
                    Conex.miDataAdapter.Fill(Conex.miDataTable)
                    dgv_productos.DataSource = Conex.miDataTable
                Catch ex As Exception
                    MsgBox("Error al mostrar los productos")
                End Try
                Conex.Dispose()
                MsgBox("Los productos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")

                txt_idProducto.Text = ""
                txt_descripcion.Text = ""
                txt_precio.Text = ""
                txt_stock.Text = ""

            Catch ex As Exception
                MsgBox("Error al insertar los productos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
        End If

    End Sub

    Private Sub btn_modificarProductos_Click(sender As Object, e As EventArgs) Handles btn_modificarProductos.Click
        gb_producto.Show()
        txt_idProducto.Show()
        txt_descripcion.Show()
        txt_precio.Show()
        txt_stock.Show()
        btn_agregar.Hide()
        btn_modificar.Show()
        btn_eliminar.Hide()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        If Val(txt_precio.Text) < 1 Or Val(txt_stock.Text) < 1 Then
            MsgBox("ERROR: Asegurate de que le precio y el stock sean mayores a 0")
        Else
            Dim Sql As String
            Conex = New conexionSQL(nombreDB)
            Try
                Sql = $"UPDATE Producto SET Descripcion = '{txt_descripcion.Text.Trim()}', Precio = '{txt_precio.Text.Trim()}', Stock = '{txt_stock.Text.Trim()}' WHERE ID_Producto = {txt_idProducto.Text.Trim()};"
                Conex.EjecutarSQL(Sql)
                Try
                    Sql = "SELECT * FROM Producto;"
                    Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                    Conex.miDataTable = New DataTable
                    Conex.miDataAdapter.Fill(Conex.miDataTable)
                    dgv_productos.DataSource = Conex.miDataTable
                Catch ex As Exception
                    MsgBox("Error al mostrar los productos")
                End Try
                Conex.Dispose()
                MsgBox("Los productos se modificaron correctamente", MsgBoxStyle.Information, "Insertar Datos")

                txt_idProducto.Text = ""
                txt_descripcion.Text = ""
                txt_precio.Text = ""
                txt_stock.Text = ""

            Catch ex As Exception
                MsgBox("Error al insertar los productos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
        End If
    End Sub

    Private Sub btn_eliminarProducto_Click(sender As Object, e As EventArgs) Handles btn_eliminarProducto.Click
        gb_producto.Show()
        txt_idProducto.Show()
        txt_descripcion.Hide()
        txt_precio.Hide()
        txt_stock.Hide()
        btn_agregar.Hide()
        btn_modificar.Hide()
        btn_eliminar.Show()
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim Sql As String
        Conex = New conexionSQL(nombreDB)
        Try
            Sql = $"DELETE FROM Producto WHERE ID_Producto = {txt_idProducto.Text.Trim()};"
            Conex.EjecutarSQL(Sql)
            Try
                Sql = "SELECT * FROM Producto;"
                Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                Conex.miDataTable = New DataTable
                Conex.miDataAdapter.Fill(Conex.miDataTable)
                dgv_productos.DataSource = Conex.miDataTable
            Catch ex As Exception
                MsgBox("Error al mostrar los productos")
            End Try
            Conex.Dispose()
            MsgBox("El producto se elimino correctamente", MsgBoxStyle.Information, "Insertar Datos")

            txt_idProducto.Text = ""
            txt_descripcion.Text = ""
            txt_precio.Text = ""
            txt_stock.Text = ""

        Catch ex As Exception
            MsgBox("Error al insertar los productos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        'MsgBox("Apartado ventas")
        NOmostrarProductos()
        mostrarVenta()
        NOmostrarHistorial()

        Dim Sql As String
        Conex = New conexionSQL(nombreDB)
        Try
            Sql = "SELECT * FROM Cliente;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_clientes.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los clientes")
        End Try

        Conex.Dispose()

    End Sub

    Private Sub btn_historialVentas_Click(sender As Object, e As EventArgs) Handles btn_historialVentas.Click
        'MsgBox("Apartado historial ventas")
        NOmostrarProductos()
        NOmostrarVenta()
        mostrarHistorial()

        Dim Sql As String
        Conex = New conexionSQL(nombreDB)

        Try
            Sql = $"SELECT ID_Cliente,Fecha,ID_Producto,Cantidad,MontoTotal FROM Ventas WHERE ID_Vendedor = {Form1.idUsuarioActual} ;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_historialVentas.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar el historial de ventas")
        End Try

        Conex.Dispose()
    End Sub

    Sub mostrarProductos()
        gb_producto.Show()
        btn_agregarProductos.Show()
        btn_modificarProductos.Show()
        btn_eliminarProducto.Show()
        dgv_productos.Show()
        gb_producto.Location = New System.Drawing.Point(6, 22)
    End Sub

    Sub mostrarVenta()
        gb_ventas.Show()
        gb_ventas.Location = New System.Drawing.Point(6, 22)
    End Sub

    Sub mostrarHistorial()
        gb_historial.Show()
        gb_historial.Location = New System.Drawing.Point(6, 22)
    End Sub

    Sub NOmostrarProductos()
        txt_idProducto.Hide()
        btn_eliminar.Hide()
        btn_modificar.Hide()
        btn_agregarProductos.Hide()
        gb_producto.Hide()
        btn_modificarProductos.Hide()
        btn_eliminarProducto.Hide()
        dgv_productos.Hide()
    End Sub

    Sub NOmostrarVenta()
        gb_ventas.Hide()
    End Sub

    Sub NOmostrarHistorial()
        gb_historial.Hide()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_idProdVenta.Text = ""
        txt_cantidadVender.Text = ""
        txt_idCliente.Text = ""
    End Sub

    Private Sub btn_vender_Click(sender As Object, e As EventArgs) Handles btn_vender.Click
        If Val(txt_cantidadVender.Text) < 1 Then
            MsgBox("ERROR: Asegurate de que la cantidad que desas vender sea mayor a 0")
        Else
            Dim Sql As String
            Conex = New conexionSQL(nombreDB)

            Dim fechaHoraActual As DateTime = DateTime.Now
            Dim fechaHoraFormateada As String = fechaHoraActual.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)

            Try
                Sql = $"SELECT Stock FROM Producto WHERE ID_Producto = {txt_idProdVenta.Text.Trim()};"

                Conex.miComando = New MySqlCommand(Sql, Conex.miConexion)
                Dim resultado As Object = Conex.miComando.ExecuteScalar()
                Dim stockActual As Integer = Convert.ToInt32(resultado)

                Sql = $"SELECT Precio FROM Producto WHERE ID_Producto = {txt_idProdVenta.Text.Trim()};"
                Conex.miComando = New MySqlCommand(Sql, Conex.miConexion)
                resultado = Conex.miComando.ExecuteScalar()
                Dim precioUnitario As Integer = Convert.ToInt32(resultado)



                If stockActual >= Val(txt_cantidadVender.Text.Trim()) Then

                    Sql = $"INSERT INTO Ventas (Fecha, ID_Vendedor, ID_Cliente, ID_Producto, Cantidad, PrecioUnitario, MontoTotal) VALUES ('{fechaHoraFormateada}', '{Form1.idUsuarioActual}', '{Val(txt_idCliente.Text.Trim())}', '{Val(txt_idProdVenta.Text.Trim())}', '{Val(txt_cantidadVender.Text.Trim())}', '{precioUnitario}', '{Val(txt_cantidadVender.Text.Trim()) * precioUnitario}');"
                    Conex.EjecutarSQL(Sql)

                    Sql = $"UPDATE Producto SET Stock = Stock - {Val(txt_cantidadVender.Text.Trim())} WHERE ID_Producto = {txt_idProdVenta.Text.Trim()};"
                    Conex.EjecutarSQL(Sql)

                    ' historial de ventas actualizado -------------------------------------------
                    Try
                        Sql = $"SELECT ID_Cliente,Fecha,ID_Producto,Cantidad,MontoTotal FROM Ventas WHERE ID_Vendedor = {Form1.idUsuarioActual} ;"
                        Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                        Conex.miDataTable = New DataTable
                        Conex.miDataAdapter.Fill(Conex.miDataTable)
                        dgv_historialVentas.DataSource = Conex.miDataTable
                    Catch ex As Exception
                        MsgBox("Error al mostrar el historial de ventas")
                    End Try
                    '----------------------------------------------------------------------------

                    Conex.Dispose()
                    MsgBox("La venta se cerró correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Else

                    MsgBox("No hay suficiente stock para realizar la venta.", MsgBoxStyle.Exclamation, "Stock Insuficiente")
                End If
            Catch ex As Exception
                MsgBox("Error al cerrar la venta." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
        End If
    End Sub

End Class