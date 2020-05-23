<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantenimiento
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
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscarEstado = New System.Windows.Forms.Button()
        Me.txtbBuscarEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnBuscarIDIncidencia = New System.Windows.Forms.Button()
        Me.txtbBuscarIDIncidencia = New System.Windows.Forms.TextBox()
        Me.lblIDIncidencia = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.dgvMantenimiento = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminarIncidencia = New System.Windows.Forms.Button()
        Me.btnAgregarIncidencia = New System.Windows.Forms.Button()
        Me.gbDatosIncidencia = New System.Windows.Forms.GroupBox()
        Me.txtbIncidencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbEstado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbIDIncidencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.gbBuscar.SuspendLayout()
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosIncidencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarEstado)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarEstado)
        Me.gbBuscar.Controls.Add(Me.lblEstado)
        Me.gbBuscar.Controls.Add(Me.btnBuscarIDIncidencia)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarIDIncidencia)
        Me.gbBuscar.Controls.Add(Me.lblIDIncidencia)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(381, 238)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(300, 260)
        Me.gbBuscar.TabIndex = 5
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarEstado
        '
        Me.btnBuscarEstado.BackColor = System.Drawing.Color.Green
        Me.btnBuscarEstado.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarEstado.Location = New System.Drawing.Point(24, 207)
        Me.btnBuscarEstado.Name = "btnBuscarEstado"
        Me.btnBuscarEstado.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscarEstado.TabIndex = 9
        Me.btnBuscarEstado.Text = "Buscar"
        Me.btnBuscarEstado.UseVisualStyleBackColor = False
        '
        'txtbBuscarEstado
        '
        Me.txtbBuscarEstado.Location = New System.Drawing.Point(24, 176)
        Me.txtbBuscarEstado.Name = "txtbBuscarEstado"
        Me.txtbBuscarEstado.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarEstado.TabIndex = 8
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(21, 150)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 16)
        Me.lblEstado.TabIndex = 10
        Me.lblEstado.Text = "Estado"
        '
        'btnBuscarIDIncidencia
        '
        Me.btnBuscarIDIncidencia.BackColor = System.Drawing.Color.Green
        Me.btnBuscarIDIncidencia.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarIDIncidencia.Location = New System.Drawing.Point(24, 93)
        Me.btnBuscarIDIncidencia.Name = "btnBuscarIDIncidencia"
        Me.btnBuscarIDIncidencia.Size = New System.Drawing.Size(255, 33)
        Me.btnBuscarIDIncidencia.TabIndex = 7
        Me.btnBuscarIDIncidencia.Text = "Buscar"
        Me.btnBuscarIDIncidencia.UseVisualStyleBackColor = False
        '
        'txtbBuscarIDIncidencia
        '
        Me.txtbBuscarIDIncidencia.Location = New System.Drawing.Point(24, 62)
        Me.txtbBuscarIDIncidencia.Name = "txtbBuscarIDIncidencia"
        Me.txtbBuscarIDIncidencia.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarIDIncidencia.TabIndex = 6
        '
        'lblIDIncidencia
        '
        Me.lblIDIncidencia.AutoSize = True
        Me.lblIDIncidencia.Location = New System.Drawing.Point(21, 36)
        Me.lblIDIncidencia.Name = "lblIDIncidencia"
        Me.lblIDIncidencia.Size = New System.Drawing.Size(104, 16)
        Me.lblIDIncidencia.TabIndex = 7
        Me.lblIDIncidencia.Text = "ID de incidencia"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(705, 442)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(153, 51)
        Me.btnAtras.TabIndex = 13
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(219, 447)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(138, 51)
        Me.btnSiguiente.TabIndex = 15
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Location = New System.Drawing.Point(12, 447)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(131, 51)
        Me.btnAnterior.TabIndex = 14
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'dgvMantenimiento
        '
        Me.dgvMantenimiento.AllowUserToDeleteRows = False
        Me.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMantenimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvMantenimiento.Location = New System.Drawing.Point(12, 12)
        Me.dgvMantenimiento.Name = "dgvMantenimiento"
        Me.dgvMantenimiento.ReadOnly = True
        Me.dgvMantenimiento.Size = New System.Drawing.Size(345, 421)
        Me.dgvMantenimiento.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "IDIncidencia"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Incidencia"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Estado"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btnEliminarIncidencia
        '
        Me.btnEliminarIncidencia.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarIncidencia.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarIncidencia.Location = New System.Drawing.Point(705, 144)
        Me.btnEliminarIncidencia.Name = "btnEliminarIncidencia"
        Me.btnEliminarIncidencia.Size = New System.Drawing.Size(153, 58)
        Me.btnEliminarIncidencia.TabIndex = 11
        Me.btnEliminarIncidencia.Text = "Eliminar incidencia"
        Me.btnEliminarIncidencia.UseVisualStyleBackColor = False
        '
        'btnAgregarIncidencia
        '
        Me.btnAgregarIncidencia.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarIncidencia.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarIncidencia.Location = New System.Drawing.Point(705, 12)
        Me.btnAgregarIncidencia.Name = "btnAgregarIncidencia"
        Me.btnAgregarIncidencia.Size = New System.Drawing.Size(155, 58)
        Me.btnAgregarIncidencia.TabIndex = 10
        Me.btnAgregarIncidencia.Text = "Agregar incidencia"
        Me.btnAgregarIncidencia.UseVisualStyleBackColor = False
        '
        'gbDatosIncidencia
        '
        Me.gbDatosIncidencia.Controls.Add(Me.txtbIncidencia)
        Me.gbDatosIncidencia.Controls.Add(Me.Label4)
        Me.gbDatosIncidencia.Controls.Add(Me.txtbEstado)
        Me.gbDatosIncidencia.Controls.Add(Me.Label2)
        Me.gbDatosIncidencia.Controls.Add(Me.txtbIDIncidencia)
        Me.gbDatosIncidencia.Controls.Add(Me.Label3)
        Me.gbDatosIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosIncidencia.Location = New System.Drawing.Point(381, 12)
        Me.gbDatosIncidencia.Name = "gbDatosIncidencia"
        Me.gbDatosIncidencia.Size = New System.Drawing.Size(300, 206)
        Me.gbDatosIncidencia.TabIndex = 1
        Me.gbDatosIncidencia.TabStop = False
        Me.gbDatosIncidencia.Text = "Datos de incidencias"
        '
        'txtbIncidencia
        '
        Me.txtbIncidencia.Location = New System.Drawing.Point(24, 115)
        Me.txtbIncidencia.Name = "txtbIncidencia"
        Me.txtbIncidencia.Size = New System.Drawing.Size(255, 22)
        Me.txtbIncidencia.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Incidencia"
        '
        'txtbEstado
        '
        Me.txtbEstado.Location = New System.Drawing.Point(24, 168)
        Me.txtbEstado.Name = "txtbEstado"
        Me.txtbEstado.Size = New System.Drawing.Size(255, 22)
        Me.txtbEstado.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Estado"
        '
        'txtbIDIncidencia
        '
        Me.txtbIDIncidencia.Enabled = False
        Me.txtbIDIncidencia.Location = New System.Drawing.Point(24, 53)
        Me.txtbIDIncidencia.Name = "txtbIDIncidencia"
        Me.txtbIDIncidencia.Size = New System.Drawing.Size(255, 22)
        Me.txtbIDIncidencia.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID de incidencia"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnActualizar.Location = New System.Drawing.Point(705, 300)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(153, 50)
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'FormMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 510)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.gbDatosIncidencia)
        Me.Controls.Add(Me.btnEliminarIncidencia)
        Me.Controls.Add(Me.btnAgregarIncidencia)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.dgvMantenimiento)
        Me.Name = "FormMantenimiento"
        Me.Text = "FormMantenimiento"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosIncidencia.ResumeLayout(False)
        Me.gbDatosIncidencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarEstado As Button
    Friend WithEvents txtbBuscarEstado As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnBuscarIDIncidencia As Button
    Friend WithEvents txtbBuscarIDIncidencia As TextBox
    Friend WithEvents lblIDIncidencia As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents dgvMantenimiento As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarIncidencia As Button
    Friend WithEvents btnAgregarIncidencia As Button
    Friend WithEvents gbDatosIncidencia As GroupBox
    Friend WithEvents txtbEstado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbIDIncidencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbIncidencia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnActualizar As Button
End Class
