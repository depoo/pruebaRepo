﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumContactoTrabajador
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        btnEliminar = New FontAwesome.Sharp.IconButton()
        btnLimpiar = New FontAwesome.Sharp.IconButton()
        btnModificar = New FontAwesome.Sharp.IconButton()
        btnAgregar = New FontAwesome.Sharp.IconButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(221), CByte(230), CByte(237))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(73), CByte(81), CByte(101))
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 43
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(55), CByte(66), CByte(89))
        DataGridView1.Location = New Point(312, 49)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(221), CByte(230), CByte(237))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(25), CByte(167), CByte(206))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(221), CByte(230), CByte(237))
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(25), CByte(167), CByte(206))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(43), CByte(39), CByte(48))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(558, 386)
        DataGridView1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FlatStyle = FlatStyle.System
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(154, 102)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(154, 145)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(142, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label2.Location = New Point(27, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 18)
        Label2.TabIndex = 10
        Label2.Text = "Trabajador"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label3.Location = New Point(27, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 18)
        Label3.TabIndex = 11
        Label3.Text = "Núm.Contacto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label4.Location = New Point(27, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 18)
        Label4.TabIndex = 12
        Label4.Text = "Operador"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FlatStyle = FlatStyle.System
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(154, 198)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(142, 23)
        ComboBox2.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(51), CByte(59), CByte(82))
        Label5.Location = New Point(27, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 18)
        Label5.TabIndex = 17
        Label5.Text = "Id. telefono"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(154, 57)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(142, 23)
        TextBox2.TabIndex = 16
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
        btnEliminar.Location = New Point(223, 260)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(47, 47)
        btnEliminar.TabIndex = 28
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
        btnLimpiar.Location = New Point(162, 260)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(47, 47)
        btnLimpiar.TabIndex = 27
        btnLimpiar.UseVisualStyleBackColor = False
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
        btnModificar.Location = New Point(101, 260)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(47, 47)
        btnModificar.TabIndex = 26
        btnModificar.UseVisualStyleBackColor = False
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
        btnAgregar.Location = New Point(40, 260)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(47, 47)
        btnAgregar.TabIndex = 25
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' NumContactoTrabajador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        ClientSize = New Size(886, 463)
        Controls.Add(btnEliminar)
        Controls.Add(btnLimpiar)
        Controls.Add(btnModificar)
        Controls.Add(btnAgregar)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Name = "NumContactoTrabajador"
        Text = "Número Telefono"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
End Class
