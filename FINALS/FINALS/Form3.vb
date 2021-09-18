Public Class Form3


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Username.Text = "admin" And Password.Text = "admin" Then

            Form1.Show()
            Me.Hide()
            Password.Clear()
            Username.Clear()
        Else
            MsgBox("Incorrect", MsgBoxStyle.Critical, "Invalid")
            Password.Clear()
            Username.Clear()
            Username.Focus()
        End If
    End Sub
End Class