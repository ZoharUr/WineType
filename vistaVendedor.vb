Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Pqc.Crypto.Falcon

Public Class vistaVendedor

    Dim Conex As conexionSQL
    Dim nombreDB As String = Form1.nombreDB

    Dim prodSeleccionado(-1) As String



    Private Sub vistaVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gb_producto.Hide()
        gb_ventas.Hide()
        gb_historial.Hide()

        dgv_clientes.Enabled = True
        dgv_prductosVenta.Enabled = False
        txt_cantidadVender.Text = ""
        txt_cantidadVender.Enabled = False
        btn_confirmarVenta.Enabled = False
        btn_cancelarVenta.Enabled = False
        lb_detalles.Items.Clear()

        Conex = New conexionSQL(nombreDB)

        Dim Sql As String

        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_verProductos.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try

        Try
            Sql = "SELECT * FROM Cliente;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_clientes.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los clientes")
        End Try

        Try
            Sql = $"SELECT * FROM Venta WHERE ID_Vendedor = '{Form1.idUsuarioActual}';"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_historialVentas.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar el historial de ventas")
        End Try


        Try
            Sql = $"SELECT ID_Venta, ID_Producto, CantidadVendida FROM VentaProducto WHERE ID_VentaProducto = 0;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_detallesVenta.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar el historial de ventas")
        End Try


    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        gb_producto.Show()
        gb_ventas.Hide()
        gb_historial.Hide()


        Conex = New conexionSQL(nombreDB)

        Dim Sql As String

        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_verProductos.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try


    End Sub

    Private Sub btn_crearProd_Click(sender As Object, e As EventArgs) Handles btn_crearProd.Click
        If txt_descripcionProd.Text = "" Or txt_precioProd.Text = "" Or txt_stockProd.Text = "" Then
            MsgBox("ERROR: Asegurese de completar todos los campos")
        Else
            If Val(txt_precioProd.Text) < 1 Or Val(txt_stockProd.Text) < 1 Then
                MsgBox("ERROR: Los campos 'Precio' y 'Stock' deben ser mayores a 0")
            Else
                Conex = New conexionSQL(nombreDB)

                Dim Sql As String = $"INSERT INTO Producto (Descripcion, Precio, Stock) VALUES ('{txt_descripcionProd.Text}', '{Val(txt_precioProd.Text)}', '{Val(txt_stockProd.Text)}')"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se ingreso correctamente", MsgBoxStyle.Information, "Insertar Datos")

                    Try
                        Sql = "SELECT * FROM Producto;"
                        Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                        Conex.miDataTable = New DataTable
                        Conex.miDataAdapter.Fill(Conex.miDataTable)
                        dgv_verProductos.DataSource = Conex.miDataTable
                    Catch ex As Exception
                        MsgBox("Error al mostrar los productos")
                    End Try

                Catch ex As Exception
                    MsgBox("ERROR: No se pudo ingresar el producto")
                End Try
            End If


        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_modificarProd.Click
        Conex = New conexionSQL(nombreDB)
        Dim Sql As String





        If txt_descripcionProd.Text = "" And txt_precioProd.Text = "" And txt_stockProd.Text = "" Then


            MsgBox("ERROR: Debe completar al menos un campo para poder modificar un producto")


        ElseIf txt_descripcionProd.Text = "" And txt_precioProd.Text = "" And txt_stockProd.Text <> "" Then

            If Val(txt_stockProd.Text) < 1 Then
                MsgBox("ERROR: El campo 'Stock' debe ser mayor a 0")
            Else
                Conex = New conexionSQL(nombreDB)
                Sql = $"UPDATE Producto SET Stock = '{txt_stockProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("ERROR: No se pudo modificar el producto")
                End Try
            End If

        ElseIf txt_descripcionProd.Text = "" And txt_precioProd.Text <> "" And txt_stockProd.Text = "" Then

            If Val(txt_precioProd.Text) < 1 Then
                MsgBox("ERROR: El campo 'Precio' debe ser mayor a 0")
            Else
                Conex = New conexionSQL(nombreDB)
                Sql = $"UPDATE Producto SET Precio = '{txt_precioProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("ERROR: No se pudo modificar el producto")
                End Try
            End If

        ElseIf txt_descripcionProd.Text = "" And txt_precioProd.Text <> "" And txt_stockProd.Text <> "" Then

            If Val(txt_precioProd.Text) < 1 Or Val(txt_stockProd.Text) < 1 Then
                MsgBox("ERROR: Los campos 'Precio' y 'Stock' deben ser mayores a 0")
            Else
                Conex = New conexionSQL(nombreDB)
                Sql = $"UPDATE Producto SET Precio = '{txt_precioProd.Text.Trim()}', Stock = '{txt_stockProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("ERROR: No se pudo modificar el producto")
                End Try
            End If

        ElseIf txt_descripcionProd.Text <> "" And txt_precioProd.Text = "" And txt_stockProd.Text = "" Then

            Sql = $"UPDATE Producto SET Descripcion = '{txt_descripcionProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
            Try
                Conex.EjecutarSQL(Sql)
                Conex.Dispose()
                MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
            Catch ex As Exception
                MsgBox("ERROR: No se pudo modificar el producto")
            End Try

        ElseIf txt_descripcionProd.Text <> "" And txt_precioProd.Text = "" And txt_stockProd.Text <> "" Then

            If Val(txt_stockProd.Text) < 1 Then
                MsgBox("ERROR: El campo 'Stock' debe ser mayores a 0")
            Else
                Conex = New conexionSQL(nombreDB)
                Sql = $"UPDATE Producto SET Descripcion = '{txt_descripcionProd.Text.Trim()}', Stock = '{txt_stockProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("ERROR: No se pudo modificar el producto")
                End Try
            End If

        ElseIf txt_descripcionProd.Text <> "" And txt_precioProd.Text <> "" And txt_stockProd.Text = "" Then

            If Val(txt_precioProd.Text) < 1 Then
                MsgBox("ERROR: El campo 'Precio' debe ser mayores a 0")
            Else
                Conex = New conexionSQL(nombreDB)
                Sql = $"UPDATE Producto SET Descripcion = '{txt_descripcionProd.Text.Trim()}', Precio = '{txt_precioProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("ERROR: No se pudo modificar el producto")
                End Try
            End If

        ElseIf txt_descripcionProd.Text <> "" And txt_precioProd.Text <> "" And txt_stockProd.Text <> "" Then

            If Val(txt_precioProd.Text) < 1 Or Val(txt_stockProd.Text) < 1 Then
                MsgBox("ERROR: Los campos 'Precio' y 'Stock' deben ser mayores a 0")
            Else
                Conex = New conexionSQL(nombreDB)
                Sql = $"UPDATE Producto SET Descripcion = '{txt_descripcionProd.Text.Trim()}', Precio = '{txt_precioProd.Text.Trim()}', Stock = '{txt_stockProd.Text.Trim()}' WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
                Try
                    Conex.EjecutarSQL(Sql)
                    Conex.Dispose()
                    MsgBox("El producto se modifico correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("ERROR: No se pudo modificar el producto")
                End Try
            End If

        End If

        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_verProductos.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try

        txt_descripcionProd.Text = ""
        txt_precioProd.Text = ""
        txt_stockProd.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_eliminarProd.Click
        Conex = New conexionSQL(nombreDB)

        Dim Sql As String = $"DELETE FROM Producto WHERE ID_Producto = {dgv_verProductos.CurrentRow.Cells(0).Value};"
        Try
            Conex.EjecutarSQL(Sql)
            Conex.Dispose()
            MsgBox("El producto se elimino correctamente", MsgBoxStyle.Information, "Insertar Datos")

            Try
                Sql = "SELECT * FROM Producto;"
                Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                Conex.miDataTable = New DataTable
                Conex.miDataAdapter.Fill(Conex.miDataTable)
                dgv_verProductos.DataSource = Conex.miDataTable
            Catch ex As Exception
                MsgBox("Error al mostrar los productos")
            End Try

        Catch ex As Exception
            MsgBox("ERROR: No se pudo eliminar el producto")
        End Try
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        gb_producto.Hide()

        gb_ventas.Show()
        gb_ventas.Location = New System.Drawing.Point(6, 22)

        gb_historial.Hide()

        Conex = New conexionSQL(nombreDB)

        Dim Sql As String

        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_prductosVenta.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try

    End Sub

    Private Sub btn_historialVentas_Click(sender As Object, e As EventArgs) Handles btn_historialVentas.Click
        gb_producto.Hide()
        gb_ventas.Hide()

        gb_historial.Show()
        gb_historial.Location = New System.Drawing.Point(6, 22)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesion.Click


        Conex = New conexionSQL
        Try
            Conex.EjecutarSQL($"USE {nombreDB};")
            MessageBox.Show("Sesión cerrada correctamente.", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Dispose()

        dgv_clientes.DataSource = Nothing
        dgv_detallesVenta.DataSource = Nothing
        dgv_historialVentas.DataSource = Nothing
        dgv_prductosVenta.DataSource = Nothing
        dgv_verProductos.DataSource = Nothing


        dgv_clientes.Rows.Clear()
        dgv_detallesVenta.Rows.Clear()
        dgv_historialVentas.Rows.Clear()
        dgv_prductosVenta.Rows.Clear()
        dgv_verProductos.Rows.Clear()


        Form1.Show()
        Me.Close()

    End Sub


    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick

        'MsgBox(dgv_clientes.CurrentRow.Cells(0).Value)
        dgv_clientes.Enabled = False
        dgv_prductosVenta.Enabled = True
        txt_cantidadVender.Text = ""
        txt_cantidadVender.Enabled = True
        btn_confirmarVenta.Enabled = True
        btn_cancelarVenta.Enabled = True
        lb_detalles.Items.Add($"Nombre cliente: {dgv_clientes.CurrentRow.Cells(1).Value}")
        lb_detalles.Items.Add($"")
    End Sub

    Private Sub dgv_prductosVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prductosVenta.CellContentClick
        If Val(txt_cantidadVender.Text) < 1 Then
            MsgBox("Debe ingresar un valor mayor a 0")
        Else
            Dim Sql As String
            Conex = New conexionSQL(nombreDB)
            Sql = $"SELECT Stock FROM Producto WHERE ID_Producto = {dgv_prductosVenta.CurrentRow.Cells(0).Value};"
            Dim stockActual As Integer = Convert.ToInt32(Conex.EjecutarSQLResp(Sql))

            If stockActual >= Val(txt_cantidadVender.Text.Trim()) Then

                ReDim Preserve prodSeleccionado(prodSeleccionado.Length)
                prodSeleccionado(prodSeleccionado.Length - 1) = dgv_prductosVenta.CurrentRow.Cells(0).Value
                ReDim Preserve prodSeleccionado(prodSeleccionado.Length)
                prodSeleccionado(prodSeleccionado.Length - 1) = txt_cantidadVender.Text.Trim()

                lb_detalles.Items.Add($"{dgv_prductosVenta.CurrentRow.Cells(1).Value} - Cantidad: {txt_cantidadVender.Text}")

                stockActual -= Val(txt_cantidadVender.Text.Trim())
                Sql = $"USE {nombreDB};UPDATE Producto Set Stock = '{stockActual}' WHERE ID_Producto = '{dgv_prductosVenta.CurrentRow.Cells(0).Value}'"
                Conex.EjecutarSQL(Sql)

                Try
                    Sql = "SELECT * FROM Producto;"
                    Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                    Conex.miDataTable = New DataTable
                    Conex.miDataAdapter.Fill(Conex.miDataTable)
                    dgv_prductosVenta.DataSource = Conex.miDataTable
                Catch ex As Exception
                    MsgBox("Error al mostrar los productos")
                End Try

                Conex.Dispose()

            Else
                MsgBox("No puede seleccionar vender una cantidad mayor de productos de la que hay en el stock.", MsgBoxStyle.Exclamation, "Stock Insuficiente")
            End If
        End If




    End Sub

    Private Sub btn_cancelarVenta_Click(sender As Object, e As EventArgs) Handles btn_cancelarVenta.Click

        Conex = New conexionSQL(nombreDB)

        Dim Sql As String

        'MsgBox(prodSeleccionado.Length())

        For i = 0 To prodSeleccionado.Length() - 2 Step 2
            Sql = $"SELECT Stock FROM Producto WHERE ID_Producto = {prodSeleccionado(i)};"
            Dim stockActual As Integer = Convert.ToInt32(Conex.EjecutarSQLResp(Sql))
            Sql = $"USE {nombreDB};UPDATE Producto Set Stock = '{stockActual + Val(prodSeleccionado(i + 1))}' WHERE ID_Producto = '{prodSeleccionado(i)}'"
            Conex.EjecutarSQL(Sql)
        Next

        Try
            Sql = "SELECT * FROM Producto;"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_prductosVenta.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar los productos")
        End Try

        ReDim prodSeleccionado(-1)
        dgv_clientes.Enabled = True
        dgv_prductosVenta.Enabled = False
        txt_cantidadVender.Text = ""
        txt_cantidadVender.Enabled = False
        btn_confirmarVenta.Enabled = False
        btn_cancelarVenta.Enabled = False
        lb_detalles.Items.Clear()
    End Sub

    Private Sub btn_confirmarVenta_Click(sender As Object, e As EventArgs) Handles btn_confirmarVenta.Click
        Dim Sql As String
        Conex = New conexionSQL(nombreDB)

        Dim fechaActual As DateTime = DateTime.Now
        Dim fechaSQL As String = fechaActual.ToString("yyyy-MM-dd")

        Try
            Sql = $"USE {nombreDB};INSERT INTO Venta(Fecha, ID_Vendedor, ID_Cliente) VALUES('{fechaSQL}','{Form1.idUsuarioActual}','{dgv_clientes.CurrentRow.Cells(0).Value}')"
            Conex.EjecutarSQL(Sql)

            ' Obtener el ID_Venta generado en la inserción anterior
            Dim idVenta As String = ObtenerIDVenta() ' Función para obtener el ID_Venta, tendrás que implementarla

            For i = 0 To prodSeleccionado.Length() - 2 Step 2
                Sql = $"USE {nombreDB}; INSERT INTO VentaProducto(ID_Venta, ID_Producto, CantidadVendida) VALUES('{idVenta}','{prodSeleccionado(i)}', '{prodSeleccionado(i + 1)}')"
                Conex.EjecutarSQL(Sql)
            Next

            MsgBox("Venta cerrada exitosamente")

            ReDim prodSeleccionado(-1)
            dgv_clientes.Enabled = True
            dgv_prductosVenta.Enabled = False
            txt_cantidadVender.Text = ""
            txt_cantidadVender.Enabled = False
            btn_confirmarVenta.Enabled = False
            btn_cancelarVenta.Enabled = False
            lb_detalles.Items.Clear()

            Try
                Sql = "SELECT * FROM Producto;"
                Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                Conex.miDataTable = New DataTable
                Conex.miDataAdapter.Fill(Conex.miDataTable)
                dgv_verProductos.DataSource = Conex.miDataTable
            Catch ex As Exception
                MsgBox("Error al mostrar los productos")
            End Try

            Try
                Sql = "SELECT * FROM Venta;"
                Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
                Conex.miDataTable = New DataTable
                Conex.miDataAdapter.Fill(Conex.miDataTable)
                dgv_historialVentas.DataSource = Conex.miDataTable
            Catch ex As Exception
                MsgBox("Error al mostrar el historial de ventas")
            End Try
            Conex.Dispose()
        Catch ex As Exception
            MsgBox("Error al cerrar la venta." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            Conex.Dispose()
        End Try

    End Sub




    Private Function ObtenerIDVenta() As Integer

        Conex = New conexionSQL(nombreDB)
        Dim idVenta As Integer = 0

        Try
            Dim Sql As String = $"USE {nombreDB}; SELECT MAX(ID_Venta) FROM Venta WHERE ID_Vendedor = '{Form1.idUsuarioActual}'"
            idVenta = Convert.ToInt32(Conex.EjecutarSQLResp(Sql))
        Catch ex As Exception
            MsgBox("Error al obtener el ID de venta." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Obtener ID de Venta")
        End Try

        Return idVenta

    End Function



    Private Sub dgv_historialVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historialVentas.CellContentClick
        Dim Sql As String
        Conex = New conexionSQL(nombreDB)
        Try
            Sql = $"SELECT ID_Venta, ID_Producto, CantidadVendida FROM VentaProducto WHERE ID_Venta ='{dgv_historialVentas.CurrentRow.Cells(0).Value}';"
            Conex.miDataAdapter = New MySqlDataAdapter(Sql, Conex.miConexion)
            Conex.miDataTable = New DataTable
            Conex.miDataAdapter.Fill(Conex.miDataTable)
            dgv_detallesVenta.DataSource = Conex.miDataTable
        Catch ex As Exception
            MsgBox("Error al mostrar el historial de ventas")
        End Try
    End Sub
End Class