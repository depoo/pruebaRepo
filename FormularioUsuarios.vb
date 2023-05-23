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
            Dim Trabajador = dbContext.Actores.ToList()

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
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        cargarDataUsuario()
        cargarData2()
        cargarData3()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "TRABAJADOR"
        DataGridView1.Columns(2).HeaderText = "USUARIO"
        DataGridView1.Columns(3).HeaderText = "CONTRASEÑA"
        DataGridView1.Columns(4).HeaderText = "ROL"
        TextBox3.Enabled = False

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

            'Try
            'Dim dbContext As New MiDbContext()
            'Dim asignarRol = dbContext.Usuario.Find(idUsuario)
            'If asignarRol IsNot Nothing Then
            'signarRol.id_Usuario = idUsuario
            'ignarRol.id_Actor = Actor
            'asignarRol.usuario = userName
            'asignarRol.pass = password
            'asignarRol.id_Rol = Rol
            'ontext.SaveChanges()
            'cajademensaje.Actualizacionderegistro()
            'cargarDataUsuario()
            'Else
            'cajademensaje.Actualizacionderegistro2()
            'End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try

    End Sub

End Class