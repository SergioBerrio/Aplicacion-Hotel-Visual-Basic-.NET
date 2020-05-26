﻿Public Class FormReservasClientes2
    Private Sub btnAccederReservar_Click(sender As Object, e As EventArgs) Handles btnAccederReservar.Click
        If txtbDNI.Text = "" And txtbNombre.Text = "" And txtbApellidos.Text = "" And txtbTelefono.Text = "" And txtbEmail.Text = "" Then
            MsgBox("No se puede agregar sin datos introducidos", MsgBoxStyle.Critical, "Error")

        ElseIf txtbDNI.Text = "" And txtbNombre.Text = "" And txtbApellidos.Text = "" And txtbTelefono.Text = "" And txtbEmail.Text = "" Then
            comando = New OleDb.OleDbCommand("INSERT INTO Clientes(DNI, Nombre, Apellidos, Telefono, Email)" & Chr(13) &
                                        "VALUES(txtbDNI, txtbNombre, txtbApellidos, txtbTelefono, txtbEmail)", conexion)
            comando.Parameters.AddWithValue("@DNI", txtbDNI.Text.ToUpper)
            comando.Parameters.AddWithValue("@Nombre", txtbNombre.Text.ToUpper)
            comando.Parameters.AddWithValue("@Apellidos", txtbApellidos.Text.ToUpper)
            comando.Parameters.AddWithValue("@Telefono", txtbTelefono.Text.ToUpper)
            comando.Parameters.AddWithValue("@Email", txtbEmail.Text)
            comando.ExecuteNonQuery()

            MsgBox("Datos personales almacenados correctamente!!", MsgBoxStyle.Information, "Información")
        End If

        FormVerClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        FormVerClientes.Show()
        Me.Hide()
    End Sub
End Class