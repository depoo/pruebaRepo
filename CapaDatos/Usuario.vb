Imports System.ComponentModel.DataAnnotations

Public Class Usuario
    <Key>
    Public Property id_Usuario As Integer
    Public Property usuario As String
    Public Property pass As String
    Public Property id_Rol As Integer
    Public Property id_Actor As Integer

End Class