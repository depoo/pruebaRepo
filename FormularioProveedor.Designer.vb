<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioProveedor
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(171, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 25)
        Label1.TabIndex = 0
        Label1.Text = "PROVEEDORES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Id Proveedor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(210, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nombre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(30, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(111, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(74, 113)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 32)
        Button1.TabIndex = 9
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(171, 113)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 32)
        Button2.TabIndex = 10
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(267, 113)
        Button3.Name = "Button3"
        Button3.Size = New Size(80, 32)
        Button3.TabIndex = 11
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(364, 113)
        Button4.Name = "Button4"
        Button4.Size = New Size(80, 32)
        Button4.TabIndex = 12
        Button4.Text = "Salir"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(81, 169)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(349, 205)
        DataGridView1.TabIndex = 13
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(183, 66)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(129, 23)
        ComboBox2.TabIndex = 14
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(338, 66)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(356, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 16
        Label4.Text = "Clasificación"
        ' 
        ' FormularioProveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(486, 420)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(ComboBox2)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormularioProveedor"
        Text = "FormularioProveedor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
