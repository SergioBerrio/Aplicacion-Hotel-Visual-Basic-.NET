<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerClientes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.ClientesTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.ClientesTableAdapter()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnCrearClientes = New System.Windows.Forms.Button()
        Me.btnEliminarClientes = New System.Windows.Forms.Button()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscarNombre = New System.Windows.Forms.Button()
        Me.txtbBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarDNI = New System.Windows.Forms.Button()
        Me.txtbBuscarDNI = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNIDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.ClientesBindingSource
        Me.dgvClientes.Location = New System.Drawing.Point(13, 19)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(544, 340)
        Me.dgvClientes.TabIndex = 0
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(16, 386)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(183, 51)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(374, 386)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(183, 51)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(580, 386)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(323, 51)
        Me.btnAtras.TabIndex = 3
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnCrearClientes
        '
        Me.btnCrearClientes.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCrearClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearClientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCrearClientes.Location = New System.Drawing.Point(576, 19)
        Me.btnCrearClientes.Name = "btnCrearClientes"
        Me.btnCrearClientes.Size = New System.Drawing.Size(137, 51)
        Me.btnCrearClientes.TabIndex = 4
        Me.btnCrearClientes.Text = "Crear clientes"
        Me.btnCrearClientes.UseVisualStyleBackColor = False
        '
        'btnEliminarClientes
        '
        Me.btnEliminarClientes.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarClientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarClientes.Location = New System.Drawing.Point(768, 19)
        Me.btnEliminarClientes.Name = "btnEliminarClientes"
        Me.btnEliminarClientes.Size = New System.Drawing.Size(135, 51)
        Me.btnEliminarClientes.TabIndex = 5
        Me.btnEliminarClientes.Text = "Eliminar clientes"
        Me.btnEliminarClientes.UseVisualStyleBackColor = False
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarNombre)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarNombre)
        Me.gbBuscar.Controls.Add(Me.Label1)
        Me.gbBuscar.Controls.Add(Me.btnBuscarDNI)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarDNI)
        Me.gbBuscar.Controls.Add(Me.lblBuscar)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(580, 96)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(322, 263)
        Me.gbBuscar.TabIndex = 6
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarNombre
        '
        Me.btnBuscarNombre.BackColor = System.Drawing.Color.Green
        Me.btnBuscarNombre.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarNombre.Location = New System.Drawing.Point(24, 207)
        Me.btnBuscarNombre.Name = "btnBuscarNombre"
        Me.btnBuscarNombre.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscarNombre.TabIndex = 12
        Me.btnBuscarNombre.Text = "Buscar"
        Me.btnBuscarNombre.UseVisualStyleBackColor = False
        '
        'txtbBuscarNombre
        '
        Me.txtbBuscarNombre.Location = New System.Drawing.Point(24, 176)
        Me.txtbBuscarNombre.Name = "txtbBuscarNombre"
        Me.txtbBuscarNombre.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarNombre.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre"
        '
        'btnBuscarDNI
        '
        Me.btnBuscarDNI.BackColor = System.Drawing.Color.Green
        Me.btnBuscarDNI.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarDNI.Location = New System.Drawing.Point(24, 93)
        Me.btnBuscarDNI.Name = "btnBuscarDNI"
        Me.btnBuscarDNI.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscarDNI.TabIndex = 9
        Me.btnBuscarDNI.Text = "Buscar"
        Me.btnBuscarDNI.UseVisualStyleBackColor = False
        '
        'txtbBuscarDNI
        '
        Me.txtbBuscarDNI.Location = New System.Drawing.Point(24, 62)
        Me.txtbBuscarDNI.Name = "txtbBuscarDNI"
        Me.txtbBuscarDNI.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarDNI.TabIndex = 8
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(21, 36)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(31, 16)
        Me.lblBuscar.TabIndex = 7
        Me.lblBuscar.Text = "DNI"
        '
        'FormVerClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 450)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnEliminarClientes)
        Me.Controls.Add(Me.btnCrearClientes)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "FormVerClientes"
        Me.Text = "FormVerClientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BDHotelDataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnCrearClientes As Button
    Friend WithEvents btnEliminarClientes As Button
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarNombre As Button
    Friend WithEvents txtbBuscarNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarDNI As Button
    Friend WithEvents txtbBuscarDNI As TextBox
    Friend WithEvents lblBuscar As Label
End Class
