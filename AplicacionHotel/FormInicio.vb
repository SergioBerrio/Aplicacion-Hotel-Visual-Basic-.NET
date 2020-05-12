Public Class FormInicio
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("Aplicación finalizada", , "Mensaje de información")
        Me.Close()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        FormEntrada.Show()
        Me.Hide()
    End Sub
End Class
