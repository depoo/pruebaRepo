Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FormularioLogin

    Dim intentosFallidos As Integer = 0
    Dim user, pass As String
    Dim bloqueadoHasta As DateTime

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        user = TextBox1.Text
        pass = TextBox2.Text

        If user = "" Or pass = "" Then
            cajademensaje.Casillasvacias()
            Exit Sub
        End If

        Dim dbContext As New MiDbContext()
        Dim datos = dbContext.Usuario.Where(Function(u) u.usuario = user AndAlso u.pass = pass).ToList()
        If datos.Count() > 0 Then
            Me.Hide()
            FormularioPersonaNatural.Show()
        Else
            intentosFallidos += 1
            If intentosFallidos >= 3 Then
                bloqueadoHasta = DateTime.Now.AddSeconds(15)
                intentosFallidos = 0
                cajademensaje.Limitedeintentos()
                Button1.Enabled = False
                While bloqueadoHasta > DateTime.Now
                    Application.DoEvents()
                End While
                Button1.Enabled = True
            Else
                cajademensaje.Credencialesincorrectas()
            End If
        End If
    End Sub
End Class
