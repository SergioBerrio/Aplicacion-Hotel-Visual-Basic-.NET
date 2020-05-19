<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDarAltaTrabajadores
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
        Me.lblIDTrabajkador = New System.Windows.Forms.Label()
        Me.lblTipoTrabajador = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtbIDTrabajador = New System.Windows.Forms.TextBox()
        Me.txtbNombre = New System.Windows.Forms.TextBox()
        Me.cmbTipoTrabajador = New System.Windows.Forms.ComboBox()
        Me.dgvDarAltaTrabajadores = New System.Windows.Forms.DataGridView()
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTipoTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajadoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet1 = New AplicacionHotel.BDHotelDataSet()
        Me.TrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajadoresTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.TrabajadoresTableAdapter()
        Me.FacturasTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.FacturasTableAdapter()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDarAltaTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDarAltaTrabajador
        '
        Me.btnDarAltaTrabajador.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDarAltaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarAltaTrabajador.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDarAltaTrabajador.Location = New System.Drawing.Point(642, 12)
        Me.btnDarAltaTrabajador.Name = "btnDarAltaTrabajador"
        Me.btnDarAltaTrabajador.Size = New System.Drawing.Size(135, 74)
        Me.btnDarAltaTrabajador.TabIndex = 4
        Me.btnDarAltaTrabajador.Text = "Dar de alta un trabajador"
        Me.btnDarAltaTrabajador.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(642, 328)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(135, 74)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnEliminarTrabajador
        '
        Me.btnEliminarTrabajador.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTrabajador.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarTrabajador.Location = New System.Drawing.Point(642, 124)
        Me.btnEliminarTrabajador.Name = "btnEliminarTrabajador"
        Me.btnEliminarTrabajador.Size = New System.Drawing.Size(135, 74)
        Me.btnEliminarTrabajador.TabIndex = 5
        Me.btnEliminarTrabajador.Text = "Eliminar trabajador"
        Me.btnEliminarTrabajador.UseVisualStyleBackColor = False
        '
        'lblIDTrabajkador
        '
        Me.lblIDTrabajkador.AutoSize = True
        Me.lblIDTrabajkador.Location = New System.Drawing.Point(26, 22)
        Me.lblIDTrabajkador.Name = "lblIDTrabajkador"
        Me.lblIDTrabajkador.Size = New System.Drawing.Size(85, 13)
        Me.lblIDTrabajkador.TabIndex = 5
        Me.lblIDTrabajkador.Text = "ID del trabajador"
        '
        'lblTipoTrabajador
        '
        Me.lblTipoTrabajador.AutoSize = True
        Me.lblTipoTrabajador.Location = New System.Drawing.Point(26, 94)
        Me.lblTipoTrabajador.Name = "lblTipoTrabajador"
        Me.lblTipoTrabajador.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoTrabajador.TabIndex = 6
        Me.lblTipoTrabajador.Text = "Tipo de trabajador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(26, 173)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre"
        '
        'txtbIDTrabajador
        '
        Me.txtbIDTrabajador.Enabled = False
        Me.txtbIDTrabajador.Location = New System.Drawing.Point(29, 50)
        Me.txtbIDTrabajador.Name = "txtbIDTrabajador"
        Me.txtbIDTrabajador.Size = New System.Drawing.Size(133, 20)
        Me.txtbIDTrabajador.TabIndex = 1
        '
        'txtbNombre
        '
        Me.txtbNombre.Location = New System.Drawing.Point(29, 201)
        Me.txtbNombre.Name = "txtbNombre"
        Me.txtbNombre.Size = New System.Drawing.Size(133, 20)
        Me.txtbNombre.TabIndex = 3
        '
        'cmbTipoTrabajador
        '
        Me.cmbTipoTrabajador.FormattingEnabled = True
        Me.cmbTipoTrabajador.Location = New System.Drawing.Point(29, 126)
        Me.cmbTipoTrabajador.Name = "cmbTipoTrabajador"
        Me.cmbTipoTrabajador.Size = New System.Drawing.Size(129, 21)
        Me.cmbTipoTrabajador.TabIndex = 2
        '
        'dgvDarAltaTrabajadores
        '
        Me.dgvDarAltaTrabajadores.AllowUserToDeleteRows = False
        Me.dgvDarAltaTrabajadores.AutoGenerateColumns = False
        Me.dgvDarAltaTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDarAltaTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTrabajadorDataGridViewTextBoxColumn, Me.IDTipoTrabajadorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvDarAltaTrabajadores.DataSource = Me.TrabajadoresBindingSource1
        Me.dgvDarAltaTrabajadores.Location = New System.Drawing.Point(12, 12)
        Me.dgvDarAltaTrabajadores.Name = "dgvDarAltaTrabajadores"
        Me.dgvDarAltaTrabajadores.ReadOnly = True
        Me.dgvDarAltaTrabajadores.Size = New System.Drawing.Size(344, 393)
        Me.dgvDarAltaTrabajadores.TabIndex = 8
        '
        'IDTrabajadorDataGridViewTextBoxColumn
        '
        Me.IDTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.HeaderText = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.Name = "IDTrabajadorDataGridViewTextBoxColumn"
        Me.IDTrabajadorDataGridViewTextBoxColumn.ReadOnly = True
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
        'TrabajadoresBindingSource1
        '
        Me.TrabajadoresBindingSource1.DataMember = "Trabajadores"
        Me.TrabajadoresBindingSource1.DataSource = Me.BdHotelDataSet1
        '
        'BdHotelDataSet1
        '
        Me.BdHotelDataSet1.DataSetName = "BDHotelDataSet"
        Me.BdHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrabajadoresTableAdapter
        '
        Me.TrabajadoresTableAdapter.ClearBeforeFill = True
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.cmbTipoTrabajador)
        Me.gb1.Controls.Add(Me.txtbNombre)
        Me.gb1.Controls.Add(Me.txtbIDTrabajador)
        Me.gb1.Controls.Add(Me.lblNombre)
        Me.gb1.Controls.Add(Me.lblTipoTrabajador)
        Me.gb1.Controls.Add(Me.lblIDTrabajkador)
        Me.gb1.Location = New System.Drawing.Point(394, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(204, 246)
        Me.gb1.TabIndex = 9
        Me.gb1.TabStop = False
        Me.gb1.Text = "Datos del trabajador"
        '
        'FormDarAltaTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 414)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgvDarAltaTrabajadores)
        Me.Controls.Add(Me.btnEliminarTrabajador)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnDarAltaTrabajador)
        Me.Name = "FormDarAltaTrabajadores"
        Me.Text = "FormDarAltaTrabajadores"
        CType(Me.dgvDarAltaTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDarAltaTrabajador As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEliminarTrabajador As Button
    Friend WithEvents lblIDTrabajkador As Label
    Friend WithEvents lblTipoTrabajador As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtbIDTrabajador As TextBox
    Friend WithEvents txtbNombre As TextBox
    Friend WithEvents cmbTipoTrabajador As ComboBox
    Friend WithEvents dgvDarAltaTrabajadores As DataGridView
    Friend WithEvents IDTrabajadoresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents TrabajadoresBindingSource As BindingSource
    Friend WithEvents BdHotelDataSet1 As BDHotelDataSet
    Friend WithEvents TrabajadoresBindingSource1 As BindingSource
    Friend WithEvents TrabajadoresTableAdapter As BDHotelDataSetTableAdapters.TrabajadoresTableAdapter
    Friend WithEvents FacturasTableAdapter As BDHotelDataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTipoTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
