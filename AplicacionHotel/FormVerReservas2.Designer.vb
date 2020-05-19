<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerReservas2
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
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.IDReservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantPersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New AplicacionHotel.BDHotelDataSet()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnEliminarReserva = New System.Windows.Forms.Button()
        Me.ReservasTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.ReservasTableAdapter()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReservas
        '
        Me.dgvReservas.AutoGenerateColumns = False
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservaDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CantPersDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.FechaFinDataGridViewTextBoxColumn, Me.NumHabitacionDataGridViewTextBoxColumn})
        Me.dgvReservas.DataSource = Me.ReservasBindingSource
        Me.dgvReservas.Location = New System.Drawing.Point(28, 22)
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.Size = New System.Drawing.Size(745, 327)
        Me.dgvReservas.TabIndex = 10
        '
        'IDReservaDataGridViewTextBoxColumn
        '
        Me.IDReservaDataGridViewTextBoxColumn.DataPropertyName = "IDReserva"
        Me.IDReservaDataGridViewTextBoxColumn.HeaderText = "IDReserva"
        Me.IDReservaDataGridViewTextBoxColumn.Name = "IDReservaDataGridViewTextBoxColumn"
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'CantPersDataGridViewTextBoxColumn
        '
        Me.CantPersDataGridViewTextBoxColumn.DataPropertyName = "CantPers"
        Me.CantPersDataGridViewTextBoxColumn.HeaderText = "CantPers"
        Me.CantPersDataGridViewTextBoxColumn.Name = "CantPersDataGridViewTextBoxColumn"
        '
        'FechaInicioDataGridViewTextBoxColumn
        '
        Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
        '
        'FechaFinDataGridViewTextBoxColumn
        '
        Me.FechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin"
        Me.FechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin"
        Me.FechaFinDataGridViewTextBoxColumn.Name = "FechaFinDataGridViewTextBoxColumn"
        '
        'NumHabitacionDataGridViewTextBoxColumn
        '
        Me.NumHabitacionDataGridViewTextBoxColumn.DataPropertyName = "NumHabitacion"
        Me.NumHabitacionDataGridViewTextBoxColumn.HeaderText = "NumHabitacion"
        Me.NumHabitacionDataGridViewTextBoxColumn.Name = "NumHabitacionDataGridViewTextBoxColumn"
        '
        'ReservasBindingSource
        '
        Me.ReservasBindingSource.DataMember = "Reservas"
        Me.ReservasBindingSource.DataSource = Me.BDHotelDataSet
        '
        'BDHotelDataSet
        '
        Me.BDHotelDataSet.DataSetName = "BDHotelDataSet"
        Me.BDHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(613, 381)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(160, 47)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Location = New System.Drawing.Point(223, 381)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(157, 47)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Location = New System.Drawing.Point(28, 381)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(158, 47)
        Me.btnAnterior.TabIndex = 7
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnEliminarReserva
        '
        Me.btnEliminarReserva.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarReserva.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarReserva.Location = New System.Drawing.Point(413, 381)
        Me.btnEliminarReserva.Name = "btnEliminarReserva"
        Me.btnEliminarReserva.Size = New System.Drawing.Size(162, 47)
        Me.btnEliminarReserva.TabIndex = 6
        Me.btnEliminarReserva.Text = "Eliminar reservas"
        Me.btnEliminarReserva.UseVisualStyleBackColor = False
        '
        'ReservasTableAdapter
        '
        Me.ReservasTableAdapter.ClearBeforeFill = True
        '
        'FormVerReservas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvReservas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnEliminarReserva)
        Me.Name = "FormVerReservas2"
        Me.Text = "FormVerReservas2"
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReservas As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnEliminarReserva As Button
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents ReservasBindingSource As BindingSource
    Friend WithEvents ReservasTableAdapter As BDHotelDataSetTableAdapters.ReservasTableAdapter
    Friend WithEvents IDReservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantPersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumHabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
