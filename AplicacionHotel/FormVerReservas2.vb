Imports System.Data.OleDb

Public Class FormVerReservas2

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminarReserva_Click(sender As Object, e As EventArgs) Handles btnEliminarReserva.Click
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.Reservas' Puede moverla o quitarla según sea necesario.
        Me.ReservasTableAdapter.Fill(Me.BDHotelDataSet.Reservas)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Reservas WHERE IDReserva = " & FormReservaHabitaciones.txtbIDReserva.Text & ""
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()
    End Sub
End Class