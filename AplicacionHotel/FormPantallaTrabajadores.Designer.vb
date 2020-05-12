<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPantallaTrabajadores
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
        Me.btnConserjeria = New System.Windows.Forms.Button()
        Me.btnRecepcion = New System.Windows.Forms.Button()
        Me.btnCocina = New System.Windows.Forms.Button()
        Me.btnAnimacion = New System.Windows.Forms.Button()
        Me.btnSocorrista = New System.Windows.Forms.Button()
        Me.btnSeguridad = New System.Windows.Forms.Button()
        Me.btnMasPuestos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConserjeria
        '
        Me.btnConserjeria.Location = New System.Drawing.Point(46, 51)
        Me.btnConserjeria.Name = "btnConserjeria"
        Me.btnConserjeria.Size = New System.Drawing.Size(137, 117)
        Me.btnConserjeria.TabIndex = 0
        Me.btnConserjeria.Text = "Entrar como conserjería"
        Me.btnConserjeria.UseVisualStyleBackColor = True
        '
        'btnRecepcion
        '
        Me.btnRecepcion.Location = New System.Drawing.Point(311, 51)
        Me.btnRecepcion.Name = "btnRecepcion"
        Me.btnRecepcion.Size = New System.Drawing.Size(137, 117)
        Me.btnRecepcion.TabIndex = 1
        Me.btnRecepcion.Text = "Entrar como recepción"
        Me.btnRecepcion.UseVisualStyleBackColor = True
        '
        'btnCocina
        '
        Me.btnCocina.Location = New System.Drawing.Point(585, 51)
        Me.btnCocina.Name = "btnCocina"
        Me.btnCocina.Size = New System.Drawing.Size(137, 117)
        Me.btnCocina.TabIndex = 2
        Me.btnCocina.Text = "Entrar como cocina"
        Me.btnCocina.UseVisualStyleBackColor = True
        '
        'btnAnimacion
        '
        Me.btnAnimacion.Location = New System.Drawing.Point(46, 270)
        Me.btnAnimacion.Name = "btnAnimacion"
        Me.btnAnimacion.Size = New System.Drawing.Size(137, 117)
        Me.btnAnimacion.TabIndex = 3
        Me.btnAnimacion.Text = "Entrar como animación"
        Me.btnAnimacion.UseVisualStyleBackColor = True
        '
        'btnSocorrista
        '
        Me.btnSocorrista.Location = New System.Drawing.Point(311, 270)
        Me.btnSocorrista.Name = "btnSocorrista"
        Me.btnSocorrista.Size = New System.Drawing.Size(137, 117)
        Me.btnSocorrista.TabIndex = 4
        Me.btnSocorrista.Text = "Entrar como socorrista"
        Me.btnSocorrista.UseVisualStyleBackColor = True
        '
        'btnSeguridad
        '
        Me.btnSeguridad.Location = New System.Drawing.Point(585, 270)
        Me.btnSeguridad.Name = "btnSeguridad"
        Me.btnSeguridad.Size = New System.Drawing.Size(137, 117)
        Me.btnSeguridad.TabIndex = 5
        Me.btnSeguridad.Text = "Entrar como personal de seguridad"
        Me.btnSeguridad.UseVisualStyleBackColor = True
        '
        'btnMasPuestos
        '
        Me.btnMasPuestos.Location = New System.Drawing.Point(677, 203)
        Me.btnMasPuestos.Name = "btnMasPuestos"
        Me.btnMasPuestos.Size = New System.Drawing.Size(94, 35)
        Me.btnMasPuestos.TabIndex = 6
        Me.btnMasPuestos.Text = "Más puestos"
        Me.btnMasPuestos.UseVisualStyleBackColor = True
        '
        'FormPantallaTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMasPuestos)
        Me.Controls.Add(Me.btnSeguridad)
        Me.Controls.Add(Me.btnSocorrista)
        Me.Controls.Add(Me.btnAnimacion)
        Me.Controls.Add(Me.btnCocina)
        Me.Controls.Add(Me.btnRecepcion)
        Me.Controls.Add(Me.btnConserjeria)
        Me.Name = "FormPantallaTrabajadores"
        Me.Text = "FormPantallaTrabajadores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConserjeria As Button
    Friend WithEvents btnRecepcion As Button
    Friend WithEvents btnCocina As Button
    Friend WithEvents btnAnimacion As Button
    Friend WithEvents btnSocorrista As Button
    Friend WithEvents btnSeguridad As Button
    Friend WithEvents btnMasPuestos As Button
End Class
