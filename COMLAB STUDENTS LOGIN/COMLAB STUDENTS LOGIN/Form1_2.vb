Public Class Form1

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox2.Text = ComboBox2.SelectedItem
        If ComboBox2.SelectedItem = "None of the above" Then
            TextBox2.Text = ""
            ComboBox2.Hide()
            TextBox2.Show()
            Label2.Hide()
            Label4.Show()

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Hide()
        Label4.Hide()

        Timer1.Start()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Fill up all the information needed")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Fill up all the information needed")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please Fill up all the information needed")
        Else
            Form2.Show()

        End If
        Label4.Hide()
        TextBox2.Hide()
        Label2.Show()
        ComboBox2.Show()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay
        Label6.Text = Today

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()

    End Sub
End Class
