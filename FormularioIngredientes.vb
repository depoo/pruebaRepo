Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports OfficeOpenXml

Public Class FormularioIngredientes1

    Dim Valor As Integer
    Dim Id As Integer
    Dim excelPackage As ExcelPackage

    Private Sub CargarData(DATO As Integer)
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From A In dbContext.Almacen
                        Join P In dbContext.Productos On A.id_Productos Equals P.id_Producto
                        Join C In dbContext.Categorias On A.id_Categoria Equals C.id_Categoria
                        Join U In dbContext.UnidadMedida On A.id_Unidad Equals U.id_Unidad
                        Where A.id_Categoria = DATO
                        Select New With {
                            .ID = A.id_Almacen,
                            .NOBRE = P.nombre_Producto,
                            .CANTIDAD = A.Cantidad,
                            .Unidad = U.unidad
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub CargarDataComboBox()
        Try
            Using dbContext As New MiDbContext()
                Dim query = From A In dbContext.Almacen
                            Join P In dbContext.Productos On A.id_Productos Equals P.id_Producto
                            Join C In dbContext.Categorias On A.id_Categoria Equals C.id_Categoria
                            Join U In dbContext.UnidadMedida On A.id_Unidad Equals U.id_Unidad
                            Select New With {
                            .ID = A.id_Almacen,
                            .IDPRODUCTO = A.id_Productos,
                            .NOMBRE = P.nombre_Producto,
                            .CANTIDAD = A.Cantidad,
                            .Unidad = U.unidad
                        }

                ComboBox1.DataSource = query.ToList()
                ComboBox1.DisplayMember = "NOMBRE"
                ComboBox1.ValueMember = "ID"
            End Using
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ComboBox1.Text = row.Cells("NOBRE").Value.ToString()
        End If
    End Sub

    Private Sub CargarData2()
        Try
            Dim dbContext As New MiDbContext()
            Dim query = From A In dbContext.Almacen
                        Join P In dbContext.Productos On A.id_Productos Equals P.id_Producto
                        Join C In dbContext.Categorias On A.id_Categoria Equals C.id_Categoria
                        Join U In dbContext.UnidadMedida On A.id_Unidad Equals U.id_Unidad
                        Select New With {
                            .ID = A.id_Almacen,
                            .NOBRE = P.nombre_Producto,
                            .CANTIDAD = A.Cantidad,
                            .Unidad = U.unidad
                            }
            DataGridView1.DataSource = query.ToList()
        Catch ex As Exception
            cajademensaje.Errordeobtencion()
        End Try
    End Sub

    Private Sub FormularioIngredientes1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarData2()
        CargarDataComboBox()
        ComboBox1.Text = ""
        ComboBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "VERDURAS"
        Dim dato As Integer = 1
        CargarData(dato)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label1.Text = "CEREALES"
        Dim dato As Integer = 2
        CargarData(dato)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label1.Text = "LEGUMBRES"
        Dim dato As Integer = 3
        CargarData(dato)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.Text = "FRUTAS"
        Dim dato As Integer = 5
        CargarData(dato)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Text = "LÁCTEOS"
        Dim dato As Integer = 6
        CargarData(dato)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Text = "GRASAS"
        Dim dato As Integer = 7
        CargarData(dato)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "CARNES"
        Dim dato As Integer = 4
        CargarData(dato)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        FormularioLogin.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Nuevo_Producto.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim Id As Integer = ComboBox1.SelectedValue
        Dim Valor As Integer = Integer.Parse(TextBox3.Text)
        Try
            Using dbContext As New MiDbContext()
                Dim Almacen = dbContext.Almacen.Find(Id)
                If Almacen IsNot Nothing Then
                    Dim nuevaCantidad As Integer = Almacen.Cantidad + Valor
                    Almacen.Cantidad = nuevaCantidad
                    dbContext.SaveChanges()
                    cajademensaje.Actualizacionderegistro()
                    CargarData2()
                Else
                    cajademensaje.Actualizacionderegistro2()
                End If
            End Using
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Id As Integer = ComboBox1.SelectedValue
        Dim Valor As Integer = Integer.Parse(TextBox1.Text)
        Try
            Using dbContext As New MiDbContext()
                Dim Almacen = dbContext.Almacen.Find(Id)
                If Almacen IsNot Nothing Then
                    Dim nuevaCantidad As Integer = Almacen.Cantidad - Valor
                    Almacen.Cantidad = nuevaCantidad
                    dbContext.SaveChanges()
                    cajademensaje.Actualizacionderegistro()
                    CargarData2()
                Else
                    cajademensaje.Actualizacionderegistro2()
                End If
            End Using
        Catch ex As Exception
            cajademensaje.errorglobal()
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Archivos PDF|*.pdf"
        saveDialog.Title = "Guardar PDF"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveDialog.FileName

            Dim doc As New iTextSharp.text.Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()

            Dim table As New PdfPTable(DataGridView1.Columns.Count)

            For Each column As DataGridViewColumn In DataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                table.AddCell(cell)
            Next

            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                    Dim pdfCell As New PdfPCell(New Phrase(cellValue))
                    table.AddCell(pdfCell)
                Next
            Next

            doc.Add(table)
            doc.Close()

            MessageBox.Show("PDF generado exitosamente.", "Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        ' Crear un nuevo archivo de Excel
        ExcelPackage = New ExcelPackage()

        ' Agregar una hoja de trabajo al archivo de Excel
        Dim worksheet As ExcelWorksheet = excelPackage.Workbook.Worksheets.Add("Datos")

        ' Obtener los datos del DataGridView
        Dim rowCount As Integer = DataGridView1.Rows.Count
        Dim columnCount As Integer = DataGridView1.Columns.Count

        ' Escribir los encabezados de columna en el archivo de Excel
        For c As Integer = 0 To columnCount - 1
            worksheet.Cells(1, c + 1).Value = DataGridView1.Columns(c).HeaderText
        Next

        ' Escribir los datos del DataGridView en el archivo de Excel
        For r As Integer = 0 To rowCount - 1
            For c As Integer = 0 To columnCount - 1
                worksheet.Cells(r + 2, c + 1).Value = DataGridView1.Rows(r).Cells(c).Value
            Next
        Next

        ' Guardar el archivo de Excel
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos de Excel|*.xlsx"
        saveFileDialog.Title = "Guardar archivo de Excel"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim excelFile As New FileInfo(saveFileDialog.FileName)
            excelPackage.SaveAs(excelFile)
            MessageBox.Show("Archivo de Excel generado exitosamente.")
        End If
    End Sub

End Class