Imports Photoshop

Public Class mugColorsSampler_class

    Private Const HEATHER_NAVY_PROOF_X = 163
    Private Const HEATHER_NAVY_PRINT_X = 383
    Private Const DARK_HEATHER_PROOF_X = 171
    Private Const DARK_HEATHER_PRINT_X = 367
    Private Const HEATHER_INDIGO_PROOF_X = 171
    Private Const HEATHER_INDIGO_PRINT_X = 375
    Private Const STONE_BLUE_PROOF_X = 155
    Private Const STONE_BLUE_PRINT_X = 383
    Private Const NAVY_BLUE_PROOF_X = 171
    Private Const NAVY_BLUE_PRINT_X = 395
    Private Const AQUATIC_BLUE_PROOF_X = 147
    Private Const AQUATIC_BLUE_PRINT_X = 371
    Private Const INDIGO_BLUE_PROOF_X = 131
    Private Const INDIGO_BLUE_PRINT_X = 387
    Private Const CAROLINA_BLUE_PROOF_X = 143
    Private Const CAROLINA_BLUE_PRINT_X = 399
    Private Const IRIS_PROOF_X = 143
    Private Const IRIS_PRINT_X = 395
    Private Const VIOLET_PROOF_X = 171
    Private Const VIOLET_PRINT_X = 399
    Private Const LT_BLUE_PROOF_X = 139
    Private Const LT_BLUE_PRINT_X = 395
    Private Const HEATHER_MILITARY_PROOF_X = 779
    Private Const HEATHER_MILITARY_PRINT_X = 1019
    Private Const STONEWASHED_GREEN_PROOF_X = 779
    Private Const STONEWASHED_GREEN_PRINT_X = 1015
    Private Const MILITARY_GREEN_PROOF_X = 787
    Private Const MILITARY_GREEN_PRINT_X = 1003
    Private Const FOREST_GREEN_PROOF_X = 767
    Private Const FOREST_GREEN_PRINT_X = 1023
    Private Const PISTACHIO_PROOF_X = 759
    Private Const PISTACHIO_PRINT_X = 995
    Private Const ROYAL_BLUE_PROOF_X = 759
    Private Const ROYAL_BLUE_PRINT_X = 1003
    Private Const PURPLE_PROOF_X = 783
    Private Const PURPLE_PRINT_X = 999
    Private Const JADE_DOME_PROOF_X = 783
    Private Const JADE_DOME_PRINT_X = 995
    Private Const COBALT_PROOF_X = 767
    Private Const COBALT_PRINT_X = 991
    Private Const SAPPHIRE_PROOF_X = 755
    Private Const SAPPHIRE_PRINT_X = 995
    Private Const BLUE_DUSK_PROOF_X = 775
    Private Const BLUE_DUSK_PRINT_X = 1007
    Private Const CARDINAL_RED_PROOF_X = 1399
    Private Const CARDINAL_RED_PRINT_X = 1631
    Private Const RED_PROOF_X = 1403
    Private Const RED_PRINT_X = 1659
    Private Const HEATHER_RED_PROOF_X = 1427
    Private Const HEATHER_RED_PRINT_X = 1635
    Private Const HEATHER_CARDINAL_PROOF_X = 1439
    Private Const HEATHER_CARDINAL_PRINT_X = 1635
    Private Const HELICONIA_PROOF_X = 1383
    Private Const HELICONIA_PRINT_X = 1383
    Private Const LT_PINK_PROOF_X = 1423
    Private Const LT_PINK_PRINT_X = 1423
    Private Const LAVENDER_PROOF_X = 1399
    Private Const LAVENDER_PRINT_X = 1631
    Private Const ORCHID_PROOF_X = 1339
    Private Const ORCHID_PRINT_X = 1659
    Private Const GARNET_PROOF_X = 1411
    Private Const GARNET_PRINT_X = 1655
    Private Const MAROON_PROOF_X = 1415
    Private Const MAROON_PRINT_X = 1631
    Private Const METRO_BLUE_PROOF_X = 1439
    Private Const METRO_BLUE_PRINT_X = 1623
    Private Const SANDY_PROOF_X = 2063
    Private Const SANDY_PRINT_X = 2294
    Private Const PRAIRIE_DUST_PROOF_X = 2063
    Private Const PRAIRIE_DUST_PRINT_X = 2282
    Private Const NATURAL_PROOF_X = 2079
    Private Const NATURAL_PRINT_X = 2290
    Private Const DARK_CHOCOLATE_PROOF_X = 2071
    Private Const DARK_CHOCOLATE_PRINT_X = 2278
    Private Const SAND_PROOF_X = 2043
    Private Const SAND_PRINT_X = 2302
    Private Const BROWN_SAVANA_PROOF_X = 2087
    Private Const BROWN_SAVANA_PRINT_X = 2278
    Private Const CHESTNUT_PROOF_X = 2107
    Private Const CHESTNUT_PRINT_X = 2326
    Private Const HEATHER_DARK_CHOCOLATE_PROOF_X = 2091
    Private Const HEATHER_DARK_CHOCOLATE_PRINT_X = 2091
    Private Const IRISH_GREEN_PROOF_X = 2087
    Private Const IRISH_GREEN_PRINT_X = 2294
    Private Const HEATHER_FOREST_PROOF_X = 2091
    Private Const HEATHER_FOREST_PRINT_X = 2259
    Private Const ANTIQUE_JADE_DOME_PROOF_X = 2103
    Private Const ANTIQUE_JADE_DOME_PRINT_X = 2331
    Private Const CHARCOAL_PROOF_X = 2719
    Private Const CHARCOAL_PRINT_X = 2919
    Private Const SPORTS_GREY_PROOF_X = 2695
    Private Const SPORTS_GREY_PRINT_X = 2951
    Private Const KIWI_PROOF_X = 2699
    Private Const KIWI_PRINT_X = 2927
    Private Const ANTIQUE_SAPPHIRE_PROOF_X = 2719
    Private Const ANTIQUE_SAPPHIRE_PRINT_X = 2931
    Private Const GRAPHITE_HEATHER_PROOF_X = 2719
    Private Const GRAPHITE_HEATHER_PRINT_X = 2911
    Private Const BLACKBERRY_PROOF_X = 2447
    Private Const BLACKBERRY_PRINT_X = 2947
    Private Const MIDNIGHT_PROOF_X = 2731
    Private Const MIDNIGHT_PRINT_X = 2959
    Private Const HONEY_PROOF_X = 3346
    Private Const HONEY_PRINT_X = 3538
    Private Const DAFFODIL_PROOF_X = 3343
    Private Const DAFFODIL_PRINT_X = 3343
    Private Const DAISY_PROOF_X = 3358
    Private Const DAISY_PRINT_X = 3562
    Private Const TEXAS_ORANGE_PROOF_X = 3374
    Private Const TEXAS_ORANGE_PRINT_X = 3566
    Private Const ANTIQUE_ORANGE_PRINT_X = 3366
    Private Const ANTIQUE_ORANGE_PROOF_X = 3554
    Private Const ANTIQUE_CHERRY_PRINT_X = 3358
    Private Const ANTIQUE_CHERRY_PROOF_X = 3558
    Private Const ORANGE_PRINT_X = 3346
    Private Const ORANGE_PROOF_X = 3566

    Private Const HEATHER_NAVY_PROOF_Y = 210
    Private Const HEATHER_NAVY_PRINT_Y = 210
    Private Const DARK_HEATHER_PROOF_Y = 514
    Private Const DARK_HEATHER_PRINT_Y = 502
    Private Const HEATHER_INDIGO_PROOF_Y = 802
    Private Const HEATHER_INDIGO_PRINT_Y = 786
    Private Const STONE_BLUE_PROOF_Y = 1066
    Private Const STONE_BLUE_PRINT_Y = 1058
    Private Const NAVY_BLUE_PROOF_Y = 1358
    Private Const NAVY_BLUE_PRINT_Y = 1350
    Private Const AQUATIC_BLUE_PROOF_Y = 1594
    Private Const AQUATIC_BLUE_PRINT_Y = 1606
    Private Const INDIGO_BLUE_PROOF_Y = 1906
    Private Const INDIGO_BLUE_PRINT_Y = 1882
    Private Const CAROLINA_BLUE_PROOF_Y = 2190
    Private Const CAROLINA_BLUE_PRINT_Y = 2198
    Private Const IRIS_PROOF_Y = 2482
    Private Const IRIS_PRINT_Y = 2458
    Private Const VIOLET_PROOF_Y = 2734
    Private Const VIOLET_PRINT_Y = 2730
    Private Const LT_BLUE_PROOF_Y = 2994
    Private Const LT_BLUE_PRINT_Y = 3002
    Private Const HEATHER_MILITARY_PROOF_Y = 202
    Private Const HEATHER_MILITARY_PRINT_Y = 214
    Private Const STONEWASHED_GREEN_PROOF_Y = 498
    Private Const STONEWASHED_GREEN_PRINT_Y = 498
    Private Const MILITARY_GREEN_PROOF_Y = 798
    Private Const MILITARY_GREEN_PRINT_Y = 794
    Private Const FOREST_GREEN_PROOF_Y = 1082
    Private Const FOREST_GREEN_PRINT_Y = 1070
    Private Const PISTACHIO_PROOF_Y = 1322
    Private Const PISTACHIO_PRINT_Y = 1338
    Private Const ROYAL_BLUE_PROOF_Y = 1602
    Private Const ROYAL_BLUE_PRINT_Y = 1602
    Private Const PURPLE_PROOF_Y = 1882
    Private Const PURPLE_PRINT_Y = 1914
    Private Const JADE_DOME_PROOF_Y = 2190
    Private Const JADE_DOME_PRINT_Y = 2202
    Private Const COBALT_PROOF_Y = 2478
    Private Const COBALT_PRINT_Y = 2494
    Private Const SAPPHIRE_PROOF_Y = 2766
    Private Const SAPPHIRE_PRINT_Y = 2742
    Private Const BLUE_DUSK_PROOF_Y = 3030
    Private Const BLUE_DUSK_PRINT_Y = 3030
    Private Const CARDINAL_RED_PROOF_Y = 270
    Private Const CARDINAL_RED_PRINT_Y = 214
    Private Const RED_PROOF_Y = 502
    Private Const RED_PRINT_Y = 490
    Private Const HEATHER_RED_PROOF_Y = 782
    Private Const HEATHER_RED_PRINT_Y = 786
    Private Const HEATHER_CARDINAL_PROOF_Y = 1078
    Private Const HEATHER_CARDINAL_PRINT_Y = 1098
    Private Const HELICONIA_PROOF_Y = 1346
    Private Const HELICONIA_PRINT_Y = 1346
    Private Const LT_PINK_PROOF_Y = 1606
    Private Const LT_PINK_PRINT_Y = 1606
    Private Const LAVENDER_PROOF_Y = 1902
    Private Const LAVENDER_PRINT_Y = 1886
    Private Const ORCHID_PROOF_Y = 2166
    Private Const ORCHID_PRINT_Y = 2190
    Private Const GARNET_PROOF_Y = 2478
    Private Const GARNET_PRINT_Y = 2490
    Private Const MAROON_PROOF_Y = 2722
    Private Const MAROON_PRINT_Y = 2742
    Private Const METRO_BLUE_PROOF_Y = 3010
    Private Const METRO_BLUE_PRINT_Y = 3026
    Private Const SANDY_PROOF_Y = 230
    Private Const SANDY_PRINT_Y = 214
    Private Const PRAIRIE_DUST_PROOF_Y = 482
    Private Const PRAIRIE_DUST_PRINT_Y = 486
    Private Const NATURAL_PROOF_Y = 786
    Private Const NATURAL_PRINT_Y = 762
    Private Const DARK_CHOCOLATE_PROOF_Y = 1090
    Private Const DARK_CHOCOLATE_PRINT_Y = 1110
    Private Const SAND_PROOF_Y = 1334
    Private Const SAND_PRINT_Y = 1330
    Private Const BROWN_SAVANA_PROOF_Y = 1610
    Private Const BROWN_SAVANA_PRINT_Y = 1626
    Private Const CHESTNUT_PROOF_Y = 1898
    Private Const CHESTNUT_PRINT_Y = 1906
    Private Const HEATHER_DARK_CHOCOLATE_PROOF_Y = 2174
    Private Const HEATHER_DARK_CHOCOLATE_PRINT_Y = 2174
    Private Const IRISH_GREEN_PROOF_Y = 2478
    Private Const IRISH_GREEN_PRINT_Y = 2474
    Private Const HEATHER_FOREST_PROOF_Y = 2750
    Private Const HEATHER_FOREST_PRINT_Y = 2778
    Private Const ANTIQUE_JADE_DOME_PROOF_Y = 3018
    Private Const ANTIQUE_JADE_DOME_PRINT_Y = 3015
    Private Const CHARCOAL_PROOF_Y = 215
    Private Const CHARCOAL_PRINT_Y = 231
    Private Const SPORTS_GREY_PROOF_Y = 479
    Private Const SPORTS_GREY_PRINT_Y = 491
    Private Const KIWI_PROOF_Y = 795
    Private Const KIWI_PRINT_Y = 811
    Private Const ANTIQUE_SAPPHIRE_PROOF_Y = 1071
    Private Const ANTIQUE_SAPPHIRE_PRINT_Y = 1071
    Private Const GRAPHITE_HEATHER_PROOF_Y = 1347
    Private Const GRAPHITE_HEATHER_PRINT_Y = 1327
    Private Const BLACKBERRY_PROOF_Y = 1899
    Private Const BLACKBERRY_PRINT_Y = 1883
    Private Const MIDNIGHT_PROOF_Y = 2151
    Private Const MIDNIGHT_PRINT_Y = 2167
    Private Const HONEY_PROOF_Y = 207
    Private Const HONEY_PRINT_Y = 223
    Private Const DAFFODIL_PROOF_Y = 479
    Private Const DAFFODIL_PRINT_Y = 479
    Private Const DAISY_PROOF_Y = 799
    Private Const DAISY_PRINT_Y = 803
    Private Const TEXAS_ORANGE_PROOF_Y = 1091
    Private Const TEXAS_ORANGE_PRINT_Y = 1075
    Private Const ANTIQUE_ORANGE_PRINT_Y = 1391
    Private Const ANTIQUE_ORANGE_PROOF_Y = 1379
    Private Const ANTIQUE_CHERRY_PRINT_Y = 1647
    Private Const ANTIQUE_CHERRY_PROOF_Y = 1659
    Private Const ORANGE_PRINT_Y = 1927
    Private Const ORANGE_PROOF_Y = 1927

    Public Enum MUG_COLOR

        HEATHER_NAVY_PROOF = 0
        HEATHER_NAVY_PRINT = 1
        DARK_HEATHER_PROOF = 2
        DARK_HEATHER_PRINT = 3
        HEATHER_INDIGO_PROOF = 4
        HEATHER_INDIGO_PRINT = 5
        STONE_BLUE_PROOF = 6
        STONE_BLUE_PRINT = 7
        NAVY_BLUE_PROOF = 8
        NAVY_BLUE_PRINT = 9
        AQUATIC_BLUE_PROOF = 10
        AQUATIC_BLUE_PRINT = 11
        INDIGO_BLUE_PROOF = 12
        INDIGO_BLUE_PRINT = 13
        CAROLINA_BLUE_PROOF = 14
        CAROLINA_BLUE_PRINT = 15
        IRIS_PROOF = 16
        IRIS_PRINT = 17
        VIOLET_PROOF = 18
        VIOLET_PRINT = 19
        LT_BLUE_PROOF = 20
        LT_BLUE_PRINT = 21
        HEATHER_MILITARY_PROOF = 22
        HEATHER_MILITARY_PRINT = 23
        STONEWASHED_GREEN_PROOF = 24
        STONEWASHED_GREEN_PRINT = 25
        MILITARY_GREEN_PROOF = 26
        MILITARY_GREEN_PRINT = 27
        FOREST_GREEN_PROOF = 28
        FOREST_GREEN_PRINT = 29
        PISTACHIO_PROOF = 30
        PISTACHIO_PRINT = 31
        ROYAL_BLUE_PROOF = 32
        ROYAL_BLUE_PRINT = 33
        PURPLE_PROOF = 34
        PURPLE_PRINT = 35
        JADE_DOME_PROOF = 36
        JADE_DOME_PRINT = 37
        COBALT_PROOF = 38
        COBALT_PRINT = 39
        SAPPHIRE_PROOF = 40
        SAPPHIRE_PRINT = 41
        BLUE_DUSK_PROOF = 42
        BLUE_DUSK_PRINT = 43
        CARDINAL_RED_PROOF = 44
        CARDINAL_RED_PRINT = 45
        RED_PROOF = 46
        RED_PRINT = 47
        HEATHER_RED_PROOF = 48
        HEATHER_RED_PRINT = 49
        HEATHER_CARDINAL_PROOF = 50
        HEATHER_CARDINAL_PRINT = 51
        HELICONIA_PROOF = 52
        HELICONIA_PRINT = 53
        LT_PINK_PROOF = 54
        LT_PINK_PRINT = 55
        LAVENDER_PROOF = 56
        LAVENDER_PRINT = 57
        ORCHID_PROOF = 58
        ORCHID_PRINT = 59
        GARNET_PROOF = 60
        GARNET_PRINT = 61
        MAROON_PROOF = 62
        MAROON_PRINT = 63
        METRO_BLUE_PROOF = 64
        METRO_BLUE_PRINT = 65
        SANDY_PROOF = 66
        SANDY_PRINT = 67
        PRAIRIE_DUST_PROOF = 68
        PRAIRIE_DUST_PRINT = 69
        NATURAL_PROOF = 70
        NATURAL_PRINT = 71
        DARK_CHOCOLATE_PROOF = 72
        DARK_CHOCOLATE_PRINT = 73
        SAND_PROOF = 74
        SAND_PRINT = 75
        BROWN_SAVANA_PROOF = 76
        BROWN_SAVANA_PRINT = 77
        CHESTNUT_PROOF = 78
        CHESTNUT_PRINT = 79
        HEATHER_DARK_CHOCOLATE_PROOF = 80
        HEATHER_DARK_CHOCOLATE_PRINT = 81
        IRISH_GREEN_PROOF = 82
        IRISH_GREEN_PRINT = 83
        HEATHER_FOREST_PROOF = 84
        HEATHER_FOREST_PRINT = 85
        ANTIQUE_JADE_DOME_PROOF = 86
        ANTIQUE_JADE_DOME_PRINT = 87
        CHARCOAL_PROOF = 88
        CHARCOAL_PRINT = 89
        SPORTS_GREY_PROOF = 90
        SPORTS_GREY_PRINT = 91
        KIWI_PROOF = 92
        KIWI_PRINT = 93
        ANTIQUE_SAPPHIRE_PROOF = 94
        ANTIQUE_SAPPHIRE_PRINT = 95
        GRAPHITE_HEATHER_PROOF = 96
        GRAPHITE_HEATHER_PRINT = 97
        BLACKBERRY_PROOF = 98
        BLACKBERRY_PRINT = 99
        MIDNIGHT_PROOF = 100
        MIDNIGHT_PRINT = 101
        HONEY_PROOF = 102
        HONEY_PRINT = 103
        DAFFODIL_PROOF = 104
        DAFFODIL_PRINT = 105
        DAISY_PROOF = 106
        DAISY_PRINT = 107
        TEXAS_ORANGE_PROOF = 108
        TEXAS_ORANGE_PRINT = 109
        ANTIQUE_ORANGE_PRINT = 110
        ANTIQUE_ORANGE_PROOF = 111
        ANTIQUE_CHERRY_PRINT = 112
        ANTIQUE_CHERRY_PROOF = 113
        ORANGE_PRINT = 114
        ORANGE_PROOF = 115

    End Enum

    Public Function GetPointSampleColorFromShirtColorFile(ByRef app As Application, ByVal MugColor As MUG_COLOR) As ColorSampler

    End Function

    'Define the x And y coordinates for the pixel to sample.
    Dim x As Integer = 1
    Dim y As Integer = 1

    'Add a Color Sampler at a given x And y coordinate in the image.
    Dim pointSample As ColorSampler = app.activeDocument.colorSamplers.add([(x - 1),(y - 1)])

    'Obtain array of RGB values.
    'var rgb = [
    '    pointSample.color.rgb.red,
    '    pointSample.color.rgb.green,
    '    pointSample.color.rgb.blue
    '];

    'Obtain array of rounded CMYK values.
    'var cmyk = [
    '    Math.round(pointSample.color.cmyk.cyan),
    '    Math.round(pointSample.color.cmyk.magenta), 
    '    Math.round(pointSample.color.cmyk.yellow),
    '    Math.round(pointSample.color.cmyk.black)
    '];

    'Remove the Color Sampler.
    'pointSample.remove();

    'Display the complete RGB values And each component color.
    'alert('RGB: ' + rgb)
    'alert('red: ' + rgb[0])
    'alert('green: ' + rgb[1])
    'alert('blue: ' + rgb[2])

    'Display the complete CMYK values And each component color.
    'alert('CMYK: ' + cmyk)
    'alert('cyan: ' + cmyk[0])
    'alert('magenta: ' + cmyk[1])
    'alert('yellow: ' + cmyk[2])
    'alert('black: ' + cmyk[3])

End Class
