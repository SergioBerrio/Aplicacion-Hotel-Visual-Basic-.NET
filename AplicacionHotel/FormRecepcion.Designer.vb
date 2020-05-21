<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecepcion
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
        Me.btnVerReservas = New System.Windows.Forms.Button()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.btnHacerFacturas = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnHacerReserva = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVerReservas
        '
        Me.btnVerReservas.BackColor = System.Drawing.Color.Goldenrod
        Me.btnVerReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerReservas.Location = New System.Drawing.Point(90, 185)
        Me.btnVerReservas.Name = "btnVerReservas"
        Me.btnVerReservas.Size = New System.Drawing.Size(232, 74)
        Me.btnVerReservas.TabIndex = 3
        Me.btnVerReservas.Text = "Ver reservas de los clientes"
        Me.btnVerReservas.UseVisualStyleBackColor = False
        '
        'btnVerClientes
        '
        Me.btnVerClientes.BackColor = System.Drawing.Color.Goldenrod
        Me.btnVerClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerClientes.Location = New System.Drawing.Point(90, 310)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(232, 74)
        Me.btnVerClientes.TabIndex = 5
        Me.btnVerClientes.Text = "Ver clientes"
        Me.btnVerClientes.UseVisualStyleBackColor = False
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.BackColor = System.Drawing.Color.Goldenrod
        Me.btnVerFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerFacturas.Location = New System.Drawing.Point(469, 185)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(232, 74)
        Me.btnVerFacturas.TabIndex = 4
        Me.btnVerFacturas.Text = "Ver facturas"
        Me.btnVerFacturas.UseVisualStyleBackColor = False
        '
        'btnHacerFacturas
        '
        Me.btnHacerFacturas.BackColor = System.Drawing.Color.Goldenrod
        Me.btnHacerFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHacerFacturas.Location = New System.Drawing.Point(469, 61)
        Me.btnHacerFacturas.Name = "btnHacerFacturas"
        Me.btnHacerFacturas.Size = New System.Drawing.Size(232, 74)
        Me.btnHacerFacturas.TabIndex = 2
        Me.btnHacerFacturas.Text = "Hacer facturas"
        Me.btnHacerFacturas.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(469, 310)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(232, 74)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnHacerReserva
        '
        Me.btnHacerReserva.BackColor = System.Drawing.Color.Goldenrod
        Me.btnHacerReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHacerReserva.Location = New System.Drawing.Point(90, 61)
        Me.btnHacerReserva.Name = "btnHacerReserva"
        Me.btnHacerReserva.Size = New System.Drawing.Size(232, 74)
        Me.btnHacerReserva.TabIndex = 1
        Me.btnHacerReserva.Text = "Hacer reservas de clientes"
        Me.btnHacerReserva.UseVisualStyleBackColor = False
        '
        'FormRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHacerReserva)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnHacerFacturas)
        Me.Controls.Add(Me.btnVerFacturas)
        Me.Controls.Add(Me.btnVerClientes)
        Me.Controls.Add(Me.btnVerReservas)
        Me.Name = "FormRecepcion"
        Me.Text = "FormRecepcion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerReservas As Button
    Friend WithEvents btnVerClientes As Button
    Friend WithEvents btnVerFacturas As Button
    Friend WithEvents btnHacerFacturas As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnHacerReserva As Button
End Class
