Imports MySql.Data.MySqlClient

Public Class Form2
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public auto As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim r As New Random
        Dim s As String
        Dim t As String
        Dim u As String
        Dim v As String

        If TextBox7.Text <> TextBox6.Text Then

            MsgBox("PASSWORD NOT MATCHED")
     

        Else

            s = (Convert.ToString(r.Next(1000, 2000)))
            t = (Convert.ToString(r.Next(5000, 6000)))
            u = (Convert.ToString(r.Next(9000, 10000)))
            v = (Convert.ToString(r.Next(1000, 9000)))

            auto = s & " " & t & " " & u & " " & v
            If RadioButton1.Checked = True Then

                If TextBox9.Text > 500 Then


                    Try
                        sql.con.Open()
                        qry = "INSERT INTO users (name,gen,address,email,phone,cardnum,pin,bal) VALUES (@name,@gen,@address,@email,@phone,@cardnum,@pin,@bal)"
                        cmd = New MySqlCommand(qry, sql.con)
                        cmd.Parameters.AddWithValue("@name", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@age", TextBox2.Text)
                        cmd.Parameters.AddWithValue("@gen", ComboBox1.SelectedItem)
                        cmd.Parameters.AddWithValue("@address", TextBox3.Text)
                        cmd.Parameters.AddWithValue("@email", TextBox4.Text)
                        cmd.Parameters.AddWithValue("@phone", TextBox5.Text)
                        cmd.Parameters.AddWithValue("@cardnum", auto)
                        cmd.Parameters.AddWithValue("@pin", TextBox6.Text)
                        cmd.Parameters.AddWithValue("@bal", TextBox9.Text)


                        cmd.ExecuteNonQuery()

                        Me.Hide()

                        MsgBox("ACCOUNT CREATED, THANK YOU")

                        Form4.Show()
                        Form4.TextBox1.AppendText("NAME: " & TextBox1.Text & vbNewLine & vbNewLine & "CARD/ACCOUNT NUMBER: " & auto & vbNewLine & vbNewLine & "PIN/PASSWORD: " & TextBox6.Text & vbNewLine & vbNewLine & "SAVINGS BALANCE: " & TextBox9.Text)

                    Catch ex As Exception
                        MsgBox("opps fill up all infomation needed")
                    End Try
                Else
                    MsgBox("Savings should not be less than 500")
                End If

            ElseIf RadioButton2.Checked = True Then

                If TextBox9.Text > 20000 Then



                    Try
                        sql.con.Open()
                        qry = "INSERT INTO users (name,gen,address,email,phone,cardnum,pin,fixedbal) VALUES (@name,@gen,@address,@email,@phone,@cardnum,@pin,@fixedbal)"
                        cmd = New MySqlCommand(qry, sql.con)
                        cmd.Parameters.AddWithValue("@name", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@age", TextBox2.Text)
                        cmd.Parameters.AddWithValue("@gen", ComboBox1.SelectedItem)
                        cmd.Parameters.AddWithValue("@address", TextBox3.Text)
                        cmd.Parameters.AddWithValue("@email", TextBox4.Text)
                        cmd.Parameters.AddWithValue("@phone", TextBox5.Text)
                        cmd.Parameters.AddWithValue("@cardnum", auto)
                        cmd.Parameters.AddWithValue("@pin", TextBox6.Text)
                        cmd.Parameters.AddWithValue("@fixedbal", TextBox9.Text)

                        cmd.ExecuteNonQuery()

                        Me.Hide()

                        MsgBox("FIXED AMOUNT DEPOSITED THANK YOU")

                        Form4.Show()
                        Form4.TextBox1.AppendText("NAME: " & TextBox1.Text & vbNewLine & vbNewLine & "CARD/ACCOUNT NUMBER: " & auto & vbNewLine & vbNewLine & "PIN/PASSWORD: " & TextBox6.Text & vbNewLine & vbNewLine & "CHECKED ACCOUNT BALANCE: " & TextBox9.Text)

                    Catch ex As Exception
                        MsgBox("opps fill up all infomation needed")
                    End Try
            Else
                MsgBox("Please Insert Your Initial Deposit")
                End If
            Else
                MsgBox("Checked Deposit should not be less than 20000")
            End If


        End If

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class