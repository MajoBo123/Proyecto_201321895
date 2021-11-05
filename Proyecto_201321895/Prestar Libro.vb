Imports System.Data.SqlClient
Public Class Prestar_Libro
    Dim Conexion As String
    Dim Cmd As String
    Dim da As SqlDataAdapter
    Dim dt As DataSet
    Dim Con As New SqlConnection
    Dim Cm As New SqlCommand
    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Cliente.Show()
    End Sub

    Private Sub Prestar_Libro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion = "Data Source=LAPTOP-JU65BB51\SQLEXPRESS;Initial Catalog=BD_201321895;Integrated Security=True"
        Cmd = "Select * From Genero"
        da = New System.Data.SqlClient.SqlDataAdapter(Cmd, Conexion)
        dt = New DataSet
        da.Fill(dt)
        ComboBox1.DataSource = dt.Tables(0)
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id_genero"
    End Sub
    Public Sub disp_data()
        Cm = Con.CreateCommand()
        Cm.CommandType = CommandType.Text
        Cm.CommandText = "select * from Libro"
        Cm.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(Cm)
        da.Fill(dt)
        Editorial.DataSource = dt
    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            For i As Integer = 0 To Me.Editorial.Rows.Count - 2
                For x As Integer = 0 To Editorial.ColumnCount - 1
                    If Editorial.Rows(i).Cells(x).Value.ToString.Contains(Me.TextNombre.Text) Then
                        Me.Editorial.CurrentCell = Editorial.Rows(i).Cells(x)
                    End If
                Next x
            Next i
        Catch ex As Exception
            MsgBox("No se puede realizar la búsqueda por: " & ex.Message)
        End Try
    End Sub

    Private Sub Editorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Editorial.CellContentClick

    End Sub
End Class