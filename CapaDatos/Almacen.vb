Imports System.ComponentModel.DataAnnotations

Public Class Almacen
    <Key>
    Public Property id_Almacen As Integer
    Public Property id_Productos As Integer
    Public Property id_Categoria As Integer
    Public Property Cantidad As Integer
    Public Property id_Unidad As Integer

    Public ReadOnly Property cantidadProducto As String
        Get
            Return $"{Cantidad} {id_Unidad}"
        End Get
    End Property
End Class
