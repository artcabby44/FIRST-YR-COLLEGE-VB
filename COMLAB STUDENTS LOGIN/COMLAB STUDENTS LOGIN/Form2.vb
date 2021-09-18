Imports MySql.Data.MySqlClient

Public Class Form2
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem = "" Then
            MsgBox("Please Select Your PC Number")
        Else

            sql.con.Close()


            Try
                sql.con.Open()
                qry = "INSERT INTO jimz (name,yrsec,sn,pcnum,date,time) VALUES (@name,@yrsec,@sn,@pcnum,@date,@time)"
                cmd = New MySqlCommand(qry, sql.con)
                cmd.Parameters.AddWithValue("@name", Form1.TextBox1.Text)
                cmd.Parameters.AddWithValue("@yrsec", Form1.TextBox2.Text)
                cmd.Parameters.AddWithValue("@sn", Form1.TextBox3.Text)
                cmd.Parameters.AddWithValue("@pcnum", ComboBox1.SelectedItem)
                cmd.Parameters.AddWithValue("@date", Form1.Label6.Text)
                cmd.Parameters.AddWithValue("@time", Form1.Label5.Text)

                cmd.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            MsgBox("Thank you " & Form1.TextBox1.Text & " you can now use " & ComboBox1.SelectedItem)
            Form2_Load(sender, e)
            Me.Hide()
            Form1.TextBox1.Text = ""
            Form1.TextBox2.Text = ""
            Form1.TextBox3.Text = ""
            Form1.ComboBox2.Text = ""

        End If
        ComboBox1.Text = ""

    End Sub
End Class