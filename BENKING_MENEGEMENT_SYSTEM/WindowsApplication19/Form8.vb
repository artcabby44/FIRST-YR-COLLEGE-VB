Public Class Form8
    Public cb As String

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BenkDataSet1.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter1.Fill(Me.BenkDataSet1.users)
        cb = Form1.Label1.Text
        UsersBindingSource1.Filter = String.Format("[cardnum] Like '{0}%'", Me.cb.Trim())
        'TODO: This line of code loads data into the 'BenkDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.BenkDataSet.users)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form8_Load(sender, e)
    End Sub
End Class