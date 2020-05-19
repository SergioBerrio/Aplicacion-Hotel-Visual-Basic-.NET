Imports System.Data.OleDb

Public Class FormServicioMesaBarra
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Servicios"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Servicios")
        adaptador2.Fill(registro2.Tables("Servicios"))
        dgvActividades.DataSource = registro2.Tables("Servicios")
        posicion = 0
        posicionFinal = registro2.Tables("Servicios").Rows.Count - 1
    End Sub

    Private Sub FormServicioMesaBarra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.BDHotelDataSet.Servicios)

        txtbIDServicio.Text = Val(txtbIDServicio.Text) + 1

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            cargarCombo()

            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
            'CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnagregarServicio_Click(sender As Object, e As EventArgs) Handles btngregarServicio.Click
        'dgvActividades.Rows.Add(txtbIDServicios.Text, cmbNombre.Text)
        'txtbIDServicios.Text = ""
        'cmbNombre.Text = String.Empty

        'txtbIDServicios.Clear()

        comando = New OleDbCommand("INSERT INTO Actividades(IDServicios, Nombre)" & Chr(13) &
                                         "VALUES(txtIDServicios, cmbNombre)", conexion)
        comando.Parameters.AddWithValue("@IDServicios", txtbIDServicio.Text)
        comando.Parameters.AddWithValue("@Nombre", cmbNombreServicio.Text)
        comando.ExecuteNonQuery()
        conexion.Close()

        Me.ServiciosTableAdapter.Fill(Me.BDHotelDataSet.Servicios)

        MsgBox("Datos de las actividades almacenadas correctamente!!")
    End Sub

    Public Sub cargarCombo()
        Dim tabla As New DataTable
        Dim oleDb As String = "SELECT IDServicios, Nombre FROM Servicios"
        Dim adp As New OleDbDataAdapter(oleDb, conexion)
        adp.Fill(tabla)

        cmbNombreServicio.DataSource = tabla

        cmbNombreServicio.DisplayMember = "Nombre"
        cmbNombreServicio.ValueMember = "IDServicios"
    End Sub
End Class