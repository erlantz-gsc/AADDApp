Public Class AppMenuDia
    Private Sub AppMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim groupBox1Selected As String = GetSelectedRadioButtonText(GroupBox1)
        Dim groupBox2Selected As String = GetSelectedRadioButtonText(GroupBox2)
        Dim groupBox3Selected As String = GetSelectedRadioButtonText(GroupBox3)

        If groupBox1Selected IsNot Nothing AndAlso groupBox2Selected IsNot Nothing AndAlso groupBox3Selected IsNot Nothing Then
            Dim notas As String = "Menu: " & vbCrLf &
                            "Primer plato - " & groupBox1Selected & vbCrLf &
                            "Segundo plato - " & groupBox2Selected & vbCrLf &
                            "Postre - " & groupBox3Selected & vbCrLf
            AppComandaMenu.notas += notas

            Dim articuloExistente As Articulo = AppComandaMenu.articulos.Find(Function(a) a.Nombre = "Menu")

            If articuloExistente IsNot Nothing Then
                ' Actualiza la cantidad en la lista con el valor del DataGridView
                articuloExistente.Stock += 1
            Else
                Dim nuevoArticulo As New Articulo()
                nuevoArticulo.Codigo = 0
                nuevoArticulo.Nombre = "Menu"
                nuevoArticulo.Stock = 1
                nuevoArticulo.Tipo = "Menu"
                nuevoArticulo.Precio = 20
                AppComandaMenu.articulos.Add(nuevoArticulo)
            End If

            Me.Close()
        Else
            MessageBox.Show("Alguno de los GroupBox no tiene un RadioButton seleccionado.")
        End If
    End Sub
    Private Function GetSelectedRadioButtonText(groupBox As GroupBox) As String
        ' Obtiene el texto del RadioButton seleccionado en un GroupBox
        For Each control As Control In groupBox.Controls
            If TypeOf control Is RadioButton AndAlso DirectCast(control, RadioButton).Checked Then
                Return DirectCast(control, RadioButton).Text
            End If
        Next
        Return Nothing
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class