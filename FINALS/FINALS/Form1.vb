Public Class Form1
    Dim curwidth As Integer = Me.Width
    Dim curheight As Integer = Me.Height
    Dim ratioheight As Double = (Me.Height - curheight) / curheight
    Dim ratiowidth As Double = (Me.Width - curwidth) / curwidth

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize



        For Each ctrl As Control In Controls
            ctrl.Width += ctrl.Width = ratiowidth
            ctrl.Left += ctrl.Left = ratiowidth
            ctrl.Top += ctrl.Top = ratioheight
            ctrl.Height += ctrl.Height = ratioheight


        Next

        curheight = Me.Height
        curwidth = Me.Width



    End Sub

    Private Sub beerpilsen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beerpilsen.CheckedChanged
        If beerpilsen.CheckState = CheckState.Checked Then
            bp.Enabled = True
            bp.Focus()

        Else
            bp.Enabled = False
            bp.Clear()
        End If
    End Sub

    Private Sub sanmiglight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sanmiglight.CheckedChanged
        If sanmiglight.CheckState = CheckState.Checked Then
            sml.Enabled = True
            sml.Focus()
        Else
            sml.Enabled = False
            sml.Clear()
        End If
    End Sub

    Private Sub reedhorse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reedhorse.CheckedChanged
        If reedhorse.CheckState = CheckState.Checked Then
            rh.Enabled = True
            rh.Focus()
        Else
            rh.Enabled = False
            rh.Clear()
        End If
    End Sub

    Private Sub mucho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mucho.CheckedChanged
        If mucho.CheckState = CheckState.Checked Then
            much.Enabled = True
            much.Focus()
        Else
            much.Enabled = False
            much.Clear()
        End If
    End Sub

    Private Sub bucket_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bucket.CheckedChanged
        If bucket.CheckState = CheckState.Checked Then
            buck.Enabled = True
            buck.Focus()
        Else
            buck.Enabled = False
            buck.Clear()
        End If
    End Sub

    Private Sub liters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles liters.CheckedChanged
        If liters.CheckState = CheckState.Checked Then
            lit.Enabled = True
            lit.Focus()
        Else
            lit.Enabled = False
            lit.Clear()
        End If
    End Sub

    Private Sub pork_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pork.CheckedChanged
        If pork.CheckState = CheckState.Checked Then
            por.Enabled = True
            por.Focus()
        Else
            por.Enabled = False
            por.Clear()
        End If
    End Sub

    Private Sub bangus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bangus.CheckedChanged
        If bangus.CheckState = CheckState.Checked Then
            bang.Enabled = True
            bang.Focus()
        Else
            bang.Enabled = False
            bang.Clear()
        End If
    End Sub

    Private Sub tuna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tuna.CheckedChanged
        If tuna.CheckState = CheckState.Checked Then
            tun.Enabled = True
            tun.Focus()
        Else
            tun.Enabled = False
            tun.Clear()
        End If
    End Sub

    Private Sub chicken_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chicken.CheckedChanged
        If chicken.CheckState = CheckState.Checked Then
            chick.Enabled = True
            chick.Focus()
        Else
            chick.Enabled = False
            chick.Clear()
        End If
    End Sub

    Private Sub lechon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lechon.CheckedChanged
        If lechon.CheckState = CheckState.Checked Then
            lech.Enabled = True
            lech.Focus()
        Else
            lech.Enabled = False
            lech.Clear()
        End If
    End Sub

    Private Sub butteredfish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butteredfish.CheckedChanged
        If butteredfish.CheckState = CheckState.Checked Then
            fis.Enabled = True
            fis.Focus()
        Else
            fis.Enabled = False
            fis.Clear()
        End If
    End Sub

    Private Sub butteredshrimp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butteredshrimp.CheckedChanged
        If butteredshrimp.CheckState = CheckState.Checked Then
            shrim.Enabled = True
            shrim.Focus()
        Else
            shrim.Enabled = False
            shrim.Clear()
        End If
    End Sub

    Private Sub butteredchicken_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butteredchicken.CheckedChanged
        If butteredchicken.CheckState = CheckState.Checked Then
            bc.Enabled = True
            bc.Focus()
        Else
            bc.Enabled = False
            bc.Clear()
        End If
    End Sub

    Private Sub hotdog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hotdog.CheckedChanged
        If hotdog.CheckState = CheckState.Checked Then
            hot.Enabled = True
            hot.Focus()
        Else
            hot.Enabled = False
            hot.Clear()
        End If
    End Sub

    Private Sub liempo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles liempo.CheckedChanged
        If liempo.CheckState = CheckState.Checked Then
            liem.Enabled = True
            liem.Focus()
        Else
            liem.Enabled = False
            liem.Clear()
        End If
    End Sub

    Private Sub liem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tun.KeyPress, sml.KeyPress, shrim.KeyPress, rh.KeyPress, por.KeyPress, much.KeyPress, lit.KeyPress, liem.KeyPress, lech.KeyPress, hot.KeyPress, fis.KeyPress, chick.KeyPress, buck.KeyPress, bp.KeyPress, bc.KeyPress, bang.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

       

        beerpilsen.CheckState = False
        sanmiglight.CheckState = False
        reedhorse.CheckState = False
        mucho.CheckState = False
        bucket.CheckState = False
        liters.CheckState = False

        pork.CheckState = False
        bangus.CheckState = False
        tuna.CheckState = False
        chicken.CheckState = False
        lechon.CheckState = False
        butteredfish.CheckState = False
        butteredshrimp.CheckState = False
        butteredchicken.CheckState = False
        hotdog.CheckState = False
        liempo.CheckState = False

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        total.Clear()

        price.Clear()
        price.AppendText(vbTab & "Wal-walan Club" & vbNewLine & vbNewLine)




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If beerpilsen.CheckState = CheckState.Checked Then
            TextBox1.Text = Val(bp.Text) * Val(bpp.Text)

            price.AppendText(bp.Text & " " & beerpilsen.Text & " : " & TextBox1.Text & vbNewLine)

        End If

        If sanmiglight.CheckState = CheckState.Checked Then
            TextBox2.Text = Val(sml.Text) * Val(smlp.Text)

            price.AppendText(sml.Text & " " & sanmiglight.Text & " : " & TextBox2.Text & vbNewLine)


        End If

        If reedhorse.CheckState = CheckState.Checked Then
            TextBox3.Text = Val(rh.Text) * Val(rhp.Text)

            price.AppendText(rh.Text & " " & reedhorse.Text & " : " & TextBox3.Text & vbNewLine)

        End If

        If mucho.CheckState = CheckState.Checked Then
            TextBox4.Text = Val(much.Text) * Val(muchp.Text)

            price.AppendText(much.Text & " " & mucho.Text & " : " & TextBox4.Text & vbNewLine)

        End If

        If bucket.CheckState = CheckState.Checked Then
            TextBox5.Text = Val(buck.Text) * Val(buckp.Text)

            price.AppendText(buck.Text & " " & bucket.Text & " : " & TextBox5.Text & vbNewLine)

        End If

        If liters.CheckState = CheckState.Checked Then
            TextBox6.Text = Val(lit.Text) * Val(litp.Text)

            price.AppendText(lit.Text & " " & liters.Text & " : " & TextBox6.Text & vbNewLine)

        End If

        If pork.CheckState = CheckState.Checked Then
            TextBox7.Text = Val(por.Text) * Val(porp.Text)

            price.AppendText(por.Text & " " & pork.Text & " : " & TextBox7.Text & vbNewLine)

        End If

        If bangus.CheckState = CheckState.Checked Then
            TextBox8.Text = Val(bang.Text) * Val(bangp.Text)

            price.AppendText(bang.Text & " " & bangus.Text & " : " & TextBox8.Text & vbNewLine)

        End If

        If tuna.CheckState = CheckState.Checked Then
            TextBox9.Text = Val(tun.Text) * Val(tunp.Text)

            price.AppendText(tun.Text & " " & tuna.Text & " : " & TextBox9.Text & vbNewLine)

        End If

        If chicken.CheckState = CheckState.Checked Then
            TextBox10.Text = Val(chick.Text) * Val(chickp.Text)

            price.AppendText(chick.Text & " " & chicken.Text & " : " & TextBox10.Text & vbNewLine)

        End If

        If lechon.CheckState = CheckState.Checked Then
            TextBox11.Text = Val(lech.Text) * Val(lechp.Text)

            price.AppendText(lech.Text & " " & lechon.Text & " : " & TextBox11.Text & vbNewLine)

        End If

        If butteredfish.CheckState = CheckState.Checked Then
            TextBox12.Text = Val(fis.Text) * Val(fisp.Text)

            price.AppendText(fis.Text & " " & butteredfish.Text & " : " & TextBox12.Text & vbNewLine)

        End If

        If butteredshrimp.CheckState = CheckState.Checked Then
            TextBox13.Text = Val(shrim.Text) * Val(pshrim.Text)

            price.AppendText(shrim.Text & " " & butteredshrimp.Text & " : " & TextBox13.Text & vbNewLine)

        End If

        If butteredchicken.CheckState = CheckState.Checked Then
            TextBox14.Text = Val(bc.Text) * Val(bcp.Text)

            price.AppendText(bc.Text & " " & butteredchicken.Text & " : " & TextBox14.Text & vbNewLine)

        End If

        If hotdog.CheckState = CheckState.Checked Then
            TextBox15.Text = Val(hot.Text) * Val(hotp.Text)

            price.AppendText(hot.Text & " " & hotdog.Text & " : " & TextBox15.Text & vbNewLine)

        End If

        If liempo.CheckState = CheckState.Checked Then
            TextBox16.Text = Val(liem.Text) * Val(liemp.Text)

            price.AppendText(liem.Text & " " & liempo.Text & " : " & TextBox16.Text & vbNewLine)

        End If

        total.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text)

        Form2.total1.Text = total.Text

        Form2.Show()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        price.AppendText(vbTab & "Wal-walan Club" & vbNewLine & vbNewLine)

       
    End Sub

   
    Private Sub total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim isave As New SaveFileDialog
        isave.Filter = "txt files (*.txt) | *.txt "
        isave.FilterIndex = 2
        isave.RestoreDirectory = False

        If isave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(isave.FileName, price.Text)
        End If


        beerpilsen.CheckState = False
        sanmiglight.CheckState = False
        reedhorse.CheckState = False
        mucho.CheckState = False
        bucket.CheckState = False
        liters.CheckState = False

        pork.CheckState = False
        bangus.CheckState = False
        tuna.CheckState = False
        chicken.CheckState = False
        lechon.CheckState = False
        butteredfish.CheckState = False
        butteredshrimp.CheckState = False
        butteredchicken.CheckState = False
        hotdog.CheckState = False
        liempo.CheckState = False

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        total.Clear()

        price.Clear()
        price.AppendText(vbTab & "Wal-walan Club" & vbNewLine & vbNewLine)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles price.TextChanged

    End Sub
End Class
