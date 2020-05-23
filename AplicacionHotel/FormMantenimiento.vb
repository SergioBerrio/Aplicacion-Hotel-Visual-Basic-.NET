Imports System.Data.OleDb

Public Class FormMantenimiento
    Dim conexion As New OleDbConnection
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim Mantenimiento As New DataTable
    Dim i As Integer = 0

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores2.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvMantenimiento.CurrentCell.RowIndex
        Dim atras As Integer = actual + 1

        Try
            If atras >= 0 Then
                dgvMantenimiento.CurrentCell = dgvMantenimiento.Rows(atras).Cells(0)
                dgvMantenimiento.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvMantenimiento.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvMantenimiento.Rows.Count > siguiente Then
                dgvMantenimiento.CurrentCell = dgvMantenimiento.Rows(siguiente).Cells(0)
                dgvMantenimiento.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarIDIncidencia_Click(sender As Object, e As EventArgs) Handles btnBuscarIDIncidencia.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarIDIncidencia.Text <> "" Then
            consulta = "SELECT * FROM Mantenimiento WHERE IDIncidencia = " & txtbBuscarIDIncidencia.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Mantenimiento")
            registro = registro2.Tables("Mantenimiento").Rows.Count

            If registro <> 0 Then
                dgvMantenimiento.DataSource = registro2
                dgvMantenimiento.DataMember = "Mantenimiento"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
        txtbBuscarIDIncidencia.Clear()
    End Sub

    Private Sub btnBuscarEstado_Click(sender As Object, e As EventArgs) Handles btnBuscarEstado.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarEstado.Text <> "" Then
            consulta = "SELECT * FROM Mantenimiento WHERE Estado = " & txtbBuscarEstado.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Mantenimiento")
            registro = registro2.Tables("Mantenimiento").Rows.Count

            If registro <> 0 Then
                dgvMantenimiento.DataSource = registro2
                dgvMantenimiento.DataMember = "Mantenimiento"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If
        txtbBuscarEstado.Clear()
    End Sub

    Private Sub btnAgregarIncidencia_Click(sender As Object, e As EventArgs) Handles btnAgregarIncidencia.Click
        'txtbIDIncidencia.Text = Val(txtbIDIncidencia.Text) + 1

        If txtbIDIncidencia.Text = "" And txtbEstado.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf txtbIDIncidencia.Text <> "" And txtbEstado.Text <> "" Then
            dgvMantenimiento.Rows.Add(txtbIDIncidencia.Text, txtbIncidencia.Text, txtbEstado.Text)

            i = i + 1
            txtbIDIncidencia.Text = CStr(i + 1)

            txtbIncidencia.Text = ""
            txtbEstado.Text = ""

            txtbIncidencia.Clear()
            txtbEstado.Clear()

            conexion.Close()

            MsgBox("Datos de las recetas almacenadas correctamente!!", MsgBoxStyle.Information, "Información")

            txtbIDIncidencia.Text = Val(txtbIDIncidencia.Text) + 1
        End If
    End Sub

    Private Sub btnEliminarIncidencia_Click(sender As Object, e As EventArgs) Handles btnEliminarIncidencia.Click
        dgvMantenimiento.Rows.Remove(dgvMantenimiento.CurrentRow)

        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        refreshDatagrid()
    End Sub

    Private Sub refreshDatagrid()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb")
        Dim ole As New OleDbCommand("SELECT * FROM Mantenimiento", con)
        Dim ds As New DataSet
        Dim DataAdapter1 As New OleDbDataAdapter
        con.Open()
        DataAdapter1.SelectCommand = ole
        DataAdapter1.Fill(ds, "Mantenimiento")
        dgvMantenimiento.DataSource = ds
        dgvMantenimiento.DataMember = "Mantenimiento"
        con.Close()
    End Sub

    Private Sub FormMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbIDIncidencia.Text = CStr(i + 1)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class