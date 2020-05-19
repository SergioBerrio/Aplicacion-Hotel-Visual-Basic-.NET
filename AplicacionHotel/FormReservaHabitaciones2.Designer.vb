<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservaHabitaciones2
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
        Me.cmbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.cmbNumeroCamas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbNumeroHabitacion = New System.Windows.Forms.TextBox()
        Me.lblNumeroHabitacion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbPersonas = New System.Windows.Forms.ComboBox()
        Me.txtbIDHabitacion = New System.Windows.Forms.TextBox()
        Me.lblIDHabitacion = New System.Windows.Forms.Label()
        Me.txtbIDReserva = New System.Windows.Forms.TextBox()
        Me.lblIDReserva = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.txtbFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtbDNICliente = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbTipoHabitacion
        '
        Me.cmbTipoHabitacion.FormattingEnabled = True
        Me.cmbTipoHabitacion.Location = New System.Drawing.Point(242, 228)
        Me.cmbTipoHabitacion.Name = "cmbTipoHabitacion"
        Me.cmbTipoHabitacion.Size = New System.Drawing.Size(139, 21)
        Me.cmbTipoHabitacion.TabIndex = 51
        '
        'cmbNumeroCamas
        '
        Me.cmbNumeroCamas.FormattingEnabled = True
        Me.cmbNumeroCamas.Location = New System.Drawing.Point(586, 228)
        Me.cmbNumeroCamas.Name = "cmbNumeroCamas"
        Me.cmbNumeroCamas.Size = New System.Drawing.Size(139, 21)
        Me.cmbNumeroCamas.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(459, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Nº de camas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Tipo de habitación"
        '
        'txtbNumeroHabitacion
        '
        Me.txtbNumeroHabitacion.Enabled = False
        Me.txtbNumeroHabitacion.Location = New System.Drawing.Point(586, 188)
        Me.txtbNumeroHabitacion.Name = "txtbNumeroHabitacion"
        Me.txtbNumeroHabitacion.Size = New System.Drawing.Size(139, 20)
        Me.txtbNumeroHabitacion.TabIndex = 44
        '
        'lblNumeroHabitacion
        '
        Me.lblNumeroHabitacion.AutoSize = True
        Me.lblNumeroHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroHabitacion.Location = New System.Drawing.Point(459, 188)
        Me.lblNumeroHabitacion.Name = "lblNumeroHabitacion"
        Me.lblNumeroHabitacion.Size = New System.Drawing.Size(125, 20)
        Me.lblNumeroHabitacion.TabIndex = 47
        Me.lblNumeroHabitacion.Text = "Nº de habitación"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(463, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 68)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbPersonas
        '
        Me.cmbPersonas.FormattingEnabled = True
        Me.cmbPersonas.Location = New System.Drawing.Point(242, 150)
        Me.cmbPersonas.Name = "cmbPersonas"
        Me.cmbPersonas.Size = New System.Drawing.Size(139, 21)
        Me.cmbPersonas.TabIndex = 46
        '
        'txtbIDHabitacion
        '
        Me.txtbIDHabitacion.Enabled = False
        Me.txtbIDHabitacion.Location = New System.Drawing.Point(586, 150)
        Me.txtbIDHabitacion.Name = "txtbIDHabitacion"
        Me.txtbIDHabitacion.Size = New System.Drawing.Size(139, 20)
        Me.txtbIDHabitacion.TabIndex = 43
        '
        'lblIDHabitacion
        '
        Me.lblIDHabitacion.AutoSize = True
        Me.lblIDHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDHabitacion.Location = New System.Drawing.Point(459, 150)
        Me.lblIDHabitacion.Name = "lblIDHabitacion"
        Me.lblIDHabitacion.Size = New System.Drawing.Size(125, 20)
        Me.lblIDHabitacion.TabIndex = 45
        Me.lblIDHabitacion.Text = "ID de habitación"
        '
        'txtbIDReserva
        '
        Me.txtbIDReserva.Enabled = False
        Me.txtbIDReserva.Location = New System.Drawing.Point(242, 74)
        Me.txtbIDReserva.Name = "txtbIDReserva"
        Me.txtbIDReserva.Size = New System.Drawing.Size(139, 20)
        Me.txtbIDReserva.TabIndex = 42
        '
        'lblIDReserva
        '
        Me.lblIDReserva.AutoSize = True
        Me.lblIDReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDReserva.Location = New System.Drawing.Point(74, 72)
        Me.lblIDReserva.Name = "lblIDReserva"
        Me.lblIDReserva.Size = New System.Drawing.Size(120, 20)
        Me.lblIDReserva.TabIndex = 41
        Me.lblIDReserva.Text = "ID de la reserva"
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(586, 111)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(139, 20)
        Me.dtpFin.TabIndex = 40
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(586, 71)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(139, 20)
        Me.dtpInicio.TabIndex = 39
        '
        'btnReservar
        '
        Me.btnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.Location = New System.Drawing.Point(78, 311)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(264, 68)
        Me.btnReservar.TabIndex = 37
        Me.btnReservar.Text = "Reservar habitación"
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'txtbFecha
        '
        Me.txtbFecha.Enabled = False
        Me.txtbFecha.Location = New System.Drawing.Point(242, 188)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(139, 20)
        Me.txtbFecha.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(459, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha de fin"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(74, 152)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(165, 20)
        Me.lblApellidos.TabIndex = 32
        Me.lblApellidos.Text = "Cantidad de personas"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(459, 71)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(115, 20)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Fecha de inicio"
        '
        'txtbDNICliente
        '
        Me.txtbDNICliente.Location = New System.Drawing.Point(242, 111)
        Me.txtbDNICliente.Name = "txtbDNICliente"
        Me.txtbDNICliente.Size = New System.Drawing.Size(139, 20)
        Me.txtbDNICliente.TabIndex = 31
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(74, 111)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(112, 20)
        Me.lblDNI.TabIndex = 30
        Me.lblDNI.Text = "DNI del cliente"
        '
        'FormReservaHabitaciones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbTipoHabitacion)
        Me.Controls.Add(Me.cmbNumeroCamas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbNumeroHabitacion)
        Me.Controls.Add(Me.lblNumeroHabitacion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbPersonas)
        Me.Controls.Add(Me.txtbIDHabitacion)
        Me.Controls.Add(Me.lblIDHabitacion)
        Me.Controls.Add(Me.txtbIDReserva)
        Me.Controls.Add(Me.lblIDReserva)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.btnReservar)
        Me.Controls.Add(Me.txtbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtbDNICliente)
        Me.Controls.Add(Me.lblDNI)
        Me.Name = "FormReservaHabitaciones2"
        Me.Text = "FormReservaHabitaciones2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipoHabitacion As ComboBox
    Friend WithEvents cmbNumeroCamas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbNumeroHabitacion As TextBox
    Friend WithEvents lblNumeroHabitacion As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbPersonas As ComboBox
    Friend WithEvents txtbIDHabitacion As TextBox
    Friend WithEvents lblIDHabitacion As Label
    Friend WithEvents txtbIDReserva As TextBox
    Friend WithEvents lblIDReserva As Label
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents btnReservar As Button
    Friend WithEvents txtbFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbDNICliente As TextBox
    Friend WithEvents lblDNI As Label
End Class
