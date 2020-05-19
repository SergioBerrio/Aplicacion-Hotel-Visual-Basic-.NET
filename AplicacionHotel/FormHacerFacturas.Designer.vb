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
        Me.components = New System.ComponentModel.Container()
        Me.btnHacerFactura = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtbIDTrabajador = New System.Windows.Forms.TextBox()
        Me.lblIDReserva = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbDNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New AplicacionHotel.BDHotelDataSet()
        Me.FacturasTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.FacturasTableAdapter()
        Me.btnAñadirFactura = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.txtbFecha = New System.Windows.Forms.TextBox()
        Me.lblIDFactura = New System.Windows.Forms.Label()
        Me.txtbIDFactura = New System.Windows.Forms.TextBox()
        Me.dgvHacerFacturas = New System.Windows.Forms.DataGridView()
        Me.IDFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        CType(Me.dgvHacerFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHacerFactura
        '
        Me.btnHacerFactura.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHacerFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHacerFactura.Location = New System.Drawing.Point(602, 41)
        Me.btnHacerFactura.Name = "btnHacerFactura"
        Me.btnHacerFactura.Size = New System.Drawing.Size(191, 47)
        Me.btnHacerFactura.TabIndex = 7
        Me.btnHacerFactura.Text = "Hacer factura"
        Me.btnHacerFactura.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Location = New System.Drawing.Point(290, 374)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(136, 47)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Location = New System.Drawing.Point(494, 374)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(134, 47)
        Me.btnSiguiente.TabIndex = 9
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(696, 374)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(138, 47)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtbIDTrabajador
        '
        Me.txtbIDTrabajador.Enabled = False
        Me.txtbIDTrabajador.Location = New System.Drawing.Point(31, 133)
        Me.txtbIDTrabajador.Name = "txtbIDTrabajador"
        Me.txtbIDTrabajador.Size = New System.Drawing.Size(173, 22)
        Me.txtbIDTrabajador.TabIndex = 2
        '
        'lblIDReserva
        '
        Me.lblIDReserva.AutoSize = True
        Me.lblIDReserva.Location = New System.Drawing.Point(29, 105)
        Me.lblIDReserva.Name = "lblIDReserva"
        Me.lblIDReserva.Size = New System.Drawing.Size(108, 16)
        Me.lblIDReserva.TabIndex = 6
        Me.lblIDReserva.Text = "ID del trabajador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DNI del cliente"
        '
        'txtbDNI
        '
        Me.txtbDNI.Enabled = False
        Me.txtbDNI.Location = New System.Drawing.Point(32, 212)
        Me.txtbDNI.Name = "txtbDNI"
        Me.txtbDNI.Size = New System.Drawing.Size(173, 22)
        Me.txtbDNI.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Importe total"
        '
        'txtbImporteTotal
        '
        Me.txtbImporteTotal.Location = New System.Drawing.Point(31, 290)
        Me.txtbImporteTotal.Name = "txtbImporteTotal"
        Me.txtbImporteTotal.Size = New System.Drawing.Size(173, 22)
        Me.txtbImporteTotal.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha"
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.BDHotelDataSet
        '
        'BDHotelDataSet
        '
        Me.BDHotelDataSet.DataSetName = "BDHotelDataSet"
        Me.BDHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'btnAñadirFactura
        '
        Me.btnAñadirFactura.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAñadirFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAñadirFactura.Location = New System.Drawing.Point(315, 41)
        Me.btnAñadirFactura.Name = "btnAñadirFactura"
        Me.btnAñadirFactura.Size = New System.Drawing.Size(191, 47)
        Me.btnAñadirFactura.TabIndex = 6
        Me.btnAñadirFactura.Text = "Añadir factura"
        Me.btnAñadirFactura.UseVisualStyleBackColor = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.txtbFecha)
        Me.gb1.Controls.Add(Me.lblIDFactura)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.txtbIDFactura)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.txtbImporteTotal)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.txtbDNI)
        Me.gb1.Controls.Add(Me.lblIDReserva)
        Me.gb1.Controls.Add(Me.txtbIDTrabajador)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(23, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(238, 426)
        Me.gb1.TabIndex = 1
        Me.gb1.TabStop = False
        Me.gb1.Text = "Datos de factura"
        '
        'txtbFecha
        '
        Me.txtbFecha.Location = New System.Drawing.Point(31, 374)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(173, 22)
        Me.txtbFecha.TabIndex = 5
        '
        'lblIDFactura
        '
        Me.lblIDFactura.AutoSize = True
        Me.lblIDFactura.Location = New System.Drawing.Point(29, 29)
        Me.lblIDFactura.Name = "lblIDFactura"
        Me.lblIDFactura.Size = New System.Drawing.Size(97, 16)
        Me.lblIDFactura.TabIndex = 16
        Me.lblIDFactura.Text = "ID de la factura"
        '
        'txtbIDFactura
        '
        Me.txtbIDFactura.Enabled = False
        Me.txtbIDFactura.Location = New System.Drawing.Point(32, 56)
        Me.txtbIDFactura.Name = "txtbIDFactura"
        Me.txtbIDFactura.Size = New System.Drawing.Size(173, 22)
        Me.txtbIDFactura.TabIndex = 1
        '
        'dgvHacerFacturas
        '
        Me.dgvHacerFacturas.AutoGenerateColumns = False
        Me.dgvHacerFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHacerFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFacturaDataGridViewTextBoxColumn, Me.IDTrabajadorDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgvHacerFacturas.DataSource = Me.FacturasBindingSource1
        Me.dgvHacerFacturas.Location = New System.Drawing.Point(290, 125)
        Me.dgvHacerFacturas.Name = "dgvHacerFacturas"
        Me.dgvHacerFacturas.Size = New System.Drawing.Size(544, 225)
        Me.dgvHacerFacturas.TabIndex = 11
        '
        'IDFacturaDataGridViewTextBoxColumn
        '
        Me.IDFacturaDataGridViewTextBoxColumn.DataPropertyName = "IDFactura"
        Me.IDFacturaDataGridViewTextBoxColumn.HeaderText = "IDFactura"
        Me.IDFacturaDataGridViewTextBoxColumn.Name = "IDFacturaDataGridViewTextBoxColumn"
        '
        'IDTrabajadorDataGridViewTextBoxColumn
        '
        Me.IDTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.HeaderText = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.Name = "IDTrabajadorDataGridViewTextBoxColumn"
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'ImporteTotalDataGridViewTextBoxColumn
        '
        Me.ImporteTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal"
        Me.ImporteTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal"
        Me.ImporteTotalDataGridViewTextBoxColumn.Name = "ImporteTotalDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'FacturasBindingSource1
        '
        Me.FacturasBindingSource1.DataMember = "Facturas"
        Me.FacturasBindingSource1.DataSource = Me.BDHotelDataSet
        '
        'FormHacerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 450)
        Me.Controls.Add(Me.dgvHacerFacturas)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.btnAñadirFactura)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnHacerFactura)
        Me.Name = "FormHacerFacturas"
        Me.Text = "FormHacerFacturas"
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.dgvHacerFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHacerFactura As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtbIDTrabajador As TextBox
    Friend WithEvents lblIDReserva As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbDNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbImporteTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As BDHotelDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents btnAñadirFactura As Button
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents lblIDFactura As Label
    Friend WithEvents txtbIDFactura As TextBox
    Friend WithEvents dgvHacerFacturas As DataGridView
    Friend WithEvents IDFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturasBindingSource1 As BindingSource
    Friend WithEvents txtbFecha As TextBox
End Class
