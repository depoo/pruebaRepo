Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class NumContactoTrabajador

    Dim id_cel, trabajador, operador As Integer
    Dim numTelefono As String

    Private Sub cargarDataTelefono()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From N In dbContext.NumeroContacto
                        Join A In dbContext.Actores On N.id_Actor Equals A.id_Actor
                        Join O In dbContext.Operadores On N.id_Operador Equals O.id_Operador
                        Select New With {
                            .ID = N.id_Cel,
                            .NOMBRE = A.NombreCompleto,
                            .OPERADOR = O.nombreOperador,
                            .NUMERO = N.numeroTelefono
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub cargarDatacombobox2()
        Try
            Dim dbContext As New MiDbContext()
            Dim operadores = dbContext.Operadores.ToList()
            ComboBox2.DataSource = operadores
            ComboBox2.DisplayMember = "nombreOperador"
            ComboBox2.ValueMember = "id_Operador"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub


    Private Sub cargarDatacombobox1()
        Try
            Dim dbContext As New MiDbContext()
            Dim operadores = dbContext.Actores.ToList()
            ComboBox1.DataSource = operadores
            ComboBox1.DisplayMember = "NombreCompleto"
            ComboBox1.ValueMember = "id_Actor"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub NumContactoTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarDataTelefono()
        cargarDatacombobox1()
        cargarDatacombobox2()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Trabajador"
        DataGridView1.Columns(2).HeaderText = "Operador telf"
        DataGridView1.Columns(3).HeaderText = "Telefono"
        Button1.Enabled = False
        Button2.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        FormularioPersonaNatural.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        id_cel = 1
        operador = ComboBox2.SelectedValue
        trabajador = ComboBox1.SelectedValue
        numTelefono = TextBox1.Text

        Try
            Dim dbContext As New MiDbContext()
            Dim NewPersonaNatural As New NumeroContacto() With
            {
                .id_Actor = trabajador,
                .id_Operador = operador,
                .numeroTelefono = numTelefono
            }
            dbContext.NumeroContacto.Add(NewPersonaNatural)
            dbContext.SaveChanges()
            cajademensaje.Creacionderegistro()
            cargarDataTelefono()
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox2.Text = row.Cells("ID").Value.ToString()
            TextBox1.Text = row.Cells("NUMERO").Value.ToString()
            ComboBox1.Text = row.Cells("NOMBRE").Value.ToString()
            ComboBox2.Text = row.Cells("OPERADOR").Value.ToString()
            Button1.Enabled = True
            Button2.Enabled = True
            Button5.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id_cel = TextBox2.Text
        operador = ComboBox2.SelectedValue
        trabajador = ComboBox1.SelectedValue
        numTelefono = TextBox1.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim NUMEROCEL = dbContext.NumeroContacto.Find(id_cel)
            If NUMEROCEL IsNot Nothing Then
                NUMEROCEL.id_Cel = id_cel
                NUMEROCEL.id_Actor = trabajador
                NUMEROCEL.id_Operador = operador
                NUMEROCEL.numeroTelefono = numTelefono
                dbContext.SaveChanges()
                cajademensaje.Actualizacionderegistro()
                cargarDataTelefono()
            Else
                cajademensaje.Actualizacionderegistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        id_cel = TextBox2.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim NUMEROCEL = dbContext.NumeroContacto.Find(id_cel)
            If NUMEROCEL IsNot Nothing Then
                dbContext.NumeroContacto.Remove(NUMEROCEL)
                dbContext.SaveChanges()
                cajademensaje.Eliminarregistro()
                cargarDataTelefono()
            Else
                cajademensaje.Eliminarregistro2()
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Clear()
        TextBox1.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button5.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class

