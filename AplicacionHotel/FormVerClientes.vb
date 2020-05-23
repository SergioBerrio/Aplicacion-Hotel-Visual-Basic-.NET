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
        FormRecepcion.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminarClientes_Click(sender As Object, e As EventArgs) Handles btnEliminarClientes.Click
        dgvClientes.Rows.Remove(dgvClientes.CurrentRow)

        Dim eliminarRegistro As String
        eliminarRegistro = "DELETE FROM Clientes WHERE DNI = " & FormReservasClientes.txtbDNI.Text & ""
        comando = New OleDbCommand(eliminarRegistro, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Private Sub btnCrearClientes_Click(sender As Object, e As EventArgs) Handles btnCrearClientes.Click
        FormReservasClientes2.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarDNI.Text <> "" Then
            consulta = "SELECT * FROM Clientes WHERE 'DNI = " & txtbBuscarDNI.Text & "'"
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Clientes")
            registro = registro2.Tables("Clientes").Rows.Count

            If registro <> 0 Then
                dgvClientes.DataSource = registro2
                dgvClientes.DataMember = "Clientes"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub btnBuscarNombre_Click(sender As Object, e As EventArgs) Handles btnBuscarNombre.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarNombre.Text <> "" Then
            consulta = "SELECT * FROM Clientes WHERE Nombre = " & txtbBuscarNombre.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Clientes")
            registro = registro2.Tables("Clientes").Rows.Count

            If registro <> 0 Then
                dgvClientes.DataSource = registro2
                dgvClientes.DataMember = "Clientes"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvClientes.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvClientes.CurrentCell = dgvClientes.Rows(atras).Cells(0)
                dgvClientes.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
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
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub
End Class