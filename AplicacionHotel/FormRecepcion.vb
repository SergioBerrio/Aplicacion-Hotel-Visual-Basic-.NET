Public Class FormRecepcion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerReservas.Click
        FormVerReservas2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHacerFacturas.Click
        FormPapelFactura.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        FormVerClientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVerFacturas.Click
        FormVerFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnHacerReserva.Click
        FormReservaHabitaciones2.Show()
        Me.Hide()
    End Sub
End Class