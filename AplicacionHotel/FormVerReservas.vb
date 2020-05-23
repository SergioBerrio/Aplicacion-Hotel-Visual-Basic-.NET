Imports System.Data.OleDb

Public Class FormVerReservas
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim adaptador3 As New OleDbDataAdapter
    Dim registro3 As New DataSet

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Reservas"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Reservas")
        adaptador2.Fill(registro2.Tables("Reservas"))
        dgvVerReservas.DataSource = registro2.Tables("Reservas")
        posicion = 0
        posicionFinal = registro2.Tables("Reservas").Rows.Count - 1
    End Sub

    Private Sub FormVerReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Reservas' Puede moverla o quitarla según sea necesario.
        Me.ReservasTableAdapter.Fill(Me.BdHotelDataSet11.Reservas)

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

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormEntrada.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminarReservas_Click(sender As Object, e As EventArgs) Handles btnEliminarReservas.Click
        dgvVerReservas.Rows.Remove(dgvVerReservas.CurrentRow)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE FROM Reservas WHERE 'IDReserva = " & FormReservaHabitaciones.txtbIDReserva.Text & "'"
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Private Sub bnAnterior_Click(sender As Object, e As EventArgs) Handles bnAnterior.Click
        Dim actual As Integer = dgvVerReservas.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvVerReservas.CurrentCell = dgvVerReservas.Rows(atras).Cells(0)
                dgvVerReservas.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvVerReservas.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvVerReservas.Rows.Count > siguiente Then
                dgvVerReservas.CurrentCell = dgvVerReservas.Rows(siguiente).Cells(0)
                dgvVerReservas.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarID.Text <> "" Then
            consulta = "SELECT * FROM Reservas WHERE IDReserva = " & txtbBuscarID.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Reservas")
            registro = registro2.Tables("Reservas").Rows.Count
            txtbBuscarID.Clear()

            If registro <> 0 Then
                dgvVerReservas.DataSource = registro2
                dgvVerReservas.DataMember = "Reservas"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        ElseIf txtbBuscarID.Text = "" Then
            MsgBox("Inserta un valor", MsgBoxStyle.Critical, "Error")
        End If
        txtbBuscarID.Clear()
    End Sub

    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarDNI.Text <> "" Then
            consulta = "SELECT * FROM Reservas WHERE 'DNI = " & txtbBuscarDNI.Text & "'"
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Reservas")
            registro = registro2.Tables("Reservas").Rows.Count
            txtbBuscarDNI.Clear()

            If registro <> 0 Then
                dgvVerReservas.DataSource = registro2
                dgvVerReservas.DataMember = "Reservas"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        ElseIf txtbBuscarDNI.Text = "" Then
            MsgBox("Inserta un valor", MsgBoxStyle.Critical, "Error")
        End If
        txtbBuscarDNI.Clear()
    End Sub
End Class