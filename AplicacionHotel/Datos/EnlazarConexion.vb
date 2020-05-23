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
            estado = "conectado"
        Catch ex As Exception
            estado = "desconectado"
        End Try
    End Sub
End Module
