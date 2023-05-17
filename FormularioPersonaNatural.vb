Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormularioPersonaNatural

    Dim IdAutor, TipoDocumento, TipoSexo, NDocumento As Integer
    Dim nombre, apellido As String

    Private Sub Cargardata()
        Try
            Dim dbContext As New MiDbContext()
            Dim listaPersonaNatural = dbContext.Actores.
                                                Join(dbContext.TipoDocumento,
                                                     Function(pn) pn.id_Tipodoc,
                                                     Function(td) td.id_TipoDoc,
                                                     Function(pn, td) New With {
                                                        .id_Actor = pn.id_Actor,
                                                        .nombre = pn.nombre,
                                                        .apellido = pn.apellido,
                                                        .Nombre_tipoDoc = td.Nombre_tipoDoc,
                                                        .numeroDocumento = pn.numeroDocumento,
                                                        .id_sexo = pn.id_sexo
                                                     }).ToList()

            DataGridView1.DataSource = listaPersonaNatural
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

        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.TextBox1.Enabled = False
        Cargardata()
        Cargardata2()
        Cargardata3()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nombre"
        DataGridView1.Columns(2).HeaderText = "Apellido"
        DataGridView1.Columns(3).HeaderText = "Tipo de documento"
        DataGridView1.Columns(4).HeaderText = "Número de documento"
        DataGridView1.Columns(5).HeaderText = "id_sexo"

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
                Cargardata()
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
            Cargardata()
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
            Me.Button1.Enabled = False
            Me.Button2.Enabled = True
            Me.Button3.Enabled = True

        End If
    End Sub
End Class