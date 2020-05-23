Imports System.Data.OleDb

Public Class FormGobernanta
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim Limpieza As New DataTable

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Trabajadores WHERE Puesto = 'Limpieza' ORDER BY IDTrabajador ASC"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Trabajadores")
        adaptador2.Fill(registro2.Tables("Trabajadores"))
        dgvLimpieza.DataSource = registro2.Tables("Trabajadores")
        posicion = 0
        posicionFinal = registro2.Tables("Trabajadores").Rows.Count - 1
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub FormGobernanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Trabajadores' Puede moverla o quitarla según sea necesario.
        Me.TrabajadoresTableAdapter.Fill(Me.BdHotelDataSet11.Trabajadores)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBuscarPuesto_Click(sender As Object, e As EventArgs) Handles btnBuscarPuesto.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarPuesto.Text <> "" Then
            consulta = "SELECT * FROM Trabajadores WHERE Puesto = " & txtbBuscarPuesto.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Trabajadores")
            registro = registro2.Tables("Trabajadores").Rows.Count

            If registro <> 0 Then
                dgvLimpieza.DataSource = registro2
                dgvLimpieza.DataMember = "Trabajadores"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
        txtbBuscarPuesto.Clear()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        refreshDatagrid()
    End Sub

    Private Sub refreshDatagrid()
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb")
        Dim ole As New OleDbCommand("SELECT * FROM Trabajadores WHERE Puesto = 'Limpieza' ORDER BY IDTrabajador ASC", con)
        Dim ds As New DataSet
        Dim DataAdapter1 As New OleDbDataAdapter
        con.Open()
        DataAdapter1.SelectCommand = ole
        DataAdapter1.Fill(ds, "Trabajadores")
        dgvLimpieza.DataSource = ds
        dgvLimpieza.DataMember = "Trabajadores"
        con.Close()
    End Sub
End Class