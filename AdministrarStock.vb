Imports System.Data.SqlClient
Imports System.Net

Public Class AdministrarStock
    Private Cod_Producto As String
    Private cantidad As Integer
    Private Sub AdministrarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Dim sql As String = "SELECT COD_ARTICULO, NOMBRE, TIPO, STOCK, PRECIO FROM Articulos"

        ' Crea un nuevo comando SQL y adapta los resultados.
        Dim command As SqlCommand = New SqlCommand(sql, Login.connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim dataTable As DataTable = New DataTable()
        Try
            ' Llena el DataTable con los datos de la tabla Empleados.
            adapter.Fill(dataTable)

            ' Asigna el DataTable como origen de datos del DataGridView.
            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error al recuperar los datos: " & ex.Message)
        End Try
    End Sub

    Private Function ParseCantidad() As Integer
        Dim cantidad As Integer
        If Integer.TryParse(CantidadText.Text, cantidad) Then
            Return cantidad
        Else
            Return 0 ' Valor predeterminado si el análisis falla
        End If
    End Function

    Private Sub Sumar1_Click(sender As Object, e As EventArgs) Handles Sumar1.Click
        cantidad += 1
        CantidadText.Text = cantidad
    End Sub

    Private Sub Sumar10_Click(sender As Object, e As EventArgs) Handles Sumar10.Click
        cantidad += 10
        CantidadText.Text = cantidad
    End Sub

    Private Sub Restar1_Click(sender As Object, e As EventArgs) Handles Restar1.Click
        If cantidad > 1 Then
            cantidad -= 1
            CantidadText.Text = cantidad
        Else
            MessageBox.Show("El valor actual no es un número válido.")
        End If
    End Sub

    Private Sub Restar10_Click(sender As Object, e As EventArgs) Handles Restar10.Click
        If cantidad > 10 Then
            cantidad -= 10
            CantidadText.Text = cantidad
        Else
            MessageBox.Show("El valor actual no es un número válido.")
        End If
    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        Dim sqlUpdate As String = "UPDATE Articulos SET STOCK = " & CantidadText.Text & ", PRECIO = " & PrecioText.Text.Replace(",", ".") & " WHERE COD_ARTICULO = '" & Cod_Producto & "'"
        Login.EjecutarConsulta(sqlUpdate, "UPDATE")
        LoadTable()
        cantidad = 0
        Cod_Producto = ""
        CantidadText.Text = ""
        PrecioText.Text = ""
        ProductoText.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            ' Obten el valor de la celda en la columna "DNI" (o la columna que corresponda).
            Cod_Producto = DataGridView1.Rows(e.RowIndex).Cells("COD_ARTICULO").Value.ToString()
            Dim resultados As List(Of String) = Login.EjecutarConsulta("select  COD_ARTICULO, STOCK, PRECIO from Articulos where COD_ARTICULO = '" & Cod_Producto & "'", "SELECT", True)

            If resultados.Count > 0 Then
                ' Suponiendo que los datos se encuentran en un orden específico en la lista (por ejemplo, DNI, Contraseña, Puesto, Nombre, Apellidos, Antigüedad y Número de Seguridad Social):
                ProductoText.Text = resultados(0)
                CantidadText.Text = resultados(1)
                PrecioText.Text = resultados(2)
                cantidad = ParseCantidad()
            End If
        End If
    End Sub
End Class