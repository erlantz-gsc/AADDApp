Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class AppMenuTerminar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSelect As String = "SELECT MAX(COD_COMANDA) FROM COMANDAS;"
        Dim cod_comanda = Login.EjecutarConsulta(sqlSelect, "SELECT").First() + 1
        Dim sqlInsert As String = "INSERT INTO COMANDAS (COD_COMANDA, DNI, NOTAS) VALUES ('" & cod_comanda & "', '" & Login.DNI & "', '" & RichTextBox1.Text & "')"
        Login.EjecutarConsulta(sqlInsert, "INSERT")
        For Each articulo As Articulo In AppComandaMenu.articulos
            Dim sqlArticuloInsert As String = "INSERT INTO ARTICULOS_COMANDAS (COD_ARTICULO, COD_COMANDA, CANTIDAD) VALUES ('" & articulo.Codigo & "', '" & cod_comanda & "', '" & articulo.Stock & "')"
            Login.EjecutarConsulta(sqlArticuloInsert, "INSERT")
            Dim sqlUpdate As String = "UPDATE Articulos SET STOCK = STOCK - " & articulo.Stock & " WHERE COD_ARTICULO = '" & articulo.Codigo & "'"
            Login.EjecutarConsulta(sqlUpdate, "UPDATE")
        Next
        AppComandaMenu.articulos.Clear()

        Me.Close()
    End Sub

    Private Sub AppMenuTerminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el DataGridView para mostrar los datos de los artículos.
        RichTextBox1.Text = AppComandaMenu.notas
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