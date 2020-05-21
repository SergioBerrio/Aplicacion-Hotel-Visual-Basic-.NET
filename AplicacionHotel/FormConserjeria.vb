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
        'TODO: esta línea de código carga datos en la tabla 'BdHotelDataSet11.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BdHotelDataSet11.Clientes)

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
            consulta = "SELECT * FROM Clientes WHERE 'DNI = " & txtbBuscarDNI.Text & "'"
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Clientes")
            registro = registro2.Tables("Clientes").Rows.Count
            txtbBuscarDNI.Clear()

            If registro <> 0 Then
                dgvConserjeria.DataSource = registro2
                dgvConserjeria.DataMember = "Clientes"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        ElseIf txtbBuscarDNI.Text = "" Then
            MsgBox("Inserta un valor", MsgBoxStyle.Critical, "Error")
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
            txtbBuscarNombre.Clear()

            If registro <> 0 Then
                dgvConserjeria.DataSource = registro2
                dgvConserjeria.DataMember = "Clientes"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        ElseIf txtbBuscarDNI.Text = "" Then
            MsgBox("Inserta un valor", MsgBoxStyle.Critical, "Error")
        End If
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
            MsgBox("No se realizó el proceso por: " & ex.Message)
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
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub
End Class