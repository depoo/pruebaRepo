Imports System.ComponentModel.DataAnnotations

Public Class Movimientos
    <Key>
    Public Property id_Movimiento As Integer

    Public Property id_tipoMovimiento As Integer
    Public Property id_Pruducto As Integer

    Public Property id_Fecha As DateTime

    Public Property id_Cantidad As String

    Public Property id_Usuario As Integer
End Class