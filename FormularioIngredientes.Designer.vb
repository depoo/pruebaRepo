<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioIngredientes1
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
        Label1 = New Label()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        Button11 = New Button()
        Button12 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        TextBox3 = New TextBox()
        GroupBox2 = New GroupBox()
        Button10 = New Button()
        Label2 = New Label()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(324, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 18)
        Label1.TabIndex = 0
        Label1.Text = "VERDURAS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Orange
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(41, 100)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 35)
        Button1.TabIndex = 2
        Button1.Text = "VERDURAS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(86, 61)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(196, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 167)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(757, 333)
        DataGridView1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightSeaGreen
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button11)
        GroupBox1.Controls.Add(Button12)
        GroupBox1.Controls.Add(Button8)
        GroupBox1.Controls.Add(Button9)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(310, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(805, 610)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(523, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(165, 23)
        TextBox1.TabIndex = 12
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Salmon
        Button11.ForeColor = Color.Black
        Button11.Location = New Point(150, 517)
        Button11.Name = "Button11"
        Button11.Size = New Size(206, 61)
        Button11.TabIndex = 10
        Button11.Text = "SALIR"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(457, 517)
        Button12.Name = "Button12"
        Button12.Size = New Size(206, 61)
        Button12.TabIndex = 11
        Button12.Text = "GENERAR LISTA"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(323, 100)
        Button8.Name = "Button8"
        Button8.Size = New Size(165, 53)
        Button8.TabIndex = 11
        Button8.Text = "INGRESO"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(523, 100)
        Button9.Name = "Button9"
        Button9.Size = New Size(165, 53)
        Button9.TabIndex = 10
        Button9.Text = "SALIDA"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(323, 61)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(165, 23)
        TextBox3.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Indigo
        GroupBox2.Controls.Add(Button10)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.ForeColor = Color.Transparent
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(279, 610)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Orange
        Button10.Location = New Point(41, 517)
        Button10.Name = "Button10"
        Button10.Size = New Size(206, 61)
        Button10.TabIndex = 9
        Button10.Text = "NUEVO INGREDIENTE"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(84, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 18)
        Label2.TabIndex = 5
        Label2.Text = "PRODUCTOS"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Orange
        Button7.Location = New Point(41, 457)
        Button7.Name = "Button7"
        Button7.Size = New Size(206, 35)
        Button7.TabIndex = 8
        Button7.Text = "GRASAS"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Orange
        Button6.Location = New Point(41, 397)
        Button6.Name = "Button6"
        Button6.Size = New Size(206, 35)
        Button6.TabIndex = 7
        Button6.Text = "LÁCTEOS"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Orange
        Button5.Location = New Point(41, 336)
        Button5.Name = "Button5"
        Button5.Size = New Size(206, 35)
        Button5.TabIndex = 6
        Button5.Text = "FRUTAS"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Orange
        Button4.Location = New Point(41, 276)
        Button4.Name = "Button4"
        Button4.Size = New Size(206, 35)
        Button4.TabIndex = 5
        Button4.Text = "CARNES"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Orange
        Button3.Location = New Point(41, 217)
        Button3.Name = "Button3"
        Button3.Size = New Size(206, 35)
        Button3.TabIndex = 4
        Button3.Text = "LEGUMBRES"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Orange
        Button2.Location = New Point(41, 159)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 35)
        Button2.TabIndex = 3
        Button2.Text = "CEREALES"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormularioIngredientes1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 634)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FormularioIngredientes1"
        Text = "FormularioIngredientes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
