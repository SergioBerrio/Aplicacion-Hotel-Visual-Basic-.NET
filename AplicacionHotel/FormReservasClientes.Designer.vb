<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservasClientes
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.txtbDNI = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.txtbTelefono = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtbApellidos = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 64)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Acceder a reservar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtbNombre
        '
        Me.txtbNombre.Location = New System.Drawing.Point(161, 71)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(139, 22)
        Me.txtbNombre.TabIndex = 4
        '
        'txtbDNI
        '
        Me.txtbDNI.Location = New System.Drawing.Point(161, 34)
        Me.txtbDNI.Name = "txtbDNI"
        Me.txtbDNI.Size = New System.Drawing.Size(139, 22)
        Me.txtbDNI.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(34, 71)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(34, 34)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(37, 20)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI"
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(161, 185)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(139, 22)
        Me.txtbEmail.TabIndex = 10
        '
        'txtbTelefono
        '
        Me.txtbTelefono.Location = New System.Drawing.Point(161, 150)
        Me.txtbTelefono.Name = "txtbTelefono"
        Me.txtbTelefono.Size = New System.Drawing.Size(139, 22)
        Me.txtbTelefono.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(34, 185)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(34, 150)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtbApellidos
        '
        Me.txtbApellidos.Location = New System.Drawing.Point(161, 111)
        Me.txtbApellidos.Name = "txtbApellidos"
        Me.txtbApellidos.Size = New System.Drawing.Size(139, 22)
        Me.txtbApellidos.TabIndex = 6
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(34, 111)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(73, 20)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Apellidos"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(428, 329)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(186, 64)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtbApellidos)
        Me.gbDatos.Controls.Add(Me.lblApellidos)
        Me.gbDatos.Controls.Add(Me.txtbEmail)
        Me.gbDatos.Controls.Add(Me.txtbTelefono)
        Me.gbDatos.Controls.Add(Me.lblEmail)
        Me.gbDatos.Controls.Add(Me.lblTelefono)
        Me.gbDatos.Controls.Add(Me.txtbNombre)
        Me.gbDatos.Controls.Add(Me.txtbDNI)
        Me.gbDatos.Controls.Add(Me.lblNombre)
        Me.gbDatos.Controls.Add(Me.lblDNI)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(221, 58)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(336, 236)
        Me.gbDatos.TabIndex = 1
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos personales"
        '
        'FormReservasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormReservasClientes"
        Me.Text = "FormReservasClientes"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents txtbDNI As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents txtbTelefono As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtbApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents gbDatos As GroupBox
End Class
