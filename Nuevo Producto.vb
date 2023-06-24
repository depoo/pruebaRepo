Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Nuevo_Producto
    Dim idNuevoProducto, idProveedor As Integer
    Dim nombreProducto As String
    Dim ultimoIdMostrado As Integer = 0
    Public Sub cargarDatos()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From P In dbContext.Productos
                        Join Pr In dbContext.Proveedor On P.id_Proveedor Equals Pr.id_Proveedor
                        Join A In dbContext.Actores On Pr.id_Actor Equals A.id_Actor
                        Where P.id_Producto > ultimoIdMostrado
                        Select New With {
                            .id_Producto = P.id_Producto,
                            .nombre = P.nombre_Producto,
                            .proveedor = A.NombreCompleto
                            }
            Dim productos = query.ToList()

            If productos.Any() Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = productos

                ultimoIdMostrado = productos.Max(Function(p) p.id_Producto)
            End If
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

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
        cargarDatos()
        cargarProveedor()

        ' Configurar el tooltip
        ToolTip1.AutoPopDelay = 5000 ' Establecer el tiempo en milisegundos que el tooltip se mostrará antes de desaparecer automáticamente
        ToolTip1.ShowAlways = True ' Mostrar el tooltip aunque el formulario no esté activo

        ' Asignar el tooltip a un control específico
        ToolTip1.SetToolTip(btnAgregarProductoNuevo, "Agregar Nuevo Producto") ' Asignar el texto del tooltip al botón
    End Sub
    'Este boton agrega un nuevo producto
    Private Sub btnAgregarProductoNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregarProductoNuevo.Click
        idNuevoProducto = 1
        nombreProducto = TextBox1.Text
        idProveedor = ComboBox1.SelectedValue

        Try
            Dim dbContext As New MiDbContext()
            Dim nuevoProducto As New Productos() With
                {
                .nombre_Producto = nombreProducto,
                .id_Proveedor = idProveedor
                }
            dbContext.Productos.Add(nuevoProducto)
            dbContext.SaveChanges()
            cajademensaje.Creacionderegistro()
            cargarDatos()
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub
End Class