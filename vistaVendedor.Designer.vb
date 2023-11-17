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
        txt_totalVenta = New TextBox()
        dgv_detallesVenta = New DataGridView()
        dgv_historialVentas = New DataGridView()
        gb_ventas = New GroupBox()
        txt_cantidadVender = New TextBox()
        lb_detalles = New ListBox()
        dgv_prductosVenta = New DataGridView()
        btn_cancelarVenta = New Button()
        btn_confirmarVenta = New Button()
        dgv_clientes = New DataGridView()
        gb_producto = New GroupBox()
        dgv_verProductos = New DataGridView()
        GroupBox4 = New GroupBox()
        btn_eliminarProd = New Button()
        GroupBox2 = New GroupBox()
        btn_modificarProd = New Button()
        btn_crearProd = New Button()
        txt_stockProd = New TextBox()
        txt_precioProd = New TextBox()
        txt_descripcionProd = New TextBox()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        gb_mostrarOpcion.SuspendLayout()
        gb_historial.SuspendLayout()
        CType(dgv_detallesVenta, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_historialVentas, ComponentModel.ISupportInitialize).BeginInit()
        gb_ventas.SuspendLayout()
        CType(dgv_prductosVenta, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        gb_producto.SuspendLayout()
        CType(dgv_verProductos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_cerrarSesion
        ' 
        btn_cerrarSesion.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_cerrarSesion.FlatStyle = FlatStyle.Popup
        btn_cerrarSesion.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cerrarSesion.Location = New Point(6, 654)
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
        GroupBox1.Size = New Size(274, 721)
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
        gb_mostrarOpcion.Size = New Size(983, 721)
        gb_mostrarOpcion.TabIndex = 4
        gb_mostrarOpcion.TabStop = False
        ' 
        ' gb_historial
        ' 
        gb_historial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_historial.Controls.Add(txt_totalVenta)
        gb_historial.Controls.Add(dgv_detallesVenta)
        gb_historial.Controls.Add(dgv_historialVentas)
        gb_historial.Location = New Point(6, 545)
        gb_historial.Name = "gb_historial"
        gb_historial.Size = New Size(971, 170)
        gb_historial.TabIndex = 10
        gb_historial.TabStop = False
        ' 
        ' txt_totalVenta
        ' 
        txt_totalVenta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txt_totalVenta.Location = New Point(762, 141)
        txt_totalVenta.Name = "txt_totalVenta"
        txt_totalVenta.PlaceholderText = "Total: $"
        txt_totalVenta.ReadOnly = True
        txt_totalVenta.Size = New Size(203, 23)
        txt_totalVenta.TabIndex = 6
        ' 
        ' dgv_detallesVenta
        ' 
        dgv_detallesVenta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        dgv_detallesVenta.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_detallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_detallesVenta.Location = New Point(462, 22)
        dgv_detallesVenta.Name = "dgv_detallesVenta"
        dgv_detallesVenta.ReadOnly = True
        dgv_detallesVenta.RowTemplate.Height = 25
        dgv_detallesVenta.Size = New Size(503, 116)
        dgv_detallesVenta.TabIndex = 5
        ' 
        ' dgv_historialVentas
        ' 
        dgv_historialVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_historialVentas.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_historialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_historialVentas.Location = New Point(6, 22)
        dgv_historialVentas.Name = "dgv_historialVentas"
        dgv_historialVentas.ReadOnly = True
        dgv_historialVentas.RowTemplate.Height = 25
        dgv_historialVentas.Size = New Size(450, 142)
        dgv_historialVentas.TabIndex = 4
        ' 
        ' gb_ventas
        ' 
        gb_ventas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_ventas.Controls.Add(txt_cantidadVender)
        gb_ventas.Controls.Add(lb_detalles)
        gb_ventas.Controls.Add(dgv_prductosVenta)
        gb_ventas.Controls.Add(btn_cancelarVenta)
        gb_ventas.Controls.Add(btn_confirmarVenta)
        gb_ventas.Controls.Add(dgv_clientes)
        gb_ventas.Location = New Point(6, 338)
        gb_ventas.Name = "gb_ventas"
        gb_ventas.Size = New Size(971, 207)
        gb_ventas.TabIndex = 9
        gb_ventas.TabStop = False
        ' 
        ' txt_cantidadVender
        ' 
        txt_cantidadVender.Anchor = AnchorStyles.Bottom
        txt_cantidadVender.Location = New Point(489, 178)
        txt_cantidadVender.Name = "txt_cantidadVender"
        txt_cantidadVender.PlaceholderText = "Cantidad de producto a vender"
        txt_cantidadVender.Size = New Size(194, 23)
        txt_cantidadVender.TabIndex = 10
        ' 
        ' lb_detalles
        ' 
        lb_detalles.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lb_detalles.FormattingEnabled = True
        lb_detalles.ItemHeight = 15
        lb_detalles.Location = New Point(427, 129)
        lb_detalles.Name = "lb_detalles"
        lb_detalles.Size = New Size(538, 34)
        lb_detalles.TabIndex = 9
        ' 
        ' dgv_prductosVenta
        ' 
        dgv_prductosVenta.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgv_prductosVenta.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_prductosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_prductosVenta.Location = New Point(427, 22)
        dgv_prductosVenta.Name = "dgv_prductosVenta"
        dgv_prductosVenta.ReadOnly = True
        dgv_prductosVenta.RowTemplate.Height = 25
        dgv_prductosVenta.Size = New Size(538, 101)
        dgv_prductosVenta.TabIndex = 8
        ' 
        ' btn_cancelarVenta
        ' 
        btn_cancelarVenta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_cancelarVenta.FlatAppearance.BorderColor = Color.Red
        btn_cancelarVenta.FlatStyle = FlatStyle.Flat
        btn_cancelarVenta.Location = New Point(689, 178)
        btn_cancelarVenta.Name = "btn_cancelarVenta"
        btn_cancelarVenta.Size = New Size(140, 23)
        btn_cancelarVenta.TabIndex = 7
        btn_cancelarVenta.Text = "Cancelar venta"
        btn_cancelarVenta.UseVisualStyleBackColor = True
        ' 
        ' btn_confirmarVenta
        ' 
        btn_confirmarVenta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_confirmarVenta.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btn_confirmarVenta.FlatStyle = FlatStyle.Flat
        btn_confirmarVenta.Location = New Point(835, 178)
        btn_confirmarVenta.Name = "btn_confirmarVenta"
        btn_confirmarVenta.Size = New Size(130, 23)
        btn_confirmarVenta.TabIndex = 6
        btn_confirmarVenta.Text = "Confirmar venta"
        btn_confirmarVenta.UseVisualStyleBackColor = True
        ' 
        ' dgv_clientes
        ' 
        dgv_clientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_clientes.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_clientes.Location = New Point(6, 22)
        dgv_clientes.Name = "dgv_clientes"
        dgv_clientes.ReadOnly = True
        dgv_clientes.RowTemplate.Height = 25
        dgv_clientes.Size = New Size(415, 179)
        dgv_clientes.TabIndex = 5
        ' 
        ' gb_producto
        ' 
        gb_producto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gb_producto.Controls.Add(dgv_verProductos)
        gb_producto.Controls.Add(GroupBox4)
        gb_producto.Controls.Add(GroupBox2)
        gb_producto.Location = New Point(6, 22)
        gb_producto.Name = "gb_producto"
        gb_producto.Size = New Size(971, 310)
        gb_producto.TabIndex = 8
        gb_producto.TabStop = False
        ' 
        ' dgv_verProductos
        ' 
        dgv_verProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_verProductos.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgv_verProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_verProductos.Location = New Point(377, 22)
        dgv_verProductos.Name = "dgv_verProductos"
        dgv_verProductos.ReadOnly = True
        dgv_verProductos.RowTemplate.Height = 25
        dgv_verProductos.Size = New Size(588, 282)
        dgv_verProductos.TabIndex = 3
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox4.Controls.Add(btn_eliminarProd)
        GroupBox4.Location = New Point(6, 188)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(365, 116)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        ' 
        ' btn_eliminarProd
        ' 
        btn_eliminarProd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_eliminarProd.FlatStyle = FlatStyle.Popup
        btn_eliminarProd.Location = New Point(6, 22)
        btn_eliminarProd.Name = "btn_eliminarProd"
        btn_eliminarProd.Size = New Size(353, 88)
        btn_eliminarProd.TabIndex = 5
        btn_eliminarProd.Text = "ELIMINAR PRODUCTO"
        btn_eliminarProd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox2.Controls.Add(btn_modificarProd)
        GroupBox2.Controls.Add(btn_crearProd)
        GroupBox2.Controls.Add(txt_stockProd)
        GroupBox2.Controls.Add(txt_precioProd)
        GroupBox2.Controls.Add(txt_descripcionProd)
        GroupBox2.Location = New Point(6, 22)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(365, 136)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' btn_modificarProd
        ' 
        btn_modificarProd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_modificarProd.FlatStyle = FlatStyle.Popup
        btn_modificarProd.Location = New Point(190, 75)
        btn_modificarProd.Name = "btn_modificarProd"
        btn_modificarProd.Size = New Size(142, 55)
        btn_modificarProd.TabIndex = 4
        btn_modificarProd.Text = "Modificar"
        btn_modificarProd.UseVisualStyleBackColor = True
        ' 
        ' btn_crearProd
        ' 
        btn_crearProd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btn_crearProd.FlatStyle = FlatStyle.Popup
        btn_crearProd.Location = New Point(20, 75)
        btn_crearProd.Name = "btn_crearProd"
        btn_crearProd.Size = New Size(164, 55)
        btn_crearProd.TabIndex = 3
        btn_crearProd.Text = "Crear"
        btn_crearProd.UseVisualStyleBackColor = True
        ' 
        ' txt_stockProd
        ' 
        txt_stockProd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txt_stockProd.Location = New Point(259, 28)
        txt_stockProd.Multiline = True
        txt_stockProd.Name = "txt_stockProd"
        txt_stockProd.PlaceholderText = "Stock"
        txt_stockProd.Size = New Size(100, 33)
        txt_stockProd.TabIndex = 2
        txt_stockProd.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_precioProd
        ' 
        txt_precioProd.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_precioProd.Location = New Point(157, 28)
        txt_precioProd.Multiline = True
        txt_precioProd.Name = "txt_precioProd"
        txt_precioProd.PlaceholderText = "Precio Unitario"
        txt_precioProd.Size = New Size(96, 33)
        txt_precioProd.TabIndex = 1
        txt_precioProd.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_descripcionProd
        ' 
        txt_descripcionProd.Location = New Point(6, 28)
        txt_descripcionProd.Multiline = True
        txt_descripcionProd.Name = "txt_descripcionProd"
        txt_descripcionProd.PlaceholderText = "Descripcion"
        txt_descripcionProd.Size = New Size(145, 33)
        txt_descripcionProd.TabIndex = 0
        txt_descripcionProd.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(397, 859)
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
        ClientSize = New Size(1287, 745)
        Controls.Add(gb_mostrarOpcion)
        Controls.Add(GroupBox1)
        Name = "vistaVendedor"
        Text = "vistaVendedor"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        gb_mostrarOpcion.ResumeLayout(False)
        gb_historial.ResumeLayout(False)
        gb_historial.PerformLayout()
        CType(dgv_detallesVenta, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_historialVentas, ComponentModel.ISupportInitialize).EndInit()
        gb_ventas.ResumeLayout(False)
        gb_ventas.PerformLayout()
        CType(dgv_prductosVenta, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).EndInit()
        gb_producto.ResumeLayout(False)
        CType(dgv_verProductos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_cerrarSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_historialVentas As Button
    Friend WithEvents btn_ventas As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents gb_mostrarOpcion As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gb_producto As GroupBox
    Friend WithEvents gb_ventas As GroupBox
    Friend WithEvents gb_historial As GroupBox
    Friend WithEvents dgv_verProductos As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_descripcionProd As TextBox
    Friend WithEvents txt_stockProd As TextBox
    Friend WithEvents txt_precioProd As TextBox
    Friend WithEvents btn_crearProd As Button
    Friend WithEvents btn_eliminarProd As Button
    Friend WithEvents btn_modificarProd As Button
    Friend WithEvents dgv_historialVentas As DataGridView
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents dgv_detallesVenta As DataGridView
    Friend WithEvents btn_cancelarVenta As Button
    Friend WithEvents btn_confirmarVenta As Button
    Friend WithEvents dgv_prductosVenta As DataGridView
    Friend WithEvents lb_detalles As ListBox
    Friend WithEvents txt_cantidadVender As TextBox
    Friend WithEvents txt_totalVenta As TextBox
End Class
