<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrador))
        Me.Gestionar_Editoriales = New System.Windows.Forms.Button()
        Me.Gestionar_Libros = New System.Windows.Forms.Button()
        Me.Reportes = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Regresar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gestionar_Editoriales
        '
        Me.Gestionar_Editoriales.Location = New System.Drawing.Point(255, 69)
        Me.Gestionar_Editoriales.Name = "Gestionar_Editoriales"
        Me.Gestionar_Editoriales.Size = New System.Drawing.Size(133, 42)
        Me.Gestionar_Editoriales.TabIndex = 0
        Me.Gestionar_Editoriales.Text = "Gestionar Editoriales"
        Me.Gestionar_Editoriales.UseVisualStyleBackColor = True
        '
        'Gestionar_Libros
        '
        Me.Gestionar_Libros.Location = New System.Drawing.Point(255, 133)
        Me.Gestionar_Libros.Name = "Gestionar_Libros"
        Me.Gestionar_Libros.Size = New System.Drawing.Size(133, 42)
        Me.Gestionar_Libros.TabIndex = 1
        Me.Gestionar_Libros.Text = "Gestionar Libros"
        Me.Gestionar_Libros.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.Reportes.Location = New System.Drawing.Point(255, 198)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(133, 40)
        Me.Reportes.TabIndex = 2
        Me.Reportes.Text = "Reportes"
        Me.Reportes.UseVisualStyleBackColor = True
        '
        'Cerrar
        '
        Me.Cerrar.Location = New System.Drawing.Point(484, 272)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(103, 27)
        Me.Cerrar.TabIndex = 3
        Me.Cerrar.Text = "Cerrar Sesión"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 57)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(27, 291)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(103, 27)
        Me.Regresar.TabIndex = 19
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(651, 330)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Reportes)
        Me.Controls.Add(Me.Gestionar_Libros)
        Me.Controls.Add(Me.Gestionar_Editoriales)
        Me.Name = "Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gestionar_Editoriales As Button
    Friend WithEvents Gestionar_Libros As Button
    Friend WithEvents Reportes As Button
    Friend WithEvents Cerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Regresar As Button
End Class
