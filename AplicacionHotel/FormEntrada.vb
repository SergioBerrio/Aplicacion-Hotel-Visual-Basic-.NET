Public Class FormEntrada
    Private Sub bntAtras1_Click(sender As Object, e As EventArgs) Handles bntAtras1.Click
        FormInicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormInicioSesionTrabajadores.Show()
    End Sub
End Class