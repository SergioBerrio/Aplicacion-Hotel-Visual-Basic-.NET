Public Class FormInicioSesionTrabajadores
    Private Sub lblUsuario_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If txtbUsuario.Text = "Empleado" Or txtbUsuario.Text = "Admin" And txtbContrasena.Text = "ParadiseRessort" Then
            MsgBox("Credenciales de inicio de sesión correctos!!", MsgBoxStyle.Information, "Información")
            FormPantallaTrabajadores.Show()
            Me.Hide()
        Else
            MsgBox("Credenciales de inicio de sesión incorrectos!!", MsgBoxStyle.Information, "Información")
        End If
    End Sub

    Private Sub FormInicioSesionTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class