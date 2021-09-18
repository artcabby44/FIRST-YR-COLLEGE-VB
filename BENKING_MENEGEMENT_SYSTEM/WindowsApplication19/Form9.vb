Imports MySql.Data.MySqlClient

Public Class Form9
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim result As String

        result = MessageBox.Show("Are you sure you want to transfer " & TextBox1.Text & " to " & TextBox2.Text, "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then



            Try
                sql.con.Open()

                qry = "UPDATE users SET bal = bal - @bal  WHERE cardnum=@cardnum"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@cardnum", Label1.Text)
                cmd.Parameters.AddWithValue("@bal", TextBox1.Text)
                cmd.ExecuteNonQuery()

                Me.Hide()
                Form1.Show()


            Catch ex As Exception
                MsgBox("oopps")
            End Try

            Try


                qry = "UPDATE users SET bal = bal + @bal  WHERE cardnum=@cardnum"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@cardnum", TextBox2.Text)
                cmd.Parameters.AddWithValue("@bal", TextBox1.Text)
                cmd.ExecuteNonQuery()

                sql.con.Close()
                Me.Hide()
                Form1.Show()
                MsgBox(" Amount was transfered")

            Catch ex As Exception
                MsgBox("oopps")
            End Try

        End If


    End Sub
End Class