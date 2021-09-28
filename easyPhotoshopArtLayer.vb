Imports Photoshop

Public Class easyPhotoshopArtLayer

    Private aLayer As ArtLayer

    'public methods*****************************************************************************

    Public Sub SetArtLayer(ByRef layer As ArtLayer)

        aLayer = layer

    End Sub

    Public Function GetArtLayer() As ArtLayer

        Return aLayer

    End Function

    Public Sub TurnOffLock()

        aLayer.AllLocked = False

    End Sub

    Public Function GetLeftArtBound() As Integer

        Return aLayer.Bounds(0)

    End Function

    Public Function GetTopArtBound() As Integer

        Return aLayer.Bounds(1)

    End Function

    Public Function GetRightArtBound() As Integer

        Return aLayer.Bounds(2)

    End Function

    Public Function GetBottomArtBount() As Integer

        Return aLayer.Bounds(3)

    End Function

    Public Function GetArtWidth() As Integer

        Return GetRightArtBound() - GetLeftArtBound()

    End Function

    Public Function GetArtHeight() As Integer

        Return GetBottomArtBount() - GetTopArtBound()

    End Function

    Public Sub CopyToClipboard(ByVal copyAsMerged As Boolean)

        aLayer.Copy(copyAsMerged)

    End Sub

    Public Sub Resize(ByVal xScalePercentage As Double, ByVal yScalePercentage As Double, ByVal anchorPosition As PsAnchorPosition)

        aLayer.Resize(xScalePercentage, yScalePercentage, anchorPosition)

    End Sub

    Public Sub Translate(ByVal xMoveAmount As Double, ByVal yMoveAmount As Double)

        aLayer.Translate(xMoveAmount, yMoveAmount)

    End Sub

    Public Function Duplicate(ByRef targetDocument As Document, ByVal placement As PsElementPlacement) As ArtLayer

        Return aLayer.Duplicate(targetDocument, placement)

    End Function

    Public Function GetArtXCenterPosition() As Integer

        Return GetRightArtBound() - (GetArtWidth() / 2)

    End Function

    Public Function GetArtYCenterPosition() As Integer

        Return GetBottomArtBount() - (GetArtHeight() / 2)

    End Function

    Public Sub MoveCenterToPosition(ByVal xPosition As Integer, ByVal yPosition As Integer)

        Dim curLeftXPos As Integer = GetLeftArtBound()
        Dim curTopYPos As Integer = GetTopArtBound()

        Dim moveXAmount As Integer = (xPosition - curLeftXPos) - (GetArtWidth() / 2)
        Dim moveYAmount As Integer = (yPosition - curTopYPos) - (GetArtHeight() / 2)

        aLayer.Translate(moveXAmount, moveYAmount)

    End Sub

    Public Sub MoveRightCenterToPosition(ByVal xPosition As Integer, ByVal yPosition As Integer)

        Dim curRightXPos As Integer = GetRightArtBound()
        Dim curCenterYPos As Integer = GetBottomArtBount() - (GetArtHeight() / 2)

        Dim moveXAmount As Integer = -(curRightXPos - xPosition)
        Dim moveYAmount As Integer = -(curCenterYPos - yPosition)

        aLayer.Translate(moveXAmount, moveYAmount)

    End Sub

    Public Sub MoveLeftCenterToPosition(ByVal xPosition As Integer, ByVal yPosition As Integer)

        Dim curLeftXPos As Integer = GetLeftArtBound()
        Dim curCenterYPos As Integer = GetBottomArtBount() - (GetArtHeight() / 2)

        Dim moveXAmount As Integer = -(curLeftXPos - xPosition)
        Dim moveYAmount As Integer = -(curCenterYPos - yPosition)

        aLayer.Translate(moveXAmount, moveYAmount)

    End Sub

    Public Sub SetName(ByVal newName As String)

        aLayer.Name = newName

    End Sub

    Public Function GetName() As String

        Return aLayer.Name

    End Function

    Public Sub SetVisibilityToOff()

        aLayer.Visible = False

    End Sub

    Public Sub SetVisibilityToOn()

        aLayer.Visible = True

    End Sub

    Public Sub ScaleUniformlyToFitDimensions(ByVal maxWidth As Integer, ByVal maxHeight As Integer)

        Dim widthScalePercentage As Double
        Dim heightScalePercentage As Double

        'calculate how much width would need to scale to match maxWidth
        If GetArtWidth() > maxWidth Then

            widthScalePercentage = (maxWidth / GetArtWidth()) * 100

        Else

            widthScalePercentage = (GetArtWidth() / maxWidth) * 100

        End If

        'calculate how much height would need to scale to match maxHeight
        If GetArtHeight() > maxHeight Then

            heightScalePercentage = (maxHeight / GetArtHeight()) * 100

        Else

            heightScalePercentage = (GetArtHeight() / maxHeight) * 100

        End If

        'determine whether width or height scaling should be used for uniform scaling (scale to whichever scales the most - ie the smaller scale percentage)
        Dim uniformScalingPercentage As Double
        If widthScalePercentage > heightScalePercentage Or widthScalePercentage = heightScalePercentage Then

            uniformScalingPercentage = heightScalePercentage

        ElseIf heightScalePercentage > widthScalePercentage Then

            uniformScalingPercentage = widthScalePercentage

        End If

        aLayer.Resize(uniformScalingPercentage, uniformScalingPercentage, PsAnchorPosition.psTopLeft)

    End Sub

    Public Sub SetBlendMode(ByVal blendMode As PsBlendMode)

        aLayer.BlendMode = blendMode

    End Sub

    'private methods****************************************************************************

End Class
