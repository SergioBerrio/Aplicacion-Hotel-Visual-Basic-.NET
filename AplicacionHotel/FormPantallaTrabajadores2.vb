Public Class FormPantallaTrabajadores2
    Private Sub btnPrimerosPuestos_Click(sender As Object, e As EventArgs) Handles btnPrimerosPuestos.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpieza_Click(sender As Object, e As EventArgs) Handles btnLimpieza.Click
        FormLimpieza.Show()
        Me.Hide()
    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        FormMantenimiento.Show()
        Me.Hide()
    End Sub

    Private Sub btnDirector_Click(sender As Object, e As EventArgs) Handles btnDirector.Click
        FormDirector.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormGobernanta.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormCamarerasPiso.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormServicioMesaBarra.Show()
        Me.Hide()
    End Sub
End Class