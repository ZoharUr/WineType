Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class vistaVendedor

    Dim Conex As conexionSQL
    Dim nombreDB As String = "SistemaComercial"

    Dim IdProducto As String

    Private Sub vistaVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NOmostrarProductos()

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesion.Click

        ' Realiza las operaciones necesarias para cerrar la sesión
        Me.Hide()
        Form1.Show()

        Conex = New conexionSQL

        ' Asegúrate de seleccionar la base de datos nuevamente antes de realizar nuevas operaciones
        Try
            ' Reemplaza "NombreDeTuBaseDeDatos" con el nombre real de tu base de datos
            Conex.EjecutarSQL($"USE {nombreDB};")
            MessageBox.Show("Sesión cerrada correctamente.", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegúrate de liberar recursos
            Conex.Dispose()
        End Try


    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        MsgBox("Apartado productos")
        mostrarProductos()
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
        Catch ex As Exception
            MsgBox("Error al insertar los productos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
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
            MsgBox("Los productos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
        Catch ex As Exception
            MsgBox("Error al insertar los productos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
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
            MsgBox("Los productos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
        Catch ex As Exception
            MsgBox("Error al insertar los productos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        MsgBox("Apartado ventas")
        NOmostrarProductos()
    End Sub

    Private Sub btn_historialVentas_Click(sender As Object, e As EventArgs) Handles btn_historialVentas.Click
        MsgBox("Apartado historial ventas")
        NOmostrarProductos()
    End Sub

    Sub mostrarProductos()
        btn_agregarProductos.Show()
        btn_modificarProductos.Show()
        btn_eliminarProducto.Show()
        dgv_productos.Show()
    End Sub

    Sub NOmostrarProductos()
        btn_agregarProductos.Hide()
        gb_producto.Hide()
        btn_modificarProductos.Hide()
        btn_eliminarProducto.Hide()
        dgv_productos.Hide()
    End Sub


End Class