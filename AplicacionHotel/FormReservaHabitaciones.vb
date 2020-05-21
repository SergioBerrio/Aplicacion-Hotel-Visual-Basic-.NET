Imports System.Data.OleDb

Public Class FormReservaHabitaciones
    Dim tablaReservaHabitaciones As New DataTable

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        comando = New OleDbCommand("INSERT INTO Reservas(IDReserva, DNI, Fecha, CantPers, FechaInicio, FechaFin, NumHabitacion)" & Chr(13) &
                                         "VALUES(txtbIDReserva, txtbDNI, txtbFecha, cmbPersonas, dtpInicio, dtpFin, txtbFecha, txtbNumHabitacion)", conexion)
        comando.Parameters.AddWithValue("@IDReserva", txtbIDReserva.Text.ToUpper)
        comando.Parameters.AddWithValue("@DNI", txtbDNICliente.Text.ToUpper)
        comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text.ToUpper)
        comando.Parameters.AddWithValue("@CantPers", cmbPersonas.Text.ToUpper)
        comando.Parameters.AddWithValue("@FechaInicio", dtpInicio.Text.ToUpper)
        comando.Parameters.AddWithValue("@FechaFin", dtpFin.Text.ToUpper)
        comando.Parameters.AddWithValue("@NumHabitacion", txtbNumeroHabitacion.Text.ToUpper)
        comando.ExecuteNonQuery()

        comando = New OleDbCommand("INSERT INTO Habitaciones(NumHabitacion, NumCamas, IDTipo)" & Chr(13) &
                                         "VALUES(txtbNumeroHabitacion, txtbNumeroCamas, cmbTipoHabitacion)", conexion)
        comando.Parameters.AddWithValue("@NumHabitacion", txtbNumeroHabitacion.Text.ToUpper)
        comando.Parameters.AddWithValue("@NumCamas", txtbNumeroCamas.Text.ToUpper)

        comando = New OleDbCommand("INSERT INTO TipoHabitacion(IDTipo, Tipo)" & Chr(13) &
                                         "VALUES(, cmbTipoHabitacion)", conexion)
        comando.Parameters.AddWithValue("@Tipo", cmbTipoHabitacion.Text.ToUpper)
        comando.ExecuteNonQuery()

        MsgBox("Datos de la reserva guardados correctamente!!", MsgBoxStyle.Information, "Información")

        FormEntrada.Show()
        Me.Hide()
    End Sub

    Private Sub txtbDNICliente_TextChanged(sender As Object, e As EventArgs) Handles txtbDNICliente.TextChanged
        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text
    End Sub

    Private Sub FormReservaHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbIDReserva.Text = Val(txtbIDReserva.Text) + 1

        txtbNumeroHabitacion.Text = Val(txtbNumeroHabitacion.Text) + 1

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text

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

        Dim consulta As String = "SELECT NumHabitacion, Tipo, NumCamas FROM Habitaciones"
        Dim comando As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tablaReservaHabitaciones)
        cargarComboTipoHabitacion()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormReservasClientes.Show()
        Me.Hide()
    End Sub

    Public Sub cargarComboTipoHabitacion()
        cmbTipoHabitacion.DataSource = tablaReservaHabitaciones

        cmbTipoHabitacion.DisplayMember = "Tipo"
        cmbTipoHabitacion.ValueMember = "Tipo"
    End Sub

    Private Sub cmbTipoHabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoHabitacion.SelectedIndexChanged
        Dim camas = tablaReservaHabitaciones.Rows(cmbTipoHabitacion.SelectedIndex)("NumCamas")
        'Console.WriteLine(camas)
        txtbNumeroCamas.Text = camas
    End Sub
End Class