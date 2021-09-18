Public Class Form2
    Dim firstnum As Decimal
    Dim secondnum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False

    Private Sub answer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles answer.TextChanged

    End Sub

    Private Sub equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal.Click
        If operator_selector = True Then
            secondnum = answer.Text
            If operations = 1 Then
                answer.Text = firstnum + secondnum
            ElseIf operations = 2 Then
                answer.Text = firstnum - secondnum
            ElseIf operations = 3 Then
                answer.Text = firstnum * secondnum
           

            Else
                If secondnum = 0 Then
                    answer.Text = MsgBox("Error", MsgBoxStyle.Critical)
                ElseIf operations = 4 Then
                    answer.Text = firstnum / secondnum
                End If
        End If
        operator_selector = False
        End If

        change1.Text = answer.Text
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        total1.Clear()
        cash1.Clear()
        change1.Clear()
        answer.Clear()
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        change1.Text = Val(cash1.Text) - Val(total1.Text)
        Form1.price.AppendText(vbNewLine & "*****************************************************" & vbNewLine)
        Form1.price.AppendText(total.Text & " " & total1.Text & vbNewLine & cash.Text & " " & cash1.Text & vbNewLine & change.Text & " " & change1.Text & vbNewLine & vbNewLine & vbTab & DateAndTime.Today & vbNewLine & vbTab & TimeOfDay)
        total1.Clear()
        cash1.Clear()
        change1.Clear()
        answer.Clear()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        answer.Focus()
    End Sub

    Private Sub answer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles answer.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub one_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one.Click
        If answer.Text <> "" Then
            answer.Text += "1"
        Else
            answer.Text = "1"
        End If
    End Sub

    Private Sub two_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles two.Click
        If answer.Text <> "" Then
            answer.Text += "2"
        Else
            answer.Text = "2"
        End If
    End Sub

    Private Sub three_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles three.Click
        If answer.Text <> "" Then
            answer.Text += "3"
        Else
            answer.Text = "3"
        End If
    End Sub

    Private Sub four_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles four.Click
        If answer.Text <> "" Then
            answer.Text += "4"
        Else
            answer.Text = "4"
        End If
    End Sub

    Private Sub five_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles five.Click
        If answer.Text <> "" Then
            answer.Text += "5"
        Else
            answer.Text = "5"
        End If
    End Sub

    Private Sub six_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles six.Click
        If answer.Text <> "" Then
            answer.Text += "6"
        Else
            answer.Text = "6"
        End If
    End Sub

    Private Sub seven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seven.Click
        If answer.Text <> "" Then
            answer.Text += "7"
        Else
            answer.Text = "7"
        End If
    End Sub

    Private Sub eight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eight.Click
        If answer.Text <> "" Then
            answer.Text += "8"
        Else
            answer.Text = "8"
        End If
    End Sub

    Private Sub nine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nine.Click
        If answer.Text <> "" Then
            answer.Text += "9"
        Else
            answer.Text = "9"
        End If
    End Sub

    Private Sub zero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zero.Click
        If answer.Text <> "" Then
            answer.Text += "0"


        End If
    End Sub

    Private Sub dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot.Click
        If Not (answer.Text.Contains(".")) Then
            answer.Text += "."
        End If
    End Sub

    Private Sub c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.Click
        answer.Clear()
        change1.Clear()
        cash1.Clear()
    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        firstnum = answer.Text
        answer.Text = ""
        operator_selector = True
        Operations = 1

    End Sub

    Private Sub minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus.Click
        firstnum = answer.Text
        answer.Text = ""
        operator_selector = True
        operations = 2

    End Sub

    Private Sub multiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiply.Click
        firstnum = answer.Text
        answer.Text = ""
        operator_selector = True
        operations = 3

    End Sub

    Private Sub divide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divide.Click
        firstnum = answer.Text
        answer.Text = ""
        operator_selector = True
        operations = 4

    End Sub

    Private Sub cash1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cash1.TextChanged
        answer.Text = cash1.Text
    End Sub
End Class