Imports System.Data.SqlClient
Public Class VerificarContraseña
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Hide()
    End Sub

    Private Sub VerificarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Elija As String
            If CheckBox1.Checked = True Then
                Elija = CheckBox1.Text = ""
            ElseIf CheckBox2.Checked = True Then
                Elija = CheckBox2.Text = ""
            ElseIf CheckBox3.Checked = True Then
                Elija = CheckBox3.Text = ""
            ElseIf CheckBox4.Checked = True Then
                Elija = CheckBox4.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class