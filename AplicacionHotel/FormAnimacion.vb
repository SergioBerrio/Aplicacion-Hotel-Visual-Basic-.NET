Imports System.Data.OleDb

Public Class FormAnimacion
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet

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
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet1.Actividades' Puede moverla o quitarla según sea necesario.
        Me.ActividadesTableAdapter1.Fill(Me.BdHotelDataSet1.Actividades)

        txtbIDActividad.Text = Val(txtbIDActividad.Text) + 1

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            cargarCombo()
            cargarImporte()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
            'CargarDatosDataGridView()
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
                                         "VALUES(txtIDActividad, cmbNombre, txtImporteActividad)", conexion)
        comando.Parameters.AddWithValue("@IDActividades", txtbIDActividad.Text)
        comando.Parameters.AddWithValue("@Nombre", cmbNombre.Text)
        comando.Parameters.AddWithValue("@ImporteActividad", cmbImporte.Text)
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
        Dim tabla As New DataTable
        Dim consulta As String = "SELECT IDActividades, Nombre FROM Actividades"
        Dim comando As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tabla)

        cmbNombre.DataSource = tabla

        cmbNombre.DisplayMember = "Nombre"
        cmbNombre.ValueMember = "IDActividades"
    End Sub

    Public Sub cargarImporte()
        Dim tabla As New DataTable
        Dim consulta As String = "SELECT IDActividades, ImporteActividad FROM Actividades"
        Dim comando As New OleDbCommand(consulta, conexion)
        Dim adaptadorTabla As New OleDbDataAdapter(consulta, conexion)
        adaptadorTabla.Fill(tabla)

        cmbImporte.DataSource = tabla

        cmbImporte.DisplayMember = "ImporteActividad"
        cmbImporte.ValueMember = "IDActividades"
    End Sub
End Class