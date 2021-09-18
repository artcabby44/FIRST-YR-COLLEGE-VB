Imports MySql.Data.MySqlClient
Public Class Form4
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        Dim result As String

        result = MessageBox.Show("Are you sure you want to remove  " & TextBox2.Text & " from booklist?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then



            sql.con.Close()
            Try
                sql.con.Open()
                cmd = sql.con.CreateCommand()
                cmd.CommandText = "DELETE FROM admins WHERE id=@id;"
                cmd.Parameters.AddWithValue("@regnum", TextBox4.Text)


                cmd.ExecuteNonQuery()


            Catch ex As Exception


            End Try
            Form4_Load(sender, e)
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraDataSet5.admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.LibraDataSet5.admins)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sql.con.Open()

            qry = "UPDATE admin SET firstname=@firstname,lastname=@lastname,id=@id,password=@password WHERE id=@id"
            cmd = New MySqlCommand(qry, sql.con)
            cmd.Parameters.AddWithValue("@firstname", TextBox3.Text)
            cmd.Parameters.AddWithValue("@lastname", TextBox2.Text)
            cmd.Parameters.AddWithValue("@id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@password", TextBox1.Text)

        
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        sql.con.Close()

        Form4_Load(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Admin.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Admine.Show()

    End Sub
End Class