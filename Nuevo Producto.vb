Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Nuevo_Producto
    Dim idNuevoProducto, idProveedor As Integer
    Dim nombreProducto As String

    Public Sub cargarProveedor()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From N In dbContext.Proveedor
                        Join A In dbContext.Actores On N.id_Actor Equals A.id_Actor
                        Select New With {
                    .idProveedor = N.id_Proveedor,
                    .Nombre = A.NombreCompleto
                }
            Dim proveedores As IEnumerable(Of Object) = query.ToList()
            ComboBox1.DataSource = proveedores
            ComboBox1.DisplayMember = "Nombre"
            ComboBox1.ValueMember = "idProveedor"
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