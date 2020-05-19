Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class FormDarAltaTrabajadores
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
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
        Me.TrabajadoresTableAdapter.Fill(Me.BdHotelDataSet1.Trabajadores)

        txtbIDTrabajador.Text = Val(txtbIDTrabajador.Text) + 1

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            cargarCombo()

            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub btnDarAltaTrabajador_Click(sender As Object, e As EventArgs) Handles btnDarAltaTrabajador.Click
        'Dim tabla As New DataTable(txtbIDTrabajador.Text)
        'tabla.Rows.Add(cmbTipoTrabajador.Text)
        'tabla.Rows.Add(txtbNombre.Text)
        'dgvDarAltaTrabajadores.Rows.Add(tabla)

        BdHotelDataSet1.Trabajadores.Rows.Add(6, 4, "Pepe")
        txtbIDTrabajador.Text = ""
        cmbTipoTrabajador.Text = ""
        txtbNombre.Text = String.Empty

        txtbIDTrabajador.Clear()
        txtbNombre.Clear()

        comando = New OleDbCommand("INSERT INTO Trabajadores(IDTrabajador, IDTipoTrabajador, Nombre)" & Chr(13) &
                                         "VALUES(txtIDTrabajdor, cmbTipoTrabajador, txtbNombre)", conexion)
        comando.Parameters.AddWithValue("@IDTrabajador", txtbIDTrabajador.Text)
        comando.Parameters.AddWithValue("@IDTipoTrabajador", cmbTipoTrabajador.Text)
        comando.Parameters.AddWithValue("@Nombre", txtbNombre.Text)
        comando.ExecuteNonQuery()
        conexion.Close()

        Me.TrabajadoresTableAdapter.Fill(Me.BdHotelDataSet1.Trabajadores)

        MsgBox("Datos de los trabajadores almacenados correctamente!!", MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminarTrabajador_Click(sender As Object, e As EventArgs) Handles btnEliminarTrabajador.Click
        dgvDarAltaTrabajadores.Rows.Remove(dgvDarAltaTrabajadores.CurrentRow)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Trabajadores"
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Public Sub cargarCombo()
        Dim tabla As New DataTable
        Dim oleDb As String = "SELECT IDTipoTrabajador, Puesto FROM TipoTrabajador"
        Dim adp As New OleDbDataAdapter(oleDb, conexion)
        adp.Fill(tabla)

        cmbTipoTrabajador.DataSource = tabla

        cmbTipoTrabajador.DisplayMember = "Puesto"
        cmbTipoTrabajador.ValueMember = "IDTipoTrabajador"
    End Sub
End Class