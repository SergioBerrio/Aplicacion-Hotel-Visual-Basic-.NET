Imports System.Data.OleDb

Public Class FormPapelFactura
    Dim tablaFacturas As New DataTable
    Dim tablaHabitaciones As New DataTable
    Dim tablaReservas As New DataTable

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormHacerFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        txtbSubtotal.Text = Val(txtbImporte.Text) + Val(txtbImporteActividades.Text)

        txtbIVA.Text = Val(txtbImporte.Text) * 0.01

        txbImporteTotal.Text = Val(txtbSubtotal.Text) + Val(txtbIVA.Text)

        MsgBox("El importe total de su estancia es de: " & txbImporteTotal.Text & "€", MsgBoxStyle.Information, "Información")
        MsgBox("Importe de la factura cobrado correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub btnNuevaFactura_Click(sender As Object, e As EventArgs) Handles btnNuevaFactura.Click
        txtbDNI.Clear()
        txtbFecha.Clear()
        txtbImporte.Clear()
        txtbImporteActividades.Clear()
        txtbIVA.Clear()
        txtbSubtotal.Clear()
        txtbPersonas.Clear()
        txbImporteTotal.Clear()

        'comando = New OleDbCommand("INSERT INTO Facturas(IDFactura, IDTrabajador, DNI, ImporteTotal, Fecha)" & Chr(13) &
        '                                   "VALUES(txtbIDFactura, txtbIDTrabajador, txtbDNICliente, txtbImporteTotal, txbFecha)", conexion)
        'comando.Parameters.AddWithValue("@IDFactura", txtbIDReserva.Text)
        'comando.Parameters.AddWithValue("@IDTrabajador", txtbIDTrabajador.Text)
        'comando.Parameters.AddWithValue("@DNI", txtbDNI.Text)
        'comando.Parameters.AddWithValue("@ImporteTotal", txbImporteTotal.Text)
        'comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text)
        'comando.ExecuteNonQuery()
        'conexion.Close()

        MsgBox("Datos de la factura almacenados correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub FormPapelFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Dim consulta As String = "SELECT DNI, Nombre, Apellidos, Telefono, Email FROM Clientes"
        Dim comando As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tablaFacturas)
        cargarComboCliente()

        Dim consulta2 As String = "SELECT Tipo FROM TipoHabitacion"
        Dim comando2 As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla2 As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tablaHabitaciones)

        Dim consulta23 As String = "SELECT IDReserva, DNI, Fecha, CantPersonas, FechaInicio, FechaFin, NumHabitacion FROM Reservas"
        Dim comando3 As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla3 As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tablaReservas)
    End Sub

    Public Sub cargarComboCliente()
        cmbClientes.DataSource = tablaFacturas

        cmbClientes.DisplayMember = "Nombre"
        cmbClientes.ValueMember = "DNI"
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        Dim DNI = tablaFacturas.Rows(cmbClientes.SelectedIndex)("DNI")
        txtbDNI.Text = DNI

        'Dim habitacion = tablaHabitaciones.Rows(cmbClientes.SelectedIndex)("Tipo")
        'txtbTipoHabitacion.Text = habitacion

        'Dim personas = tablaReservas.Rows(cmbClientes.SelectedIndex)("CantPersonas")
        'txtbPersonas.Text = personas
    End Sub
End Class