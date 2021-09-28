Public Class progressForm

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

End Class