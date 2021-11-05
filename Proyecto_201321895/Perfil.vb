Imports System.Data.SqlClient
Public Class Perfil
    Private Con As New SqlConnection
    Private Cmd As New SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Cliente.Show()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Try

            Dim Fecha As String = Nacimiento.Value.ToString("yyyy-MM-d")
            Dim nombre As String = TextNombre.Text
            Dim apellido As String = TextApellido.Text
            Dim usuario As String = TextUs.Text

            Dim resultado As Integer
            Con = New SqlConnection()
            Con.ConnectionString = "Data Source=LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
            Con.Open()
            Dim cadena As String = "delete from Usuario where Nombre='(nombre,apellido,usuario,nacimiento) VALUES ('" & nombre & "','" & apellido & "','" & usuario & "','" & Fecha & "')"
            Dim comando As SqlCommand
            comando = New SqlCommand(cadena, Con)
            resultado = comando.ExecuteNonQuery()
            Con.Close()

            If resultado = 1 Then
                MsgBox("El Usuario: " + TextUs.Text + " fue eliminado")
            Else
                MsgBox("El Usuario: " + TextUs.Text + " no fue eliminado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
    End Sub
    Private Sub MostrarDatos()
        Try
            Dim command As New SqlCommand("SELECT * FROM Usuario", Con)
            Dim dataAdapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Usuario")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Try
            Dim command As New SqlCommand("UPDATE Usuario SET nombre=@nombre WHERE Usuario=@Us", Con)
            command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextNombre.Text
            command.Parameters.Add("@Us", SqlDbType.VarChar).Value = TextUs.Text

            Con.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Se modifico correctamente el usuario")
            Else
                MessageBox.Show("No se logro modificar el usuario")
            End If

            Con.Close()
            MostrarDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class