<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.dgvSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
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
        Me.dgvSeguridad.TabIndex = 7
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
        Me.gbBuscar.Location = New System.Drawing.Point(279, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(386, 157)
        Me.gbBuscar.TabIndex = 1
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarZona
        '
        Me.btnBuscarZona.BackColor = System.Drawing.Color.Green
        Me.btnBuscarZona.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarZona.Location = New System.Drawing.Point(24, 91)
        Me.btnBuscarZona.Name = "btnBuscarZona"
        Me.btnBuscarZona.Size = New System.Drawing.Size(346, 33)
        Me.btnBuscarZona.TabIndex = 3
        Me.btnBuscarZona.Text = "Buscar"
        Me.btnBuscarZona.UseVisualStyleBackColor = False
        '
        'txtbBuscarZona
        '
        Me.txtbBuscarZona.Location = New System.Drawing.Point(24, 60)
        Me.txtbBuscarZona.Name = "txtbBuscarZona"
        Me.txtbBuscarZona.Size = New System.Drawing.Size(346, 22)
        Me.txtbBuscarZona.TabIndex = 2
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
        Me.btnAtras.Location = New System.Drawing.Point(519, 380)
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
        Me.btnSiguiente.Location = New System.Drawing.Point(157, 380)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(100, 51)
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
        Me.btnAnterior.Size = New System.Drawing.Size(90, 51)
        Me.btnAnterior.TabIndex = 4
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'FormSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 450)
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
End Class
