Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace My
    Friend Class Contacto
        Inherits Persona

        Private telefono As String

        Public Property TelefonoP As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value.Replace(" ", "").Replace("-", "")
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            telefono = String.Empty
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?, ByVal telefono As String)
            MyBase.New(nombre, fechaNacimiento)
            Me.telefono = telefono
        End Sub

        Public Overrides Function ToString() As String
            Return MyBase.ToString() & " " & telefono
        End Function
    End Class
End Namespace
