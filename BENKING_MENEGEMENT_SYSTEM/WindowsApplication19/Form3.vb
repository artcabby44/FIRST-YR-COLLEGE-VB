Imports MySql.Data.MySqlClient
Public Class Form3
    Public sql As New Class1
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim command As MySqlCommand = New MySqlCommand( _
                 "SELECT * FROM users WHERE cardnum = '" & _
                 TextBox1.Text & "' AND pin = '" & TextBox2.Text & "' ", sql.con)

        Sql.con.Open()
        Dim sdr As MySqlDataReader = command.ExecuteReader()
        If (sdr.Read() = True) Then
            MessageBox.Show("You are Now Logged In")
            sql.con.Close()
            Form1.Show()
            Form1.Label1.Text = TextBox1.Text

            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password!")
            Sql.con.Close()
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class