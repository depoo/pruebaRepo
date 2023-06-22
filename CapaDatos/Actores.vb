Imports System.ComponentModel.DataAnnotations

Public Class Actores
    <Key>
    Public Property id_Actor As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property id_Tipodoc As Integer
    Public Property numeroDocumento As String
    Public Property id_sexo As Integer
    ' Se le agrego la propiedad estado para cuando registremos a un nuevo actor
    Public Property Estado As String


    Public ReadOnly Property NombreCompleto As String
        Get
            Return $"{nombre} {apellido}"
        End Get
    End Property

End Class
