<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReservaHabitaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtbDNICliente = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtbFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.txtbIDReserva = New System.Windows.Forms.TextBox()
        Me.lblIDReserva = New System.Windows.Forms.Label()
        Me.cmbPersonas = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtbNumeroHabitacion = New System.Windows.Forms.TextBox()
        Me.lblNumeroHabitacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.txtbNumeroCamas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(41, 157)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(165, 20)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Cantidad de personas"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(464, 75)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(115, 20)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Fecha de inicio"
        '
        'txtbDNICliente
        '
        Me.txtbDNICliente.Location = New System.Drawing.Point(209, 116)
        Me.txtbDNICliente.Name = "txtbDNICliente"
        Me.txtbDNICliente.Size = New System.Drawing.Size(139, 20)
        Me.txtbDNICliente.TabIndex = 2
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(41, 116)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(112, 20)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI del cliente"
        '
        'txtbFecha
        '
        Me.txtbFecha.Enabled = False
        Me.txtbFecha.Location = New System.Drawing.Point(209, 193)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(139, 20)
        Me.txtbFecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(464, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha de fin"
        '
        'btnReservar
        '
        Me.btnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.Location = New System.Drawing.Point(45, 316)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(264, 68)
        Me.btnReservar.TabIndex = 10
        Me.btnReservar.Text = "Reservar habitación"
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(601, 76)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(139, 20)
        Me.dtpInicio.TabIndex = 6
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(601, 116)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(139, 20)
        Me.dtpFin.TabIndex = 7
        '
        'txtbIDReserva
        '
        Me.txtbIDReserva.Enabled = False
        Me.txtbIDReserva.Location = New System.Drawing.Point(209, 79)
        Me.txtbIDReserva.Name = "txtbIDReserva"
        Me.txtbIDReserva.Size = New System.Drawing.Size(139, 20)
        Me.txtbIDReserva.TabIndex = 1
        '
        'lblIDReserva
        '
        Me.lblIDReserva.AutoSize = True
        Me.lblIDReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDReserva.Location = New System.Drawing.Point(41, 77)
        Me.lblIDReserva.Name = "lblIDReserva"
        Me.lblIDReserva.Size = New System.Drawing.Size(120, 20)
        Me.lblIDReserva.TabIndex = 18
        Me.lblIDReserva.Text = "ID de la reserva"
        '
        'cmbPersonas
        '
        Me.cmbPersonas.FormattingEnabled = True
        Me.cmbPersonas.Location = New System.Drawing.Point(209, 155)
        Me.cmbPersonas.Name = "cmbPersonas"
        Me.cmbPersonas.Size = New System.Drawing.Size(139, 21)
        Me.cmbPersonas.TabIndex = 3
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(468, 316)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(272, 68)
        Me.btnAtras.TabIndex = 11
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtbNumeroHabitacion
        '
        Me.txtbNumeroHabitacion.Enabled = False
        Me.txtbNumeroHabitacion.Location = New System.Drawing.Point(601, 157)
        Me.txtbNumeroHabitacion.Name = "txtbNumeroHabitacion"
        Me.txtbNumeroHabitacion.Size = New System.Drawing.Size(139, 20)
        Me.txtbNumeroHabitacion.TabIndex = 8
        '
        'lblNumeroHabitacion
        '
        Me.lblNumeroHabitacion.AutoSize = True
        Me.lblNumeroHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroHabitacion.Location = New System.Drawing.Point(464, 155)
        Me.lblNumeroHabitacion.Name = "lblNumeroHabitacion"
        Me.lblNumeroHabitacion.Size = New System.Drawing.Size(125, 20)
        Me.lblNumeroHabitacion.TabIndex = 23
        Me.lblNumeroHabitacion.Text = "Nº de habitación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tipo de habitación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nº de camas"
        '
        'cmbTipoHabitacion
        '
        Me.cmbTipoHabitacion.FormattingEnabled = True
        Me.cmbTipoHabitacion.Location = New System.Drawing.Point(209, 233)
        Me.cmbTipoHabitacion.Name = "cmbTipoHabitacion"
        Me.cmbTipoHabitacion.Size = New System.Drawing.Size(139, 21)
        Me.cmbTipoHabitacion.TabIndex = 5
        '
        'txtbNumeroCamas
        '
        Me.txtbNumeroCamas.Enabled = False
        Me.txtbNumeroCamas.Location = New System.Drawing.Point(601, 195)
        Me.txtbNumeroCamas.Name = "txtbNumeroCamas"
        Me.txtbNumeroCamas.Size = New System.Drawing.Size(139, 20)
        Me.txtbNumeroCamas.TabIndex = 9
        '
        'FormReservaHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbNumeroCamas)
        Me.Controls.Add(Me.cmbTipoHabitacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbNumeroHabitacion)
        Me.Controls.Add(Me.lblNumeroHabitacion)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.cmbPersonas)
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
        Me.Name = "FormReservaHabitaciones"
        Me.Text = "FormReservaHabitaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbDNICliente As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtbFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReservar As Button
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents txtbIDReserva As TextBox
    Friend WithEvents lblIDReserva As Label
    Friend WithEvents cmbPersonas As ComboBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents txtbNumeroHabitacion As TextBox
    Friend WithEvents lblNumeroHabitacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipoHabitacion As ComboBox
    Friend WithEvents txtbNumeroCamas As TextBox
End Class
