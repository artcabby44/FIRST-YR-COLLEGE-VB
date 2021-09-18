Imports MySql.Data.MySqlClient
Public Class Form2
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraDataSet5.admins' table. You can move, or remove it, as needed.
      
        Me.UsersTableAdapter1.Fill(Me.LibraDataSet4.users)
        'TODO: This line of code loads data into the 'LibraDataSet2.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LibraDataSet2.users)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged, TextBox2.TextChanged, TextBox6.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox7.Text = row.Cells(0).Value.ToString
            TextBox6.Text = row.Cells(1).Value.ToString
            TextBox3.Text = row.Cells(2).Value.ToString
            TextBox2.Text = row.Cells(3).Value.ToString
            ComboBox1.SelectedItem = row.Cells(4).Value.ToString
            TextBox4.Text = row.Cells(5).Value.ToString
            TextBox1.Text = row.Cells(6).Value.ToString
            TextBox5.Text = row.Cells(7).Value.ToString


        Catch ex As Exception
        End Try

        Form2_Load(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sql.con.Open()

            qry = "UPDATE users SET fname=@fname,lname=@lname,gender=@gender,dept=@dept,email=@email,password=@password,book_no=@book_no WHERE regnum=@regnum"
            cmd = New MySqlCommand(qry, sql.con)
            cmd.Parameters.AddWithValue("@regnum", TextBox6.Text)
            cmd.Parameters.AddWithValue("@fname", TextBox3.Text)
            cmd.Parameters.AddWithValue("@lname", TextBox2.Text)
            cmd.Parameters.AddWithValue("@gender", ComboBox1.SelectedItem)
            cmd.Parameters.AddWithValue("@dept", TextBox4.Text)
            cmd.Parameters.AddWithValue("@password", TextBox7.Text)
            cmd.Parameters.AddWithValue("@book_no", TextBox5.Text)
            cmd.Parameters.AddWithValue("@email", TextBox1.Text)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        sql.con.Close()

        Form2_Load(sender, e)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        Dim result As String

        result = MessageBox.Show("Are you sure you want to remove  " & TextBox2.Text & " from booklist?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then



            sql.con.Close()
            Try
                sql.con.Open()
                cmd = sql.con.CreateCommand()
                cmd.CommandText = "DELETE FROM users WHERE regnum=@regnum;"
                cmd.Parameters.AddWithValue("@regnum", TextBox6.Text)


                cmd.ExecuteNonQuery()


            Catch ex As Exception


            End Try
            Form2_Load(sender, e)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Admine.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class