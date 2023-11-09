Public Class AppComandaMenu
    Public articulos As New List(Of Articulo)
    Public notas As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppGridElementos.elemento = "Bebida"
        AppGridElementos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AppMenuDia.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppGridElementos.elemento = "Carta"
        AppGridElementos.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AppMenuTerminar.Show()
    End Sub

    Private Sub AppComandaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class