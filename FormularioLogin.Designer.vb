<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 24F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(290, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 38)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(256, 208)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 42)
        Button1.TabIndex = 1
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(256, 111)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(319, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(136, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 18)
        Label2.TabIndex = 3
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(136, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 18)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(256, 156)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(319, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(400, 208)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 42)
        Button2.TabIndex = 6
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormularioLogin1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(706, 317)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormularioLogin1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
End Class
