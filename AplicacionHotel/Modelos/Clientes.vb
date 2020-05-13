Namespace Modelos
    Public Class Clientes
        Public dni As Integer
        Public nombre As String
        Public email As String
        Public telefono As Integer

        Public Sub New()

        End Sub

        Public Sub New(dni As Integer,
                      nombre As String,
                      email As String,
                      telefono As Integer)
            dni = dni
            nombre = nombre
            email = email
            telefono = telefono
        End Sub

        Public Sub New(row As DataRow)
            dni = row("DNI")
            telefono = row("NOMBRE")
            email = row("EMAIL") + ""
            telefono = row("TELEFONO") + ""
        End Sub

        Public Function Clone() As Clientes
            Return DirectCast(Me.MemberwiseClone(), Clientes)
        End Function
    End Class
End Namespace
