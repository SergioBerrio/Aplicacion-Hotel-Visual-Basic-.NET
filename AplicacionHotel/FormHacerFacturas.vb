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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnHacerFactura_Click(sender As Object, e As EventArgs) Handles btnHacerFactura.Click
        'FormPapelFactura.Show()
        'Me.Hide()
    End Sub

    Private Sub FormHacerFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.BDHotelDataSet.Facturas)

        txtbDNI.Text = FormReservasClientes.txtbDNI.Text

        txtbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        txtbIDTrabajador.Text = Val(txtbIDTrabajador.Text) + 1

        txtbIDFactura.Text = Val(txtbIDFactura.Text) + 1

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub btnAñadirFactura_Click(sender As Object, e As EventArgs) Handles btnAñadirFactura.Click
        dgvHacerFacturas.Rows.Add(txtbIDTrabajador.Text, txtbDNI.Text, txtbImporteTotal.Text, txtbFecha.Text)
        txtbIDTrabajador.Text = ""
        txtbDNI.Text = ""
        txtbImporteTotal.Text = ""
        txtbFecha.Text = ""

        txtbIDTrabajador.Clear()
        txtbDNI.Clear()
        txtbImporteTotal.Clear()
        txtbFecha.Clear()

        comando = New OleDb.OleDbCommand("INSERT INTO Facturas(IDFactura, IDTrabajdor, DNI, ImporteTotal, Fecha)" & Chr(13) &
                                         "VALUES(txtbIDFactura, txtbIDTrabajador, txtbDNI, txtbImporteTotal, txbFecha)", conexion)
        comando.Parameters.AddWithValue("@IDFactura", txtbIDFactura.Text)
        comando.Parameters.AddWithValue("@IDTrabajdor", txtbIDTrabajador.Text)
        comando.Parameters.AddWithValue("@DNI", txtbDNI.Text)
        comando.Parameters.AddWithValue("@ImporteTotal", txtbImporteTotal.Text)
        comando.Parameters.AddWithValue("@Fecha", txtbFecha.Text)
        comando.ExecuteNonQuery()
        conexion.Close()

        Me.FacturasTableAdapter.Fill(Me.BDHotelDataSet.Facturas)

        MsgBox("Datos de los trabajadores almacenados correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub
End Class