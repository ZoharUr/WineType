<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Label2 = New Label()
        gb_registro = New GroupBox()
        btn_salir = New Button()
        btn_registrarte = New Button()
        txt_password = New TextBox()
        txt_nombre = New TextBox()
        txt_mail = New TextBox()
        txt_telefono = New TextBox()
        gb_volver = New GroupBox()
        link_iniciarSesion = New LinkLabel()
        Label1 = New Label()
        gb_registro.SuspendLayout()
        gb_volver.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label2.Font = New Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label2.Location = New Point(78, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 46)
        Label2.TabIndex = 4
        Label2.Text = "WineType"
        ' 
        ' gb_registro
        ' 
        gb_registro.Anchor = AnchorStyles.None
        gb_registro.Controls.Add(btn_salir)
        gb_registro.Controls.Add(btn_registrarte)
        gb_registro.Controls.Add(txt_password)
        gb_registro.Controls.Add(txt_nombre)
        gb_registro.Controls.Add(txt_mail)
        gb_registro.Controls.Add(txt_telefono)
        gb_registro.Controls.Add(Label2)
        gb_registro.Location = New Point(12, 12)
        gb_registro.Name = "gb_registro"
        gb_registro.Size = New Size(340, 294)
        gb_registro.TabIndex = 5
        gb_registro.TabStop = False
        ' 
        ' btn_salir
        ' 
        btn_salir.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btn_salir.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        btn_salir.FlatAppearance.BorderSize = 0
        btn_salir.FlatStyle = FlatStyle.Popup
        btn_salir.Location = New Point(123, 256)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(90, 23)
        btn_salir.TabIndex = 10
        btn_salir.Text = "Salir"
        btn_salir.UseVisualStyleBackColor = False
        ' 
        ' btn_registrarte
        ' 
        btn_registrarte.FlatStyle = FlatStyle.Popup
        btn_registrarte.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_registrarte.Location = New Point(101, 216)
        btn_registrarte.Name = "btn_registrarte"
        btn_registrarte.Size = New Size(130, 34)
        btn_registrarte.TabIndex = 9
        btn_registrarte.Text = "Registrarte"
        btn_registrarte.UseVisualStyleBackColor = True
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(101, 176)
        txt_password.Multiline = True
        txt_password.Name = "txt_password"
        txt_password.PlaceholderText = "Contraseña"
        txt_password.Size = New Size(130, 25)
        txt_password.TabIndex = 8
        txt_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(101, 145)
        txt_nombre.Multiline = True
        txt_nombre.Name = "txt_nombre"
        txt_nombre.PlaceholderText = "Nombre"
        txt_nombre.Size = New Size(130, 25)
        txt_nombre.TabIndex = 7
        txt_nombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_mail
        ' 
        txt_mail.Location = New Point(169, 114)
        txt_mail.Multiline = True
        txt_mail.Name = "txt_mail"
        txt_mail.PlaceholderText = "Correo electronico"
        txt_mail.Size = New Size(130, 25)
        txt_mail.TabIndex = 6
        txt_mail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_telefono
        ' 
        txt_telefono.Location = New Point(33, 114)
        txt_telefono.Multiline = True
        txt_telefono.Name = "txt_telefono"
        txt_telefono.PlaceholderText = "Télefono"
        txt_telefono.Size = New Size(130, 25)
        txt_telefono.TabIndex = 5
        txt_telefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' gb_volver
        ' 
        gb_volver.Anchor = AnchorStyles.None
        gb_volver.Controls.Add(link_iniciarSesion)
        gb_volver.Controls.Add(Label1)
        gb_volver.Location = New Point(12, 312)
        gb_volver.Name = "gb_volver"
        gb_volver.Size = New Size(340, 126)
        gb_volver.TabIndex = 6
        gb_volver.TabStop = False
        ' 
        ' link_iniciarSesion
        ' 
        link_iniciarSesion.AutoSize = True
        link_iniciarSesion.Location = New Point(205, 65)
        link_iniciarSesion.Name = "link_iniciarSesion"
        link_iniciarSesion.Size = New Size(38, 15)
        link_iniciarSesion.TabIndex = 1
        link_iniciarSesion.TabStop = True
        link_iniciarSesion.Text = "Entrar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(87, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 15)
        Label1.TabIndex = 0
        Label1.Text = "¿Tienes una cuenta?"
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(364, 451)
        Controls.Add(gb_volver)
        Controls.Add(gb_registro)
        Name = "Registro"
        Text = "Registro"
        WindowState = FormWindowState.Maximized
        gb_registro.ResumeLayout(False)
        gb_registro.PerformLayout()
        gb_volver.ResumeLayout(False)
        gb_volver.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents gb_registro As GroupBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_mail As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents btn_registrarte As Button
    Friend WithEvents gb_volver As GroupBox
    Friend WithEvents link_iniciarSesion As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_salir As Button
End Class
