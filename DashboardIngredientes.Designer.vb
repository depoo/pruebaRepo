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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelMenuLateral = New Panel()
        btnSalir = New FontAwesome.Sharp.IconButton()
        btnNuevoProductos = New FontAwesome.Sharp.IconButton()
        PanelSubMenuIngredientes = New Panel()
        btnGrasas = New Button()
        btnLacteos = New Button()
        btnFrutas = New Button()
        btnCarnes = New Button()
        btnLegumbres = New Button()
        btnCereales = New Button()
        btnVerduras = New Button()
        btnGeneral = New Button()
        btnIngredientes = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        imgHome = New PictureBox()
        PanelTitleBar = New Panel()
        btnMinimizar = New FontAwesome.Sharp.IconButton()
        btnMaximizar = New FontAwesome.Sharp.IconButton()
        lblFromTitle = New Label()
        PanelDesktop = New Panel()
        TextProducto = New TextBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextSacarCantidad = New TextBox()
        lblIngresarProducto = New Label()
        TextIngresarCantidad = New TextBox()
        lblProducto = New Label()
        PanelMenuLateral.SuspendLayout()
        PanelSubMenuIngredientes.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        PanelDesktop.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelMenuLateral.Size = New Size(182, 581)
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
        btnSalir.Location = New Point(0, 531)
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
        btnNuevoProductos.Cursor = Cursors.Hand
        btnNuevoProductos.Dock = DockStyle.Top
        btnNuevoProductos.FlatAppearance.BorderSize = 0
        btnNuevoProductos.FlatStyle = FlatStyle.Flat
        btnNuevoProductos.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnNuevoProductos.ForeColor = Color.White
        btnNuevoProductos.IconChar = FontAwesome.Sharp.IconChar.Box
        btnNuevoProductos.IconColor = Color.White
        btnNuevoProductos.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnNuevoProductos.IconSize = 32
        btnNuevoProductos.Location = New Point(0, 465)
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
        PanelSubMenuIngredientes.BackColor = Color.Silver
        PanelSubMenuIngredientes.Controls.Add(btnGrasas)
        PanelSubMenuIngredientes.Controls.Add(btnLacteos)
        PanelSubMenuIngredientes.Controls.Add(btnFrutas)
        PanelSubMenuIngredientes.Controls.Add(btnCarnes)
        PanelSubMenuIngredientes.Controls.Add(btnLegumbres)
        PanelSubMenuIngredientes.Controls.Add(btnCereales)
        PanelSubMenuIngredientes.Controls.Add(btnVerduras)
        PanelSubMenuIngredientes.Controls.Add(btnGeneral)
        PanelSubMenuIngredientes.Cursor = Cursors.Hand
        PanelSubMenuIngredientes.Dock = DockStyle.Top
        PanelSubMenuIngredientes.Location = New Point(0, 135)
        PanelSubMenuIngredientes.Name = "PanelSubMenuIngredientes"
        PanelSubMenuIngredientes.Size = New Size(182, 330)
        PanelSubMenuIngredientes.TabIndex = 1
        ' 
        ' btnGrasas
        ' 
        btnGrasas.Dock = DockStyle.Top
        btnGrasas.FlatAppearance.BorderSize = 0
        btnGrasas.FlatStyle = FlatStyle.Flat
        btnGrasas.ForeColor = Color.White
        btnGrasas.Location = New Point(0, 280)
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
        btnLacteos.FlatAppearance.BorderSize = 0
        btnLacteos.FlatStyle = FlatStyle.Flat
        btnLacteos.ForeColor = Color.White
        btnLacteos.Location = New Point(0, 240)
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
        btnFrutas.FlatAppearance.BorderSize = 0
        btnFrutas.FlatStyle = FlatStyle.Flat
        btnFrutas.ForeColor = Color.White
        btnFrutas.Location = New Point(0, 200)
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
        btnCarnes.FlatAppearance.BorderSize = 0
        btnCarnes.FlatStyle = FlatStyle.Flat
        btnCarnes.ForeColor = Color.White
        btnCarnes.Location = New Point(0, 160)
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
        btnLegumbres.FlatAppearance.BorderSize = 0
        btnLegumbres.FlatStyle = FlatStyle.Flat
        btnLegumbres.ForeColor = Color.White
        btnLegumbres.Location = New Point(0, 120)
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
        btnCereales.FlatAppearance.BorderSize = 0
        btnCereales.FlatStyle = FlatStyle.Flat
        btnCereales.ForeColor = Color.White
        btnCereales.Location = New Point(0, 80)
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
        btnVerduras.FlatAppearance.BorderSize = 0
        btnVerduras.FlatStyle = FlatStyle.Flat
        btnVerduras.ForeColor = Color.White
        btnVerduras.Location = New Point(0, 40)
        btnVerduras.Name = "btnVerduras"
        btnVerduras.Padding = New Padding(35, 0, 0, 0)
        btnVerduras.Size = New Size(182, 40)
        btnVerduras.TabIndex = 1
        btnVerduras.Text = "Verduras"
        btnVerduras.TextAlign = ContentAlignment.MiddleLeft
        btnVerduras.UseVisualStyleBackColor = True
        ' 
        ' btnGeneral
        ' 
        btnGeneral.Dock = DockStyle.Top
        btnGeneral.FlatAppearance.BorderSize = 0
        btnGeneral.FlatStyle = FlatStyle.Flat
        btnGeneral.ForeColor = Color.White
        btnGeneral.Location = New Point(0, 0)
        btnGeneral.Name = "btnGeneral"
        btnGeneral.Padding = New Padding(35, 0, 0, 0)
        btnGeneral.Size = New Size(182, 40)
        btnGeneral.TabIndex = 0
        btnGeneral.Text = "General"
        btnGeneral.TextAlign = ContentAlignment.MiddleLeft
        btnGeneral.UseVisualStyleBackColor = True
        ' 
        ' btnIngredientes
        ' 
        btnIngredientes.Cursor = Cursors.Hand
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
        PanelTitleBar.BackColor = Color.OrangeRed
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
        PanelDesktop.BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        PanelDesktop.Controls.Add(TextProducto)
        PanelDesktop.Controls.Add(IconButton2)
        PanelDesktop.Controls.Add(IconButton1)
        PanelDesktop.Controls.Add(DataGridView1)
        PanelDesktop.Controls.Add(Label1)
        PanelDesktop.Controls.Add(TextSacarCantidad)
        PanelDesktop.Controls.Add(lblIngresarProducto)
        PanelDesktop.Controls.Add(TextIngresarCantidad)
        PanelDesktop.Controls.Add(lblProducto)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        PanelDesktop.Location = New Point(182, 59)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(902, 522)
        PanelDesktop.TabIndex = 2
        ' 
        ' TextProducto
        ' 
        TextProducto.Location = New Point(26, 42)
        TextProducto.Name = "TextProducto"
        TextProducto.Size = New Size(196, 23)
        TextProducto.TabIndex = 18
        ' 
        ' IconButton2
        ' 
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.Location = New Point(125, 211)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(75, 31)
        IconButton2.TabIndex = 17
        IconButton2.Text = "Sacar"
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(36, 211)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(75, 31)
        IconButton1.TabIndex = 16
        IconButton1.Text = "Agregar"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(221), CByte(230), CByte(237))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(73), CByte(81), CByte(101))
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(87), CByte(103), CByte(241))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 43
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(55), CByte(66), CByte(89))
        DataGridView1.Location = New Point(259, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(221), CByte(230), CByte(237))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(25), CByte(167), CByte(206))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(612, 414)
        DataGridView1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 17)
        Label1.TabIndex = 14
        Label1.Text = "Sacar Cantidad Producto"
        ' 
        ' TextSacarCantidad
        ' 
        TextSacarCantidad.Location = New Point(26, 155)
        TextSacarCantidad.Name = "TextSacarCantidad"
        TextSacarCantidad.Size = New Size(196, 23)
        TextSacarCantidad.TabIndex = 13
        ' 
        ' lblIngresarProducto
        ' 
        lblIngresarProducto.AutoSize = True
        lblIngresarProducto.Location = New Point(29, 79)
        lblIngresarProducto.Name = "lblIngresarProducto"
        lblIngresarProducto.Size = New Size(189, 17)
        lblIngresarProducto.TabIndex = 8
        lblIngresarProducto.Text = "Ingresar Cantidad Producto"
        ' 
        ' TextIngresarCantidad
        ' 
        TextIngresarCantidad.Location = New Point(26, 102)
        TextIngresarCantidad.Name = "TextIngresarCantidad"
        TextIngresarCantidad.Size = New Size(196, 23)
        TextIngresarCantidad.TabIndex = 7
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Location = New Point(88, 22)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(73, 17)
        lblProducto.TabIndex = 5
        lblProducto.Text = "Productos"
        ' 
        ' DashboardIngredientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 581)
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
        PanelDesktop.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelSubMenuIngredientes As Panel
    Friend WithEvents btnIngredientes As FontAwesome.Sharp.IconButton
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnNuevoProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFromTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCereales As Button
    Friend WithEvents btnVerduras As Button
    Friend WithEvents btnGeneral As Button
    Friend WithEvents btnGrasas As Button
    Friend WithEvents btnLacteos As Button
    Friend WithEvents btnFrutas As Button
    Friend WithEvents btnCarnes As Button
    Friend WithEvents btnLegumbres As Button
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblIngresarProducto As Label
    Friend WithEvents TextIngresarCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextSacarCantidad As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextProducto As TextBox
End Class
