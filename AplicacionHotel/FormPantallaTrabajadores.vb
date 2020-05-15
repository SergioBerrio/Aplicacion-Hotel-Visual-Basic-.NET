Public Class FormPantallaTrabajadores
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnMasPuestos.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnConserjeria_Click(sender As Object, e As EventArgs) Handles btnConserjeria.Click
        MsgBox("Has accedido como puesto de conserjería!!")
        FormConserjeria.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecepcion_Click(sender As Object, e As EventArgs) Handles btnRecepcion.Click
        MsgBox("Has accedido como puesto de recepción!!")
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnCocina_Click(sender As Object, e As EventArgs) Handles btnCocina.Click
        MsgBox("Has accedido como puesto de cocina!!")
        FormCocina.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnimacion_Click(sender As Object, e As EventArgs) Handles btnAnimacion.Click
        MsgBox("Has accedido como puesto de animación!!")
        FormAnimacion.Show()
        Me.Hide()
    End Sub

    Private Sub btnSocorrista_Click(sender As Object, e As EventArgs) Handles btnSocorrista.Click
        MsgBox("Has accedido como puesto de socorrista!!")
        FormSocorrista.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        MsgBox("Has accedido como puesto de personal de seguridad!!")
        FormSeguridad.Show()
        Me.Hide()
    End Sub
End Class