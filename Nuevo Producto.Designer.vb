<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo_Producto
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        btnAgregarProductoNuevo = New FontAwesome.Sharp.IconButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(39, 162)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(186, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(39, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 17)
        Label1.TabIndex = 1
        Label1.Text = "Nuevo Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(39, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 2
        Label2.Text = "Proveedor"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(39, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 23)
        TextBox1.TabIndex = 3
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
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(27), CByte(156), CByte(133))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 43
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(55), CByte(66), CByte(89))
        DataGridView1.Location = New Point(250, 36)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
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
        DataGridView1.TabIndex = 4
        ' 
        ' btnAgregarProductoNuevo
        ' 
        btnAgregarProductoNuevo.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnAgregarProductoNuevo.FlatAppearance.BorderSize = 0
        btnAgregarProductoNuevo.FlatStyle = FlatStyle.Flat
        btnAgregarProductoNuevo.IconChar = FontAwesome.Sharp.IconChar.Add
        btnAgregarProductoNuevo.IconColor = Color.White
        btnAgregarProductoNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAgregarProductoNuevo.IconSize = 32
        btnAgregarProductoNuevo.Location = New Point(104, 225)
        btnAgregarProductoNuevo.Name = "btnAgregarProductoNuevo"
        btnAgregarProductoNuevo.Size = New Size(47, 47)
        btnAgregarProductoNuevo.TabIndex = 6
        btnAgregarProductoNuevo.UseVisualStyleBackColor = False
        ' 
        ' Nuevo_Producto
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(232), CByte(246), CByte(239))
        ClientSize = New Size(886, 483)
        Controls.Add(btnAgregarProductoNuevo)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Name = "Nuevo_Producto"
        Text = "Nuevo Producto"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarProductoNuevo As FontAwesome.Sharp.IconButton
End Class
