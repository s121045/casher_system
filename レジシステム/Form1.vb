Public Class Form1

    Private MyButton() As System.Windows.Forms.RadioButton
    Private Sub ConnectControls()
        MyButton = New System.Windows.Forms.RadioButton(138) {}
        '単品　バーガー
        MyButton(1) = RadioButton1
        MyButton(2) = RadioButton2
        MyButton(3) = RadioButton3
        MyButton(4) = RadioButton4
        MyButton(5) = RadioButton5
        MyButton(6) = RadioButton6
        MyButton(7) = RadioButton7
        MyButton(8) = RadioButton8
        MyButton(9) = RadioButton9
        MyButton(10) = RadioButton10
        MyButton(11) = RadioButton11
        MyButton(12) = RadioButton12
        MyButton(13) = RadioButton13

        MyButton(14) = RadioButton122

        '単品　サイド
        MyButton(15) = RadioButton14
        MyButton(16) = RadioButton15
        MyButton(17) = RadioButton16
        MyButton(18) = RadioButton18
        MyButton(19) = RadioButton19
        MyButton(20) = RadioButton20
        MyButton(21) = RadioButton21
        MyButton(22) = RadioButton22
        MyButton(23) = RadioButton23
        MyButton(24) = RadioButton24
        MyButton(25) = RadioButton25
        MyButton(26) = RadioButton26
        MyButton(27) = RadioButton27
        MyButton(28) = RadioButton28
        MyButton(29) = RadioButton29
        MyButton(30) = RadioButton30
        MyButton(31) = RadioButton31
        MyButton(32) = RadioButton32

        MyButton(33) = RadioButton124

        '単品　ドリンク
        MyButton(34) = RadioButton32
        MyButton(35) = RadioButton33
        MyButton(36) = RadioButton34
        MyButton(37) = RadioButton35
        MyButton(38) = RadioButton36
        MyButton(39) = RadioButton37
        MyButton(40) = RadioButton38
        MyButton(41) = RadioButton39
        MyButton(42) = RadioButton40
        MyButton(43) = RadioButton41
        MyButton(44) = RadioButton42
        MyButton(45) = RadioButton43
        MyButton(46) = RadioButton44
        MyButton(47) = RadioButton45
        MyButton(48) = RadioButton46
        MyButton(49) = RadioButton47
        MyButton(50) = RadioButton48
        MyButton(51) = RadioButton49
        MyButton(52) = RadioButton50
        MyButton(53) = RadioButton51
        MyButton(54) = RadioButton52
        MyButton(55) = RadioButton53
        MyButton(56) = RadioButton54
        MyButton(57) = RadioButton55
        MyButton(58) = RadioButton56
        MyButton(59) = RadioButton57
        MyButton(60) = RadioButton58
        MyButton(61) = RadioButton59
        MyButton(62) = RadioButton60
        MyButton(63) = RadioButton61
        MyButton(64) = RadioButton62
        MyButton(65) = RadioButton63
        MyButton(66) = RadioButton64
        MyButton(67) = RadioButton65
        MyButton(68) = RadioButton66
        MyButton(69) = RadioButton67
        MyButton(70) = RadioButton68
        MyButton(71) = RadioButton69
        MyButton(72) = RadioButton70
        MyButton(73) = RadioButton71
        MyButton(74) = RadioButton72
        MyButton(75) = RadioButton73
        MyButton(76) = RadioButton74
        MyButton(77) = RadioButton75
        MyButton(78) = RadioButton76
        MyButton(79) = RadioButton77
        MyButton(80) = RadioButton78
        MyButton(81) = RadioButton79
        MyButton(82) = RadioButton107
        MyButton(83) = RadioButton108
        MyButton(84) = RadioButton109
        MyButton(85) = RadioButton110
        MyButton(86) = RadioButton111
        MyButton(87) = RadioButton80
        MyButton(88) = RadioButton81
        MyButton(89) = RadioButton82
        MyButton(90) = RadioButton83
        MyButton(91) = RadioButton84
        MyButton(92) = RadioButton85

        MyButton(93) = RadioButton125

        'セット　バーガー
        MyButton(94) = RadioButton86
        MyButton(95) = RadioButton87
        MyButton(96) = RadioButton88
        MyButton(97) = RadioButton89
        MyButton(98) = RadioButton90
        MyButton(99) = RadioButton91
        MyButton(100) = RadioButton92
        MyButton(101) = RadioButton93
        MyButton(102) = RadioButton94
        MyButton(103) = RadioButton95
        MyButton(104) = RadioButton96
        MyButton(105) = RadioButton97
        MyButton(106) = RadioButton98

        MyButton(107) = RadioButton127

        'セット　ドリンク
        MyButton(108) = RadioButton112
        MyButton(109) = RadioButton113
        MyButton(110) = RadioButton114
        MyButton(111) = RadioButton115
        MyButton(112) = RadioButton116
        MyButton(113) = RadioButton117
        MyButton(114) = RadioButton120
        MyButton(115) = RadioButton123
        MyButton(116) = RadioButton126
        MyButton(117) = RadioButton129
        MyButton(118) = RadioButton132
        MyButton(119) = RadioButton135
        MyButton(120) = RadioButton138
        MyButton(121) = RadioButton141
        MyButton(122) = RadioButton144
        MyButton(123) = RadioButton146

        MyButton(124) = RadioButton128

        'セット内容変更１
        MyButton(125) = RadioButton99
        MyButton(126) = RadioButton101
        MyButton(127) = RadioButton102
        MyButton(128) = RadioButton103
        MyButton(129) = RadioButton104
        MyButton(130) = RadioButton105
        MyButton(131) = RadioButton118
        MyButton(132) = RadioButton119
        MyButton(133) = RadioButton121

        MyButton(134) = RadioButton130

        'セット内容変更２
        MyButton(135) = RadioButton100
        MyButton(136) = RadioButton106

        MyButton(137) = RadioButton131

        'その他(セットのドリンク)
        MyButton(138) = RadioButton17

        


    End Sub



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ConnectControls()

    End Sub

    Private Sub MyButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Function goukei() As Integer
        Dim sum As Integer = 0
        Dim listCount As Integer = 購入リスト.Items.Count
        For i As Integer = 1 To listCount
            Dim syouhin As String = 購入リスト.Items(i - 1)
            Dim mozisuu As Integer = Len(syouhin)
            Dim position As Integer = syouhin.IndexOf("￥") + 1
            Dim price As Integer = Mid(syouhin, position + 1, (mozisuu + 1) - (position + 1))
            sum += price
        Next
        Return sum
    End Function


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Dim nedan As Integer = goukei()
        Label2.Text = nedan
    End Sub






    Private Function shouhinmei1() As String
        Dim name As String = ""

        For i As Integer = 1 To 13

            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("：") + 1
                Dim kiritori As String = Mid(MyButton(i).Text, 1, position - 1)
                name = kiritori
            End If
        Next

        Return name

    End Function

    Private Function shouhinmei2() As String
        Dim name As String = ""

        For i As Integer = 15 To 32

            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("：") + 1
                Dim kiritori As String = Mid(MyButton(i).Text, 1, position - 1)
                name = kiritori
            End If
        Next

        Return name

    End Function

    Private Function shouhinmei3() As String
        Dim name As String = ""

        For i As Integer = 34 To 92

            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("：") + 1
                Dim kiritori As String = Mid(MyButton(i).Text, 1, position - 1)
                name = kiritori
            End If
        Next

        Return name

    End Function

    Private Function shouhinmei4() As String
        Dim name As String = ""

        For i As Integer = 94 To 106

            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("：") + 1
                Dim kiritori As String = Mid(MyButton(i).Text, 1, position - 1)
                name = kiritori
            End If
        Next

        Return name

    End Function


    Private Function shouhinmei5() As String
        Dim name As String = ""

        For i As Integer = 108 To 123
            If MyButton(i).Checked = True Then
                Dim all As Integer = Len(MyButton(i).Text)
                name = Mid(MyButton(i).Text, 1, all)
            End If
        Next

        Return name
    End Function


    Private Function kakezan1(ByVal a As Integer) As Integer
        Dim nedan As Integer = 0
        For i As Integer = 1 To 13
            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("￥") + 1
                Dim mozisuu As Integer = Len(MyButton(i).Text)
                Dim price As Integer = Mid(MyButton(i).Text, position + 1, (mozisuu + 1) - (position + 1))
                nedan = price * a
            End If
        Next
        Return nedan
    End Function

    Private Function kakezan2(ByVal a As Integer) As Integer
        Dim nedan As Integer = 0
        For i As Integer = 15 To 32
            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("￥") + 1
                Dim mozisuu As Integer = Len(MyButton(i).Text)
                Dim price As Integer = Mid(MyButton(i).Text, position + 1, (mozisuu + 1) - (position + 1))
                nedan = price * a
            End If
        Next
        Return nedan
    End Function

    Private Function kakezan3(ByVal a As Integer) As Integer
        Dim nedan As Integer = 0
        For i As Integer = 34 To 92
            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("￥") + 1
                Dim mozisuu As Integer = Len(MyButton(i).Text)
                Dim price As Integer = Mid(MyButton(i).Text, position + 1, (mozisuu + 1) - (position + 1))
                nedan = price * a
            End If
        Next
        Return nedan
    End Function

    Private Function kakezan4(ByVal a As Integer) As Integer
        Dim nedan As Integer = 0
        For i As Integer = 94 To 106
            If MyButton(i).Checked = True Then
                Dim position As Integer = MyButton(i).Text.IndexOf("￥") + 1
                Dim mozisuu As Integer = Len(MyButton(i).Text)
                Dim price As Integer = Mid(MyButton(i).Text, position + 1, (mozisuu + 1) - (position + 1))
                nedan = price * a
            End If
        Next
        Return nedan
    End Function





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer = NumericUpDown1.Value
        Dim food As String = ""
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0
        Dim d As Integer = 0
        Dim f As Integer = 0
        Dim g As Integer = 0
        Dim pac As Integer = 0
        Dim j As Integer = 0
        Dim price As Integer = kakezan4(num)
        Dim potato As String = "ポテト"
        Dim drink As String = shouhinmei5()
        Dim potatoSize As String = "Ｍ"
        Dim drinkSize As String = "Ｍ"

        For i As Integer = 1 To 13
            If MyButton(i).Checked = True Then
                購入リスト.Items.Add(shouhinmei1() & "    " & num & "   " & "￥" & kakezan1(num))
                MyButton(i).Checked = False
                NumericUpDown1.Value = 1
            End If
        Next

        For i As Integer = 15 To 32
            If MyButton(i).Checked = True Then
                購入リスト.Items.Add(shouhinmei2() & "    " & num & "   " & "￥" & kakezan2(num))
                MyButton(i).Checked = False
                NumericUpDown1.Value = 1
            End If
        Next

        For i As Integer = 34 To 92
            If MyButton(i).Checked = True Then
                購入リスト.Items.Add(shouhinmei3() & "    " & num & "   " & "￥" & kakezan3(num))
                MyButton(i).Checked = False
                NumericUpDown1.Value = 1
            End If
        Next


        For i As Integer = 108 To 123
            If MyButton(i).Checked = True Then
                a = 1

                If MyButton(109).Checked = False And MyButton(110).Checked = False And MyButton(111).Checked = False And MyButton(112).Checked = False And MyButton(113).Checked = False And MyButton(123).Checked = False Then
                    b = 1
                End If

                If MyButton(109).Checked = False And MyButton(110).Checked = False And MyButton(111).Checked = False Then
                    pac = 1
                End If

                If MyButton(122).Checked = True Or MyButton(123).Checked = True Or MyButton(111).Checked = True Or MyButton(112).Checked = True Or MyButton(113).Checked = True Or MyButton(127).Checked = True Or _
                     MyButton(128).Checked = True Or MyButton(129).Checked = True Or MyButton(131).Checked = True Or MyButton(132).Checked = True Or MyButton(130).Checked = True Or MyButton(133).Checked = True Then
                    g = 1
                End If

                If MyButton(127).Checked = False And MyButton(128).Checked = False And MyButton(129).Checked = False And MyButton(130).Checked = False And MyButton(131).Checked = False And MyButton(132).Checked = False And MyButton(133).Checked = False Then
                    j = 1
                End If



                MyButton(i).Checked = False
                NumericUpDown1.Value = 1

            End If
        Next

        If MyButton(138).Checked = True Then
            d = 1
            a = 1
            MyButton(138).Checked = False
            NumericUpDown1.Value = 1
        End If


        If MyButton(125).Checked = True Then
            f = 1
            c = 1
            If b = 1 Then
                potatoSize = "Ｌ"
                drinkSize = "Ｌ"
                price += 60
            End If
            MyButton(125).Checked = False
            NumericUpDown1.Value = 1
        End If



        If MyButton(126).Checked = True Then
            f = 1
            c = 1
            If b = 1 Then
                potato = "サラダ"
                potatoSize = ""
                drinkSize = "Ｌ"
                price += 60
            End If
            MyButton(126).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(127).Checked = True Then
            drink = "カフェラテ"
            drinkSize = "Ｍ（ホット）"
            price += 60
            MyButton(127).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(131).Checked = True Then
            drink = "カフェラテ"
            drinkSize = "Ｍ（アイス）"
            price += 60
            MyButton(131).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(128).Checked = True Then
            drink = "カプチーノ"
            drinkSize = "Ｍ（ホット）"
            price += 60
            MyButton(128).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(129).Checked = True Then
            drink = "カフェモカ"
            drinkSize = "Ｍ（ホット）"
            price += 90
            MyButton(129).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(132).Checked = True Then
            drink = "カフェモカ"
            drinkSize = "Ｍ（アイス）"
            price += 90
            MyButton(132).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(130).Checked = True Then
            drink = "キャラメルラテ"
            drinkSize = "Ｍ（ホット）"
            price += 90
            MyButton(130).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(133).Checked = True Then
            drink = "キャラメルラテ"
            drinkSize = "Ｍ（アイス）"
            price += 90
            MyButton(133).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(135).Checked = True Then
            If c = 0 Then
                potato = "サラダ"
                potatoSize = ""
                price += 40
            End If
            MyButton(135).Checked = False
            NumericUpDown1.Value = 1
        End If
        If MyButton(136).Checked = True Then
            If g = 1 Then
                potatoSize = "Ｌ"
                price += 40
            End If
            MyButton(136).Checked = False
            NumericUpDown1.Value = 1
        End If

        For i As Integer = 94 To 106

            If MyButton(i).Checked = True And a = 1 And (d <> 1 Or f <> 1) And pac = 1 Then
                food = shouhinmei4()
                購入リスト.Items.Add(food & "/" & drink & drinkSize & "/" & potato & potatoSize & "/" & "   " & num & "  " & "￥" & price)
                NumericUpDown1.Value = 1
            End If

            If MyButton(i).Checked = True And a = 1 And (d <> 1 Or f <> 1) And pac = 0 And j = 1 Then
                food = shouhinmei4()
                購入リスト.Items.Add(food & "/" & drink & "/" & potato & potatoSize & "/" & "   " & num & "  " & "￥" & price)
                NumericUpDown1.Value = 1
            End If

            If MyButton(i).Checked = True And a = 1 And (d <> 1 Or f <> 1) And pac = 0 And j = 0 Then
                food = shouhinmei4()
                購入リスト.Items.Add(food & "/" & drink & drinkSize & "/" & potato & potatoSize & "/" & "   " & num & "  " & "￥" & price)
                NumericUpDown1.Value = 1
            End If
            MyButton(i).Checked = False
        Next


        If MyButton(14).Checked = True Then
            MyButton(14).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(33).Checked = True Then
            MyButton(33).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(93).Checked = True Then
            MyButton(93).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(107).Checked = True Then
            MyButton(107).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(124).Checked = True Then
            MyButton(124).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(134).Checked = True Then
            MyButton(134).Checked = False
            NumericUpDown1.Value = 1
        End If

        If MyButton(137).Checked = True Then
            MyButton(137).Checked = False
            NumericUpDown1.Value = 1
        End If

        NumericUpDown1.Value = 1
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num As Integer = NumericUpDown1.Value
        Dim selectedItemNum As Integer = 購入リスト.SelectedIndex
        If selectedItemNum <> -1 Then
            Dim selectedItem As String = 購入リスト.Text
            Dim mozisuu As Integer = Len(selectedItem)
            Dim position1 As Integer = selectedItem.IndexOf("  ") + 1
            Dim position2 As Integer = selectedItem.IndexOf("￥") + 1
            Dim kosuu As Integer = Mid(selectedItem, position1 + 1, (position2 - 1) - position1 + 1)
            Dim price As Integer = Mid(selectedItem, position2 + 1, (mozisuu + 1) - (position2 + 1))
            Dim priceOf1 As Integer = price / kosuu
            Dim shouhin As String = Mid(selectedItem, 1, position1 - 1)
            kosuu = kosuu - num
            price = priceOf1 * kosuu
            購入リスト.Items.Remove(selectedItem)
            購入リスト.Items.Insert(selectedItemNum, shouhin & "    " & kosuu & "   " & "￥" & price)

            If kosuu <= 0 Then
                購入リスト.Items.RemoveAt(selectedItemNum)
            End If

            NumericUpDown1.Value = 1
        End If
        NumericUpDown1.Value = 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If IsNumeric(TextBox2.Text) = False Then
            MessageBox.Show("半角の数字でお願いします。", _
                               "エラー", _
                               MessageBoxButtons.OK, _
                               MessageBoxIcon.Error)

        ElseIf Label2.Text = "合計金額" Then
            Label2.Text = 0

        ElseIf Not TextBox2.Text = "" Then


            Dim oturi As Integer = TextBox2.Text - Label2.Text
            If oturi > 0 Then
                MessageBox.Show("ありがとうございました！おつりは" & oturi & "円です。", _
                "会計", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Asterisk)

                購入リスト.Items.Clear()
                Label2.Text = "合計金額"
                TextBox2.Text = ""
            End If

            If oturi = 0 Then
                MessageBox.Show("ありがとうございました！ちょうどお預かりします。", _
                "会計", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Asterisk)
                購入リスト.Items.Clear()
                Label2.Text = "合計金額"
                TextBox2.Text = ""
            End If

            If oturi < 0 Then
                MessageBox.Show(-oturi & "円足りません。", _
                                "警告", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        購入リスト.Items.Clear()
    End Sub

End Class
