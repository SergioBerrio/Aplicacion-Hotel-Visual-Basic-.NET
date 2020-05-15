Imports System.Data.OleDb

Public Class FormVerClientes
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Clientes"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Clientes")
        adaptador2.Fill(registro2.Tables("Clientes"))
        dgvClientes.DataSource = registro2.Tables("Clientes")
        posicion = 0
        posicionFinal = registro2.Tables("Clientes").Rows.Count - 1
    End Sub

    Private Sub FormVerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDHotelDataSet1.Clientes)
        Me.ClientesTableAdapter.Fill(Me.BDHotelDataSet.Clientes)
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "información")
            CargarDatosDataGridView()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvClientes.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1
        Try
            If atras >= 0 Then
                dgvClientes.CurrentCell = dgvClientes.Rows(atras).Cells(0)
                dgvClientes.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", , "Mensaje de advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvClientes.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1
        Try
            If dgvClientes.Rows.Count > siguiente Then
                dgvClientes.CurrentCell = dgvClientes.Rows(siguiente).Cells(0)
                dgvClientes.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", , "Mensaje de advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarClientes_Click(sender As Object, e As EventArgs) Handles btnEliminarClientes.Click
        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Clientes WHERE IDReserva = " & FormReservaHabitaciones.txtbDNICliente.Text & ""
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()

        If dgvClientes.Rows.Count > 0 Then
            dgvClientes.Rows.RemoveAt(dgvClientes.CurrentRow.Index)
        End If
    End Sub
End Class