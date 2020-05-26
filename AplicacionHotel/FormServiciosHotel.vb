Imports System.Data.OleDb

Public Class FormServiciosHotel
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim tabla As New DataTable
    Dim i As Integer = 3

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Servicios"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Servicios")
        adaptador2.Fill(registro2.Tables("Servicios"))
        dgvServicios.DataSource = registro2.Tables("Servicios")
        posicion = 0
        posicionFinal = registro2.Tables("Servicios").Rows.Count - 1
    End Sub

    Private Sub FormServiciosHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Servicios' Puede moverla o quitarla según sea necesario.
        'Me.ServiciosTableAdapter.Fill(Me.BdHotelDataSet11.Servicios)

        txtbIDServicio.Text = CStr(i + 1)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            Dim consulta As String = "SELECT IDServicios, Nombre FROM Servicios"
            Dim comando As New OleDbCommand(consulta, conexion)
            Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
            adaptadorTabla.Fill(tabla)
            cargarCombo()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarServicio_Click(sender As Object, e As EventArgs) Handles btnAgregarServicio.Click
        If cmbNombre.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf cmbNombre.Text = "" Then
            i = i + 1
            txtbIDServicio.Text = CStr(i + 1)

            conexion.Open()

            comando = New OleDbCommand("INSERT INTO Servicios(IDServicios, Nombre)" & Chr(13) &
                                             "VALUES(txtbIDServicios, cmbNombre)", conexion)
            comando.Parameters.AddWithValue("@IDServicios", txtbIDServicio.Text)
            comando.Parameters.AddWithValue("@Nombre", cmbNombre.Text)
            comando.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Datos de las actividades almacenadas correctamente!!")

            txtbIDServicio.Text = Val(txtbIDServicio.Text) + 1
        End If
    End Sub

    Private Sub btnEliminarServicio_Click(sender As Object, e As EventArgs) Handles btnEliminarServicio.Click
        dgvServicios.Rows.Remove(dgvServicios.CurrentRow)

        conexion.Open()

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Servicios WHERE IDServicios = " & txtbIDServicio.Text & ""
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub cargarCombo()
        cmbNombre.DataSource = tabla

        cmbNombre.DisplayMember = "Nombre"
        cmbNombre.ValueMember = "IDServicios"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscar.Text <> "" Then
            consulta = "SELECT * FROM Servicios WHERE IDServicios = " & txtbBuscar.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Servicios")
            registro = registro2.Tables("Servicios").Rows.Count

            If registro <> 0 Then
                dgvServicios.DataSource = registro2
                dgvServicios.DataMember = "Servicios"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvServicios.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvServicios.CurrentCell = dgvServicios.Rows(atras).Cells(0)
                dgvServicios.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvServicios.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvServicios.Rows.Count > siguiente Then
                dgvServicios.CurrentCell = dgvServicios.Rows(siguiente).Cells(0)
                dgvServicios.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refreshDatagrid()
    End Sub

    Private Sub refreshDatagrid()
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb")
        Dim ole As New OleDbCommand("SELECT * FROM Servicios ORDER BY IDServicios ASC", con)
        Dim ds As New DataSet
        Dim DataAdapter1 As New OleDbDataAdapter
        con.Open()
        DataAdapter1.SelectCommand = ole
        DataAdapter1.Fill(ds, "Servicios")
        dgvServicios.DataSource = ds
        dgvServicios.DataMember = "Servicios"
        con.Close()
    End Sub
End Class