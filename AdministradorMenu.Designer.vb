<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministradorMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 149)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Administrar Empleados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 149)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Administrar Stock"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(368, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 149)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "App Comandas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AdministradorMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 295)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AdministradorMenu"
        Me.Text = "AdministradorMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
