Public Class Administrador
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub Gestionar_Editoriales_Click(sender As Object, e As EventArgs) Handles Gestionar_Editoriales.Click
        Me.Hide()
        GestionarEditoriales.ShowDialog()
    End Sub

    Private Sub Gestionar_Libros_Click(sender As Object, e As EventArgs) Handles Gestionar_Libros.Click
        Me.Hide()
        GestionarLibros.Show()
    End Sub

    Private Sub Reportes_Click(sender As Object, e As EventArgs) Handles Reportes.Click
        Me.Hide()
        Proyecto.Show()
    End Sub
End Class