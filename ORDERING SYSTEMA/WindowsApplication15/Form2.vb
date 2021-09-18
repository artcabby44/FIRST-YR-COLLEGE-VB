Imports MySql.Data.MySqlClient

Public Class Form2
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LagadoomDataSet1.lagadoom' table. You can move, or remove it, as needed.
        Me.LagadoomTableAdapter.Fill(Me.LagadoomDataSet1.lagadoom)
        TextBox5.Text = Today

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql.con.Close()


        Try
            sql.con.Open()
            qry = "INSERT INTO lagadoom (product,availstock,oldstock,soldstock,date,sales) VALUES (@product,@availstock,@oldstock,@soldstock,@date,@sales)"
            cmd = New MySqlCommand(qry, sql.con)
            cmd.Parameters.AddWithValue("@product", TextBox1.Text)
            cmd.Parameters.AddWithValue("@availstock", TextBox2.Text)
            cmd.Parameters.AddWithValue("@oldstock", TextBox3.Text)
            cmd.Parameters.AddWithValue("@soldstock", TextBox4.Text)
            cmd.Parameters.AddWithValue("@date", TextBox5.Text)
            cmd.Parameters.AddWithValue("@sales", TextBox6.Text)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Form2_Load(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            sql.con.Open()

            qry = "UPDATE jimz SET studentname=@studentname,price=@price,money=@money,stock=@stock WHERE studentname='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(qry, sql.con)


            cmd.Parameters.AddWithValue("@studentname", TextBox1.Text)
            cmd.Parameters.AddWithValue("@price", TextBox2.Text)
            cmd.Parameters.AddWithValue("@money", TextBox3.Text)
            cmd.Parameters.AddWithValue("@stock", TextBox4.Text)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Form2_Load(sender, e)
    End Sub
End Class