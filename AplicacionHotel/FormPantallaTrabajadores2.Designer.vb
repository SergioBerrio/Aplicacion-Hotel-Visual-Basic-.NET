<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPantallaTrabajadores2
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDirector = New System.Windows.Forms.Button()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.btnLimpieza = New System.Windows.Forms.Button()
        Me.btnPrimerosPuestos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(584, 272)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 117)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Entrar como servicio de barra y mesa"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(310, 272)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 117)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Entrar como camarera de habitación"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(45, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 117)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Entrar como gobernanta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnDirector
        '
        Me.btnDirector.Location = New System.Drawing.Point(584, 53)
        Me.btnDirector.Name = "btnDirector"
        Me.btnDirector.Size = New System.Drawing.Size(137, 117)
        Me.btnDirector.TabIndex = 9
        Me.btnDirector.Text = "Entrar como director"
        Me.btnDirector.UseVisualStyleBackColor = True
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.Location = New System.Drawing.Point(310, 53)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(137, 117)
        Me.btnMantenimiento.TabIndex = 8
        Me.btnMantenimiento.Text = "Entrar como mantenimiento"
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'btnLimpieza
        '
        Me.btnLimpieza.Location = New System.Drawing.Point(45, 53)
        Me.btnLimpieza.Name = "btnLimpieza"
        Me.btnLimpieza.Size = New System.Drawing.Size(137, 117)
        Me.btnLimpieza.TabIndex = 7
        Me.btnLimpieza.Text = "Entrar como limpieza"
        Me.btnLimpieza.UseVisualStyleBackColor = True
        '
        'btnPrimerosPuestos
        '
        Me.btnPrimerosPuestos.Location = New System.Drawing.Point(21, 197)
        Me.btnPrimerosPuestos.Name = "btnPrimerosPuestos"
        Me.btnPrimerosPuestos.Size = New System.Drawing.Size(101, 43)
        Me.btnPrimerosPuestos.TabIndex = 13
        Me.btnPrimerosPuestos.Text = "Primeros puestos"
        Me.btnPrimerosPuestos.UseVisualStyleBackColor = True
        '
        'FormPantallaTrabajadores2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrimerosPuestos)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDirector)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Controls.Add(Me.btnLimpieza)
        Me.Name = "FormPantallaTrabajadores2"
        Me.Text = "FormPantallaTrabajadores2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDirector As Button
    Friend WithEvents btnMantenimiento As Button
    Friend WithEvents btnLimpieza As Button
    Friend WithEvents btnPrimerosPuestos As Button
End Class
