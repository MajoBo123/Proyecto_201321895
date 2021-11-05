Imports System.Data.SqlClient
Public Class Registro
    Dim Con As New SqlConnection
    Dim Cmd As New SqlCommand
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader


    Private Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click
        Try

            Dim Fecha As String = Nacimiento.Value.ToString("yyyy-MM-d")
            Dim nombre As String = TextNombre.Text
            Dim apellido As String = TextApellido.Text
            Dim usuario As String = TextUs.Text
            Dim contrasenia As String = TextCon.Text
            Dim tipo_Usr As String = 2

            Dim resultado As Integer
            Con = New SqlConnection()
            Con.ConnectionString = "Data Source=LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
            Con.Open()
            Dim cadena As String = "INSERT INTO  Usuario (nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia) VALUES ('" & nombre & "','" & apellido & "','" & usuario & "','" & tipo_Usr & "','" & Fecha & "','" & contrasenia & "')"
            Dim comando As SqlCommand
            comando = New SqlCommand(cadena, Con)
            resultado = comando.ExecuteNonQuery()
            Con.Close()

            If resultado > 0 Then
                MsgBox("El Usuario: " + TextUs.Text + " fue registrado")
            Else
                MsgBox("El Usuario: " + TextUs.Text + " no fue registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
        VerificarContraseña.Show()

        TextUs.Text = ""
        TextCon.Text = ""
        TextNombre.Text = ""
        TextApellido.Text = ""

    End Sub


    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Form1.Show()
        Me.Hide()
        Me.TextUs.Clear()
        Me.TextCon.Clear()
        Me.TextApellido.Clear()
        Me.TextNombre.Clear()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class