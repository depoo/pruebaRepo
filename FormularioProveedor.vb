Imports System.Numerics
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
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("idProveedor").Value.ToString()
            ComboBox2.Text = row.Cells("idActor").Value.ToString()

            Me.Button3.Enabled = True
            Me.Button1.Enabled = False
            Me.TextBox1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        ComboBox2.Text = ""

        Button1.Enabled = True
        Button3.Enabled = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        idProveedor = TextBox1.Text
        Try
            If MessageBox.Show("ESTAS SEGURO DE ELIMINAR ESTE REGISTRO", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim dbContext As New MiDbContext()
                Dim Proveedor = dbContext.Proveedor.Find(idProveedor)
                If Proveedor IsNot Nothing Then
                    dbContext.Proveedor.Remove(Proveedor)
                    dbContext.SaveChanges()
                    cajademensaje.Eliminarregistro()
                    cargarDataProveedor()
                Else
                    cajademensaje.Eliminarregistro2()
                End If
            End If
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        FormularioPersonaNatural.Show()
    End Sub
End Class