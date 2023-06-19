<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardIngredientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DashboardIngredientes))
        PanelMenuLateral = New Panel()
        btnSalir = New FontAwesome.Sharp.IconButton()
        btnNuevoProductos = New FontAwesome.Sharp.IconButton()
        PanelSubMenuIngredientes = New Panel()
        btnGrasas = New FontAwesome.Sharp.IconButton()
        btnLacteos = New FontAwesome.Sharp.IconButton()
        btnFrutas = New FontAwesome.Sharp.IconButton()
        btnCarnes = New FontAwesome.Sharp.IconButton()
        btnLegumbres = New FontAwesome.Sharp.IconButton()
        btnCereales = New FontAwesome.Sharp.IconButton()
        btnVerduras = New FontAwesome.Sharp.IconButton()
        btnIngredientes = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        imgHome = New PictureBox()
        PanelTitleBar = New Panel()
        btnMinimizar = New FontAwesome.Sharp.IconButton()
        btnMaximizar = New FontAwesome.Sharp.IconButton()
        lblFromTitle = New Label()
        PanelDesktop = New Panel()
        PictureBox2 = New PictureBox()
        PanelMenuLateral.SuspendLayout()
        PanelSubMenuIngredientes.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        PanelDesktop.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenuLateral
        ' 
        PanelMenuLateral.BackColor = SystemColors.ActiveCaption
        PanelMenuLateral.Controls.Add(btnSalir)
        PanelMenuLateral.Controls.Add(btnNuevoProductos)
        PanelMenuLateral.Controls.Add(PanelSubMenuIngredientes)
        PanelMenuLateral.Controls.Add(btnIngredientes)
        PanelMenuLateral.Controls.Add(PanelLogo)
        PanelMenuLateral.Dock = DockStyle.Left
        PanelMenuLateral.Location = New Point(0, 0)
        PanelMenuLateral.Name = "PanelMenuLateral"
        PanelMenuLateral.Size = New Size(182, 561)
        PanelMenuLateral.TabIndex = 0
        ' 
        ' btnSalir
        ' 
        btnSalir.Dock = DockStyle.Bottom
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir.ForeColor = Color.White
        btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket
        btnSalir.IconColor = Color.White
        btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSalir.IconSize = 32
        btnSalir.ImageAlign = ContentAlignment.MiddleLeft
        btnSalir.Location = New Point(0, 511)
        btnSalir.Name = "btnSalir"
        btnSalir.Padding = New Padding(10, 0, 0, 0)
        btnSalir.Size = New Size(182, 50)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.MiddleLeft
        btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnNuevoProductos
        ' 
        btnNuevoProductos.Dock = DockStyle.Top
        btnNuevoProductos.FlatAppearance.BorderSize = 0
        btnNuevoProductos.FlatStyle = FlatStyle.Flat
        btnNuevoProductos.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnNuevoProductos.ForeColor = Color.White
        btnNuevoProductos.IconChar = FontAwesome.Sharp.IconChar.Box
        btnNuevoProductos.IconColor = Color.White
        btnNuevoProductos.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNuevoProductos.IconSize = 32
        btnNuevoProductos.Location = New Point(0, 423)
        btnNuevoProductos.Name = "btnNuevoProductos"
        btnNuevoProductos.Size = New Size(182, 45)
        btnNuevoProductos.TabIndex = 1
        btnNuevoProductos.Text = "Nuevo Producto"
        btnNuevoProductos.TextAlign = ContentAlignment.MiddleLeft
        btnNuevoProductos.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNuevoProductos.UseVisualStyleBackColor = True
        ' 
        ' PanelSubMenuIngredientes
        ' 
        PanelSubMenuIngredientes.BackColor = Color.DarkGray
        PanelSubMenuIngredientes.Controls.Add(btnGrasas)
        PanelSubMenuIngredientes.Controls.Add(btnLacteos)
        PanelSubMenuIngredientes.Controls.Add(btnFrutas)
        PanelSubMenuIngredientes.Controls.Add(btnCarnes)
        PanelSubMenuIngredientes.Controls.Add(btnLegumbres)
        PanelSubMenuIngredientes.Controls.Add(btnCereales)
        PanelSubMenuIngredientes.Controls.Add(btnVerduras)
        PanelSubMenuIngredientes.Dock = DockStyle.Top
        PanelSubMenuIngredientes.Location = New Point(0, 135)
        PanelSubMenuIngredientes.Name = "PanelSubMenuIngredientes"
        PanelSubMenuIngredientes.Size = New Size(182, 288)
        PanelSubMenuIngredientes.TabIndex = 1
        ' 
        ' btnGrasas
        ' 
        btnGrasas.Dock = DockStyle.Top
        btnGrasas.FlatStyle = FlatStyle.Flat
        btnGrasas.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnGrasas.ForeColor = Color.White
        btnGrasas.IconChar = FontAwesome.Sharp.IconChar.None
        btnGrasas.IconColor = Color.Black
        btnGrasas.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnGrasas.Location = New Point(0, 240)
        btnGrasas.Name = "btnGrasas"
        btnGrasas.Padding = New Padding(35, 0, 0, 0)
        btnGrasas.Size = New Size(182, 40)
        btnGrasas.TabIndex = 7
        btnGrasas.Text = "Grasas"
        btnGrasas.TextAlign = ContentAlignment.MiddleLeft
        btnGrasas.UseVisualStyleBackColor = True
        ' 
        ' btnLacteos
        ' 
        btnLacteos.Dock = DockStyle.Top
        btnLacteos.FlatStyle = FlatStyle.Flat
        btnLacteos.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnLacteos.ForeColor = Color.White
        btnLacteos.IconChar = FontAwesome.Sharp.IconChar.None
        btnLacteos.IconColor = Color.Black
        btnLacteos.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLacteos.Location = New Point(0, 200)
        btnLacteos.Name = "btnLacteos"
        btnLacteos.Padding = New Padding(35, 0, 0, 0)
        btnLacteos.Size = New Size(182, 40)
        btnLacteos.TabIndex = 6
        btnLacteos.Text = "Lácteos"
        btnLacteos.TextAlign = ContentAlignment.MiddleLeft
        btnLacteos.UseVisualStyleBackColor = True
        ' 
        ' btnFrutas
        ' 
        btnFrutas.Dock = DockStyle.Top
        btnFrutas.FlatStyle = FlatStyle.Flat
        btnFrutas.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnFrutas.ForeColor = Color.White
        btnFrutas.IconChar = FontAwesome.Sharp.IconChar.None
        btnFrutas.IconColor = Color.Black
        btnFrutas.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFrutas.Location = New Point(0, 160)
        btnFrutas.Name = "btnFrutas"
        btnFrutas.Padding = New Padding(35, 0, 0, 0)
        btnFrutas.Size = New Size(182, 40)
        btnFrutas.TabIndex = 5
        btnFrutas.Text = "Frutas"
        btnFrutas.TextAlign = ContentAlignment.MiddleLeft
        btnFrutas.UseVisualStyleBackColor = True
        ' 
        ' btnCarnes
        ' 
        btnCarnes.Dock = DockStyle.Top
        btnCarnes.FlatStyle = FlatStyle.Flat
        btnCarnes.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCarnes.ForeColor = Color.White
        btnCarnes.IconChar = FontAwesome.Sharp.IconChar.None
        btnCarnes.IconColor = Color.Black
        btnCarnes.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCarnes.Location = New Point(0, 120)
        btnCarnes.Name = "btnCarnes"
        btnCarnes.Padding = New Padding(35, 0, 0, 0)
        btnCarnes.Size = New Size(182, 40)
        btnCarnes.TabIndex = 4
        btnCarnes.Text = "Carnes"
        btnCarnes.TextAlign = ContentAlignment.MiddleLeft
        btnCarnes.UseVisualStyleBackColor = True
        ' 
        ' btnLegumbres
        ' 
        btnLegumbres.Dock = DockStyle.Top
        btnLegumbres.FlatStyle = FlatStyle.Flat
        btnLegumbres.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnLegumbres.ForeColor = Color.White
        btnLegumbres.IconChar = FontAwesome.Sharp.IconChar.None
        btnLegumbres.IconColor = Color.Black
        btnLegumbres.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLegumbres.Location = New Point(0, 80)
        btnLegumbres.Name = "btnLegumbres"
        btnLegumbres.Padding = New Padding(35, 0, 0, 0)
        btnLegumbres.Size = New Size(182, 40)
        btnLegumbres.TabIndex = 3
        btnLegumbres.Text = "Legumbres"
        btnLegumbres.TextAlign = ContentAlignment.MiddleLeft
        btnLegumbres.UseVisualStyleBackColor = True
        ' 
        ' btnCereales
        ' 
        btnCereales.Dock = DockStyle.Top
        btnCereales.FlatStyle = FlatStyle.Flat
        btnCereales.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCereales.ForeColor = Color.White
        btnCereales.IconChar = FontAwesome.Sharp.IconChar.None
        btnCereales.IconColor = Color.Black
        btnCereales.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCereales.Location = New Point(0, 40)
        btnCereales.Name = "btnCereales"
        btnCereales.Padding = New Padding(35, 0, 0, 0)
        btnCereales.Size = New Size(182, 40)
        btnCereales.TabIndex = 2
        btnCereales.Text = "Cereales"
        btnCereales.TextAlign = ContentAlignment.MiddleLeft
        btnCereales.UseVisualStyleBackColor = True
        ' 
        ' btnVerduras
        ' 
        btnVerduras.Dock = DockStyle.Top
        btnVerduras.FlatStyle = FlatStyle.Flat
        btnVerduras.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnVerduras.ForeColor = Color.White
        btnVerduras.IconChar = FontAwesome.Sharp.IconChar.None
        btnVerduras.IconColor = Color.Black
        btnVerduras.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnVerduras.Location = New Point(0, 0)
        btnVerduras.Name = "btnVerduras"
        btnVerduras.Padding = New Padding(35, 0, 0, 0)
        btnVerduras.Size = New Size(182, 40)
        btnVerduras.TabIndex = 1
        btnVerduras.Text = "Verduras"
        btnVerduras.TextAlign = ContentAlignment.MiddleLeft
        btnVerduras.UseVisualStyleBackColor = True
        ' 
        ' btnIngredientes
        ' 
        btnIngredientes.Dock = DockStyle.Top
        btnIngredientes.FlatAppearance.BorderSize = 0
        btnIngredientes.FlatStyle = FlatStyle.Flat
        btnIngredientes.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnIngredientes.ForeColor = Color.White
        btnIngredientes.IconChar = FontAwesome.Sharp.IconChar.Utensils
        btnIngredientes.IconColor = Color.White
        btnIngredientes.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnIngredientes.IconSize = 32
        btnIngredientes.Location = New Point(0, 90)
        btnIngredientes.Name = "btnIngredientes"
        btnIngredientes.Size = New Size(182, 45)
        btnIngredientes.TabIndex = 1
        btnIngredientes.Text = "Ingredientes"
        btnIngredientes.TextAlign = ContentAlignment.MiddleLeft
        btnIngredientes.TextImageRelation = TextImageRelation.ImageBeforeText
        btnIngredientes.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(imgHome)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(182, 90)
        PanelLogo.TabIndex = 1
        ' 
        ' imgHome
        ' 
        imgHome.Dock = DockStyle.Fill
        imgHome.Image = CType(resources.GetObject("imgHome.Image"), Image)
        imgHome.Location = New Point(0, 0)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(182, 90)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 1
        imgHome.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = SystemColors.Desktop
        PanelTitleBar.Controls.Add(btnMinimizar)
        PanelTitleBar.Controls.Add(btnMaximizar)
        PanelTitleBar.Controls.Add(lblFromTitle)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(182, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(902, 59)
        PanelTitleBar.TabIndex = 1
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.Transparent
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        btnMinimizar.IconColor = Color.FromArgb(CByte(50), CByte(59), CByte(68))
        btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMinimizar.IconSize = 22
        btnMinimizar.Location = New Point(848, 4)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(23, 23)
        btnMinimizar.TabIndex = 4
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.BackColor = Color.Transparent
        btnMaximizar.FlatAppearance.BorderSize = 0
        btnMaximizar.FlatStyle = FlatStyle.Flat
        btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        btnMaximizar.IconColor = Color.FromArgb(CByte(50), CByte(59), CByte(68))
        btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMaximizar.IconSize = 22
        btnMaximizar.Location = New Point(873, 4)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(23, 23)
        btnMaximizar.TabIndex = 3
        btnMaximizar.UseVisualStyleBackColor = False
        ' 
        ' lblFromTitle
        ' 
        lblFromTitle.AutoSize = True
        lblFromTitle.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblFromTitle.Location = New Point(19, 20)
        lblFromTitle.Name = "lblFromTitle"
        lblFromTitle.Size = New Size(79, 19)
        lblFromTitle.TabIndex = 0
        lblFromTitle.Text = "Principal"
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.Controls.Add(PictureBox2)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(182, 59)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(902, 502)
        PanelDesktop.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(151, 103)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(600, 296)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' DashboardIngredientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 561)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenuLateral)
        MinimumSize = New Size(1100, 600)
        Name = "DashboardIngredientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardIngredientes"
        PanelMenuLateral.ResumeLayout(False)
        PanelSubMenuIngredientes.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelSubMenuIngredientes As Panel
    Friend WithEvents btnIngredientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVerduras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGrasas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLacteos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFrutas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCarnes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLegumbres As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCereales As FontAwesome.Sharp.IconButton
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnNuevoProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFromTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximizar As FontAwesome.Sharp.IconButton
End Class
