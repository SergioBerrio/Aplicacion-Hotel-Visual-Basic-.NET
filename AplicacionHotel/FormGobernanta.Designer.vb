<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGobernanta
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
        Me.dgvLimpieza = New System.Windows.Forms.DataGridView()
        Me.IDTrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPuesto = New System.Windows.Forms.Button()
        Me.txtbBuscarPuesto = New System.Windows.Forms.TextBox()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.TrabajadoresTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.TrabajadoresTableAdapter()
        CType(Me.dgvLimpieza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLimpieza
        '
        Me.dgvLimpieza.AllowUserToDeleteRows = False
        Me.dgvLimpieza.AutoGenerateColumns = False
        Me.dgvLimpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLimpieza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTrabajadorDataGridViewTextBoxColumn, Me.PuestoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvLimpieza.DataSource = Me.TrabajadoresBindingSource
        Me.dgvLimpieza.Location = New System.Drawing.Point(12, 12)
        Me.dgvLimpieza.Name = "dgvLimpieza"
        Me.dgvLimpieza.ReadOnly = True
        Me.dgvLimpieza.Size = New System.Drawing.Size(343, 358)
        Me.dgvLimpieza.TabIndex = 7
        '
        'IDTrabajadorDataGridViewTextBoxColumn
        '
        Me.IDTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.HeaderText = "IDTrabajador"
        Me.IDTrabajadorDataGridViewTextBoxColumn.Name = "IDTrabajadorDataGridViewTextBoxColumn"
        Me.IDTrabajadorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PuestoDataGridViewTextBoxColumn
        '
        Me.PuestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.HeaderText = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.Name = "PuestoDataGridViewTextBoxColumn"
        Me.PuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
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
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarPuesto)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarPuesto)
        Me.gbBuscar.Controls.Add(Me.lblPuesto)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(385, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(289, 157)
        Me.gbBuscar.TabIndex = 1
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarPuesto
        '
        Me.btnBuscarPuesto.BackColor = System.Drawing.Color.Green
        Me.btnBuscarPuesto.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarPuesto.Location = New System.Drawing.Point(24, 91)
        Me.btnBuscarPuesto.Name = "btnBuscarPuesto"
        Me.btnBuscarPuesto.Size = New System.Drawing.Size(243, 33)
        Me.btnBuscarPuesto.TabIndex = 3
        Me.btnBuscarPuesto.Text = "Buscar"
        Me.btnBuscarPuesto.UseVisualStyleBackColor = False
        '
        'txtbBuscarPuesto
        '
        Me.txtbBuscarPuesto.Location = New System.Drawing.Point(24, 60)
        Me.txtbBuscarPuesto.Name = "txtbBuscarPuesto"
        Me.txtbBuscarPuesto.Size = New System.Drawing.Size(243, 22)
        Me.txtbBuscarPuesto.TabIndex = 2
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Location = New System.Drawing.Point(21, 34)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(50, 16)
        Me.lblPuesto.TabIndex = 10
        Me.lblPuesto.Text = "Puesto"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(521, 380)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(153, 51)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(218, 380)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(138, 51)
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(11, 380)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(131, 51)
        Me.btnAnterior.TabIndex = 4
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'TrabajadoresTableAdapter
        '
        Me.TrabajadoresTableAdapter.ClearBeforeFill = True
        '
        'FormGobernanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 450)
        Me.Controls.Add(Me.dgvLimpieza)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Name = "FormGobernanta"
        Me.Text = "FormGobernanta"
        CType(Me.dgvLimpieza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLimpieza As DataGridView
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarPuesto As Button
    Friend WithEvents txtbBuscarPuesto As TextBox
    Friend WithEvents lblPuesto As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents TrabajadoresBindingSource As BindingSource
    Friend WithEvents TrabajadoresTableAdapter As BDHotelDataSet1TableAdapters.TrabajadoresTableAdapter
    Friend WithEvents IDTrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
