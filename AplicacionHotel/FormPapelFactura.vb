Imports System.Data.OleDb

Public Class FormPapelFactura
    Dim tablaFacturas As New DataTable
    Dim tablaTipoHabitaciones As New DataTable

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormHacerFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        txtbSubtotal.Text = Val(txtbImporte.Text) + Val(txtbImporteActividades.Text)

        nudIVA.Text = Val(txtbImporte.Text) * 0.01

        txbImporteTotal.Text = Val(txtbSubtotal.Text) + Val(nudIVA.Text)

        MsgBox("El importe total de su estancia es de: " & txbImporteTotal.Text & "€", MsgBoxStyle.Information, "Información")
        MsgBox("Importe de la factura cobrado correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub btnNuevaFactura_Click(sender As Object, e As EventArgs) Handles btnNuevaFactura.Click
        txtbImporte.Clear()
        txtbImporteActividades.Clear()
        txtbSubtotal.Clear()
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

        nudIVA.Text = "10%"

        'cmbNumeroPersonas.Items.Add("1 persona")
        'cmbNumeroPersonas.Items.Add("2 personas")
        'cmbNumeroPersonas.Items.Add("3 personas")
        'cmbNumeroPersonas.Items.Add("4 personas")
        'cmbNumeroPersonas.Items.Add("5 personas")
        'cmbNumeroPersonas.Items.Add("6 personas")
        'cmbNumeroPersonas.Items.Add("7 personas")
        'cmbNumeroPersonas.Items.Add("8 personas")
        'cmbNumeroPersonas.Items.Add("9 personas")
        'cmbNumeroPersonas.Items.Add("10 personas")

        Dim consulta As String = "SELECT DNI, Nombre, Apellidos, Telefono, Email FROM Clientes"
        Dim comando As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tablaFacturas)
        cargarComboCliente()

        Dim consulta2 As String = "SELECT Tipo FROM TipoHabitacion"
        Dim comando2 As New OleDbCommand(consulta2, conexion)
        Dim adaptadorTabla2 As New OleDbDataAdapter(consulta2, conexion)
        adaptadorTabla2.Fill(tablaTipoHabitaciones)
        cargarComboTipoHabitacion()
    End Sub

    Public Sub cargarComboCliente()
        cmbClientes.DataSource = tablaFacturas

        cmbClientes.DisplayMember = "Nombre"
        cmbClientes.ValueMember = "DNI"
    End Sub

    Public Sub cargarComboTipoHabitacion()
        cmbTipoHabitacion.DataSource = tablaTipoHabitaciones

        cmbTipoHabitacion.DisplayMember = "Tipo"
        cmbTipoHabitacion.ValueMember = "Tipo"
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        Dim DNI = tablaFacturas.Rows(cmbClientes.SelectedIndex)("DNI")
        txtbDNI.Text = DNI
    End Sub

    Private Sub btnVerFacturas_Click(sender As Object, e As EventArgs) Handles btnVerFacturas.Click
        FormVerReservas3.Show()
        Me.Hide()
    End Sub
End Class