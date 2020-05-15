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
        Me.btnDarAltaTrabajador = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnEliminarTrabajador = New System.Windows.Forms.Button()
        Me.TrabajadoresFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblIDTrabajkador = New System.Windows.Forms.Label()
        Me.lblTipoTrabajador = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtbIDTrabajador = New System.Windows.Forms.TextBox()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.cmbTipoTrabajador = New System.Windows.Forms.ComboBox()
        Me.dgvDarAltaTrabajadores = New System.Windows.Forms.DataGridView()
        Me.IDTrabajadoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTipoTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajadoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New AplicacionHotel.BDHotelDataSet()
        Me.TrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajadoresTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.TrabajadoresTableAdapter()
        Me.TrabajadoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajadoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.FacturasTableAdapter()
        CType(Me.TrabajadoresFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDarAltaTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDarAltaTrabajador
        '
        Me.btnDarAltaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarAltaTrabajador.Location = New System.Drawing.Point(614, 30)
        Me.btnDarAltaTrabajador.Name = "btnDarAltaTrabajador"
        Me.btnDarAltaTrabajador.Size = New System.Drawing.Size(135, 74)
        Me.btnDarAltaTrabajador.TabIndex = 4
        Me.btnDarAltaTrabajador.Text = "Dar de alta un trabajador"
        Me.btnDarAltaTrabajador.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(614, 328)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(135, 74)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnEliminarTrabajador
        '
        Me.btnEliminarTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTrabajador.Location = New System.Drawing.Point(614, 155)
        Me.btnEliminarTrabajador.Name = "btnEliminarTrabajador"
        Me.btnEliminarTrabajador.Size = New System.Drawing.Size(135, 74)
        Me.btnEliminarTrabajador.TabIndex = 5
        Me.btnEliminarTrabajador.Text = "Eliminar trabajador"
        Me.btnEliminarTrabajador.UseVisualStyleBackColor = True
        '
        'TrabajadoresFacturasBindingSource
        '
        Me.TrabajadoresFacturasBindingSource.DataMember = "TrabajadoresFacturas"
        Me.TrabajadoresFacturasBindingSource.DataSource = Me.TrabajadoresBindingSource
        '
        'lblIDTrabajkador
        '
        Me.lblIDTrabajkador.AutoSize = True
        Me.lblIDTrabajkador.Location = New System.Drawing.Point(402, 30)
        Me.lblIDTrabajkador.Name = "lblIDTrabajkador"
        Me.lblIDTrabajkador.Size = New System.Drawing.Size(85, 13)
        Me.lblIDTrabajkador.TabIndex = 5
        Me.lblIDTrabajkador.Text = "ID del trabajador"
        '
        'lblTipoTrabajador
        '
        Me.lblTipoTrabajador.AutoSize = True
        Me.lblTipoTrabajador.Location = New System.Drawing.Point(402, 102)
        Me.lblTipoTrabajador.Name = "lblTipoTrabajador"
        Me.lblTipoTrabajador.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoTrabajador.TabIndex = 6
        Me.lblTipoTrabajador.Text = "Tipo de trabajador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(402, 181)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre"
        '
        'txtbIDTrabajador
        '
        Me.txtbIDTrabajador.Location = New System.Drawing.Point(405, 58)
        Me.txtbIDTrabajador.Name = "txtbIDTrabajador"
        Me.txtbIDTrabajador.Size = New System.Drawing.Size(133, 20)
        Me.txtbIDTrabajador.TabIndex = 1
        '
        'txtbNombre
        '
        Me.txtbNombre.Location = New System.Drawing.Point(405, 209)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(133, 20)
        Me.txtbNombre.TabIndex = 3
        '
        'cmbTipoTrabajador
        '
        Me.cmbTipoTrabajador.FormattingEnabled = True
        Me.cmbTipoTrabajador.Location = New System.Drawing.Point(405, 134)
        Me.cmbTipoTrabajador.Name = "cmbTipoTrabajador"
        Me.cmbTipoTrabajador.Size = New System.Drawing.Size(129, 21)
        Me.cmbTipoTrabajador.TabIndex = 2
        '
        'dgvDarAltaTrabajadores
        '
        Me.dgvDarAltaTrabajadores.AllowUserToDeleteRows = False
        Me.dgvDarAltaTrabajadores.AutoGenerateColumns = False
        Me.dgvDarAltaTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDarAltaTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTrabajadoresDataGridViewTextBoxColumn, Me.IDTipoTrabajadorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvDarAltaTrabajadores.DataSource = Me.TrabajadoresBindingSource3
        Me.dgvDarAltaTrabajadores.Location = New System.Drawing.Point(12, 17)
        Me.dgvDarAltaTrabajadores.Name = "dgvDarAltaTrabajadores"
        Me.dgvDarAltaTrabajadores.ReadOnly = True
        Me.dgvDarAltaTrabajadores.Size = New System.Drawing.Size(344, 388)
        Me.dgvDarAltaTrabajadores.TabIndex = 8
        '
        'IDTrabajadoresDataGridViewTextBoxColumn
        '
        Me.IDTrabajadoresDataGridViewTextBoxColumn.DataPropertyName = "IDTrabajadores"
        Me.IDTrabajadoresDataGridViewTextBoxColumn.HeaderText = "IDTrabajadores"
        Me.IDTrabajadoresDataGridViewTextBoxColumn.Name = "IDTrabajadoresDataGridViewTextBoxColumn"
        Me.IDTrabajadoresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDTipoTrabajadorDataGridViewTextBoxColumn
        '
        Me.IDTipoTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IDTipoTrabajador"
        Me.IDTipoTrabajadorDataGridViewTextBoxColumn.HeaderText = "IDTipoTrabajador"
        Me.IDTipoTrabajadorDataGridViewTextBoxColumn.Name = "IDTipoTrabajadorDataGridViewTextBoxColumn"
        Me.IDTipoTrabajadorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrabajadoresBindingSource3
        '
        Me.TrabajadoresBindingSource3.DataMember = "Trabajadores"
        Me.TrabajadoresBindingSource3.DataSource = Me.BDHotelDataSet
        '
        'BDHotelDataSet
        '
        Me.BDHotelDataSet.DataSetName = "BDHotelDataSet"
        Me.BDHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrabajadoresBindingSource
        '
        Me.TrabajadoresBindingSource.DataMember = "Trabajadores"
        Me.TrabajadoresBindingSource.DataSource = Me.BDHotelDataSet
        '
        'TrabajadoresTableAdapter
        '
        Me.TrabajadoresTableAdapter.ClearBeforeFill = True
        '
        'TrabajadoresBindingSource1
        '
        Me.TrabajadoresBindingSource1.DataMember = "Trabajadores"
        Me.TrabajadoresBindingSource1.DataSource = Me.BDHotelDataSet
        '
        'TrabajadoresBindingSource2
        '
        Me.TrabajadoresBindingSource2.DataMember = "Trabajadores"
        Me.TrabajadoresBindingSource2.DataSource = Me.BDHotelDataSet
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'FormDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 414)
        Me.Controls.Add(Me.dgvDarAltaTrabajadores)
        Me.Controls.Add(Me.cmbTipoTrabajador)
        Me.Controls.Add(Me.txtbNombre)
        Me.Controls.Add(Me.txtbIDTrabajador)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTipoTrabajador)
        Me.Controls.Add(Me.lblIDTrabajkador)
        Me.Controls.Add(Me.btnEliminarTrabajador)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnDarAltaTrabajador)
        Me.Name = "FormDirector"
        Me.Text = "FormDirector"
        CType(Me.TrabajadoresFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDarAltaTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDarAltaTrabajador As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEliminarTrabajador As Button
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents TrabajadoresBindingSource As BindingSource
    Friend WithEvents TrabajadoresTableAdapter As BDHotelDataSetTableAdapters.TrabajadoresTableAdapter
    Friend WithEvents TrabajadoresBindingSource1 As BindingSource
    Friend WithEvents TrabajadoresBindingSource2 As BindingSource
    Friend WithEvents TrabajadoresFacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As BDHotelDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents TrabajadoresBindingSource3 As BindingSource
    Friend WithEvents lblIDTrabajkador As Label
    Friend WithEvents lblTipoTrabajador As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtbIDTrabajador As TextBox
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents cmbTipoTrabajador As ComboBox
    Friend WithEvents dgvDarAltaTrabajadores As DataGridView
    Friend WithEvents IDTrabajadoresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTipoTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
