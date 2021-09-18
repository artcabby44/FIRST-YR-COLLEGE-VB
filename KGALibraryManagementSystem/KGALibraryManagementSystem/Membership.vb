Imports MySql.Data.MySqlClient
Public Class Membership
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Membership_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Hide()
        TextBox5.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox8.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox7.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox6.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox5.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Please Fill-up All Information Needed")

        ElseIf TextBox7.Text = TextBox8.Text Then

            Try
                sql.con.Open()
                qry = "INSERT INTO users (regnum,fname,lname,gender,dept,email,password) VALUES (@regnum,@fname,@lname,@gender,@dept,@email,@password)"
                cmd = New MySqlCommand(qry, sql.con)
                cmd.Parameters.AddWithValue("@regnum", TextBox3.Text)
                cmd.Parameters.AddWithValue("@fname", TextBox1.Text)
                cmd.Parameters.AddWithValue("@lname", TextBox2.Text)
                cmd.Parameters.AddWithValue("@gender", TextBox5.Text)
                cmd.Parameters.AddWithValue("@dept", ComboBox1.SelectedItem)
                cmd.Parameters.AddWithValue("@email", TextBox6.Text)
                cmd.Parameters.AddWithValue("@password", TextBox7.Text)


                MsgBox("Hi, " & TextBox1.Text & " You've successfuly created your account,Thank you")

                cmd.ExecuteNonQuery()

                sql.con.Close()
                Me.Hide()
                Login.Show()

                TextBox3.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox5.Text = ""
                ComboBox1.SelectedItem = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
            Catch ex As Exception

            End Try
        Else
            MsgBox("Password not matched please re-enter your password")
            MsgBox("book")
            TextBox3.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox5.Text = ""
            ComboBox1.SelectedItem = ""
            TextBox6.Text = ""
            TextBox7.Text = ""

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox5.Text = "Male"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox5.Text = "Female"
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "Male" Then
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox2.Visible = True
        ElseIf TextBox5.Text = "Female" Then
            PictureBox1.Visible = False
            PictureBox3.Visible = True
            PictureBox2.Visible = False
        Else
            PictureBox1.Visible = True
            PictureBox3.Visible = False
            PictureBox2.Visible = False

        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = TextBox7.Text Then
            Label1.Text = "Password Matched"
            Button1.Show()

        ElseIf TextBox8.Text = "" Then
            Label1.Text = ""
            Button1.Hide()

        Else
            Label1.Text = "Password Not Matched!!"
            Button1.Hide()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class