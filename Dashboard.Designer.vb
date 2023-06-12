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
        btnProveedor = New FontAwesome.Sharp.IconButton()
        btnRol = New FontAwesome.Sharp.IconButton()
        btnTelefono = New FontAwesome.Sharp.IconButton()
        btnPersonas = New FontAwesome.Sharp.IconButton()
        btnPrincipal = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        lblFormTitle = New Label()
        PanelDesktop = New Panel()
        PanelMenu.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = SystemColors.ActiveCaption
        PanelMenu.Controls.Add(btnProveedor)
        PanelMenu.Controls.Add(btnRol)
        PanelMenu.Controls.Add(btnTelefono)
        PanelMenu.Controls.Add(btnPersonas)
        PanelMenu.Controls.Add(btnPrincipal)
        PanelMenu.Controls.Add(Panel2)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(182, 577)
        PanelMenu.TabIndex = 0
        ' 
        ' btnProveedor
        ' 
        btnProveedor.Cursor = Cursors.Hand
        btnProveedor.Dock = DockStyle.Top
        btnProveedor.FlatAppearance.BorderSize = 0
        btnProveedor.FlatStyle = FlatStyle.Flat
        btnProveedor.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnProveedor.ForeColor = Color.DimGray
        btnProveedor.IconChar = FontAwesome.Sharp.IconChar.TruckFast
        btnProveedor.IconColor = Color.DimGray
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
        btnRol.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnRol.ForeColor = Color.DimGray
        btnRol.IconChar = FontAwesome.Sharp.IconChar.UsersCog
        btnRol.IconColor = Color.DimGray
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
        btnTelefono.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnTelefono.ForeColor = Color.DimGray
        btnTelefono.IconChar = FontAwesome.Sharp.IconChar.Phone
        btnTelefono.IconColor = Color.DimGray
        btnTelefono.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTelefono.IconSize = 32
        btnTelefono.ImageAlign = ContentAlignment.MiddleLeft
        btnTelefono.Location = New Point(0, 220)
        btnTelefono.Name = "btnTelefono"
        btnTelefono.Padding = New Padding(10, 0, 0, 0)
        btnTelefono.Size = New Size(182, 60)
        btnTelefono.TabIndex = 3
        btnTelefono.Text = "Numero Telefono"
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
        btnPersonas.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPersonas.ForeColor = Color.DimGray
        btnPersonas.IconChar = FontAwesome.Sharp.IconChar.Users
        btnPersonas.IconColor = Color.DimGray
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
        btnPrincipal.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrincipal.ForeColor = Color.DimGray
        btnPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        btnPrincipal.IconColor = Color.DimGray
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
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(182, 100)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(133, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Desktop
        Panel3.Controls.Add(lblFormTitle)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(182, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(805, 59)
        Panel3.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblFormTitle.Location = New Point(19, 22)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(62, 17)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Principal"
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(182, 59)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(805, 518)
        PanelDesktop.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(987, 577)
        Controls.Add(PanelDesktop)
        Controls.Add(Panel3)
        Controls.Add(PanelMenu)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        PanelMenu.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRol As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTelefono As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPersonas As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
End Class
