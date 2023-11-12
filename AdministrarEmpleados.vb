Imports System.Data.SqlClient

Public Class AdministrarEmpleados

    Private DNI As String

    Private Sub AdministrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub LoadTable()
        Dim sql As String = "SELECT * FROM Empleados"

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
        Dim puestoColumn As DataColumn = dataTable.Columns("Puesto")
        Dim uniquePuestos As List(Of String) = dataTable.AsEnumerable().Select(Function(row) row.Field(Of String)(puestoColumn)).Distinct().ToList()
        PuestoCombo.DataSource = uniquePuestos
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            ' Obtén el valor de la celda en la columna "DNI" (o la columna que corresponda).
            DNI = DataGridView1.Rows(e.RowIndex).Cells("DNI").Value.ToString()
            DNIText.Visible = False
            DniLabel.Visible = False
            ContraseñaText.Visible = False
            ContraseñaLabel.Visible = False
            DespedirButton.Visible = True
            AgregarButton.Text = "Modificar"

            ' Obtén la fila correspondiente en el DataTable.
            Dim row As DataRow = DirectCast(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView).Row

            If row IsNot Nothing Then
                ' Utiliza los datos de la fila para llenar los campos.
                DNIText.Text = row("DNI").ToString()
                ContraseñaText.Text = row("CONTRASEÑA").ToString()
                If row("Puesto").ToString() = "Camarero" Then
                    PuestoCombo.SelectedIndex = 0
                ElseIf row("Puesto").ToString() = "Gerente" Then
                    PuestoCombo.SelectedIndex = 1
                End If
                NombreText.Text = row("NOMBRE").ToString()
                ApellidosText.Text = row("APELLIDOS").ToString()
                AntiguedadText.Text = row("ANTIGUEDAD").ToString()
                NSeguridadSocialText.Text = row("N_SEGURIDAD_SOCIAL").ToString()
            End If
        End If
    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click
        If String.IsNullOrWhiteSpace(DNI) Then
            ' DNI está vacío, realiza una inserción
            Dim sqlInsert As String = "INSERT INTO empleados (DNI, PUESTO, NOMBRE, APELLIDOS, ANTIGUEDAD, N_SEGURIDAD_SOCIAL, CONTRASEÑA) VALUES ('" & DNIText.Text & "', '" & PuestoCombo.SelectedText & "', '" & NombreText.Text & "', '" & ApellidosText.Text & "', '" & AntiguedadText.Text & "', '" & NSeguridadSocialText.Text & "', '" & ContraseñaText.Text & "')"
            Login.EjecutarConsulta(sqlInsert, "INSERT")
        Else
            ' DNI no está vacío, realiza una actualización
            Dim sqlUpdate As String = "UPDATE empleados SET DNI = '" & DNIText.Text & "', PUESTO = '" & PuestoCombo.SelectedText & "', NOMBRE = '" & NombreText.Text & "', APELLIDOS = '" & ApellidosText.Text & "', ANTIGUEDAD = '" & AntiguedadText.Text & "', N_SEGURIDAD_SOCIAL = '" & NSeguridadSocialText.Text & "', CONTRASEÑA = '" & ContraseñaText.Text & "' WHERE DNI = '" & DNI & "'"
            Login.EjecutarConsulta(sqlUpdate, "UPDATE")
        End If
        Reset()
        LoadTable()
    End Sub

    Private Sub DespedirButton_Click(sender As Object, e As EventArgs) Handles DespedirButton.Click
        If Not String.IsNullOrWhiteSpace(DNI) Then
            ' DNI no está vacío, realiza una eliminación
            Dim sqlDelete As String = "DELETE FROM empleados WHERE DNI = '" & DNI & "'"
            Login.EjecutarConsulta(sqlDelete, "DELETE")
        End If
        Reset()
        LoadTable()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub

    Private Sub Reset()
        DNIText.Visible = True
        DniLabel.Visible = True
        ContraseñaText.Visible = True
        ContraseñaLabel.Visible = True
        DespedirButton.Visible = False
        AgregarButton.Text = "Añadir"
        DNIText.Text = ""
        ContraseñaText.Text = ""
        PuestoCombo.SelectedIndex = 0
        NombreText.Text = ""
        ApellidosText.Text = ""
        AntiguedadText.Text = ""
        NSeguridadSocialText.Text = ""
    End Sub
End Class
