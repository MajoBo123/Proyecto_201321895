<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Libros_Prestados
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Devolver = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        CType(Me.Editorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Editorial
        '
        Me.Editorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Editorial.Location = New System.Drawing.Point(56, 125)
        Me.Editorial.Name = "Editorial"
        Me.Editorial.RowTemplate.Height = 25
        Me.Editorial.Size = New System.Drawing.Size(530, 121)
        Me.Editorial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(74, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Cuentas con estos libros en tu haber:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(56, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "*Para devolver haga click sobre el titulo de este"
        '
        'Devolver
        '
        Me.Devolver.Location = New System.Drawing.Point(304, 279)
        Me.Devolver.Name = "Devolver"
        Me.Devolver.Size = New System.Drawing.Size(75, 23)
        Me.Devolver.TabIndex = 27
        Me.Devolver.Text = "Devolver"
        Me.Devolver.UseVisualStyleBackColor = True
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(608, 387)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(75, 23)
        Me.Regresar.TabIndex = 28
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Libros_Prestados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Devolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Editorial)
        Me.Name = "Libros_Prestados"
        Me.Text = "Libros Prestados"
        CType(Me.Editorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Editorial As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Devolver As Button
    Friend WithEvents Regresar As Button
End Class
