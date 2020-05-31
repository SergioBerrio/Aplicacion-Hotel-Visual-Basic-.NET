Imports System.Data.OleDb

Public Class FormReservaHabitaciones
    Dim tablaReservaHabitaciones As New DataTable
    Dim i As Integer = 0

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        If cmbPersonas.Text = "" And cmbTipoHabitacion.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf cmbPersonas.Text <> "" And cmbTipoHabitacion.Text <> "" Then
            txtbDNICliente.Clear()

            i = i + 1
            txtbIDReserva.Text = CStr(i + 1)

            comando = New OleDbCommand("INSERT INTO Reservas(IDReserva, DNI, Fecha, CantPers, FechaInicio, FechaFin, NumHabitacion)" & Chr(13) &
                                         "VALUES(@IDReserva, @DNI, @Fecha, @CantPers, @FechaInicio, @FechaFin, @NumHabitacion)", conexion)
            comando.Parameters.AddWithValue("@IDReserva", txtbIDReserva.Text)
            comando.Parameters.AddWithValue("@DNI", txtbDNICliente.Text)
            comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text)
            comando.Parameters.AddWithValue("@CantPers", cmbPersonas.Text)
            comando.Parameters.AddWithValue("@FechaInicio", dtpInicio.Text)
            comando.Parameters.AddWithValue("@FechaFin", dtpFin.Text)
            comando.Parameters.AddWithValue("@NumHabitacion", txtbNumeroHabitacion.Text)
            comando.ExecuteNonQuery()

            comando = New OleDbCommand("INSERT INTO Habitaciones(NumHabitacion, IDTipo, NumCamas)" & Chr(13) &
                                             "VALUES(@NumHabitacion, @TipoHabitacion, @NumCamas)", conexion)
            comando.Parameters.AddWithValue("@NumHabitacion", txtbNumeroHabitacion.Text)
            comando.Parameters.AddWithValue("@TipoHabitacion", cmbTipoHabitacion.Text)
            comando.Parameters.AddWithValue("@NumCamas", txtbNumeroCamas.Text)
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

        cmbPersonas.Items.Add(1)
        cmbPersonas.Items.Add(2)
        cmbPersonas.Items.Add(3)
        cmbPersonas.Items.Add(4)
        cmbPersonas.Items.Add(5)
        cmbPersonas.Items.Add(6)
        cmbPersonas.Items.Add(7)
        cmbPersonas.Items.Add(8)
        cmbPersonas.Items.Add(9)
        cmbPersonas.Items.Add(10)

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
        cmbTipoHabitacion.ValueMember = "NumHabitacion"
    End Sub

    Private Sub cmbTipoHabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoHabitacion.SelectedIndexChanged
        Dim camas = tablaReservaHabitaciones.Rows(cmbTipoHabitacion.SelectedIndex)("NumCamas")
        txtbNumeroCamas.Text = camas
    End Sub
End Class