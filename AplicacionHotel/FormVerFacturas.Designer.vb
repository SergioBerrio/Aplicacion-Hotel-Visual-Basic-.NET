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
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet2 = New AplicacionHotel.BDHotelDataSet()
        Me.FacturasTableAdapter1 = New AplicacionHotel.BDHotelDataSetTableAdapters.FacturasTableAdapter()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarReserva
        '
        Me.btnEliminarReserva.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarReserva.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarReserva.Location = New System.Drawing.Point(555, 25)
        Me.btnEliminarReserva.Name = "btnEliminarReserva"
        Me.btnEliminarReserva.Size = New System.Drawing.Size(191, 47)
        Me.btnEliminarReserva.TabIndex = 2
        Me.btnEliminarReserva.Text = "Eliminar facturas"
        Me.btnEliminarReserva.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAnterior.Location = New System.Drawing.Point(555, 223)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(191, 47)
        Me.btnAnterior.TabIndex = 3
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Location = New System.Drawing.Point(555, 298)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(191, 47)
        Me.btnSiguiente.TabIndex = 4
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(555, 377)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(191, 47)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AutoGenerateColumns = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTrabajadorDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgvFacturas.DataSource = Me.FacturasBindingSource
        Me.dgvFacturas.Location = New System.Drawing.Point(12, 8)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.Size = New System.Drawing.Size(446, 415)
        Me.dgvFacturas.TabIndex = 6
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
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.BDHotelDataSet2
        Me.BindingSource1.Position = 0
        '
        'BDHotelDataSet2
        '
        Me.BDHotelDataSet2.DataSetName = "BDHotelDataSet"
        Me.BDHotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasTableAdapter1
        '
        Me.FacturasTableAdapter1.ClearBeforeFill = True
        '
        'FormVerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnEliminarReserva)
        Me.Name = "FormVerFacturas"
        Me.Text = "FormVerFacturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEliminarReserva As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents BDHotelDataSet1 As BDHotelDataSet
    Friend WithEvents FacturasTableAdapter As BDHotelDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents dgvFacturas As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BDHotelDataSet2 As BDHotelDataSet
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter1 As BDHotelDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
