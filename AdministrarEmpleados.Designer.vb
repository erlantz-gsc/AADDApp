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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarEmpleados))
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
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(450, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1017, 544)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Puesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(244, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(244, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Antiguedad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nº Seguridad Social"
        '
        'DniLabel
        '
        Me.DniLabel.AutoSize = True
        Me.DniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.DniLabel.ForeColor = System.Drawing.Color.White
        Me.DniLabel.Location = New System.Drawing.Point(34, 261)
        Me.DniLabel.Name = "DniLabel"
        Me.DniLabel.Size = New System.Drawing.Size(57, 29)
        Me.DniLabel.TabIndex = 6
        Me.DniLabel.Text = "DNI"
        '
        'ContraseñaLabel
        '
        Me.ContraseñaLabel.AutoSize = True
        Me.ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ContraseñaLabel.ForeColor = System.Drawing.Color.White
        Me.ContraseñaLabel.Location = New System.Drawing.Point(244, 261)
        Me.ContraseñaLabel.Name = "ContraseñaLabel"
        Me.ContraseñaLabel.Size = New System.Drawing.Size(146, 29)
        Me.ContraseñaLabel.TabIndex = 7
        Me.ContraseñaLabel.Text = "Contraseña"
        '
        'PuestoText
        '
        Me.PuestoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PuestoText.Location = New System.Drawing.Point(39, 56)
        Me.PuestoText.Multiline = True
        Me.PuestoText.Name = "PuestoText"
        Me.PuestoText.Size = New System.Drawing.Size(164, 32)
        Me.PuestoText.TabIndex = 8
        '
        'NombreText
        '
        Me.NombreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreText.Location = New System.Drawing.Point(39, 133)
        Me.NombreText.Multiline = True
        Me.NombreText.Name = "NombreText"
        Me.NombreText.Size = New System.Drawing.Size(164, 32)
        Me.NombreText.TabIndex = 9
        '
        'ApellidosText
        '
        Me.ApellidosText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosText.Location = New System.Drawing.Point(249, 133)
        Me.ApellidosText.Multiline = True
        Me.ApellidosText.Name = "ApellidosText"
        Me.ApellidosText.Size = New System.Drawing.Size(173, 32)
        Me.ApellidosText.TabIndex = 10
        '
        'AntiguedadText
        '
        Me.AntiguedadText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AntiguedadText.Location = New System.Drawing.Point(249, 56)
        Me.AntiguedadText.Multiline = True
        Me.AntiguedadText.Name = "AntiguedadText"
        Me.AntiguedadText.Size = New System.Drawing.Size(173, 32)
        Me.AntiguedadText.TabIndex = 11
        '
        'NSeguridadSocialText
        '
        Me.NSeguridadSocialText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NSeguridadSocialText.Location = New System.Drawing.Point(39, 216)
        Me.NSeguridadSocialText.Multiline = True
        Me.NSeguridadSocialText.Name = "NSeguridadSocialText"
        Me.NSeguridadSocialText.Size = New System.Drawing.Size(232, 32)
        Me.NSeguridadSocialText.TabIndex = 12
        '
        'DNIText
        '
        Me.DNIText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNIText.Location = New System.Drawing.Point(39, 293)
        Me.DNIText.Multiline = True
        Me.DNIText.Name = "DNIText"
        Me.DNIText.Size = New System.Drawing.Size(164, 32)
        Me.DNIText.TabIndex = 13
        '
        'ContraseñaText
        '
        Me.ContraseñaText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaText.Location = New System.Drawing.Point(249, 293)
        Me.ContraseñaText.Multiline = True
        Me.ContraseñaText.Name = "ContraseñaText"
        Me.ContraseñaText.Size = New System.Drawing.Size(173, 32)
        Me.ContraseñaText.TabIndex = 14
        '
        'AgregarButton
        '
        Me.AgregarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.AgregarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AgregarButton.ForeColor = System.Drawing.Color.White
        Me.AgregarButton.Location = New System.Drawing.Point(39, 355)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(164, 72)
        Me.AgregarButton.TabIndex = 15
        Me.AgregarButton.Text = "Agregar"
        Me.AgregarButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(226, 354)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(170, 73)
        Me.ResetButton.TabIndex = 16
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'DespedirButton
        '
        Me.DespedirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DespedirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DespedirButton.ForeColor = System.Drawing.Color.White
        Me.DespedirButton.Location = New System.Drawing.Point(39, 446)
        Me.DespedirButton.Name = "DespedirButton"
        Me.DespedirButton.Size = New System.Drawing.Size(357, 84)
        Me.DespedirButton.TabIndex = 17
        Me.DespedirButton.Text = "Despedir"
        Me.DespedirButton.UseVisualStyleBackColor = False
        Me.DespedirButton.Visible = False
        '
        'AdministrarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1479, 568)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdministrarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Empleados"
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
