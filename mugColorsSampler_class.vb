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

    Public Function GetRGBColorFromShirtColors_NEWFile(ByRef app As Application, ByVal MugColor As MUG_COLOR) As RGBColor

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

    Private Function GetColorSwatchXPosition(ByVal MugColor As MUG_COLOR) As Integer

        Dim xPos As Integer = -1

        Select Case MugColor

            Case MUG_COLOR.HEATHER_NAVY_PROOF

                xPos = HEATHER_NAVY_PROOF_X

            Case MUG_COLOR.HEATHER_NAVY_PRINT

                xPos = HEATHER_NAVY_PRINT_X

            Case MUG_COLOR.DARK_HEATHER_PROOF

                xPos = DARK_HEATHER_PROOF_X

            Case MUG_COLOR.DARK_HEATHER_PRINT

                xPos = DARK_HEATHER_PRINT_X

            Case MUG_COLOR.HEATHER_INDIGO_PROOF

                xPos = HEATHER_INDIGO_PROOF_X

            Case MUG_COLOR.HEATHER_INDIGO_PRINT

                xPos = HEATHER_INDIGO_PRINT_X

            Case MUG_COLOR.STONE_BLUE_PROOF

                xPos = STONE_BLUE_PROOF_X

            Case MUG_COLOR.STONE_BLUE_PRINT

                xPos = STONE_BLUE_PRINT_X

            Case MUG_COLOR.NAVY_BLUE_PROOF

                xPos = NAVY_BLUE_PROOF_X

            Case MUG_COLOR.NAVY_BLUE_PRINT

                xPos = NAVY_BLUE_PRINT_X

            Case MUG_COLOR.AQUATIC_BLUE_PROOF

                xPos = AQUATIC_BLUE_PROOF_X

            Case MUG_COLOR.AQUATIC_BLUE_PRINT

                xPos = AQUATIC_BLUE_PRINT_X

            Case MUG_COLOR.INDIGO_BLUE_PROOF

                xPos = INDIGO_BLUE_PROOF_X

            Case MUG_COLOR.INDIGO_BLUE_PRINT

                xPos = INDIGO_BLUE_PRINT_X

            Case MUG_COLOR.CAROLINA_BLUE_PROOF

                xPos = CAROLINA_BLUE_PROOF_X

            Case MUG_COLOR.CAROLINA_BLUE_PRINT

                xPos = CAROLINA_BLUE_PRINT_X

            Case MUG_COLOR.IRIS_PROOF

                xPos = IRIS_PROOF_X

            Case MUG_COLOR.IRIS_PRINT

                xPos = IRIS_PRINT_X

            Case MUG_COLOR.VIOLET_PROOF

                xPos = VIOLET_PROOF_X

            Case MUG_COLOR.VIOLET_PRINT

                xPos = VIOLET_PRINT_X

            Case MUG_COLOR.LT_BLUE_PROOF

                xPos = LT_BLUE_PROOF_X

            Case MUG_COLOR.LT_BLUE_PRINT

                xPos = LT_BLUE_PRINT_X

            Case MUG_COLOR.HEATHER_MILITARY_PROOF

                xPos = HEATHER_MILITARY_PROOF_X

            Case MUG_COLOR.HEATHER_MILITARY_PRINT

                xPos = HEATHER_MILITARY_PRINT_X

            Case MUG_COLOR.STONEWASHED_GREEN_PROOF

                xPos = STONEWASHED_GREEN_PROOF_X

            Case MUG_COLOR.STONEWASHED_GREEN_PRINT

                xPos = STONEWASHED_GREEN_PRINT_X

            Case MUG_COLOR.MILITARY_GREEN_PROOF

                xPos = MILITARY_GREEN_PROOF_X

            Case MUG_COLOR.MILITARY_GREEN_PRINT

                xPos = MILITARY_GREEN_PRINT_X

            Case MUG_COLOR.FOREST_GREEN_PROOF

                xPos = FOREST_GREEN_PROOF_X

            Case MUG_COLOR.FOREST_GREEN_PRINT

                xPos = FOREST_GREEN_PRINT_X

            Case MUG_COLOR.PISTACHIO_PROOF

                xPos = PISTACHIO_PROOF_X

            Case MUG_COLOR.PISTACHIO_PRINT

                xPos = PISTACHIO_PRINT_X

            Case MUG_COLOR.ROYAL_BLUE_PROOF

                xPos = ROYAL_BLUE_PROOF_X

            Case MUG_COLOR.ROYAL_BLUE_PRINT

                xPos = ROYAL_BLUE_PRINT_X

            Case MUG_COLOR.PURPLE_PROOF

                xPos = PURPLE_PROOF_X

            Case MUG_COLOR.PURPLE_PRINT

                xPos = PURPLE_PRINT_X

            Case MUG_COLOR.JADE_DOME_PROOF

                xPos = JADE_DOME_PROOF_X

            Case MUG_COLOR.JADE_DOME_PRINT

                xPos = JADE_DOME_PRINT_X

            Case MUG_COLOR.COBALT_PROOF

                xPos = COBALT_PROOF_X

            Case MUG_COLOR.COBALT_PRINT

                xPos = COBALT_PRINT_X

            Case MUG_COLOR.SAPPHIRE_PROOF

                xPos = SAPPHIRE_PROOF_X

            Case MUG_COLOR.SAPPHIRE_PRINT

                xPos = SAPPHIRE_PRINT_X

            Case MUG_COLOR.BLUE_DUSK_PROOF

                xPos = BLUE_DUSK_PROOF_X

            Case MUG_COLOR.BLUE_DUSK_PRINT

                xPos = BLUE_DUSK_PRINT_X

            Case MUG_COLOR.CARDINAL_RED_PROOF

                xPos = CARDINAL_RED_PROOF_X

            Case MUG_COLOR.CARDINAL_RED_PRINT

                xPos = CARDINAL_RED_PRINT_X

            Case MUG_COLOR.RED_PROOF

                xPos = RED_PROOF_X

            Case MUG_COLOR.RED_PRINT

                xPos = RED_PRINT_X

            Case MUG_COLOR.HEATHER_RED_PROOF

                xPos = HEATHER_RED_PROOF_X

            Case MUG_COLOR.HEATHER_RED_PRINT

                xPos = HEATHER_RED_PRINT_X

            Case MUG_COLOR.HEATHER_CARDINAL_PROOF

                xPos = HEATHER_CARDINAL_PROOF_X

            Case MUG_COLOR.HEATHER_CARDINAL_PRINT

                xPos = HEATHER_CARDINAL_PRINT_X

            Case MUG_COLOR.HELICONIA_PROOF

                xPos = HELICONIA_PROOF_X

            Case MUG_COLOR.HELICONIA_PRINT

                xPos = HELICONIA_PRINT_X

            Case MUG_COLOR.LT_PINK_PROOF

                xPos = LT_PINK_PROOF_X

            Case MUG_COLOR.LT_PINK_PRINT

                xPos = LT_PINK_PRINT_X

            Case MUG_COLOR.LAVENDER_PROOF

                xPos = LAVENDER_PROOF_X

            Case MUG_COLOR.LAVENDER_PRINT

                xPos = LAVENDER_PRINT_X

            Case MUG_COLOR.ORCHID_PROOF

                xPos = ORCHID_PROOF_X

            Case MUG_COLOR.ORCHID_PRINT

                xPos = ORCHID_PRINT_X

            Case MUG_COLOR.GARNET_PROOF

                xPos = GARNET_PROOF_X

            Case MUG_COLOR.GARNET_PRINT

                xPos = GARNET_PRINT_X

            Case MUG_COLOR.MAROON_PROOF

                xPos = MAROON_PROOF_X

            Case MUG_COLOR.MAROON_PRINT

                xPos = MAROON_PRINT_X

            Case MUG_COLOR.METRO_BLUE_PROOF

                xPos = METRO_BLUE_PROOF_X

            Case MUG_COLOR.METRO_BLUE_PRINT

                xPos = METRO_BLUE_PRINT_X

            Case MUG_COLOR.SANDY_PROOF

                xPos = SANDY_PROOF_X

            Case MUG_COLOR.SANDY_PRINT

                xPos = SANDY_PRINT_X

            Case MUG_COLOR.PRAIRIE_DUST_PROOF

                xPos = PRAIRIE_DUST_PROOF_X

            Case MUG_COLOR.PRAIRIE_DUST_PRINT

                xPos = PRAIRIE_DUST_PRINT_X

            Case MUG_COLOR.NATURAL_PROOF

                xPos = NATURAL_PROOF_X

            Case MUG_COLOR.NATURAL_PRINT

                xPos = NATURAL_PRINT_X

            Case MUG_COLOR.DARK_CHOCOLATE_PROOF

                xPos = DARK_CHOCOLATE_PROOF_X

            Case MUG_COLOR.DARK_CHOCOLATE_PRINT

                xPos = DARK_CHOCOLATE_PRINT_X

            Case MUG_COLOR.SAND_PROOF

                xPos = SAND_PROOF_X

            Case MUG_COLOR.SAND_PRINT

                xPos = SAND_PRINT_X

            Case MUG_COLOR.BROWN_SAVANA_PROOF

                xPos = BROWN_SAVANA_PROOF_X

            Case MUG_COLOR.BROWN_SAVANA_PRINT

                xPos = BROWN_SAVANA_PRINT_X

            Case MUG_COLOR.CHESTNUT_PROOF

                xPos = CHESTNUT_PROOF_X

            Case MUG_COLOR.CHESTNUT_PRINT

                xPos = CHESTNUT_PRINT_X

            Case MUG_COLOR.HEATHER_DARK_CHOCOLATE_PROOF

                xPos = HEATHER_DARK_CHOCOLATE_PROOF_X

            Case MUG_COLOR.HEATHER_DARK_CHOCOLATE_PRINT

                xPos = HEATHER_DARK_CHOCOLATE_PRINT_X

            Case MUG_COLOR.IRISH_GREEN_PROOF

                xPos = IRISH_GREEN_PROOF_X

            Case MUG_COLOR.IRISH_GREEN_PRINT

                xPos = IRISH_GREEN_PRINT_X

            Case MUG_COLOR.HEATHER_FOREST_PROOF

                xPos = HEATHER_FOREST_PROOF_X

            Case MUG_COLOR.HEATHER_FOREST_PRINT

                xPos = HEATHER_FOREST_PRINT_X

            Case MUG_COLOR.ANTIQUE_JADE_DOME_PROOF

                xPos = ANTIQUE_JADE_DOME_PROOF_X

            Case MUG_COLOR.ANTIQUE_JADE_DOME_PRINT

                xPos = ANTIQUE_JADE_DOME_PRINT_X

            Case MUG_COLOR.CHARCOAL_PROOF

                xPos = CHARCOAL_PROOF_X

            Case MUG_COLOR.CHARCOAL_PRINT

                xPos = CHARCOAL_PRINT_X

            Case MUG_COLOR.SPORTS_GREY_PROOF

                xPos = SPORTS_GREY_PROOF_X

            Case MUG_COLOR.SPORTS_GREY_PRINT

                xPos = SPORTS_GREY_PRINT_X

            Case MUG_COLOR.KIWI_PROOF

                xPos = KIWI_PROOF_X

            Case MUG_COLOR.KIWI_PRINT

                xPos = KIWI_PRINT_X

            Case MUG_COLOR.ANTIQUE_SAPPHIRE_PROOF

                xPos = ANTIQUE_SAPPHIRE_PROOF_X

            Case MUG_COLOR.ANTIQUE_SAPPHIRE_PRINT

                xPos = ANTIQUE_SAPPHIRE_PRINT_X

            Case MUG_COLOR.GRAPHITE_HEATHER_PROOF

                xPos = GRAPHITE_HEATHER_PROOF_X

            Case MUG_COLOR.GRAPHITE_HEATHER_PRINT

                xPos = GRAPHITE_HEATHER_PRINT_X

            Case MUG_COLOR.BLACKBERRY_PROOF

                xPos = BLACKBERRY_PROOF_X

            Case MUG_COLOR.BLACKBERRY_PRINT

                xPos = BLACKBERRY_PRINT_X

            Case MUG_COLOR.MIDNIGHT_PROOF

                xPos = MIDNIGHT_PROOF_X

            Case MUG_COLOR.MIDNIGHT_PRINT

                xPos = MIDNIGHT_PRINT_X

            Case MUG_COLOR.HONEY_PROOF

                xPos = HONEY_PROOF_X

            Case MUG_COLOR.HONEY_PRINT

                xPos = HONEY_PRINT_X

            Case MUG_COLOR.DAFFODIL_PROOF

                xPos = DAFFODIL_PROOF_X

            Case MUG_COLOR.DAFFODIL_PRINT

                xPos = DAFFODIL_PRINT_X

            Case MUG_COLOR.DAISY_PROOF

                xPos = DAISY_PROOF_X

            Case MUG_COLOR.DAISY_PRINT

                xPos = DAISY_PRINT_X

            Case MUG_COLOR.TEXAS_ORANGE_PROOF

                xPos = TEXAS_ORANGE_PROOF_X

            Case MUG_COLOR.TEXAS_ORANGE_PRINT

                xPos = TEXAS_ORANGE_PRINT_X

            Case MUG_COLOR.ANTIQUE_ORANGE_PRINT

                xPos = ANTIQUE_ORANGE_PRINT_X

            Case MUG_COLOR.ANTIQUE_ORANGE_PROOF

                xPos = ANTIQUE_ORANGE_PROOF_X

            Case MUG_COLOR.ANTIQUE_CHERRY_PRINT

                xPos = ANTIQUE_CHERRY_PRINT_X

            Case MUG_COLOR.ANTIQUE_CHERRY_PROOF

                xPos = ANTIQUE_CHERRY_PROOF_X

            Case MUG_COLOR.ORANGE_PRINT

                xPos = ORANGE_PRINT_X

            Case MUG_COLOR.ORANGE_PROOF

                xPos = ORANGE_PROOF_X

        End Select

        Return xPos

    End Function

    Private Function GetColorSwatchYPosition(ByVal MugColor As MUG_COLOR) As Integer

        Dim yPos As Integer = -1

        Select Case MugColor

            Case MUG_COLOR.HEATHER_NAVY_PROOF

                yPos = HEATHER_NAVY_PROOF_Y

            Case MUG_COLOR.HEATHER_NAVY_PRINT

                yPos = HEATHER_NAVY_PRINT_Y

            Case MUG_COLOR.DARK_HEATHER_PROOF

                yPos = DARK_HEATHER_PROOF_Y

            Case MUG_COLOR.DARK_HEATHER_PRINT

                yPos = DARK_HEATHER_PRINT_Y

            Case MUG_COLOR.HEATHER_INDIGO_PROOF

                yPos = HEATHER_INDIGO_PROOF_Y

            Case MUG_COLOR.HEATHER_INDIGO_PRINT

                yPos = HEATHER_INDIGO_PRINT_Y

            Case MUG_COLOR.STONE_BLUE_PROOF

                yPos = STONE_BLUE_PROOF_Y

            Case MUG_COLOR.STONE_BLUE_PRINT

                yPos = STONE_BLUE_PRINT_Y

            Case MUG_COLOR.NAVY_BLUE_PROOF

                yPos = NAVY_BLUE_PROOF_Y

            Case MUG_COLOR.NAVY_BLUE_PRINT

                yPos = NAVY_BLUE_PRINT_Y

            Case MUG_COLOR.AQUATIC_BLUE_PROOF

                yPos = AQUATIC_BLUE_PROOF_Y

            Case MUG_COLOR.AQUATIC_BLUE_PRINT

                yPos = AQUATIC_BLUE_PRINT_Y

            Case MUG_COLOR.INDIGO_BLUE_PROOF

                yPos = INDIGO_BLUE_PROOF_Y

            Case MUG_COLOR.INDIGO_BLUE_PRINT

                yPos = INDIGO_BLUE_PRINT_Y

            Case MUG_COLOR.CAROLINA_BLUE_PROOF

                yPos = CAROLINA_BLUE_PROOF_Y

            Case MUG_COLOR.CAROLINA_BLUE_PRINT

                yPos = CAROLINA_BLUE_PRINT_Y

            Case MUG_COLOR.IRIS_PROOF

                yPos = IRIS_PROOF_Y

            Case MUG_COLOR.IRIS_PRINT

                yPos = IRIS_PRINT_Y

            Case MUG_COLOR.VIOLET_PROOF

                yPos = VIOLET_PROOF_Y

            Case MUG_COLOR.VIOLET_PRINT

                yPos = VIOLET_PRINT_Y

            Case MUG_COLOR.LT_BLUE_PROOF

                yPos = LT_BLUE_PROOF_Y

            Case MUG_COLOR.LT_BLUE_PRINT

                yPos = LT_BLUE_PRINT_Y

            Case MUG_COLOR.HEATHER_MILITARY_PROOF

                yPos = HEATHER_MILITARY_PROOF_Y

            Case MUG_COLOR.HEATHER_MILITARY_PRINT

                yPos = HEATHER_MILITARY_PRINT_Y

            Case MUG_COLOR.STONEWASHED_GREEN_PROOF

                yPos = STONEWASHED_GREEN_PROOF_Y

            Case MUG_COLOR.STONEWASHED_GREEN_PRINT

                yPos = STONEWASHED_GREEN_PRINT_Y

            Case MUG_COLOR.MILITARY_GREEN_PROOF

                yPos = MILITARY_GREEN_PROOF_Y

            Case MUG_COLOR.MILITARY_GREEN_PRINT

                yPos = MILITARY_GREEN_PRINT_Y

            Case MUG_COLOR.FOREST_GREEN_PROOF

                yPos = FOREST_GREEN_PROOF_Y

            Case MUG_COLOR.FOREST_GREEN_PRINT

                yPos = FOREST_GREEN_PRINT_Y

            Case MUG_COLOR.PISTACHIO_PROOF

                yPos = PISTACHIO_PROOF_Y

            Case MUG_COLOR.PISTACHIO_PRINT

                yPos = PISTACHIO_PRINT_Y

            Case MUG_COLOR.ROYAL_BLUE_PROOF

                yPos = ROYAL_BLUE_PROOF_Y

            Case MUG_COLOR.ROYAL_BLUE_PRINT

                yPos = ROYAL_BLUE_PRINT_Y

            Case MUG_COLOR.PURPLE_PROOF

                yPos = PURPLE_PROOF_Y

            Case MUG_COLOR.PURPLE_PRINT

                yPos = PURPLE_PRINT_Y

            Case MUG_COLOR.JADE_DOME_PROOF

                yPos = JADE_DOME_PROOF_Y

            Case MUG_COLOR.JADE_DOME_PRINT

                yPos = JADE_DOME_PRINT_Y

            Case MUG_COLOR.COBALT_PROOF

                yPos = COBALT_PROOF_Y

            Case MUG_COLOR.COBALT_PRINT

                yPos = COBALT_PRINT_Y

            Case MUG_COLOR.SAPPHIRE_PROOF

                yPos = SAPPHIRE_PROOF_Y

            Case MUG_COLOR.SAPPHIRE_PRINT

                yPos = SAPPHIRE_PRINT_Y

            Case MUG_COLOR.BLUE_DUSK_PROOF

                yPos = BLUE_DUSK_PROOF_Y

            Case MUG_COLOR.BLUE_DUSK_PRINT

                yPos = BLUE_DUSK_PRINT_Y

            Case MUG_COLOR.CARDINAL_RED_PROOF

                yPos = CARDINAL_RED_PROOF_Y

            Case MUG_COLOR.CARDINAL_RED_PRINT

                yPos = CARDINAL_RED_PRINT_Y

            Case MUG_COLOR.RED_PROOF

                yPos = RED_PROOF_Y

            Case MUG_COLOR.RED_PRINT

                yPos = RED_PRINT_Y

            Case MUG_COLOR.HEATHER_RED_PROOF

                yPos = HEATHER_RED_PROOF_Y

            Case MUG_COLOR.HEATHER_RED_PRINT

                yPos = HEATHER_RED_PRINT_Y

            Case MUG_COLOR.HEATHER_CARDINAL_PROOF

                yPos = HEATHER_CARDINAL_PROOF_Y

            Case MUG_COLOR.HEATHER_CARDINAL_PRINT

                yPos = HEATHER_CARDINAL_PRINT_Y

            Case MUG_COLOR.HELICONIA_PROOF

                yPos = HELICONIA_PROOF_Y

            Case MUG_COLOR.HELICONIA_PRINT

                yPos = HELICONIA_PRINT_Y

            Case MUG_COLOR.LT_PINK_PROOF

                yPos = LT_PINK_PROOF_Y

            Case MUG_COLOR.LT_PINK_PRINT

                yPos = LT_PINK_PRINT_Y

            Case MUG_COLOR.LAVENDER_PROOF

                yPos = LAVENDER_PROOF_Y

            Case MUG_COLOR.LAVENDER_PRINT

                yPos = LAVENDER_PRINT_Y

            Case MUG_COLOR.ORCHID_PROOF

                yPos = ORCHID_PROOF_Y

            Case MUG_COLOR.ORCHID_PRINT

                yPos = ORCHID_PRINT_Y

            Case MUG_COLOR.GARNET_PROOF

                yPos = GARNET_PROOF_Y

            Case MUG_COLOR.GARNET_PRINT

                yPos = GARNET_PRINT_Y

            Case MUG_COLOR.MAROON_PROOF

                yPos = MAROON_PROOF_Y

            Case MUG_COLOR.MAROON_PRINT

                yPos = MAROON_PRINT_Y

            Case MUG_COLOR.METRO_BLUE_PROOF

                yPos = METRO_BLUE_PROOF_Y

            Case MUG_COLOR.METRO_BLUE_PRINT

                yPos = METRO_BLUE_PRINT_Y

            Case MUG_COLOR.SANDY_PROOF

                yPos = SANDY_PROOF_Y

            Case MUG_COLOR.SANDY_PRINT

                yPos = SANDY_PRINT_Y

            Case MUG_COLOR.PRAIRIE_DUST_PROOF

                yPos = PRAIRIE_DUST_PROOF_Y

            Case MUG_COLOR.PRAIRIE_DUST_PRINT

                yPos = PRAIRIE_DUST_PRINT_Y

            Case MUG_COLOR.NATURAL_PROOF

                yPos = NATURAL_PROOF_Y

            Case MUG_COLOR.NATURAL_PRINT

                yPos = NATURAL_PRINT_Y

            Case MUG_COLOR.DARK_CHOCOLATE_PROOF

                yPos = DARK_CHOCOLATE_PROOF_Y

            Case MUG_COLOR.DARK_CHOCOLATE_PRINT

                yPos = DARK_CHOCOLATE_PRINT_Y

            Case MUG_COLOR.SAND_PROOF

                yPos = SAND_PROOF_Y

            Case MUG_COLOR.SAND_PRINT

                yPos = SAND_PRINT_Y

            Case MUG_COLOR.BROWN_SAVANA_PROOF

                yPos = BROWN_SAVANA_PROOF_Y

            Case MUG_COLOR.BROWN_SAVANA_PRINT

                yPos = BROWN_SAVANA_PRINT_Y

            Case MUG_COLOR.CHESTNUT_PROOF

                yPos = CHESTNUT_PROOF_Y

            Case MUG_COLOR.CHESTNUT_PRINT

                yPos = CHESTNUT_PRINT_Y

            Case MUG_COLOR.HEATHER_DARK_CHOCOLATE_PROOF

                yPos = HEATHER_DARK_CHOCOLATE_PROOF_Y

            Case MUG_COLOR.HEATHER_DARK_CHOCOLATE_PRINT

                yPos = HEATHER_DARK_CHOCOLATE_PRINT_Y

            Case MUG_COLOR.IRISH_GREEN_PROOF

                yPos = IRISH_GREEN_PROOF_Y

            Case MUG_COLOR.IRISH_GREEN_PRINT

                yPos = IRISH_GREEN_PRINT_Y

            Case MUG_COLOR.HEATHER_FOREST_PROOF

                yPos = HEATHER_FOREST_PROOF_Y

            Case MUG_COLOR.HEATHER_FOREST_PRINT

                yPos = HEATHER_FOREST_PRINT_Y

            Case MUG_COLOR.ANTIQUE_JADE_DOME_PROOF

                yPos = ANTIQUE_JADE_DOME_PROOF_Y

            Case MUG_COLOR.ANTIQUE_JADE_DOME_PRINT

                yPos = ANTIQUE_JADE_DOME_PRINT_Y

            Case MUG_COLOR.CHARCOAL_PROOF

                yPos = CHARCOAL_PROOF_Y

            Case MUG_COLOR.CHARCOAL_PRINT

                yPos = CHARCOAL_PRINT_Y

            Case MUG_COLOR.SPORTS_GREY_PROOF

                yPos = SPORTS_GREY_PROOF_Y

            Case MUG_COLOR.SPORTS_GREY_PRINT

                yPos = SPORTS_GREY_PRINT_Y

            Case MUG_COLOR.KIWI_PROOF

                yPos = KIWI_PROOF_Y

            Case MUG_COLOR.KIWI_PRINT

                yPos = KIWI_PRINT_Y

            Case MUG_COLOR.ANTIQUE_SAPPHIRE_PROOF

                yPos = ANTIQUE_SAPPHIRE_PROOF_Y

            Case MUG_COLOR.ANTIQUE_SAPPHIRE_PRINT

                yPos = ANTIQUE_SAPPHIRE_PRINT_Y

            Case MUG_COLOR.GRAPHITE_HEATHER_PROOF

                yPos = GRAPHITE_HEATHER_PROOF_Y

            Case MUG_COLOR.GRAPHITE_HEATHER_PRINT

                yPos = GRAPHITE_HEATHER_PRINT_Y

            Case MUG_COLOR.BLACKBERRY_PROOF

                yPos = BLACKBERRY_PROOF_Y

            Case MUG_COLOR.BLACKBERRY_PRINT

                yPos = BLACKBERRY_PRINT_Y

            Case MUG_COLOR.MIDNIGHT_PROOF

                yPos = MIDNIGHT_PROOF_Y

            Case MUG_COLOR.MIDNIGHT_PRINT

                yPos = MIDNIGHT_PRINT_Y

            Case MUG_COLOR.HONEY_PROOF

                yPos = HONEY_PROOF_Y

            Case MUG_COLOR.HONEY_PRINT

                yPos = HONEY_PRINT_Y

            Case MUG_COLOR.DAFFODIL_PROOF

                yPos = DAFFODIL_PROOF_Y

            Case MUG_COLOR.DAFFODIL_PRINT

                yPos = DAFFODIL_PRINT_Y

            Case MUG_COLOR.DAISY_PROOF

                yPos = DAISY_PROOF_Y

            Case MUG_COLOR.DAISY_PRINT

                yPos = DAISY_PRINT_Y

            Case MUG_COLOR.TEXAS_ORANGE_PROOF

                yPos = TEXAS_ORANGE_PROOF_Y

            Case MUG_COLOR.TEXAS_ORANGE_PRINT

                yPos = TEXAS_ORANGE_PRINT_Y

            Case MUG_COLOR.ANTIQUE_ORANGE_PRINT

                yPos = ANTIQUE_ORANGE_PRINT_Y

            Case MUG_COLOR.ANTIQUE_ORANGE_PROOF

                yPos = ANTIQUE_ORANGE_PROOF_Y

            Case MUG_COLOR.ANTIQUE_CHERRY_PRINT

                yPos = ANTIQUE_CHERRY_PRINT_Y

            Case MUG_COLOR.ANTIQUE_CHERRY_PROOF

                yPos = ANTIQUE_CHERRY_PROOF_Y

            Case MUG_COLOR.ORANGE_PRINT

                yPos = ORANGE_PRINT_Y

            Case MUG_COLOR.ORANGE_PROOF

                yPos = ORANGE_PROOF_Y

        End Select

        Return yPos

    End Function

End Class

Public Enum MUG_COLOR

    HEATHER_NAVY_PROOF
    HEATHER_NAVY_PRINT
    DARK_HEATHER_PROOF
    DARK_HEATHER_PRINT
    HEATHER_INDIGO_PROOF
    HEATHER_INDIGO_PRINT
    STONE_BLUE_PROOF
    STONE_BLUE_PRINT
    NAVY_BLUE_PROOF
    NAVY_BLUE_PRINT
    AQUATIC_BLUE_PROOF
    AQUATIC_BLUE_PRINT
    INDIGO_BLUE_PROOF
    INDIGO_BLUE_PRINT
    CAROLINA_BLUE_PROOF
    CAROLINA_BLUE_PRINT
    IRIS_PROOF
    IRIS_PRINT
    VIOLET_PROOF
    VIOLET_PRINT
    LT_BLUE_PROOF
    LT_BLUE_PRINT
    HEATHER_MILITARY_PROOF
    HEATHER_MILITARY_PRINT
    STONEWASHED_GREEN_PROOF
    STONEWASHED_GREEN_PRINT
    MILITARY_GREEN_PROOF
    MILITARY_GREEN_PRINT
    FOREST_GREEN_PROOF
    FOREST_GREEN_PRINT
    PISTACHIO_PROOF
    PISTACHIO_PRINT
    ROYAL_BLUE_PROOF
    ROYAL_BLUE_PRINT
    PURPLE_PROOF
    PURPLE_PRINT
    JADE_DOME_PROOF
    JADE_DOME_PRINT
    COBALT_PROOF
    COBALT_PRINT
    SAPPHIRE_PROOF
    SAPPHIRE_PRINT
    BLUE_DUSK_PROOF
    BLUE_DUSK_PRINT
    CARDINAL_RED_PROOF
    CARDINAL_RED_PRINT
    RED_PROOF
    RED_PRINT
    HEATHER_RED_PROOF
    HEATHER_RED_PRINT
    HEATHER_CARDINAL_PROOF
    HEATHER_CARDINAL_PRINT
    HELICONIA_PROOF
    HELICONIA_PRINT
    LT_PINK_PROOF
    LT_PINK_PRINT
    LAVENDER_PROOF
    LAVENDER_PRINT
    ORCHID_PROOF
    ORCHID_PRINT
    GARNET_PROOF
    GARNET_PRINT
    MAROON_PROOF
    MAROON_PRINT
    METRO_BLUE_PROOF
    METRO_BLUE_PRINT
    SANDY_PROOF
    SANDY_PRINT
    PRAIRIE_DUST_PROOF
    PRAIRIE_DUST_PRINT
    NATURAL_PROOF
    NATURAL_PRINT
    DARK_CHOCOLATE_PROOF
    DARK_CHOCOLATE_PRINT
    SAND_PROOF
    SAND_PRINT
    BROWN_SAVANA_PROOF
    BROWN_SAVANA_PRINT
    CHESTNUT_PROOF
    CHESTNUT_PRINT
    HEATHER_DARK_CHOCOLATE_PROOF
    HEATHER_DARK_CHOCOLATE_PRINT
    IRISH_GREEN_PROOF
    IRISH_GREEN_PRINT
    HEATHER_FOREST_PROOF
    HEATHER_FOREST_PRINT
    ANTIQUE_JADE_DOME_PROOF
    ANTIQUE_JADE_DOME_PRINT
    CHARCOAL_PROOF
    CHARCOAL_PRINT
    SPORTS_GREY_PROOF
    SPORTS_GREY_PRINT
    KIWI_PROOF
    KIWI_PRINT
    ANTIQUE_SAPPHIRE_PROOF
    ANTIQUE_SAPPHIRE_PRINT
    GRAPHITE_HEATHER_PROOF
    GRAPHITE_HEATHER_PRINT
    BLACKBERRY_PROOF
    BLACKBERRY_PRINT
    MIDNIGHT_PROOF
    MIDNIGHT_PRINT
    HONEY_PROOF
    HONEY_PRINT
    DAFFODIL_PROOF
    DAFFODIL_PRINT
    DAISY_PROOF
    DAISY_PRINT
    TEXAS_ORANGE_PROOF
    TEXAS_ORANGE_PRINT
    ANTIQUE_ORANGE_PRINT
    ANTIQUE_ORANGE_PROOF
    ANTIQUE_CHERRY_PRINT
    ANTIQUE_CHERRY_PROOF
    ORANGE_PRINT
    ORANGE_PROOF

End Enum