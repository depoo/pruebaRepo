Public Class Nuevo_Producto
    Dim idNuevoProducto, idProveedor As Integer
    Dim nombreProducto As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormularioIngredientes1.Show()
    End Sub
End Class