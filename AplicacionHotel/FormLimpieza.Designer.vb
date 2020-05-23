<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLimpieza
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
        Me.btnBuscarTipo = New System.Windows.Forms.Button()
        Me.txtbBuscarTipo = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnBuscarNumero = New System.Windows.Forms.Button()
        Me.txtbBuscarNumero = New System.Windows.Forms.TextBox()
        Me.lblIDIncidencia = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.dgvLimpieza = New System.Windows.Forms.DataGridView()
        Me.NumHabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCamasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.HabitacionesTableAdapter()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.gbBuscar.SuspendLayout()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLimpieza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarTipo)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarTipo)
        Me.gbBuscar.Controls.Add(Me.lblEstado)
        Me.gbBuscar.Controls.Add(Me.btnBuscarNumero)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarNumero)
        Me.gbBuscar.Controls.Add(Me.lblIDIncidencia)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(383, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(300, 263)
        Me.gbBuscar.TabIndex = 1
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarTipo
        '
        Me.btnBuscarTipo.BackColor = System.Drawing.Color.Green
        Me.btnBuscarTipo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarTipo.Location = New System.Drawing.Point(24, 207)
        Me.btnBuscarTipo.Name = "btnBuscarTipo"
        Me.btnBuscarTipo.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscarTipo.TabIndex = 5
        Me.btnBuscarTipo.Text = "Buscar"
        Me.btnBuscarTipo.UseVisualStyleBackColor = False
        '
        'txtbBuscarTipo
        '
        Me.txtbBuscarTipo.Location = New System.Drawing.Point(24, 176)
        Me.txtbBuscarTipo.Name = "txtbBuscarTipo"
        Me.txtbBuscarTipo.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarTipo.TabIndex = 4
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(21, 150)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(36, 16)
        Me.lblEstado.TabIndex = 10
        Me.lblEstado.Text = "Tipo"
        '
        'btnBuscarNumero
        '
        Me.btnBuscarNumero.BackColor = System.Drawing.Color.Green
        Me.btnBuscarNumero.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarNumero.Location = New System.Drawing.Point(24, 93)
        Me.btnBuscarNumero.Name = "btnBuscarNumero"
        Me.btnBuscarNumero.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscarNumero.TabIndex = 3
        Me.btnBuscarNumero.Text = "Buscar"
        Me.btnBuscarNumero.UseVisualStyleBackColor = False
        '
        'txtbBuscarNumero
        '
        Me.txtbBuscarNumero.Location = New System.Drawing.Point(24, 62)
        Me.txtbBuscarNumero.Name = "txtbBuscarNumero"
        Me.txtbBuscarNumero.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarNumero.TabIndex = 2
        '
        'lblIDIncidencia
        '
        Me.lblIDIncidencia.AutoSize = True
        Me.lblIDIncidencia.Location = New System.Drawing.Point(21, 36)
        Me.lblIDIncidencia.Name = "lblIDIncidencia"
        Me.lblIDIncidencia.Size = New System.Drawing.Size(140, 16)
        Me.lblIDIncidencia.TabIndex = 7
        Me.lblIDIncidencia.Text = "Número de habitación"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(549, 387)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(134, 51)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(219, 387)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(138, 51)
        Me.btnSiguiente.TabIndex = 7
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(12, 387)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(131, 51)
        Me.btnAnterior.TabIndex = 6
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvLimpieza
        '
        Me.dgvLimpieza.AllowUserToDeleteRows = False
        Me.dgvLimpieza.AutoGenerateColumns = False
        Me.dgvLimpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLimpieza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumHabitacionDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.NumCamasDataGridViewTextBoxColumn})
        Me.dgvLimpieza.DataSource = Me.HabitacionesBindingSource
        Me.dgvLimpieza.Location = New System.Drawing.Point(13, 19)
        Me.dgvLimpieza.Name = "dgvLimpieza"
        Me.dgvLimpieza.ReadOnly = True
        Me.dgvLimpieza.Size = New System.Drawing.Size(343, 358)
        Me.dgvLimpieza.TabIndex = 10
        '
        'NumHabitacionDataGridViewTextBoxColumn
        '
        Me.NumHabitacionDataGridViewTextBoxColumn.DataPropertyName = "NumHabitacion"
        Me.NumHabitacionDataGridViewTextBoxColumn.HeaderText = "NumHabitacion"
        Me.NumHabitacionDataGridViewTextBoxColumn.Name = "NumHabitacionDataGridViewTextBoxColumn"
        Me.NumHabitacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumCamasDataGridViewTextBoxColumn
        '
        Me.NumCamasDataGridViewTextBoxColumn.DataPropertyName = "NumCamas"
        Me.NumCamasDataGridViewTextBoxColumn.HeaderText = "NumCamas"
        Me.NumCamasDataGridViewTextBoxColumn.Name = "NumCamasDataGridViewTextBoxColumn"
        Me.NumCamasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.BdHotelDataSet11
        '
        'HabitacionesTableAdapter
        '
        Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnActualizar.Location = New System.Drawing.Point(383, 387)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(136, 50)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'FormLimpieza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 450)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvLimpieza)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Name = "FormLimpieza"
        Me.Text = "FormLimpieza"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLimpieza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarTipo As Button
    Friend WithEvents txtbBuscarTipo As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnBuscarNumero As Button
    Friend WithEvents txtbBuscarNumero As TextBox
    Friend WithEvents lblIDIncidencia As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents dgvLimpieza As DataGridView
    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents HabitacionesTableAdapter As BDHotelDataSet1TableAdapters.HabitacionesTableAdapter
    Friend WithEvents NumHabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumCamasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnActualizar As Button
End Class
