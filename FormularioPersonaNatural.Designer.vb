﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Button4 = New Button()
        Button5 = New Button()
        ComboBox2 = New ComboBox()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(31, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 18)
        Label1.TabIndex = 0
        Label1.Text = "IDTRABAJADOR"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSeaGreen
        Button1.Location = New Point(31, 301)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 40)
        Button1.TabIndex = 1
        Button1.Text = "AGREGAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(175, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(137, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(31, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 3
        Label2.Text = "NOMBRE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(31, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 18)
        Label3.TabIndex = 6
        Label3.Text = "TIPODocumento"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(175, 79)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(137, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(175, 209)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(137, 23)
        TextBox4.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(31, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 18)
        Label4.TabIndex = 9
        Label4.Text = "N°Documento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(31, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 18)
        Label5.TabIndex = 10
        Label5.Text = "GÉNERO"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(31, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 18)
        Label6.TabIndex = 11
        Label6.Text = "APELLIDO"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(175, 121)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(137, 23)
        TextBox6.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(131, 301)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 40)
        Button2.TabIndex = 14
        Button2.Text = "MODIFICAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(229, 301)
        Button3.Name = "Button3"
        Button3.Size = New Size(83, 40)
        Button3.TabIndex = 15
        Button3.Text = "ELIMINAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(347, 32)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(614, 401)
        DataGridView1.TabIndex = 16
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(175, 162)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(137, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(131, 347)
        Button4.Name = "Button4"
        Button4.Size = New Size(83, 40)
        Button4.TabIndex = 18
        Button4.Text = "LIMPIAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Salmon
        Button5.Location = New Point(229, 347)
        Button5.Name = "Button5"
        Button5.Size = New Size(83, 40)
        Button5.TabIndex = 19
        Button5.Text = "SALIR"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(175, 256)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(137, 23)
        ComboBox2.TabIndex = 20
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(31, 347)
        Button6.Name = "Button6"
        Button6.Size = New Size(83, 40)
        Button6.TabIndex = 21
        Button6.Text = "NÚM.TELF."
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(31, 393)
        Button7.Name = "Button7"
        Button7.Size = New Size(83, 40)
        Button7.TabIndex = 22
        Button7.Text = "ASIG. ROL"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(131, 393)
        Button8.Name = "Button8"
        Button8.Size = New Size(83, 40)
        Button8.TabIndex = 23
        Button8.Text = "Proveedor"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' FormularioPersonaNatural
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(985, 460)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(ComboBox2)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "FormularioPersonaNatural"
        Text = "PersonaNatural"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
