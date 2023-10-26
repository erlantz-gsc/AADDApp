Imports System.Data.SqlClient

Public Class AppGridElementos

    Dim dataTable As DataTable = New DataTable()
    Dim elemento As String
    Private Sub AppGridElementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Realiza la consulta y obtén un DataTable
        Dim sql As String = "SELECT COD_ARTICULO, STOCK, PRECIO FROM Articulos"

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
            btn.Text = row("COD_ARTICULO").ToString()
            btn.Tag = row ' Almacena la fila de datos en el Tag del botón
            AddHandler btn.Click, AddressOf BotonArticulo_Click ' Asocia un controlador de eventos al botón
            FlowLayoutPanel1.Controls.Add(btn)
        Next
        DataGridView1.Columns.Add("Codigo", "Código Artículo")
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
            If row.Cells("Codigo").Value IsNot Nothing AndAlso row.Cells("Codigo").Value.ToString() = dataRow("COD_ARTICULO").ToString() Then
                articuloExistente = row
                Exit For
            End If
        Next

        ' Si el artículo ya existe, aumenta la cantidad y actualiza el precio total
        If articuloExistente IsNot Nothing Then
            Dim cantidad As Integer = Convert.ToInt32(articuloExistente.Cells("Cantidad").Value)
            cantidad += 1
            articuloExistente.Cells("Cantidad").Value = cantidad

            Dim precio As Decimal = Convert.ToDecimal(dataRow("PRECIO"))
            Dim totalPrecio As Decimal = Convert.ToDecimal(Label1.Text.Replace("Total Precio: ", "").Replace("€", ""))
            totalPrecio += precio
            Label1.Text = "Total Precio: " & totalPrecio.ToString("C") ' Formatea el total como moneda
        Else
            ' Si el artículo no existe, agrega una nueva fila con cantidad 1
            DataGridView1.Rows.Add(dataRow("COD_ARTICULO"), 1, dataRow("PRECIO"))

            ' Calcula el precio total
            Dim totalPrecio As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Precio").Value IsNot Nothing AndAlso IsNumeric(row.Cells("Precio").Value) Then
                    totalPrecio += Convert.ToDecimal(row.Cells("Precio").Value) * Convert.ToInt32(row.Cells("Cantidad").Value)
                End If
            Next

            ' Muestra el total en Label1
            Label1.Text = "Total Precio: " & totalPrecio.ToString("C") & "€" ' Formatea el total como moneda
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
            End If
        End If
    End Sub
End Class