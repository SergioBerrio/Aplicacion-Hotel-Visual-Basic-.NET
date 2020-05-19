Imports System.Data.OleDb

Public Class FormVerFacturas
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Facturas"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Facturas")
        adaptador2.Fill(registro2.Tables("Facturas"))
        dgvFacturas.DataSource = registro2.Tables("Facturas")
        posicion = 0
        posicionFinal = registro2.Tables("Facturas").Rows.Count - 1
    End Sub

    Private Sub FormVerFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet2.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter1.Fill(Me.BDHotelDataSet2.Facturas)

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
        Dim actual As Integer = dgvFacturas.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1
        Try
            If atras >= 0 Then
                dgvFacturas.CurrentCell = dgvFacturas.Rows(atras).Cells(0)
                dgvFacturas.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", , "Mensaje de advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvFacturas.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1
        Try
            If dgvFacturas.Rows.Count > siguiente Then
                dgvFacturas.CurrentCell = dgvFacturas.Rows(siguiente).Cells(0)
                dgvFacturas.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", , "Mensaje de advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarFactura_Click(sender As Object, e As EventArgs) Handles btnEliminarReserva.Click
        dgvFacturas.Rows.Remove(dgvFacturas.CurrentRow)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE * FROM Facturas WHERE IDFactura = " & FormHacerFacturas.txtbIDTrabajador.Text & ""
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()
    End Sub
End Class