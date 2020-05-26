Public Class FormInicioSesionTrabajadores

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If txtbUsuario.Text = "Empleado" Or txtbUsuario.Text = "Admin" And txtbContrasena.Text = "ParadiseResort" Then
            MsgBox("Credenciales de inicio de sesión correctos!!", MsgBoxStyle.Information, "Información")
            FormPantallaTrabajadores.Show()
            Me.Hide()
        Else
            MsgBox("Credenciales de inicio de sesión incorrectos!!", MsgBoxStyle.Information, "Información")
        End If
    End Sub
End Class