Public Class FormInicio
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlazar()
        MsgBox("Estado de conexión: " & estado, MsgBoxStyle.Information, "Información")
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        FormEntrada.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("Aplicación finalizada", MsgBoxStyle.Information, "Información")
        Me.Close()
    End Sub

    Private Sub FormInicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        conexion.Close()
    End Sub
End Class
