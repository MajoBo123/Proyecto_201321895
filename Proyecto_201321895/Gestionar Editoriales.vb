Imports System.Data.SqlClient
Public Class GestionarEditoriales
    Dim Con As New SqlConnection
    Dim Cmd As New SqlCommand

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Administrador.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cmd = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "insert into Editorial values ('" + TextNomb.Text + "','" + TextDireccion.Text + "')"
        Cmd.ExecuteNonQuery()
        TextNomb.Text = ""
        TextDireccion.Text = ""
        disp_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            Con.Open()
            Cmd = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "delete from Editorial where Nombre='" & TextNomb.Text & "'"
            Cmd.ExecuteNonQuery()
            disp_data()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GestionarEditoriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.ConnectionString = "Data Source = LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Con.Open()
        disp_data()
    End Sub
    Public Sub disp_data()
        Cmd = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select * from Editorial"
        Cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(Cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Sql As String = "Update Editorial set Nombre='" & TextNomb.Text & "', Direccion='" & TextDireccion.Text & "'"
        Dim Cmd As New SqlCommand(Sql, Con)
        Cmd.ExecuteNonQuery()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            Con.Open()
            Cmd = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(Cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextNomb.Text = dr.GetString(1).ToString()
                TextDireccion.Text = dr.GetString(2).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub
End Class