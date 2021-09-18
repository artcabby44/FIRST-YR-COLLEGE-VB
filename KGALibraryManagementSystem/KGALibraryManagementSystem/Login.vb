Imports MySql.Data.MySqlClient
Public Class Login
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Membership.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter your Registration number and password")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please enter your Registration number and password")

        Else

            If RadioButton1.Checked Or RadioButton2.Checked Then
                Dim command As MySqlCommand = New MySqlCommand( _
                          "SELECT * FROM users WHERE regnum = '" & _
                          TextBox1.Text & "' AND password = '" & TextBox2.Text & "' ", sql.con)

                sql.con.Open()
                Dim sdr As MySqlDataReader = command.ExecuteReader()
                If (sdr.Read() = True) Then
                    MessageBox.Show("Thank you, you are now logged in.")
                    sql.con.Close()
                    Booklistvb.TextBox7.Text = TextBox1.Text
                    TextBox2.Clear()
                    Me.Hide()
                    If RadioButton1.Checked Then
                        Issue.Show()

                    ElseIf RadioButton2.Checked Then
                        Booklistvb.Show()
                    End If



                Else
                    MessageBox.Show("Invalid Username or Password!")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    sql.con.Close()
                End If
            Else
                MsgBox("Please Select an Action")
            End If
        End If

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox2.Clear()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class