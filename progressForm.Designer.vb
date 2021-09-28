<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progressForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.curProgressBar = New System.Windows.Forms.ProgressBar()
        Me.curTaskLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'curProgressBar
        '
        Me.curProgressBar.Location = New System.Drawing.Point(50, 66)
        Me.curProgressBar.Name = "curProgressBar"
        Me.curProgressBar.Size = New System.Drawing.Size(365, 23)
        Me.curProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.curProgressBar.TabIndex = 0
        '
        'curTaskLbl
        '
        Me.curTaskLbl.AutoSize = True
        Me.curTaskLbl.Location = New System.Drawing.Point(50, 37)
        Me.curTaskLbl.Name = "curTaskLbl"
        Me.curTaskLbl.Size = New System.Drawing.Size(0, 15)
        Me.curTaskLbl.TabIndex = 1
        '
        'progressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 123)
        Me.ControlBox = False
        Me.Controls.Add(Me.curTaskLbl)
        Me.Controls.Add(Me.curProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "progressForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mugshot: Processing..."
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents curProgressBar As ProgressBar
    Friend WithEvents curTaskLbl As Label
End Class
