<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Dashboard))
        PanelMenu = New Panel()
        btnSalir = New FontAwesome.Sharp.IconButton()
        btnProveedor = New FontAwesome.Sharp.IconButton()
        btnRol = New FontAwesome.Sharp.IconButton()
        btnTelefono = New FontAwesome.Sharp.IconButton()
        btnPersonas = New FontAwesome.Sharp.IconButton()
        btnPrincipal = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        imgHome = New PictureBox()
        PanelTitleBar = New Panel()
        btnMinimizar = New FontAwesome.Sharp.IconButton()
        btnMaximizar = New FontAwesome.Sharp.IconButton()
        lblFormTitle = New Label()
        PanelDesktop = New Panel()
        PictureBox1 = New PictureBox()
        PanelMenu.SuspendLayout()
        Panel2.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        PanelDesktop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(87), CByte(103), CByte(241))
        PanelMenu.Controls.Add(btnSalir)
        PanelMenu.Controls.Add(btnProveedor)
        PanelMenu.Controls.Add(btnRol)
        PanelMenu.Controls.Add(btnTelefono)
        PanelMenu.Controls.Add(btnPersonas)
        PanelMenu.Controls.Add(btnPrincipal)
        PanelMenu.Controls.Add(Panel2)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(182, 561)
        PanelMenu.TabIndex = 0
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
        btnSalir.Location = New Point(0, 501)
        btnSalir.Name = "btnSalir"
        btnSalir.Padding = New Padding(10, 0, 0, 0)
        btnSalir.Size = New Size(182, 60)
        btnSalir.TabIndex = 2
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.MiddleLeft
        btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnProveedor
        ' 
        btnProveedor.Cursor = Cursors.Hand
        btnProveedor.Dock = DockStyle.Top
        btnProveedor.FlatAppearance.BorderSize = 0
        btnProveedor.FlatStyle = FlatStyle.Flat
        btnProveedor.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnProveedor.ForeColor = Color.White
        btnProveedor.IconChar = FontAwesome.Sharp.IconChar.TruckFast
        btnProveedor.IconColor = Color.White
        btnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProveedor.IconSize = 32
        btnProveedor.ImageAlign = ContentAlignment.MiddleLeft
        btnProveedor.Location = New Point(0, 340)
        btnProveedor.Name = "btnProveedor"
        btnProveedor.Padding = New Padding(10, 0, 0, 0)
        btnProveedor.Size = New Size(182, 60)
        btnProveedor.TabIndex = 5
        btnProveedor.Text = "Proveedor"
        btnProveedor.TextAlign = ContentAlignment.MiddleLeft
        btnProveedor.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProveedor.UseVisualStyleBackColor = True
        ' 
        ' btnRol
        ' 
        btnRol.Cursor = Cursors.Hand
        btnRol.Dock = DockStyle.Top
        btnRol.FlatAppearance.BorderSize = 0
        btnRol.FlatStyle = FlatStyle.Flat
        btnRol.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnRol.ForeColor = Color.White
        btnRol.IconChar = FontAwesome.Sharp.IconChar.UsersCog
        btnRol.IconColor = Color.White
        btnRol.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRol.IconSize = 32
        btnRol.ImageAlign = ContentAlignment.MiddleLeft
        btnRol.Location = New Point(0, 280)
        btnRol.Name = "btnRol"
        btnRol.Padding = New Padding(10, 0, 0, 0)
        btnRol.Size = New Size(182, 60)
        btnRol.TabIndex = 4
        btnRol.Text = "Rol"
        btnRol.TextAlign = ContentAlignment.MiddleLeft
        btnRol.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRol.UseVisualStyleBackColor = True
        ' 
        ' btnTelefono
        ' 
        btnTelefono.Cursor = Cursors.Hand
        btnTelefono.Dock = DockStyle.Top
        btnTelefono.FlatAppearance.BorderSize = 0
        btnTelefono.FlatStyle = FlatStyle.Flat
        btnTelefono.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnTelefono.ForeColor = Color.White
        btnTelefono.IconChar = FontAwesome.Sharp.IconChar.Phone
        btnTelefono.IconColor = Color.White
        btnTelefono.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTelefono.IconSize = 32
        btnTelefono.ImageAlign = ContentAlignment.MiddleLeft
        btnTelefono.Location = New Point(0, 220)
        btnTelefono.Name = "btnTelefono"
        btnTelefono.Padding = New Padding(10, 0, 0, 0)
        btnTelefono.Size = New Size(182, 60)
        btnTelefono.TabIndex = 3
        btnTelefono.Text = "Número Telefono"
        btnTelefono.TextAlign = ContentAlignment.MiddleLeft
        btnTelefono.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTelefono.UseVisualStyleBackColor = True
        ' 
        ' btnPersonas
        ' 
        btnPersonas.Cursor = Cursors.Hand
        btnPersonas.Dock = DockStyle.Top
        btnPersonas.FlatAppearance.BorderSize = 0
        btnPersonas.FlatStyle = FlatStyle.Flat
        btnPersonas.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPersonas.ForeColor = Color.White
        btnPersonas.IconChar = FontAwesome.Sharp.IconChar.Users
        btnPersonas.IconColor = Color.White
        btnPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPersonas.IconSize = 32
        btnPersonas.ImageAlign = ContentAlignment.MiddleLeft
        btnPersonas.Location = New Point(0, 160)
        btnPersonas.Name = "btnPersonas"
        btnPersonas.Padding = New Padding(10, 0, 0, 0)
        btnPersonas.Size = New Size(182, 60)
        btnPersonas.TabIndex = 2
        btnPersonas.Text = "Resgistrar Personas"
        btnPersonas.TextAlign = ContentAlignment.MiddleLeft
        btnPersonas.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPersonas.UseVisualStyleBackColor = True
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.Dock = DockStyle.Top
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrincipal.ForeColor = Color.White
        btnPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        btnPrincipal.IconColor = Color.White
        btnPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPrincipal.IconSize = 32
        btnPrincipal.ImageAlign = ContentAlignment.MiddleLeft
        btnPrincipal.Location = New Point(0, 100)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Padding = New Padding(10, 0, 0, 0)
        btnPrincipal.Size = New Size(182, 60)
        btnPrincipal.TabIndex = 1
        btnPrincipal.Text = "Principal"
        btnPrincipal.TextAlign = ContentAlignment.MiddleLeft
        btnPrincipal.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(87), CByte(103), CByte(241))
        Panel2.Controls.Add(imgHome)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(182, 100)
        Panel2.TabIndex = 0
        ' 
        ' imgHome
        ' 
        imgHome.BackColor = Color.FromArgb(CByte(87), CByte(103), CByte(241))
        imgHome.Image = CType(resources.GetObject("imgHome.Image"), Image)
        imgHome.Location = New Point(25, 14)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(133, 72)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.White
        PanelTitleBar.Controls.Add(btnMinimizar)
        PanelTitleBar.Controls.Add(btnMaximizar)
        PanelTitleBar.Controls.Add(lblFormTitle)
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
        btnMinimizar.Location = New Point(846, 5)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(23, 23)
        btnMinimizar.TabIndex = 2
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
        btnMaximizar.Location = New Point(871, 5)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(23, 23)
        btnMaximizar.TabIndex = 1
        btnMaximizar.UseVisualStyleBackColor = False
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        lblFormTitle.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(87), CByte(103), CByte(241))
        lblFormTitle.Location = New Point(19, 19)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(79, 19)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Principal"
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(182, 59)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(902, 502)
        PanelDesktop.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(210, 115)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(482, 289)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 561)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        MinimumSize = New Size(1100, 600)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        PanelMenu.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRol As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTelefono As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPersonas As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
End Class
