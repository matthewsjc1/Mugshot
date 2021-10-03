Imports System.ComponentModel

Public Class progressForm

    Private curAnimationFrame As Integer = 1
    Private image1 As Image
    Private image2 As Image
    Private image3 As Image
    Private image4 As Image

    Private Sub progressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Reset()

    End Sub

    Public Sub SetCurrentProgressPercentage(ByVal progressPercentage As Integer)

        curProgressBar.Value = progressPercentage
        curProgressBar.Invalidate()
        curProgressBar.Update()

    End Sub

    Public Sub SetCurrentTaskText(ByVal taskText As String)

        curTaskLbl.Text = taskText
        curTaskLbl.Invalidate()
        curTaskLbl.Update()

    End Sub

    Public Sub SetProgressBarMaxValue(ByVal maxValue As Integer)

        curProgressBar.Maximum = maxValue

    End Sub

    Public Sub IncrementProgressBar(ByVal incrementAmount As Integer)

        curProgressBar.Increment(incrementAmount)

    End Sub

    Public Sub Reset()

        curTaskLbl.Text = ""
        curTaskLbl.Invalidate()
        curTaskLbl.Update()

        curProgressBar.Value = 0
        curProgressBar.Invalidate()
        curProgressBar.Update()

    End Sub

    Private Sub progressForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try

            image1 = Image.FromFile(AppContext.BaseDirectory + "\dog_animation\1.jpg")
            image2 = Image.FromFile(AppContext.BaseDirectory + "\dog_animation\2.jpg")
            image3 = Image.FromFile(AppContext.BaseDirectory + "\dog_animation\3.jpg")
            image4 = Image.FromFile(AppContext.BaseDirectory + "\dog_animation\4.jpg")

        Catch ex As Exception

            MessageBox.Show("Failed to load working animation.", "Animation Fail")

        End Try

        curAnimationFrame = 1
        animationTimer.Enabled = True
        animationTimer.Start()

    End Sub

    Private Sub progressForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        animationTimer.Stop()
        animationTimer.Enabled = False
        curAnimationFrame = 1

    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick

        Select Case curAnimationFrame

            Case 1

                dogPicBox.Image = image1
                curAnimationFrame += 1
                dogPicBox.Invalidate()

            Case 2

                dogPicBox.Image = image2
                curAnimationFrame += 1
                dogPicBox.Invalidate()

            Case 3

                dogPicBox.Image = image3
                curAnimationFrame += 1
                dogPicBox.Invalidate()

            Case 4

                dogPicBox.Image = image4
                curAnimationFrame = 1
                dogPicBox.Invalidate()

            Case Else

        End Select

    End Sub

End Class