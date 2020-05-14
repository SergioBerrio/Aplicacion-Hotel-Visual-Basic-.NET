Public Class FormRecepcion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormVerReservas.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormHacerFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormVerClientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormVerFacturas.Show()
        Me.Hide()
    End Sub
End Class