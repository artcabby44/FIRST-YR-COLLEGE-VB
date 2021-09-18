Public Class Form1
    Dim cafep, spritep, limep, bluep, orangep, cokep, cafe, sprite, lime, blue, orange, coke As Integer
    Dim qiuck, siomai, chicken, fries, burger, spag, quickp, siomaip, chickenp, friesp, burgerp, spagp, total As Double


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)








    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        cafe = 30
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox1.Visible = True
            TextBox7.Visible = True
            TextBox14.Visible = True
            Label19.Visible = True
            Label8.Visible = True
            Label7.Visible = True
        Else
            TextBox1.Visible = False
            TextBox7.Visible = False
            TextBox14.Visible = False
            TextBox1.Text = Nothing
            TextBox7.Text = Nothing
            TextBox14.Text = Nothing
            Label19.Visible = False
            Label8.Visible = False
            Label7.Visible = False

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        cafep = Val(TextBox14.Text) * cafe
        TextBox1.Text = cafep
        If TextBox14.Text = "" Then
            TextBox1.Text = ""

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        sprite = 20
        If CheckBox2.CheckState = CheckState.Checked Then
            TextBox15.Visible = True
            TextBox2.Visible = True
            TextBox8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label20.Visible = True
        Else
            TextBox2.Visible = False
            TextBox15.Visible = False
            TextBox8.Visible = False
            TextBox2.Text = Nothing
            TextBox15.Text = Nothing
            TextBox8.Text = Nothing
            Label9.Visible = False
            Label10.Visible = False
            Label20.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
     
    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        spritep = Val(TextBox15.Text) * sprite
        TextBox2.Text = spritep
        If TextBox15.Text = "" Then
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        lime = 30

        If CheckBox3.CheckState = CheckState.Checked Then
            TextBox16.Visible = True
            TextBox3.Visible = True
            TextBox10.Visible = True
            Label11.Visible = True
            Label14.Visible = True
            Label22.Visible = True
        Else
            TextBox16.Visible = False
            TextBox3.Visible = False
            TextBox10.Visible = False
            TextBox16.Text = Nothing
            TextBox3.Text = Nothing
            TextBox10.Text = Nothing
            Label11.Visible = False
            Label14.Visible = False
            Label22.Visible = False
        End If
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        limep = Val(TextBox16.Text) * lime
        TextBox3.Text = limep
        If TextBox16.Text = "" Then
            TextBox3.Text = ""

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        blue = 30

        If CheckBox4.CheckState = CheckState.Checked Then
            TextBox17.Visible = True
            TextBox4.Visible = True
            TextBox9.Visible = True
            Label13.Visible = True
            Label12.Visible = True
            Label21.Visible = True
        Else
            TextBox17.Visible = False
            TextBox4.Visible = False
            TextBox9.Visible = False
            TextBox17.Text = Nothing
            TextBox4.Text = Nothing
            TextBox9.Text = Nothing
            Label13.Visible = False
            Label12.Visible = False
            Label21.Visible = False
        End If
    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        bluep = Val(TextBox17.Text) * blue
        TextBox4.Text = bluep
        If TextBox17.Text = "" Then
            TextBox4.Text = ""
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        orange = 30
        If CheckBox5.CheckState = CheckState.Checked Then
            TextBox19.Visible = True
            TextBox5.Visible = True
            TextBox11.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label23.Visible = True
        Else
            TextBox11.Visible = False
            TextBox19.Visible = False
            TextBox5.Visible = False
            TextBox11.Text = Nothing
            TextBox19.Text = Nothing
            TextBox5.Text = Nothing
            Label15.Visible = False
            Label16.Visible = False
            Label23.Visible = False
        End If
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        orangep = Val(TextBox19.Text) * orange
        TextBox5.Text = orangep
        If TextBox19.Text = "" Then
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        coke = 20
        If CheckBox6.CheckState = CheckState.Checked Then
            TextBox18.Visible = True
            TextBox6.Visible = True
            TextBox12.Visible = True
            Label17.Show()
            Label18.Show()
            Label24.Show()

        Else
            TextBox18.Visible = False
            TextBox6.Visible = False
            TextBox12.Visible = False
            TextBox18.Text = Nothing
            TextBox6.Text = Nothing
            TextBox12.Text = Nothing
            Label17.Hide()
            Label18.Hide()
            Label24.Hide()

        End If

    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged
        cokep = Val(TextBox18.Text) * coke
        TextBox6.Text = cokep
        If TextBox18.Text = "" Then
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LagadoomDataSet.lagadoom' table. You can move, or remove it, as needed.
        Me.LagadoomTableAdapter.Fill(Me.LagadoomDataSet.lagadoom)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox7_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        qiuck = 150
        If CheckBox7.CheckState = CheckState.Checked Then
            squidp.Visible = True
            squidq.Visible = True
            squids.Visible = True
            Label50.Show()
            Label52.Show()
            Label30.Show()

        Else
            squidp.Visible = False
            squidq.Visible = False
            squids.Visible = False
            squidp.Text = Nothing
            squidq.Text = Nothing
            squids.Text = Nothing
            Label50.Hide()
            Label52.Hide()
            Label30.Hide()
        End If
    End Sub


    Private Sub squidq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles squidq.TextChanged
        quickp = Val(squidq.Text) * qiuck
        squidp.Text = quickp

        If squidq.Text = "" Then
            squidq.Text = ""
        End If

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        siomai = 100
        If CheckBox8.CheckState = CheckState.Checked Then
            siop.Visible = True
            sios.Visible = True
            sioq.Visible = True
            Label31.Show()
            Label32.Show()
            Label34.Show()

        Else
            sioq.Visible = False
            siop.Visible = False
            sios.Visible = False
            siop.Text = Nothing
            sioq.Text = Nothing
            sios.Text = Nothing
            Label31.Hide()
            Label32.Hide()
            Label34.Hide()
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        chicken = 130
        If CheckBox9.CheckState = CheckState.Checked Then
            TextBox29.Visible = True
            TextBox27.Visible = True
            TextBox38.Visible = True
            Label35.Show()
            Label38.Show()
            Label51.Show()

        Else
            TextBox29.Visible = False
            TextBox27.Visible = False
            TextBox38.Visible = False
            TextBox29.Text = Nothing
            TextBox27.Text = Nothing
            TextBox38.Text = Nothing
            Label35.Hide()
            Label38.Hide()
            Label51.Hide()
        End If
    End Sub

    Private Sub sioq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sioq.TextChanged
        siomaip = Val(sioq.Text) * siomai
        siop.Text = siomaip

        If sioq.Text = "" Then
            siop.Text = ""
        End If
    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged
        chickenp = Val(TextBox29.Text) * chicken
        TextBox27.Text = chickenp

        If TextBox29.Text = "" Then
            TextBox27.Text = ""
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        fries = 100
        If CheckBox10.CheckState = CheckState.Checked Then
            TextBox26.Visible = True
            TextBox28.Visible = True
            TextBox30.Visible = True
            Label36.Show()
            Label37.Show()
            Label39.Show()

        Else
            TextBox26.Visible = False
            TextBox28.Visible = False
            TextBox30.Visible = False
            TextBox26.Text = Nothing
            TextBox28.Text = Nothing
            TextBox30.Text = Nothing
            Label36.Hide()
            Label37.Hide()
            Label39.Hide()
        End If
    End Sub

    Private Sub TextBox30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.TextChanged
        friesp = Val(TextBox30.Text) * fries
        TextBox28.Text = friesp

        If TextBox30.Text = "" Then
            TextBox28.Text = ""
        End If

    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        burger = 110
        If CheckBox11.CheckState = CheckState.Checked Then
            TextBox31.Visible = True
            TextBox33.Visible = True
            TextBox35.Visible = True
            Label42.Show()
            Label43.Show()
            Label46.Show()

        Else
            TextBox31.Visible = False
            TextBox33.Visible = False
            TextBox35.Visible = False
            TextBox31.Text = Nothing
            TextBox33.Text = Nothing
            TextBox35.Text = Nothing
            Label42.Hide()
            Label43.Hide()
            Label46.Hide()

        End If
    End Sub

    Private Sub TextBox35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox35.TextChanged
        burgerp = Val(TextBox35.Text) * burger
        TextBox33.Text = burgerp

        If TextBox35.Text = "" Then
            TextBox33.Text = ""
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        spag = 140
        If CheckBox12.CheckState = CheckState.Checked Then
            TextBox32.Visible = True
            TextBox34.Visible = True
            TextBox36.Visible = True
            Label44.Show()
            Label45.Show()
            Label47.Show()

        Else
            TextBox32.Visible = False
            TextBox34.Visible = False
            TextBox36.Visible = False
            TextBox32.Text = Nothing
            TextBox34.Text = Nothing
            TextBox36.Text = Nothing
            Label44.Hide()
            Label45.Hide()
            Label47.Hide()

        End If
    End Sub

    Private Sub TextBox36_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox36.TextChanged
        spagp = Val(TextBox36.Text) * spag
        TextBox34.Text = spagp

        If TextBox36.Text = "" Then
            TextBox34.Text = ""
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        total = quickp + siomaip + chickenp + friesp + burgerp + spagp + cafep + spritep + limep + bluep + orangep
        TextBox13.Text = total

    End Sub

    Private Sub TextBox20_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        TextBox21.Text = Val(TextBox20.Text) - Val(TextBox13.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class