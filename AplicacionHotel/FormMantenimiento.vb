Imports System.Data.OleDb

Public Class FormMantenimiento
    Dim conexion As New OleDbConnection
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim Mantenimiento As New DataTable

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

    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
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
    End Sub

    Private Sub btnBuscarNombre_Click(sender As Object, e As EventArgs) Handles btnBuscarNombre.Click
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
    End Sub

    Private Sub btnAgregarIncidencia_Click(sender As Object, e As EventArgs) Handles btnAgregarIncidencia.Click
        dgvMantenimiento.Rows.Add(txtbIDIncidencia.Text, txtbIncidencia.Text, txtbEstado.Text)
        txtbIDIncidencia.Text = ""
        txtbIncidencia.Text = ""
        txtbEstado.Text = ""

        txtbIDIncidencia.Clear()
        txtbIncidencia.Clear()
        txtbEstado.Clear()

        conexion.Close()

        MsgBox("Datos de las recetas almacenadas correctamente!!")
    End Sub

    Private Sub btnEliminarIncidencia_Click(sender As Object, e As EventArgs) Handles btnEliminarIncidencia.Click
        dgvMantenimiento.Rows.Remove(dgvMantenimiento.CurrentRow)

        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()
    End Sub
End Class