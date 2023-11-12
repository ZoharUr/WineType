<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_user = New TextBox()
        txt_password = New TextBox()
        btn_entrar = New Button()
        gb_iniciarSesion = New GroupBox()
        btn_salir = New Button()
        Label2 = New Label()
        gb_crearCuenta = New GroupBox()
        link_registro = New LinkLabel()
        Label1 = New Label()
        gb_iniciarSesion.SuspendLayout()
        gb_crearCuenta.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(75, 118)
        txt_user.Multiline = True
        txt_user.Name = "txt_user"
        txt_user.PlaceholderText = "Teléfono o correo electronico"
        txt_user.Size = New Size(180, 25)
        txt_user.TabIndex = 0
        txt_user.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(101, 149)
        txt_password.Multiline = True
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "."c
        txt_password.PlaceholderText = "Contraseña"
        txt_password.Size = New Size(130, 25)
        txt_password.TabIndex = 1
        txt_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btn_entrar.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        btn_entrar.FlatAppearance.BorderSize = 0
        btn_entrar.FlatStyle = FlatStyle.Popup
        btn_entrar.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_entrar.Location = New Point(75, 201)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(180, 37)
        btn_entrar.TabIndex = 2
        btn_entrar.Text = "Entrar"
        btn_entrar.UseVisualStyleBackColor = False
        ' 
        ' gb_iniciarSesion
        ' 
        gb_iniciarSesion.Anchor = AnchorStyles.None
        gb_iniciarSesion.Controls.Add(btn_salir)
        gb_iniciarSesion.Controls.Add(Label2)
        gb_iniciarSesion.Controls.Add(txt_user)
        gb_iniciarSesion.Controls.Add(txt_password)
        gb_iniciarSesion.Controls.Add(btn_entrar)
        gb_iniciarSesion.Location = New Point(12, 12)
        gb_iniciarSesion.Name = "gb_iniciarSesion"
        gb_iniciarSesion.Size = New Size(340, 320)
        gb_iniciarSesion.TabIndex = 3
        gb_iniciarSesion.TabStop = False
        ' 
        ' btn_salir
        ' 
        btn_salir.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btn_salir.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        btn_salir.FlatAppearance.BorderSize = 0
        btn_salir.FlatStyle = FlatStyle.Popup
        btn_salir.Location = New Point(121, 278)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(90, 23)
        btn_salir.TabIndex = 4
        btn_salir.Text = "Salir"
        btn_salir.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label2.Font = New Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label2.Location = New Point(81, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 46)
        Label2.TabIndex = 3
        Label2.Text = "WineType"
        ' 
        ' gb_crearCuenta
        ' 
        gb_crearCuenta.Anchor = AnchorStyles.None
        gb_crearCuenta.Controls.Add(link_registro)
        gb_crearCuenta.Controls.Add(Label1)
        gb_crearCuenta.Location = New Point(12, 338)
        gb_crearCuenta.Name = "gb_crearCuenta"
        gb_crearCuenta.Size = New Size(341, 100)
        gb_crearCuenta.TabIndex = 4
        gb_crearCuenta.TabStop = False
        ' 
        ' link_registro
        ' 
        link_registro.AutoSize = True
        link_registro.Location = New Point(206, 44)
        link_registro.Name = "link_registro"
        link_registro.Size = New Size(59, 15)
        link_registro.TabIndex = 1
        link_registro.TabStop = True
        link_registro.Text = "Regístrate"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 0
        Label1.Text = "¿No tienes una cuenta?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(364, 451)
        Controls.Add(gb_crearCuenta)
        Controls.Add(gb_iniciarSesion)
        Name = "Form1"
        Text = "Form1"
        gb_iniciarSesion.ResumeLayout(False)
        gb_iniciarSesion.PerformLayout()
        gb_crearCuenta.ResumeLayout(False)
        gb_crearCuenta.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents gb_iniciarSesion As GroupBox
    Friend WithEvents gb_crearCuenta As GroupBox
    Friend WithEvents link_registro As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salir As Button
End Class
