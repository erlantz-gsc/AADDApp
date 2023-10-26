<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarStock
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
        Me.ProductoText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrecioText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CantidadText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Restar1 = New System.Windows.Forms.Button()
        Me.Restar10 = New System.Windows.Forms.Button()
        Me.Sumar10 = New System.Windows.Forms.Button()
        Me.Sumar1 = New System.Windows.Forms.Button()
        Me.ModificarButton = New System.Windows.Forms.Button()
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
        Me.DataGridView1.Size = New System.Drawing.Size(776, 323)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductoText
        '
        Me.ProductoText.Enabled = False
        Me.ProductoText.Location = New System.Drawing.Point(22, 376)
        Me.ProductoText.Name = "ProductoText"
        Me.ProductoText.Size = New System.Drawing.Size(100, 22)
        Me.ProductoText.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo Producto"
        '
        'PrecioText
        '
        Me.PrecioText.Location = New System.Drawing.Point(163, 376)
        Me.PrecioText.Name = "PrecioText"
        Me.PrecioText.Size = New System.Drawing.Size(100, 22)
        Me.PrecioText.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Precio"
        '
        'CantidadText
        '
        Me.CantidadText.Enabled = False
        Me.CantidadText.Location = New System.Drawing.Point(395, 376)
        Me.CantidadText.Name = "CantidadText"
        Me.CantidadText.Size = New System.Drawing.Size(100, 22)
        Me.CantidadText.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cantidad"
        '
        'Restar1
        '
        Me.Restar1.Location = New System.Drawing.Point(358, 375)
        Me.Restar1.Name = "Restar1"
        Me.Restar1.Size = New System.Drawing.Size(31, 23)
        Me.Restar1.TabIndex = 15
        Me.Restar1.Text = "-1"
        Me.Restar1.UseVisualStyleBackColor = True
        '
        'Restar10
        '
        Me.Restar10.Location = New System.Drawing.Point(311, 375)
        Me.Restar10.Name = "Restar10"
        Me.Restar10.Size = New System.Drawing.Size(41, 23)
        Me.Restar10.TabIndex = 16
        Me.Restar10.Text = "-10"
        Me.Restar10.UseVisualStyleBackColor = True
        '
        'Sumar10
        '
        Me.Sumar10.Location = New System.Drawing.Point(538, 376)
        Me.Sumar10.Name = "Sumar10"
        Me.Sumar10.Size = New System.Drawing.Size(41, 23)
        Me.Sumar10.TabIndex = 18
        Me.Sumar10.Text = "-10"
        Me.Sumar10.UseVisualStyleBackColor = True
        '
        'Sumar1
        '
        Me.Sumar1.Location = New System.Drawing.Point(501, 376)
        Me.Sumar1.Name = "Sumar1"
        Me.Sumar1.Size = New System.Drawing.Size(31, 23)
        Me.Sumar1.TabIndex = 17
        Me.Sumar1.Text = "+1"
        Me.Sumar1.UseVisualStyleBackColor = True
        '
        'ModificarButton
        '
        Me.ModificarButton.Location = New System.Drawing.Point(633, 356)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(141, 43)
        Me.ModificarButton.TabIndex = 19
        Me.ModificarButton.Text = "Modificar"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'AdministrarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.Sumar10)
        Me.Controls.Add(Me.Sumar1)
        Me.Controls.Add(Me.Restar10)
        Me.Controls.Add(Me.Restar1)
        Me.Controls.Add(Me.CantidadText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PrecioText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProductoText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdministrarStock"
        Me.Text = "AdministrarStock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductoText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrecioText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CantidadText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Restar1 As Button
    Friend WithEvents Restar10 As Button
    Friend WithEvents Sumar10 As Button
    Friend WithEvents Sumar1 As Button
    Friend WithEvents ModificarButton As Button
End Class
