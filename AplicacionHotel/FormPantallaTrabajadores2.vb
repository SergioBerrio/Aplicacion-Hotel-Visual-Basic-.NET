Public Class FormPantallaTrabajadores2
    Private Sub btnPrimerosPuestos_Click(sender As Object, e As EventArgs) Handles btnPrimerosPuestos.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpieza_Click(sender As Object, e As EventArgs) Handles btnLimpieza.Click
        MsgBox("Has accedido como puesto de limpieza!!", MsgBoxStyle.Information, "Información")
        FormLimpieza.Show()
        Me.Hide()
    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        MsgBox("Has accedido como puesto de mantenimiento!!", MsgBoxStyle.Information, "Información")
        FormMantenimiento.Show()
        Me.Hide()
    End Sub

    Private Sub btnDirector_Click(sender As Object, e As EventArgs) Handles btnDirector.Click
        MsgBox("Has accedido como puesto de director/administrador!!", MsgBoxStyle.Information, "Información")
        FormDirector.Show()
        Me.Hide()
    End Sub

    Private Sub btGobernanta_Click(sender As Object, e As EventArgs) Handles btnGobernanta.Click
        MsgBox("Has accedido como puesto de gobernanta!!", MsgBoxStyle.Information, "Información")
        FormGobernanta.Show()
        Me.Hide()
    End Sub

    Private Sub btnBarraMesa_Click(sender As Object, e As EventArgs) Handles btnBarraMesa.Click
        MsgBox("Has accedido como puesto de servicio de barra y mesa!!", MsgBoxStyle.Information, "Información")
        FormServiciosHotel.Show()
        Me.Hide()
    End Sub
End Class