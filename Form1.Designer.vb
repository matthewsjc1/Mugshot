<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.selColorsBtn = New System.Windows.Forms.Button()
        Me.selColorsListBox = New System.Windows.Forms.ListBox()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.roughPicBox = New System.Windows.Forms.PictureBox()
        Me.smoothPicBox = New System.Windows.Forms.PictureBox()
        Me.colorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SmoothRadBtn = New System.Windows.Forms.RadioButton()
        Me.roughRadBtn = New System.Windows.Forms.RadioButton()
        Me.artworkGroupBox = New System.Windows.Forms.GroupBox()
        Me.artFileTextBox = New System.Windows.Forms.TextBox()
        Me.selArtFileBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saveFolderGroupBox = New System.Windows.Forms.GroupBox()
        Me.saveFolderTextBox = New System.Windows.Forms.TextBox()
        Me.selSaveFolderBtn = New System.Windows.Forms.Button()
        Me.artFileOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.backOptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.horWrapRadBtn = New System.Windows.Forms.RadioButton()
        Me.twoImageRadBtn = New System.Windows.Forms.RadioButton()
        Me.curSelImagePicBox = New System.Windows.Forms.PictureBox()
        Me.hidePhotoshopCheckbox = New System.Windows.Forms.CheckBox()
        CType(Me.roughPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.smoothPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.colorsGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.artworkGroupBox.SuspendLayout()
        Me.saveFolderGroupBox.SuspendLayout()
        Me.backOptionsGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.curSelImagePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selColorsBtn
        '
        Me.selColorsBtn.Location = New System.Drawing.Point(127, 216)
        Me.selColorsBtn.Name = "selColorsBtn"
        Me.selColorsBtn.Size = New System.Drawing.Size(97, 37)
        Me.selColorsBtn.TabIndex = 0
        Me.selColorsBtn.Text = "Select Colors"
        Me.selColorsBtn.UseVisualStyleBackColor = True
        '
        'selColorsListBox
        '
        Me.selColorsListBox.FormattingEnabled = True
        Me.selColorsListBox.ItemHeight = 15
        Me.selColorsListBox.Location = New System.Drawing.Point(21, 43)
        Me.selColorsListBox.Name = "selColorsListBox"
        Me.selColorsListBox.Size = New System.Drawing.Size(203, 169)
        Me.selColorsListBox.TabIndex = 1
        '
        'nextBtn
        '
        Me.nextBtn.Location = New System.Drawing.Point(790, 544)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(97, 37)
        Me.nextBtn.TabIndex = 2
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected Colors:"
        '
        'roughPicBox
        '
        Me.roughPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.roughPicBox.Image = CType(resources.GetObject("roughPicBox.Image"), System.Drawing.Image)
        Me.roughPicBox.Location = New System.Drawing.Point(40, 43)
        Me.roughPicBox.Name = "roughPicBox"
        Me.roughPicBox.Size = New System.Drawing.Size(73, 101)
        Me.roughPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.roughPicBox.TabIndex = 4
        Me.roughPicBox.TabStop = False
        '
        'smoothPicBox
        '
        Me.smoothPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.smoothPicBox.Image = CType(resources.GetObject("smoothPicBox.Image"), System.Drawing.Image)
        Me.smoothPicBox.Location = New System.Drawing.Point(168, 43)
        Me.smoothPicBox.Name = "smoothPicBox"
        Me.smoothPicBox.Size = New System.Drawing.Size(73, 101)
        Me.smoothPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.smoothPicBox.TabIndex = 5
        Me.smoothPicBox.TabStop = False
        '
        'colorsGroupBox
        '
        Me.colorsGroupBox.Controls.Add(Me.selColorsListBox)
        Me.colorsGroupBox.Controls.Add(Me.selColorsBtn)
        Me.colorsGroupBox.Controls.Add(Me.Label1)
        Me.colorsGroupBox.Location = New System.Drawing.Point(364, 29)
        Me.colorsGroupBox.Name = "colorsGroupBox"
        Me.colorsGroupBox.Size = New System.Drawing.Size(248, 270)
        Me.colorsGroupBox.TabIndex = 6
        Me.colorsGroupBox.TabStop = False
        Me.colorsGroupBox.Text = "Colors"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SmoothRadBtn)
        Me.GroupBox2.Controls.Add(Me.roughRadBtn)
        Me.GroupBox2.Controls.Add(Me.roughPicBox)
        Me.GroupBox2.Controls.Add(Me.smoothPicBox)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 186)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edge Shape"
        '
        'SmoothRadBtn
        '
        Me.SmoothRadBtn.AutoSize = True
        Me.SmoothRadBtn.Location = New System.Drawing.Point(148, 150)
        Me.SmoothRadBtn.Name = "SmoothRadBtn"
        Me.SmoothRadBtn.Size = New System.Drawing.Size(113, 19)
        Me.SmoothRadBtn.TabIndex = 11
        Me.SmoothRadBtn.Text = "Smooth/Straight"
        Me.SmoothRadBtn.UseVisualStyleBackColor = True
        '
        'roughRadBtn
        '
        Me.roughRadBtn.AutoSize = True
        Me.roughRadBtn.Checked = True
        Me.roughRadBtn.Location = New System.Drawing.Point(19, 150)
        Me.roughRadBtn.Name = "roughRadBtn"
        Me.roughRadBtn.Size = New System.Drawing.Size(113, 19)
        Me.roughRadBtn.TabIndex = 10
        Me.roughRadBtn.TabStop = True
        Me.roughRadBtn.Text = "Rough/Rounded"
        Me.roughRadBtn.UseVisualStyleBackColor = True
        '
        'artworkGroupBox
        '
        Me.artworkGroupBox.Controls.Add(Me.artFileTextBox)
        Me.artworkGroupBox.Controls.Add(Me.selArtFileBtn)
        Me.artworkGroupBox.Location = New System.Drawing.Point(25, 380)
        Me.artworkGroupBox.Name = "artworkGroupBox"
        Me.artworkGroupBox.Size = New System.Drawing.Size(434, 128)
        Me.artworkGroupBox.TabIndex = 8
        Me.artworkGroupBox.TabStop = False
        Me.artworkGroupBox.Text = "Artwork"
        '
        'artFileTextBox
        '
        Me.artFileTextBox.Location = New System.Drawing.Point(21, 37)
        Me.artFileTextBox.Name = "artFileTextBox"
        Me.artFileTextBox.ReadOnly = True
        Me.artFileTextBox.Size = New System.Drawing.Size(391, 23)
        Me.artFileTextBox.TabIndex = 10
        Me.artFileTextBox.Text = "No file selected"
        '
        'selArtFileBtn
        '
        Me.selArtFileBtn.Location = New System.Drawing.Point(315, 66)
        Me.selArtFileBtn.Name = "selArtFileBtn"
        Me.selArtFileBtn.Size = New System.Drawing.Size(97, 37)
        Me.selArtFileBtn.TabIndex = 9
        Me.selArtFileBtn.Text = "Select Art File"
        Me.selArtFileBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 566)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "jmatthews@earthsunmoon.com"
        '
        'saveFolderGroupBox
        '
        Me.saveFolderGroupBox.Controls.Add(Me.saveFolderTextBox)
        Me.saveFolderGroupBox.Controls.Add(Me.selSaveFolderBtn)
        Me.saveFolderGroupBox.Location = New System.Drawing.Point(475, 380)
        Me.saveFolderGroupBox.Name = "saveFolderGroupBox"
        Me.saveFolderGroupBox.Size = New System.Drawing.Size(434, 128)
        Me.saveFolderGroupBox.TabIndex = 11
        Me.saveFolderGroupBox.TabStop = False
        Me.saveFolderGroupBox.Text = "Save Folder"
        '
        'saveFolderTextBox
        '
        Me.saveFolderTextBox.Location = New System.Drawing.Point(21, 37)
        Me.saveFolderTextBox.Name = "saveFolderTextBox"
        Me.saveFolderTextBox.ReadOnly = True
        Me.saveFolderTextBox.Size = New System.Drawing.Size(391, 23)
        Me.saveFolderTextBox.TabIndex = 10
        Me.saveFolderTextBox.Text = "No folder selected"
        '
        'selSaveFolderBtn
        '
        Me.selSaveFolderBtn.Location = New System.Drawing.Point(298, 66)
        Me.selSaveFolderBtn.Name = "selSaveFolderBtn"
        Me.selSaveFolderBtn.Size = New System.Drawing.Size(114, 37)
        Me.selSaveFolderBtn.TabIndex = 9
        Me.selSaveFolderBtn.Text = "Select Save Folder"
        Me.selSaveFolderBtn.UseVisualStyleBackColor = True
        '
        'artFileOpenDialog
        '
        Me.artFileOpenDialog.FileName = " "
        Me.artFileOpenDialog.Filter = "All Files|*.*"
        '
        'backOptionsGroupBox
        '
        Me.backOptionsGroupBox.Controls.Add(Me.GroupBox2)
        Me.backOptionsGroupBox.Controls.Add(Me.GroupBox1)
        Me.backOptionsGroupBox.Controls.Add(Me.colorsGroupBox)
        Me.backOptionsGroupBox.Location = New System.Drawing.Point(264, 23)
        Me.backOptionsGroupBox.Name = "backOptionsGroupBox"
        Me.backOptionsGroupBox.Size = New System.Drawing.Size(645, 322)
        Me.backOptionsGroupBox.TabIndex = 13
        Me.backOptionsGroupBox.TabStop = False
        Me.backOptionsGroupBox.Text = "Mug Background Options"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.horWrapRadBtn)
        Me.GroupBox1.Controls.Add(Me.twoImageRadBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 67)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artwork Type"
        '
        'horWrapRadBtn
        '
        Me.horWrapRadBtn.AutoSize = True
        Me.horWrapRadBtn.Location = New System.Drawing.Point(148, 29)
        Me.horWrapRadBtn.Name = "horWrapRadBtn"
        Me.horWrapRadBtn.Size = New System.Drawing.Size(111, 19)
        Me.horWrapRadBtn.TabIndex = 15
        Me.horWrapRadBtn.Text = "Horizontal Wrap"
        Me.horWrapRadBtn.UseVisualStyleBackColor = True
        '
        'twoImageRadBtn
        '
        Me.twoImageRadBtn.AutoSize = True
        Me.twoImageRadBtn.Checked = True
        Me.twoImageRadBtn.Location = New System.Drawing.Point(19, 29)
        Me.twoImageRadBtn.Name = "twoImageRadBtn"
        Me.twoImageRadBtn.Size = New System.Drawing.Size(84, 19)
        Me.twoImageRadBtn.TabIndex = 14
        Me.twoImageRadBtn.TabStop = True
        Me.twoImageRadBtn.Text = "Two Image"
        Me.twoImageRadBtn.UseVisualStyleBackColor = True
        '
        'curSelImagePicBox
        '
        Me.curSelImagePicBox.Location = New System.Drawing.Point(25, 52)
        Me.curSelImagePicBox.Name = "curSelImagePicBox"
        Me.curSelImagePicBox.Size = New System.Drawing.Size(216, 270)
        Me.curSelImagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.curSelImagePicBox.TabIndex = 14
        Me.curSelImagePicBox.TabStop = False
        '
        'hidePhotoshopCheckbox
        '
        Me.hidePhotoshopCheckbox.AutoSize = True
        Me.hidePhotoshopCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.hidePhotoshopCheckbox.Location = New System.Drawing.Point(700, 519)
        Me.hidePhotoshopCheckbox.Name = "hidePhotoshopCheckbox"
        Me.hidePhotoshopCheckbox.Size = New System.Drawing.Size(187, 19)
        Me.hidePhotoshopCheckbox.TabIndex = 16
        Me.hidePhotoshopCheckbox.Text = "Run Photoshop in Silent Mode"
        Me.hidePhotoshopCheckbox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.nextBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 595)
        Me.Controls.Add(Me.hidePhotoshopCheckbox)
        Me.Controls.Add(Me.curSelImagePicBox)
        Me.Controls.Add(Me.backOptionsGroupBox)
        Me.Controls.Add(Me.saveFolderGroupBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.artworkGroupBox)
        Me.Controls.Add(Me.nextBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mugshot - Easy Mug Mock Up and Template Maker"
        CType(Me.roughPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.smoothPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.colorsGroupBox.ResumeLayout(False)
        Me.colorsGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.artworkGroupBox.ResumeLayout(False)
        Me.artworkGroupBox.PerformLayout()
        Me.saveFolderGroupBox.ResumeLayout(False)
        Me.saveFolderGroupBox.PerformLayout()
        Me.backOptionsGroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.curSelImagePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents selColorsBtn As Button
    Friend WithEvents selColorsListBox As ListBox
    Friend WithEvents nextBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents roughPicBox As PictureBox
    Friend WithEvents smoothPicBox As PictureBox
    Friend WithEvents colorsGroupBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SmoothRadBtn As RadioButton
    Friend WithEvents roughRadBtn As RadioButton
    Friend WithEvents artworkGroupBox As GroupBox
    Friend WithEvents selArtFileBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents artFileTextBox As TextBox
    Friend WithEvents saveFolderGroupBox As GroupBox
    Friend WithEvents saveFolderTextBox As TextBox
    Friend WithEvents selSaveFolderBtn As Button
    Friend WithEvents artFileOpenDialog As OpenFileDialog
    Friend WithEvents backOptionsGroupBox As GroupBox
    Friend WithEvents curSelImagePicBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents horWrapRadBtn As RadioButton
    Friend WithEvents twoImageRadBtn As RadioButton
    Friend WithEvents hidePhotoshopCheckbox As CheckBox
End Class
