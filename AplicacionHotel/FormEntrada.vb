Public Class FormEntrada
    Private Sub bntAtras1_Click(sender As Object, e As EventArgs) Handles bntAtras1.Click
        FormInicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnControl.Click
        FormInicioSesionTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnReserva_Click(sender As Object, e As EventArgs) Handles btnReserva.Click
        FormReservasClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnVerReservas_Click(sender As Object, e As EventArgs) Handles btnVerReservas.Click
        FormVerReservas.Show()
        Me.Hide()
    End Sub
End Class