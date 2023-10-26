Public Class AdministradorMenu
    Public DNI As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdministrarEmpleados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdministrarStock.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppComandaMenu.Show()
    End Sub
End Class