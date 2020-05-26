Imports System.Data.OleDb

Public Class FormReservaHabitaciones
    Dim tablaReservaHabitaciones As New DataTable

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        If cmbPersonas.Text = "" And cmbTipoHabitacion.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf cmbPersonas.Text <> "" And cmbTipoHabitacion.Text <> "" Then
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
        End If

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

        Dim consulta As String = "SELECT NumHabitacion, Tipo, NumCamas FROM Habitaciones"
        Dim comando As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tablaReservaHabitaciones)
        cargarNumeroCamas()

        Dim consulta2 As String = "SELECT NumHabitacion, Tipo, NumCamas FROM Habitaciones"
        Dim comando2 As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla2 As New OleDbDataAdapter(consulta, conexion)
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

    Public Sub cargarNumeroCamas()
        cmbTipoHabitacion.DataSource = tablaReservaHabitaciones

        cmbTipoHabitacion.DisplayMember = "Tipo"
        cmbTipoHabitacion.ValueMember = "NumCamas"
    End Sub

    Private Sub cmbTipoHabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoHabitacion.SelectedIndexChanged
        Dim camas = tablaReservaHabitaciones.Rows(cmbTipoHabitacion.SelectedIndex)("NumCamas")
        'Console.WriteLine(camas)
        txtbNumeroCamas.Text = camas
    End Sub
End Class