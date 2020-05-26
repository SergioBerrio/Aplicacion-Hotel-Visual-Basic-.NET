Imports System.Data.OleDb

Public Class FormSeguridad
    Dim conexion As New OleDbConnection
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim Seguridad As New DataTable
    Dim i As Integer = 0

    Private Sub FormSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbIDZona.Text = CStr(i + 1)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscarPuesto_Click(sender As Object, e As EventArgs) Handles btnBuscarZona.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarZona.Text <> "" Then
            consulta = "SELECT * FROM Seguridad WHERE Zona = '" & txtbBuscarZona.Text & "'"
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Seguridad")
            registro = registro2.Tables("Seguridad").Rows.Count

            If registro <> 0 Then
                dgvSeguridad.DataSource = registro2
                dgvSeguridad.DataMember = "Seguridad"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvSeguridad.CurrentCell.RowIndex
        Dim atras As Integer = actual + 1

        Try
            If atras >= 0 Then
                dgvSeguridad.CurrentCell = dgvSeguridad.Rows(atras).Cells(0)
                dgvSeguridad.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvSeguridad.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvSeguridad.Rows.Count > siguiente Then
                dgvSeguridad.CurrentCell = dgvSeguridad.Rows(siguiente).Cells(0)
                dgvSeguridad.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarRecetas_Click(sender As Object, e As EventArgs) Handles btnAgregarRecetas.Click
        If txtbIDZona.Text = "" And txtbZona.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf txtbIDZona.Text <> "" And txtbZona.Text <> "" Then
            dgvSeguridad.Rows.Add(txtbIDZona.Text, txtbZona.Text)

            i = i + 1
            txtbIDZona.Text = CStr(i + 1)

            txtbZona.Text = ""

            txtbZona.Clear()

            conexion.Close()

            MsgBox("Datos de las zonas almacenadas correctamente!!", MsgBoxStyle.Information, "Información")

            txtbIDZona.Text = Val(txtbIDZona.Text) + 1
        End If
    End Sub

    Private Sub btnEliminarRecetas_Click(sender As Object, e As EventArgs) Handles btnEliminarRecetas.Click
        dgvSeguridad.Rows.Remove(dgvSeguridad.CurrentRow)

        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()

        txtbIDZona.Text = 1
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb")
        Dim ole As OleDbCommand = New OleDbCommand("SELECT * FROM Seguridad", con)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As OleDbDataAdapter = New OleDbDataAdapter()
        con.Open()
        DataAdapter1.SelectCommand = ole
        DataAdapter1.Fill(ds, "Seguridad")
        dgvSeguridad.DataSource = ds
        dgvSeguridad.DataMember = "Seguridad"
        con.Close()
    End Sub
End Class