Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FormCocina
    Dim conexion As New OleDbConnection
    Dim adaptador2 As New OleDbDataAdapter
    Dim registro2 As New DataSet
    Dim i As Integer = 0

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormPantallaTrabajadores.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim actual As Integer = dgvCocina.CurrentCell.RowIndex
        Dim atras As Integer = actual + 1

        Try
            If atras >= 0 Then
                dgvCocina.CurrentCell = dgvCocina.Rows(atras).Cells(0)
                dgvCocina.Rows(atras).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actual As Integer = dgvCocina.CurrentCell.RowIndex
        Dim siguiente As Integer = actual + 1

        Try
            If dgvCocina.Rows.Count > siguiente Then
                dgvCocina.CurrentCell = dgvCocina.Rows(siguiente).Cells(0)
                dgvCocina.Rows(siguiente).Selected = True
            Else
                MsgBox("Has llegado al final", MsgBoxStyle.Critical, "Advertencia")
            End If

        Catch ex As Exception
            MsgBox("No se realizó el proceso por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAgregarRecetas_Click(sender As Object, e As EventArgs) Handles btnAgregarRecetas.Click
        If txtbNombreReceta.Text = "" And txtbIngredientes.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf txtbNombreReceta.Text <> "" And txtbIngredientes.Text <> "" Then
            dgvCocina.Rows.Add(txtbIDReceta.Text, txtbNombreReceta.Text, txtbIngredientes.Text)

            i = i + 1
            txtbIDReceta.Text = CStr(i + 1)

            txtbNombreReceta.Text = ""
            txtbIngredientes.Text = ""

            txtbNombreReceta.Clear()
            txtbIngredientes.Clear()

            conexion.Close()

            MsgBox("Datos de las recetas almacenadas correctamente!!", MsgBoxStyle.Information, "Información")

            txtbIDReceta.Text = CStr(i + 1)
        End If
    End Sub

    Private Sub btnEliminarRecetas_Click(sender As Object, e As EventArgs) Handles btnEliminarRecetas.Click
        dgvCocina.Rows.Remove(dgvCocina.CurrentRow)

        MsgBox("Registro eliminado", MsgBoxStyle.Information, "Eliminado")

        conexion.Close()

        txtbIDReceta.Text = 1
    End Sub

    Private Sub btnBuscarReceta_Click(sender As Object, e As EventArgs) Handles btnBuscarReceta.Click
        Dim consulta As String
        Dim registro As Boolean

        If txtbBuscarIDReceta.Text <> "" Then
            consulta = "SELECT * FROM Cocina WHERE IDReceta = " & txtbBuscarIDReceta.Text & ""
            adaptador2 = New OleDbDataAdapter(consulta, conexion)
            registro2 = New DataSet
            adaptador2.Fill(registro2, "Recetas")
            registro = registro2.Tables("Recetas").Rows.Count

            If registro <> 0 Then
                dgvCocina.DataSource = registro2
                dgvCocina.DataMember = "Recetas"
            Else
                MsgBox("No existe el identificador", MsgBoxStyle.Critical, "Error")
                conexion.Close()
            End If
        End If

        Buscar()

        txtbBuscarIDReceta.Clear()
    End Sub

    Private Sub FormCocina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbIDReceta.Text = CStr(i + 1)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()

            conexion.Close()
            MsgBox("Se ha establecido la conexión con la base de datos!!", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión!!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Buscar()
        Dim cocina As New DataTable()
        Dim consulta As String
        consulta = ("SELECT * FROM cocina WHERE IDRecetas = " & txtbBuscarIDReceta.Text & "")
        Dim datos As New OleDbDataAdapter(consulta, conexion)
        datos.Fill(cocina)

        Me.dgvCocina.DataSource = cocina
    End Sub
End Class