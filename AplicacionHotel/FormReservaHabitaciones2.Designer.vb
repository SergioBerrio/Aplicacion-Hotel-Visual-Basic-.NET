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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbNumeroHabitacion = New System.Windows.Forms.TextBox()
        Me.lblNumeroHabitacion = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.cmbPersonas = New System.Windows.Forms.ComboBox()
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
        Me.txtbNumeroCamas = New System.Windows.Forms.TextBox()
        Me.gp1 = New System.Windows.Forms.GroupBox()
        Me.gp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTipoHabitacion
        '
        Me.cmbTipoHabitacion.FormattingEnabled = True
        Me.cmbTipoHabitacion.Location = New System.Drawing.Point(191, 185)
        Me.cmbTipoHabitacion.Name = "cmbTipoHabitacion"
        Me.cmbTipoHabitacion.Size = New System.Drawing.Size(139, 24)
        Me.cmbTipoHabitacion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Nº de camas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Tipo de habitación"
        '
        'txtbNumeroHabitacion
        '
        Me.txtbNumeroHabitacion.Enabled = False
        Me.txtbNumeroHabitacion.Location = New System.Drawing.Point(560, 105)
        Me.txtbNumeroHabitacion.Name = "txtbNumeroHabitacion"
        Me.txtbNumeroHabitacion.Size = New System.Drawing.Size(139, 22)
        Me.txtbNumeroHabitacion.TabIndex = 8
        '
        'lblNumeroHabitacion
        '
        Me.lblNumeroHabitacion.AutoSize = True
        Me.lblNumeroHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroHabitacion.Location = New System.Drawing.Point(433, 105)
        Me.lblNumeroHabitacion.Name = "lblNumeroHabitacion"
        Me.lblNumeroHabitacion.Size = New System.Drawing.Size(125, 20)
        Me.lblNumeroHabitacion.TabIndex = 47
        Me.lblNumeroHabitacion.Text = "Nº de habitación"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(463, 311)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(264, 68)
        Me.btnAtras.TabIndex = 11
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'cmbPersonas
        '
        Me.cmbPersonas.FormattingEnabled = True
        Me.cmbPersonas.Location = New System.Drawing.Point(191, 107)
        Me.cmbPersonas.Name = "cmbPersonas"
        Me.cmbPersonas.Size = New System.Drawing.Size(139, 24)
        Me.cmbPersonas.TabIndex = 3
        '
        'txtbIDReserva
        '
        Me.txtbIDReserva.Enabled = False
        Me.txtbIDReserva.Location = New System.Drawing.Point(191, 31)
        Me.txtbIDReserva.Name = "txtbIDReserva"
        Me.txtbIDReserva.Size = New System.Drawing.Size(139, 22)
        Me.txtbIDReserva.TabIndex = 1
        '
        'lblIDReserva
        '
        Me.lblIDReserva.AutoSize = True
        Me.lblIDReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDReserva.Location = New System.Drawing.Point(23, 29)
        Me.lblIDReserva.Name = "lblIDReserva"
        Me.lblIDReserva.Size = New System.Drawing.Size(120, 20)
        Me.lblIDReserva.TabIndex = 41
        Me.lblIDReserva.Text = "ID de la reserva"
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(560, 68)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(139, 22)
        Me.dtpFin.TabIndex = 7
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(560, 28)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(139, 22)
        Me.dtpInicio.TabIndex = 6
        '
        'btnReservar
        '
        Me.btnReservar.BackColor = System.Drawing.Color.Orange
        Me.btnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.Location = New System.Drawing.Point(53, 311)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(264, 68)
        Me.btnReservar.TabIndex = 10
        Me.btnReservar.Text = "Reservar habitación"
        Me.btnReservar.UseVisualStyleBackColor = False
        '
        'txtbFecha
        '
        Me.txtbFecha.Enabled = False
        Me.txtbFecha.Location = New System.Drawing.Point(191, 145)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(139, 22)
        Me.txtbFecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha de fin"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(23, 109)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(165, 20)
        Me.lblApellidos.TabIndex = 32
        Me.lblApellidos.Text = "Cantidad de personas"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(433, 28)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(115, 20)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Fecha de inicio"
        '
        'txtbDNICliente
        '
        Me.txtbDNICliente.Enabled = False
        Me.txtbDNICliente.Location = New System.Drawing.Point(191, 68)
        Me.txtbDNICliente.Name = "txtbDNICliente"
        Me.txtbDNICliente.Size = New System.Drawing.Size(139, 22)
        Me.txtbDNICliente.TabIndex = 2
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(23, 68)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(112, 20)
        Me.lblDNI.TabIndex = 30
        Me.lblDNI.Text = "DNI del cliente"
        '
        'txtbNumeroCamas
        '
        Me.txtbNumeroCamas.Enabled = False
        Me.txtbNumeroCamas.Location = New System.Drawing.Point(560, 148)
        Me.txtbNumeroCamas.Name = "txtbNumeroCamas"
        Me.txtbNumeroCamas.Size = New System.Drawing.Size(139, 22)
        Me.txtbNumeroCamas.TabIndex = 9
        '
        'gp1
        '
        Me.gp1.Controls.Add(Me.txtbNumeroCamas)
        Me.gp1.Controls.Add(Me.cmbTipoHabitacion)
        Me.gp1.Controls.Add(Me.Label4)
        Me.gp1.Controls.Add(Me.Label2)
        Me.gp1.Controls.Add(Me.txtbNumeroHabitacion)
        Me.gp1.Controls.Add(Me.lblNumeroHabitacion)
        Me.gp1.Controls.Add(Me.cmbPersonas)
        Me.gp1.Controls.Add(Me.txtbIDReserva)
        Me.gp1.Controls.Add(Me.lblIDReserva)
        Me.gp1.Controls.Add(Me.dtpFin)
        Me.gp1.Controls.Add(Me.dtpInicio)
        Me.gp1.Controls.Add(Me.txtbFecha)
        Me.gp1.Controls.Add(Me.Label1)
        Me.gp1.Controls.Add(Me.Label3)
        Me.gp1.Controls.Add(Me.lblApellidos)
        Me.gp1.Controls.Add(Me.lblEmail)
        Me.gp1.Controls.Add(Me.txtbDNICliente)
        Me.gp1.Controls.Add(Me.lblDNI)
        Me.gp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp1.Location = New System.Drawing.Point(26, 43)
        Me.gp1.Name = "gp1"
        Me.gp1.Size = New System.Drawing.Size(741, 246)
        Me.gp1.TabIndex = 1
        Me.gp1.TabStop = False
        Me.gp1.Text = "Datos de la reserva"
        '
        'FormReservaHabitaciones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gp1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnReservar)
        Me.Name = "FormReservaHabitaciones2"
        Me.Text = "FormReservaHabitaciones2"
        Me.gp1.ResumeLayout(False)
        Me.gp1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbTipoHabitacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbNumeroHabitacion As TextBox
    Friend WithEvents lblNumeroHabitacion As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents cmbPersonas As ComboBox
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
    Friend WithEvents txtbNumeroCamas As TextBox
    Friend WithEvents gp1 As GroupBox
End Class
