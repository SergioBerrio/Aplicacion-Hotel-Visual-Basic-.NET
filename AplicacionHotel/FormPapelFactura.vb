Imports System.Data.OleDb

Public Class FormPapelFactura
    Dim tablaFacturas As New DataTable
    Dim tablaTipoHabitaciones As New DataTable
    Dim i As Integer = 0

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        nudIVA.Text = Val(txtbImporte.Text) * 0.01

        txtbSubtotal.Text = Val(txtbImporte.Text) + Val(txtbImporteActividades.Text)

        txtbImporteTotal.Text = Val(txtbSubtotal.Text) + Val(nudIVA.Text)

        comando = New OleDbCommand("INSERT INTO Facturas(IDFactura, IDTrabajador, DNI, ImporteTotal, Fecha)" & Chr(13) &
                                           "VALUES(@IDFactura, @IDTrabajador, @DNI, @ImporteTotal, @Fecha)", conexion)
        comando.Parameters.AddWithValue("@IDFactura", i + 1)
        comando.Parameters.AddWithValue("@IDTrabajador", 1)
        comando.Parameters.AddWithValue("@DNI", txtbDNI.Text)
        comando.Parameters.AddWithValue("@ImporteTotal", txtbImporteTotal.Text)
        comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text)
        comando.ExecuteNonQuery()
        conexion.Close()

        txtbImporte.Clear()
        txtbImporteActividades.Clear()
        txtbSubtotal.Clear()
        txtbImporteTotal.Clear()

        MsgBox("El importe total de su estancia es de: " & txtbImporteTotal.Text & "€", MsgBoxStyle.Information, "Información")
        MsgBox("Importe de la factura cobrado correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub btnNuevaFactura_Click(sender As Object, e As EventArgs) Handles btnNuevaFactura.Click
        txtbImporte.Clear()
        txtbImporteActividades.Clear()
        txtbSubtotal.Clear()
        txtbImporteTotal.Clear()

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub FormPapelFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

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