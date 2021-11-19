Imports Photoshop

Public Class colorSelector

    Private PICTURE_BOX_UNSELECTED_COLOR As Color = color.Transparent
    Private PICTURE_BOX_SELECTED_COLOR As Color = color.LawnGreen

    Private picBox As PictureBox
    Private isSelected As Boolean = False
    Private colorName As String = ""

    Public Function GetAssociatedPictureBox() As PictureBox

        Return picBox

    End Function

    Public Sub SetAssociatedPictureBox(ByRef pictureBoxName As PictureBox)

        picBox = pictureBoxName

    End Sub

    Public Sub ToggleSelectState()

        If isSelected = True Then

            isSelected = False
            picBox.BackColor = PICTURE_BOX_UNSELECTED_COLOR

        ElseIf isSelected = False Then

            isSelected = True
            picBox.BackColor = PICTURE_BOX_SELECTED_COLOR

        End If

    End Sub

    Public Function GetIsSelected() As Boolean

        Return isSelected

    End Function

    Public Sub SetAsNotSelected()

        isSelected = False
        picBox.BackColor = PICTURE_BOX_UNSELECTED_COLOR

    End Sub

    Public Sub SetAsSelected()

        isSelected = True
        picBox.BackColor = PICTURE_BOX_SELECTED_COLOR

    End Sub

    Public Sub SetColorName(ByRef nameOfColor)

        colorName = nameOfColor

    End Sub

    Public Function GetColorName()

        Return colorName

    End Function

End Class
