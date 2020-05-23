<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnimacion
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
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet11 = New AplicacionHotel.BDHotelDataSet1()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAgregarActividad = New System.Windows.Forms.Button()
        Me.btnEliminarActividad = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblIDActividad = New System.Windows.Forms.Label()
        Me.txtbImporte = New System.Windows.Forms.TextBox()
        Me.txtbIDActividad = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtbBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.ActividadesTableAdapter1 = New AplicacionHotel.BDHotelDataSet1TableAdapters.ActividadesTableAdapter()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbBuscar.SuspendLayout()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvActividades
        '
        Me.dgvActividades.AutoGenerateColumns = False
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvActividades.DataSource = Me.ActividadesBindingSource1
        Me.dgvActividades.Location = New System.Drawing.Point(21, 22)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.Size = New System.Drawing.Size(345, 345)
        Me.dgvActividades.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDActividades"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDActividades"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ImporteActividad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ImporteActividad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'ActividadesBindingSource1
        '
        Me.ActividadesBindingSource1.DataMember = "Actividades"
        Me.ActividadesBindingSource1.DataSource = Me.BdHotelDataSet11
        '
        'BdHotelDataSet11
        '
        Me.BdHotelDataSet11.DataSetName = "BDHotelDataSet1"
        Me.BdHotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(643, 358)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(131, 70)
        Me.btnAtras.TabIndex = 10
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAgregarActividad
        '
        Me.btnAgregarActividad.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarActividad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarActividad.Location = New System.Drawing.Point(643, 22)
        Me.btnAgregarActividad.Name = "btnAgregarActividad"
        Me.btnAgregarActividad.Size = New System.Drawing.Size(131, 79)
        Me.btnAgregarActividad.TabIndex = 7
        Me.btnAgregarActividad.Text = "Agregar actividad"
        Me.btnAgregarActividad.UseVisualStyleBackColor = False
        '
        'btnEliminarActividad
        '
        Me.btnEliminarActividad.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarActividad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarActividad.Location = New System.Drawing.Point(643, 190)
        Me.btnEliminarActividad.Name = "btnEliminarActividad"
        Me.btnEliminarActividad.Size = New System.Drawing.Size(131, 80)
        Me.btnEliminarActividad.TabIndex = 9
        Me.btnEliminarActividad.Text = "Eliminar actividad"
        Me.btnEliminarActividad.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblImporte)
        Me.GroupBox1.Controls.Add(Me.lblIDActividad)
        Me.GroupBox1.Controls.Add(Me.txtbImporte)
        Me.GroupBox1.Controls.Add(Me.txtbIDActividad)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.cmbNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(387, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 248)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de las actividades"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(17, 166)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 16)
        Me.lblImporte.TabIndex = 5
        Me.lblImporte.Text = "Importe"
        '
        'lblIDActividad
        '
        Me.lblIDActividad.AutoSize = True
        Me.lblIDActividad.Location = New System.Drawing.Point(17, 28)
        Me.lblIDActividad.Name = "lblIDActividad"
        Me.lblIDActividad.Size = New System.Drawing.Size(98, 16)
        Me.lblIDActividad.TabIndex = 4
        Me.lblIDActividad.Text = "ID de actividad"
        '
        'txtbImporte
        '
        Me.txtbImporte.Enabled = False
        Me.txtbImporte.Location = New System.Drawing.Point(20, 197)
        Me.txtbImporte.Name = "txtbImporte"
        Me.txtbImporte.Size = New System.Drawing.Size(176, 22)
        Me.txtbImporte.TabIndex = 4
        '
        'txtbIDActividad
        '
        Me.txtbIDActividad.Location = New System.Drawing.Point(20, 52)
        Me.txtbIDActividad.Name = "txtbIDActividad"
        Me.txtbIDActividad.Size = New System.Drawing.Size(175, 22)
        Me.txtbIDActividad.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 87)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'cmbNombre
        '
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(20, 118)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(176, 24)
        Me.cmbNombre.TabIndex = 3
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscar)
        Me.gbBuscar.Controls.Add(Me.txtbBuscar)
        Me.gbBuscar.Controls.Add(Me.lblBuscar)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(387, 288)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(222, 140)
        Me.gbBuscar.TabIndex = 5
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Green
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Location = New System.Drawing.Point(20, 88)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(176, 33)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtbBuscar
        '
        Me.txtbBuscar.Location = New System.Drawing.Point(20, 57)
        Me.txtbBuscar.Name = "txtbBuscar"
        Me.txtbBuscar.Size = New System.Drawing.Size(175, 22)
        Me.txtbBuscar.TabIndex = 6
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(17, 31)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(81, 16)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Identificador"
        '
        'ActividadesTableAdapter1
        '
        Me.ActividadesTableAdapter1.ClearBeforeFill = True
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(21, 376)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(131, 52)
        Me.btnAnterior.TabIndex = 11
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(235, 376)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(131, 52)
        Me.btnSiguiente.TabIndex = 12
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "Actividades"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnActualizar.Location = New System.Drawing.Point(643, 127)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(130, 47)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'FormAnimacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminarActividad)
        Me.Controls.Add(Me.btnAgregarActividad)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvActividades)
        Me.Name = "FormAnimacion"
        Me.Text = "FormAnimacion"
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents BDHotelDataSet1 As BDHotelDataSet1
    Friend WithEvents ActividadesBindingSource As BindingSource
    Friend WithEvents ActividadesTableAdapter As BDHotelDataSet1TableAdapters.ActividadesTableAdapter
    Friend WithEvents IDActividadesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteActividadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAgregarActividad As Button
    Friend WithEvents btnEliminarActividad As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents txtbImporte As TextBox
    Friend WithEvents txtbIDActividad As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtbBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents lblIDActividad As Label
    Friend WithEvents BdHotelDataSet11 As BDHotelDataSet1
    Friend WithEvents ActividadesBindingSource1 As BindingSource
    Friend WithEvents ActividadesTableAdapter1 As BDHotelDataSet1TableAdapters.ActividadesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnActualizar As Button
End Class
