Public Class AppMenuDia
    Private Sub AppMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim groupBox1Selected As String = GetSelectedRadioButtonText(GroupBox1)
        Dim groupBox2Selected As String = GetSelectedRadioButtonText(GroupBox2)
        Dim groupBox3Selected As String = GetSelectedRadioButtonText(GroupBox3)

        If groupBox1Selected IsNot Nothing AndAlso groupBox2Selected IsNot Nothing AndAlso groupBox3Selected IsNot Nothing Then
            MessageBox.Show("Seleccionado en GroupBox1: " & groupBox1Selected & vbCrLf &
                        "Seleccionado en GroupBox2: " & groupBox2Selected & vbCrLf &
                        "Seleccionado en GroupBox3: " & groupBox3Selected)
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
End Class