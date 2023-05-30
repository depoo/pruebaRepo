Public Class Nuevo_Producto
    Dim idNuevoProducto, idProveedor As Integer
    Dim nombreProducto As String

    Public Sub cargarProveedor()
        Try
            Using dbContext As New MiDbContext
                Dim query = From N In dbContext.Proveedor
                            Join A In dbContext.Actores On N.id_Actor Equals A.id_Actor
                            Select New With {
                                .idProveedor = N.id_Proveedor,
                                .Nombre = A.NombreCompleto
                                }

                ComboBox1.DataSource = query.ToList()
                ComboBox1.DisplayMember = "Nombre"
                ComboBox1.SelectedValue = "idProveedor"

            End Using
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try

    End Sub
    Private Sub Nuevo_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarProveedor()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormularioIngredientes1.Show()
    End Sub

End Class