<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEntrada
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
        Me.bntAtras1 = New System.Windows.Forms.Button()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnVerReservas = New System.Windows.Forms.Button()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.gbTrabajadores = New System.Windows.Forms.GroupBox()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.gbClientes.SuspendLayout()
        Me.gbTrabajadores.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bntAtras1
        '
        Me.bntAtras1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAtras1.Location = New System.Drawing.Point(460, 327)
        Me.bntAtras1.Name = "bntAtras1"
        Me.bntAtras1.Size = New System.Drawing.Size(206, 60)
        Me.bntAtras1.TabIndex = 4
        Me.bntAtras1.Text = "Atrás"
        Me.bntAtras1.UseVisualStyleBackColor = True
        '
        'btnControl
        '
        Me.btnControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControl.Location = New System.Drawing.Point(28, 28)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(196, 59)
        Me.btnControl.TabIndex = 3
        Me.btnControl.Text = "Control de los trabajadores"
        Me.btnControl.UseVisualStyleBackColor = True
        '
        'btnReserva
        '
        Me.btnReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserva.Location = New System.Drawing.Point(30, 29)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(196, 59)
        Me.btnReserva.TabIndex = 1
        Me.btnReserva.Text = "Hacer una reserva"
        Me.btnReserva.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(17, 20)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(366, 55)
        Me.lblMensaje.TabIndex = 5
        Me.lblMensaje.Text = "Bienvenido a la pantalla de entrada," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que desea hacer??"
        '
        'btnVerReservas
        '
        Me.btnVerReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerReservas.Location = New System.Drawing.Point(360, 29)
        Me.btnVerReservas.Name = "btnVerReservas"
        Me.btnVerReservas.Size = New System.Drawing.Size(206, 59)
        Me.btnVerReservas.TabIndex = 2
        Me.btnVerReservas.Text = "Ver reservas realizadas"
        Me.btnVerReservas.UseVisualStyleBackColor = True
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.btnVerReservas)
        Me.gbClientes.Controls.Add(Me.btnReserva)
        Me.gbClientes.Location = New System.Drawing.Point(100, 167)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(604, 115)
        Me.gbClientes.TabIndex = 1
        Me.gbClientes.TabStop = False
        Me.gbClientes.Text = "Clientes"
        '
        'gbTrabajadores
        '
        Me.gbTrabajadores.Controls.Add(Me.btnControl)
        Me.gbTrabajadores.Location = New System.Drawing.Point(100, 301)
        Me.gbTrabajadores.Name = "gbTrabajadores"
        Me.gbTrabajadores.Size = New System.Drawing.Size(254, 110)
        Me.gbTrabajadores.TabIndex = 2
        Me.gbTrabajadores.TabStop = False
        Me.gbTrabajadores.Text = "Trabajadores"
        '
        'p1
        '
        Me.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p1.Controls.Add(Me.lblMensaje)
        Me.p1.Location = New System.Drawing.Point(197, 32)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(401, 97)
        Me.p1.TabIndex = 6
        '
        'FormEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.gbTrabajadores)
        Me.Controls.Add(Me.gbClientes)
        Me.Controls.Add(Me.bntAtras1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormEntrada"
        Me.Text = "FormEntrada"
        Me.gbClientes.ResumeLayout(False)
        Me.gbTrabajadores.ResumeLayout(False)
        Me.p1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntAtras1 As Button
    Friend WithEvents btnControl As Button
    Friend WithEvents btnReserva As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnVerReservas As Button
    Friend WithEvents gbClientes As GroupBox
    Friend WithEvents gbTrabajadores As GroupBox
    Friend WithEvents p1 As Panel
End Class
