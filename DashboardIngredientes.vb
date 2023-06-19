Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class DashboardIngredientes
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Cosntructor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 45)
        PanelMenuLateral.Controls.Add(leftBorderBtn)

        'Formulario oculta sus botones de maximizar, minimizar y cerrar
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    ' Dando estilo a los botones cuando hagamos click
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        DisableButton()
        If senderBtn IsNot Nothing Then
            'Button
            currentBtn = CType(senderBtn, IconButton)
            'currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'estilo del borde izquierdo
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    ' Cuando hagamos click en otro boton el boton con color regresa a su estado normal
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            'currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
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

    ' Esta funcion hara que los nombres de los botones pasen a label cuando hagamos click
    Private Sub AsignarNombreBotonAlLabel(sender As Object)
        Dim boton As Button = DirectCast(sender, Button)
        lblFromTitle.Text = boton.Text
    End Sub

    Private Sub btnIngredientes_Click(sender As Object, e As EventArgs) Handles btnIngredientes.Click
        ShowSubMenu(PanelSubMenuIngredientes)
        ActivateButton(sender, RGBColors.color7)
    End Sub

    Private Sub btnNuevoProductos_Click(sender As Object, e As EventArgs) Handles btnNuevoProductos.Click
        HideSubMenu()
        ActivateButton(sender, RGBColors.color7)
    End Sub
    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub
    Private Sub btnVerduras_Click(sender As Object, e As EventArgs) Handles btnVerduras.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub

    Private Sub btnCereales_Click(sender As Object, e As EventArgs) Handles btnCereales.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub

    Private Sub btnLegumbres_Click(sender As Object, e As EventArgs) Handles btnLegumbres.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub

    Private Sub btnCarnes_Click(sender As Object, e As EventArgs) Handles btnCarnes.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub

    Private Sub btnFrutas_Click(sender As Object, e As EventArgs) Handles btnFrutas.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub

    Private Sub btnLacteos_Click(sender As Object, e As EventArgs) Handles btnLacteos.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub

    Private Sub btnGrasas_Click(sender As Object, e As EventArgs) Handles btnGrasas.Click
        HideSubMenu()
        AsignarNombreBotonAlLabel(sender)
    End Sub
    'Al salir este codigo te devuelve al formulario Login
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        FormularioLogin.Show()
    End Sub

    Private Sub reset()
        DisableButton()
        leftBorderBtn.Visible = False
        lblFromTitle.Text = "Principal"
    End Sub
    'Mostrara la ventana que contiene el logo
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        reset()
    End Sub
    ' Sirve para sujertar con un click la barra y mover la aplicacion por cualquier lado de la pantalla
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    ' este codigo sirve para hacer click en la barra del panel
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'sirve para reajustar el programa en cualquier lado de la pantalla
    Private Sub DashboardIngredientes_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    'sirve para maximizar la ventana
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    'sirve para minimizar la ventana
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class