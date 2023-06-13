Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormularioPersonaNatural

    Dim IdAutor, TipoDocumento As Integer
    Dim nombre, apellido, TipoSexo, NDocumento As String

    Private Sub cargarData()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From A In dbContext.Actores
                        Join D In dbContext.TipoDocumento On A.id_Tipodoc Equals D.id_TipoDoc
                        Join S In dbContext.Sexo On A.id_sexo Equals S.id_Sexo
                        Select New With {
                            .id_Actor = A.id_Actor,
                            .nombre = A.nombre,
                            .apellido = A.apellido,
                            .Nombre_tipoDoc = D.Nombre_tipoDoc,
                            .numeroDocumento = A.numeroDocumento,
                            .tiposex = S.sexo
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub Cargardata2()
        Try
            Dim dbContext As New MiDbContext()
            Dim tiposDocumento = dbContext.TipoDocumento.ToList()

            ComboBox1.DataSource = tiposDocumento
            ComboBox1.DisplayMember = "Nombre_tipoDoc"
            ComboBox1.ValueMember = "id_TipoDoc"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub Cargardata3()
        Try
            Dim dbContext As New MiDbContext()
            Dim tiposDocumento = dbContext.Sexo.ToList()

            ComboBox2.DataSource = tiposDocumento
            ComboBox2.DisplayMember = "sexo"
            ComboBox2.ValueMember = "id_Sexo"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub PersonaNatural_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se comento esta parte del codigo para que no se muestre los boderdes de este formulario en el panel del dashboard
        'Me.FormBorderStyle = FormBorderStyle.FixedDialog
        'Me.StartPosition = FormStartPosition.CenterScreen
        'Me.MaximizeBox = False
        'Me.MinimizeBox = False
        'Me.ControlBox = False
        'Me.Button2.Enabled = False
        'Me.Button3.Enabled = False
        'Me.TextBox1.Enabled = False
        cargarData()
        Cargardata2()
        Cargardata3()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nombre"
        DataGridView1.Columns(2).HeaderText = "Apellido"
        DataGridView1.Columns(3).HeaderText = "Tipo de documento"
        DataGridView1.Columns(4).HeaderText = "Número de documento"
        DataGridView1.Columns(5).HeaderText = "Genero"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox6.Clear()
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        FormularioLogin.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        IdAutor = TextBox1.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim personaNatural = dbContext.Actores.Find(IdAutor)
            If personaNatural IsNot Nothing Then
                dbContext.Actores.Remove(personaNatural)
                dbContext.SaveChanges()
                cajademensaje.Eliminarregistro()
                Cargardata()
            Else
                cajademensaje.Eliminarregistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        IdAutor = TextBox1.Text
        TipoDocumento = ComboBox1.SelectedValue
        TipoSexo = ComboBox2.SelectedValue
        NDocumento = TextBox4.Text
        nombre = TextBox3.Text
        apellido = TextBox6.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim personaNatural = dbContext.Actores.Find(IdAutor)
            If personaNatural IsNot Nothing Then
                personaNatural.nombre = nombre
                personaNatural.id_Tipodoc = TipoDocumento
                personaNatural.numeroDocumento = NDocumento
                personaNatural.id_sexo = TipoSexo
                personaNatural.apellido = apellido
                dbContext.SaveChanges()
                cajademensaje.Actualizacionderegistro()
                cargarData()
            Else
                cajademensaje.Actualizacionderegistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        IdAutor = 1
        TipoDocumento = ComboBox1.SelectedValue
        TipoSexo = ComboBox2.SelectedValue
        NDocumento = TextBox4.Text
        nombre = TextBox3.Text
        apellido = TextBox6.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim NewPersonaNatural As New Actores() With
            {
                .nombre = nombre,
                .id_Tipodoc = TipoDocumento,
                .numeroDocumento = NDocumento,
                .id_sexo = TipoSexo,
                .apellido = apellido
            }
            dbContext.Actores.Add(NewPersonaNatural)
            dbContext.SaveChanges()
            cajademensaje.Creacionderegistro()
            cargarData()
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("id_Actor").Value.ToString()
            TextBox3.Text = row.Cells("nombre").Value.ToString()
            ComboBox1.Text = row.Cells("Nombre_tipoDoc").Value.ToString()
            TextBox4.Text = row.Cells("numeroDocumento").Value.ToString()
            TextBox6.Text = row.Cells("apellido").Value.ToString()
            ComboBox2.Text = row.Cells("tiposex").Value.ToString()
            Me.Button1.Enabled = False
            Me.Button2.Enabled = True
            Me.Button3.Enabled = True

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        NumContactoTrabajador.Show()

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        FormularioUsuarios.Show()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        FormularioProveedor.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class