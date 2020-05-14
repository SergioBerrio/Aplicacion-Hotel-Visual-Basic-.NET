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
        Me.SuspendLayout()
        '
        'bntAtras1
        '
        Me.bntAtras1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAtras1.Location = New System.Drawing.Point(460, 274)
        Me.bntAtras1.Name = "bntAtras1"
        Me.bntAtras1.Size = New System.Drawing.Size(206, 60)
        Me.bntAtras1.TabIndex = 2
        Me.bntAtras1.Text = "Atrás"
        Me.bntAtras1.UseVisualStyleBackColor = True
        '
        'btnControl
        '
        Me.btnControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControl.Location = New System.Drawing.Point(281, 155)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(190, 59)
        Me.btnControl.TabIndex = 3
        Me.btnControl.Text = "Control de los trabajadores"
        Me.btnControl.UseVisualStyleBackColor = True
        '
        'btnReserva
        '
        Me.btnReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserva.Location = New System.Drawing.Point(108, 276)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(183, 59)
        Me.btnReserva.TabIndex = 1
        Me.btnReserva.Text = "Hacer una reserva"
        Me.btnReserva.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(211, 54)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(366, 66)
        Me.lblMensaje.TabIndex = 5
        Me.lblMensaje.Text = "Bienvenido  a la pantalla de entrada," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que es lo que desea hacer??"
        '
        'FormEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.bntAtras1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormEntrada"
        Me.Text = "FormEntrada"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntAtras1 As Button
    Friend WithEvents btnControl As Button
    Friend WithEvents btnReserva As Button
    Friend WithEvents lblMensaje As Label
End Class
