Imports System.Data.OleDb

Public Class FormReservaHabitaciones2
    Dim tablaReservaHabitaciones As New DataTable
    Dim i As Integer = 0

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        If cmbPersonas.Text = "" And cmbTipoHabitacion.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf cmbPersonas.Text <> "" And cmbTipoHabitacion.Text <> "" Then
            i = i + 1
            txtbIDReserva.Text = CStr(i + 1)

            comando = New OleDbCommand("INSERT INTO Reservas(IDReserva, DNI, Fecha, CantPers, FechaInicio, FechaFin, NumHabitacion)" & Chr(13) &
                                        "VALUES(txtbIDReserva, txtbDNI, txtbFecha, cmbbPersonas, dtpInicio, dtpFin, txtbNumHabitacion)", conexion)
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
            comando.Parameters.AddWithValue("@IDTipo", cmbTipoHabitacion.Text.ToUpper)
            comando.ExecuteNonQuery()

            MsgBox("Datos de la reserva guardados correctamente!!", MsgBoxStyle.Information, "Información")
        End If

        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub txtbDNICliente_TextChanged(sender As Object, e As EventArgs) Handles txtbDNICliente.TextChanged
        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text
    End Sub

    Private Sub FormReservaHabitaciones2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = i + 1
        txtbIDReserva.Text = CStr(i + 1)

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