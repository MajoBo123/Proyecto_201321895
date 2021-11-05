Imports System.Data.SqlClient
Public Class Form1
    Private Con As New SqlConnection
    Private Cmd As New SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Dim nivel As String, admi, apellido, usuario, contraseña As String
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuario where Usuario='" & nombreUsuario & "'", Con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function contrasena(ByVal nombreContraseña As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contrasenia from Usuario where Contrasenia='" & nombreContraseña & "'", Con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contrasenia")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select TIPO_USR from Usuario where Usuario ='" & nombreUsuario & "'", Con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("TIPO_USR"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Private Sub Cerrar_Sesion_Click(sender As Object, e As EventArgs) Handles Cerrar_Sesion.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        Try
            Con = New SqlConnection("Data Source=LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True")
            Con.Open()
            MsgBox("Conexión con exito")

        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try

    End Sub

    Private Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Try
            Me.Hide()
            VerificarContraseña.ShowDialog()
            If usuarioRegistrado(TextUsuario.Text) = True Then
                Dim contra As String = contrasena(TextContraseña.Text)
                If contra.Equals(TextContraseña.Text) = True Then
                    If ConsultarTipoUsuario(TextUsuario.Text) = 2 Then
                        Me.Hide()
                        Cliente.ShowDialog()
                    ElseIf ConsultarTipoUsuario(TextUsuario.Text) = 1 Then
                        Administrador.ShowDialog()
                    End If
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + TextUsuario.Text + " favor registrarse")
            End If
            Me.TextUsuario.Clear()
            Me.TextContraseña.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
