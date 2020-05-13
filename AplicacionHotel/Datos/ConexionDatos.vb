Imports System.Data
Imports System.Data.OleDb

#Const DATABASE = "MSAccess"

Namespace DAM
    Public Module DB
        Public Function getConnection() As OleDbConnection
            Dim connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\source\repos\AplicacionHotel\BDHotel.accdb;Persist Security Info=False"
            getConnection = New OleDbConnection(connString)
        End Function

    End Module

    Public Module Usuarios
        Public Function QryGetAll() As DataTable
            Dim query = "SELECT * FROM CLIENTES"
            Dim conn = DB.getConnection()
            conn.Open()
            Dim sqlCommand = New OleDbCommand(query, conn)

            Dim table = New DataTable()
            Dim executeReader = sqlCommand.ExecuteReader()
            table.Load(executeReader)
            sqlCommand.Dispose()
            conn.Close()
            Return table
        End Function

        Public Function CmdInsert(u As Modelos.Clientes) As Integer
            Dim id = -1
            Dim conn = DB.getConnection()
            conn.Open()
            Try
                Dim cmd = conn.CreateCommand
                cmd.CommandText = "INSERT INTO CLIENTES 
                 (DNI, NOMBRE, EMAIL, TELEFONO) VALUES 
                 (@dni, @nombre, @email, @telefono)"
                cmd.Parameters.AddWithValue("@dni", u.dni)
                cmd.Parameters.AddWithValue("nombre", u.nombre)
                cmd.Parameters.AddWithValue("@email", u.email)
                cmd.Parameters.AddWithValue("@telefono", u.telefono)
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@Identity"
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            Return id
        End Function
    End Module
End Namespace