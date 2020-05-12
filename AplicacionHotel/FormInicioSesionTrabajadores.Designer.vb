<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicioSesionTrabajadores
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
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtbUsuario = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(219, 168)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(92, 20)
        Me.lblContrasena.TabIndex = 1
        Me.lblContrasena.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(219, 121)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'txtbUsuario
        '
        Me.txtbUsuario.Location = New System.Drawing.Point(358, 121)
        Me.txtbUsuario.Name = "txtbUsuario"
        Me.txtbUsuario.Size = New System.Drawing.Size(139, 20)
        Me.txtbUsuario.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(358, 165)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 2
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(223, 275)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(300, 73)
        Me.btnIniciarSesion.TabIndex = 3
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'FormInicioTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtbUsuario)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "FormInicioTrabajadores"
        Me.Text = "FormInicioTrabajadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtbUsuario As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnIniciarSesion As Button
End Class
