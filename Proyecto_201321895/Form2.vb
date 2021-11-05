Imports System.Data.SqlClient
Public Class Libros_Prestados
    Dim Con As New SqlConnection
    Dim Cmd As New SqlCommand
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Cliente.Show()
    End Sub

    Private Sub Editorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Editorial.CellContentClick
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
        Catch ex As Exception

        End Try
    End Sub
    Public Sub disp_data()
        Cmd = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select * from Prestamo"
        Cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(Cmd)
        da.Fill(dt)
        Editorial.DataSource = dt
    End Sub
    Private Sub Libros_Prestados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.ConnectionString = "Data Source = LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Con.Open()
        disp_data()
    End Sub
End Class