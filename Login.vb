﻿Imports System.Data.SqlClient

Public Class Login
    ' Define una variable para la conexión a la base de datos
    Public connection As SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cadena de conexión
        Dim connectionString As String = "Data Source=sql518.sql.dinaserver.com;Initial Catalog=Reto1;User ID=AdminG2;Password=Reto01Ayuda-"

        ' Intenta establecer la conexión
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()

            ' Si la conexión se establece con éxito, imprime un mensaje de éxito en el log
            Console.WriteLine("Conexión exitosa a la base de datos.")
        Catch ex As Exception
            ' En caso de error, maneja la excepción aquí
            Console.WriteLine("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Function EjecutarConsulta(sql As String, consultaType As String, Optional obtenerTodosLosCampos As Boolean = False) As List(Of String)
        Dim results As New List(Of String)()

        ' Verifica que la conexión esté abierta antes de ejecutar una consulta
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            Dim command As New SqlCommand(sql, connection)

            If consultaType.ToUpper() = "SELECT" Then
                ' Consulta SELECT
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    If obtenerTodosLosCampos Then
                        ' Agrega todos los campos a la lista
                        For i As Integer = 0 To reader.FieldCount - 1
                            results.Add(reader.GetValue(i).ToString())
                        Next
                    Else
                        ' Agrega el campo especificado a la lista
                        results.Add(reader.GetString(0)) ' Ajusta esto según el campo que necesitas
                    End If
                End While
                reader.Close()
            ElseIf consultaType.ToUpper() = "INSERT" Or consultaType.ToUpper() = "UPDATE" Or consultaType.ToUpper() = "DELETE" Then
                ' Consulta INSERT, UPDATE o DELETE
                command.ExecuteNonQuery()
            End If
        Else
            ' La conexión no está abierta
            Console.WriteLine("La conexión a la base de datos no está disponible.")
        End If

        ' Devuelve la lista de resultados
        Return results
    End Function

    ' Cierra la conexión cuando la ventana se cierra
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
            Console.WriteLine("Conexión cerrada.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EjecutarConsulta("select contraseña from empleados where DNI = " + TextBox1.Text, "SELECT", True).First().Equals(TextBox2.Text) Then
            ' Load App
            Console.WriteLine("Ususario Existe")
            If EjecutarConsulta("select puesto from empleados where DNI = " + TextBox1.Text, "SELECT").First().Equals("Gerente") Then
                AdministradorMenu.DNI = TextBox1.Text
                TextBox1.Text = ""
                TextBox2.Text = ""
                AdministradorMenu.Show()
            Else
                ' Show()
            End If
        Else
            Console.WriteLine("Ususario NO Existe")
        End If
    End Sub
End Class