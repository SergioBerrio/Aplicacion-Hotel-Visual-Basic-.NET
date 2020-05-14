Public Class FormReservaHabitaciones
    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        comando = New OleDb.OleDbCommand("INSERT INTO Reservas(IDReserva, DNI, Fecha, CantPers, FechaInicio, FechaFin, IDHabitacion)" & Chr(13) &
                                         "VALUES(txtbIDReserva, txtbDNI, txtbFecha, cmbbPersonas, dtpInicio, dtpFin, txtbFecha, txtbHabitacion)", conexion)
        comando.Parameters.AddWithValue("@IDReserva", txtbIDReserva.Text.ToUpper)
        comando.Parameters.AddWithValue("@DNI", txtbDNICliente.Text.ToUpper)
        comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text.ToUpper)
        comando.Parameters.AddWithValue("@CantPers", cmbPersonas.Text.ToUpper)
        comando.Parameters.AddWithValue("@FechaInicio", dtpInicio.Text.ToUpper)
        comando.Parameters.AddWithValue("@FechaFin", dtpFin.Text.ToUpper)
        comando.Parameters.AddWithValue("@IDHabitacion", txtbIDHabitacion.Text.ToUpper)
        comando.ExecuteNonQuery()
    End Sub

    Private Sub txtbDNICliente_TextChanged(sender As Object, e As EventArgs) Handles txtbDNICliente.TextChanged
        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text
    End Sub

    Private Sub FormReservaHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbIDReserva.Text = Val(txtbIDReserva.Text) + 1

        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text

        txtbIDHabitacion.Text = Val(txtbIDHabitacion.Text) + 1

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        cmbPersonas.Items.Add("1")
        cmbPersonas.Items.Add("2")
        cmbPersonas.Items.Add("3")
        cmbPersonas.Items.Add("4")
        cmbPersonas.Items.Add("5")
        cmbPersonas.Items.Add("6")
        cmbPersonas.Items.Add("7")
        cmbPersonas.Items.Add("8")
        cmbPersonas.Items.Add("9")
        cmbPersonas.Items.Add("10")
        cmbPersonas.Items.Add("11")
        cmbPersonas.Items.Add("12")
        cmbPersonas.Items.Add("13")
        cmbPersonas.Items.Add("14")
        cmbPersonas.Items.Add("15")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReservasClientes.Show()
        Me.Hide()
    End Sub
End Class