Public Class AppMenuTerminar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub AppMenuTerminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el DataGridView para mostrar los datos de los artículos.
        DataGridView1.DataSource = AppComandaMenu.articulos

        DataGridView1.Columns("Codigo").HeaderText = "Código"
        DataGridView1.Columns("Nombre").HeaderText = "Nombre"
        DataGridView1.Columns("Stock").HeaderText = "Stock"
        DataGridView1.Columns("Precio").HeaderText = "Precio"

        Dim totalPrecio As Decimal = 0
        For Each articulo As Articulo In AppComandaMenu.articulos
            totalPrecio += articulo.Precio * articulo.Stock
        Next

        ' Muestra la suma total en el Label.
        Label2.Text = "Total Precio: " & totalPrecio.ToString("C")
    End Sub
End Class