Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "vsa_admin" Then
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Opps, You entered a wrong password!")
        End If
    End Sub
End Class