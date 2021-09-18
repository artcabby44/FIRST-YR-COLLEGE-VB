Imports MySql.Data.MySqlClient

Public Class Form3
    Public sql As New Class1
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Const Price_FriedEggWithBaconettes As Decimal = 5
    Const Price_SiomaiAlaCarte As Decimal = 3
    Const Price_FriedShanghaiWithCelery As Decimal = 3
    Const Price_CheeseburgerDeluxe As Decimal = 5
    Const Price_CrispyPataalaJhoy As Decimal = 2
    Const Price_AnielsCrunchyHotdogs As Decimal = 1.5
    Const Price_PasmadoSteaksWithChili As Decimal = 5
    Const Price_SinigangDeMucho As Decimal = 3
    Const Price_YummyGrumpyCake As Decimal = 4
    Const Price_AspaltoSweets As Decimal = 2
    Const Price_DesertDesserts As Decimal = 2
    Const Price_LecheFlan As Decimal = 3
    Const Price_SaltyEggPie As Decimal = 3
    Const Price_RockyRoadBomb As Decimal = 2
    Const Price_HotMomma14 As Decimal = 2
    Const Price_Sugariffic As Decimal = 2
    Const Price_EazyBreezyFloat As Decimal = 1.5
    Const Price_EucalypthicShake As Decimal = 1.5
    Const Price_PopsVanillaShake As Decimal = 3
    Const Price_EdgarsFave As Decimal = 3
    Const Price_MountainShout As Decimal = 1.5
    Const Price_CoolAmericano As Decimal = 4
    Const Price_BarbarasMasterpiece As Decimal = 5
    Const Price_MethodologySecret As Decimal = 2
    Const Tax_Rate As Decimal = 1.86

    Dim iTax As Decimal
    Dim iSubtotal As Decimal
    Dim iTotal As Decimal
    Dim itemcost(24) As Decimal

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblDRINKS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDRINKS.Click

    End Sub

    Private Sub lbljaw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbljaw.Click

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

      
        For Each txt In {textAniels, textAspaltoSweets, textBarbarasMasterpiece, textCheeseburgerDeluxe, textCoolAmericano, textCrispyPataAlaJhoy, textDesertDesserts, textEazyBreezyFloat,
                      textEdgarsFave, textEucalypthicShake, textFriedEggwithBaconettess, textFriedShanghaiWithCelery, textHotMomma14, textLecheFlan, textMethodologSecret, textMountainShout,
                        textPasmadoSteaks, textPopsVanillaShake, textRockyRoadbomb, textSaltyEggPie, textSinigangDeMucho, textSiomaiAlacarte, textSugariffic, textYummyGrumpyCake}
            txt.Enabled = False
        Next
        cmbPayment.Items.Add("Cash")
        cmbPayment.Items.Add("Via Counter")

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Thank you for ordering! Come Again!", "B Z A R D", MessageBoxButtons.OK)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each txt In {textAniels, textAspaltoSweets, textBarbarasMasterpiece, textCheeseburgerDeluxe, textCoolAmericano, textCrispyPataAlaJhoy, textDesertDesserts, textEazyBreezyFloat,
                        textEdgarsFave, textEucalypthicShake, textFriedEggwithBaconettess, textFriedShanghaiWithCelery, textHotMomma14, textLecheFlan, textMethodologSecret, textMountainShout,
                          textPasmadoSteaks, textPopsVanillaShake, textRockyRoadbomb, textSaltyEggPie, textSinigangDeMucho, textSiomaiAlacarte, textSugariffic, textYummyGrumpyCake, txtModeOfPayment}
            txt.Clear()
            txt.Text = "0"
        Next
        txtChange.Text = ""
        txtChange.Text = False
        txtChange.Text = "0"

        txtTotal.Text = ""
        txtTotal.Text = False
        txtTotal.Text = "0"
        cmbPayment.Text = ""
        txtModeOfPayment.Enabled = False
        txtModeOfPayment.Text = "0"

        For Each chk In {chkAniel, chkAspaltoSweets, chkBarbaras, chkCheeseBurgerDeluxe, chkCoolAmericano, chkCrispyPataAlaJhoy, chkDesertDesserts, chkEazyBreezyFloat,
                         chkEdgar, chkEucalypthicShake, chkFriedeggwithbaconettes, chkFriedShanghaiwithCelery, chkHotMomma14, chkLecheFlan, chkMethodology,
                         chkMountainshout, chkMethodology, chkPasmado, chkPop, chkRockyRoadBomb, chkSaltyEggPie, chkSinigangDeMucho, chkSiomaiAlaCarte,
                         chkSugariffic, chkYummyGrumpyCake}
            chk.Checked = False

        Next

    End Sub

    Private Sub chkFriedeggwithbaconettes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFriedeggwithbaconettes.CheckedChanged, CheckBox8.CheckedChanged
        If chkFriedeggwithbaconettes.Checked = True Then
            textFriedEggwithBaconettess.Enabled = True
            textFriedEggwithBaconettess.Text = ""
            textFriedEggwithBaconettess.Focus()
        Else
            textFriedEggwithBaconettess.Enabled = False
            textFriedEggwithBaconettess.Clear()
            textFriedEggwithBaconettess.Text = "0"
        End If

    End Sub
    Private Sub chkSiomaiAlaCarte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSiomaiAlaCarte.CheckedChanged, CheckBox7.CheckedChanged
        If chkSiomaiAlaCarte.Checked = True Then
            textSiomaiAlacarte.Enabled = True
            textSiomaiAlacarte.Text = ""
            textSiomaiAlacarte.Focus()
        Else
            textSiomaiAlacarte.Enabled = False
            textSiomaiAlacarte.Clear()
            textSiomaiAlacarte.Text = "0"
        End If

    End Sub

    Private Sub chkFriedShanghaiwithCelery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFriedShanghaiwithCelery.CheckedChanged, CheckBox6.CheckedChanged
        If chkFriedShanghaiwithCelery.Checked = True Then
            textFriedShanghaiWithCelery.Enabled = True
            textFriedShanghaiWithCelery.Text = ""
            textFriedShanghaiWithCelery.Focus()
        Else
            textFriedShanghaiWithCelery.Enabled = False
            textFriedShanghaiWithCelery.Clear()
            textFriedShanghaiWithCelery.Text = "0"
        End If

    End Sub

    Private Sub chkCheeseBurgerDeluxe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheeseBurgerDeluxe.CheckedChanged, CheckBox5.CheckedChanged
        If chkCheeseBurgerDeluxe.Checked = True Then
            textCheeseburgerDeluxe.Enabled = True
            textCheeseburgerDeluxe.Text = ""
            textCheeseburgerDeluxe.Focus()
        Else
            textCheeseburgerDeluxe.Enabled = False
            textCheeseburgerDeluxe.Clear()
            textCheeseburgerDeluxe.Text = "0"
        End If

    End Sub

    Private Sub chkCrispyPataAlaJhoy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCrispyPataAlaJhoy.CheckedChanged, CheckBox4.CheckedChanged
        If chkCrispyPataAlaJhoy.Checked = True Then
            textCrispyPataAlaJhoy.Enabled = True
            textCrispyPataAlaJhoy.Text = ""
            textCrispyPataAlaJhoy.Focus()
        Else
            textCrispyPataAlaJhoy.Enabled = False
            textCrispyPataAlaJhoy.Clear()
            textCrispyPataAlaJhoy.Text = "0"
        End If

    End Sub


    Private Sub Numbers_Only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textYummyGrumpyCake.KeyPress,
        textSugariffic.KeyPress, textSiomaiAlacarte.KeyPress, textSinigangDeMucho.KeyPress, textSaltyEggPie.KeyPress, textRockyRoadbomb.KeyPress,
        textPopsVanillaShake.KeyPress, textPasmadoSteaks.KeyPress, textMountainShout.KeyPress, textMethodologSecret.KeyPress, textLecheFlan.KeyPress,
        textHotMomma14.KeyPress, textFriedShanghaiWithCelery.KeyPress, textFriedEggwithBaconettess.KeyPress, textEucalypthicShake.KeyPress,
        textEdgarsFave.KeyPress, textEazyBreezyFloat.KeyPress, textDesertDesserts.KeyPress, textCrispyPataAlaJhoy.KeyPress, textCoolAmericano.KeyPress,
        textCheeseburgerDeluxe.KeyPress, textBarbarasMasterpiece.KeyPress, textAspaltoSweets.KeyPress, textAniels.KeyPress, MyBase.KeyPress, txtModeOfPayment.KeyPress, TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox33.KeyPress, TextBox32.KeyPress, TextBox31.KeyPress, TextBox30.KeyPress, TextBox3.KeyPress, TextBox29.KeyPress, TextBox28.KeyPress, TextBox27.KeyPress, TextBox26.KeyPress, TextBox25.KeyPress, TextBox24.KeyPress, TextBox23.KeyPress, TextBox22.KeyPress, TextBox21.KeyPress, TextBox20.KeyPress, TextBox2.KeyPress, TextBox19.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, TextBox1.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub chkAniel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAniel.CheckedChanged, CheckBox3.CheckedChanged
        If chkAniel.Checked = True Then
            textAniels.Enabled = True
            textAniels.Text = ""
            textAniels.Focus()
        Else
            textAniels.Enabled = False
            textAniels.Text = "0"
            textAniels.Clear()
        End If
    End Sub

    Private Sub chkPasmado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPasmado.CheckedChanged, CheckBox2.CheckedChanged
        If chkPasmado.Checked = True Then
            textPasmadoSteaks.Enabled = True
            textPasmadoSteaks.Text = ""
            textPasmadoSteaks.Focus()
        Else
            textPasmadoSteaks.Enabled = False
            textPasmadoSteaks.Clear()
            textPasmadoSteaks.Text = "0"

        End If
    End Sub

    Private Sub chkSinigangDeMucho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSinigangDeMucho.CheckedChanged, CheckBox1.CheckedChanged
        If chkSinigangDeMucho.Checked = True Then
            textSinigangDeMucho.Enabled = True
            textSinigangDeMucho.Text = ""
            textSinigangDeMucho.Focus()
        Else
            textSinigangDeMucho.Enabled = False
            textSinigangDeMucho.Clear()
            textSinigangDeMucho.Text = "0"

        End If
    End Sub

    Private Sub chkYummyGrumpyCake_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYummyGrumpyCake.CheckedChanged
        If chkYummyGrumpyCake.Checked = True Then
            textYummyGrumpyCake.Enabled = True
            textYummyGrumpyCake.Text = ""
            textYummyGrumpyCake.Focus()
        Else
            textYummyGrumpyCake.Enabled = False
            textYummyGrumpyCake.Clear()
            textYummyGrumpyCake.Text = "0"

        End If
    End Sub

    Private Sub chkAspaltoSweets_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAspaltoSweets.CheckedChanged
        If chkAspaltoSweets.Checked = True Then
            textAspaltoSweets.Enabled = True
            textAspaltoSweets.Text = ""
            textAspaltoSweets.Focus()
        Else
            textAspaltoSweets.Enabled = False
            textAspaltoSweets.Clear()
            textAspaltoSweets.Text = "0"

        End If
    End Sub

    Private Sub chkDesertDesserts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesertDesserts.CheckedChanged
        If chkDesertDesserts.Checked = True Then
            textDesertDesserts.Enabled = True
            textDesertDesserts.Text = ""
            textDesertDesserts.Focus()
        Else
            textDesertDesserts.Enabled = False
            textDesertDesserts.Clear()
            textDesertDesserts.Text = "0"

        End If
    End Sub

    Private Sub chkLecheFlan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLecheFlan.CheckedChanged
        If chkLecheFlan.Checked = True Then
            textLecheFlan.Enabled = True
            textLecheFlan.Text = ""
            textLecheFlan.Focus()
        Else
            textLecheFlan.Enabled = False
            textLecheFlan.Clear()
            textLecheFlan.Text = "0"

        End If
    End Sub

    Private Sub chkSaltyEggPie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSaltyEggPie.CheckedChanged
        If chkSaltyEggPie.Checked = True Then
            textSaltyEggPie.Enabled = True
            textSaltyEggPie.Text = ""
            textSaltyEggPie.Focus()
        Else
            textSaltyEggPie.Enabled = False
            textSaltyEggPie.Clear()
            textSaltyEggPie.Text = "0"

        End If
    End Sub

    Private Sub chkRockyRoadBomb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRockyRoadBomb.CheckedChanged
        If chkRockyRoadBomb.Checked = True Then
            textRockyRoadbomb.Enabled = True
            textRockyRoadbomb.Text = ""
            textRockyRoadbomb.Focus()
        Else
            textRockyRoadbomb.Enabled = False
            textRockyRoadbomb.Clear()
            textRockyRoadbomb.Text = "0"

        End If
    End Sub

    Private Sub chkHotMomma14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHotMomma14.CheckedChanged
        If chkHotMomma14.Checked = True Then
            textHotMomma14.Enabled = True
            textHotMomma14.Text = ""
            textHotMomma14.Focus()
        Else
            textHotMomma14.Enabled = False
            textHotMomma14.Clear()
            textHotMomma14.Text = "0"

        End If
    End Sub

    Private Sub chkSugariffic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSugariffic.CheckedChanged
        If chkSugariffic.Checked = True Then
            textSugariffic.Enabled = True
            textSugariffic.Text = ""
            textSugariffic.Focus()
        Else
            textSugariffic.Enabled = False
            textSugariffic.Clear()
            textSugariffic.Text = "0"

        End If
    End Sub

    Private Sub chkEazyBreezyFloat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEazyBreezyFloat.CheckedChanged
        If chkEazyBreezyFloat.Checked = True Then
            textEazyBreezyFloat.Enabled = True
            textEazyBreezyFloat.Text = ""
            textEazyBreezyFloat.Focus()
        Else
            textEazyBreezyFloat.Enabled = False
            textEazyBreezyFloat.Clear()
            textEazyBreezyFloat.Text = "0"

        End If
    End Sub

    Private Sub chkEucalypthicShake_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEucalypthicShake.CheckedChanged
        If chkEucalypthicShake.Checked = True Then
            textEucalypthicShake.Enabled = True
            textEucalypthicShake.Text = ""
            textEucalypthicShake.Focus()
        Else
            textEucalypthicShake.Enabled = False
            textEucalypthicShake.Clear()
            textEucalypthicShake.Text = "0"

        End If
    End Sub

    Private Sub chkPop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPop.CheckedChanged
        If chkPop.Checked = True Then
            textPopsVanillaShake.Enabled = True
            textPopsVanillaShake.Text = ""
            textPopsVanillaShake.Focus()
        Else
            textPopsVanillaShake.Enabled = False
            textPopsVanillaShake.Clear()
            textPopsVanillaShake.Text = "0"

        End If
    End Sub

    Private Sub chkEdgar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEdgar.CheckedChanged
        If chkEdgar.Checked = True Then
            textEdgarsFave.Enabled = True
            textEdgarsFave.Text = ""
            textEdgarsFave.Focus()
        Else
            textEdgarsFave.Enabled = False
            textEdgarsFave.Clear()
            textEdgarsFave.Text = "0"

        End If
    End Sub

    Private Sub chkMountainshout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMountainshout.CheckedChanged
        If chkMountainshout.Checked = True Then
            textMountainShout.Enabled = True
            textMountainShout.Text = ""
            textMountainShout.Focus()
        Else
            textMountainShout.Enabled = False
            textMountainShout.Clear()
            textMountainShout.Text = "0"

        End If
    End Sub

    Private Sub chkCoolAmericano_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCoolAmericano.CheckedChanged
        If chkCoolAmericano.Checked = True Then
            textCoolAmericano.Enabled = True
            textCoolAmericano.Text = ""
            textCoolAmericano.Focus()
        Else
            textCoolAmericano.Enabled = False
            textCoolAmericano.Clear()
            textCoolAmericano.Text = "0"

        End If
    End Sub

    Private Sub chkBarbaras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarbaras.CheckedChanged
        If chkBarbaras.Checked = True Then
            textBarbarasMasterpiece.Enabled = True
            textBarbarasMasterpiece.Text = ""
            textBarbarasMasterpiece.Focus()
        Else
            textBarbarasMasterpiece.Enabled = False
            textBarbarasMasterpiece.Clear()
            textBarbarasMasterpiece.Text = "0"

        End If
    End Sub

    Private Sub chkMethodology_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMethodology.CheckedChanged
        If chkMethodology.Checked = True Then
            textMethodologSecret.Enabled = True
            textMethodologSecret.Text = ""
            textMethodologSecret.Focus()
        Else
            textMethodologSecret.Enabled = False
            textMethodologSecret.Clear()
            textMethodologSecret.Text = "0"

        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        itemcost(0) = Convert.ToDecimal(textFriedEggwithBaconettess.Text) * Price_FriedEggWithBaconettes
        itemcost(1) = Convert.ToDecimal(textSiomaiAlacarte.Text) * Price_SiomaiAlaCarte
        itemcost(2) = Convert.ToDecimal(textFriedShanghaiWithCelery.Text) * Price_FriedShanghaiWithCelery
        itemcost(3) = Convert.ToDecimal(textCheeseburgerDeluxe.Text) * Price_CheeseburgerDeluxe
        itemcost(4) = Convert.ToDecimal(textCrispyPataAlaJhoy.Text) * Price_CrispyPataalaJhoy
        itemcost(5) = Convert.ToDecimal(textAniels.Text) * Price_AnielsCrunchyHotdogs
        itemcost(6) = Convert.ToDecimal(textPasmadoSteaks.Text) * Price_PasmadoSteaksWithChili
        itemcost(7) = Convert.ToDecimal(textSinigangDeMucho.Text) * Price_SinigangDeMucho
        itemcost(8) = Convert.ToDecimal(textYummyGrumpyCake.Text) * Price_YummyGrumpyCake
        itemcost(9) = Convert.ToDecimal(textAspaltoSweets.Text) * Price_AspaltoSweets
        itemcost(10) = Convert.ToDecimal(textDesertDesserts.Text) * Price_DesertDesserts
        itemcost(11) = Convert.ToDecimal(textLecheFlan.Text) * Price_LecheFlan
        itemcost(12) = Convert.ToDecimal(textSaltyEggPie.Text) * Price_SaltyEggPie
        itemcost(13) = Convert.ToDecimal(textRockyRoadbomb.Text) * Price_RockyRoadBomb
        itemcost(14) = Convert.ToDecimal(textSugariffic.Text) * Price_Sugariffic
        itemcost(15) = Convert.ToDecimal(textHotMomma14.Text) * Price_HotMomma14
        itemcost(16) = Convert.ToDecimal(textEazyBreezyFloat.Text) * Price_EazyBreezyFloat
        itemcost(17) = Convert.ToDecimal(textEucalypthicShake.Text) * Price_EucalypthicShake
        itemcost(18) = Convert.ToDecimal(textPopsVanillaShake.Text) * Price_PopsVanillaShake
        itemcost(19) = Convert.ToDecimal(textEdgarsFave.Text) * Price_EdgarsFave
        itemcost(20) = Convert.ToDecimal(textMountainShout.Text) * Price_MountainShout
        itemcost(21) = Convert.ToDecimal(textCoolAmericano.Text) * Price_CoolAmericano
        itemcost(22) = Convert.ToDecimal(textBarbarasMasterpiece.Text) * Price_BarbarasMasterpiece
        itemcost(23) = Convert.ToDecimal(textMethodologSecret.Text) * Price_MethodologySecret

        Dim cost As Decimal
        If cmbPayment.Text = "Cash" Then
            iSubtotal = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) + itemcost(7) + itemcost(8) + itemcost(9) +
                itemcost(10) + itemcost(12) + itemcost(13) + itemcost(14) + itemcost(15) + itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) +
                itemcost(20) + itemcost(21) + itemcost(22) + itemcost(23)
            cost = txtModeOfPayment.Text - iSubtotal
            txtChange.Text = cost

            txtTotal.Text = iSubtotal



        Else
            MessageBox.Show("You must select a mode of Payment", "B Z A R D", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayment.SelectedIndexChanged
        If cmbPayment.Text = "Cash" Then
            txtModeOfPayment.Enabled = True
            txtModeOfPayment.Text = ""
            txtModeOfPayment.Focus()
        Else
            txtModeOfPayment.Enabled = False
            txtModeOfPayment.Text = "0"
        End If

    End Sub

    Private Sub textCoolAmericano_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textCoolAmericano.TextChanged

    End Sub

    Private Sub textBarbarasMasterpiece_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBarbarasMasterpiece.TextChanged

    End Sub

    Private Sub textMountainShout_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textMountainShout.TextChanged

    End Sub

    Private Sub textMethodologSecret_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textMethodologSecret.TextChanged

    End Sub

    Private Sub textEdgarsFave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textEdgarsFave.TextChanged

    End Sub

    Private Sub textPopsVanillaShake_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textPopsVanillaShake.TextChanged

    End Sub

    Private Sub textEucalypthicShake_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textEucalypthicShake.TextChanged

    End Sub

    Private Sub textEazyBreezyFloat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textEazyBreezyFloat.TextChanged

    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub txtModeOfPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModeOfPayment.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click, Label32.Click, Label33.Click, Label1.Click, Label6.Click, Label4.Click, Label37.Click, Label38.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim iClose As DialogResult
        iClose = MessageBox.Show("Confirm if you want to exit", "B Z A R D", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iClose = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtChange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChange.TextChanged

    End Sub

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub textFriedEggwithBaconettess_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textFriedEggwithBaconettess.TextChanged, TextBox9.TextChanged, TextBox33.TextChanged, TextBox32.TextChanged, TextBox31.TextChanged, TextBox30.TextChanged, TextBox29.TextChanged, TextBox28.TextChanged, TextBox27.TextChanged, TextBox26.TextChanged, TextBox25.TextChanged, TextBox24.TextChanged, TextBox23.TextChanged, TextBox22.TextChanged, TextBox21.TextChanged, TextBox20.TextChanged, TextBox19.TextChanged, TextBox18.TextChanged, TextBox17.TextChanged, TextBox16.TextChanged, TextBox15.TextChanged, TextBox14.TextChanged, TextBox13.TextChanged, TextBox12.TextChanged, TextBox11.TextChanged, TextBox10.TextChanged, TextBox1.TextChanged

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub txtPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbPayment.Text = "Cash" Then
            txtModeOfPayment.Enabled = True
            txtModeOfPayment.Text = ""
            txtModeOfPayment.Focus()
        Else
            txtModeOfPayment.Enabled = False
            txtModeOfPayment.Text = "0"
        End If
    End Sub

    Private Sub lblCOMBOMEALS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCOMBOMEALS.Click, Label34.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        dataf.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       
    End Sub
End Class
