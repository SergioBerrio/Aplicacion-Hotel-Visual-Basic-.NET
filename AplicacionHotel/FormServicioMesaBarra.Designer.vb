<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormServicioMesaBarra
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
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.cmbNombreServicio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbIDServicio = New System.Windows.Forms.TextBox()
        Me.lblIDTrabajkador = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.IDServiciosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New AplicacionHotel.BDHotelDataSet()
        Me.btnEliminarActividad = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btngregarServicio = New System.Windows.Forms.Button()
        Me.ServiciosTableAdapter = New AplicacionHotel.BDHotelDataSetTableAdapters.ServiciosTableAdapter()
        Me.gb1.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.cmbNombreServicio)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.txtbIDServicio)
        Me.gb1.Controls.Add(Me.lblIDTrabajkador)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(299, 19)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(275, 179)
        Me.gb1.TabIndex = 1
        Me.gb1.TabStop = False
        Me.gb1.Text = "Datos de actividad"
        '
        'cmbNombreServicio
        '
        Me.cmbNombreServicio.FormattingEnabled = True
        Me.cmbNombreServicio.Location = New System.Drawing.Point(37, 131)
        Me.cmbNombreServicio.Name = "cmbNombreServicio"
        Me.cmbNombreServicio.Size = New System.Drawing.Size(130, 24)
        Me.cmbNombreServicio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre del servicio"
        '
        'txtbIDServicio
        '
        Me.txtbIDServicio.Enabled = False
        Me.txtbIDServicio.Location = New System.Drawing.Point(35, 61)
        Me.txtbIDServicio.Name = "txtbIDServicio"
        Me.txtbIDServicio.Size = New System.Drawing.Size(133, 22)
        Me.txtbIDServicio.TabIndex = 1
        '
        'lblIDTrabajkador
        '
        Me.lblIDTrabajkador.AutoSize = True
        Me.lblIDTrabajkador.Location = New System.Drawing.Point(32, 33)
        Me.lblIDTrabajkador.Name = "lblIDTrabajkador"
        Me.lblIDTrabajkador.Size = New System.Drawing.Size(93, 16)
        Me.lblIDTrabajkador.TabIndex = 12
        Me.lblIDTrabajkador.Text = "ID del servicio"
        '
        'dgvActividades
        '
        Me.dgvActividades.AutoGenerateColumns = False
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDServiciosDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvActividades.DataSource = Me.ServiciosBindingSource
        Me.dgvActividades.Location = New System.Drawing.Point(25, 19)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.Size = New System.Drawing.Size(245, 413)
        Me.dgvActividades.TabIndex = 12
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
        Me.ServiciosBindingSource.DataSource = Me.BDHotelDataSet
        '
        'BDHotelDataSet
        '
        Me.BDHotelDataSet.DataSetName = "BDHotelDataSet"
        Me.BDHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEliminarActividad
        '
        Me.btnEliminarActividad.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarActividad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarActividad.Location = New System.Drawing.Point(604, 150)
        Me.btnEliminarActividad.Name = "btnEliminarActividad"
        Me.btnEliminarActividad.Size = New System.Drawing.Size(171, 74)
        Me.btnEliminarActividad.TabIndex = 4
        Me.btnEliminarActividad.Text = "Eliminar servicio"
        Me.btnEliminarActividad.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(604, 330)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(171, 74)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btngregarServicio
        '
        Me.btngregarServicio.BackColor = System.Drawing.Color.RoyalBlue
        Me.btngregarServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngregarServicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btngregarServicio.Location = New System.Drawing.Point(604, 26)
        Me.btngregarServicio.Name = "btngregarServicio"
        Me.btngregarServicio.Size = New System.Drawing.Size(171, 74)
        Me.btngregarServicio.TabIndex = 3
        Me.btngregarServicio.Text = "Agregar servicio"
        Me.btngregarServicio.UseVisualStyleBackColor = False
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'FormServicioMesaBarra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.btnEliminarActividad)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btngregarServicio)
        Me.Name = "FormServicioMesaBarra"
        Me.Text = "FormServicioMesaBarra"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbIDServicio As TextBox
    Friend WithEvents lblIDTrabajkador As Label
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents btnEliminarActividad As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btngregarServicio As Button
    Friend WithEvents cmbNombreServicio As ComboBox
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BDHotelDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents IDServiciosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
