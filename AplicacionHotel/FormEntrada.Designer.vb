<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntrada
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
        Me.bntAtras1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bntAtras1
        '
        Me.bntAtras1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAtras1.Location = New System.Drawing.Point(460, 274)
        Me.bntAtras1.Name = "bntAtras1"
        Me.bntAtras1.Size = New System.Drawing.Size(206, 78)
        Me.bntAtras1.TabIndex = 2
        Me.bntAtras1.Text = "Atrás"
        Me.bntAtras1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(67, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 78)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Control de los trabajadores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bntAtras1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormEntrada"
        Me.Text = "FormEntrada"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntAtras1 As Button
    Friend WithEvents Button1 As Button
End Class
