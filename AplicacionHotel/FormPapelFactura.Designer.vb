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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudIVA = New System.Windows.Forms.NumericUpDown()
        Me.cmbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.txtbSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbDNI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevaFactura
        '
        Me.btnNuevaFactura.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNuevaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNuevaFactura.Location = New System.Drawing.Point(214, 387)
        Me.btnNuevaFactura.Name = "btnNuevaFactura"
        Me.btnNuevaFactura.Size = New System.Drawing.Size(177, 51)
        Me.btnNuevaFactura.TabIndex = 12
        Me.btnNuevaFactura.Text = "Nueva Factura"
        Me.btnNuevaFactura.UseVisualStyleBackColor = False
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.Green
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCobrar.Location = New System.Drawing.Point(31, 387)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(177, 51)
        Me.btnCobrar.TabIndex = 11
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'txbImporteTotal
        '
        Me.txbImporteTotal.Enabled = False
        Me.txbImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbImporteTotal.Location = New System.Drawing.Point(561, 237)
        Me.txbImporteTotal.Name = "txbImporteTotal"
        Me.txbImporteTotal.Size = New System.Drawing.Size(140, 22)
        Me.txbImporteTotal.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 153)
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
        Me.lblIVA.Size = New System.Drawing.Size(66, 16)
        Me.lblIVA.TabIndex = 10
        Me.lblIVA.Text = "% de IVA:"
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
        Me.btnSalir.Location = New System.Drawing.Point(585, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(177, 51)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtbImporte
        '
        Me.txtbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbImporte.Location = New System.Drawing.Point(373, 150)
        Me.txtbImporte.Name = "txtbImporte"
        Me.txtbImporte.Size = New System.Drawing.Size(328, 22)
        Me.txtbImporte.TabIndex = 7
        '
        'txtbImporteActividades
        '
        Me.txtbImporteActividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbImporteActividades.Location = New System.Drawing.Point(458, 198)
        Me.txtbImporteActividades.Name = "txtbImporteActividades"
        Me.txtbImporteActividades.Size = New System.Drawing.Size(243, 22)
        Me.txtbImporteActividades.TabIndex = 9
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
        Me.txtbFecha.Location = New System.Drawing.Point(77, 73)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(268, 22)
        Me.txtbFecha.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(226, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(385, 44)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Hotel Paradise Resort"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tipo de habitación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudIVA)
        Me.GroupBox1.Controls.Add(Me.cmbTipoHabitacion)
        Me.GroupBox1.Controls.Add(Me.txtbSubtotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbDNI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbClientes)
        Me.GroupBox1.Controls.Add(Me.Label2)
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
        Me.GroupBox1.Location = New System.Drawing.Point(31, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 287)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la factura"
        '
        'nudIVA
        '
        Me.nudIVA.Location = New System.Drawing.Point(96, 149)
        Me.nudIVA.Name = "nudIVA"
        Me.nudIVA.Size = New System.Drawing.Size(192, 22)
        Me.nudIVA.TabIndex = 6
        '
        'cmbTipoHabitacion
        '
        Me.cmbTipoHabitacion.FormattingEnabled = True
        Me.cmbTipoHabitacion.Location = New System.Drawing.Point(516, 73)
        Me.cmbTipoHabitacion.Name = "cmbTipoHabitacion"
        Me.cmbTipoHabitacion.Size = New System.Drawing.Size(185, 24)
        Me.cmbTipoHabitacion.TabIndex = 5
        '
        'txtbSubtotal
        '
        Me.txtbSubtotal.Enabled = False
        Me.txtbSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSubtotal.Location = New System.Drawing.Point(88, 198)
        Me.txtbSubtotal.Name = "txtbSubtotal"
        Me.txtbSubtotal.Size = New System.Drawing.Size(205, 22)
        Me.txtbSubtotal.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Subtotal:"
        '
        'txtbDNI
        '
        Me.txtbDNI.Enabled = False
        Me.txtbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbDNI.Location = New System.Drawing.Point(427, 31)
        Me.txtbDNI.Name = "txtbDNI"
        Me.txtbDNI.Size = New System.Drawing.Size(274, 22)
        Me.txtbDNI.TabIndex = 3
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
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(80, 28)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(265, 24)
        Me.cmbClientes.TabIndex = 2
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.BackColor = System.Drawing.Color.Orange
        Me.btnVerFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerFacturas.Location = New System.Drawing.Point(397, 387)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(177, 51)
        Me.btnVerFacturas.TabIndex = 13
        Me.btnVerFacturas.Text = "Ver reservas"
        Me.btnVerFacturas.UseVisualStyleBackColor = False
        '
        'FormPapelFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVerFacturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevaFactura)
        Me.Controls.Add(Me.btnCobrar)
        Me.Name = "FormPapelFactura"
        Me.Text = "FormPapelFactura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudIVA, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents txtbDNI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnVerFacturas As Button
    Friend WithEvents cmbTipoHabitacion As ComboBox
    Friend WithEvents nudIVA As NumericUpDown
End Class
