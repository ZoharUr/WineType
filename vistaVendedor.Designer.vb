<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_cerrarSesion = New Button()
        GroupBox1 = New GroupBox()
        btn_historialVentas = New Button()
        btn_ventas = New Button()
        btn_productos = New Button()
        gb_mostrarOpcion = New GroupBox()
        gb_historial = New GroupBox()
        dgv_historialVentas = New DataGridView()
        gb_ventas = New GroupBox()
        txt_idCliente = New TextBox()
        txt_cantidadVender = New TextBox()
        txt_idProdVenta = New TextBox()
        btn_cancelar = New Button()
        btn_vender = New Button()
        dgv_clientes = New DataGridView()
        gb_producto = New GroupBox()
        btn_eliminar = New Button()
        dgv_productos = New DataGridView()
        btn_modificar = New Button()
        btn_eliminarProducto = New Button()
        txt_idProducto = New TextBox()
        btn_modificarProductos = New Button()
        btn_agregar = New Button()
        btn_agregarProductos = New Button()
        txt_stock = New TextBox()
        txt_precio = New TextBox()
        txt_descripcion = New TextBox()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        gb_mostrarOpcion.SuspendLayout()
        gb_historial.SuspendLayout()
        CType(dgv_historialVentas, ComponentModel.ISupportInitialize).BeginInit()
        gb_ventas.SuspendLayout()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        gb_producto.SuspendLayout()
        CType(dgv_productos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_cerrarSesion
        ' 
        btn_cerrarSesion.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_cerrarSesion.FlatStyle = FlatStyle.Popup
        btn_cerrarSesion.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cerrarSesion.Location = New Point(6, 467)
        btn_cerrarSesion.Name = "btn_cerrarSesion"
        btn_cerrarSesion.Size = New Size(262, 61)
        btn_cerrarSesion.TabIndex = 0
        btn_cerrarSesion.Text = "Cerrar Sesión"
        btn_cerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox1.Controls.Add(btn_historialVentas)
        GroupBox1.Controls.Add(btn_cerrarSesion)
        GroupBox1.Controls.Add(btn_ventas)
        GroupBox1.Controls.Add(btn_productos)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(274, 534)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' btn_historialVentas
        ' 
        btn_historialVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_historialVentas.FlatStyle = FlatStyle.Popup
        btn_historialVentas.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn_historialVentas.Location = New Point(6, 156)
        btn_historialVentas.Name = "btn_historialVentas"
        btn_historialVentas.Size = New Size(262, 61)
        btn_historialVentas.TabIndex = 3
        btn_historialVentas.Text = "Historial de ventas"
        btn_historialVentas.UseVisualStyleBackColor = True
        ' 
        ' btn_ventas
        ' 
        btn_ventas.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_ventas.FlatStyle = FlatStyle.Popup
        btn_ventas.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn_ventas.Location = New Point(6, 89)
        btn_ventas.Name = "btn_ventas"
        btn_ventas.Size = New Size(262, 61)
        btn_ventas.TabIndex = 2
        btn_ventas.Text = "Ventas"
        btn_ventas.UseVisualStyleBackColor = True
        ' 
        ' btn_productos
        ' 
        btn_productos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_productos.FlatStyle = FlatStyle.Popup
        btn_productos.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn_productos.Location = New Point(6, 22)
        btn_productos.Name = "btn_productos"
        btn_productos.Size = New Size(262, 61)
        btn_productos.TabIndex = 1
        btn_productos.Text = "Productos"
        btn_productos.UseVisualStyleBackColor = True
        ' 
        ' gb_mostrarOpcion
        ' 
        gb_mostrarOpcion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_mostrarOpcion.Controls.Add(gb_historial)
        gb_mostrarOpcion.Controls.Add(gb_ventas)
        gb_mostrarOpcion.Controls.Add(gb_producto)
        gb_mostrarOpcion.Controls.Add(Button3)
        gb_mostrarOpcion.Location = New Point(292, 12)
        gb_mostrarOpcion.Name = "gb_mostrarOpcion"
        gb_mostrarOpcion.Size = New Size(897, 534)
        gb_mostrarOpcion.TabIndex = 4
        gb_mostrarOpcion.TabStop = False
        ' 
        ' gb_historial
        ' 
        gb_historial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_historial.Controls.Add(dgv_historialVentas)
        gb_historial.Location = New Point(6, 382)
        gb_historial.Name = "gb_historial"
        gb_historial.Size = New Size(885, 146)
        gb_historial.TabIndex = 10
        gb_historial.TabStop = False
        ' 
        ' dgv_historialVentas
        ' 
        dgv_historialVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_historialVentas.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_historialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_historialVentas.Location = New Point(6, 22)
        dgv_historialVentas.Name = "dgv_historialVentas"
        dgv_historialVentas.RowTemplate.Height = 25
        dgv_historialVentas.Size = New Size(873, 118)
        dgv_historialVentas.TabIndex = 0
        ' 
        ' gb_ventas
        ' 
        gb_ventas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_ventas.Controls.Add(txt_idCliente)
        gb_ventas.Controls.Add(txt_cantidadVender)
        gb_ventas.Controls.Add(txt_idProdVenta)
        gb_ventas.Controls.Add(btn_cancelar)
        gb_ventas.Controls.Add(btn_vender)
        gb_ventas.Controls.Add(dgv_clientes)
        gb_ventas.Location = New Point(6, 261)
        gb_ventas.Name = "gb_ventas"
        gb_ventas.Size = New Size(885, 115)
        gb_ventas.TabIndex = 9
        gb_ventas.TabStop = False
        ' 
        ' txt_idCliente
        ' 
        txt_idCliente.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txt_idCliente.Location = New Point(211, 14)
        txt_idCliente.Name = "txt_idCliente"
        txt_idCliente.PlaceholderText = "ID CLIENTE"
        txt_idCliente.Size = New Size(72, 23)
        txt_idCliente.TabIndex = 9
        ' 
        ' txt_cantidadVender
        ' 
        txt_cantidadVender.Location = New Point(112, 14)
        txt_cantidadVender.Name = "txt_cantidadVender"
        txt_cantidadVender.PlaceholderText = "Cantidad"
        txt_cantidadVender.Size = New Size(58, 23)
        txt_cantidadVender.TabIndex = 8
        ' 
        ' txt_idProdVenta
        ' 
        txt_idProdVenta.Location = New Point(6, 14)
        txt_idProdVenta.Name = "txt_idProdVenta"
        txt_idProdVenta.PlaceholderText = "ID PRODUCTO"
        txt_idProdVenta.Size = New Size(100, 23)
        txt_idProdVenta.TabIndex = 8
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_cancelar.FlatStyle = FlatStyle.Popup
        btn_cancelar.Location = New Point(127, 86)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(75, 23)
        btn_cancelar.TabIndex = 2
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_vender
        ' 
        btn_vender.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_vender.FlatStyle = FlatStyle.Popup
        btn_vender.Location = New Point(208, 86)
        btn_vender.Name = "btn_vender"
        btn_vender.Size = New Size(75, 23)
        btn_vender.TabIndex = 1
        btn_vender.Text = "Vender"
        btn_vender.UseVisualStyleBackColor = True
        ' 
        ' dgv_clientes
        ' 
        dgv_clientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        dgv_clientes.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_clientes.Location = New Point(289, 14)
        dgv_clientes.Name = "dgv_clientes"
        dgv_clientes.RowTemplate.Height = 25
        dgv_clientes.Size = New Size(590, 95)
        dgv_clientes.TabIndex = 0
        ' 
        ' gb_producto
        ' 
        gb_producto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_producto.Controls.Add(btn_eliminar)
        gb_producto.Controls.Add(dgv_productos)
        gb_producto.Controls.Add(btn_modificar)
        gb_producto.Controls.Add(btn_eliminarProducto)
        gb_producto.Controls.Add(txt_idProducto)
        gb_producto.Controls.Add(btn_modificarProductos)
        gb_producto.Controls.Add(btn_agregar)
        gb_producto.Controls.Add(btn_agregarProductos)
        gb_producto.Controls.Add(txt_stock)
        gb_producto.Controls.Add(txt_precio)
        gb_producto.Controls.Add(txt_descripcion)
        gb_producto.Location = New Point(6, 22)
        gb_producto.Name = "gb_producto"
        gb_producto.Size = New Size(885, 233)
        gb_producto.TabIndex = 8
        gb_producto.TabStop = False
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Anchor = AnchorStyles.Bottom
        btn_eliminar.FlatStyle = FlatStyle.Popup
        btn_eliminar.Font = New Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn_eliminar.Location = New Point(549, 146)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(136, 30)
        btn_eliminar.TabIndex = 7
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' dgv_productos
        ' 
        dgv_productos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_productos.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_productos.BorderStyle = BorderStyle.Fixed3D
        dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_productos.Location = New Point(6, 96)
        dgv_productos.Name = "dgv_productos"
        dgv_productos.ReadOnly = True
        dgv_productos.RowTemplate.Height = 25
        dgv_productos.Size = New Size(873, 44)
        dgv_productos.TabIndex = 7
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Anchor = AnchorStyles.Bottom
        btn_modificar.FlatStyle = FlatStyle.Popup
        btn_modificar.Font = New Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn_modificar.Location = New Point(372, 146)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(136, 30)
        btn_modificar.TabIndex = 6
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminarProducto
        ' 
        btn_eliminarProducto.Anchor = AnchorStyles.Top
        btn_eliminarProducto.FlatStyle = FlatStyle.Popup
        btn_eliminarProducto.Font = New Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn_eliminarProducto.Location = New Point(528, 22)
        btn_eliminarProducto.Name = "btn_eliminarProducto"
        btn_eliminarProducto.Size = New Size(157, 32)
        btn_eliminarProducto.TabIndex = 6
        btn_eliminarProducto.Text = "Eliminar Productos"
        btn_eliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' txt_idProducto
        ' 
        txt_idProducto.Anchor = AnchorStyles.Top
        txt_idProducto.Location = New Point(92, 67)
        txt_idProducto.Name = "txt_idProducto"
        txt_idProducto.PlaceholderText = "ID PRODUCTO"
        txt_idProducto.Size = New Size(100, 23)
        txt_idProducto.TabIndex = 5
        ' 
        ' btn_modificarProductos
        ' 
        btn_modificarProductos.Anchor = AnchorStyles.Top
        btn_modificarProductos.FlatStyle = FlatStyle.Popup
        btn_modificarProductos.Font = New Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn_modificarProductos.Location = New Point(357, 22)
        btn_modificarProductos.Name = "btn_modificarProductos"
        btn_modificarProductos.Size = New Size(165, 32)
        btn_modificarProductos.TabIndex = 5
        btn_modificarProductos.Text = "Modificar Productos"
        btn_modificarProductos.UseVisualStyleBackColor = True
        ' 
        ' btn_agregar
        ' 
        btn_agregar.Anchor = AnchorStyles.Bottom
        btn_agregar.FlatStyle = FlatStyle.Popup
        btn_agregar.Font = New Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn_agregar.Location = New Point(199, 146)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(136, 30)
        btn_agregar.TabIndex = 4
        btn_agregar.Text = "Agregar"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' btn_agregarProductos
        ' 
        btn_agregarProductos.Anchor = AnchorStyles.Top
        btn_agregarProductos.FlatStyle = FlatStyle.Popup
        btn_agregarProductos.Font = New Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btn_agregarProductos.Location = New Point(199, 22)
        btn_agregarProductos.Name = "btn_agregarProductos"
        btn_agregarProductos.Size = New Size(152, 32)
        btn_agregarProductos.TabIndex = 4
        btn_agregarProductos.Text = "Agregar Productos"
        btn_agregarProductos.UseVisualStyleBackColor = True
        ' 
        ' txt_stock
        ' 
        txt_stock.Anchor = AnchorStyles.Top
        txt_stock.Location = New Point(585, 67)
        txt_stock.Name = "txt_stock"
        txt_stock.PlaceholderText = "Stock"
        txt_stock.Size = New Size(100, 23)
        txt_stock.TabIndex = 2
        ' 
        ' txt_precio
        ' 
        txt_precio.Anchor = AnchorStyles.Top
        txt_precio.Location = New Point(422, 67)
        txt_precio.Name = "txt_precio"
        txt_precio.PlaceholderText = "Precio"
        txt_precio.Size = New Size(100, 23)
        txt_precio.TabIndex = 1
        ' 
        ' txt_descripcion
        ' 
        txt_descripcion.Anchor = AnchorStyles.Top
        txt_descripcion.Location = New Point(251, 67)
        txt_descripcion.Name = "txt_descripcion"
        txt_descripcion.PlaceholderText = "Descripcion"
        txt_descripcion.Size = New Size(100, 23)
        txt_descripcion.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(354, 672)
        Button3.Name = "Button3"
        Button3.Size = New Size(262, 61)
        Button3.TabIndex = 0
        Button3.Text = "Cerrar Sesión"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' vistaVendedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1201, 558)
        Controls.Add(gb_mostrarOpcion)
        Controls.Add(GroupBox1)
        Name = "vistaVendedor"
        Text = "vistaVendedor"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        gb_mostrarOpcion.ResumeLayout(False)
        gb_historial.ResumeLayout(False)
        CType(dgv_historialVentas, ComponentModel.ISupportInitialize).EndInit()
        gb_ventas.ResumeLayout(False)
        gb_ventas.PerformLayout()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).EndInit()
        gb_producto.ResumeLayout(False)
        gb_producto.PerformLayout()
        CType(dgv_productos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_cerrarSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_historialVentas As Button
    Friend WithEvents btn_ventas As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents gb_mostrarOpcion As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_agregarProductos As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_eliminarProducto As Button
    Friend WithEvents btn_modificarProductos As Button
    Friend WithEvents dgv_productos As DataGridView
    Friend WithEvents gb_producto As GroupBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_idProducto As TextBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents gb_ventas As GroupBox
    Friend WithEvents gb_historial As GroupBox
    Friend WithEvents dgv_historialVentas As DataGridView
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_vender As Button
    Friend WithEvents txt_cantidadVender As TextBox
    Friend WithEvents txt_idProdVenta As TextBox
    Friend WithEvents txt_idCliente As TextBox
End Class
