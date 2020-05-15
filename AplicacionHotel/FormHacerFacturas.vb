Public Class FormHacerFacturas
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnHacerFactura_Click(sender As Object, e As EventArgs) Handles btnHacerFactura.Click
        'FormPapelFactura.Show()
        'Me.Hide()
    End Sub

    Private Sub FormHacerFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbDNI.Text = FormReservasClientes.txtbDNI.Text

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        txtIDTrabajador.Text = Val(txtIDTrabajador.Text) + 1
    End Sub
End Class