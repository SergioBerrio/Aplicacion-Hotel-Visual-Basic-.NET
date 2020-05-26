Imports System.Data
Imports System.Data.OleDb
Module EnlazarConexion
    Public conexion As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand

    Sub enlazar()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb"
            conexion.Open()
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub
End Module
