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
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscarDNI = New System.Windows.Forms.Button()
        Me.txtbBuscarDNI = New System.Windows.Forms.TextBox()
        Me.lblBuscarNombre = New System.Windows.Forms.Label()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.txtbBuscarID = New System.Windows.Forms.TextBox()
        Me.lblBuscarID = New System.Windows.Forms.Label()
        Me.dgvVerReservas = New System.Windows.Forms.DataGridView()
        Me.IDReservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantPersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnEliminarReservas = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.bnAnterior = New System.Windows.Forms.Button()
        Me.ReservasTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.ReservasTableAdapter()
        Me.gbBuscar.SuspendLayout()
        CType(Me.dgvVerReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarDNI)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarDNI)
        Me.gbBuscar.Controls.Add(Me.lblBuscarNombre)
        Me.gbBuscar.Controls.Add(Me.btnBuscarID)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarID)
        Me.gbBuscar.Controls.Add(Me.lblBuscarID)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(769, 14)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(212, 269)
        Me.gbBuscar.TabIndex = 11
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarDNI
        '
        Me.btnBuscarDNI.BackColor = System.Drawing.Color.Green
        Me.btnBuscarDNI.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarDNI.Location = New System.Drawing.Point(17, 222)
        Me.btnBuscarDNI.Name = "btnBuscarDNI"
        Me.btnBuscarDNI.Size = New System.Drawing.Size(176, 33)
        Me.btnBuscarDNI.TabIndex = 13
        Me.btnBuscarDNI.Text = "Buscar"
        Me.btnBuscarDNI.UseVisualStyleBackColor = False
        '
        'txtbBuscarDNI
        '
        Me.txtbBuscarDNI.Location = New System.Drawing.Point(18, 194)
        Me.txtbBuscarDNI.Name = "txtbBuscarDNI"
        Me.txtbBuscarDNI.Size = New System.Drawing.Size(175, 22)
        Me.txtbBuscarDNI.TabIndex = 12
        '
        'lblBuscarNombre
        '
        Me.lblBuscarNombre.AutoSize = True
        Me.lblBuscarNombre.Location = New System.Drawing.Point(12, 163)
        Me.lblBuscarNombre.Name = "lblBuscarNombre"
        Me.lblBuscarNombre.Size = New System.Drawing.Size(31, 16)
        Me.lblBuscarNombre.TabIndex = 11
        Me.lblBuscarNombre.Text = "DNI"
        '
        'btnBuscarID
        '
        Me.btnBuscarID.BackColor = System.Drawing.Color.Green
        Me.btnBuscarID.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarID.Location = New System.Drawing.Point(15, 100)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(176, 33)
        Me.btnBuscarID.TabIndex = 10
        Me.btnBuscarID.Text = "Buscar"
        Me.btnBuscarID.UseVisualStyleBackColor = False
        '
        'txtbBuscarID
        '
        Me.txtbBuscarID.Location = New System.Drawing.Point(16, 72)
        Me.txtbBuscarID.Name = "txtbBuscarID"
        Me.txtbBuscarID.Size = New System.Drawing.Size(175, 22)
        Me.txtbBuscarID.TabIndex = 9
        '
        'lblBuscarID
        '
        Me.lblBuscarID.AutoSize = True
        Me.lblBuscarID.Location = New System.Drawing.Point(14, 43)
        Me.lblBuscarID.Name = "lblBuscarID"
        Me.lblBuscarID.Size = New System.Drawing.Size(89, 16)
        Me.lblBuscarID.TabIndex = 8
        Me.lblBuscarID.Text = "ID de reserva"
        '
        'dgvVerReservas
        '
        Me.dgvVerReservas.AllowUserToDeleteRows = False
        Me.dgvVerReservas.AutoGenerateColumns = False
        Me.dgvVerReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVerReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservaDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CantPersDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.FechaFinDataGridViewTextBoxColumn, Me.NumHabitacionDataGridViewTextBoxColumn})
        Me.dgvVerReservas.DataSource = Me.ReservasBindingSource
        Me.dgvVerReservas.Location = New System.Drawing.Point(12, 12)
        Me.dgvVerReservas.Name = "dgvVerReservas"
        Me.dgvVerReservas.ReadOnly = True
        Me.dgvVerReservas.Size = New System.Drawing.Size(744, 363)
        Me.dgvVerReservas.TabIndex = 10
        '
        'IDReservaDataGridViewTextBoxColumn
        '
        Me.IDReservaDataGridViewTextBoxColumn.DataPropertyName = "IDReserva"
        Me.IDReservaDataGridViewTextBoxColumn.HeaderText = "IDReserva"
        Me.IDReservaDataGridViewTextBoxColumn.Name = "IDReservaDataGridViewTextBoxColumn"
        Me.IDReservaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantPersDataGridViewTextBoxColumn
        '
        Me.CantPersDataGridViewTextBoxColumn.DataPropertyName = "CantPers"
        Me.CantPersDataGridViewTextBoxColumn.HeaderText = "CantPers"
        Me.CantPersDataGridViewTextBoxColumn.Name = "CantPersDataGridViewTextBoxColumn"
        Me.CantPersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInicioDataGridViewTextBoxColumn
        '
        Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
        Me.FechaInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaFinDataGridViewTextBoxColumn
        '
        Me.FechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin"
        Me.FechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin"
        Me.FechaFinDataGridViewTextBoxColumn.Name = "FechaFinDataGridViewTextBoxColumn"
        Me.FechaFinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumHabitacionDataGridViewTextBoxColumn
        '
        Me.NumHabitacionDataGridViewTextBoxColumn.DataPropertyName = "NumHabitacion"
        Me.NumHabitacionDataGridViewTextBoxColumn.HeaderText = "NumHabitacion"
        Me.NumHabitacionDataGridViewTextBoxColumn.Name = "NumHabitacionDataGridViewTextBoxColumn"
        Me.NumHabitacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReservasBindingSource
        '
        Me.ReservasBindingSource.DataMember = "Reservas"
        Me.ReservasBindingSource.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(769, 387)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(212, 54)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnEliminarReservas
        '
        Me.btnEliminarReservas.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarReservas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarReservas.Location = New System.Drawing.Point(769, 304)
        Me.btnEliminarReservas.Name = "btnEliminarReservas"
        Me.btnEliminarReservas.Size = New System.Drawing.Size(214, 54)
        Me.btnEliminarReservas.TabIndex = 8
        Me.btnEliminarReservas.Text = "EliminarReservas"
        Me.btnEliminarReservas.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(532, 381)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(224, 54)
        Me.btnSiguiente.TabIndex = 7
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'bnAnterior
        '
        Me.bnAnterior.BackColor = System.Drawing.Color.Orange
        Me.bnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnAnterior.Location = New System.Drawing.Point(12, 387)
        Me.bnAnterior.Name = "bnAnterior"
        Me.bnAnterior.Size = New System.Drawing.Size(216, 54)
        Me.bnAnterior.TabIndex = 6
        Me.bnAnterior.Text = "Anterior"
        Me.bnAnterior.UseVisualStyleBackColor = False
        '
        'ReservasTableAdapter
        '
        Me.ReservasTableAdapter.ClearBeforeFill = True
        '
        'FormVerReservas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 450)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.dgvVerReservas)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnEliminarReservas)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.bnAnterior)
        Me.Name = "FormVerReservas2"
        Me.Text = "FormVerReservas2"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.dgvVerReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarDNI As Button
    Friend WithEvents txtbBuscarDNI As TextBox
    Friend WithEvents lblBuscarNombre As Label
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents txtbBuscarID As TextBox
    Friend WithEvents lblBuscarID As Label
    Friend WithEvents dgvVerReservas As DataGridView
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEliminarReservas As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents bnAnterior As Button
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents ReservasBindingSource As BindingSource
    Friend WithEvents ReservasTableAdapter As BDHotelDataSet1TableAdapters.ReservasTableAdapter
    Friend WithEvents IDReservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantPersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumHabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
