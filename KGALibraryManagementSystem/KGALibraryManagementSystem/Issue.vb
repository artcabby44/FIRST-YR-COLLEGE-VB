Imports MySql.Data.MySqlClient
Public Class Issue
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public num As Integer = 0


    Private Sub Issue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraDataSet.books)

        TextBox1.Text = Login.TextBox1.Text


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim result As String

        result = MessageBox.Show("Are you sure you want to logout?  ", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            Me.Hide()
            Login.Show()
        End If

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        BooksBindingSource.Filter = String.Format("[title] Like '{0}%'", Me.TextBox5.Text.Trim())
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim stats, a As String

        a = ""
        stats = "unavailable"
        num = num + 1
        If num = 4 Then
            MsgBox("opps you can only barrow 3 books")
        Else
            Try

                sql.con.Open()

                qry = "UPDATE books SET status=@status,barrower=@barrower,returndate=@returndate,returned=@returned,balik=@balik WHERE id=@id"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@id", TextBox4.Text)
                cmd.Parameters.AddWithValue("@barrower", TextBox1.Text)
                cmd.Parameters.AddWithValue("@returndate", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@status", stats)
                cmd.Parameters.AddWithValue("@returned", a)
                cmd.Parameters.AddWithValue("@balik", a)
                cmd.ExecuteNonQuery()
                sql.con.Close()
                MsgBox("Thank you, you can now barrow " & TextBox2.Text)
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox6.Text = ""



            Catch ex As Exception
                MsgBox("opps")

            End Try
            Try


                sql.con.Open()

                qry = "UPDATE users SET book_no=@book_no WHERE regnum=@regnum"
                cmd = New MySqlCommand(qry, sql.con)
                cmd.Parameters.AddWithValue("@regnum", TextBox1.Text)
                cmd.Parameters.AddWithValue("@book_no", num)
                cmd.ExecuteNonQuery()
                sql.con.Close()

            Catch ex As Exception
                MsgBox("opps")
            End Try



            Issue_Load(sender, e)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            TextBox4.Text = row.Cells(0).Value.ToString
            TextBox2.Text = row.Cells(1).Value.ToString
            TextBox3.Text = row.Cells(2).Value.ToString
            TextBox6.Text = row.Cells(3).Value.ToString


        Catch ex As Exception
        End Try
        If TextBox6.Text = "unavailable" Then
            MsgBox("Opps, This book is currently unavailable.")
            TextBox4.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox6.Text = ""

        End If
        Issue_Load(sender, e)
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

  

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class