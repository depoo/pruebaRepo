<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioUsuarios
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(296, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 18)
        Label1.TabIndex = 0
        Label1.Text = "Asignar Rol Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(29, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 18)
        Label2.TabIndex = 1
        Label2.Text = "Trabajador"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(29, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 18)
        Label3.TabIndex = 2
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(29, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 18)
        Label4.TabIndex = 3
        Label4.Text = "Contraseña"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(29, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 18)
        Label5.TabIndex = 4
        Label5.Text = "Rol"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 150)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(146, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(131, 196)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(146, 23)
        TextBox2.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(131, 105)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(146, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(131, 235)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(146, 23)
        ComboBox2.TabIndex = 8
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(296, 65)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(544, 363)
        DataGridView1.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSeaGreen
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(51, 292)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 42)
        Button1.TabIndex = 10
        Button1.Text = "AGREGAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(161, 292)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 42)
        Button2.TabIndex = 11
        Button2.Text = "MODIFICAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(51, 340)
        Button3.Name = "Button3"
        Button3.Size = New Size(92, 42)
        Button3.TabIndex = 12
        Button3.Text = "ELIMINAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Salmon
        Button4.Location = New Point(161, 340)
        Button4.Name = "Button4"
        Button4.Size = New Size(92, 42)
        Button4.TabIndex = 13
        Button4.Text = "SALIR"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(29, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 18)
        Label6.TabIndex = 14
        Label6.Text = "Id Usuario"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(131, 66)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(146, 23)
        TextBox3.TabIndex = 15
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(51, 388)
        Button5.Name = "Button5"
        Button5.Size = New Size(92, 40)
        Button5.TabIndex = 16
        Button5.Text = "LIMPIAR"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' FormularioUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(864, 455)
        Controls.Add(Button5)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormularioUsuarios"
        Text = "FormularioUsuarios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button5 As Button
End Class
