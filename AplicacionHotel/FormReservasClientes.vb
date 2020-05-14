﻿Public Class FormReservasClientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comando = New OleDb.OleDbCommand("INSERT INTO Clientes(DNI, Nombre, Apellidos, Telefono, Email)" & Chr(13) &
                                         "VALUES(txtbDNI, txtbNombre, txtbApellidos, txtbTelefono, txtbEmail)", conexion)
        comando.Parameters.AddWithValue("@DNI", txtbDNI.Text.ToUpper)
        comando.Parameters.AddWithValue("@Nombre", txtbNombre.Text.ToUpper)
        comando.Parameters.AddWithValue("@Apellidos", txtbApellidos.Text.ToUpper)
        comando.Parameters.AddWithValue("@Telefono", txtbTelefono.Text.ToUpper)
        comando.Parameters.AddWithValue("@Email", txtbEmail.Text.ToUpper)
        'comando.ExecuteNonQuery()

        FormReservaHabitaciones.Show()
        Me.Hide()
    End Sub
End Class