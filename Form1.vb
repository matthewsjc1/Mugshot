Imports Photoshop
Imports System.IO

Public Class Form1

    Private Const BACKGROUND_TEMPLATES_DIRECTORY As String = "background_templates"
    Private Const MOCK_UP_TEMPLATES_DIRECTORY As String = "mock_up_templates"
    Private Const PREVIEW_IMAGES_DIRECTORY As String = "preview_images"
    Private Const COPYRIGHT_TEMPLATE_DIRECTORY As String = "copyright_template"

    Private Const LEFT_ARTWORK_LAYER_NAME As String = "Left Artwork"
    Private Const RIGHT_ARTWORK_LAYER_NAME As String = "Right Artwork"
    Private Const WRAP_ARTWORK_LAYER_NAME As String = "Wrap Artwork"
    Private Const PROOF_LAYER_NAME As String = "Proof Color"
    Private Const PRINT_LAYER_NAME As String = "Print Color"
    Private Const OVERLAY_LAYER_NAME As String = "Shading Overlay"
    Private Const COPYRIGHT_LAYER_NAME As String = "Copyright Info"

    Private Const PREVIEW_IMAGE_BLANK_MUG As String = "blank_mug.png"
    Private Const PREVIEW_IMAGE_ROUGH_BACKGROUND_SELECTED As String = "rough_background_selected.png"
    Private Const PREVIEW_IMAGE_ROUGH_DESIGN_SELECTED As String = "rough_design_selected.png"
    Private Const PREVIEW_IMAGE_SMOOTH_BACKGROUND_SELECTED As String = "smooth_background_selected.png"
    Private Const PREVIEW_IMAGE_SMOOTH_DESIGN_SELECTED As String = "smooth_design_selected.png"
    Private Const PREVIEW_IMAGE_ROUGH_COLOR_SELECTED As String = "rough_background_color_selected.png"
    Private Const PREVIEW_IMAGE_SMOOTH_COLOR_SELECTED As String = "smooth_background_color_selected.png"
    Private Const PREVIEW_IMAGE_ROUGH_TWO_IMAGE_SELECTED As String = "rough_design_two_image_selected.png"
    Private Const PREVIEW_IMAGE_SMOOTH_TWO_IMAGE_SELECTED As String = "smooth_design_two_image_selected.png"
    Private Const PREVIEW_IMAGE_ROUGH_WRAP_SELECTED As String = "rough_design_wrap_selected.png"
    Private Const PREVIEW_IMAGE_SMOOTH_WRAP_SELECTED As String = "smooth_design_wrap_selected.png"

    Private psApp As Photoshop.Application

    Private selectedColors As New ArrayList()

    Private mugColorsSampler As New mugColorsSampler_class

    Private artFileDoc As Document
    Private overlayDoc As Document

    Private artFileNameNoEx As String = ""
    Private artFilePath As String = ""
    Private saveFolderPath As String = ""
    Private overlayFilePath As String = ""

    Private sourceEasyArtLayer As New easyPhotoshopArtLayer
    Private wrapLeftSourceEasyArtLayer As New easyPhotoshopArtLayer
    Private wrapRightSourceEasyArtLayer As New easyPhotoshopArtLayer
    Private copyrightSourceEasyArtLayer As New easyPhotoshopArtLayer
    Private leftEasyArtLayer As New easyPhotoshopArtLayer
    Private rightEasyArtLayer As New easyPhotoshopArtLayer
    Private wrapEasyArtLayer As New easyPhotoshopArtLayer
    Private proofEasyArtLayer As New easyPhotoshopArtLayer
    Private printEasyArtLayer As New easyPhotoshopArtLayer
    Private mockupBaseEasyArtLayer As New easyPhotoshopArtLayer
    Private mockupLeftEasyArtLayer As New easyPhotoshopArtLayer
    Private mockupRightEasyArtLayer As New easyPhotoshopArtLayer
    Private overlayEasyArtLayer As New easyPhotoshopArtLayer
    Private copyrightEasyArtLayer As New easyPhotoshopArtLayer
    Private mockUpTemplateEasyArtLayer As New easyPhotoshopArtLayer

    'PUBLIC ROUTINES=======================================================

    Public Sub UpdateSelectedColors(ByVal colorSourceArrayList As ArrayList)

        'copy colorsSourceArrayList to selectedColors
        selectedColors.Clear()

        For curIndex As Integer = 0 To colorSourceArrayList.Count - 1

            Dim curColor As colorSelector = colorSourceArrayList.Item(curIndex)
            selectedColors.Add(curColor)
        Next

        'update selColorsListBox
        selColorsListBox.Items.Clear()

        For curIndex As Integer = 0 To selectedColors.Count - 1

            Dim curColor As colorSelector = selectedColors.Item(curIndex)
            selColorsListBox.Items.Add(curColor.GetColorName())

        Next

    End Sub

    'PRIVATE ROUTINES=======================================================

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim updateClient As New autoUpdateClient

        Try

            updateClient.StartAutoUpdater()

        Catch ex As Exception

            WriteErrorLog("unable to start auto-updater")

        End Try

        Try

            updateClient.WaitForClientMessage()

        Catch ex As Exception

            WriteErrorLog("problem waiting for client message")

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WriteAppOpenedRecordToUsageRecords()

        artFileOpenDialog.InitialDirectory = "\\ARTSERVER\Textile-Misc\Textile Files\In Progress & Ideas"

        SetPreviewImage(PREVIEW_IMAGE_BLANK_MUG)

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click

        If selectedColors.Count > 0 Then

            If artFilePath.Length > 0 Then

                If saveFolderPath.Length > 0 Then

                    Try 'attempt to open photoshop, process, and save files

                        progressForm.Reset()
                        progressForm.Show()

                        Dim colorCount As Integer = selectedColors.Count
                        Dim maxProgressIntervals As Integer = 3 + (colorCount * 7) '3 increments before color loop; 7 increments per color
                        progressForm.SetProgressBarMaxValue(maxProgressIntervals)

                        Try

                            progressForm.SetCurrentTaskText("Linking to Photoshop COM")

                            psApp = CreateObject("Photoshop.Application") 'start photoshop
                            psApp.DisplayDialogs = PsDialogModes.psDisplayNoDialogs 'turn off dialog boxes showing
                            psApp.Visible = Not hidePhotoshopCheckbox.Checked

                            If hidePhotoshopCheckbox.Checked = False Then

                                Try

                                    System.Diagnostics.Process.Start(psApp.Path + "Photoshop.exe")

                                Catch ex As Exception

                                End Try

                            End If

                            progressForm.IncrementProgressBar(1)

                        Catch ex As Exception

                            WriteErrorLog("failed to start photoshop")

                            MessageBox.Show("Mugshot wasn't able to start Photoshop." + vbCrLf + "Make sure a copy of Photoshop 2021 is installed!" +
                                            vbCrLf + "Error details:" + vbCrLf + ex.Message + vbCrLf + ex.StackTrace, "Problem Opening Photoshop")

                        End Try

                        progressForm.SetCurrentTaskText("Setting temporary preferences")

                        Dim previousUnitPreference As Photoshop.PsUnits = psApp.Preferences.RulerUnits
                        psApp.Preferences.RulerUnits = Photoshop.PsUnits.psPixels

                        progressForm.IncrementProgressBar(1)
                        progressForm.SetCurrentTaskText("Processing art file")

                        If Path.GetExtension(artFilePath) = ".ai" Then 'if illustrator file selected

                            Dim openOptions As New PDFOpenOptions
                            openOptions.ConstrainProportions = True
                            openOptions.Mode = PsOpenDocumentMode.psOpenRGB
                            artFileDoc = psApp.Open(artFilePath, openOptions, True) 'open chosen art file
                            artFileDoc.Trim(PsTrimType.psTransparentPixels, True, True, True, True)
                            Dim originalWidth As Double = artFileDoc.Width()
                            Dim originalHeight As Double = artFileDoc.Height()
                            sourceEasyArtLayer.SetArtLayer(artFileDoc.ActiveLayer)

                        ElseIf Path.GetExtension(artFilePath) = ".psd" Then 'if illustrator file used

                            artFileDoc = psApp.Open(artFilePath) 'open chosen art file
                            psApp.ActiveDocument = artFileDoc
                            Dim originalWidth As Double = artFileDoc.Width()
                            Dim originalHeight As Double = artFileDoc.Height()
                            artFileDoc.Selection.SelectAll()

                            Try

                                artFileDoc.Selection.Copy(True)
                                artFileDoc.Close(PsSaveOptions.psDoNotSaveChanges)
                                artFileDoc = psApp.Documents.Add(originalWidth, originalHeight, 300, "artFileDoc", PsNewDocumentMode.psNewRGB)
                                artFileDoc.Paste()
                                originalWidth = artFileDoc.Width()
                                originalHeight = artFileDoc.Height()
                                sourceEasyArtLayer.SetArtLayer(artFileDoc.ActiveLayer)
                                artFileDoc.BackgroundLayer.Visible = False

                            Catch ex As Exception

                                artFileDoc.Close(PsSaveOptions.psDoNotSaveChanges)
                                psApp.Quit()

                                progressForm.Reset()
                                progressForm.Hide()

                                WriteErrorLog("couldn't process .psd file - " + artFilePath)

                                MessageBox.Show("For some reason Mugshot doesn't like this Photoshop file." + vbCrLf + vbCrLf +
                                                "Email jmatthews@earthsunmoon.com for further assistance." + vbCrLf +
                                                "Please mention this error and include a link to the Photoshop file you selected.", "Issue with Photoshop File")

                            End Try

                        End If

                        progressForm.IncrementProgressBar(1)

                        progressForm.SetCurrentTaskText("Open templates")

                        For curColorIndex As Integer = 0 To selectedColors.Count - 1 'loop through each color

                            overlayFilePath = AppContext.BaseDirectory + MOCK_UP_TEMPLATES_DIRECTORY + "\overlay.psd"
                            overlayDoc = psApp.Open(overlayFilePath)

                            'BUG: CRASHING ON SECOND COLOR

                            Dim curColor As colorSelector = selectedColors.Item(curColorIndex)

                            'figure out current template name and assign it to curTemplateFilePath
                            Dim curTemplateFilePath As String = ""
                            If SmoothRadBtn.Checked = True Then

                                curTemplateFilePath = BACKGROUND_TEMPLATES_DIRECTORY + "\smooth_mug_template.psd"

                            ElseIf roughRadBtn.Checked = True Then

                                curTemplateFilePath = BACKGROUND_TEMPLATES_DIRECTORY + "\rough_mug_template.psd"

                            End If

                            Dim curMugTemplateDoc As Document = psApp.Open(AppContext.BaseDirectory + "\" + curTemplateFilePath) 'open template for current mug color

                            progressForm.IncrementProgressBar(1)

                            'MUG TEMPLATE SECTION**************************************************************************
                            '**********************************************************************************************

                            progressForm.SetCurrentTaskText("Processing current color template")

                            psApp.ActiveDocument = artFileDoc
                            sourceEasyArtLayer.CopyToClipboard(True)

                            'go to current mug template document and set it up
                            psApp.ActiveDocument = curMugTemplateDoc

                            proofEasyArtLayer.SetArtLayer(curMugTemplateDoc.ArtLayers.Item("Layer 1"))
                            printEasyArtLayer.SetArtLayer(curMugTemplateDoc.ArtLayers.Item("Layer 2"))

                            ChangeBackgroundTemplateBackgroundColor(curMugTemplateDoc, proofEasyArtLayer.GetArtLayer(), printEasyArtLayer.GetArtLayer(), curColor.GetColorName())

                            curMugTemplateDoc.ActiveLayer = proofEasyArtLayer.GetArtLayer()

                            If twoImageRadBtn.Checked = True Then

                                leftEasyArtLayer.SetArtLayer(curMugTemplateDoc.Paste())

                                'LEFT ARTWORK: W: 826 px, H: 981 px, CENTER POS: 695, 582 px
                                leftEasyArtLayer.ScaleUniformlyToFitDimensions(826, 981)
                                leftEasyArtLayer.MoveCenterToPosition(695, 582)

                                'RIGHT ARTWORK: W: 826 px, H: 981 px, CENTER POS: 2196, 582 px
                                rightEasyArtLayer.SetArtLayer(leftEasyArtLayer.Duplicate(curMugTemplateDoc, PsElementPlacement.psPlaceAtBeginning))
                                rightEasyArtLayer.MoveCenterToPosition(2196, 582)

                                'set layers to final names
                                proofEasyArtLayer.SetName(PROOF_LAYER_NAME)
                                printEasyArtLayer.SetName(PRINT_LAYER_NAME)
                                leftEasyArtLayer.SetName(LEFT_ARTWORK_LAYER_NAME)
                                rightEasyArtLayer.SetName(RIGHT_ARTWORK_LAYER_NAME)

                            ElseIf horWrapRadBtn.Checked = True Then

                                wrapEasyArtLayer.SetArtLayer(curMugTemplateDoc.Paste())
                                wrapEasyArtLayer.SetName(WRAP_ARTWORK_LAYER_NAME)

                                'WRAP ARTWORK: W: 2326 px, H: 981 px, TOP-LEFT POS: 282, 92 px, CENTER POS: 1446, 582
                                wrapEasyArtLayer.ScaleUniformlyToFitDimensions(2326, 981)
                                wrapEasyArtLayer.MoveCenterToPosition(1446, 582)

                            End If

                            'if copyright info is enabled, copy and paste copyright template on top
                            If copyrightEnabledRadBtn.Checked = True Then

                                Dim copyrightFilePath As String = AppContext.BaseDirectory + COPYRIGHT_TEMPLATE_DIRECTORY + "\copyright_template.psd"
                                Dim copyrightDoc As Document = psApp.Open(copyrightFilePath)

                                'copy and close
                                psApp.ActiveDocument = copyrightDoc
                                copyrightSourceEasyArtLayer.SetArtLayer(copyrightDoc.ActiveLayer)
                                copyrightSourceEasyArtLayer.CopyToClipboard(True)

                                copyrightDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                                'paste and reposition
                                psApp.ActiveDocument = curMugTemplateDoc
                                copyrightEasyArtLayer.SetArtLayer(curMugTemplateDoc.Paste())
                                copyrightEasyArtLayer.MoveCenterToPosition(74, 921)

                                'set copyright layer final name
                                copyrightEasyArtLayer.SetName(COPYRIGHT_LAYER_NAME)

                            End If

                            progressForm.IncrementProgressBar(1)
                            progressForm.SetCurrentTaskText("Saving TO PRINT file")

                            Try

                                'save '_TO_PRINT' tif
                                proofEasyArtLayer.SetVisibilityToOff()
                                printEasyArtLayer.SetVisibilityToOn()
                                Dim tifFilePath As String = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_MUG_TO_PRINT.tif"
                                Dim tifOptions As New TiffSaveOptions
                                tifOptions.AlphaChannels = True
                                tifOptions.ByteOrder = PsByteOrderType.psIBMByteOrder
                                tifOptions.ImageCompression = PsTiffEncodingType.psNoTIFFCompression
                                tifOptions.EmbedColorProfile = True
                                curMugTemplateDoc.SaveAs(tifFilePath, tifOptions)

                            Catch ex As Exception

                                WriteErrorLog("unable to save '_TO_PRINT' tif")

                                MessageBox.Show("Failed to save '_TO_PRINT' tif")

                            End Try

                            progressForm.IncrementProgressBar(1)
                            progressForm.SetCurrentTaskText("Saving MUG file")

                            Try

                                'save '_MUG' psd
                                proofEasyArtLayer.SetVisibilityToOn()
                                printEasyArtLayer.SetVisibilityToOn()

                            Catch ex As Exception

                                WriteErrorLog("unable to save '_MUG' psd")

                                MessageBox.Show("Failed to save '_MUG' psd")

                            End Try

                            Dim psdFileName As String = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_MUG.psd"
                            curMugTemplateDoc.SaveAs(psdFileName)

                            progressForm.IncrementProgressBar(1)

                            curMugTemplateDoc.Close(PsSaveOptions.psDoNotSaveChanges) 'close current mug template

                            'END OF MUG TEMPLATE SECTION*******************************************************************
                            '**********************************************************************************************

                            'MOCK UP SECTION*******************************************************************************
                            '**********************************************************************************************

                            progressForm.SetCurrentTaskText("Processing current color mock up")

                            'figure out current template name and assign it to curMockUpTemplatePath
                            Dim curMockUpTemplateFilePath As String = ""
                            If SmoothRadBtn.Checked = True Then

                                curMockUpTemplateFilePath = MOCK_UP_TEMPLATES_DIRECTORY + "\smooth_mockup_template.psd"

                            ElseIf roughRadBtn.Checked = True Then

                                curMockUpTemplateFilePath = MOCK_UP_TEMPLATES_DIRECTORY + "\rough_mockup_template.psd"

                            End If

                            Dim curMockUpDoc As Document = psApp.Open(AppContext.BaseDirectory + curMockUpTemplateFilePath) 'open mock up template for current mug color

                            mockupBaseEasyArtLayer.SetArtLayer(curMockUpDoc.ArtLayers.Item("Layer 1"))

                            ChangeMockUpTemplateBackgroundColor(curMockUpDoc, mockupBaseEasyArtLayer.GetArtLayer(), curColor.GetColorName())

                            If twoImageRadBtn.Checked Then

                                psApp.ActiveDocument = artFileDoc
                                sourceEasyArtLayer.CopyToClipboard(True)
                                psApp.ActiveDocument = curMockUpDoc
                                mockupBaseEasyArtLayer.SetArtLayer(curMockUpDoc.ArtLayers.Item("Layer 1"))
                                curMockUpDoc.ActiveLayer = mockupBaseEasyArtLayer.GetArtLayer()
                                mockupLeftEasyArtLayer.SetArtLayer(curMockUpDoc.Paste())

                                'LEFT ARTWORK: W: 900 px, H: 1072 px, CENTER POS: 1015, 900 px
                                mockupLeftEasyArtLayer.ScaleUniformlyToFitDimensions(900, 1072)
                                mockupLeftEasyArtLayer.MoveCenterToPosition(1015, 900)

                                'RIGHT ARTWORK: W: 900 px, H: 1072 px, CENTER POS: 2162, 900 px
                                mockupRightEasyArtLayer.SetArtLayer(mockupLeftEasyArtLayer.Duplicate(curMockUpDoc, PsElementPlacement.psPlaceAtBeginning))
                                mockupRightEasyArtLayer.MoveCenterToPosition(2162, 900)

                            ElseIf horWrapRadBtn.Checked Then

                                'WRAP LEFT ARTWORK: W: 942 px, H: 1072 px, MUG CENTER-RIGHT POS: 1489, 900
                                psApp.ActiveDocument = artFileDoc
                                Dim leftArtDoc As Document = artFileDoc.Duplicate("Left Art Doc", False)
                                psApp.ActiveDocument = leftArtDoc
                                leftArtDoc.Trim(PsTrimType.psTransparentPixels, True, True, True, True)
                                leftArtDoc.ResizeCanvas(leftArtDoc.Width / 2, leftArtDoc.Height, PsAnchorPosition.psMiddleLeft)
                                wrapLeftSourceEasyArtLayer.SetArtLayer(leftArtDoc.ActiveLayer)
                                wrapLeftSourceEasyArtLayer.CopyToClipboard(True)
                                psApp.ActiveDocument = curMockUpDoc
                                mockupLeftEasyArtLayer.SetArtLayer(curMockUpDoc.Paste())
                                mockupLeftEasyArtLayer.ScaleUniformlyToFitDimensions(942, 1072) 'fit left half of design to left mug
                                mockupLeftEasyArtLayer.MoveRightCenterToPosition(1489, 900) 'move to center right

                                leftArtDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                                'WRAP RIGHT ARTWORK: W: 942 px, H: 1072 px, MUG CENTER-LEFT POS: 1695, 900
                                psApp.ActiveDocument = artFileDoc
                                Dim rightArtDoc As Document = artFileDoc.Duplicate("Right Art Doc", False)
                                psApp.ActiveDocument = rightArtDoc
                                rightArtDoc.Trim(PsTrimType.psTransparentPixels, True, True, True, True)
                                rightArtDoc.ResizeCanvas(rightArtDoc.Width / 2, rightArtDoc.Height, PsAnchorPosition.psMiddleRight)
                                wrapRightSourceEasyArtLayer.SetArtLayer(rightArtDoc.ActiveLayer)
                                wrapRightSourceEasyArtLayer.CopyToClipboard(True)
                                psApp.ActiveDocument = curMockUpDoc
                                mockupRightEasyArtLayer.SetArtLayer(curMockUpDoc.Paste())
                                mockupRightEasyArtLayer.ScaleUniformlyToFitDimensions(942, 1072) 'fit right half of design to right mug
                                mockupRightEasyArtLayer.MoveLeftCenterToPosition(1695, 900)

                                rightArtDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                            End If

                            'add shading overlay
                            psApp.ActiveDocument = overlayDoc
                            overlayEasyArtLayer.SetArtLayer(overlayDoc.ArtLayers.Item("Layer 1"))
                            overlayEasyArtLayer.CopyToClipboard(True)
                            psApp.ActiveDocument = curMockUpDoc
                            curMockUpDoc.ActiveLayer = mockupRightEasyArtLayer.GetArtLayer()
                            overlayEasyArtLayer.SetArtLayer(curMockUpDoc.Paste())
                            overlayEasyArtLayer.SetBlendMode(PsBlendMode.psMultiply)

                            'set layers to final names
                            mockupLeftEasyArtLayer.SetName(LEFT_ARTWORK_LAYER_NAME)
                            mockupRightEasyArtLayer.SetName(RIGHT_ARTWORK_LAYER_NAME)
                            overlayEasyArtLayer.SetName(OVERLAY_LAYER_NAME)

                            progressForm.IncrementProgressBar(1)
                            progressForm.SetCurrentTaskText("Saving ON MUG jpg")

                            Try

                                'save '_ON_MUG' mock up jpg
                                Dim jpgFileName As String = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_ON_MUG.jpg"
                                Dim jpgOptions As New JPEGSaveOptions
                                jpgOptions.Quality = 12
                                jpgOptions.EmbedColorProfile = True
                                curMockUpDoc.SaveAs(psdFileName, jpgOptions)

                                WriteSuccessfulRunRecordToUsageRecords()

                            Catch ex As Exception

                                WriteErrorLog("unable to save '_ON_MUG' jpg")

                                MessageBox.Show("Failed to save '_ON_MUG' jpg")

                            End Try


                            progressForm.IncrementProgressBar(1)
                            progressForm.SetCurrentTaskText("Saving ON MUG psd")

                            'save '_ON_MUG' mock up psd
                            psdFileName = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_ON_MUG.psd"
                            curMockUpDoc.SaveAs(psdFileName)
                            curMockUpDoc.Close(PsSaveOptions.psDoNotSaveChanges)
                            progressForm.IncrementProgressBar(1)


                            'End Of MOCK UP SECTION************************************************************************
                            '**********************************************************************************************

                        Next 'move to next color

                        psApp.Preferences.RulerUnits = previousUnitPreference 'restore previous ruler units preference

                        'Close last of open documents
                        artFileDoc.Close(PsSaveOptions.psDoNotSaveChanges)
                        overlayDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                        progressForm.Hide()

                        'open the save folder in file explorer
                        Process.Start("explorer.exe", saveFolderPath)

                    Catch ex As Exception 'catch failure of opening photoshop, processing, and saving files

                        MessageBox.Show("An error occurred while processing files." + vbCrLf + "Error details:" + vbCrLf + ex.Message, "Processing Error")

                        If hidePhotoshopCheckbox.Checked = True Then

                            psApp.Quit()

                        End If

                    End Try

                Else 'if no save folder was selected

                    MessageBox.Show("Please select a save folder!", "Save Folder Error")

                End If

            Else 'if no art file was selected

                MessageBox.Show("Please select an art file!", "Art File Error")

            End If

        Else 'if no background colors were selected

            MessageBox.Show("Please select at least one background color!", "Background Color Error")

        End If

        If hidePhotoshopCheckbox.Checked = True Then

            psApp.Quit()

        End If

        Me.Activate() 'bring Mugshot back to foreground

    End Sub

    Private Sub ChangeBackgroundTemplateBackgroundColor(ByRef doc As Document, ByRef proofLayer As ArtLayer, ByRef printLayer As ArtLayer, ByVal colorName As String)

        Dim previouslyActiveDoc As Document = psApp.ActiveDocument
        Dim previouslyActiveLayer As ArtLayer = psApp.ActiveDocument.ActiveLayer

        Dim mugColorsSampler As New mugColorsSampler_class

        Dim proofColor As RGBColor = mugColorsSampler.GetRGBColorFromShirtColors_NEWFile(psApp, colorName + "_proof", False)
        Dim printColor As RGBColor = mugColorsSampler.GetRGBColorFromShirtColors_NEWFile(psApp, colorName + "_print", True)

        psApp.ActiveDocument = doc

        doc.ActiveLayer = proofLayer
        MakeSelection(doc, 500, 500, 100, 100)
        doc.Selection.Grow(10, True)
        doc.Selection.Fill(proofColor)
        doc.Selection.Deselect()
        proofLayer.Visible = False

        doc.ActiveLayer = printLayer
        MakeSelection(doc, 500, 500, 100, 100)
        doc.Selection.Grow(10, True)
        doc.Selection.Fill(printColor)
        doc.Selection.Deselect()

        proofLayer.Visible = True
        doc.ActiveLayer = proofLayer

        psApp.ActiveDocument = previouslyActiveDoc
        previouslyActiveDoc.ActiveLayer = previouslyActiveLayer

    End Sub

    Private Sub ChangeMockUpTemplateBackgroundColor(ByRef doc As Document, ByRef templateLayer As ArtLayer, ByVal colorName As String)

        Dim previouslyActiveDoc As Document = psApp.ActiveDocument
        Dim previouslyActiveLayer As ArtLayer = psApp.ActiveDocument.ActiveLayer

        Dim mugColorsSampler As New mugColorsSampler_class

        Dim newColor As RGBColor = mugColorsSampler.GetRGBColorFromShirtColors_NEWFile(psApp, colorName + "_proof", True)

        psApp.ActiveDocument = doc

        'left mug
        doc.ActiveLayer = templateLayer
        MakeSelection(doc, 700, 500, 1000, 800)
        doc.Selection.Grow(10, True)
        doc.Selection.Fill(newColor)
        doc.Selection.Deselect()

        'right mug
        MakeSelection(doc, 2000, 500, 2300, 800)
        doc.Selection.Grow(10, True)
        doc.Selection.Fill(newColor)
        doc.Selection.Deselect()

        psApp.ActiveDocument = previouslyActiveDoc
        previouslyActiveDoc.ActiveLayer = previouslyActiveLayer

    End Sub

    Private Sub MakeSelection(ByRef doc As Document, ByVal left As Integer, ByVal top As Integer, ByVal right As Integer, ByVal bottom As Integer)

        Dim psArray1() As Object = {right, bottom}
        Dim psArray2() As Object = {left, bottom}
        Dim psArray3() As Object = {left, top}
        Dim psArray4() As Object = {right, top}

        Dim psArray() As Object = {psArray1, psArray2, psArray3, psArray4}

        doc.Selection.Select(psArray)

    End Sub

    Private Sub WriteAppOpenedRecordToUsageRecords()

        If My.Computer.Name = "ART-AB" = False Then  'don't make records for my work pc (avoid contaminating actual usage records)

            Try

                Dim curDateTime As String = DateTime.Now.ToString("yyyy-M-d @ H_m")
                File.Create("\\ARTSERVER\Working_Files\Jared\CUSTOM SOFTWARE\MUGSHOT\USAGE_RECORDS\" + "App Opened - " + curDateTime + ".ur")

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub WriteSuccessfulRunRecordToUsageRecords()

        If My.Computer.Name = "ART-AB" = False Then 'don't make records for my work pc (avoid contaminating actual usage records)

            Try

                Dim curDateTime As String = DateTime.Now.ToString("yyyy-M-d @ H_m")
                Dim usageFile As New StreamWriter("\\ARTSERVER\Working_Files\Jared\CUSTOM SOFTWARE\MUGSHOT\USAGE_RECORDS\" + "Template Made - " + curDateTime + ".ur")

                usageFile.WriteLine("ran in silent mode = " + hidePhotoshopCheckbox.Checked.ToString) 'was run in silent mode

                usageFile.Close()

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub WriteErrorLog(ByVal errorMessage As String)

        If My.Computer.Name = "ART-AB" = False Then 'don't make records for my work pc (avoid contaminating actual usage records)

            Try

                Dim curDateTime As String = DateTime.Now.ToString("yyyy-M-d @ H_m")
                Dim usageFile As New StreamWriter("\\ARTSERVER\Working_Files\Jared\CUSTOM SOFTWARE\MUGSHOT\USAGE_RECORDS\" + "ERROR OCCURRED! - " + curDateTime + ".ur")

                usageFile.WriteLine("mugshot error message = " + errorMessage)

                usageFile.WriteLine("stack trace = " + Environment.StackTrace) 'stack trace

                usageFile.Close()

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles roughPicBox.Click

        roughRadBtn.Checked = True

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles smoothPicBox.Click

        SmoothRadBtn.Checked = True

    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter

        SetPreviewImage(PREVIEW_IMAGE_BLANK_MUG)
        curSelImagePicBox.Invalidate()

    End Sub

    Private Sub roughPicBox_MouseEnter(sender As Object, e As EventArgs) Handles roughPicBox.MouseEnter

        SetPreviewImage(PREVIEW_IMAGE_ROUGH_BACKGROUND_SELECTED)
        curSelImagePicBox.Invalidate()

    End Sub

    Private Sub smoothPicBox_MouseEnter(sender As Object, e As EventArgs) Handles smoothPicBox.MouseEnter

        SetPreviewImage(PREVIEW_IMAGE_SMOOTH_BACKGROUND_SELECTED)
        curSelImagePicBox.Invalidate()

    End Sub

    Private Sub backOptionsGroupBox_MouseEnter(sender As Object, e As EventArgs) Handles backOptionsGroupBox.MouseEnter

        SetPreviewImage(PREVIEW_IMAGE_BLANK_MUG)
        curSelImagePicBox.Invalidate()

    End Sub

    Private Sub roughRadBtn_MouseEnter(sender As Object, e As EventArgs) Handles roughRadBtn.MouseEnter

        SetPreviewImage(PREVIEW_IMAGE_ROUGH_BACKGROUND_SELECTED)
        curSelImagePicBox.Invalidate()

    End Sub

    Private Sub SmoothRadBtn_MouseEnter(sender As Object, e As EventArgs) Handles SmoothRadBtn.MouseEnter

        SetPreviewImage(PREVIEW_IMAGE_SMOOTH_BACKGROUND_SELECTED)
        curSelImagePicBox.Invalidate()

    End Sub

    Private Sub colorsGroupBox_MouseEnter(sender As Object, e As EventArgs) Handles colorsGroupBox.MouseEnter

        If roughRadBtn.Checked Then

            SetPreviewImage(PREVIEW_IMAGE_ROUGH_COLOR_SELECTED)
            curSelImagePicBox.Invalidate()

        ElseIf SmoothRadBtn.Checked Then

            SetPreviewImage(PREVIEW_IMAGE_SMOOTH_COLOR_SELECTED)
            curSelImagePicBox.Invalidate()

        End If

    End Sub

    Private Sub artworkGroupBox_MouseEnter(sender As Object, e As EventArgs) Handles artworkGroupBox.MouseEnter

        If roughRadBtn.Checked Then

            SetPreviewImage(PREVIEW_IMAGE_ROUGH_DESIGN_SELECTED)
            curSelImagePicBox.Invalidate()

        ElseIf SmoothRadBtn.Checked Then

            SetPreviewImage(PREVIEW_IMAGE_SMOOTH_DESIGN_SELECTED)
            curSelImagePicBox.Invalidate()

        End If

    End Sub

    Private Sub twoImageRadBtn_MouseEnter(sender As Object, e As EventArgs) Handles twoImageRadBtn.MouseEnter

        If roughRadBtn.Checked = True Then

            SetPreviewImage(PREVIEW_IMAGE_ROUGH_TWO_IMAGE_SELECTED)
            curSelImagePicBox.Invalidate()

        ElseIf SmoothRadBtn.Checked = True Then

            SetPreviewImage(PREVIEW_IMAGE_SMOOTH_TWO_IMAGE_SELECTED)
            curSelImagePicBox.Invalidate()

        End If

    End Sub

    Private Sub wrapImageBtn_MouseEnter(sender As Object, e As EventArgs) Handles horWrapRadBtn.MouseEnter

        If roughRadBtn.Checked = True Then

            SetPreviewImage(PREVIEW_IMAGE_ROUGH_WRAP_SELECTED)
            curSelImagePicBox.Invalidate()

        ElseIf SmoothRadBtn.Checked = True Then

            SetPreviewImage(PREVIEW_IMAGE_SMOOTH_WRAP_SELECTED)
            curSelImagePicBox.Invalidate()

        End If

    End Sub

    Private Sub SetPreviewImage(ByVal imageName As String)

        Dim previewImageFilePath As String = AppContext.BaseDirectory + PREVIEW_IMAGES_DIRECTORY + "\" + imageName
        Dim previewImage As Image = Image.FromFile(previewImageFilePath)
        curSelImagePicBox.Image = previewImage

    End Sub

    Private Sub selColorsBtn_Click(sender As Object, e As EventArgs) Handles selColorsBtn.Click

        colorSelectionsForm.ShowDialog()

    End Sub

    Private Sub selArtFileBtn_Click(sender As Object, e As EventArgs) Handles selArtFileBtn.Click

        If artFileOpenDialog.ShowDialog() = DialogResult.OK Then

            artFilePath = artFileOpenDialog.FileName
            artFileNameNoEx = Path.GetFileNameWithoutExtension(artFilePath)
            artFileTextBox.Text = artFileNameNoEx

            If Path.GetExtension(artFilePath) <> ".ai" And Path.GetExtension(artFilePath) <> ".psd" Then

                MessageBox.Show("This file type is not supported yet." + vbCrLf + "If this file type is needed, please email jmatthews@earthsunmoon.com.")

            End If

        End If

    End Sub

    Private Sub selSaveFolderBtn_Click(sender As Object, e As EventArgs) Handles selSaveFolderBtn.Click

        Dim folderDialog As New FolderBrowserDialog

        If folderDialog.ShowDialog() = DialogResult.OK Then

            saveFolderPath = folderDialog.SelectedPath
            saveFolderTextBox.Text = saveFolderPath

        End If

    End Sub

End Class
