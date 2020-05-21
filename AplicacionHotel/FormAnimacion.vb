Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Public Class FormAnimacion
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim tabla As New DataTable

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Actividades"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Actividades")
        adaptador2.Fill(registro2.Tables("Actividades"))
        dgvActividades.DataSource = registro2.Tables("Actividades")
        posicion = 0
        posicionFinal = registro2.Tables("Actividades").Rows.Count - 1
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub FormAnimacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Actividades' Puede moverla o quitarla según sea necesario.
        Me.ActividadesTableAdapter1.Fill(Me.BdHotelDataSet11.Actividades)

        txtbIDActividad.Text = Val(txtbIDActividad.Text) + 1

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            Dim consulta As String = "SELECT IDActividades, Nombre, ImporteActividad FROM Actividades"
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

    Private Sub btnAgregarActividad_Click(sender As Object, e As EventArgs) Handles btnAgregarActividad.Click
        'dgvActividades.Rows.Add(txtbIDActividad.Text, txtbImporte.Text, cmbNombre.Text)
        'txtbIDActividad.Text = ""
        'txtbImporte.Text = ""
        'cmbNombre.Text = String.Empty

        'txtbIDActividad.Clear()
        'txtbImporte.Clear()

        comando = New OleDbCommand("INSERT INTO Actividades(IDActividades, Nombre, ImporteActividad)" & Chr(13) &
                                         "VALUES(txtIDActividad, cmbNombre, txtImporte)", conexion)
        comando.Parameters.AddWithValue("@IDActividades", txtbIDActividad.Text)
        comando.Parameters.AddWithValue("@Nombre", cmbNombre.Text)
        comando.Parameters.AddWithValue("@ImporteActividad", txtbImporte.Text)
        comando.ExecuteNonQuery()
        conexion.Close()

        MsgBox("Datos de las actividades almacenadas correctamente!!")
    End Sub

    Private Sub btnEliminarActividad_Click(sender As Object, e As EventArgs) Handles btnEliminarActividad.Click
        dgvActividades.Rows.Remove(dgvActividades.CurrentRow)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Actividades WHERE IDActividades = " & txtbIDActividad.Text & ""
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub cargarCombo()
        cmbNombre.DataSource = tabla

        cmbNombre.DisplayMember = "Nombre"
        cmbNombre.ValueMember = "IDActividades"
    End Sub

    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        Dim precio = tabla.Rows(cmbNombre.SelectedIndex)("ImporteActividad")
        txtbImporte.Text = precio
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscar.Text <> "" Then
            consulta = "SELECT * FROM Actividades WHERE IDActividades = " & txtbBuscar.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Actividades")
            registro = registro2.Tables("Actividades").Rows.Count

            If registro <> 0 Then
                dgvActividades.DataSource = registro2
                dgvActividades.DataMember = "Actividades"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvActividades.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvActividades.Rows.Count > siguiente Then
                dgvActividades.CurrentCell = dgvActividades.Rows(siguiente).Cells(0)
                dgvActividades.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvActividades.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvActividades.CurrentCell = dgvActividades.Rows(atras).Cells(0)
                dgvActividades.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub
End Class