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
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "Trabajador"
        DataGridView1.Columns(2).HeaderText = "Usuario"
        DataGridView1.Columns(3).HeaderText = "Contraseña"
        DataGridView1.Columns(4).HeaderText = "Rol"



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


        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        idUsuario = TextBox3.Text
        Actor = ComboBox1.SelectedValue
        userName = TextBox1.Text
        password = TextBox2.Text
        Rol = ComboBox2.SelectedValue

        Try
            Dim dbContext As New MiDbContext()
            Dim asignarRol = dbContext.Usuario.Find(idUsuario)
            If asignarRol IsNot Nothing Then
                asignarRol.id_Usuario = idUsuario
                asignarRol.id_Actor = Actor
                asignarRol.usuario = userName
                asignarRol.pass = password
                asignarRol.id_Rol = Rol
                dbContext.SaveChanges()
                cajademensaje.Actualizacionderegistro()
                cargarDataUsuario()
            Else
                cajademensaje.Actualizacionderegistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox3.Text = row.Cells("ID").Value.ToString()
            ComboBox1.Text = row.Cells("Nombre").Value.ToString()
            TextBox1.Text = row.Cells("Username").Value.ToString()
            TextBox2.Text = row.Cells("Password").Value.ToString()
            ComboBox2.Text = row.Cells("Rol").Value.ToString()
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        FormularioPersonaNatural.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        idUsuario = TextBox3.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim deleteUsuario = dbContext.Usuario.Find(idUsuario)
            If deleteUsuario IsNot Nothing Then
                dbContext.Usuario.Remove(deleteUsuario)
                dbContext.SaveChanges()
                cajademensaje.Eliminarregistro()
                cargarDataUsuario()
            Else
                cajademensaje.Eliminarregistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class