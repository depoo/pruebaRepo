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

        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Trabajador"
        DataGridView1.Columns(2).HeaderText = "Operador telf"
        DataGridView1.Columns(3).HeaderText = "Telefono"
        TextBox2.Enabled = False

        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnLimpiar.Enabled = False

        'Limpia al cargar el sistema los inputs se limpian
        LimpiarCampos()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox2.Text = row.Cells("ID").Value.ToString()
            TextBox1.Text = row.Cells("NUMERO").Value.ToString()
            ComboBox1.Text = row.Cells("NOMBRE").Value.ToString()
            ComboBox2.Text = row.Cells("OPERADOR").Value.ToString()
            TextBox2.Enabled = False

            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnLimpiar.Enabled = True
            btnAgregar.Enabled = False
        End If
    End Sub
    ' Funcion que sirve para Limpiar los campos de entrada
    Private Sub LimpiarCampos()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Clear()
        TextBox1.Clear()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
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
            ' Al agregar un nuevo registro se limpia los inputs
            LimpiarCampos()
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
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
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Clear()
        TextBox1.Clear()

        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnLimpiar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        id_cel = TextBox2.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim NUMEROCEL = dbContext.NumeroContacto.Find(id_cel)
            If NUMEROCEL IsNot Nothing Then
                dbContext.NumeroContacto.Remove(NUMEROCEL)
                dbContext.SaveChanges()
                cajademensaje.Eliminarregistro()
                cargarDataTelefono()
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

