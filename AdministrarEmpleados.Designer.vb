<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DniLabel = New System.Windows.Forms.Label()
        Me.ContraseñaLabel = New System.Windows.Forms.Label()
        Me.PuestoText = New System.Windows.Forms.TextBox()
        Me.NombreText = New System.Windows.Forms.TextBox()
        Me.ApellidosText = New System.Windows.Forms.TextBox()
        Me.AntiguedadText = New System.Windows.Forms.TextBox()
        Me.NSeguridadSocialText = New System.Windows.Forms.TextBox()
        Me.DNIText = New System.Windows.Forms.TextBox()
        Me.ContraseñaText = New System.Windows.Forms.TextBox()
        Me.AgregarButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.DespedirButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(908, 236)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Puesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Antiguedad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nº Seguridad Social"
        '
        'DniLabel
        '
        Me.DniLabel.AutoSize = True
        Me.DniLabel.Location = New System.Drawing.Point(547, 268)
        Me.DniLabel.Name = "DniLabel"
        Me.DniLabel.Size = New System.Drawing.Size(30, 16)
        Me.DniLabel.TabIndex = 6
        Me.DniLabel.Text = "DNI"
        '
        'ContraseñaLabel
        '
        Me.ContraseñaLabel.AutoSize = True
        Me.ContraseñaLabel.Location = New System.Drawing.Point(547, 326)
        Me.ContraseñaLabel.Name = "ContraseñaLabel"
        Me.ContraseñaLabel.Size = New System.Drawing.Size(76, 16)
        Me.ContraseñaLabel.TabIndex = 7
        Me.ContraseñaLabel.Text = "Contraseña"
        '
        'PuestoText
        '
        Me.PuestoText.Location = New System.Drawing.Point(37, 288)
        Me.PuestoText.Name = "PuestoText"
        Me.PuestoText.Size = New System.Drawing.Size(100, 22)
        Me.PuestoText.TabIndex = 8
        '
        'NombreText
        '
        Me.NombreText.Location = New System.Drawing.Point(37, 345)
        Me.NombreText.Name = "NombreText"
        Me.NombreText.Size = New System.Drawing.Size(100, 22)
        Me.NombreText.TabIndex = 9
        '
        'ApellidosText
        '
        Me.ApellidosText.Location = New System.Drawing.Point(37, 398)
        Me.ApellidosText.Name = "ApellidosText"
        Me.ApellidosText.Size = New System.Drawing.Size(100, 22)
        Me.ApellidosText.TabIndex = 10
        '
        'AntiguedadText
        '
        Me.AntiguedadText.Location = New System.Drawing.Point(284, 288)
        Me.AntiguedadText.Name = "AntiguedadText"
        Me.AntiguedadText.Size = New System.Drawing.Size(100, 22)
        Me.AntiguedadText.TabIndex = 11
        '
        'NSeguridadSocialText
        '
        Me.NSeguridadSocialText.Location = New System.Drawing.Point(284, 345)
        Me.NSeguridadSocialText.Name = "NSeguridadSocialText"
        Me.NSeguridadSocialText.Size = New System.Drawing.Size(126, 22)
        Me.NSeguridadSocialText.TabIndex = 12
        '
        'DNIText
        '
        Me.DNIText.Location = New System.Drawing.Point(550, 287)
        Me.DNIText.Name = "DNIText"
        Me.DNIText.Size = New System.Drawing.Size(100, 22)
        Me.DNIText.TabIndex = 13
        '
        'ContraseñaText
        '
        Me.ContraseñaText.Location = New System.Drawing.Point(550, 345)
        Me.ContraseñaText.Name = "ContraseñaText"
        Me.ContraseñaText.Size = New System.Drawing.Size(100, 22)
        Me.ContraseñaText.TabIndex = 14
        '
        'AgregarButton
        '
        Me.AgregarButton.Location = New System.Drawing.Point(739, 268)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(147, 46)
        Me.AgregarButton.TabIndex = 15
        Me.AgregarButton.Text = "Agregar"
        Me.AgregarButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(739, 373)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(147, 47)
        Me.ResetButton.TabIndex = 16
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'DespedirButton
        '
        Me.DespedirButton.Location = New System.Drawing.Point(739, 320)
        Me.DespedirButton.Name = "DespedirButton"
        Me.DespedirButton.Size = New System.Drawing.Size(147, 46)
        Me.DespedirButton.TabIndex = 17
        Me.DespedirButton.Text = "Despedir"
        Me.DespedirButton.UseVisualStyleBackColor = True
        Me.DespedirButton.Visible = False
        '
        'AdministrarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 445)
        Me.Controls.Add(Me.DespedirButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.AgregarButton)
        Me.Controls.Add(Me.ContraseñaText)
        Me.Controls.Add(Me.DNIText)
        Me.Controls.Add(Me.NSeguridadSocialText)
        Me.Controls.Add(Me.AntiguedadText)
        Me.Controls.Add(Me.ApellidosText)
        Me.Controls.Add(Me.NombreText)
        Me.Controls.Add(Me.PuestoText)
        Me.Controls.Add(Me.ContraseñaLabel)
        Me.Controls.Add(Me.DniLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdministrarEmpleados"
        Me.Text = "AdministrarEmpleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DniLabel As Label
    Friend WithEvents ContraseñaLabel As Label
    Friend WithEvents PuestoText As TextBox
    Friend WithEvents NombreText As TextBox
    Friend WithEvents ApellidosText As TextBox
    Friend WithEvents AntiguedadText As TextBox
    Friend WithEvents NSeguridadSocialText As TextBox
    Friend WithEvents DNIText As TextBox
    Friend WithEvents ContraseñaText As TextBox
    Friend WithEvents AgregarButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents DespedirButton As Button
End Class
