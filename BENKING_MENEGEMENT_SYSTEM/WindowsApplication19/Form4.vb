Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()


    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim isave As New SaveFileDialog
        isave.Filter = "txt files (*.txt) | *.txt "
        isave.FilterIndex = 2
        isave.RestoreDirectory = False

        If isave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(isave.FileName, TextBox1.Text)
        End If
    End Sub
End Class