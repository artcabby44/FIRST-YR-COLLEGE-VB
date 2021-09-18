Imports MySql.Data.MySqlClient
Public Class form3
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter your Registration number and password")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please enter your Registration number and password")

        Else


            Dim command As MySqlCommand = New MySqlCommand( _
                      "SELECT * FROM admins WHERE id = '" & _
                      TextBox1.Text & "' AND password = '" & TextBox2.Text & "' ", sql.con)

            sql.con.Open()
            Dim sdr As MySqlDataReader = command.ExecuteReader()
            If (sdr.Read() = True) Then
                MessageBox.Show("Thank you, you are now logged in.")
                TextBox1.Clear()
                TextBox2.Clear()
                sql.con.Close()
                Me.Hide()
                Admine.Show()

            Else
                MessageBox.Show("Invalid Username or Password!")
                TextBox1.Clear()
                TextBox2.Clear()

                sql.con.Close()
                End If
        End If





    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Admin.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class