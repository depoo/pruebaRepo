<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        DataGridView1 = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(321, 83)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(459, 364)
        DataGridView1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(157, 145)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 188)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(142, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Salmon
        Button4.Location = New Point(103, 410)
        Button4.Name = "Button4"
        Button4.Size = New Size(121, 44)
        Button4.TabIndex = 8
        Button4.Text = "SALIR"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkSeaGreen
        Button5.Location = New Point(30, 293)
        Button5.Name = "Button5"
        Button5.Size = New Size(121, 44)
        Button5.TabIndex = 9
        Button5.Text = "AGREGAR"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(30, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 18)
        Label2.TabIndex = 10
        Label2.Text = "Trabajador"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(30, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 18)
        Label3.TabIndex = 11
        Label3.Text = "Núm.Contacto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(30, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 18)
        Label4.TabIndex = 12
        Label4.Text = "Operador"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(157, 241)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(142, 23)
        ComboBox2.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(30, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 44)
        Button1.TabIndex = 14
        Button1.Text = "MODIFICAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(169, 353)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 44)
        Button2.TabIndex = 15
        Button2.Text = "ELIMINAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(30, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 18)
        Label5.TabIndex = 17
        Label5.Text = "Id. telefono"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(142, 23)
        TextBox2.TabIndex = 16
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(169, 293)
        Button3.Name = "Button3"
        Button3.Size = New Size(121, 44)
        Button3.TabIndex = 18
        Button3.Text = "LIMPIAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' NumContactoTrabajador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(800, 473)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button5)
        Controls.Add(Button4)
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
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
End Class
