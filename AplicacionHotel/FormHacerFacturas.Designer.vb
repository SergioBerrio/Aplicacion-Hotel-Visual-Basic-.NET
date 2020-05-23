<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHacerFacturas
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
        Me.components = New System.ComponentModel.Container()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregarFactura = New System.Windows.Forms.Button()
        Me.btnHacerFactura = New System.Windows.Forms.Button()
        Me.gbFactura = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbIDReserva = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblIDTrabajador = New System.Windows.Forms.Label()
        Me.txtbFecha = New System.Windows.Forms.TextBox()
        Me.txtbImporteTotal = New System.Windows.Forms.TextBox()
        Me.txtbDNICliente = New System.Windows.Forms.TextBox()
        Me.txtbIDTrabajador = New System.Windows.Forms.TextBox()
        Me.dgvHacerFacturas = New System.Windows.Forms.DataGridView()
        Me.IDFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.FacturasTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.FacturasTableAdapter()
        Me.gbFactura.SuspendLayout()
        CType(Me.dgvHacerFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(23, 377)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(221, 58)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(347, 377)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(221, 58)
        Me.btnSiguiente.TabIndex = 9
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(593, 377)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(221, 58)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregarFactura
        '
        Me.btnAgregarFactura.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarFactura.Location = New System.Drawing.Point(23, 12)
        Me.btnAgregarFactura.Name = "btnAgregarFactura"
        Me.btnAgregarFactura.Size = New System.Drawing.Size(221, 58)
        Me.btnAgregarFactura.TabIndex = 6
        Me.btnAgregarFactura.Text = "Agregar factura"
        Me.btnAgregarFactura.UseVisualStyleBackColor = False
        '
        'btnHacerFactura
        '
        Me.btnHacerFactura.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHacerFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHacerFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHacerFactura.Location = New System.Drawing.Point(347, 18)
        Me.btnHacerFactura.Name = "btnHacerFactura"
        Me.btnHacerFactura.Size = New System.Drawing.Size(221, 58)
        Me.btnHacerFactura.TabIndex = 7
        Me.btnHacerFactura.Text = "Imprimir factura"
        Me.btnHacerFactura.UseVisualStyleBackColor = False
        '
        'gbFactura
        '
        Me.gbFactura.Controls.Add(Me.Label1)
        Me.gbFactura.Controls.Add(Me.txtbIDReserva)
        Me.gbFactura.Controls.Add(Me.lblFecha)
        Me.gbFactura.Controls.Add(Me.lblImporteTotal)
        Me.gbFactura.Controls.Add(Me.lblDNI)
        Me.gbFactura.Controls.Add(Me.lblIDTrabajador)
        Me.gbFactura.Controls.Add(Me.txtbFecha)
        Me.gbFactura.Controls.Add(Me.txtbImporteTotal)
        Me.gbFactura.Controls.Add(Me.txtbDNICliente)
        Me.gbFactura.Controls.Add(Me.txtbIDTrabajador)
        Me.gbFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFactura.Location = New System.Drawing.Point(593, 18)
        Me.gbFactura.Name = "gbFactura"
        Me.gbFactura.Size = New System.Drawing.Size(225, 353)
        Me.gbFactura.TabIndex = 1
        Me.gbFactura.TabStop = False
        Me.gbFactura.Text = "Datos de la factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID de la reserva"
        '
        'txtbIDReserva
        '
        Me.txtbIDReserva.Enabled = False
        Me.txtbIDReserva.Location = New System.Drawing.Point(22, 49)
        Me.txtbIDReserva.Name = "txtbIDReserva"
        Me.txtbIDReserva.Size = New System.Drawing.Size(176, 22)
        Me.txtbIDReserva.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(19, 279)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 16)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha"
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Location = New System.Drawing.Point(19, 210)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(81, 16)
        Me.lblImporteTotal.TabIndex = 8
        Me.lblImporteTotal.Text = "Importe total"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(19, 150)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(95, 16)
        Me.lblDNI.TabIndex = 7
        Me.lblDNI.Text = "DNI del cliente"
        '
        'lblIDTrabajador
        '
        Me.lblIDTrabajador.AutoSize = True
        Me.lblIDTrabajador.Location = New System.Drawing.Point(19, 90)
        Me.lblIDTrabajador.Name = "lblIDTrabajador"
        Me.lblIDTrabajador.Size = New System.Drawing.Size(100, 16)
        Me.lblIDTrabajador.TabIndex = 6
        Me.lblIDTrabajador.Text = "ID del trabajdor"
        '
        'txtbFecha
        '
        Me.txtbFecha.Enabled = False
        Me.txtbFecha.Location = New System.Drawing.Point(22, 308)
        Me.txtbFecha.Name = "txtbFecha"
        Me.txtbFecha.Size = New System.Drawing.Size(176, 22)
        Me.txtbFecha.TabIndex = 5
        '
        'txtbImporteTotal
        '
        Me.txtbImporteTotal.Location = New System.Drawing.Point(22, 240)
        Me.txtbImporteTotal.Name = "txtbImporteTotal"
        Me.txtbImporteTotal.Size = New System.Drawing.Size(176, 22)
        Me.txtbImporteTotal.TabIndex = 4
        '
        'txtbDNICliente
        '
        Me.txtbDNICliente.Enabled = False
        Me.txtbDNICliente.Location = New System.Drawing.Point(22, 169)
        Me.txtbDNICliente.Name = "txtbDNICliente"
        Me.txtbDNICliente.Size = New System.Drawing.Size(176, 22)
        Me.txtbDNICliente.TabIndex = 3
        '
        'txtbIDTrabajador
        '
        Me.txtbIDTrabajador.Enabled = False
        Me.txtbIDTrabajador.Location = New System.Drawing.Point(22, 109)
        Me.txtbIDTrabajador.Name = "txtbIDTrabajador"
        Me.txtbIDTrabajador.Size = New System.Drawing.Size(176, 22)
        Me.txtbIDTrabajador.TabIndex = 2
        '
        'dgvHacerFacturas
        '
        Me.dgvHacerFacturas.AllowUserToDeleteRows = False
        Me.dgvHacerFacturas.AutoGenerateColumns = False
        Me.dgvHacerFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHacerFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFacturaDataGridViewTextBoxColumn, Me.IDTrabajadorDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgvHacerFacturas.DataSource = Me.FacturasBindingSource
        Me.dgvHacerFacturas.Location = New System.Drawing.Point(23, 82)
        Me.dgvHacerFacturas.Name = "dgvHacerFacturas"
        Me.dgvHacerFacturas.ReadOnly = True
        Me.dgvHacerFacturas.Size = New System.Drawing.Size(545, 289)
        Me.dgvHacerFacturas.TabIndex = 6
        '
        'IDFacturaDataGridViewTextBoxColumn
        '
        Me.IDFacturaDataGridViewTextBoxColumn.DataPropertyName = "IDFactura"
        Me.IDFacturaDataGridViewTextBoxColumn.HeaderText = "IDFactura"
        Me.IDFacturaDataGridViewTextBoxColumn.Name = "IDFacturaDataGridViewTextBoxColumn"
        Me.IDFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDTrabajadorDataGridViewTextBoxColumn
        '
        Me.IDTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.HeaderText = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.Name = "IDTrabajadorDataGridViewTextBoxColumn"
        Me.IDTrabajadorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteTotalDataGridViewTextBoxColumn
        '
        Me.ImporteTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal"
        Me.ImporteTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal"
        Me.ImporteTotalDataGridViewTextBoxColumn.Name = "ImporteTotalDataGridViewTextBoxColumn"
        Me.ImporteTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'FormHacerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 450)
        Me.Controls.Add(Me.dgvHacerFacturas)
        Me.Controls.Add(Me.gbFactura)
        Me.Controls.Add(Me.btnHacerFactura)
        Me.Controls.Add(Me.btnAgregarFactura)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Name = "FormHacerFacturas"
        Me.Text = "FormHacerFacturas"
        Me.gbFactura.ResumeLayout(False)
        Me.gbFactura.PerformLayout()
        CType(Me.dgvHacerFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregarFactura As Button
    Friend WithEvents btnHacerFactura As Button
    Friend WithEvents gbFactura As GroupBox
    Friend WithEvents dgvHacerFacturas As DataGridView
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As BDHotelDataSet1TableAdapters.FacturasTableAdapter
    Friend WithEvents IDFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblIDTrabajador As Label
    Friend WithEvents txtbFecha As TextBox
    Friend WithEvents txtbImporteTotal As TextBox
    Friend WithEvents txtbDNICliente As TextBox
    Friend WithEvents txtbIDTrabajador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbIDReserva As TextBox
End Class
