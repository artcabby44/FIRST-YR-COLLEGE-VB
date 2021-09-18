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
         

        Catch ex As Exception
        End Try

        Form3_Load(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()

    End Sub
End Class