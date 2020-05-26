Imports System.Data.OleDb

Public Class FormConserjeria
    Dim conexion As New OleDbConnection
    Dim posicion As Integer
    Dim posicionFinal As Integer
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim tabla As New DataTable

    Private Sub CargarDatosDataGridView()
        Dim consulta As String
        consulta = "SELECT * FROM Clientes"
        adaptador2 = New OleDbDataAdapter(consulta, conexion)
        registro2.Tables.Add("Clientes")
        adaptador2.Fill(registro2.Tables("Clientes"))
        dgvConserjeria.DataSource = registro2.Tables("Clientes")
        posicion = 0
        posicionFinal = registro2.Tables("Clientes").Rows.Count - 1
    End Sub

    Private Sub FormConserjeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        FormPantallaTrabajadores.Show()
        Close()
    End Sub

    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarDNI.Text <> "" Then
            consulta = "SELECT * FROM Clientes WHERE DNI = '" & txtbBuscarDNI.Text & "'"
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Clientes")
            registro = registro2.Tables("Clientes").Rows.Count

            If registro <> 0 Then
                dgvConserjeria.DataSource = registro2
                dgvConserjeria.DataMember = "Clientes"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
        txtbBuscarDNI.Clear()
    End Sub

    Private Sub btnBuscarNombre_Click(sender As Object, e As EventArgs) Handles btnBuscarNombre.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarNombre.Text <> "" Then
            consulta = "SELECT * FROM Clientes WHERE Nombre = '" & txtbBuscarNombre.Text & "'"
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Clientes")
            registro = registro2.Tables("Clientes").Rows.Count

            If registro <> 0 Then
                dgvConserjeria.DataSource = registro2
                dgvConserjeria.DataMember = "Clientes"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
        txtbBuscarNombre.Clear()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvConserjeria.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                dgvConserjeria.CurrentCell = dgvConserjeria.Rows(atras).Cells(0)
                dgvConserjeria.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al principio", MsgBoxStyle.Critical, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvConserjeria.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvConserjeria.Rows.Count > siguiente Then
                dgvConserjeria.CurrentCell = dgvConserjeria.Rows(siguiente).Cells(0)
                dgvConserjeria.Rows(siguiente).Selected = True
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
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb")
        Dim ole As New OleDbCommand("SELECT * FROM Clientes", con)
        Dim ds As New DataSet()
        Dim DataAdapter1 As New OleDbDataAdapter()
        con.Open()
        DataAdapter1.SelectCommand = ole
        DataAdapter1.Fill(ds, "Clientes")
        dgvConserjeria.DataSource = ds
        dgvConserjeria.DataMember = "Clientes"
        con.Close()
    End Sub
End Class