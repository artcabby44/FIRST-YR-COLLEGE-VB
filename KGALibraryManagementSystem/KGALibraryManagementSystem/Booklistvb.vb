Imports MySql.Data.MySqlClient
Public Class Booklistvb
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Booklistvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraDataSet1.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraDataSet1.books)
        TextBox7.Text = Login.TextBox1.Text

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox4.Text = row.Cells(0).Value.ToString
            TextBox2.Text = row.Cells(1).Value.ToString
            TextBox3.Text = row.Cells(2).Value.ToString
            TextBox1.Text = row.Cells(3).Value.ToString
            TextBox5.Text = row.Cells(4).Value.ToString

        Catch ex As Exception
        End Try

        Booklistvb_Load(sender, e)
    End Sub

   


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.SelectedItem = "available"
        Dim num1, num2 As Integer
        num1 = 3
        num2 = num1 - 1


        If TextBox5.Text = TextBox7.Text Then


            Try
                Dim a As String
                a = ""
                sql.con.Open()

                qry = "UPDATE books SET id=@id,title=@title,author=@author,status=@status,returndate=@returndate,returned=@returned,barrower=@barrower,balik=@balik WHERE id=@id"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@id", TextBox4.Text)
                cmd.Parameters.AddWithValue("@title", TextBox2.Text)
                cmd.Parameters.AddWithValue("@author", TextBox3.Text)
                cmd.Parameters.AddWithValue("@status", TextBox1.Text)
                cmd.Parameters.AddWithValue("@returndate", a)
                cmd.Parameters.AddWithValue("@barrower", a)
                cmd.Parameters.AddWithValue("@balik", TextBox7.Text)
                cmd.Parameters.AddWithValue("@returned", DateTimePicker1.Value)
                cmd.ExecuteNonQuery()
                sql.con.Close()

            Catch ex As Exception
                MsgBox("opps")

            End Try
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox1.Text = ""
            ComboBox1.SelectedItem = ""
            Try



                sql.con.Open()

                qry = "UPDATE users SET book_no=@book_no WHERE regnum=@regnum"
                cmd = New MySqlCommand(qry, sql.con)
                cmd.Parameters.AddWithValue("@regnum", TextBox7.Text)
                cmd.Parameters.AddWithValue("@book_no", num2)
                cmd.ExecuteNonQuery()
                sql.con.Close()

            Catch ex As Exception
                MsgBox("opps")
            End Try
        Else
            MsgBox("Oopss, You Didn't Barrowed This One")
        End If
        Booklistvb_Load(sender, e)
    End Sub

   

  
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedItem


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        ComboBox1.Text = TextBox1.Text


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Login.Show()
        Login.TextBox1.Clear()
        Login.TextBox2.Clear()
        TextBox7.Clear()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Issue.Show()

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        BooksBindingSource.Filter = String.Format("[title] Like '{0}%'", Me.TextBox6.Text.Trim())
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class