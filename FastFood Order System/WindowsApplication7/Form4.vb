Imports MySql.Data.MySqlClient

Public Class dataf
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PanchamDataSet1.pancham' table. You can move, or remove it, as needed.
        Me.PanchamTableAdapter.Fill(Me.PanchamDataSet1.pancham)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = Today


        sql.con.Close()


        Try
            sql.con.Open()
            qry = "INSERT INTO pancham (prodname,stock,oldstock,date,Income) VALUES (@prodname,@stock,@oldstock,@date,@Income)"
            cmd = New MySqlCommand(qry, sql.con)
            cmd.Parameters.AddWithValue("@prodname", TextBox1.Text)
            cmd.Parameters.AddWithValue("@stock", TextBox2.Text)
            cmd.Parameters.AddWithValue("@oldstock", TextBox3.Text)
            cmd.Parameters.AddWithValue("@date", TextBox4.Text)
            cmd.Parameters.AddWithValue("@Income", TextBox5.Text)


            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Form4_Load(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox1.Text = row.Cells(0).Value.ToString
            TextBox3.Text = row.Cells(2).Value.ToString
            TextBox2.Text = row.Cells(1).Value.ToString
            TextBox4.Text = row.Cells(3).Value.ToString
            TextBox5.Text = row.Cells(3).Value.ToString

            Form4_Load(sender, e)
        Catch ex As Exception
        End Try
        Form4_Load(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql.con.Close()

        Try
            sql.con.Open()
            cmd = sql.con.CreateCommand()
            cmd.CommandText = "DELETE FROM pancham WHERE prodname=@prodname;"
            cmd.Parameters.AddWithValue("@prodname", TextBox1.Text)


            cmd.ExecuteNonQuery()

            Form4_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Form4_Load(sender, e)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub
End Class