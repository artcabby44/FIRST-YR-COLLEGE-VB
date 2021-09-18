Imports MySql.Data.MySqlClient
Public Class return_reissue

    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox4.Text = row.Cells(0).Value.ToString
            TextBox2.Text = row.Cells(1).Value.ToString
            TextBox3.Text = row.Cells(2).Value.ToString
            ComboBox1.SelectedItem = row.Cells(3).Value.ToString


        Catch ex As Exception
        End Try

        Return_reissue_Load(sender, e)
    End Sub

    Private Sub Return_reissue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraDataSet4.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraDataSet4.books)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim a As String
            a = ""
            sql.con.Open()

            qry = "UPDATE books SET id=@id,title=@title,author=@author,status=@status WHERE id=@id"
            cmd = New MySqlCommand(qry, sql.con)

            cmd.Parameters.AddWithValue("@id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@title", TextBox2.Text)
            cmd.Parameters.AddWithValue("@author", TextBox3.Text)
            cmd.Parameters.AddWithValue("@status", ComboBox1.SelectedItem)
           
            cmd.ExecuteNonQuery()
            sql.con.Close()
            MsgBox("Book successfully updated")
        Catch ex As Exception
            MsgBox("opps")

        End Try
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        ComboBox1.SelectedItem = ""


        Return_reissue_Load(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            sql.con.Open()
            qry = "INSERT INTO books (id,title,author,status) VALUES (@id,@title,@author,@status)"
            cmd = New MySqlCommand(qry, sql.con)
            cmd.Parameters.AddWithValue("@id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@title", TextBox2.Text)
            cmd.Parameters.AddWithValue("@author", TextBox3.Text)
            cmd.Parameters.AddWithValue("@status", ComboBox1.SelectedItem)




            cmd.ExecuteNonQuery()
            sql.con.Close()
            MsgBox("Book successfully added")
        Catch ex As Exception
            MsgBox("successfully failed")

        End Try
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        ComboBox1.SelectedItem = ""
        Return_reissue_Load(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As MySqlCommand
        Dim result As String

        result = MessageBox.Show("Are you sure you want to remove  " & TextBox2.Text & " from booklist?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then



            sql.con.Close()
            Try
                sql.con.Open()
                cmd = sql.con.CreateCommand()
                cmd.CommandText = "DELETE FROM books WHERE id=@id;"
                cmd.Parameters.AddWithValue("@id", TextBox4.Text)


                cmd.ExecuteNonQuery()


            Catch ex As Exception


            End Try
        End If
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        ComboBox1.SelectedItem = ""
        Return_reissue_Load(sender, e)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Admine.Show()

    End Sub
End Class