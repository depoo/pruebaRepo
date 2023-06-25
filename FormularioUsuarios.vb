Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FormularioUsuarios

    Dim idUsuario, Rol, Actor As Integer
    Dim userName, password As String

    Private Sub cargarDataUsuario()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From U In dbContext.Usuario
                        Join R In dbContext.Roles On U.id_Rol Equals R.id_Rol
                        Join A In dbContext.Actores On U.id_Actor Equals A.id_Actor
                        Select New With {
                            .Id = U.id_Usuario,
                            .Nombre = A.NombreCompleto,
                            .UserName = U.usuario,
                            .Password = U.pass,
                            .Rol = R.rolDenominacion
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub


    Private Sub cargarData2()
        Try
            Dim dbContext As New MiDbContext()
            Dim Trabajador = dbContext.Actores.Where(Function(a) a.Estado = "A").ToList()

            ComboBox1.DataSource = Trabajador
            ComboBox1.DisplayMember = "NombreCompleto"
            ComboBox1.ValueMember = "id_Actor"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub cargarData3()
        Try
            Dim dbContext As New MiDbContext()
            Dim Rol = dbContext.Roles.ToList()

            ComboBox2.DataSource = Rol
            ComboBox2.DisplayMember = "rolDenominacion"
            ComboBox2.ValueMember = "id_Rol"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub FormularioUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se comento esta parte del codigo para que no se muestre los boderdes de este formulario en el panel del dashboard
        'Me.FormBorderStyle = FormBorderStyle.FixedDialog
        'Me.StartPosition = FormStartPosition.CenterScreen
        'Me.MaximizeBox = False
        'Me.MinimizeBox = False
        'Me.ControlBox = False
        cargarDataUsuario()
        cargarData2()
        cargarData3()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Trabajador"
        DataGridView1.Columns(2).HeaderText = "Usuario"
        DataGridView1.Columns(3).HeaderText = "Contraseña"
        DataGridView1.Columns(4).HeaderText = "Rol"


        btnModificar.Enabled = False
        btnLimpiar.Enabled = False
        btnEliminar.Enabled = False
        TextBox3.Enabled = False

        'Limpia al cargar el sistema los inputs se limpian
        LimpiarCampos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox3.Text = row.Cells("ID").Value.ToString()
            ComboBox1.Text = row.Cells("Nombre").Value.ToString()
            TextBox1.Text = row.Cells("Username").Value.ToString()
            TextBox2.Text = row.Cells("Password").Value.ToString()
            ComboBox2.Text = row.Cells("Rol").Value.ToString()

            Me.btnAgregar.Enabled = False
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnLimpiar.Enabled = True
        End If
    End Sub
    ' Funcion que sirve para Limpiar los campos de entrada
    Private Sub LimpiarCampos()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        idUsuario = 1
        Actor = ComboBox1.SelectedValue
        userName = TextBox1.Text
        password = TextBox2.Text
        Rol = ComboBox2.SelectedValue

        Try
            Dim dbContext As New MiDbContext()
            Dim nuevaAsignacion As New Usuario() With
            {
                .id_Actor = Actor,
                .usuario = userName,
                .pass = password,
                .id_Rol = Rol
            }
            dbContext.Usuario.Add(nuevaAsignacion)
            dbContext.SaveChanges()
            cajademensaje.Creacionderegistro()
            cargarDataUsuario()
            ' Al agregar un nuevo registro se limpia los inputs
            LimpiarCampos()
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        idUsuario = TextBox3.Text
        Actor = ComboBox1.SelectedValue
        userName = TextBox1.Text
        password = TextBox2.Text
        Rol = ComboBox2.SelectedValue

        Try
            Dim dbContext As New MiDbContext()
            Dim asignarRol = dbContext.Usuario.Find(idUsuario)
            If asignarRol IsNot Nothing Then
                asignarRol.id_Actor = Actor
                asignarRol.usuario = userName
                asignarRol.pass = password
                asignarRol.id_Rol = Rol
                dbContext.SaveChanges()
                cajademensaje.Actualizacionderegistro()
                cargarDataUsuario()
                ' Al agregar un nuevo registro se limpia los inputs
                LimpiarCampos()
            Else
                cajademensaje.Actualizacionderegistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnLimpiar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        idUsuario = TextBox3.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim deleteUsuario = dbContext.Usuario.Find(idUsuario)
            If deleteUsuario IsNot Nothing Then
                dbContext.Usuario.Remove(deleteUsuario)
                dbContext.SaveChanges()
                cajademensaje.Eliminarregistro()
                cargarDataUsuario()
                ' Al agregar un nuevo registro se limpia los inputs
                LimpiarCampos()
            Else
                cajademensaje.Eliminarregistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub
End Class