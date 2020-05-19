Public Class FormPantallaTrabajadores
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnMasPuestos.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnConserjeria_Click(sender As Object, e As EventArgs) Handles btnConserjeria.Click
        MsgBox("Has accedido como puesto de conserjería!!", MsgBoxStyle.Information, "Información")
        FormConserjeria.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecepcion_Click(sender As Object, e As EventArgs) Handles btnRecepcion.Click
        MsgBox("Has accedido como puesto de recepción!!", MsgBoxStyle.Information, "Información")
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnCocina_Click(sender As Object, e As EventArgs) Handles btnCocina.Click
        MsgBox("Has accedido como puesto de cocina!!", MsgBoxStyle.Information, "Información")
        FormCocina.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnimacion_Click(sender As Object, e As EventArgs) Handles btnAnimacion.Click
        MsgBox("Has accedido como puesto de animación!!", MsgBoxStyle.Information, "Información")
        FormAnimacion.Show()
        Me.Hide()
    End Sub

    Private Sub btnSocorrista_Click(sender As Object, e As EventArgs) Handles btnSocorrista.Click
        MsgBox("Has accedido como puesto de socorrista!!", MsgBoxStyle.Information, "Información")
        FormSocorrista.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        MsgBox("Has accedido como puesto de personal de seguridad!!", MsgBoxStyle.Information, "Información")
        FormSeguridad.Show()
        Me.Hide()
    End Sub
End Class