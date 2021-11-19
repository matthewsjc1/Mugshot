<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class progressForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.curProgressBar = New System.Windows.Forms.ProgressBar()
        Me.curTaskLbl = New System.Windows.Forms.Label()
        Me.dogPicBox = New System.Windows.Forms.PictureBox()
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dogPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'curProgressBar
        '
        Me.curProgressBar.Location = New System.Drawing.Point(12, 133)
        Me.curProgressBar.Name = "curProgressBar"
        Me.curProgressBar.Size = New System.Drawing.Size(190, 23)
        Me.curProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.curProgressBar.TabIndex = 0
        '
        'curTaskLbl
        '
        Me.curTaskLbl.AutoSize = True
        Me.curTaskLbl.Location = New System.Drawing.Point(15, 162)
        Me.curTaskLbl.Name = "curTaskLbl"
        Me.curTaskLbl.Size = New System.Drawing.Size(0, 15)
        Me.curTaskLbl.TabIndex = 1
        '
        'dogPicBox
        '
        Me.dogPicBox.Location = New System.Drawing.Point(11, 11)
        Me.dogPicBox.Name = "dogPicBox"
        Me.dogPicBox.Size = New System.Drawing.Size(190, 101)
        Me.dogPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dogPicBox.TabIndex = 2
        Me.dogPicBox.TabStop = False
        '
        'animationTimer
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = """Workin' on it!"""
        '
        'progressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dogPicBox)
        Me.Controls.Add(Me.curTaskLbl)
        Me.Controls.Add(Me.curProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "progressForm"
        Me.Text = "Mugshot: Processing..."
        Me.TopMost = True
        CType(Me.dogPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents curProgressBar As ProgressBar
    Friend WithEvents curTaskLbl As Label
    Friend WithEvents dogPicBox As PictureBox
    Friend WithEvents animationTimer As Timer
    Friend WithEvents Label1 As Label
End Class
