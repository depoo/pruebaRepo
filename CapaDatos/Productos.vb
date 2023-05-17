
Imports System.ComponentModel.DataAnnotations

Public Class Productos
    <Key>
    Public Property id_Producto As Integer
    Public Property nombre_Producto As String
    Public Property id_Categoria As Integer
    Public Property id_Unidad As Integer
    Public Property id_Movimiento As Integer
End Class