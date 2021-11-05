Imports System.Data.SqlClient
Public Class Cliente
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Libros_Prestados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Prestar_Libro.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Perfil.Show()
    End Sub

    Private Sub Cerrar_Sesion_Click(sender As Object, e As EventArgs) Handles Cerrar_Sesion.Click
        Me.Close()
    End Sub
End Class