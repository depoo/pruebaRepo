Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Timers
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FormularioLogin

    Dim intentosFallidos As Integer = 0
    Dim user, pass As String
    Dim bloqueadoHasta As DateTime

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub
    ' Funcion que sirve para Limpiar los campos de entrada
    Private Sub LimpiarCampos()
        TextBox1.Clear()
        TextBox2.Clear()
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
            Dim Rol As Integer = datos(0).id_Rol
            Dim idActores As Integer = datos(0).id_Actor
            If Rol = 1 Then
                Me.Hide()
                Dashboard.Show()
            Else
                Me.Hide()
                DashboardIngredientes.Show()
            End If
            ' funcion que limpia los campos cuando ingresamos al programa
            LimpiarCampos()
        Else

            intentosFallidos += 1
            If intentosFallidos >= 3 Then
                bloqueadoHasta = DateTime.Now.AddSeconds(15)
                intentosFallidos = 0
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Realiza la acción deseada aquí, como ejecutar el código del botón.

            user = TextBox1.Text
            pass = TextBox2.Text

            If user = "" Or pass = "" Then
                cajademensaje.Casillasvacias()
                TextBox1.Focus()
                Exit Sub
            End If

            Dim dbContext As New MiDbContext()
            Dim datos = dbContext.Usuario.Where(Function(u) u.usuario = user AndAlso u.pass = pass).ToList()

            If datos.Count() > 0 Then
                Dim Rol As Integer = datos(0).id_Rol
                Dim idActores As Integer = datos(0).id_Actor
                If Rol = 1 Then
                    Me.Hide()
                    Dashboard.Show()
                Else
                    Me.Hide()
                    DashboardIngredientes.Show()
                End If
                ' funcion que limpia los campos cuando ingresamos al programa
                LimpiarCampos()
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
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If

            End If
        End If
    End Sub

End Class
