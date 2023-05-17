Public Class FormularioIngredientes1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label1.Text = "CEREALES"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label1.Text = "LEGUMBRES"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "VERDURAS"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Label1.Text = "FRUTAS"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Label1.Text = "LÁCTEOS"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Label1.Text = "GRASAS"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Nuevo_Producto.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Label1.Text = "CARNES"

    End Sub
End Class