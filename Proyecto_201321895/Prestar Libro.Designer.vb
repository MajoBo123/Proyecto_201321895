<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prestar_Libro
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
        Me.Editorial = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Prestar = New System.Windows.Forms.Button()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        CType(Me.Editorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Editorial
        '
        Me.Editorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Editorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Editorial.Location = New System.Drawing.Point(47, 105)
        Me.Editorial.Name = "Editorial"
        Me.Editorial.RowTemplate.Height = 25
        Me.Editorial.Size = New System.Drawing.Size(530, 121)
        Me.Editorial.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Titulo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Autor"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Genero"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Editorial"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Disponible"
        Me.Column5.Name = "Column5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Elige un libro de interes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(47, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "*Para prestar libro, haga click sobre el titulo de este"
        '
        'Prestar
        '
        Me.Prestar.Location = New System.Drawing.Point(305, 258)
        Me.Prestar.Name = "Prestar"
        Me.Prestar.Size = New System.Drawing.Size(75, 23)
        Me.Prestar.TabIndex = 29
        Me.Prestar.Text = "Prestar"
        Me.Prestar.UseVisualStyleBackColor = True
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(305, 71)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(122, 23)
        Me.TextNombre.TabIndex = 30
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Titulo", "Categoria"})
        Me.ComboBox1.Location = New System.Drawing.Point(433, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 31
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(549, 300)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(75, 23)
        Me.Regresar.TabIndex = 32
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(560, 72)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 33
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Prestar_Libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 348)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.Prestar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Editorial)
        Me.Name = "Prestar_Libro"
        Me.Text = "Prestar_Libro"
        CType(Me.Editorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Editorial As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Prestar As Button
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Regresar As Button
    Friend WithEvents Buscar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
