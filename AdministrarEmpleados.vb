﻿Imports System.Data.SqlClient

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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            ' Obten el valor de la celda en la columna "DNI" (o la columna que corresponda).
            DNI = DataGridView1.Rows(e.RowIndex).Cells("DNI").Value.ToString()
            DNIText.Visible = False
            DniLabel.Visible = False
            ContraseñaText.Visible = False
            ContraseñaLabel.Visible = False
            DespedirButton.Visible = True
            AgregarButton.Text = "Modificar"
            Dim resultados As List(Of String) = Login.EjecutarConsulta("select * from empleados where DNI = '" & DNI & "'", "SELECT", True)

            If resultados.Count > 0 Then
                ' Suponiendo que los datos se encuentran en un orden específico en la lista (por ejemplo, DNI, Contraseña, Puesto, Nombre, Apellidos, Antigüedad y Número de Seguridad Social):
                DNIText.Text = resultados(0)
                ContraseñaText.Text = resultados(6)
                PuestoText.Text = resultados(1)
                NombreText.Text = resultados(2)
                ApellidosText.Text = resultados(3)
                AntiguedadText.Text = resultados(4)
                NSeguridadSocialText.Text = resultados(5)
            End If
        End If
    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click
        If String.IsNullOrWhiteSpace(DNI) Then
            ' DNI está vacío, realiza una inserción
            Dim sqlInsert As String = "INSERT INTO empleados (DNI, PUESTO, NOMBRE, APELLIDOS, ANTIGUEDAD, N_SEGURIDAD_SOCIAL, CONTRASEÑA) VALUES ('" & DNIText.Text & "', '" & PuestoText.Text & "', '" & NombreText.Text & "', '" & ApellidosText.Text & "', '" & AntiguedadText.Text & "', '" & NSeguridadSocialText.Text & "', '" & ContraseñaText.Text & "')"
            Login.EjecutarConsulta(sqlInsert, "INSERT")
        Else
            ' DNI no está vacío, realiza una actualización
            Dim sqlUpdate As String = "UPDATE empleados SET DNI = '" & DNIText.Text & "', PUESTO = '" & PuestoText.Text & "', NOMBRE = '" & NombreText.Text & "', APELLIDOS = '" & ApellidosText.Text & "', ANTIGUEDAD = '" & AntiguedadText.Text & "', N_SEGURIDAD_SOCIAL = '" & NSeguridadSocialText.Text & "', CONTRASEÑA = '" & ContraseñaText.Text & "' WHERE DNI = '" & DNI & "'"
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
        PuestoText.Text = ""
        NombreText.Text = ""
        ApellidosText.Text = ""
        AntiguedadText.Text = ""
        NSeguridadSocialText.Text = ""
    End Sub
End Class