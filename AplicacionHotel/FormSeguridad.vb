Imports System.Data.OleDb

Public Class FormSeguridad
    Dim conexion As New OleDbConnection
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim Seguridad As New DataTable

    Private Sub FormSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            consulta = "SELECT * FROM Seguridad WHERE Puesto = " & txtbBuscarZona.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Trabajdores")
            registro = registro2.Tables("Trabajdores").Rows.Count

            If registro <> 0 Then
                dgvSeguridad.DataSource = registro2
                dgvSeguridad.DataMember = "Trabajdores"
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
End Class