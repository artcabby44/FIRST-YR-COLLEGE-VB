Imports MySql.Data.MySqlClient

Public Class Form3
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JimzDataSet1.jimz' table. You can move, or remove it, as needed.
        Me.JimzTableAdapter.Fill(Me.JimzDataSet1.jimz)
        Me.Refresh()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand


        sql.con.Close()
        Try
            sql.con.Open()
            cmd = sql.con.CreateCommand()
            cmd.CommandText = "DELETE FROM jimz WHERE date=@date;"
            cmd.Parameters.AddWithValue("@date", TextBox1.Text)


            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Form3_Load(sender, e)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox1.Text = row.Cells(0).Value.ToString
            TextBox7.Text = row.Cells(0).Value.ToString
            TextBox6.Text = row.Cells(1).Value.ToString
            TextBox2.Text = row.Cells(2).Value.ToString
            TextBox4.Text = row.Cells(3).Value.ToString
            TextBox3.Text = row.Cells(4).Value.ToString
            TextBox5.Text = row.Cells(5).Value.ToString

        Catch ex As Exception
        End Try

        Form3_Load(sender, e)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim cmd As MySqlCommand


        sql.con.Close()
        Try
            sql.con.Open()
            cmd = sql.con.CreateCommand()
            cmd.CommandText = "DELETE FROM jimz WHERE date=@date;"
            cmd.Parameters.AddWithValue("@date", TextBox1.Text)


            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Form3_Load(sender, e)

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql.con.Close()

        Try
            sql.con.Open()

            qry = "UPDATE jimz SET name=@name,yrsec=@yrsec,sn=@sn,pcnum=@pcnum,date=@date,time=@time WHERE sn=@sn"
            cmd = New MySqlCommand(qry, sql.con)

            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@yrsec", TextBox4.Text)
            cmd.Parameters.AddWithValue("@sn", TextBox3.Text)
            cmd.Parameters.AddWithValue("@pcnum", TextBox5.Text)
            cmd.Parameters.AddWithValue("@date", TextBox7.Text)
            cmd.Parameters.AddWithValue("@time", TextBox6.Text)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Form3_Load(sender, e)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class