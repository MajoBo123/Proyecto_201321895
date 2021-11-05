Imports System.Data.SqlClient
Public Class GestionarLibros
    Dim Conexion As String
    Dim Cmd As String
    Dim da As SqlDataAdapter
    Dim dt As DataSet
    Dim Con As New SqlConnection
    Dim Cm As New SqlCommand


    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Administrador.Show()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Public Sub disp_data()
        Cm = Con.CreateCommand()
        Cm.CommandType = CommandType.Text
        Cm.CommandText = "select * from Libro"
        Cm.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(Cm)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub GestionarLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = "Data Source=LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
        Cmd = "Select * From Editorial"
        da = New System.Data.SqlClient.SqlDataAdapter(Cmd, Conexion)
        dt = New DataSet
        da.Fill(dt)
        ComboBox1.DataSource = dt.Tables(0)
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id_editorial"
        Cmd = "Select * From Genero"
        da = New System.Data.SqlClient.SqlDataAdapter(Cmd, Conexion)
        dt = New DataSet
        da.Fill(dt)
        ComboBox2.DataSource = dt.Tables(0)
        ComboBox2.DisplayMember = "nombre"
        ComboBox2.ValueMember = "id_genero"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Cantidad As String = 50
            Dim Editorial As String = ComboBox1.Text
            Dim Genero As String = ComboBox2.Text
            Dim Titulo As String = TextBox1.Text
            Dim Autor As String = TextBox2.Text
            Dim resultado As Integer
            Con = New SqlConnection()
            Con.ConnectionString = "Data Source=LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
            Con.Open()
            Dim cadena As String = "INSERT INTO  Libro (id_editorial,genero,titulo,autor,cantidad) VALUES ('" & Editorial & "','" & Genero & "','" & Titulo & "','" & Autor & "','" & Cantidad & "')"
            Dim comando As SqlCommand
            comando = New SqlCommand(cadena, Con)
            resultado = comando.ExecuteNonQuery()
            Con.Close()
            disp_data()
            If resultado > 0 Then
                MsgBox("El Libro: " + TextBox1.Text + " fue registrado")
            Else
                MsgBox("El Libro: " + TextBox1.Text + " no fue registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            Con.Open()
            Cm = Con.CreateCommand()
            Cm.CommandType = CommandType.Text
            Cm.CommandText = "delete from Libro where titulo='" & TextBox1.Text & "'"
            Cm.ExecuteNonQuery()
            disp_data()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            Con.Open()
            Cm = Con.CreateCommand()
            Cm.CommandType = CommandType.Text
            Cm.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(Cm)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = Cm.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextBox1.Text = dr.GetString(1).ToString()
                TextBox2.Text = dr.GetString(2).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub
End Class