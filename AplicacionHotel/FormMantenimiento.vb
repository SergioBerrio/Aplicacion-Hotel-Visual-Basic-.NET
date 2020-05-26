Imports System.Data.OleDb

Public Class FormMantenimiento
    Dim conexion As New OleDbConnection
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
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

    Private Sub btnAgregarIncidencia_Click(sender As Object, e As EventArgs) Handles btnAgregarIncidencia.Click
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

            MsgBox("Datos de la incidencia almacenados correctamente!!", MsgBoxStyle.Information, "Información")

            txtbIDIncidencia.Text = CStr(i + 1)
        End If
    End Sub

    Private Sub btnEliminarIncidencia_Click(sender As Object, e As EventArgs) Handles btnEliminarIncidencia.Click
        dgvMantenimiento.Rows.Remove(dgvMantenimiento.CurrentRow)

        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()

        txtbIDIncidencia.Text = txtbIDIncidencia.Text - 1
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