Imports System.Data.OleDb

Public Class FormLimpieza
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Habitaciones"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Habitaciones")
        adaptador2.Fill(registro2.Tables("Habitaciones"))
        dgvLimpieza.DataSource = registro2.Tables("Habitaciones")
        posicion = 0
        posicionFinal = registro2.Tables("Habitaciones").Rows.Count - 1
    End Sub

    Private Sub FormLimpieza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Habitaciones' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesTableAdapter.Fill(Me.BdHotelDataSet11.Habitaciones)

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
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvLimpieza.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvLimpieza.CurrentCell = dgvLimpieza.Rows(atras).Cells(0)
                dgvLimpieza.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvLimpieza.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvLimpieza.Rows.Count > siguiente Then
                dgvLimpieza.CurrentCell = dgvLimpieza.Rows(siguiente).Cells(0)
                dgvLimpieza.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarNumero_Click(sender As Object, e As EventArgs) Handles btnBuscarNumero.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarNumero.Text <> "" Then
            consulta = "SELECT * FROM Habitaciones WHERE NumHabitacion = " & txtbBuscarNumero.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Habitaciones")
            registro = registro2.Tables("Habitaciones").Rows.Count

            If registro <> 0 Then
                dgvLimpieza.DataSource = registro2
                dgvLimpieza.DataMember = "Habitaciones"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub btnBuscarTipo_Click(sender As Object, e As EventArgs) Handles btnBuscarTipo.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarTipo.Text <> "" Then
            consulta = "SELECT * FROM Habitaciones WHERE Tipo = " & txtbBuscarTipo.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Habitaciones")
            registro = registro2.Tables("Habitaciones").Rows.Count

            If registro <> 0 Then
                dgvLimpieza.DataSource = registro2
                dgvLimpieza.DataMember = "Habitaciones"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub
End Class