Public Class FormPantallaTrabajadores
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnMasPuestos.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnConserjeria_Click(sender As Object, e As EventArgs) Handles btnConserjeria.Click
        FormConserjeria.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecepcion_Click(sender As Object, e As EventArgs) Handles btnRecepcion.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnCocina_Click(sender As Object, e As EventArgs) Handles btnCocina.Click
        FormCocina.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnimacion_Click(sender As Object, e As EventArgs) Handles btnAnimacion.Click
        FormAnimacion.Show()
        Me.Hide()
    End Sub

    Private Sub btnSocorrista_Click(sender As Object, e As EventArgs) Handles btnSocorrista.Click
        FormSocorrista.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        FormSeguridad.Show()
        Me.Hide()
    End Sub
End Class