Imports System.Numerics
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.EntityFrameworkCore

Public Class FormularioProveedor

    Dim idProveedor, Actor As Integer

    Private Sub cargarDataProveedor()

        Try
            Dim dbContext As New MiDbContext()
            Dim query = From P In dbContext.Proveedor
                        Join A In dbContext.Actores On A.id_Actor Equals P.id_Actor
                        Select New With
                            {
                            .idProveedor = P.id_Proveedor,
                            .idActor = A.NombreCompleto
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub cargarDataComboBox()
        Try
            Dim dbContext As New MiDbContext()
            Dim Actor = dbContext.Actores.ToList()

            ComboBox2.DataSource = Actor
            ComboBox2.DisplayMember = "NombreCompleto"
            ComboBox2.ValueMember = "id_Actor"
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub FormularioProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDataProveedor()
        cargarDataComboBox()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Proveedor"
        TextBox1.Enabled = False

        btnEliminar.Enabled = False
        btnLimpiar.Enabled = False

        'Limpia al cargar el sistema los inputs se limpian
        LimpiarCampos()

        ToolTip1.AutoPopDelay = 5000 ' Establecer el tiempo en milisegundos que el tooltip se mostrará antes de desaparecer automáticamente
        ToolTip1.ShowAlways = True ' Mostrar el tooltip aunque el formulario no esté activo

        ' Asignar el tooltip a un control específico
        ToolTip1.SetToolTip(btnAgregar, "Agregar Registro") ' Asignar el texto del tooltip al botón
        ToolTip1.SetToolTip(btnEliminar, "Eliminar Registro") ' Asignar el texto del tooltip al botón
        ToolTip1.SetToolTip(btnLimpiar, "Limpiar Campos") ' Asignar el texto del tooltip al botón
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("idProveedor").Value.ToString()
            ComboBox2.Text = row.Cells("idActor").Value.ToString()

            btnEliminar.Enabled = True
            btnAgregar.Enabled = False
            btnLimpiar.Enabled = True
            TextBox1.Enabled = False
        End If
    End Sub
    ' Funcion que sirve para Limpiar los campos de entrada
    Private Sub LimpiarCampos()
        TextBox1.Clear()
        ComboBox2.Text = ""
    End Sub
    'Botones
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        idProveedor = 1
        Actor = ComboBox2.SelectedValue
        Try
            Dim dbContext As New MiDbContext()
            Dim Proveedor As New Proveedor() With
                {
                    .id_Actor = Actor
                }
            dbContext.Proveedor.Add(Proveedor)
            dbContext.SaveChanges()
            cajademensaje.Creacionderegistro()
            cargarDataProveedor()
            ' Al agregar un nuevo registro se limpia los inputs
            LimpiarCampos()
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TextBox1.Clear()
        ComboBox2.Text = ""

        btnAgregar.Enabled = True
        btnEliminar.Enabled = False
        btnLimpiar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        idProveedor = TextBox1.Text
        Try
            Dim dbContext As New MiDbContext()
            Dim Proveedor = dbContext.Proveedor.Find(idProveedor)
            If MessageBox.Show("ESTAS SEGURO DE ELIMINAR ESTE REGISTRO", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Proveedor IsNot Nothing Then
                    'dbContext.Proveedor.Remove(Proveedor)
                    dbContext.SaveChanges()
                    cajademensaje.Eliminarregistro()
                    cargarDataProveedor()
                    ' Al agregar un nuevo registro se limpia los inputs
                    LimpiarCampos()
                Else
                    cajademensaje.Eliminarregistro2()
                End If
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub
End Class