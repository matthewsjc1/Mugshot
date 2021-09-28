﻿Imports Photoshop
Imports System.IO

Public Class Form1

    'directory name constants
    Private Const BACKGROUND_TEMPLATES_DIRECTORY As String = "background_templates"
    Private Const MOCK_UP_TEMPLATES_DIRECTORY As String = "mock_up_templates"
    Private Const PREVIEW_IMAGES_DIRECTORY As String = "preview_images"

    'layer name constants
    Private Const LEFT_ARTWORK_LAYER_NAME As String = "Left Artwork"
    Private Const RIGHT_ARTWORK_LAYER_NAME As String = "Right Artwork"
    Private Const WRAP_ARTWORK_LAYER_NAME As String = "Wrap Artwork"
    Private Const PROOF_LAYER_NAME As String = "Proof Color"
    Private Const PRINT_LAYER_NAME As String = "Print Color"
    Private Const OVERLAY_LAYER_NAME As String = "Shading Overlay"

    'preview image constants
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
    Private artFileDoc As Document
    Private artFileNameNoEx As String = ""
    Private artFilePath As String = ""
    Private saveFolderPath As String = ""
    Private sourceArtLayer As New easyPhotoshopArtLayer
    Private wrapLeftSourceArtLayer As New easyPhotoshopArtLayer
    Private wrapRightSourceArtLayer As New easyPhotoshopArtLayer
    Private leftArtLayer As New easyPhotoshopArtLayer
    Private rightArtLayer As New easyPhotoshopArtLayer
    Private wrapArtLayer As New easyPhotoshopArtLayer
    Private proofArtLayer As New easyPhotoshopArtLayer
    Private printArtLayer As New easyPhotoshopArtLayer
    Private mockupBaseArtLayer As New easyPhotoshopArtLayer
    Private mockupLeftArtLayer As New easyPhotoshopArtLayer
    Private mockupRightArtLayer As New easyPhotoshopArtLayer
    Private overlayArtLayer As New easyPhotoshopArtLayer

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

        updateClient.StartAutoUpdater()

        updateClient.WaitForClientMessage()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        artFileOpenDialog.InitialDirectory = "\\ARTSERVER\Textile-Misc\Textile Files\In Progress & Ideas"

        SetPreviewImage(PREVIEW_IMAGE_BLANK_MUG)

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click

        If selectedColors.Count > 0 Then

            If artFilePath.Length > 0 Then

                If saveFolderPath.Length > 0 Then

                    Try 'attempt to open photoshop, process, and save files

                        progressForm.Reset()
                        progressForm.TopMost = True
                        progressForm.Show()

                        Dim colorCount As Integer = selectedColors.Count
                        Dim maxProgressIntervals As Integer = 3 + (colorCount * 7) '3 increments before color loop; 7 increments per color
                        progressForm.SetProgressBarMaxValue(maxProgressIntervals)

                        Try

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Linking to Photoshop COM")
                            progressForm.Invalidate()

                            psApp = CreateObject("Photoshop.Application") 'start photoshop
                            psApp.DisplayDialogs = PsDialogModes.psDisplayNoDialogs 'turn off dialog boxes showing
                            psApp.Visible = Not hidePhotoshopCheckbox.Checked

                            If hidePhotoshopCheckbox.Checked = False Then

                                Try

                                    System.Diagnostics.Process.Start(psApp.Path + "Photoshop.exe")

                                Catch ex As Exception

                                End Try

                            End If

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                        Catch ex As Exception

                            MessageBox.Show("Mugshot wasn't able to start Photoshop." + vbCrLf + "Make sure a copy of Photoshop 2021 is installed!" +
            vbCrLf + "Error details:" + vbCrLf + ex.Message + vbCrLf + ex.StackTrace, "Problem Opening Photoshop")

                        End Try

                        'UPDATE PROGRESS FORM**************************
                        progressForm.SetCurrentTaskText("Setting temporary preferences")
                        progressForm.Invalidate()

                        Dim previousUnitPreference As Photoshop.PsUnits = psApp.Preferences.RulerUnits
                        psApp.Preferences.RulerUnits = Photoshop.PsUnits.psPixels

                        'UPDATE PROGRESS FORM**************************
                        progressForm.IncrementProgressBar(1)
                        progressForm.Invalidate()

                        'UPDATE PROGRESS FORM**************************
                        progressForm.SetCurrentTaskText("Processing art file")
                        progressForm.Invalidate()

                        If Path.GetExtension(artFilePath) = ".ai" Then 'if illustrator file selected

                            Dim openOptions As New PDFOpenOptions
                            openOptions.ConstrainProportions = True
                            openOptions.Mode = PsOpenDocumentMode.psOpenRGB
                            artFileDoc = psApp.Open(artFilePath, openOptions, True) 'open chosen art file
                            artFileDoc.Trim(PsTrimType.psTransparentPixels, True, True, True, True)
                            Dim originalWidth As Double = artFileDoc.Width()
                            Dim originalHeight As Double = artFileDoc.Height()
                            sourceArtLayer.SetArtLayer(artFileDoc.ActiveLayer)

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
                                sourceArtLayer.SetArtLayer(artFileDoc.ActiveLayer)
                                artFileDoc.BackgroundLayer.Visible = False

                            Catch ex As Exception

                                artFileDoc.Close(PsSaveOptions.psDoNotSaveChanges)
                                psApp.Quit()

                                progressForm.Reset()
                                progressForm.Hide()

                                MessageBox.Show("For some reason Mugshot doesn't like this Photoshop file." + vbCrLf + vbCrLf +
                                                "Email jmatthews@earthsunmoon.com for further assistance." + vbCrLf +
                                                "Please mention this error and include a link to the Photoshop file you selected.", "Issue with Photoshop File")

                            End Try

                        End If

                        'UPDATE PROGRESS FORM**************************
                        progressForm.IncrementProgressBar(1)
                        progressForm.Invalidate()

                        Dim overlayFilePath As String = AppContext.BaseDirectory + MOCK_UP_TEMPLATES_DIRECTORY + "\overlay.psd"
                        Dim overlayDoc As Document = psApp.Open(overlayFilePath)

                        'UPDATE PROGRESS FORM**************************
                        progressForm.SetCurrentTaskText("Open templates")
                        progressForm.Invalidate()

                        For curColorIndex As Integer = 0 To selectedColors.Count - 1 'loop through each color

                            Dim curColor As colorSelector = selectedColors.Item(curColorIndex)

                            'figure out current template name and assign it to curTemplateFilePath
                            Dim curTemplateFilePath As String = ""
                            If SmoothRadBtn.Checked = True Then

                                curTemplateFilePath = BACKGROUND_TEMPLATES_DIRECTORY + "\" + "smooth_" + curColor.GetColorName() + ".psd"

                            ElseIf roughRadBtn.Checked = True Then

                                curTemplateFilePath = BACKGROUND_TEMPLATES_DIRECTORY + "\" + "rough_" + curColor.GetColorName() + ".psd"

                            End If

                            Dim curMugTemplateDoc As Document = psApp.Open(AppContext.BaseDirectory + "\" + curTemplateFilePath) 'open template for current mug color

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            'MUG TEMPLATE SECTION**************************************************************************
                            '**********************************************************************************************

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Processing current color template")
                            progressForm.Invalidate()

                            psApp.ActiveDocument = artFileDoc
                            sourceArtLayer.CopyToClipboard(True)

                            'go to current mug template document and paste artwork
                            psApp.ActiveDocument = curMugTemplateDoc
                            proofArtLayer.SetArtLayer(curMugTemplateDoc.ArtLayers.Item("Layer 1"))
                            printArtLayer.SetArtLayer(curMugTemplateDoc.ArtLayers.Item("Layer 2"))
                            curMugTemplateDoc.ActiveLayer = proofArtLayer.GetArtLayer()

                            If twoImageRadBtn.Checked = True Then

                                leftArtLayer.SetArtLayer(curMugTemplateDoc.Paste())

                                'LEFT ARTWORK: W: 826 px, H: 981 px, CENTER POS: 695, 582 px
                                leftArtLayer.ScaleUniformlyToFitDimensions(826, 981)
                                leftArtLayer.MoveCenterToPosition(695, 582)

                                'RIGHT ARTWORK: W: 826 px, H: 981 px, CENTER POS: 2196, 582 px
                                rightArtLayer.SetArtLayer(leftArtLayer.Duplicate(curMugTemplateDoc, PsElementPlacement.psPlaceAtBeginning))
                                rightArtLayer.MoveCenterToPosition(2196, 582)

                                'set layers to final names
                                proofArtLayer.SetName(PROOF_LAYER_NAME)
                                printArtLayer.SetName(PRINT_LAYER_NAME)
                                leftArtLayer.SetName(LEFT_ARTWORK_LAYER_NAME)
                                rightArtLayer.SetName(RIGHT_ARTWORK_LAYER_NAME)

                            ElseIf horWrapRadBtn.Checked = True Then

                                wrapArtLayer.SetArtLayer(curMugTemplateDoc.Paste())

                                'WRAP ARTWORK: W: 2326 px, H: 981 px, TOP-LEFT POS: 282, 92 px, CENTER POS: 1446, 582
                                wrapArtLayer.ScaleUniformlyToFitDimensions(2326, 981)
                                wrapArtLayer.MoveCenterToPosition(1446, 582)

                                'set layers to final names
                                proofArtLayer.SetName(PROOF_LAYER_NAME)
                                printArtLayer.SetName(PRINT_LAYER_NAME)
                                wrapArtLayer.SetName(WRAP_ARTWORK_LAYER_NAME)

                            End If

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Saving TO PRINT file")
                            progressForm.Invalidate()

                            'save '_TO_PRINT' tif
                            proofArtLayer.SetVisibilityToOff()
                            printArtLayer.SetVisibilityToOn()
                            Dim tifFilePath As String = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_MUG_TO_PRINT.tif"
                            Dim tifOptions As New TiffSaveOptions
                            tifOptions.AlphaChannels = True
                            tifOptions.ByteOrder = PsByteOrderType.psIBMByteOrder
                            tifOptions.ImageCompression = PsTiffEncodingType.psNoTIFFCompression
                            tifOptions.EmbedColorProfile = True
                            curMugTemplateDoc.SaveAs(tifFilePath, tifOptions)

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Saving MUG file")
                            progressForm.Invalidate()

                            'save '_MUG' psd
                            proofArtLayer.SetVisibilityToOn()
                            printArtLayer.SetVisibilityToOn()

                            Dim psdFileName As String = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_MUG.psd"
                            curMugTemplateDoc.SaveAs(psdFileName)

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            curMugTemplateDoc.Close(PsSaveOptions.psDoNotSaveChanges) 'close current mug template

                            'END OF MUG TEMPLATE SECTION*******************************************************************
                            '**********************************************************************************************

                            'MOCK UP SECTION*******************************************************************************
                            '**********************************************************************************************

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Processing current color mock up")
                            progressForm.Invalidate()

                            'figure out current template name and assign it to curMockUpTemplatePath
                            Dim curMockUpTemplateFilePath As String = ""
                            If SmoothRadBtn.Checked = True Then

                                curMockUpTemplateFilePath = MOCK_UP_TEMPLATES_DIRECTORY + "\" + curColor.GetColorName() + "_smooth" + ".psd"

                            ElseIf roughRadBtn.Checked = True Then

                                curMockUpTemplateFilePath = MOCK_UP_TEMPLATES_DIRECTORY + "\" + curColor.GetColorName() + "_rough" + ".psd"

                            End If

                            Dim curMockUpDoc As Document = psApp.Open(AppContext.BaseDirectory + curMockUpTemplateFilePath) 'open mock up template for current mug color

                            If twoImageRadBtn.Checked Then

                                psApp.ActiveDocument = artFileDoc
                                sourceArtLayer.CopyToClipboard(True)
                                psApp.ActiveDocument = curMockUpDoc
                                mockupBaseArtLayer.SetArtLayer(curMockUpDoc.ArtLayers.Item("Layer 1"))
                                curMockUpDoc.ActiveLayer = mockupBaseArtLayer.GetArtLayer()
                                mockupLeftArtLayer.SetArtLayer(curMockUpDoc.Paste())

                                'LEFT ARTWORK: W: 900 px, H: 1072 px, CENTER POS: 1015, 900 px
                                mockupLeftArtLayer.ScaleUniformlyToFitDimensions(900, 1072)
                                mockupLeftArtLayer.MoveCenterToPosition(1015, 900)

                                'RIGHT ARTWORK: W: 900 px, H: 1072 px, CENTER POS: 2162, 900 px
                                mockupRightArtLayer.SetArtLayer(mockupLeftArtLayer.Duplicate(curMockUpDoc, PsElementPlacement.psPlaceAtBeginning))
                                mockupRightArtLayer.MoveCenterToPosition(2162, 900)

                            ElseIf horWrapRadBtn.Checked Then

                                'WRAP LEFT ARTWORK: W: 942 px, H: 1072 px, MUG CENTER-RIGHT POS: 1489, 900
                                psApp.ActiveDocument = artFileDoc
                                Dim leftArtDoc As Document = artFileDoc.Duplicate("Left Art Doc", False)
                                psApp.ActiveDocument = leftArtDoc
                                leftArtDoc.Trim(PsTrimType.psTransparentPixels, True, True, True, True)
                                leftArtDoc.ResizeCanvas(leftArtDoc.Width / 2, leftArtDoc.Height, PsAnchorPosition.psMiddleLeft)
                                wrapLeftSourceArtLayer.SetArtLayer(leftArtDoc.ActiveLayer)
                                wrapLeftSourceArtLayer.CopyToClipboard(True)
                                psApp.ActiveDocument = curMockUpDoc
                                mockupLeftArtLayer.SetArtLayer(curMockUpDoc.Paste())
                                mockupLeftArtLayer.ScaleUniformlyToFitDimensions(942, 1072) 'fit left half of design to left mug
                                mockupLeftArtLayer.MoveRightCenterToPosition(1489, 900) 'move to center right

                                leftArtDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                                'WRAP RIGHT ARTWORK: W: 942 px, H: 1072 px, MUG CENTER-LEFT POS: 1695, 900
                                psApp.ActiveDocument = artFileDoc
                                Dim rightArtDoc As Document = artFileDoc.Duplicate("Right Art Doc", False)
                                psApp.ActiveDocument = rightArtDoc
                                rightArtDoc.Trim(PsTrimType.psTransparentPixels, True, True, True, True)
                                rightArtDoc.ResizeCanvas(rightArtDoc.Width / 2, rightArtDoc.Height, PsAnchorPosition.psMiddleRight)
                                wrapRightSourceArtLayer.SetArtLayer(rightArtDoc.ActiveLayer)
                                wrapRightSourceArtLayer.CopyToClipboard(True)
                                psApp.ActiveDocument = curMockUpDoc
                                mockupRightArtLayer.SetArtLayer(curMockUpDoc.Paste())
                                mockupRightArtLayer.ScaleUniformlyToFitDimensions(942, 1072) 'fit right half of design to right mug
                                mockupRightArtLayer.MoveLeftCenterToPosition(1695, 900)

                                rightArtDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                            End If

                            'add shading overlay
                            psApp.ActiveDocument = overlayDoc
                            overlayArtLayer.SetArtLayer(overlayDoc.ArtLayers.Item("Layer 1"))
                            overlayArtLayer.CopyToClipboard(True)
                            psApp.ActiveDocument = curMockUpDoc
                            curMockUpDoc.ActiveLayer = mockupRightArtLayer.GetArtLayer()
                            overlayArtLayer.SetArtLayer(curMockUpDoc.Paste())
                            overlayArtLayer.SetBlendMode(PsBlendMode.psMultiply)

                            'set layers to final names
                            mockupLeftArtLayer.SetName(LEFT_ARTWORK_LAYER_NAME)
                            mockupRightArtLayer.SetName(RIGHT_ARTWORK_LAYER_NAME)
                            overlayArtLayer.SetName(OVERLAY_LAYER_NAME)

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Saving ON MUG jpg")
                            progressForm.Invalidate()

                            'save '_ON_MUG' mock up jpg
                            Dim jpgFileName As String = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_ON_MUG.jpg"
                            Dim jpgOptions As New JPEGSaveOptions
                            jpgOptions.Quality = 12
                            jpgOptions.EmbedColorProfile = True
                            curMockUpDoc.SaveAs(psdFileName, jpgOptions)

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            'UPDATE PROGRESS FORM**************************
                            progressForm.SetCurrentTaskText("Saving ON MUG psd")
                            progressForm.Invalidate()

                            'save '_ON_MUG' mock up psd
                            psdFileName = saveFolderPath + "\" + artFileNameNoEx + "_" + curColor.GetColorName() + "_ON_MUG.psd"
                            curMockUpDoc.SaveAs(psdFileName)

                            'UPDATE PROGRESS FORM**************************
                            progressForm.IncrementProgressBar(1)
                            progressForm.Invalidate()

                            curMockUpDoc.Close(PsSaveOptions.psDoNotSaveChanges)

                            'End Of MOCK UP SECTION************************************************************************
                            '**********************************************************************************************

                        Next 'move to next color

                        psApp.Preferences.RulerUnits = previousUnitPreference 'restore previous ruler units preference

                        'Close any open documents
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
