<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCocina
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
        Me.btnBuscarReceta = New System.Windows.Forms.Button()
        Me.txtbBuscarReceta = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.dgvCocina = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarRecetas = New System.Windows.Forms.Button()
        Me.btnEliminarRecetas = New System.Windows.Forms.Button()
        Me.gbDatosReceta = New System.Windows.Forms.GroupBox()
        Me.txtbIngredientes = New System.Windows.Forms.TextBox()
        Me.lblIngredientes = New System.Windows.Forms.Label()
        Me.txtbNombreReceta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbIDReceta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBuscar.SuspendLayout()
        CType(Me.dgvCocina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosReceta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.btnBuscarReceta)
        Me.gbBuscar.Controls.Add(Me.txtbBuscarReceta)
        Me.gbBuscar.Controls.Add(Me.lblBuscar)
        Me.gbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(714, 19)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(311, 184)
        Me.gbBuscar.TabIndex = 5
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscador"
        '
        'btnBuscarReceta
        '
        Me.btnBuscarReceta.BackColor = System.Drawing.Color.Green
        Me.btnBuscarReceta.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBuscarReceta.Location = New System.Drawing.Point(24, 125)
        Me.btnBuscarReceta.Name = "btnBuscarReceta"
        Me.btnBuscarReceta.Size = New System.Drawing.Size(255, 34)
        Me.btnBuscarReceta.TabIndex = 7
        Me.btnBuscarReceta.Text = "Buscar"
        Me.btnBuscarReceta.UseVisualStyleBackColor = False
        '
        'txtbBuscarReceta
        '
        Me.txtbBuscarReceta.Location = New System.Drawing.Point(24, 62)
        Me.txtbBuscarReceta.Name = "txtbBuscarReceta"
        Me.txtbBuscarReceta.Size = New System.Drawing.Size(255, 22)
        Me.txtbBuscarReceta.TabIndex = 6
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(21, 36)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(81, 16)
        Me.lblBuscar.TabIndex = 7
        Me.lblBuscar.Text = "ID de receta"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(714, 304)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(314, 51)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.Text = "Salir"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Orange
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(222, 301)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(135, 51)
        Me.btnSiguiente.TabIndex = 9
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.Orange
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(12, 301)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(130, 51)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'dgvCocina
        '
        Me.dgvCocina.AllowUserToDeleteRows = False
        Me.dgvCocina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCocina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvCocina.Location = New System.Drawing.Point(12, 12)
        Me.dgvCocina.Name = "dgvCocina"
        Me.dgvCocina.ReadOnly = True
        Me.dgvCocina.Size = New System.Drawing.Size(345, 269)
        Me.dgvCocina.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "IDRecetas"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ingredientes"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btnAgregarRecetas
        '
        Me.btnAgregarRecetas.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregarRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRecetas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarRecetas.Location = New System.Drawing.Point(381, 294)
        Me.btnAgregarRecetas.Name = "btnAgregarRecetas"
        Me.btnAgregarRecetas.Size = New System.Drawing.Size(131, 58)
        Me.btnAgregarRecetas.TabIndex = 10
        Me.btnAgregarRecetas.Text = "Agregar recetas"
        Me.btnAgregarRecetas.UseVisualStyleBackColor = False
        '
        'btnEliminarRecetas
        '
        Me.btnEliminarRecetas.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminarRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRecetas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEliminarRecetas.Location = New System.Drawing.Point(563, 297)
        Me.btnEliminarRecetas.Name = "btnEliminarRecetas"
        Me.btnEliminarRecetas.Size = New System.Drawing.Size(129, 58)
        Me.btnEliminarRecetas.TabIndex = 11
        Me.btnEliminarRecetas.Text = "Eliminar recetas"
        Me.btnEliminarRecetas.UseVisualStyleBackColor = False
        '
        'gbDatosReceta
        '
        Me.gbDatosReceta.Controls.Add(Me.txtbIngredientes)
        Me.gbDatosReceta.Controls.Add(Me.lblIngredientes)
        Me.gbDatosReceta.Controls.Add(Me.txtbNombreReceta)
        Me.gbDatosReceta.Controls.Add(Me.Label2)
        Me.gbDatosReceta.Controls.Add(Me.txtbIDReceta)
        Me.gbDatosReceta.Controls.Add(Me.Label1)
        Me.gbDatosReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosReceta.Location = New System.Drawing.Point(381, 19)
        Me.gbDatosReceta.Name = "gbDatosReceta"
        Me.gbDatosReceta.Size = New System.Drawing.Size(311, 262)
        Me.gbDatosReceta.TabIndex = 1
        Me.gbDatosReceta.TabStop = False
        Me.gbDatosReceta.Text = "Datos de  las recetas"
        '
        'txtbIngredientes
        '
        Me.txtbIngredientes.Location = New System.Drawing.Point(24, 218)
        Me.txtbIngredientes.Name = "txtbIngredientes"
        Me.txtbIngredientes.Size = New System.Drawing.Size(255, 22)
        Me.txtbIngredientes.TabIndex = 4
        '
        'lblIngredientes
        '
        Me.lblIngredientes.AutoSize = True
        Me.lblIngredientes.Location = New System.Drawing.Point(26, 189)
        Me.lblIngredientes.Name = "lblIngredientes"
        Me.lblIngredientes.Size = New System.Drawing.Size(82, 16)
        Me.lblIngredientes.TabIndex = 12
        Me.lblIngredientes.Text = "Ingredientes"
        '
        'txtbNombreReceta
        '
        Me.txtbNombreReceta.Location = New System.Drawing.Point(24, 137)
        Me.txtbNombreReceta.Name = "txtbNombreReceta"
        Me.txtbNombreReceta.Size = New System.Drawing.Size(255, 22)
        Me.txtbNombreReceta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'txtbIDReceta
        '
        Me.txtbIDReceta.Enabled = False
        Me.txtbIDReceta.Location = New System.Drawing.Point(24, 62)
        Me.txtbIDReceta.Name = "txtbIDReceta"
        Me.txtbIDReceta.Size = New System.Drawing.Size(255, 22)
        Me.txtbIDReceta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID de receta"
        '
        'FormCocina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 364)
        Me.Controls.Add(Me.gbDatosReceta)
        Me.Controls.Add(Me.btnEliminarRecetas)
        Me.Controls.Add(Me.btnAgregarRecetas)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.dgvCocina)
        Me.Name = "FormCocina"
        Me.Text = "FormCocina"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.dgvCocina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosReceta.ResumeLayout(False)
        Me.gbDatosReceta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarReceta As Button
    Friend WithEvents txtbBuscarReceta As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents dgvCocina As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarRecetas As Button
    Friend WithEvents btnEliminarRecetas As Button
    Friend WithEvents gbDatosReceta As GroupBox
    Friend WithEvents txtbIngredientes As TextBox
    Friend WithEvents lblIngredientes As Label
    Friend WithEvents txtbNombreReceta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbIDReceta As TextBox
    Friend WithEvents Label1 As Label
End Class
