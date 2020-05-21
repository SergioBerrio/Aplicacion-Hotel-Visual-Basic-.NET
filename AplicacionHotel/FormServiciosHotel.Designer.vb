<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormServiciosHotel
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
        Me.dgvServicios = New System.Windows.Forms.DataGridView()
        Me.IDServiciosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.ServiciosTableAdapter = New AplicacionHotel.BDHotelDataSet1TableAdapters.ServiciosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbIDServicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.btnEliminarServicio = New System.Windows.Forms.Button()
        Me.btnAgregarServicio = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtbBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvServicios
        '
        Me.dgvServicios.AutoGenerateColumns = False
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDServiciosDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvServicios.DataSource = Me.ServiciosBindingSource
        Me.dgvServicios.Location = New System.Drawing.Point(16, 18)
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.Size = New System.Drawing.Size(243, 351)
        Me.dgvServicios.TabIndex = 0
        '
        'IDServiciosDataGridViewTextBoxColumn
        '
        Me.IDServiciosDataGridViewTextBoxColumn.DataPropertyName = "IDServicios"
        Me.IDServiciosDataGridViewTextBoxColumn.HeaderText = "IDServicios"
        Me.IDServiciosDataGridViewTextBoxColumn.Name = "IDServiciosDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbIDServicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(291, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 224)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de las actividades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID de servicio"
        '
        'txtbIDServicio
        '
        Me.txtbIDServicio.Location = New System.Drawing.Point(21, 81)
        Me.txtbIDServicio.Name = "txtbIDServicio"
        Me.txtbIDServicio.Size = New System.Drawing.Size(254, 22)
        Me.txtbIDServicio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'cmbNombre
        '
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(20, 168)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(255, 24)
        Me.cmbNombre.TabIndex = 3
        '
        'btnEliminarServicio
        '
        Me.btnEliminarServicio.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarServicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarServicio.Location = New System.Drawing.Point(629, 162)
        Me.btnEliminarServicio.Name = "btnEliminarServicio"
        Me.btnEliminarServicio.Size = New System.Drawing.Size(159, 80)
        Me.btnEliminarServicio.TabIndex = 8
        Me.btnEliminarServicio.Text = "Eliminar servicio"
        Me.btnEliminarServicio.UseVisualStyleBackColor = False
        '
        'btnAgregarServicio
        '
        Me.btnAgregarServicio.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarServicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarServicio.Location = New System.Drawing.Point(629, 18)
        Me.btnAgregarServicio.Name = "btnAgregarServicio"
        Me.btnAgregarServicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAgregarServicio.Size = New System.Drawing.Size(159, 79)
        Me.btnAgregarServicio.TabIndex = 7
        Me.btnAgregarServicio.Text = "Agregar servicio"
        Me.btnAgregarServicio.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(629, 367)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(159, 70)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscar)
        Me.gbBuscar.Controls.Add(Me.txtbBuscar)
        Me.gbBuscar.Controls.Add(Me.lblBuscar)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(291, 266)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(301, 172)
        Me.gbBuscar.TabIndex = 4
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(20, 111)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtbBuscar
        '
        Me.txtbBuscar.Location = New System.Drawing.Point(20, 69)
        Me.txtbBuscar.Name = "txtbBuscar"
        Me.txtbBuscar.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscar.TabIndex = 5
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(17, 39)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(81, 16)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Identificador"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(168, 377)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(91, 61)
        Me.btnSiguiente.TabIndex = 11
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(16, 377)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(90, 61)
        Me.btnAnterior.TabIndex = 10
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'FormServiciosHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminarServicio)
        Me.Controls.Add(Me.btnAgregarServicio)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvServicios)
        Me.Name = "FormServiciosHotel"
        Me.Text = "FormServiciosHotel"
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvServicios As DataGridView
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BDHotelDataSet1TableAdapters.ServiciosTableAdapter
    Friend WithEvents IDServiciosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbIDServicio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents btnEliminarServicio As Button
    Friend WithEvents btnAgregarServicio As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtbBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
End Class
