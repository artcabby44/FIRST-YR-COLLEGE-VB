Imports MySql.Data.MySqlClient

Public Class Form5
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then

            Try
                sql.con.Open()

                qry = "UPDATE users SET fixedbal = fixedbal + @fixedbal WHERE cardnum=@cardnum"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@cardnum", Label3.Text)
                cmd.Parameters.AddWithValue("@fixedbal", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Ammount was deposited, Thank you")
                Me.Hide()
                Form1.Show()
                sql.con.Close()

            Catch ex As Exception
                MsgBox("oopps")

            End Try
        Else

            Try
                sql.con.Open()

                qry = "UPDATE users SET bal = bal + @bal  WHERE cardnum=@cardnum"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@cardnum", Label3.Text)
                cmd.Parameters.AddWithValue("@bal", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Ammount was deposited")
                Me.Hide()
                Form1.Show()

            Catch ex As Exception
                MsgBox("oopps")

            End Try
        End If

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Form1.Label1.Text

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
   

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class