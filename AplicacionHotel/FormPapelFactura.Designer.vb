<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPapelFactura
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
        Me.btnNuevaFactura = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.txbImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.lblEstancia = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtbImporte = New System.Windows.Forms.TextBox()
        Me.txtbImporteActividades = New System.Windows.Forms.TextBox()
        Me.lblImporteActividades = New System.Windows.Forms.Label()
        Me.txtbFecha = New System.Windows.Forms.TextBox()
        Me.txtbIVA = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtbPersonas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbTipoHabitacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbDNI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbSubtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevaFactura
        '
        Me.btnNuevaFactura.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNuevaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNuevaFactura.Location = New System.Drawing.Point(293, 378)
        Me.btnNuevaFactura.Name = "btnNuevaFactura"
        Me.btnNuevaFactura.Size = New System.Drawing.Size(218, 51)
        Me.btnNuevaFactura.TabIndex = 15
        Me.btnNuevaFactura.Text = "Nueva Factura"
        Me.btnNuevaFactura.UseVisualStyleBackColor = False
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.Green
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCobrar.Location = New System.Drawing.Point(31, 378)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(216, 51)
        Me.btnCobrar.TabIndex = 14
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'txbImporteTotal
        '
        Me.txbImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbImporteTotal.Location = New System.Drawing.Point(561, 237)
        Me.txbImporteTotal.Name = "txbImporteTotal"
        Me.txbImporteTotal.Size = New System.Drawing.Size(140, 22)
        Me.txbImporteTotal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Importe:"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.Location = New System.Drawing.Point(22, 150)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(80, 16)
        Me.lblIVA.TabIndex = 10
        Me.lblIVA.Text = "10% de IVA:"
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.Location = New System.Drawing.Point(465, 240)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(90, 16)
        Me.lblImporteTotal.TabIndex = 9
        Me.lblImporteTotal.Text = "Importe Total:"
        '
        'lblEstancia
        '
        Me.lblEstancia.AutoSize = True
        Me.lblEstancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstancia.Location = New System.Drawing.Point(22, 34)
        Me.lblEstancia.Name = "lblEstancia"
        Me.lblEstancia.Size = New System.Drawing.Size(52, 16)
        Me.lblEstancia.TabIndex = 8
        Me.lblEstancia.Text = "Cliente:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(556, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(206, 51)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtbImporte
        '
        Me.txtbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbImporte.Location = New System.Drawing.Point(80, 198)
        Me.txtbImporte.Name = "txtbImporte"
        Me.txtbImporte.Size = New System.Drawing.Size(209, 22)
        Me.txtbImporte.TabIndex = 17
        '
        'txtbImporteActividades
        '
        Me.txtbImporteActividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbImporteActividades.Location = New System.Drawing.Point(458, 198)
        Me.txtbImporteActividades.Name = "txtbImporteActividades"
        Me.txtbImporteActividades.Size = New System.Drawing.Size(243, 22)
        Me.txtbImporteActividades.TabIndex = 18
        '
        'lblImporteActividades
        '
        Me.lblImporteActividades.AutoSize = True
        Me.lblImporteActividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteActividades.Location = New System.Drawing.Point(308, 201)
        Me.lblImporteActividades.Name = "lblImporteActividades"
        Me.lblImporteActividades.Size = New System.Drawing.Size(148, 16)
        Me.lblImporteActividades.TabIndex = 19
        Me.lblImporteActividades.Text = "Importe de actividades:"
        '
        'txtbFecha
        '
        Me.txtbFecha.Enabled = False
        Me.txtbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFecha.Location = New System.Drawing.Point(437, 81)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(264, 22)
        Me.txtbFecha.TabIndex = 20
        '
        'txtbIVA
        '
        Me.txtbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbIVA.Location = New System.Drawing.Point(108, 147)
        Me.txtbIVA.Name = "txtbIVA"
        Me.txtbIVA.Size = New System.Drawing.Size(181, 22)
        Me.txtbIVA.TabIndex = 22
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(275, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(249, 29)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Hotel Paradise Resort"
        '
        'txtbPersonas
        '
        Me.txtbPersonas.Enabled = False
        Me.txtbPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPersonas.Location = New System.Drawing.Point(166, 81)
        Me.txtbPersonas.Name = "txtbPersonas"
        Me.txtbPersonas.Size = New System.Drawing.Size(186, 22)
        Me.txtbPersonas.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Número de personas:"
        '
        'txtbTipoHabitacion
        '
        Me.txtbTipoHabitacion.Enabled = False
        Me.txtbTipoHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbTipoHabitacion.Location = New System.Drawing.Point(437, 147)
        Me.txtbTipoHabitacion.Name = "txtbTipoHabitacion"
        Me.txtbTipoHabitacion.Size = New System.Drawing.Size(264, 22)
        Me.txtbTipoHabitacion.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(308, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tipo de habitación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbSubtotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbDNI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbClientes)
        Me.GroupBox1.Controls.Add(Me.txtbTipoHabitacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbPersonas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbIVA)
        Me.GroupBox1.Controls.Add(Me.txtbFecha)
        Me.GroupBox1.Controls.Add(Me.lblImporteActividades)
        Me.GroupBox1.Controls.Add(Me.txtbImporteActividades)
        Me.GroupBox1.Controls.Add(Me.txtbImporte)
        Me.GroupBox1.Controls.Add(Me.txbImporteTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblIVA)
        Me.GroupBox1.Controls.Add(Me.lblImporteTotal)
        Me.GroupBox1.Controls.Add(Me.lblEstancia)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 275)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la factura"
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(80, 28)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(265, 24)
        Me.cmbClientes.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "DNI:"
        '
        'txtbDNI
        '
        Me.txtbDNI.Enabled = False
        Me.txtbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbDNI.Location = New System.Drawing.Point(427, 31)
        Me.txtbDNI.Name = "txtbDNI"
        Me.txtbDNI.Size = New System.Drawing.Size(274, 22)
        Me.txtbDNI.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Subtotal:"
        '
        'txtbSubtotal
        '
        Me.txtbSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSubtotal.Location = New System.Drawing.Point(84, 240)
        Me.txtbSubtotal.Name = "txtbSubtotal"
        Me.txtbSubtotal.Size = New System.Drawing.Size(205, 22)
        Me.txtbSubtotal.TabIndex = 32
        '
        'FormPapelFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevaFactura)
        Me.Controls.Add(Me.btnCobrar)
        Me.Name = "FormPapelFactura"
        Me.Text = "FormPapelFactura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevaFactura As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents txbImporteTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents lblEstancia As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtbImporte As TextBox
    Friend WithEvents txtbImporteActividades As TextBox
    Friend WithEvents lblImporteActividades As Label
    Friend WithEvents txtbFecha As TextBox
    Friend WithEvents txtbIVA As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtbPersonas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbTipoHabitacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents txtbDNI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbSubtotal As TextBox
    Friend WithEvents Label6 As Label
End Class
