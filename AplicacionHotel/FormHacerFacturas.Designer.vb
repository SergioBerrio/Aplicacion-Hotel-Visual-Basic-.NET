<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHacerFacturas
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
        Me.btnHacerFactura = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtbDNI = New System.Windows.Forms.TextBox()
        Me.lblIDReserva = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDTrabajador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbFecha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnHacerFactura
        '
        Me.btnHacerFactura.Location = New System.Drawing.Point(552, 40)
        Me.btnHacerFactura.Name = "btnHacerFactura"
        Me.btnHacerFactura.Size = New System.Drawing.Size(191, 47)
        Me.btnHacerFactura.TabIndex = 1
        Me.btnHacerFactura.Text = "Hacer factura"
        Me.btnHacerFactura.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(52, 374)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(191, 47)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(299, 374)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(191, 47)
        Me.btnSiguiente.TabIndex = 3
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(552, 374)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(191, 47)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtbDNI
        '
        Me.txtbDNI.Enabled = False
        Me.txtbDNI.Location = New System.Drawing.Point(52, 67)
        Me.txtbDNI.Name = "txtbDNI"
        Me.txtbDNI.Size = New System.Drawing.Size(173, 20)
        Me.txtbDNI.TabIndex = 5
        '
        'lblIDReserva
        '
        Me.lblIDReserva.AutoSize = True
        Me.lblIDReserva.Location = New System.Drawing.Point(50, 101)
        Me.lblIDReserva.Name = "lblIDReserva"
        Me.lblIDReserva.Size = New System.Drawing.Size(85, 13)
        Me.lblIDReserva.TabIndex = 6
        Me.lblIDReserva.Text = "ID del trabajador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DNI del cliente"
        '
        'txtIDTrabajador
        '
        Me.txtIDTrabajador.Enabled = False
        Me.txtIDTrabajador.Location = New System.Drawing.Point(52, 127)
        Me.txtIDTrabajador.Name = "txtIDTrabajador"
        Me.txtIDTrabajador.Size = New System.Drawing.Size(173, 20)
        Me.txtIDTrabajador.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Importe total"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Location = New System.Drawing.Point(52, 196)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(173, 20)
        Me.txtImporteTotal.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha"
        '
        'txtbFecha
        '
        Me.txtbFecha.Enabled = False
        Me.txtbFecha.Location = New System.Drawing.Point(53, 260)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(173, 20)
        Me.txtbFecha.TabIndex = 11
        '
        'FormHacerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtImporteTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDTrabajador)
        Me.Controls.Add(Me.lblIDReserva)
        Me.Controls.Add(Me.txtbDNI)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnHacerFactura)
        Me.Name = "FormHacerFacturas"
        Me.Text = "FormHacerFacturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHacerFactura As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtbDNI As TextBox
    Friend WithEvents lblIDReserva As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDTrabajador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtImporteTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbFecha As TextBox
End Class
