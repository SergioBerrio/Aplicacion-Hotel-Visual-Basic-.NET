Imports System.Data.OleDb

Public Class FormDirector
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim tabla As New DataTable
    Dim i As Integer = 0

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Trabajadores ORDER BY IDTrabajador ASC"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Trabajadores")
        adaptador2.Fill(registro2.Tables("Trabajadores"))
        dgvTrabajadores.DataSource = registro2.Tables("Trabajadores")
        posicion = 0
        posicionFinal = registro2.Tables("Trabajadores").Rows.Count - 1
    End Sub

    Private Sub FormDarAltaTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Trabajadores' Puede moverla o quitarla según sea necesario.
        Me.TrabajadoresTableAdapter.Fill(Me.BdHotelDataSet11.Trabajadores)

        txtbIDTrabajador.Text = CStr(i + 1)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            Dim consulta As String = "SELECT Puesto FROM TipoTrabajador"
            Dim comando As New OleDbCommand(consulta, conexion)
            Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
            adaptadorTabla.Fill(tabla)
            cargarCombo()

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

    Private Sub btnDarAltaTrabajadores_Click(sender As Object, e As EventArgs) Handles btnDarAltaTrabajadores.Click
        If txtbNombre.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf txtbNombre.Text <> "" Then
            txtbNombre.Text = ""
            cmbPuesto.Text = String.Empty

            txtbNombre.Clear()

            i = i + 1
            txtbIDTrabajador.Text = CStr(i + 1)

            comando = New OleDbCommand("INSERT INTO Trabajadores(IDTrabajador, Puesto, Nombre)" & Chr(13) &
                                             "VALUES(txtIDTrabajador, cmbPuesto, txtNombre)", conexion)
            comando.Parameters.AddWithValue("@IDTrabajador", txtbIDTrabajador.Text)
            comando.Parameters.AddWithValue("@Puesto", cmbPuesto.Text)
            comando.Parameters.AddWithValue("@Nombre", txtbNombre.Text)
            comando.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Datos del trabajador almacenados correctamente!!", MsgBoxStyle.Information, "Información")
        End If
    End Sub

    Private Sub btnEliminarTrabajador_Click(sender As Object, e As EventArgs) Handles btnEliminarTrabajador.Click
        dgvTrabajadores.Rows.Remove(dgvTrabajadores.CurrentRow)

        conexion.Open()

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE FROM Trabajadores WHERE 'IDTrabajador = " & txtbIDTrabajador.Text & "'"
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub cargarCombo()
        cmbPuesto.DataSource = tabla

        cmbPuesto.DisplayMember = "Puesto"
        cmbPuesto.ValueMember = "Puesto"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscar.Text <> "" Then
            consulta = "SELECT * FROM Trabajadores WHERE IDTrabajador = " & txtbBuscar.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Trabajadores")
            registro = registro2.Tables("Trabajadores").Rows.Count

            If registro <> 0 Then
                dgvTrabajadores.DataSource = registro2
                dgvTrabajadores.DataMember = "Trabajadores"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        ElseIf txtbBuscar.Text = "" Then
            MsgBox("Inserta un valor", MsgBoxStyle.Critical, "Error")
        End If
        txtbBuscar.Clear()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvTrabajadores.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvTrabajadores.CurrentCell = dgvTrabajadores.Rows(atras).Cells(0)
                dgvTrabajadores.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvTrabajadores.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvTrabajadores.Rows.Count > siguiente Then
                dgvTrabajadores.CurrentCell = dgvTrabajadores.Rows(siguiente).Cells(0)
                dgvTrabajadores.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarDatagrid()
    End Sub

    Private Sub actualizarDatagrid()
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb")
        Dim ole As New OleDbCommand("SELECT * FROM Trabajadores ORDER BY IDTrabajador ASC", con)
        Dim ds As New DataSet
        Dim DataAdapter1 As New OleDbDataAdapter
        con.Open()
        DataAdapter1.SelectCommand = ole
        DataAdapter1.Fill(ds, "Trabajadores")
        dgvTrabajadores.DataSource = ds
        dgvTrabajadores.DataMember = "Trabajadores"
        con.Close()
    End Sub
End Class