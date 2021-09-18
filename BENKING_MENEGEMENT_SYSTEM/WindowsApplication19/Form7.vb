Imports MySql.Data.MySqlClient

Public Class Form7
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
            Try
                sql.con.Open()

                qry = "UPDATE users SET bal = bal - @bal  WHERE cardnum=@cardnum"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@cardnum", Label3.Text)
                cmd.Parameters.AddWithValue("@bal", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Amount was withdrawn")
                sql.con.Close()
                Me.Hide()
                Form1.Show()


            Catch ex As Exception
                MsgBox("oopps")
            End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class