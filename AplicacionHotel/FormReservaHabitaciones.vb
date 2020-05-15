Public Class FormReservaHabitaciones
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

        MsgBox("Datos de la reserva guardados correctamente!!")
    End Sub

    Private Sub txtbDNICliente_TextChanged(sender As Object, e As EventArgs) Handles txtbDNICliente.TextChanged
        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text
    End Sub

    Private Sub FormReservaHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbIDReserva.Text = Val(txtbIDReserva.Text) + 1

        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text

        txtbIDHabitacion.Text = Val(txtbIDHabitacion.Text) + 1

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        cmbPersonas.Items.Add("1 persona")
        cmbPersonas.Items.Add("2 personas")
        cmbPersonas.Items.Add("3 personas")
        cmbPersonas.Items.Add("4 personas")
        cmbPersonas.Items.Add("5 personas")
        cmbPersonas.Items.Add("6 personas")
        cmbPersonas.Items.Add("7 personas")
        cmbPersonas.Items.Add("8 personas")
        cmbPersonas.Items.Add("9 personas")
        cmbPersonas.Items.Add("10 personas")
        cmbPersonas.Items.Add("11 personas")
        cmbPersonas.Items.Add("12 personas")
        cmbPersonas.Items.Add("13 personas")
        cmbPersonas.Items.Add("14 personas")
        cmbPersonas.Items.Add("15 personas")

        cmbNumeroCamas.Items.Add("1")
        cmbNumeroCamas.Items.Add("2")
        cmbNumeroCamas.Items.Add("3")

        cmbTipoHabitacion.Items.Add("Estándar")
        cmbTipoHabitacion.Items.Add("Suite presidencial")
        cmbTipoHabitacion.Items.Add("Suite Luxury")
        cmbTipoHabitacion.Items.Add("Master Suite")
        cmbTipoHabitacion.Items.Add("Suite nupcial")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReservasClientes.Show()
        Me.Hide()
    End Sub

    Private Sub txtbNumeroHabitacion_TextChanged(sender As Object, e As EventArgs) Handles txtbNumeroHabitacion.TextChanged
        txtbNumeroHabitacion.Text = Val(txtbNumeroHabitacion.Text) + 1
    End Sub
End Class