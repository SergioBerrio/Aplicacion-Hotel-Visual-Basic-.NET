<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDirector
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
        Me.dgvTrabajadores = New System.Windows.Forms.DataGridView()
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.TrabajadoresTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.TrabajadoresTableAdapter()
        Me.txtbIDTrabajdor = New System.Windows.Forms.TextBox()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.lblIDTrabajador = New System.Windows.Forms.Label()
        Me.lblTipoTrabajador = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbDatosTrabajadores = New System.Windows.Forms.GroupBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnDarAltaTrabajadores = New System.Windows.Forms.Button()
        Me.btnEliminarTrabajador = New System.Windows.Forms.Button()
        Me.gbBuscadorTrabajadores = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtbBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        CType(Me.dgvTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosTrabajadores.SuspendLayout()
        Me.gbBuscadorTrabajadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTrabajadores
        '
        Me.dgvTrabajadores.AutoGenerateColumns = False
        Me.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTrabajadorDataGridViewTextBoxColumn, Me.PuestoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvTrabajadores.DataSource = Me.TrabajadoresBindingSource
        Me.dgvTrabajadores.Location = New System.Drawing.Point(15, 16)
        Me.dgvTrabajadores.Name = "dgvTrabajadores"
        Me.dgvTrabajadores.Size = New System.Drawing.Size(345, 350)
        Me.dgvTrabajadores.TabIndex = 13
        '
        'IDTrabajadorDataGridViewTextBoxColumn
        '
        Me.IDTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.HeaderText = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.Name = "IDTrabajadorDataGridViewTextBoxColumn"
        '
        'PuestoDataGridViewTextBoxColumn
        '
        Me.PuestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.HeaderText = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.Name = "PuestoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'TrabajadoresBindingSource
        '
        Me.TrabajadoresBindingSource.DataMember = "Trabajadores"
        Me.TrabajadoresBindingSource.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrabajadoresTableAdapter
        '
        Me.TrabajadoresTableAdapter.ClearBeforeFill = True
        '
        'txtbIDTrabajdor
        '
        Me.txtbIDTrabajdor.Location = New System.Drawing.Point(31, 54)
        Me.txtbIDTrabajdor.Name = "txtbIDTrabajdor"
        Me.txtbIDTrabajdor.Size = New System.Drawing.Size(173, 22)
        Me.txtbIDTrabajdor.TabIndex = 2
        '
        'txtbNombre
        '
        Me.txtbNombre.Location = New System.Drawing.Point(31, 194)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(173, 22)
        Me.txtbNombre.TabIndex = 4
        '
        'cmbPuesto
        '
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Location = New System.Drawing.Point(31, 119)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(173, 24)
        Me.cmbPuesto.TabIndex = 3
        '
        'lblIDTrabajador
        '
        Me.lblIDTrabajador.AutoSize = True
        Me.lblIDTrabajador.Location = New System.Drawing.Point(31, 31)
        Me.lblIDTrabajador.Name = "lblIDTrabajador"
        Me.lblIDTrabajador.Size = New System.Drawing.Size(108, 16)
        Me.lblIDTrabajador.TabIndex = 4
        Me.lblIDTrabajador.Text = "ID del trabajador"
        '
        'lblTipoTrabajador
        '
        Me.lblTipoTrabajador.AutoSize = True
        Me.lblTipoTrabajador.Location = New System.Drawing.Point(31, 89)
        Me.lblTipoTrabajador.Name = "lblTipoTrabajador"
        Me.lblTipoTrabajador.Size = New System.Drawing.Size(134, 16)
        Me.lblTipoTrabajador.TabIndex = 5
        Me.lblTipoTrabajador.Text = "Puesto de trabajador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(31, 158)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre"
        '
        'gbDatosTrabajadores
        '
        Me.gbDatosTrabajadores.Controls.Add(Me.lblNombre)
        Me.gbDatosTrabajadores.Controls.Add(Me.lblTipoTrabajador)
        Me.gbDatosTrabajadores.Controls.Add(Me.lblIDTrabajador)
        Me.gbDatosTrabajadores.Controls.Add(Me.cmbPuesto)
        Me.gbDatosTrabajadores.Controls.Add(Me.txtbNombre)
        Me.gbDatosTrabajadores.Controls.Add(Me.txtbIDTrabajdor)
        Me.gbDatosTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosTrabajadores.Location = New System.Drawing.Point(386, 16)
        Me.gbDatosTrabajadores.Name = "gbDatosTrabajadores"
        Me.gbDatosTrabajadores.Size = New System.Drawing.Size(237, 244)
        Me.gbDatosTrabajadores.TabIndex = 1
        Me.gbDatosTrabajadores.TabStop = False
        Me.gbDatosTrabajadores.Text = "Datos de los trabajadores"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(655, 367)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(133, 71)
        Me.btnAtras.TabIndex = 10
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnDarAltaTrabajadores
        '
        Me.btnDarAltaTrabajadores.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDarAltaTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarAltaTrabajadores.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDarAltaTrabajadores.Location = New System.Drawing.Point(655, 19)
        Me.btnDarAltaTrabajadores.Name = "btnDarAltaTrabajadores"
        Me.btnDarAltaTrabajadores.Size = New System.Drawing.Size(133, 73)
        Me.btnDarAltaTrabajadores.TabIndex = 8
        Me.btnDarAltaTrabajadores.Text = "Dar de alta a un trabajador"
        Me.btnDarAltaTrabajadores.UseVisualStyleBackColor = False
        '
        'btnEliminarTrabajador
        '
        Me.btnEliminarTrabajador.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTrabajador.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarTrabajador.Location = New System.Drawing.Point(655, 174)
        Me.btnEliminarTrabajador.Name = "btnEliminarTrabajador"
        Me.btnEliminarTrabajador.Size = New System.Drawing.Size(133, 86)
        Me.btnEliminarTrabajador.TabIndex = 9
        Me.btnEliminarTrabajador.Text = "Eliminar trabajador"
        Me.btnEliminarTrabajador.UseVisualStyleBackColor = False
        '
        'gbBuscadorTrabajadores
        '
        Me.gbBuscadorTrabajadores.Controls.Add(Me.btnBuscar)
        Me.gbBuscadorTrabajadores.Controls.Add(Me.txtbBuscar)
        Me.gbBuscadorTrabajadores.Controls.Add(Me.lblBuscar)
        Me.gbBuscadorTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscadorTrabajadores.Location = New System.Drawing.Point(389, 282)
        Me.gbBuscadorTrabajadores.Name = "gbBuscadorTrabajadores"
        Me.gbBuscadorTrabajadores.Size = New System.Drawing.Size(234, 155)
        Me.gbBuscadorTrabajadores.TabIndex = 5
        Me.gbBuscadorTrabajadores.TabStop = False
        Me.gbBuscadorTrabajadores.Text = "Buscador"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Green
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Location = New System.Drawing.Point(25, 85)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(176, 33)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtbBuscar
        '
        Me.txtbBuscar.Location = New System.Drawing.Point(25, 54)
        Me.txtbBuscar.Name = "txtbBuscar"
        Me.txtbBuscar.Size = New System.Drawing.Size(176, 22)
        Me.txtbBuscar.TabIndex = 6
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(22, 28)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(81, 16)
        Me.lblBuscar.TabIndex = 8
        Me.lblBuscar.Text = "Identificador"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(229, 386)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(131, 51)
        Me.btnSiguiente.TabIndex = 12
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(15, 386)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(131, 51)
        Me.btnAnterior.TabIndex = 11
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'FormDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.gbBuscadorTrabajadores)
        Me.Controls.Add(Me.btnEliminarTrabajador)
        Me.Controls.Add(Me.btnDarAltaTrabajadores)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.gbDatosTrabajadores)
        Me.Controls.Add(Me.dgvTrabajadores)
        Me.Name = "FormDirector"
        Me.Text = "FormDirector"
        CType(Me.dgvTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosTrabajadores.ResumeLayout(False)
        Me.gbDatosTrabajadores.PerformLayout()
        Me.gbBuscadorTrabajadores.ResumeLayout(False)
        Me.gbBuscadorTrabajadores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTrabajadores As DataGridView
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents TrabajadoresBindingSource As BindingSource
    Friend WithEvents TrabajadoresTableAdapter As BDHotelDataSet1TableAdapters.TrabajadoresTableAdapter
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtbIDTrabajdor As TextBox
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents cmbPuesto As ComboBox
    Friend WithEvents lblIDTrabajador As Label
    Friend WithEvents lblTipoTrabajador As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents gbDatosTrabajadores As GroupBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnDarAltaTrabajadores As Button
    Friend WithEvents btnEliminarTrabajador As Button
    Friend WithEvents gbBuscadorTrabajadores As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtbBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
End Class
