<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVerFacturas
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
        Me.btnEliminarReserva = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.IDFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.FacturasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter2 = New AplicacionHotel.BDHotelDataSet1TableAdapters.FacturasTableAdapter()
        Me.gbBuscadorID = New System.Windows.Forms.GroupBox()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.txtbBuscarID = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.gbBuscadorNombre = New System.Windows.Forms.GroupBox()
        Me.btnBucarDNI = New System.Windows.Forms.Button()
        Me.txtbDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FacturasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscadorID.SuspendLayout()
        Me.gbBuscadorNombre.SuspendLayout()
        CType(Me.FacturasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarReserva
        '
        Me.btnEliminarReserva.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarReserva.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarReserva.Location = New System.Drawing.Point(594, 322)
        Me.btnEliminarReserva.Name = "btnEliminarReserva"
        Me.btnEliminarReserva.Size = New System.Drawing.Size(274, 47)
        Me.btnEliminarReserva.TabIndex = 7
        Me.btnEliminarReserva.Text = "Eliminar facturas"
        Me.btnEliminarReserva.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnterior.Location = New System.Drawing.Point(12, 391)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(191, 47)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(366, 391)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(191, 49)
        Me.btnSiguiente.TabIndex = 10
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(594, 391)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(274, 47)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.AutoGenerateColumns = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFacturaDataGridViewTextBoxColumn, Me.IDTrabajadorDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgvFacturas.DataSource = Me.FacturasBindingSource3
        Me.dgvFacturas.Location = New System.Drawing.Point(12, 8)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.ReadOnly = True
        Me.dgvFacturas.Size = New System.Drawing.Size(545, 361)
        Me.dgvFacturas.TabIndex = 12
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
        'FacturasBindingSource3
        '
        Me.FacturasBindingSource3.DataMember = "Facturas"
        Me.FacturasBindingSource3.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasTableAdapter2
        '
        Me.FacturasTableAdapter2.ClearBeforeFill = True
        '
        'gbBuscadorID
        '
        Me.gbBuscadorID.Controls.Add(Me.btnBuscarID)
        Me.gbBuscadorID.Controls.Add(Me.txtbBuscarID)
        Me.gbBuscadorID.Controls.Add(Me.lblBuscar)
        Me.gbBuscadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscadorID.Location = New System.Drawing.Point(594, 8)
        Me.gbBuscadorID.Name = "gbBuscadorID"
        Me.gbBuscadorID.Size = New System.Drawing.Size(274, 156)
        Me.gbBuscadorID.TabIndex = 1
        Me.gbBuscadorID.TabStop = False
        Me.gbBuscadorID.Text = "ID de factura"
        '
        'btnBuscarID
        '
        Me.btnBuscarID.BackColor = System.Drawing.Color.Green
        Me.btnBuscarID.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarID.Location = New System.Drawing.Point(34, 106)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(215, 33)
        Me.btnBuscarID.TabIndex = 3
        Me.btnBuscarID.Text = "Buscar"
        Me.btnBuscarID.UseVisualStyleBackColor = False
        '
        'txtbBuscarID
        '
        Me.txtbBuscarID.Location = New System.Drawing.Point(34, 67)
        Me.txtbBuscarID.Name = "txtbBuscarID"
        Me.txtbBuscarID.Size = New System.Drawing.Size(215, 22)
        Me.txtbBuscarID.TabIndex = 2
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(31, 41)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(83, 16)
        Me.lblBuscar.TabIndex = 8
        Me.lblBuscar.Text = "ID de factura"
        '
        'gbBuscadorNombre
        '
        Me.gbBuscadorNombre.Controls.Add(Me.btnBucarDNI)
        Me.gbBuscadorNombre.Controls.Add(Me.txtbDNI)
        Me.gbBuscadorNombre.Controls.Add(Me.Label1)
        Me.gbBuscadorNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscadorNombre.Location = New System.Drawing.Point(594, 170)
        Me.gbBuscadorNombre.Name = "gbBuscadorNombre"
        Me.gbBuscadorNombre.Size = New System.Drawing.Size(274, 142)
        Me.gbBuscadorNombre.TabIndex = 4
        Me.gbBuscadorNombre.TabStop = False
        Me.gbBuscadorNombre.Text = "DNI"
        '
        'btnBucarDNI
        '
        Me.btnBucarDNI.BackColor = System.Drawing.Color.Green
        Me.btnBucarDNI.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBucarDNI.Location = New System.Drawing.Point(34, 91)
        Me.btnBucarDNI.Name = "btnBucarDNI"
        Me.btnBucarDNI.Size = New System.Drawing.Size(215, 33)
        Me.btnBucarDNI.TabIndex = 6
        Me.btnBucarDNI.Text = "Buscar"
        Me.btnBucarDNI.UseVisualStyleBackColor = False
        '
        'txtbDNI
        '
        Me.txtbDNI.Location = New System.Drawing.Point(34, 52)
        Me.txtbDNI.Name = "txtbDNI"
        Me.txtbDNI.Size = New System.Drawing.Size(215, 22)
        Me.txtbDNI.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DNI"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnActualizar.Location = New System.Drawing.Point(218, 392)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(133, 47)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'FormVerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 450)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.gbBuscadorNombre)
        Me.Controls.Add(Me.gbBuscadorID)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnEliminarReserva)
        Me.Name = "FormVerFacturas"
        Me.Text = "FormVerFacturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscadorID.ResumeLayout(False)
        Me.gbBuscadorID.PerformLayout()
        Me.gbBuscadorNombre.ResumeLayout(False)
        Me.gbBuscadorNombre.PerformLayout()
        CType(Me.FacturasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEliminarReserva As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents BDHotelDataSet As BDHotelDataSet1
    Friend WithEvents BDHotelDataSet1 As BDHotelDataSet1
    Friend WithEvents FacturasTableAdapter As BDHotelDataSet1TableAdapters.FacturasTableAdapter
    Friend WithEvents dgvFacturas As DataGridView
    Friend WithEvents BDHotelDataSet2 As BDHotelDataSet1
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter1 As BDHotelDataSet1TableAdapters.FacturasTableAdapter
    Friend WithEvents FacturasBindingSource1 As BindingSource
    Friend WithEvents FacturasTableAdapter2 As BDHotelDataSet1TableAdapters.FacturasTableAdapter
    Friend WithEvents gbBuscadorID As GroupBox
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents txtbBuscarID As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents gbBuscadorNombre As GroupBox
    Friend WithEvents btnBucarDNI As Button
    Friend WithEvents txtbDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturasBindingSource3 As BindingSource
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents FacturasBindingSource2 As BindingSource
    Friend WithEvents btnActualizar As Button
End Class
