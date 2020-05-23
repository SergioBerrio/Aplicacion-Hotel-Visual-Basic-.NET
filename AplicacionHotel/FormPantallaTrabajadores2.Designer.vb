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
        Me.btnBarraMesa = New System.Windows.Forms.Button()
        Me.btnGobernanta = New System.Windows.Forms.Button()
        Me.btnDirector = New System.Windows.Forms.Button()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.btnLimpieza = New System.Windows.Forms.Button()
        Me.btnPrimerosPuestos = New System.Windows.Forms.Button()
        Me.gb9 = New System.Windows.Forms.GroupBox()
        Me.gb8 = New System.Windows.Forms.GroupBox()
        Me.gb7 = New System.Windows.Forms.GroupBox()
        Me.gb10 = New System.Windows.Forms.GroupBox()
        Me.gb11 = New System.Windows.Forms.GroupBox()
        Me.gb9.SuspendLayout()
        Me.gb8.SuspendLayout()
        Me.gb7.SuspendLayout()
        Me.gb10.SuspendLayout()
        Me.gb11.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBarraMesa
        '
        Me.btnBarraMesa.BackColor = System.Drawing.Color.Goldenrod
        Me.btnBarraMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarraMesa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBarraMesa.Location = New System.Drawing.Point(27, 33)
        Me.btnBarraMesa.Name = "btnBarraMesa"
        Me.btnBarraMesa.Size = New System.Drawing.Size(150, 117)
        Me.btnBarraMesa.TabIndex = 11
        Me.btnBarraMesa.Text = "Entrar como servicio de barra y mesa"
        Me.btnBarraMesa.UseVisualStyleBackColor = False
        '
        'btnGobernanta
        '
        Me.btnGobernanta.BackColor = System.Drawing.Color.Goldenrod
        Me.btnGobernanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGobernanta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGobernanta.Location = New System.Drawing.Point(29, 33)
        Me.btnGobernanta.Name = "btnGobernanta"
        Me.btnGobernanta.Size = New System.Drawing.Size(137, 117)
        Me.btnGobernanta.TabIndex = 10
        Me.btnGobernanta.Text = "Entrar como gobernanta"
        Me.btnGobernanta.UseVisualStyleBackColor = False
        '
        'btnDirector
        '
        Me.btnDirector.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirector.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDirector.Location = New System.Drawing.Point(26, 22)
        Me.btnDirector.Name = "btnDirector"
        Me.btnDirector.Size = New System.Drawing.Size(150, 117)
        Me.btnDirector.TabIndex = 9
        Me.btnDirector.Text = "Entrar como director/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "administrador"
        Me.btnDirector.UseVisualStyleBackColor = False
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackColor = System.Drawing.Color.Goldenrod
        Me.btnMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMantenimiento.Location = New System.Drawing.Point(25, 21)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(137, 117)
        Me.btnMantenimiento.TabIndex = 8
        Me.btnMantenimiento.Text = "Entrar como mantenimiento"
        Me.btnMantenimiento.UseVisualStyleBackColor = False
        '
        'btnLimpieza
        '
        Me.btnLimpieza.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLimpieza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpieza.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLimpieza.Location = New System.Drawing.Point(21, 21)
        Me.btnLimpieza.Name = "btnLimpieza"
        Me.btnLimpieza.Size = New System.Drawing.Size(137, 117)
        Me.btnLimpieza.TabIndex = 7
        Me.btnLimpieza.Text = "Entrar como limpieza"
        Me.btnLimpieza.UseVisualStyleBackColor = False
        '
        'btnPrimerosPuestos
        '
        Me.btnPrimerosPuestos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPrimerosPuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerosPuestos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrimerosPuestos.Location = New System.Drawing.Point(30, 190)
        Me.btnPrimerosPuestos.Name = "btnPrimerosPuestos"
        Me.btnPrimerosPuestos.Size = New System.Drawing.Size(101, 74)
        Me.btnPrimerosPuestos.TabIndex = 12
        Me.btnPrimerosPuestos.Text = "Primeros puestos"
        Me.btnPrimerosPuestos.UseVisualStyleBackColor = False
        '
        'gb9
        '
        Me.gb9.Controls.Add(Me.btnDirector)
        Me.gb9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb9.Location = New System.Drawing.Point(544, 23)
        Me.gb9.Name = "gb9"
        Me.gb9.Size = New System.Drawing.Size(203, 162)
        Me.gb9.TabIndex = 9
        Me.gb9.TabStop = False
        Me.gb9.Text = "Puesto 9"
        '
        'gb8
        '
        Me.gb8.Controls.Add(Me.btnMantenimiento)
        Me.gb8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb8.Location = New System.Drawing.Point(284, 24)
        Me.gb8.Name = "gb8"
        Me.gb8.Size = New System.Drawing.Size(192, 160)
        Me.gb8.TabIndex = 8
        Me.gb8.TabStop = False
        Me.gb8.Text = "Puesto 8"
        '
        'gb7
        '
        Me.gb7.Controls.Add(Me.btnLimpieza)
        Me.gb7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb7.Location = New System.Drawing.Point(30, 25)
        Me.gb7.Name = "gb7"
        Me.gb7.Size = New System.Drawing.Size(197, 159)
        Me.gb7.TabIndex = 7
        Me.gb7.TabStop = False
        Me.gb7.Text = "Puesto 7"
        '
        'gb10
        '
        Me.gb10.Controls.Add(Me.btnGobernanta)
        Me.gb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb10.Location = New System.Drawing.Point(31, 270)
        Me.gb10.Name = "gb10"
        Me.gb10.Size = New System.Drawing.Size(193, 168)
        Me.gb10.TabIndex = 10
        Me.gb10.TabStop = False
        Me.gb10.Text = "Puesto 10"
        '
        'gb11
        '
        Me.gb11.Controls.Add(Me.btnBarraMesa)
        Me.gb11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb11.Location = New System.Drawing.Point(544, 270)
        Me.gb11.Name = "gb11"
        Me.gb11.Size = New System.Drawing.Size(203, 168)
        Me.gb11.TabIndex = 11
        Me.gb11.TabStop = False
        Me.gb11.Text = "Puesto 11"
        '
        'FormPantallaTrabajadores2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gb11)
        Me.Controls.Add(Me.gb10)
        Me.Controls.Add(Me.gb7)
        Me.Controls.Add(Me.gb8)
        Me.Controls.Add(Me.gb9)
        Me.Controls.Add(Me.btnPrimerosPuestos)
        Me.Name = "FormPantallaTrabajadores2"
        Me.Text = "FormPantallaTrabajadores2"
        Me.gb9.ResumeLayout(False)
        Me.gb8.ResumeLayout(False)
        Me.gb7.ResumeLayout(False)
        Me.gb10.ResumeLayout(False)
        Me.gb11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBarraMesa As Button
    Friend WithEvents btnGobernanta As Button
    Friend WithEvents btnDirector As Button
    Friend WithEvents btnMantenimiento As Button
    Friend WithEvents btnLimpieza As Button
    Friend WithEvents btnPrimerosPuestos As Button
    Friend WithEvents gb9 As GroupBox
    Friend WithEvents gb8 As GroupBox
    Friend WithEvents gb7 As GroupBox
    Friend WithEvents gb10 As GroupBox
    Friend WithEvents gb11 As GroupBox
End Class
