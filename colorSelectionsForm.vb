Imports System.ComponentModel
Imports Photoshop

Public Class colorSelectionsForm

    Private Const NUMBER_OF_AVAILABLE_COLORS As Integer = 57

    Private colors As New ArrayList()
    Private haveColorsBeenInitialized As Boolean = False

    Public Sub GetSelectedColors(ByRef arrayListToCopyTo As ArrayList)

        arrayListToCopyTo.Clear()

        For curIndex As Integer = 0 To colors.Count - 1

            Dim curColor As colorSelector = colors.Item(curIndex)

            If curColor.GetIsSelected() = True Then

                arrayListToCopyTo.Add(curColor)

            End If

        Next

    End Sub

    Private Sub colorSelectionsForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If haveColorsBeenInitialized = False Then

            For curIndex As Integer = 0 To NUMBER_OF_AVAILABLE_COLORS - 1

                Dim newColor As New colorSelector
                colors.Add(newColor)
            Next

            InitializeColorSelectors()

            haveColorsBeenInitialized = True

        End If

    End Sub

    Private Sub SetUpColorSelector(ByVal colorIndex As Integer, ByVal colorName As String, ByRef associatedPictureBox As PictureBox)

        Dim color As colorSelector = colors.Item(colorIndex)
        color.SetAssociatedPictureBox(associatedPictureBox)
        color.SetColorName(colorName)
        color.SetAsNotSelected()

    End Sub

    Private Sub InitializeColorSelectors()

        SetUpColorSelector(0, "heather_navy", colorPixBox0) ', 75, 80, 89, 97, 116, 126)
        SetUpColorSelector(1, "dark_heather", colorPixBox1) ', 93, 93, 93, 99, 111, 117)
        SetUpColorSelector(2, "heather_indigo", colorPixBox2) ', 105, 113, 125, 114, 120, 144)
        SetUpColorSelector(3, "stone_blue", colorPixBox3) ', 128, 144, 160, 137, 155, 173)
        SetUpColorSelector(4, "navy_blue", colorPixBox4) ', 33, 33, 49, 57, 68, 84)
        SetUpColorSelector(5, "aquatic_blue", colorPixBox5) ', 82, 180, 218, 82, 180, 218)
        SetUpColorSelector(6, "indigo_blue", colorPixBox6) ', 65, 75, 95, 134, 154, 175)
        SetUpColorSelector(7, "carolina_blue", colorPixBox7) ', 123, 148, 205, 127, 160, 206)
        SetUpColorSelector(8, "iris", colorPixBox8) ', 84, 118, 171, 94, 132, 191)
        SetUpColorSelector(9, "violet", colorPixBox9) ', 160, 153, 193, 145, 151, 195)
        SetUpColorSelector(10, "lt_blue", colorPixBox10) ', 196, 213, 230, 210, 232, 244)
        SetUpColorSelector(11, "heather_military", colorPixBox11) ', 115, 119, 99, 143, 156, 123)
        SetUpColorSelector(12, "stonewashed_green", colorPixBox12) ', 173, 181, 159, 205, 217, 185)
        SetUpColorSelector(13, "military_green", colorPixBox13) ', 89, 92, 59, 73, 91, 62)
        SetUpColorSelector(14, "forest_green", colorPixBox14) ', 13, 52, 21, 2, 30, 8)
        SetUpColorSelector(15, "pistachio", colorPixBox15) ', 191, 212, 119, 212, 231, 147)
        SetUpColorSelector(16, "royal_blue", colorPixBox16) ', 19, 71, 133, 63, 89, 156)
        SetUpColorSelector(17, "purple", colorPixBox17) ', 61, 31, 85, 80, 61, 102)
        SetUpColorSelector(18, "jade_dome", colorPixBox18) ', 0, 127, 105, 3, 169, 160)
        SetUpColorSelector(19, "cobalt", colorPixBox19) ', 46, 53, 103, 57, 63, 111)
        SetUpColorSelector(20, "sapphire", colorPixBox20) ', 0, 116, 157, 5, 120, 179)
        SetUpColorSelector(21, "blue_dusk", colorPixBox21) ', 45, 58, 75, 55, 77, 91)
        SetUpColorSelector(22, "cardinal_red", colorPixBox22) ', 149, 41, 47, 155, 55, 59)
        SetUpColorSelector(23, "red", colorPixBox23) ', 240, 65, 48, 240, 65, 48)
        SetUpColorSelector(24, "heather_red", colorPixBox24) ', 194, 98, 95, 227, 108, 102)
        SetUpColorSelector(25, "heather_cardinal", colorPixBox25) ', 155, 77, 82, 198, 105, 108)
        SetUpColorSelector(26, "heliconia", colorPixBox26) ', 231, 81, 130, 231, 81, 130)
        SetUpColorSelector(27, "lt_pink", colorPixBox27) ', 255, 204, 213, 255, 204, 213)
        SetUpColorSelector(28, "lavender", colorPixBox28) ', 230, 211, 228, 218, 202, 235)
        SetUpColorSelector(29, "orchid", colorPixBox29) ', 215, 185, 209, 241, 202, 229)
        SetUpColorSelector(30, "garnet", colorPixBox30) ', 85, 25, 37, 85, 25, 37)
        SetUpColorSelector(31, "maroon", colorPixBox31) ', 79, 25, 31, 75, 11, 42)
        SetUpColorSelector(32, "metro_blue", colorPixBox32) ', 57, 65, 109, 65, 71, 109)
        SetUpColorSelector(33, "sandy", colorPixBox33) ', 182, 152, 107, 206, 189, 155)
        SetUpColorSelector(34, "prairie_dust", colorPixBox34) ', 150, 122, 86, 157, 149, 123)
        SetUpColorSelector(35, "natural", colorPixBox35) ', 252, 251, 235, 252, 251, 235)
        SetUpColorSelector(36, "dark_chocolate", colorPixBox36) ', 46, 27, 7, 35, 21, 6)
        SetUpColorSelector(37, "sand", colorPixBox37) ', 224, 210, 188, 228, 218, 201)
        SetUpColorSelector(38, "brown_savana", colorPixBox38) ', 123, 107, 92, 130, 121, 104)
        SetUpColorSelector(39, "chestnut", colorPixBox39) ', 136, 93, 67, 141, 116, 103)
        SetUpColorSelector(40, "heather_dark_chocolate", colorPixBox40) ', 117, 94, 83, 117, 94, 83)
        SetUpColorSelector(41, "irish_green", colorPixBox41) ', 62, 149, 49, 82, 202, 84)
        SetUpColorSelector(42, "heather_forest", colorPixBox42) ', 111, 126, 114, 111, 126, 114)
        SetUpColorSelector(43, "antique_jade_dome", colorPixBox43) ', 31, 114, 118, 31, 114, 118)
        SetUpColorSelector(44, "charcoal", colorPixBox44) ', 86, 82, 82, 97, 102, 98)
        SetUpColorSelector(45, "sports_grey", colorPixBox45) ', 204, 204, 204, 204, 204, 204)
        SetUpColorSelector(46, "kiwi", colorPixBox46) ', 155, 168, 72, 173, 188, 80)
        SetUpColorSelector(47, "antique_sapphire", colorPixBox47) ', 22, 99, 129, 40, 130, 175)
        SetUpColorSelector(48, "graphite_heather", colorPixBox48) ', 135, 135, 135, 169, 168, 168)
        SetUpColorSelector(49, "blackberry", colorPixBox49) ', 59, 49, 74, 63, 56, 73)
        SetUpColorSelector(50, "midnight", colorPixBox50) ', 25, 39, 51, 25, 39, 51)
        SetUpColorSelector(51, "honey", colorPixBox51) ', 250, 194, 84, 255, 217, 141)
        SetUpColorSelector(52, "daffodil", colorPixBox52) ', 254, 232, 154, 254, 232, 154)
        SetUpColorSelector(53, "daisy", colorPixBox53) ', 255, 224, 96, 253, 221, 3)
        SetUpColorSelector(54, "texas_orange", colorPixBox54) ', 181, 83, 16, 213, 128, 48)
        SetUpColorSelector(55, "antique_orange", colorPixBox55) ', 179, 54, 11, 206, 74, 27)
        SetUpColorSelector(56, "antique_cherry", colorPixBox56) ', 122, 25, 27, 109, 3, 3)

    End Sub

    Private Sub colorPixBox0_Click(sender As Object, e As EventArgs) Handles colorPixBox0.Click

        Dim box As colorSelector = colors.Item(0)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox1_Click(sender As Object, e As EventArgs) Handles colorPixBox1.Click

        Dim box As colorSelector = colors.Item(1)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox2_Click(sender As Object, e As EventArgs) Handles colorPixBox2.Click

        Dim box As colorSelector = colors.Item(2)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox3_Click_1(sender As Object, e As EventArgs) Handles colorPixBox3.Click

        Dim box As colorSelector = colors.Item(3)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox4_Click_1(sender As Object, e As EventArgs) Handles colorPixBox4.Click

        Dim box As colorSelector = colors.Item(4)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox5_Click_1(sender As Object, e As EventArgs) Handles colorPixBox5.Click

        Dim box As colorSelector = colors.Item(5)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox6_Click_1(sender As Object, e As EventArgs) Handles colorPixBox6.Click

        Dim box As colorSelector = colors.Item(6)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox7_Click_1(sender As Object, e As EventArgs) Handles colorPixBox7.Click

        Dim box As colorSelector = colors.Item(7)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox8_Click_1(sender As Object, e As EventArgs) Handles colorPixBox8.Click

        Dim box As colorSelector = colors.Item(8)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox9_Click_1(sender As Object, e As EventArgs) Handles colorPixBox9.Click

        Dim box As colorSelector = colors.Item(9)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox10_Click_1(sender As Object, e As EventArgs) Handles colorPixBox10.Click

        Dim box As colorSelector = colors.Item(10)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox11_Click_1(sender As Object, e As EventArgs) Handles colorPixBox11.Click

        Dim box As colorSelector = colors.Item(11)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox12_Click_1(sender As Object, e As EventArgs) Handles colorPixBox12.Click

        Dim box As colorSelector = colors.Item(12)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox13_Click_1(sender As Object, e As EventArgs) Handles colorPixBox13.Click

        Dim box As colorSelector = colors.Item(13)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox14_Click_1(sender As Object, e As EventArgs) Handles colorPixBox14.Click

        Dim box As colorSelector = colors.Item(14)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox15_Click_1(sender As Object, e As EventArgs) Handles colorPixBox15.Click

        Dim box As colorSelector = colors.Item(15)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox16_Click_1(sender As Object, e As EventArgs) Handles colorPixBox16.Click

        Dim box As colorSelector = colors.Item(16)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox17_Click_1(sender As Object, e As EventArgs) Handles colorPixBox17.Click

        Dim box As colorSelector = colors.Item(17)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox18_Click_1(sender As Object, e As EventArgs) Handles colorPixBox18.Click

        Dim box As colorSelector = colors.Item(18)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox19_Click_1(sender As Object, e As EventArgs) Handles colorPixBox19.Click

        Dim box As colorSelector = colors.Item(19)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox20_Click_1(sender As Object, e As EventArgs) Handles colorPixBox20.Click

        Dim box As colorSelector = colors.Item(20)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox21_Click_1(sender As Object, e As EventArgs) Handles colorPixBox21.Click

        Dim box As colorSelector = colors.Item(21)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox22_Click_1(sender As Object, e As EventArgs) Handles colorPixBox22.Click

        Dim box As colorSelector = colors.Item(22)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox23_Click_1(sender As Object, e As EventArgs) Handles colorPixBox23.Click

        Dim box As colorSelector = colors.Item(23)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox24_Click_1(sender As Object, e As EventArgs) Handles colorPixBox24.Click

        Dim box As colorSelector = colors.Item(24)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox25_Click_1(sender As Object, e As EventArgs) Handles colorPixBox25.Click

        Dim box As colorSelector = colors.Item(25)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox26_Click_1(sender As Object, e As EventArgs) Handles colorPixBox26.Click

        Dim box As colorSelector = colors.Item(26)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox27_Click_1(sender As Object, e As EventArgs) Handles colorPixBox27.Click

        Dim box As colorSelector = colors.Item(27)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox28_Click_1(sender As Object, e As EventArgs) Handles colorPixBox28.Click

        Dim box As colorSelector = colors.Item(28)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox29_Click_1(sender As Object, e As EventArgs) Handles colorPixBox29.Click

        Dim box As colorSelector = colors.Item(29)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox30_Click_1(sender As Object, e As EventArgs) Handles colorPixBox30.Click
        Dim box As colorSelector = colors.Item(30)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox31_Click_1(sender As Object, e As EventArgs) Handles colorPixBox31.Click

        Dim box As colorSelector = colors.Item(31)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox32_Click_1(sender As Object, e As EventArgs) Handles colorPixBox32.Click

        Dim box As colorSelector = colors.Item(32)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox33_Click_1(sender As Object, e As EventArgs) Handles colorPixBox33.Click

        Dim box As colorSelector = colors.Item(33)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox34_Click_1(sender As Object, e As EventArgs) Handles colorPixBox34.Click

        Dim box As colorSelector = colors.Item(34)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox35_Click_1(sender As Object, e As EventArgs) Handles colorPixBox35.Click

        Dim box As colorSelector = colors.Item(35)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox36_Click_1(sender As Object, e As EventArgs) Handles colorPixBox36.Click

        Dim box As colorSelector = colors.Item(36)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox37_Click_1(sender As Object, e As EventArgs) Handles colorPixBox37.Click

        Dim box As colorSelector = colors.Item(37)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox38_Click_1(sender As Object, e As EventArgs) Handles colorPixBox38.Click

        Dim box As colorSelector = colors.Item(38)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox39_Click_1(sender As Object, e As EventArgs) Handles colorPixBox39.Click

        Dim box As colorSelector = colors.Item(39)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox40_Click_1(sender As Object, e As EventArgs) Handles colorPixBox40.Click

        Dim box As colorSelector = colors.Item(40)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox41_Click_1(sender As Object, e As EventArgs) Handles colorPixBox41.Click

        Dim box As colorSelector = colors.Item(41)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox42_Click_1(sender As Object, e As EventArgs) Handles colorPixBox42.Click

        Dim box As colorSelector = colors.Item(42)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox43_Click_1(sender As Object, e As EventArgs) Handles colorPixBox43.Click

        Dim box As colorSelector = colors.Item(43)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox44_Click_1(sender As Object, e As EventArgs) Handles colorPixBox44.Click

        Dim box As colorSelector = colors.Item(44)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox45_Click_1(sender As Object, e As EventArgs) Handles colorPixBox45.Click

        Dim box As colorSelector = colors.Item(45)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox46_Click_1(sender As Object, e As EventArgs) Handles colorPixBox46.Click

        Dim box As colorSelector = colors.Item(46)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox47_Click_1(sender As Object, e As EventArgs) Handles colorPixBox47.Click

        Dim box As colorSelector = colors.Item(47)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox48_Click_1(sender As Object, e As EventArgs) Handles colorPixBox48.Click

        Dim box As colorSelector = colors.Item(48)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox49_Click_1(sender As Object, e As EventArgs) Handles colorPixBox49.Click

        Dim box As colorSelector = colors.Item(49)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox50_Click_1(sender As Object, e As EventArgs) Handles colorPixBox50.Click

        Dim box As colorSelector = colors.Item(50)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox51_Click_1(sender As Object, e As EventArgs) Handles colorPixBox51.Click

        Dim box As colorSelector = colors.Item(51)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox52_Click_1(sender As Object, e As EventArgs) Handles colorPixBox52.Click

        Dim box As colorSelector = colors.Item(52)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox53_Click_1(sender As Object, e As EventArgs) Handles colorPixBox53.Click

        Dim box As colorSelector = colors.Item(53)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox54_Click_1(sender As Object, e As EventArgs) Handles colorPixBox54.Click

        Dim box As colorSelector = colors.Item(54)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox55_Click_1(sender As Object, e As EventArgs) Handles colorPixBox55.Click

        Dim box As colorSelector = colors.Item(55)
        box.ToggleSelectState()

    End Sub

    Private Sub colorPixBox56_Click_1(sender As Object, e As EventArgs) Handles colorPixBox56.Click

        Dim box As colorSelector = colors.Item(56)
        box.ToggleSelectState()

    End Sub

    Private Sub doneBtn_Click(sender As Object, e As EventArgs) Handles doneBtn.Click

        Dim selectedColors As New ArrayList
        GetSelectedColors(selectedColors)
        Form1.UpdateSelectedColors(selectedColors)

        colorSelectionsForm.ActiveForm.Hide()

    End Sub

End Class