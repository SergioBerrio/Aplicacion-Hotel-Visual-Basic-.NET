Public Class FormPantallaTrabajadores2
    Private Sub btnPrimerosPuestos_Click(sender As Object, e As EventArgs) Handles btnPrimerosPuestos.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpieza_Click(sender As Object, e As EventArgs) Handles btnLimpieza.Click
        MsgBox("Has accedido como puesto de limpieza!!")
        FormLimpieza.Show()
        Me.Hide()
    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        MsgBox("Has accedido como puesto de mantenimiento!!")
        FormMantenimiento.Show()
        Me.Hide()
    End Sub

    Private Sub btnDirector_Click(sender As Object, e As EventArgs) Handles btnDirector.Click
        MsgBox("Has accedido como puesto de director/administrador!!")
        FormDirector.Show()
        Me.Hide()
    End Sub

    Private Sub btGobernanta_Click(sender As Object, e As EventArgs) Handles btnGobernanta.Click
        MsgBox("Has accedido como puesto de gobernanta!!")
        FormGobernanta.Show()
        Me.Hide()
    End Sub

    Private Sub btnCamareraPiso_Click(sender As Object, e As EventArgs) Handles btnCamareraHabitacion.Click
        MsgBox("Has accedido como puesto de camarera de piso!!")
        FormCamarerasPiso.Show()
        Me.Hide()
    End Sub

    Private Sub btnBarraMesa_Click(sender As Object, e As EventArgs) Handles btnBarraMesa.Click
        MsgBox("Has accedido como puesto de servicio de barra y mesa!!")
        FormServicioMesaBarra.Show()
        Me.Hide()
    End Sub
End Class