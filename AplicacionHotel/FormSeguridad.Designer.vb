﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeguridad
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
        Me.dgvSeguridad = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscarZona = New System.Windows.Forms.Button()
        Me.txtbBuscarZona = New System.Windows.Forms.TextBox()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.gbDatosReceta = New System.Windows.Forms.GroupBox()
        Me.txtbZona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbIDZona = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarRecetas = New System.Windows.Forms.Button()
        Me.btnAgregarRecetas = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.gbDatosReceta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSeguridad
        '
        Me.dgvSeguridad.AllowUserToDeleteRows = False
        Me.dgvSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguridad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvSeguridad.Location = New System.Drawing.Point(12, 12)
        Me.dgvSeguridad.Name = "dgvSeguridad"
        Me.dgvSeguridad.ReadOnly = True
        Me.dgvSeguridad.Size = New System.Drawing.Size(245, 358)
        Me.dgvSeguridad.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "IDZona"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Zona"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarZona)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarZona)
        Me.gbBuscar.Controls.Add(Me.lblZona)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(275, 203)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(295, 157)
        Me.gbBuscar.TabIndex = 4
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarZona
        '
        Me.btnBuscarZona.BackColor = System.Drawing.Color.Green
        Me.btnBuscarZona.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarZona.Location = New System.Drawing.Point(24, 105)
        Me.btnBuscarZona.Name = "btnBuscarZona"
        Me.btnBuscarZona.Size = New System.Drawing.Size(252, 33)
        Me.btnBuscarZona.TabIndex = 6
        Me.btnBuscarZona.Text = "Buscar"
        Me.btnBuscarZona.UseVisualStyleBackColor = False
        '
        'txtbBuscarZona
        '
        Me.txtbBuscarZona.Location = New System.Drawing.Point(24, 60)
        Me.txtbBuscarZona.Name = "txtbBuscarZona"
        Me.txtbBuscarZona.Size = New System.Drawing.Size(252, 22)
        Me.txtbBuscarZona.TabIndex = 5
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Location = New System.Drawing.Point(21, 34)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(39, 16)
        Me.lblZona.TabIndex = 10
        Me.lblZona.Text = "Zona"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(275, 374)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(407, 57)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(157, 374)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(100, 57)
        Me.btnSiguiente.TabIndex = 10
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(11, 374)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(90, 57)
        Me.btnAnterior.TabIndex = 9
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'gbDatosReceta
        '
        Me.gbDatosReceta.Controls.Add(Me.txtbZona)
        Me.gbDatosReceta.Controls.Add(Me.Label2)
        Me.gbDatosReceta.Controls.Add(Me.txtbIDZona)
        Me.gbDatosReceta.Controls.Add(Me.Label1)
        Me.gbDatosReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosReceta.Location = New System.Drawing.Point(275, 12)
        Me.gbDatosReceta.Name = "gbDatosReceta"
        Me.gbDatosReceta.Size = New System.Drawing.Size(295, 185)
        Me.gbDatosReceta.TabIndex = 1
        Me.gbDatosReceta.TabStop = False
        Me.gbDatosReceta.Text = "Datos de  las zonas disponibles"
        '
        'txtbZona
        '
        Me.txtbZona.Location = New System.Drawing.Point(24, 137)
        Me.txtbZona.Name = "txtbZona"
        Me.txtbZona.Size = New System.Drawing.Size(252, 22)
        Me.txtbZona.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Zona"
        '
        'txtbIDZona
        '
        Me.txtbIDZona.Enabled = False
        Me.txtbIDZona.Location = New System.Drawing.Point(24, 62)
        Me.txtbIDZona.Name = "txtbIDZona"
        Me.txtbIDZona.Size = New System.Drawing.Size(252, 22)
        Me.txtbIDZona.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID de zona"
        '
        'btnEliminarRecetas
        '
        Me.btnEliminarRecetas.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRecetas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarRecetas.Location = New System.Drawing.Point(586, 121)
        Me.btnEliminarRecetas.Name = "btnEliminarRecetas"
        Me.btnEliminarRecetas.Size = New System.Drawing.Size(96, 58)
        Me.btnEliminarRecetas.TabIndex = 8
        Me.btnEliminarRecetas.Text = "Eliminar zona"
        Me.btnEliminarRecetas.UseVisualStyleBackColor = False
        '
        'btnAgregarRecetas
        '
        Me.btnAgregarRecetas.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRecetas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarRecetas.Location = New System.Drawing.Point(586, 12)
        Me.btnAgregarRecetas.Name = "btnAgregarRecetas"
        Me.btnAgregarRecetas.Size = New System.Drawing.Size(96, 58)
        Me.btnAgregarRecetas.TabIndex = 7
        Me.btnAgregarRecetas.Text = "Agregar zona"
        Me.btnAgregarRecetas.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnActualizar.Location = New System.Drawing.Point(586, 263)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 64)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'FormSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 438)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.gbDatosReceta)
        Me.Controls.Add(Me.btnEliminarRecetas)
        Me.Controls.Add(Me.btnAgregarRecetas)
        Me.Controls.Add(Me.dgvSeguridad)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Name = "FormSeguridad"
        Me.Text = "FormSeguridad"
        CType(Me.dgvSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatosReceta.ResumeLayout(False)
        Me.gbDatosReceta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSeguridad As DataGridView
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarZona As Button
    Friend WithEvents txtbBuscarZona As TextBox
    Friend WithEvents lblZona As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents gbDatosReceta As GroupBox
    Friend WithEvents txtbZona As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbIDZona As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminarRecetas As Button
    Friend WithEvents btnAgregarRecetas As Button
    Friend WithEvents btnActualizar As Button
End Class
