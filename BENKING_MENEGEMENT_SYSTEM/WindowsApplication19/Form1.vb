Imports MySql.Data.MySqlClient

Public Class Form1
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public s As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        s = "Fixed Account"
        Dim command As MySqlCommand = New MySqlCommand( _
                   "SELECT * FROM users WHERE cardnum = '" & _
                   Label1.Text & "' AND acctype = '" & s & "' ", sql.con)

        sql.con.Open()
        Dim sdr As MySqlDataReader = command.ExecuteReader()
        If (sdr.Read() = True) Then
            MessageBox.Show("You cant widraw From your account")
        Else
            Form7.Show()
            Form7.Label3.Text = Label1.Text
            Me.Hide()
            sql.con.Close()
            sql.con.Close()
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Form5.Show()
        Form5.Label3.Text = Label1.Text
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Form8.Show()
        Form8.cb = Label1.Text

        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form9.Show()

        Form9.Label1.Text = Label1.Text
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form7.Show()
        Form7.Label3.Text = Label1.Text

    End Sub
End Class