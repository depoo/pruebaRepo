Imports FontAwesome.Sharp
Public Class Dashboard
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    ' Constructor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub
    ' Dando estilo a los botones cuando hagamos click
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        DisableButton()
        If senderBtn IsNot Nothing Then
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
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
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Abrir un formulario
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'fin
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'Cambiando el titulo del formulario en la cabecera
        lblFormTitle.Text = childForm.Text
    End Sub

    'Eventos de click
    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        ActivateButton(sender, RGBColors.color1)
    End Sub

    Private Sub btnRol_Click(sender As Object, e As EventArgs) Handles btnRol.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FormularioUsuarios)
    End Sub

    Private Sub btnTelefono_Click(sender As Object, e As EventArgs) Handles btnTelefono.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New NumContactoTrabajador)
    End Sub

    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New FormularioPersonaNatural)
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New FormularioProveedor)
    End Sub
End Class