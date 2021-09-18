Imports MySql.Data.MySqlClient

Public Class Form4
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JimzDataSet2.vsainfo' table. You can move, or remove it, as needed.
        Me.VsainfoTableAdapter.Fill(Me.JimzDataSet2.vsainfo)
    End Sub

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql.con.Close()

        Try
            sql.con.Open()
            qry = "INSERT INTO vsainfo (vsaid,name,adress,birthday,age,cpnum,timein) VALUES (@vsaid,@name,@adress,@birthday,@age,@cpnum,@timein)"
            cmd = New MySqlCommand(qry, sql.con)
            cmd.Parameters.AddWithValue("@vsaid", TextBox1.Text)
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@adress", TextBox3.Text)
            cmd.Parameters.AddWithValue("@birthday", TextBox4.Text)
            cmd.Parameters.AddWithValue("@age", TextBox5.Text)
            cmd.Parameters.AddWithValue("@cpnum", TextBox6.Text)
            cmd.Parameters.AddWithValue("@timein", TextBox7.Text)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        Form4_Load(sender, e)


    End Sub
End Class