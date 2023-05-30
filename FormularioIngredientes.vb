Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormularioIngredientes1

    Dim Valor As Integer
    Dim Id As Integer

    Private Sub cargarData(DATO As Integer)
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From A In dbContext.Almacen
                        Join P In dbContext.Productos On A.id_Productos Equals P.id_Producto
                        Join C In dbContext.Categorias On A.id_Categoria Equals C.id_Categoria
                        Join U In dbContext.UnidadMedida On A.id_Unidad Equals U.id_Unidad
                        Where A.id_Categoria = DATO
                        Select New With {
                            .ID = A.id_Almacen,
                            .NOBRE = P.nombre_Producto,
                            .CANTIDAD = A.Cantidad,
                            .Unidad = U.unidad
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub CargarDataComboBox()
        Try
            Using dbContext As New MiDbContext()
                Dim query = From A In dbContext.Almacen
                            Join P In dbContext.Productos On A.id_Productos Equals P.id_Producto
                            Join C In dbContext.Categorias On A.id_Categoria Equals C.id_Categoria
                            Join U In dbContext.UnidadMedida On A.id_Unidad Equals U.id_Unidad
                            Select New With {
                            .ID = A.id_Almacen,
                            .IDPRODUCTO = A.id_Productos,
                            .NOMBRE = P.nombre_Producto,
                            .CANTIDAD = A.Cantidad,
                            .Unidad = U.unidad
                        }

                ComboBox1.DataSource = query.ToList()
                ComboBox1.DisplayMember = "NOMBRE"
                ComboBox1.ValueMember = "ID"
            End Using
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ComboBox1.Text = row.Cells("NOBRE").Value.ToString()
        End If
    End Sub

    Private Sub cargarData2()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From A In dbContext.Almacen
                        Join P In dbContext.Productos On A.id_Productos Equals P.id_Producto
                        Join C In dbContext.Categorias On A.id_Categoria Equals C.id_Categoria
                        Join U In dbContext.UnidadMedida On A.id_Unidad Equals U.id_Unidad
                        Select New With {
                            .ID = A.id_Almacen,
                            .NOBRE = P.nombre_Producto,
                            .CANTIDAD = A.Cantidad,
                            .Unidad = U.unidad
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub FormularioIngredientes1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarData2()
        CargarDataComboBox()
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "VERDURAS"
        Dim dato As Integer = 1
        cargarData(dato)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label1.Text = "CEREALES"
        Dim dato As Integer = 2
        cargarData(dato)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label1.Text = "LEGUMBRES"
        Dim dato As Integer = 3
        cargarData(dato)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.Text = "FRUTAS"
        Dim dato As Integer = 5
        cargarData(dato)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Text = "LÁCTEOS"
        Dim dato As Integer = 6
        cargarData(dato)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Text = "GRASAS"
        Dim dato As Integer = 7
        cargarData(dato)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "CARNES"
        Dim dato As Integer = 4
        cargarData(dato)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        FormularioLogin.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Nuevo_Producto.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim Id As Integer = ComboBox1.SelectedValue
        Dim Valor As Integer = Integer.Parse(TextBox3.Text)
        Try
            Using dbContext As New MiDbContext()
                Dim Almacen = dbContext.Almacen.Find(Id)
                If Almacen IsNot Nothing Then
                    Dim nuevaCantidad As Integer = Almacen.Cantidad + Valor
                    Almacen.Cantidad = nuevaCantidad
                    dbContext.SaveChanges()
                    cajademensaje.Actualizacionderegistro()
                    cargarData2()
                Else
                    cajademensaje.Actualizacionderegistro2()
                End If
            End Using
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Id As Integer = ComboBox1.SelectedValue
        Dim Valor As Integer = Integer.Parse(TextBox1.Text)
        Try
            Using dbContext As New MiDbContext()
                Dim Almacen = dbContext.Almacen.Find(Id)
                If Almacen IsNot Nothing Then
                    Dim nuevaCantidad As Integer = Almacen.Cantidad - Valor
                    Almacen.Cantidad = nuevaCantidad
                    dbContext.SaveChanges()
                    cajademensaje.Actualizacionderegistro()
                    cargarData2()
                Else
                    cajademensaje.Actualizacionderegistro2()
                End If
            End Using
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub
End Class