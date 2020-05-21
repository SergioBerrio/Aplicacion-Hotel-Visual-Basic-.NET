Imports System.Data.OleDb

Public Class FormHacerFacturas
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Facturas"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Facturas")
        adaptador2.Fill(registro2.Tables("Facturas"))
        dgvHacerFacturas.DataSource = registro2.Tables("Facturas")
        posicion = 0
        posicionFinal = registro2.Tables("Facturas").Rows.Count - 1
    End Sub

    Private Sub FormHacerFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.BdHotelDataSet11.Facturas)

        txtbDNICliente.Text = FormReservasClientes.txtbDNI.Text

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        txtbIDTrabajador.Text = Val(txtbIDTrabajador.Text) + 1

        txtbIDReserva.Text = Val(txtbIDReserva.Text) + 1

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub btnAgregarFactura_Click(sender As Object, e As EventArgs) Handles btnAgregarFactura.Click
        'dgvHacerFacturas.Rows.Add(txtbIDTrabajador.Text, txtbDNICliente.Text, txtbImporteTotal.Text, txtbFecha.Text)
        'txtbIDTrabajador.Text = ""
        'txtbDNICliente.Text = ""
        'txtbImporteTotal.Text = ""
        'txtbFecha.Text = ""

        'txtbIDTrabajador.Clear()
        'txtbDNICliente.Clear()
        'txtbImporteTotal.Clear()
        'txtbFecha.Clear()

        comando = New OleDbCommand("INSERT INTO Facturas(IDFactura, IDTrabajador, DNI, ImporteTotal, Fecha)" & Chr(13) &
                                         "VALUES(txtbIDFactura, txtbIDTrabajador, txtbDNICliente, txtbImporteTotal, txbFecha)", conexion)
        comando.Parameters.AddWithValue("@IDFactura", txtbIDReserva.Text)
        comando.Parameters.AddWithValue("@IDTrabajador", txtbIDTrabajador.Text)
        comando.Parameters.AddWithValue("@DNI", txtbDNICliente.Text)
        comando.Parameters.AddWithValue("@ImporteTotal", txtbImporteTotal.Text)
        comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text)
        comando.ExecuteNonQuery()
        conexion.Close()

        Me.FacturasTableAdapter.Fill(Me.BdHotelDataSet11.Facturas)

        MsgBox("Datos de los trabajadores almacenados correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub btnHacerFactura_Click(sender As Object, e As EventArgs) Handles btnHacerFactura.Click
        'FormPapelFactura.Show()
        'Me.Hide()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvHacerFacturas.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1
        Try
            If atras >= 0 Then
                dgvHacerFacturas.CurrentCell = dgvHacerFacturas.Rows(atras).Cells(0)
                dgvHacerFacturas.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Information, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvHacerFacturas.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1
        Try
            If dgvHacerFacturas.Rows.Count > siguiente Then
                dgvHacerFacturas.CurrentCell = dgvHacerFacturas.Rows(siguiente).Cells(0)
                dgvHacerFacturas.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Information, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub
End Class