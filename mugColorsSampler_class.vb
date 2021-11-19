Imports Photoshop

Public Class mugColorsSampler_class

    Private Const HEATHER_NAVY_PROOF_X As Double = 163.0
    Private Const HEATHER_NAVY_PROOF_Y As Double = 210.0
    Private Const HEATHER_NAVY_PRINT_X As Double = 383.0
    Private Const HEATHER_NAVY_PRINT_Y As Double = 210.0
    Private Const DARK_HEATHER_PROOF_X As Double = 171.0
    Private Const DARK_HEATHER_PROOF_Y As Double = 514.0
    Private Const DARK_HEATHER_PRINT_X As Double = 367.0
    Private Const DARK_HEATHER_PRINT_Y As Double = 502.0
    Private Const HEATHER_INDIGO_PROOF_X As Double = 171.0
    Private Const HEATHER_INDIGO_PROOF_Y As Double = 802.0
    Private Const HEATHER_INDIGO_PRINT_X As Double = 375.0
    Private Const HEATHER_INDIGO_PRINT_Y As Double = 786.0
    Private Const STONE_BLUE_PROOF_X As Double = 155.0
    Private Const STONE_BLUE_PROOF_Y As Double = 1066.0
    Private Const STONE_BLUE_PRINT_X As Double = 383.0
    Private Const STONE_BLUE_PRINT_Y As Double = 1058.0
    Private Const NAVY_BLUE_PROOF_X As Double = 171.0
    Private Const NAVY_BLUE_PROOF_Y As Double = 1358.0
    Private Const NAVY_BLUE_PRINT_X As Double = 395.0
    Private Const NAVY_BLUE_PRINT_Y As Double = 1350.0
    Private Const AQUATIC_BLUE_PROOF_X As Double = 147.0
    Private Const AQUATIC_BLUE_PROOF_Y As Double = 1594.0
    Private Const AQUATIC_BLUE_PRINT_X As Double = 371.0
    Private Const AQUATIC_BLUE_PRINT_Y As Double = 1606.0
    Private Const INDIGO_BLUE_PROOF_X As Double = 131.0
    Private Const INDIGO_BLUE_PROOF_Y As Double = 1906.0
    Private Const INDIGO_BLUE_PRINT_X As Double = 387.0
    Private Const INDIGO_BLUE_PRINT_Y As Double = 1882.0
    Private Const CAROLINA_BLUE_PROOF_X As Double = 143.0
    Private Const CAROLINA_BLUE_PROOF_Y As Double = 2190.0
    Private Const CAROLINA_BLUE_PRINT_X As Double = 399.0
    Private Const CAROLINA_BLUE_PRINT_Y As Double = 2198.0
    Private Const IRIS_PROOF_X As Double = 143.0
    Private Const IRIS_PROOF_Y As Double = 2482.0
    Private Const IRIS_PRINT_X As Double = 395.0
    Private Const IRIS_PRINT_Y As Double = 2458.0
    Private Const VIOLET_PROOF_X As Double = 171.0
    Private Const VIOLET_PROOF_Y As Double = 2734.0
    Private Const VIOLET_PRINT_X As Double = 399.0
    Private Const VIOLET_PRINT_Y As Double = 2730.0
    Private Const LT_BLUE_PROOF_X As Double = 139.0
    Private Const LT_BLUE_PROOF_Y As Double = 2994.0
    Private Const LT_BLUE_PRINT_X As Double = 395.0
    Private Const LT_BLUE_PRINT_Y As Double = 3002.0
    Private Const HEATHER_MILITARY_PROOF_X As Double = 779.0
    Private Const HEATHER_MILITARY_PROOF_Y As Double = 202.0
    Private Const HEATHER_MILITARY_PRINT_X As Double = 1019.0
    Private Const HEATHER_MILITARY_PRINT_Y As Double = 214.0
    Private Const STONEWASHED_GREEN_PROOF_X As Double = 779.0
    Private Const STONEWASHED_GREEN_PROOF_Y As Double = 498.0
    Private Const STONEWASHED_GREEN_PRINT_X As Double = 1015.0
    Private Const STONEWASHED_GREEN_PRINT_Y As Double = 498.0
    Private Const MILITARY_GREEN_PROOF_X As Double = 787.0
    Private Const MILITARY_GREEN_PROOF_Y As Double = 798.0
    Private Const MILITARY_GREEN_PRINT_X As Double = 1003.0
    Private Const MILITARY_GREEN_PRINT_Y As Double = 794.0
    Private Const FOREST_GREEN_PROOF_X As Double = 767.0
    Private Const FOREST_GREEN_PROOF_Y As Double = 1082.0
    Private Const FOREST_GREEN_PRINT_X As Double = 1023.0
    Private Const FOREST_GREEN_PRINT_Y As Double = 1070.0
    Private Const PISTACHIO_PROOF_X As Double = 759.0
    Private Const PISTACHIO_PROOF_Y As Double = 1322.0
    Private Const PISTACHIO_PRINT_X As Double = 995.0
    Private Const PISTACHIO_PRINT_Y As Double = 1338.0
    Private Const ROYAL_BLUE_PROOF_X As Double = 759.0
    Private Const ROYAL_BLUE_PROOF_Y As Double = 1602.0
    Private Const ROYAL_BLUE_PRINT_X As Double = 1003.0
    Private Const ROYAL_BLUE_PRINT_Y As Double = 1602.0
    Private Const PURPLE_PROOF_X As Double = 783.0
    Private Const PURPLE_PROOF_Y As Double = 1882.0
    Private Const PURPLE_PRINT_X As Double = 999.0
    Private Const PURPLE_PRINT_Y As Double = 1914.0
    Private Const JADE_DOME_PROOF_X As Double = 783.0
    Private Const JADE_DOME_PROOF_Y As Double = 2190.0
    Private Const JADE_DOME_PRINT_X As Double = 995.0
    Private Const JADE_DOME_PRINT_Y As Double = 2202.0
    Private Const COBALT_PROOF_X As Double = 767.0
    Private Const COBALT_PROOF_Y As Double = 2478.0
    Private Const COBALT_PRINT_X As Double = 991.0
    Private Const COBALT_PRINT_Y As Double = 2494.0
    Private Const SAPPHIRE_PROOF_X As Double = 755.0
    Private Const SAPPHIRE_PROOF_Y As Double = 2766.0
    Private Const SAPPHIRE_PRINT_X As Double = 995.0
    Private Const SAPPHIRE_PRINT_Y As Double = 2742.0
    Private Const BLUE_DUSK_PROOF_X As Double = 775.0
    Private Const BLUE_DUSK_PROOF_Y As Double = 3030.0
    Private Const BLUE_DUSK_PRINT_X As Double = 1007.0
    Private Const BLUE_DUSK_PRINT_Y As Double = 3030.0
    Private Const CARDINAL_RED_PROOF_X As Double = 1399.0
    Private Const CARDINAL_RED_PROOF_Y As Double = 270.0
    Private Const CARDINAL_RED_PRINT_X As Double = 1631.0
    Private Const CARDINAL_RED_PRINT_Y As Double = 214.0
    Private Const RED_PROOF_X As Double = 1403.0
    Private Const RED_PROOF_Y As Double = 502.0
    Private Const RED_PRINT_X As Double = 1659.0
    Private Const RED_PRINT_Y As Double = 490.0
    Private Const HEATHER_RED_PROOF_X As Double = 1427.0
    Private Const HEATHER_RED_PROOF_Y As Double = 782.0
    Private Const HEATHER_RED_PRINT_X As Double = 1635.0
    Private Const HEATHER_RED_PRINT_Y As Double = 786.0
    Private Const HEATHER_CARDINAL_PROOF_X As Double = 1439.0
    Private Const HEATHER_CARDINAL_PROOF_Y As Double = 1078.0
    Private Const HEATHER_CARDINAL_PRINT_X As Double = 1635.0
    Private Const HEATHER_CARDINAL_PRINT_Y As Double = 1098.0
    Private Const HELICONIA_PROOF_X As Double = 1383.0
    Private Const HELICONIA_PROOF_Y As Double = 1346.0
    Private Const HELICONIA_PRINT_X As Double = 1383.0
    Private Const HELICONIA_PRINT_Y As Double = 1346.0
    Private Const LT_PINK_PROOF_X As Double = 1423.0
    Private Const LT_PINK_PROOF_Y As Double = 1606.0
    Private Const LT_PINK_PRINT_X As Double = 1423.0
    Private Const LT_PINK_PRINT_Y As Double = 1606.0
    Private Const LAVENDER_PROOF_X As Double = 1399.0
    Private Const LAVENDER_PROOF_Y As Double = 1902.0
    Private Const LAVENDER_PRINT_X As Double = 1631.0
    Private Const LAVENDER_PRINT_Y As Double = 1886.0
    Private Const ORCHID_PROOF_X As Double = 1339.0
    Private Const ORCHID_PROOF_Y As Double = 2166.0
    Private Const ORCHID_PRINT_X As Double = 1659.0
    Private Const ORCHID_PRINT_Y As Double = 2190.0
    Private Const GARNET_PROOF_X As Double = 1411.0
    Private Const GARNET_PROOF_Y As Double = 2478.0
    Private Const GARNET_PRINT_X As Double = 1655.0
    Private Const GARNET_PRINT_Y As Double = 2490.0
    Private Const MAROON_PROOF_X As Double = 1415.0
    Private Const MAROON_PROOF_Y As Double = 2722.0
    Private Const MAROON_PRINT_X As Double = 1631.0
    Private Const MAROON_PRINT_Y As Double = 2742.0
    Private Const METRO_BLUE_PROOF_X As Double = 1439.0
    Private Const METRO_BLUE_PROOF_Y As Double = 3010.0
    Private Const METRO_BLUE_PRINT_X As Double = 1623.0
    Private Const METRO_BLUE_PRINT_Y As Double = 3026.0
    Private Const SANDY_PROOF_X As Double = 2063.0
    Private Const SANDY_PROOF_Y As Double = 230.0
    Private Const SANDY_PRINT_X As Double = 2294.0
    Private Const SANDY_PRINT_Y As Double = 214.0
    Private Const PRAIRIE_DUST_PROOF_X As Double = 2063.0
    Private Const PRAIRIE_DUST_PROOF_Y As Double = 482.0
    Private Const PRAIRIE_DUST_PRINT_X As Double = 2282.0
    Private Const PRAIRIE_DUST_PRINT_Y As Double = 486.0
    Private Const NATURAL_PROOF_X As Double = 2079.0
    Private Const NATURAL_PROOF_Y As Double = 786.0
    Private Const NATURAL_PRINT_X As Double = 2290.0
    Private Const NATURAL_PRINT_Y As Double = 762.0
    Private Const DARK_CHOCOLATE_PROOF_X As Double = 2071.0
    Private Const DARK_CHOCOLATE_PROOF_Y As Double = 1090.0
    Private Const DARK_CHOCOLATE_PRINT_X As Double = 2278.0
    Private Const DARK_CHOCOLATE_PRINT_Y As Double = 1110.0
    Private Const SAND_PROOF_X As Double = 2043.0
    Private Const SAND_PROOF_Y As Double = 1334.0
    Private Const SAND_PRINT_X As Double = 2302.0
    Private Const SAND_PRINT_Y As Double = 1330.0
    Private Const BROWN_SAVANA_PROOF_X As Double = 2087.0
    Private Const BROWN_SAVANA_PROOF_Y As Double = 1610.0
    Private Const BROWN_SAVANA_PRINT_X As Double = 2278.0
    Private Const BROWN_SAVANA_PRINT_Y As Double = 1626.0
    Private Const CHESTNUT_PROOF_X As Double = 2107.0
    Private Const CHESTNUT_PROOF_Y As Double = 1898.0
    Private Const CHESTNUT_PRINT_X As Double = 2326.0
    Private Const CHESTNUT_PRINT_Y As Double = 1906.0
    Private Const HEATHER_DARK_CHOCOLATE_PROOF_X As Double = 2091.0
    Private Const HEATHER_DARK_CHOCOLATE_PROOF_Y As Double = 2174.0
    Private Const HEATHER_DARK_CHOCOLATE_PRINT_X As Double = 2091.0
    Private Const HEATHER_DARK_CHOCOLATE_PRINT_Y As Double = 2174.0
    Private Const IRISH_GREEN_PROOF_X As Double = 2087.0
    Private Const IRISH_GREEN_PROOF_Y As Double = 2478.0
    Private Const IRISH_GREEN_PRINT_X As Double = 2294.0
    Private Const IRISH_GREEN_PRINT_Y As Double = 2474.0
    Private Const HEATHER_FOREST_PROOF_X As Double = 2091.0
    Private Const HEATHER_FOREST_PROOF_Y As Double = 2750.0
    Private Const HEATHER_FOREST_PRINT_X As Double = 2259.0
    Private Const HEATHER_FOREST_PRINT_Y As Double = 2778.0
    Private Const ANTIQUE_JADE_DOME_PROOF_X As Double = 2103.0
    Private Const ANTIQUE_JADE_DOME_PROOF_Y As Double = 3018.0
    Private Const ANTIQUE_JADE_DOME_PRINT_X As Double = 2331.0
    Private Const ANTIQUE_JADE_DOME_PRINT_Y As Double = 3015.0
    Private Const CHARCOAL_PROOF_X As Double = 2719.0
    Private Const CHARCOAL_PROOF_Y As Double = 215.0
    Private Const CHARCOAL_PRINT_X As Double = 2919.0
    Private Const CHARCOAL_PRINT_Y As Double = 231.0
    Private Const SPORTS_GREY_PROOF_X As Double = 2695.0
    Private Const SPORTS_GREY_PROOF_Y As Double = 479.0
    Private Const SPORTS_GREY_PRINT_X As Double = 2951.0
    Private Const SPORTS_GREY_PRINT_Y As Double = 491.0
    Private Const KIWI_PROOF_X As Double = 2699.0
    Private Const KIWI_PROOF_Y As Double = 795.0
    Private Const KIWI_PRINT_X As Double = 2927.0
    Private Const KIWI_PRINT_Y As Double = 811.0
    Private Const ANTIQUE_SAPPHIRE_PROOF_X As Double = 2719.0
    Private Const ANTIQUE_SAPPHIRE_PROOF_Y As Double = 1071.0
    Private Const ANTIQUE_SAPPHIRE_PRINT_X As Double = 2931.0
    Private Const ANTIQUE_SAPPHIRE_PRINT_Y As Double = 1071.0
    Private Const GRAPHITE_HEATHER_PROOF_X As Double = 2719.0
    Private Const GRAPHITE_HEATHER_PROOF_Y As Double = 1347.0
    Private Const GRAPHITE_HEATHER_PRINT_X As Double = 2911.0
    Private Const GRAPHITE_HEATHER_PRINT_Y As Double = 1327.0
    Private Const BLACKBERRY_PROOF_X As Double = 2447.0
    Private Const BLACKBERRY_PROOF_Y As Double = 1899.0
    Private Const BLACKBERRY_PRINT_X As Double = 2947.0
    Private Const BLACKBERRY_PRINT_Y As Double = 1883.0
    Private Const MIDNIGHT_PROOF_X As Double = 2731.0
    Private Const MIDNIGHT_PROOF_Y As Double = 2151.0
    Private Const MIDNIGHT_PRINT_X As Double = 2959.0
    Private Const MIDNIGHT_PRINT_Y As Double = 2167.0
    Private Const HONEY_PROOF_X As Double = 3346.0
    Private Const HONEY_PROOF_Y As Double = 207.0
    Private Const HONEY_PRINT_X As Double = 3538.0
    Private Const HONEY_PRINT_Y As Double = 223.0
    Private Const DAFFODIL_PROOF_X As Double = 3343.0
    Private Const DAFFODIL_PROOF_Y As Double = 479.0
    Private Const DAFFODIL_PRINT_X As Double = 3343.0
    Private Const DAFFODIL_PRINT_Y As Double = 479.0
    Private Const DAISY_PROOF_X As Double = 3358.0
    Private Const DAISY_PROOF_Y As Double = 799.0
    Private Const DAISY_PRINT_X As Double = 3562.0
    Private Const DAISY_PRINT_Y As Double = 803.0
    Private Const TEXAS_ORANGE_PROOF_X As Double = 3374.0
    Private Const TEXAS_ORANGE_PROOF_Y As Double = 1091.0
    Private Const TEXAS_ORANGE_PRINT_X As Double = 3566.0
    Private Const TEXAS_ORANGE_PRINT_Y As Double = 1075.0
    Private Const ANTIQUE_ORANGE_PRINT_X As Double = 3366.0
    Private Const ANTIQUE_ORANGE_PRINT_Y As Double = 1391.0
    Private Const ANTIQUE_ORANGE_PROOF_X As Double = 3554.0
    Private Const ANTIQUE_ORANGE_PROOF_Y As Double = 1379.0
    Private Const ANTIQUE_CHERRY_PRINT_X As Double = 3554.0
    Private Const ANTIQUE_CHERRY_PRINT_Y As Double = 1647.0
    Private Const ANTIQUE_CHERRY_PROOF_X As Double = 3558.0
    Private Const ANTIQUE_CHERRY_PROOF_Y As Double = 1659.0
    Private Const ORANGE_PRINT_X As Double = 3346.0
    Private Const ORANGE_PRINT_Y As Double = 1927.0
    Private Const ORANGE_PROOF_X As Double = 3566.0
    Private Const ORANGE_PROOF_Y As Double = 1927.0

    'PUBLIC METHODS****************************************************************************************************

    Public Function GetRGBColorFromShirtColors_NEWFile(ByRef app As Application, ByVal MugColor As String) As RGBColor

        Dim previousUnitPreference As PsUnits = app.Preferences.RulerUnits
        app.Preferences.RulerUnits = PsUnits.psPixels
        Dim swatchDoc As Document = app.Open("\\ARTSERVER\Textile-Misc\Textile Files\In Progress & Ideas\MUGS\Shirt Colors_NEW.psd")

        app.ActiveDocument.ColorSamplers.RemoveAll()

        Dim position(1) As Object 'the array passed to colorsampler.add MUST be type 'Object' to avoid throwing an error!
        position(0) = GetColorSwatchXPosition(MugColor)
        position(1) = GetColorSwatchYPosition(MugColor)
        Dim pointSample As ColorSampler = app.ActiveDocument.ColorSamplers.Add(position)

        Dim finalRGB As New RGBColor
        finalRGB.Red = pointSample.Color.RGB.Red
        finalRGB.Green = pointSample.Color.RGB.Green
        finalRGB.Blue = pointSample.Color.RGB.Blue

        pointSample.Delete()

        app.Preferences.RulerUnits = previousUnitPreference 'restore previous ruler units preference
        swatchDoc.Close(PsSaveOptions.psDoNotSaveChanges)

        Return finalRGB

    End Function

    'PRIVATE METHODS***************************************************************************************************
    Private Function GetColorSwatchXPosition(ByVal mugColor As String) As Integer 'returns -1 if no matching color is found

        Dim xPos As Integer = -1

        Select Case mugColor

            Case "heather_navy_proof"

                xPos = HEATHER_NAVY_PROOF_X

            Case "heather_navy_print"

                xPos = HEATHER_NAVY_PRINT_X

            Case "dark_heather_proof"

                xPos = DARK_HEATHER_PROOF_X

            Case "dark_heather_print"

                xPos = DARK_HEATHER_PRINT_X

            Case "heather_indigo_proof"

                xPos = HEATHER_INDIGO_PROOF_X

            Case "heather_indigo_print"

                xPos = HEATHER_INDIGO_PRINT_X

            Case "stone_blue_proof"

                xPos = STONE_BLUE_PROOF_X

            Case "stone_blue_print"

                xPos = STONE_BLUE_PRINT_X

            Case "navy_blue_proof"

                xPos = NAVY_BLUE_PROOF_X

            Case "navy_blue_print"

                xPos = NAVY_BLUE_PRINT_X

            Case "aquatic_blue_proof"

                xPos = AQUATIC_BLUE_PROOF_X

            Case "aquatic_blue_print"

                xPos = AQUATIC_BLUE_PRINT_X

            Case "indigo_blue_proof"

                xPos = INDIGO_BLUE_PROOF_X

            Case "indigo_blue_print"

                xPos = INDIGO_BLUE_PRINT_X

            Case "carolina_blue_proof"

                xPos = CAROLINA_BLUE_PROOF_X

            Case "carolina_blue_print"

                xPos = CAROLINA_BLUE_PRINT_X

            Case "iris_proof"

                xPos = IRIS_PROOF_X

            Case "iris_print"

                xPos = IRIS_PRINT_X

            Case "violet_proof"

                xPos = VIOLET_PROOF_X

            Case "violet_print"

                xPos = VIOLET_PRINT_X

            Case "lt_blue_proof"

                xPos = LT_BLUE_PROOF_X

            Case "lt_blue_print"

                xPos = LT_BLUE_PRINT_X

            Case "heather_military_proof"

                xPos = HEATHER_MILITARY_PROOF_X

            Case "heather_military_print"

                xPos = HEATHER_MILITARY_PRINT_X

            Case "stonewashed_green_proof"

                xPos = STONEWASHED_GREEN_PROOF_X

            Case "stonewashed_green_print"

                xPos = STONEWASHED_GREEN_PRINT_X

            Case "military_green_proof"

                xPos = MILITARY_GREEN_PROOF_X

            Case "military_green_print"

                xPos = MILITARY_GREEN_PRINT_X

            Case "forest_green_proof"

                xPos = FOREST_GREEN_PROOF_X

            Case "forest_green_print"

                xPos = FOREST_GREEN_PRINT_X

            Case "pistachio_proof"

                xPos = PISTACHIO_PROOF_X

            Case "pistachio_print"

                xPos = PISTACHIO_PRINT_X

            Case "royal_blue_proof"

                xPos = ROYAL_BLUE_PROOF_X

            Case "royal_blue_print"

                xPos = ROYAL_BLUE_PRINT_X

            Case "purple_proof"

                xPos = PURPLE_PROOF_X

            Case "purple_print"

                xPos = PURPLE_PRINT_X

            Case "jade_dome_proof"

                xPos = JADE_DOME_PROOF_X

            Case "jade_dome_print"

                xPos = JADE_DOME_PRINT_X

            Case "cobalt_proof"

                xPos = COBALT_PROOF_X

            Case "cobalt_print"

                xPos = COBALT_PRINT_X

            Case "sapphire_proof"

                xPos = SAPPHIRE_PROOF_X

            Case "sapphire_print"

                xPos = SAPPHIRE_PRINT_X

            Case "blue_dusk_proof"

                xPos = BLUE_DUSK_PROOF_X

            Case "blue_dusk_print"

                xPos = BLUE_DUSK_PRINT_X

            Case "cardinal_red_proof"

                xPos = CARDINAL_RED_PROOF_X

            Case "cardinal_red_print"

                xPos = CARDINAL_RED_PRINT_X

            Case "red_proof"

                xPos = RED_PROOF_X

            Case "red_print"

                xPos = RED_PRINT_X

            Case "heather_red_proof"

                xPos = HEATHER_RED_PROOF_X

            Case "heather_red_print"

                xPos = HEATHER_RED_PRINT_X

            Case "heather_cardinal_proof"

                xPos = HEATHER_CARDINAL_PROOF_X

            Case "heather_cardinal_print"

                xPos = HEATHER_CARDINAL_PRINT_X

            Case "heliconia_proof"

                xPos = HELICONIA_PROOF_X

            Case "heliconia_print"

                xPos = HELICONIA_PRINT_X

            Case "lt_pink_proof"

                xPos = LT_PINK_PROOF_X

            Case "lt_pink_print"

                xPos = LT_PINK_PRINT_X

            Case "lavender_proof"

                xPos = LAVENDER_PROOF_X

            Case "lavender_print"

                xPos = LAVENDER_PRINT_X

            Case "orchid_proof"

                xPos = ORCHID_PROOF_X

            Case "orchid_print"

                xPos = ORCHID_PRINT_X

            Case "garnet_proof"

                xPos = GARNET_PROOF_X

            Case "garnet_print"

                xPos = GARNET_PRINT_X

            Case "maroon_proof"

                xPos = MAROON_PROOF_X

            Case "maroon_print"

                xPos = MAROON_PRINT_X

            Case "metro_blue_proof"

                xPos = METRO_BLUE_PROOF_X

            Case "metro_blue_print"

                xPos = METRO_BLUE_PRINT_X

            Case "sandy_proof"

                xPos = SANDY_PROOF_X

            Case "sandy_print"

                xPos = SANDY_PRINT_X

            Case "prairie_dust_proof"

                xPos = PRAIRIE_DUST_PROOF_X

            Case "prairie_dust_print"

                xPos = PRAIRIE_DUST_PRINT_X

            Case "natural_proof"

                xPos = NATURAL_PROOF_X

            Case "natural_print"

                xPos = NATURAL_PRINT_X

            Case "dark_chocolate_proof"

                xPos = DARK_CHOCOLATE_PROOF_X

            Case "dark_chocolate_print"

                xPos = DARK_CHOCOLATE_PRINT_X

            Case "sand_proof"

                xPos = SAND_PROOF_X

            Case "sand_print"

                xPos = SAND_PRINT_X

            Case "brown_savana_proof"

                xPos = BROWN_SAVANA_PROOF_X

            Case "brown_savana_print"

                xPos = BROWN_SAVANA_PRINT_X

            Case "chestnut_proof"

                xPos = CHESTNUT_PROOF_X

            Case "chestnut_print"

                xPos = CHESTNUT_PRINT_X

            Case "heather_dark_chocolate_proof"

                xPos = HEATHER_DARK_CHOCOLATE_PROOF_X

            Case "heather_dark_chocolate_print"

                xPos = HEATHER_DARK_CHOCOLATE_PRINT_X

            Case "irish_green_proof"

                xPos = IRISH_GREEN_PROOF_X

            Case "irish_green_print"

                xPos = IRISH_GREEN_PRINT_X

            Case "heather_forest_proof"

                xPos = HEATHER_FOREST_PROOF_X

            Case "heather_forest_print"

                xPos = HEATHER_FOREST_PRINT_X

            Case "antique_jade_dome_proof"

                xPos = ANTIQUE_JADE_DOME_PROOF_X

            Case "antique_jade_dome_print"

                xPos = ANTIQUE_JADE_DOME_PRINT_X

            Case "charcoal_proof"

                xPos = CHARCOAL_PROOF_X

            Case "charcoal_print"

                xPos = CHARCOAL_PRINT_X

            Case "sports_grey_proof"

                xPos = SPORTS_GREY_PROOF_X

            Case "sports_grey_print"

                xPos = SPORTS_GREY_PRINT_X

            Case "kiwi_proof"

                xPos = KIWI_PROOF_X

            Case "kiwi_print"

                xPos = KIWI_PRINT_X

            Case "antique_sapphire_proof"

                xPos = ANTIQUE_SAPPHIRE_PROOF_X

            Case "antique_sapphire_print"

                xPos = ANTIQUE_SAPPHIRE_PRINT_X

            Case "graphite_heather_proof"

                xPos = GRAPHITE_HEATHER_PROOF_X

            Case "graphite_heather_print"

                xPos = GRAPHITE_HEATHER_PRINT_X

            Case "blackberry_proof"

                xPos = BLACKBERRY_PROOF_X

            Case "blackberry_print"

                xPos = BLACKBERRY_PRINT_X

            Case "midnight_proof"

                xPos = MIDNIGHT_PROOF_X

            Case "midnight_print"

                xPos = MIDNIGHT_PRINT_X

            Case "honey_proof"

                xPos = HONEY_PROOF_X

            Case "honey_print"

                xPos = HONEY_PRINT_X

            Case "daffodil_proof"

                xPos = DAFFODIL_PROOF_X

            Case "daffodil_print"

                xPos = DAFFODIL_PRINT_X

            Case "daisy_proof"

                xPos = DAISY_PROOF_X

            Case "daisy_print"

                xPos = DAISY_PRINT_X

            Case "texas_orange_proof"

                xPos = TEXAS_ORANGE_PROOF_X

            Case "texas_orange_print"

                xPos = TEXAS_ORANGE_PRINT_X

            Case "antique_orange_print"

                xPos = ANTIQUE_ORANGE_PRINT_X

            Case "antique_orange_proof"

                xPos = ANTIQUE_ORANGE_PROOF_X

            Case "antique_cherry_print"

                xPos = ANTIQUE_CHERRY_PRINT_X

            Case "antique_cherry_proof"

                xPos = ANTIQUE_CHERRY_PROOF_X

            Case "orange_print"

                xPos = ORANGE_PRINT_X

            Case "orange_proof"

                xPos = ORANGE_PROOF_X

            Case Else

                xPos = -1

        End Select

        Return xPos

    End Function

    Private Function GetColorSwatchYPosition(ByVal mugColor As String) As Integer 'returns -1 if no matching color is found

        Dim yPos As Integer = -1

        Select Case mugColor

            Case "heather_navy_proof"

                yPos = HEATHER_NAVY_PROOF_Y

            Case "heather_navy_print"

                yPos = HEATHER_NAVY_PRINT_Y

            Case "dark_heather_proof"

                yPos = DARK_HEATHER_PROOF_Y

            Case "dark_heather_print"

                yPos = DARK_HEATHER_PRINT_Y

            Case "heather_indigo_proof"

                yPos = HEATHER_INDIGO_PROOF_Y

            Case "heather_indigo_print"

                yPos = HEATHER_INDIGO_PRINT_Y

            Case "stone_blue_proof"

                yPos = STONE_BLUE_PROOF_Y

            Case "stone_blue_print"

                yPos = STONE_BLUE_PRINT_Y

            Case "navy_blue_proof"

                yPos = NAVY_BLUE_PROOF_Y

            Case "navy_blue_print"

                yPos = NAVY_BLUE_PRINT_Y

            Case "aquatic_blue_proof"

                yPos = AQUATIC_BLUE_PROOF_Y

            Case "aquatic_blue_print"

                yPos = AQUATIC_BLUE_PRINT_Y

            Case "indigo_blue_proof"

                yPos = INDIGO_BLUE_PROOF_Y

            Case "indigo_blue_print"

                yPos = INDIGO_BLUE_PRINT_Y

            Case "carolina_blue_proof"

                yPos = CAROLINA_BLUE_PROOF_Y

            Case "carolina_blue_print"

                yPos = CAROLINA_BLUE_PRINT_Y

            Case "iris_proof"

                yPos = IRIS_PROOF_Y

            Case "iris_print"

                yPos = IRIS_PRINT_Y

            Case "violet_proof"

                yPos = VIOLET_PROOF_Y

            Case "violet_print"

                yPos = VIOLET_PRINT_Y

            Case "lt_blue_proof"

                yPos = LT_BLUE_PROOF_Y

            Case "lt_blue_print"

                yPos = LT_BLUE_PRINT_Y

            Case "heather_military_proof"

                yPos = HEATHER_MILITARY_PROOF_Y

            Case "heather_military_print"

                yPos = HEATHER_MILITARY_PRINT_Y

            Case "stonewashed_green_proof"

                yPos = STONEWASHED_GREEN_PROOF_Y

            Case "stonewashed_green_print"

                yPos = STONEWASHED_GREEN_PRINT_Y

            Case "military_green_proof"

                yPos = MILITARY_GREEN_PROOF_Y

            Case "military_green_print"

                yPos = MILITARY_GREEN_PRINT_Y

            Case "forest_green_proof"

                yPos = FOREST_GREEN_PROOF_Y

            Case "forest_green_print"

                yPos = FOREST_GREEN_PRINT_Y

            Case "pistachio_proof"

                yPos = PISTACHIO_PROOF_Y

            Case "pistachio_print"

                yPos = PISTACHIO_PRINT_Y

            Case "royal_blue_proof"

                yPos = ROYAL_BLUE_PROOF_Y

            Case "royal_blue_print"

                yPos = ROYAL_BLUE_PRINT_Y

            Case "purple_proof"

                yPos = PURPLE_PROOF_Y

            Case "purple_print"

                yPos = PURPLE_PRINT_Y

            Case "jade_dome_proof"

                yPos = JADE_DOME_PROOF_Y

            Case "jade_dome_print"

                yPos = JADE_DOME_PRINT_Y

            Case "cobalt_proof"

                yPos = COBALT_PROOF_Y

            Case "cobalt_print"

                yPos = COBALT_PRINT_Y

            Case "sapphire_proof"

                yPos = SAPPHIRE_PROOF_Y

            Case "sapphire_print"

                yPos = SAPPHIRE_PRINT_Y

            Case "blue_dusk_proof"

                yPos = BLUE_DUSK_PROOF_Y

            Case "blue_dusk_print"

                yPos = BLUE_DUSK_PRINT_Y

            Case "cardinal_red_proof"

                yPos = CARDINAL_RED_PROOF_Y

            Case "cardinal_red_print"

                yPos = CARDINAL_RED_PRINT_Y

            Case "red_proof"

                yPos = RED_PROOF_Y

            Case "red_print"

                yPos = RED_PRINT_Y

            Case "heather_red_proof"

                yPos = HEATHER_RED_PROOF_Y

            Case "heather_red_print"

                yPos = HEATHER_RED_PRINT_Y

            Case "heather_cardinal_proof"

                yPos = HEATHER_CARDINAL_PROOF_Y

            Case "heather_cardinal_print"

                yPos = HEATHER_CARDINAL_PRINT_Y

            Case "heliconia_proof"

                yPos = HELICONIA_PROOF_Y

            Case "heliconia_print"

                yPos = HELICONIA_PRINT_Y

            Case "lt_pink_proof"

                yPos = LT_PINK_PROOF_Y

            Case "lt_pink_print"

                yPos = LT_PINK_PRINT_Y

            Case "lavender_proof"

                yPos = LAVENDER_PROOF_Y

            Case "lavender_print"

                yPos = LAVENDER_PRINT_Y

            Case "orchid_proof"

                yPos = ORCHID_PROOF_Y

            Case "orchid_print"

                yPos = ORCHID_PRINT_Y

            Case "garnet_proof"

                yPos = GARNET_PROOF_Y

            Case "garnet_print"

                yPos = GARNET_PRINT_Y

            Case "maroon_proof"

                yPos = MAROON_PROOF_Y

            Case "maroon_print"

                yPos = MAROON_PRINT_Y

            Case "metro_blue_proof"

                yPos = METRO_BLUE_PROOF_Y

            Case "metro_blue_print"

                yPos = METRO_BLUE_PRINT_Y

            Case "sandy_proof"

                yPos = SANDY_PROOF_Y

            Case "sandy_print"

                yPos = SANDY_PRINT_Y

            Case "prairie_dust_proof"

                yPos = PRAIRIE_DUST_PROOF_Y

            Case "prairie_dust_print"

                yPos = PRAIRIE_DUST_PRINT_Y

            Case "natural_proof"

                yPos = NATURAL_PROOF_Y

            Case "natural_print"

                yPos = NATURAL_PRINT_Y

            Case "dark_chocolate_proof"

                yPos = DARK_CHOCOLATE_PROOF_Y

            Case "dark_chocolate_print"

                yPos = DARK_CHOCOLATE_PRINT_Y

            Case "sand_proof"

                yPos = SAND_PROOF_Y

            Case "sand_print"

                yPos = SAND_PRINT_Y

            Case "brown_savana_proof"

                yPos = BROWN_SAVANA_PROOF_Y

            Case "brown_savana_print"

                yPos = BROWN_SAVANA_PRINT_Y

            Case "chestnut_proof"

                yPos = CHESTNUT_PROOF_Y

            Case "chestnut_print"

                yPos = CHESTNUT_PRINT_Y

            Case "heather_dark_chocolate_proof"

                yPos = HEATHER_DARK_CHOCOLATE_PROOF_Y

            Case "heather_dark_chocolate_print"

                yPos = HEATHER_DARK_CHOCOLATE_PRINT_Y

            Case "irish_green_proof"

                yPos = IRISH_GREEN_PROOF_Y

            Case "irish_green_print"

                yPos = IRISH_GREEN_PRINT_Y

            Case "heather_forest_proof"

                yPos = HEATHER_FOREST_PROOF_Y

            Case "heather_forest_print"

                yPos = HEATHER_FOREST_PRINT_Y

            Case "antique_jade_dome_proof"

                yPos = ANTIQUE_JADE_DOME_PROOF_Y

            Case "antique_jade_dome_print"

                yPos = ANTIQUE_JADE_DOME_PRINT_Y

            Case "charcoal_proof"

                yPos = CHARCOAL_PROOF_Y

            Case "charcoal_print"

                yPos = CHARCOAL_PRINT_Y

            Case "sports_grey_proof"

                yPos = SPORTS_GREY_PROOF_Y

            Case "sports_grey_print"

                yPos = SPORTS_GREY_PRINT_Y

            Case "kiwi_proof"

                yPos = KIWI_PROOF_Y

            Case "kiwi_print"

                yPos = KIWI_PRINT_Y

            Case "antique_sapphire_proof"

                yPos = ANTIQUE_SAPPHIRE_PROOF_Y

            Case "antique_sapphire_print"

                yPos = ANTIQUE_SAPPHIRE_PRINT_Y

            Case "graphite_heather_proof"

                yPos = GRAPHITE_HEATHER_PROOF_Y

            Case "graphite_heather_print"

                yPos = GRAPHITE_HEATHER_PRINT_Y

            Case "blackberry_proof"

                yPos = BLACKBERRY_PROOF_Y

            Case "blackberry_print"

                yPos = BLACKBERRY_PRINT_Y

            Case "midnight_proof"

                yPos = MIDNIGHT_PROOF_Y

            Case "midnight_print"

                yPos = MIDNIGHT_PRINT_Y

            Case "honey_proof"

                yPos = HONEY_PROOF_Y

            Case "honey_print"

                yPos = HONEY_PRINT_Y

            Case "daffodil_proof"

                yPos = DAFFODIL_PROOF_Y

            Case "daffodil_print"

                yPos = DAFFODIL_PRINT_Y

            Case "daisy_proof"

                yPos = DAISY_PROOF_Y

            Case "daisy_print"

                yPos = DAISY_PRINT_Y

            Case "texas_orange_proof"

                yPos = TEXAS_ORANGE_PROOF_Y

            Case "texas_orange_print"

                yPos = TEXAS_ORANGE_PRINT_Y

            Case "antique_orange_print"

                yPos = ANTIQUE_ORANGE_PRINT_Y

            Case "antique_orange_proof"

                yPos = ANTIQUE_ORANGE_PROOF_Y

            Case "antique_cherry_print"

                yPos = ANTIQUE_CHERRY_PRINT_Y

            Case "antique_cherry_proof"

                yPos = ANTIQUE_CHERRY_PROOF_Y

            Case "orange_print"

                yPos = ORANGE_PRINT_Y

            Case "orange_proof"

                yPos = ORANGE_PROOF_Y

            Case Else

                yPos = -1

        End Select

        Return yPos

    End Function

End Class