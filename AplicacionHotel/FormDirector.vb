Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class FormDirector
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Trabajadores"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Trabajadores")
        adaptador2.Fill(registro2.Tables("Trabajadores"))
        dgvDarAltaTrabajadores.DataSource = registro2.Tables("Trabajadores")
        posicion = 0
        posicionFinal = registro2.Tables("Trabajadores").Rows.Count - 1
    End Sub
    Private Sub FormDirector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.BDHotelDataSet.Facturas)
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.Trabajadores' Puede moverla o quitarla según sea necesario.
        Me.TrabajadoresTableAdapter.Fill(Me.BDHotelDataSet.Trabajadores)

        cmbTipoTrabajador.Items.Add("Conserje")
        cmbTipoTrabajador.Items.Add("Recepcionista")
        cmbTipoTrabajador.Items.Add("Cocina")
        cmbTipoTrabajador.Items.Add("Animación")
        cmbTipoTrabajador.Items.Add("Socorrista")
        cmbTipoTrabajador.Items.Add("Personal de seguridad")
        cmbTipoTrabajador.Items.Add("Limpieza")
        cmbTipoTrabajador.Items.Add("Mantenimiento")
        cmbTipoTrabajador.Items.Add("Gobernanta")
        cmbTipoTrabajador.Items.Add("Camarera de habitación")
        cmbTipoTrabajador.Items.Add("Servicio de barra y mesa")

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub btnDarAltaTrabajador_Click(sender As Object, e As EventArgs) Handles btnDarAltaTrabajador.Click
        dgvDarAltaTrabajadores.Rows.Add(txtbIDTrabajador.Text, cmbTipoTrabajador.Text, txtbNombre.Text)
        txtbIDTrabajador.Text = ""
        cmbTipoTrabajador.Text = ""
        txtbNombre.Text = String.Empty

        txtbIDTrabajador.Clear()
        txtbNombre.Clear()

        comando = New OleDb.OleDbCommand("INSERT INTO Trabajadores(IDTrabajadores, IDTipoTrabajador, Nombre)" & Chr(13) &
                                         "VALUES(txtIDTrabajador, cmbTipoTrabajador, txtbNombre)", conexion)
        comando.Parameters.AddWithValue("@IDTrabajadores", txtbIDTrabajador.Text.ToUpper)
        comando.Parameters.AddWithValue("@IDTipoTrabajador", cmbTipoTrabajador.Text.ToUpper)
        comando.Parameters.AddWithValue("@Nombre", txtbNombre.Text.ToUpper)
        comando.ExecuteNonQuery()
        conexion.Close()

        MsgBox("Datos de los trabajadores almacenados correctamente!!")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminarTrabajador_Click(sender As Object, e As EventArgs) Handles btnEliminarTrabajador.Click
        dgvDarAltaTrabajadores.Rows.RemoveAt(fila)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Trabajadores"
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public fila As Integer

    Private Sub dgvDarAltaTrabajadores_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        fila = 0
        fila = dgvDarAltaTrabajadores.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub dgvDarAltaTrabajadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDarAltaTrabajadores.CellContentClick

    End Sub
End Class