Public Class FormReservaHabitaciones2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        comando = New OleDb.OleDbCommand("INSERT INTO Reservas(IDReserva, DNI, Fecha, CantPers, FechaInicio, FechaFin, NumHabitacion)" & Chr(13) &
                                        "VALUES(txtbIDReserva, txtbDNI, txtbFecha, cmbbPersonas, dtpInicio, dtpFin, txtbFecha, txtbNumHabitacion)", conexion)
        comando.Parameters.AddWithValue("@IDReserva", txtbIDReserva.Text.ToUpper)
        comando.Parameters.AddWithValue("@DNI", txtbDNICliente.Text.ToUpper)
        comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text.ToUpper)
        comando.Parameters.AddWithValue("@CantPers", cmbPersonas.Text.ToUpper)
        comando.Parameters.AddWithValue("@FechaInicio", dtpInicio.Text.ToUpper)
        comando.Parameters.AddWithValue("@FechaFin", dtpFin.Text.ToUpper)
        comando.Parameters.AddWithValue("@NumHabitacion", txtbNumeroHabitacion.Text.ToUpper)
        comando.ExecuteNonQuery()

        comando = New OleDb.OleDbCommand("INSERT INTO Habitaciones(NumHabitacion, NumCamas, IDTipo)" & Chr(13) &
                                         "VALUES(txtbNumeroHabitacion, cmbNumeroCamas, cmbTipoHabitacion)", conexion)
        comando.Parameters.AddWithValue("@NumHabitacion", txtbNumeroHabitacion.Text.ToUpper)
        comando.Parameters.AddWithValue("@NumCamas", cmbNumeroCamas.Text.ToUpper)
        comando.Parameters.AddWithValue("@IDTipo", cmbTipoHabitacion.Text.ToUpper)
        comando.ExecuteNonQuery()

        MsgBox("Datos de la reserva guardados correctamente!!", MsgBoxStyle.Information, "Información")

        FormRecepcion.Show()
        Me.Hide()
    End Sub
End Class