Public Class frmLOGIN

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter

        If TextBox1.Text = "Type Your Username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black

        End If


    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Type Your Username"
            TextBox1.ForeColor = Color.Gray
        End If


    End Sub

    Private Sub TextBox1_SystemColorsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.SystemColorsChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = My.Settings.Username And
            TextBox2.Text = My.Settings.Password Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password!", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Enter

    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "Type Your Password" Then
            TextBox2.Text = ""
            TextBox2.PasswordChar = "*"
            TextBox2.ForeColor = Color.Black
        End If

    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Type Your Password"
            TextBox2.PasswordChar = ""
            TextBox2.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
