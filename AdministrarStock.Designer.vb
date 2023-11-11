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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarStock))
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
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(329, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(740, 484)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductoText
        '
        Me.ProductoText.Enabled = False
        Me.ProductoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoText.Location = New System.Drawing.Point(30, 64)
        Me.ProductoText.Multiline = True
        Me.ProductoText.Name = "ProductoText"
        Me.ProductoText.Size = New System.Drawing.Size(122, 39)
        Me.ProductoText.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo Producto"
        '
        'PrecioText
        '
        Me.PrecioText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioText.Location = New System.Drawing.Point(182, 173)
        Me.PrecioText.Multiline = True
        Me.PrecioText.Name = "PrecioText"
        Me.PrecioText.Size = New System.Drawing.Size(127, 40)
        Me.PrecioText.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(178, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Precio"
        '
        'CantidadText
        '
        Me.CantidadText.Enabled = False
        Me.CantidadText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadText.Location = New System.Drawing.Point(28, 173)
        Me.CantidadText.Multiline = True
        Me.CantidadText.Name = "CantidadText"
        Me.CantidadText.Size = New System.Drawing.Size(124, 41)
        Me.CantidadText.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cantidad"
        '
        'Restar1
        '
        Me.Restar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Restar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restar1.ForeColor = System.Drawing.Color.White
        Me.Restar1.Location = New System.Drawing.Point(160, 241)
        Me.Restar1.Name = "Restar1"
        Me.Restar1.Size = New System.Drawing.Size(54, 51)
        Me.Restar1.TabIndex = 15
        Me.Restar1.Text = "-1"
        Me.Restar1.UseVisualStyleBackColor = False
        '
        'Restar10
        '
        Me.Restar10.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Restar10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restar10.ForeColor = System.Drawing.Color.White
        Me.Restar10.Location = New System.Drawing.Point(220, 241)
        Me.Restar10.Name = "Restar10"
        Me.Restar10.Size = New System.Drawing.Size(64, 51)
        Me.Restar10.TabIndex = 16
        Me.Restar10.Text = "-10"
        Me.Restar10.UseVisualStyleBackColor = False
        '
        'Sumar10
        '
        Me.Sumar10.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Sumar10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sumar10.ForeColor = System.Drawing.Color.White
        Me.Sumar10.Location = New System.Drawing.Point(30, 241)
        Me.Sumar10.Name = "Sumar10"
        Me.Sumar10.Size = New System.Drawing.Size(64, 51)
        Me.Sumar10.TabIndex = 18
        Me.Sumar10.Text = "+10"
        Me.Sumar10.UseVisualStyleBackColor = False
        '
        'Sumar1
        '
        Me.Sumar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Sumar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sumar1.ForeColor = System.Drawing.Color.White
        Me.Sumar1.Location = New System.Drawing.Point(100, 241)
        Me.Sumar1.Name = "Sumar1"
        Me.Sumar1.Size = New System.Drawing.Size(54, 51)
        Me.Sumar1.TabIndex = 17
        Me.Sumar1.Text = "+1"
        Me.Sumar1.UseVisualStyleBackColor = False
        '
        'ModificarButton
        '
        Me.ModificarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ModificarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarButton.ForeColor = System.Drawing.Color.White
        Me.ModificarButton.Location = New System.Drawing.Point(74, 358)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(177, 89)
        Me.ModificarButton.TabIndex = 19
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.UseVisualStyleBackColor = False
        '
        'AdministrarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 529)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdministrarStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administras Stock"
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
