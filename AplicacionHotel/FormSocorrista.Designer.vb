<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSocorrista
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
        Me.btnBuscarNombre = New System.Windows.Forms.Button()
        Me.txtbBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarDNI = New System.Windows.Forms.Button()
        Me.txtbBuscarDNI = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.dgvSocorrista = New System.Windows.Forms.DataGridView()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.ClientesTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.ClientesTableAdapter()
        Me.gbBuscar.SuspendLayout()
        CType(Me.dgvSocorrista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gbBuscar.Location = New System.Drawing.Point(579, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(322, 263)
        Me.gbBuscar.TabIndex = 1
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
        Me.btnBuscarNombre.TabIndex = 5
        Me.btnBuscarNombre.Text = "Buscar"
        Me.btnBuscarNombre.UseVisualStyleBackColor = False
        '
        'txtbBuscarNombre
        '
        Me.txtbBuscarNombre.Location = New System.Drawing.Point(24, 176)
        Me.txtbBuscarNombre.Name = "txtbBuscarNombre"
        Me.txtbBuscarNombre.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarNombre.TabIndex = 4
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
        Me.btnBuscarDNI.TabIndex = 3
        Me.btnBuscarDNI.Text = "Buscar"
        Me.btnBuscarDNI.UseVisualStyleBackColor = False
        '
        'txtbBuscarDNI
        '
        Me.txtbBuscarDNI.Location = New System.Drawing.Point(24, 62)
        Me.txtbBuscarDNI.Name = "txtbBuscarDNI"
        Me.txtbBuscarDNI.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarDNI.TabIndex = 2
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
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(579, 379)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(323, 51)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(373, 379)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(183, 51)
        Me.btnSiguiente.TabIndex = 7
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(15, 379)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(183, 51)
        Me.btnAnterior.TabIndex = 6
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'dgvSocorrista
        '
        Me.dgvSocorrista.AllowUserToDeleteRows = False
        Me.dgvSocorrista.AutoGenerateColumns = False
        Me.dgvSocorrista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSocorrista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNIDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.dgvSocorrista.DataSource = Me.ClientesBindingSource
        Me.dgvSocorrista.Location = New System.Drawing.Point(12, 12)
        Me.dgvSocorrista.Name = "dgvSocorrista"
        Me.dgvSocorrista.ReadOnly = True
        Me.dgvSocorrista.Size = New System.Drawing.Size(544, 340)
        Me.dgvSocorrista.TabIndex = 14
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
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
        'FormSocorrista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.dgvSocorrista)
        Me.Name = "FormSocorrista"
        Me.Text = " FormularioSocorrista"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.dgvSocorrista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarNombre As Button
    Friend WithEvents txtbBuscarNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarDNI As Button
    Friend WithEvents txtbBuscarDNI As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents dgvSocorrista As DataGridView
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BDHotelDataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
