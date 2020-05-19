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
        Me.txtbIDActividad = New System.Windows.Forms.TextBox()
        Me.lblImporteActividad = New System.Windows.Forms.Label()
        Me.lblIDActividad = New System.Windows.Forms.Label()
        Me.btnEliminarActividad = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAgregarActividad = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.lblNombreActividad = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.IDActividadesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdHotelDataSet1 = New AplicacionHotel.BDHotelDataSet()
        Me.ActividadesTableAdapter1 = New AplicacionHotel.BDHotelDataSetTableAdapters.ActividadesTableAdapter()
        Me.cmbImporte = New System.Windows.Forms.ComboBox()
        Me.gb1.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdHotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbIDActividad
        '
        Me.txtbIDActividad.Enabled = False
        Me.txtbIDActividad.Location = New System.Drawing.Point(21, 61)
        Me.txtbIDActividad.Name = "txtbIDActividad"
        Me.txtbIDActividad.Size = New System.Drawing.Size(163, 22)
        Me.txtbIDActividad.TabIndex = 1
        '
        'lblImporteActividad
        '
        Me.lblImporteActividad.AutoSize = True
        Me.lblImporteActividad.Location = New System.Drawing.Point(18, 173)
        Me.lblImporteActividad.Name = "lblImporteActividad"
        Me.lblImporteActividad.Size = New System.Drawing.Size(130, 16)
        Me.lblImporteActividad.TabIndex = 14
        Me.lblImporteActividad.Text = "Importe de actividad"
        '
        'lblIDActividad
        '
        Me.lblIDActividad.AutoSize = True
        Me.lblIDActividad.Location = New System.Drawing.Point(18, 27)
        Me.lblIDActividad.Name = "lblIDActividad"
        Me.lblIDActividad.Size = New System.Drawing.Size(112, 16)
        Me.lblIDActividad.TabIndex = 12
        Me.lblIDActividad.Text = "ID de la actividad"
        '
        'btnEliminarActividad
        '
        Me.btnEliminarActividad.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarActividad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarActividad.Location = New System.Drawing.Point(634, 152)
        Me.btnEliminarActividad.Name = "btnEliminarActividad"
        Me.btnEliminarActividad.Size = New System.Drawing.Size(135, 74)
        Me.btnEliminarActividad.TabIndex = 5
        Me.btnEliminarActividad.Text = "Eliminar actividad"
        Me.btnEliminarActividad.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(634, 360)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(135, 74)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAgregarActividad
        '
        Me.btnAgregarActividad.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarActividad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarActividad.Location = New System.Drawing.Point(634, 28)
        Me.btnAgregarActividad.Name = "btnAgregarActividad"
        Me.btnAgregarActividad.Size = New System.Drawing.Size(135, 74)
        Me.btnAgregarActividad.TabIndex = 4
        Me.btnAgregarActividad.Text = "Agregar actividad"
        Me.btnAgregarActividad.UseVisualStyleBackColor = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.cmbImporte)
        Me.gb1.Controls.Add(Me.cmbNombre)
        Me.gb1.Controls.Add(Me.lblNombreActividad)
        Me.gb1.Controls.Add(Me.txtbIDActividad)
        Me.gb1.Controls.Add(Me.lblImporteActividad)
        Me.gb1.Controls.Add(Me.lblIDActividad)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(389, 21)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(214, 254)
        Me.gb1.TabIndex = 1
        Me.gb1.TabStop = False
        Me.gb1.Text = "Datos de actividad"
        '
        'cmbNombre
        '
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(21, 131)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(163, 24)
        Me.cmbNombre.TabIndex = 2
        '
        'lblNombreActividad
        '
        Me.lblNombreActividad.AutoSize = True
        Me.lblNombreActividad.Location = New System.Drawing.Point(18, 96)
        Me.lblNombreActividad.Name = "lblNombreActividad"
        Me.lblNombreActividad.Size = New System.Drawing.Size(134, 16)
        Me.lblNombreActividad.TabIndex = 16
        Me.lblNombreActividad.Text = "Nombre de actividad"
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.AutoGenerateColumns = False
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDActividadesDataGridViewTextBoxColumn, Me.ImporteActividadDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dgvActividades.DataSource = Me.ActividadesBindingSource
        Me.dgvActividades.Location = New System.Drawing.Point(19, 21)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.Size = New System.Drawing.Size(344, 413)
        Me.dgvActividades.TabIndex = 7
        '
        'IDActividadesDataGridViewTextBoxColumn
        '
        Me.IDActividadesDataGridViewTextBoxColumn.DataPropertyName = "IDActividades"
        Me.IDActividadesDataGridViewTextBoxColumn.HeaderText = "IDActividades"
        Me.IDActividadesDataGridViewTextBoxColumn.Name = "IDActividadesDataGridViewTextBoxColumn"
        Me.IDActividadesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteActividadDataGridViewTextBoxColumn
        '
        Me.ImporteActividadDataGridViewTextBoxColumn.DataPropertyName = "ImporteActividad"
        Me.ImporteActividadDataGridViewTextBoxColumn.HeaderText = "ImporteActividad"
        Me.ImporteActividadDataGridViewTextBoxColumn.Name = "ImporteActividadDataGridViewTextBoxColumn"
        Me.ImporteActividadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "Actividades"
        Me.ActividadesBindingSource.DataSource = Me.BdHotelDataSet1
        '
        'BdHotelDataSet1
        '
        Me.BdHotelDataSet1.DataSetName = "BDHotelDataSet"
        Me.BdHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActividadesTableAdapter1
        '
        Me.ActividadesTableAdapter1.ClearBeforeFill = True
        '
        'cmbImporte
        '
        Me.cmbImporte.FormattingEnabled = True
        Me.cmbImporte.Location = New System.Drawing.Point(21, 210)
        Me.cmbImporte.Name = "cmbImporte"
        Me.cmbImporte.Size = New System.Drawing.Size(163, 24)
        Me.cmbImporte.TabIndex = 17
        '
        'FormAnimacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.btnEliminarActividad)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregarActividad)
        Me.Name = "FormAnimacion"
        Me.Text = "FormAnimacion"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdHotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtbIDActividad As TextBox
    Friend WithEvents lblImporteActividad As Label
    Friend WithEvents lblIDActividad As Label
    Friend WithEvents btnEliminarActividad As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAgregarActividad As Button
    Friend WithEvents ActividadesTableAdapter As BDHotelDataSetTableAdapters.ActividadesTableAdapter
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents ActXClienteTableAdapter As BDHotelDataSetTableAdapters.ActXClienteTableAdapter
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents ActividadesTableAdapter1 As BDHotelDataSetTableAdapters.ActividadesTableAdapter
    Friend WithEvents lblNombreActividad As Label
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents BdHotelDataSet1 As BDHotelDataSet
    Friend WithEvents IDActividadesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteActividadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActividadesBindingSource As BindingSource
    Friend WithEvents cmbImporte As ComboBox
End Class
