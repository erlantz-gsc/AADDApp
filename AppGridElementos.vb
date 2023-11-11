Imports System.Data.SqlClient

Public Class AppGridElementos

    Dim dataTable As DataTable = New DataTable()
    Public elemento As String
    Private Sub AppGridElementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Realiza la consulta y obtén un DataTable
        Dim sql As String = "SELECT COD_ARTICULO, NOMBRE, TIPO, STOCK, PRECIO FROM Articulos WHERE TIPO ='" + elemento + "' AND STOCK > 0"

        ' Crea un nuevo comando SQL y adapta los resultados.
        Dim command As SqlCommand = New SqlCommand(sql, Login.connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Try
            ' Llena el DataTable con los datos de la tabla Empleados.
            adapter.Fill(dataTable)

        Catch ex As Exception
            MessageBox.Show("Error al recuperar los datos: " & ex.Message)
        End Try

        ' Recorre el DataTable y crea botones en el FlowLayoutPanel
        For Each row As DataRow In dataTable.Rows
            ' Crea un nuevo botón
            Dim btn As New Button()
            btn.BackColor = Color.FromArgb(39, 113, 185)
            btn.ForeColor = Color.White
            btn.Size = New Size(103, 67)
            btn.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)

            btn.Text = row("NOMBRE").ToString()
            btn.Tag = row ' Almacena la fila de datos en el Tag del botón
            AddHandler btn.Click, AddressOf BotonArticulo_Click ' Asocia un controlador de eventos al botón
            FlowLayoutPanel1.Controls.Add(btn)
        Next
        DataGridView1.Columns.Add("Codigo", "Codigo")
        DataGridView1.Columns.Add("Nombre", "Nombre")
        DataGridView1.Columns.Add("Cantidad", "Cantidad")
        DataGridView1.Columns.Add("Precio", "Precio")
    End Sub

    Private Sub BotonArticulo_Click(sender As Object, e As EventArgs)
        ' Manejar el evento de clic del botón
        Dim btn As Button = DirectCast(sender, Button)
        Dim dataRow As DataRow = DirectCast(btn.Tag, DataRow)

        ' Busca el artículo en el DataGridView
        Dim articuloExistente As DataGridViewRow = Nothing
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Nombre").Value IsNot Nothing AndAlso row.Cells("Nombre").Value.ToString() = dataRow("NOMBRE").ToString() Then
                articuloExistente = row
                Exit For
            End If
        Next

        Dim stock As Integer = Convert.ToInt32(dataRow("STOCK"))
        If articuloExistente IsNot Nothing Then
            Dim cantidad As Integer = Convert.ToInt32(articuloExistente.Cells("Cantidad").Value)
            cantidad += 1

            ' Verifica si la cantidad es mayor o igual que el stock
            If cantidad >= stock Then
                btn.Visible = False
            End If
            articuloExistente.Cells("Cantidad").Value = cantidad

            Dim precio As Decimal = Convert.ToDecimal(dataRow("PRECIO"))
            Dim totalPrecio As Decimal = Convert.ToDecimal(Label1.Text.Replace("TOTAL PRECIO: ", "").Replace("€", ""))
            totalPrecio += precio
            Label1.Text = "TOTAL PRECIO: " & totalPrecio.ToString("C") ' Formatea el total como moneda
        Else
            ' Si el artículo no existe, agrega una nueva fila con cantidad 1
            DataGridView1.Rows.Add(dataRow("COD_ARTICULO"), dataRow("NOMBRE"), 1, dataRow("PRECIO"))

            ' Calcula el precio total
            Dim totalPrecio As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Precio").Value IsNot Nothing AndAlso IsNumeric(row.Cells("Precio").Value) Then
                    totalPrecio += Convert.ToDecimal(row.Cells("Precio").Value) * Convert.ToInt32(row.Cells("Cantidad").Value)
                End If
            Next

            ' Muestra el total en Label1
            Label1.Text = "TOTAL PRECIO: " & totalPrecio.ToString("C") ' Formatea el total como moneda
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verifica si se hizo clic en una celda de la columna de Cantidad (ajusta el nombre de la columna según tu configuración)
        If e.ColumnIndex = DataGridView1.Columns("Cantidad").Index AndAlso e.RowIndex >= 0 Then
            Dim cantidad As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Cantidad").Value)

            ' Si la cantidad es mayor que 0, resta uno; de lo contrario, elimina la fila
            If cantidad > 0 Then
                cantidad -= 1
                DataGridView1.Rows(e.RowIndex).Cells("Cantidad").Value = cantidad

                ' Actualiza el precio total restando el precio del artículo
                Dim precio As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("Precio").Value)
                Dim totalPrecio As Decimal = Convert.ToDecimal(Label1.Text.Replace("Total Precio: ", "").Replace("€", ""))
                totalPrecio -= precio
                Label1.Text = "Total Precio: " & totalPrecio.ToString("C") ' Formatea el total como moneda

                ' Si la cantidad llega a 0, elimina la fila
                If cantidad = 0 Then
                    DataGridView1.Rows.RemoveAt(e.RowIndex)
                End If
                For Each btn As Button In FlowLayoutPanel1.Controls
                    Dim dataRow As DataRow = DirectCast(btn.Tag, DataRow)
                    Dim stock As Integer = Convert.ToInt32(dataRow("STOCK"))
                    btn.Visible = (cantidad < stock)
                Next
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Agrega los artículos del DataGridView a la lista articulos en AppMenuTerminar
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim codigo As Integer = row.Cells(0).Value
            Dim nombre As String = row.Cells("Nombre").Value
            Dim cantidad As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)
            Dim precio As Decimal = row.Cells("Precio").Value

            ' Busca el artículo en la lista articulos
            Dim articuloExistente As Articulo = AppComandaMenu.articulos.Find(Function(a) a.Nombre = nombre)

            If articuloExistente IsNot Nothing Then
                ' Actualiza la cantidad en la lista con el valor del DataGridView
                articuloExistente.Stock += cantidad
            ElseIf (codigo <> 0) Then
                ' Si el artículo no existe en la lista, crea uno nuevo y agrégalo
                Dim nuevoArticulo As New Articulo()
                nuevoArticulo.Codigo = codigo
                nuevoArticulo.Nombre = nombre
                nuevoArticulo.Stock = cantidad
                nuevoArticulo.Tipo = elemento
                nuevoArticulo.Precio = precio
                AppComandaMenu.articulos.Add(nuevoArticulo)
            End If
        Next

        ' Cierra el formulario AppGridElementos
        Me.Close()
    End Sub


End Class