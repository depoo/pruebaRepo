Imports FontAwesome.Sharp
Public Class DashboardIngredientes
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private Sub DashboardIngredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenu()
    End Sub

    'Metodo Ocultar sub-menu
    Private Sub HideSubMenu()
        PanelSubMenuIngredientes.Visible = False
    End Sub

    'Metodo Mostrar sub-menu
    Private Sub ShowSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            HideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnIngredientes_Click(sender As Object, e As EventArgs) Handles btnIngredientes.Click
        ShowSubMenu(PanelSubMenuIngredientes)
    End Sub

    Private Sub btnNuevoProductos_Click(sender As Object, e As EventArgs) Handles btnNuevoProductos.Click
        HideSubMenu()
    End Sub

    Private Sub btnVerduras_Click(sender As Object, e As EventArgs) Handles btnVerduras.Click
        HideSubMenu()
    End Sub

    Private Sub btnCereales_Click(sender As Object, e As EventArgs) Handles btnCereales.Click
        HideSubMenu()
    End Sub

    Private Sub btnLegumbres_Click(sender As Object, e As EventArgs) Handles btnLegumbres.Click
        HideSubMenu()
    End Sub

    Private Sub btnCarnes_Click(sender As Object, e As EventArgs) Handles btnCarnes.Click
        HideSubMenu()
    End Sub

    Private Sub btnFrutas_Click(sender As Object, e As EventArgs) Handles btnFrutas.Click
        HideSubMenu()
    End Sub

    Private Sub btnLacteos_Click(sender As Object, e As EventArgs) Handles btnLacteos.Click
        HideSubMenu()
    End Sub

    Private Sub btnGrasas_Click(sender As Object, e As EventArgs) Handles btnGrasas.Click
        HideSubMenu()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        FormularioLogin.Show()
    End Sub

    Private Sub reset()

    End Sub
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click

    End Sub
End Class