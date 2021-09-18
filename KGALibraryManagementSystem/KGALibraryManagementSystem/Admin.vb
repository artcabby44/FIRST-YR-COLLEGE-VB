Imports MySql.Data.MySqlClient
Public Class Admin
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox8.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")


        ElseIf TextBox7.Text = TextBox8.Text Then

            Try
                sql.con.Open()
                qry = "INSERT INTO admins (id,firstname,lastname,password) VALUES (@id,@firstname,@lastname,@password)"
                cmd = New MySqlCommand(qry, sql.con)
                cmd.Parameters.AddWithValue("@id", TextBox3.Text)
                cmd.Parameters.AddWithValue("@firstname", TextBox1.Text)
                cmd.Parameters.AddWithValue("@lastname", TextBox2.Text)
                cmd.Parameters.AddWithValue("@password", TextBox7.Text)
            


                MsgBox("Hi, " & TextBox1.Text & " You've successfuly created your account,Thank you")

                cmd.ExecuteNonQuery()

                sql.con.Close()
                Me.Hide()
                Form1.Show()


                TextBox3.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
                
                TextBox7.Text = ""
            Catch ex As Exception
                MsgBox("book")
            End Try
        Else
            MsgBox("Password not matched please re-enter your password")

            TextBox3.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
         

        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Button1.Hide()
        Label5.Hide()

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = TextBox7.Text Then
            Button1.Show()
            Label5.Show()
            Label5.ForeColor = Color.Navy
            Label5.Text = "Pasword Matched"
        
        Else
            Label5.Show()
            Label5.ForeColor = Color.Red
            Label5.Text = "Pasword Not Matched!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Admine.Show()

    End Sub
End Class