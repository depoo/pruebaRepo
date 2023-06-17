<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPersonaNatural
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
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        btnAgregar = New FontAwesome.Sharp.IconButton()
        btnModificar = New FontAwesome.Sharp.IconButton()
        btnEliminar = New FontAwesome.Sharp.IconButton()
        btnLimpiar = New FontAwesome.Sharp.IconButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label1.Location = New Point(28, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 18)
        Label1.TabIndex = 0
        Label1.Text = "Id"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(160, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(121, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label2.Location = New Point(28, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 18)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label3.Location = New Point(28, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 18)
        Label3.TabIndex = 6
        Label3.Text = "Tipo Documento"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(160, 87)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(121, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(160, 214)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(121, 23)
        TextBox4.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label4.Location = New Point(28, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 18)
        Label4.TabIndex = 9
        Label4.Text = "N° Documento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label5.Location = New Point(28, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 18)
        Label5.TabIndex = 10
        Label5.Text = "Género"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label6.Location = New Point(28, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 18)
        Label6.TabIndex = 11
        Label6.Text = "Apellido"
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Location = New Point(160, 133)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(121, 23)
        TextBox6.TabIndex = 13
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
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(73), CByte(81), CByte(101))
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = Color.White
        DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(87), CByte(103), CByte(241))
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridView1.ColumnHeadersHeight = 43
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(55), CByte(66), CByte(89))
        DataGridView1.Location = New Point(302, 38)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = SystemColors.Control
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(221), CByte(230), CByte(237))
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(25), CByte(167), CByte(206))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(558, 386)
        DataGridView1.TabIndex = 16
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FlatStyle = FlatStyle.System
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(160, 173)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FlatStyle = FlatStyle.System
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(160, 252)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 20
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnAgregar.Cursor = Cursors.Hand
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        btnAgregar.IconColor = Color.White
        btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAgregar.IconSize = 32
        btnAgregar.Location = New Point(33, 312)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(47, 47)
        btnAgregar.TabIndex = 21
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.FromArgb(CByte(255), CByte(202), CByte(44))
        btnModificar.Cursor = Cursors.Hand
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        btnModificar.IconColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnModificar.IconSize = 32
        btnModificar.Location = New Point(94, 312)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(47, 47)
        btnModificar.TabIndex = 22
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(72), CByte(106))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash
        btnEliminar.IconColor = Color.White
        btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEliminar.IconSize = 32
        btnEliminar.Location = New Point(216, 312)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(47, 47)
        btnEliminar.TabIndex = 24
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.FromArgb(CByte(3), CByte(139), CByte(197))
        btnLimpiar.Cursor = Cursors.Hand
        btnLimpiar.FlatAppearance.BorderSize = 0
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom
        btnLimpiar.IconColor = Color.White
        btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLimpiar.IconSize = 32
        btnLimpiar.Location = New Point(155, 312)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(47, 47)
        btnLimpiar.TabIndex = 28
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' FormularioPersonaNatural
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        ClientSize = New Size(886, 463)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "FormularioPersonaNatural"
        Text = "Registrar Personas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiar As FontAwesome.Sharp.IconButton
End Class
