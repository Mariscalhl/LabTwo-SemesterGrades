<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMariscalLabTwo
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
        Me.components = New System.ComponentModel.Container()
        Me.tbInputOne = New System.Windows.Forms.TextBox()
        Me.tbInputTwo = New System.Windows.Forms.TextBox()
        Me.tbInputThree = New System.Windows.Forms.TextBox()
        Me.tbInputFour = New System.Windows.Forms.TextBox()
        Me.tbInputFive = New System.Windows.Forms.TextBox()
        Me.tbInputSix = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbCourseOne = New System.Windows.Forms.Label()
        Me.lbCourseTwo = New System.Windows.Forms.Label()
        Me.lbCourseThree = New System.Windows.Forms.Label()
        Me.lbCourseFour = New System.Windows.Forms.Label()
        Me.lbCourseFive = New System.Windows.Forms.Label()
        Me.lbCourseSix = New System.Windows.Forms.Label()
        Me.lbSemesterAverage = New System.Windows.Forms.Label()
        Me.lbLetterGradeOne = New System.Windows.Forms.Label()
        Me.lbErrorOutput = New System.Windows.Forms.Label()
        Me.ToolTipSemesterGrades = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbLetterGradeTwo = New System.Windows.Forms.Label()
        Me.lbLetterGradeThree = New System.Windows.Forms.Label()
        Me.lbLetterGradeFour = New System.Windows.Forms.Label()
        Me.lbLetterGradeFive = New System.Windows.Forms.Label()
        Me.lbLetterGradeSix = New System.Windows.Forms.Label()
        Me.lbNumericAverageOutput = New System.Windows.Forms.Label()
        Me.lbLetterAverageOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbInputOne
        '
        Me.tbInputOne.Location = New System.Drawing.Point(67, 12)
        Me.tbInputOne.Name = "tbInputOne"
        Me.tbInputOne.Size = New System.Drawing.Size(100, 20)
        Me.tbInputOne.TabIndex = 0
        Me.tbInputOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterGrades.SetToolTip(Me.tbInputOne, "Enter grade for course 1")
        '
        'tbInputTwo
        '
        Me.tbInputTwo.Location = New System.Drawing.Point(67, 49)
        Me.tbInputTwo.Name = "tbInputTwo"
        Me.tbInputTwo.Size = New System.Drawing.Size(100, 20)
        Me.tbInputTwo.TabIndex = 1
        Me.tbInputTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterGrades.SetToolTip(Me.tbInputTwo, "Enter grade for course 2")
        '
        'tbInputThree
        '
        Me.tbInputThree.Location = New System.Drawing.Point(67, 84)
        Me.tbInputThree.Name = "tbInputThree"
        Me.tbInputThree.Size = New System.Drawing.Size(100, 20)
        Me.tbInputThree.TabIndex = 2
        Me.tbInputThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterGrades.SetToolTip(Me.tbInputThree, "Enter grade for course 3")
        '
        'tbInputFour
        '
        Me.tbInputFour.Location = New System.Drawing.Point(67, 120)
        Me.tbInputFour.Name = "tbInputFour"
        Me.tbInputFour.Size = New System.Drawing.Size(100, 20)
        Me.tbInputFour.TabIndex = 3
        Me.tbInputFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterGrades.SetToolTip(Me.tbInputFour, "Enter grade for course 4")
        '
        'tbInputFive
        '
        Me.tbInputFive.Location = New System.Drawing.Point(67, 155)
        Me.tbInputFive.Name = "tbInputFive"
        Me.tbInputFive.Size = New System.Drawing.Size(100, 20)
        Me.tbInputFive.TabIndex = 4
        Me.tbInputFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterGrades.SetToolTip(Me.tbInputFive, "Enter grade for course 5")
        '
        'tbInputSix
        '
        Me.tbInputSix.Location = New System.Drawing.Point(67, 192)
        Me.tbInputSix.Name = "tbInputSix"
        Me.tbInputSix.Size = New System.Drawing.Size(100, 20)
        Me.tbInputSix.TabIndex = 5
        Me.tbInputSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterGrades.SetToolTip(Me.tbInputSix, "Enter grade for course 6")
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(3, 431)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTipSemesterGrades.SetToolTip(Me.btnCalculate, "Press to calculate semester average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(95, 431)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ToolTipSemesterGrades.SetToolTip(Me.btnReset, "Press to reset the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 431)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.ToolTipSemesterGrades.SetToolTip(Me.btnExit, "Press to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbCourseOne
        '
        Me.lbCourseOne.Location = New System.Drawing.Point(9, 19)
        Me.lbCourseOne.Name = "lbCourseOne"
        Me.lbCourseOne.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseOne.TabIndex = 9
        Me.lbCourseOne.Text = "Course &1:"
        Me.lbCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseTwo
        '
        Me.lbCourseTwo.Location = New System.Drawing.Point(6, 56)
        Me.lbCourseTwo.Name = "lbCourseTwo"
        Me.lbCourseTwo.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseTwo.TabIndex = 10
        Me.lbCourseTwo.Text = "Course &2:"
        Me.lbCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseThree
        '
        Me.lbCourseThree.Location = New System.Drawing.Point(6, 91)
        Me.lbCourseThree.Name = "lbCourseThree"
        Me.lbCourseThree.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseThree.TabIndex = 11
        Me.lbCourseThree.Text = "Course &3:"
        Me.lbCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseFour
        '
        Me.lbCourseFour.Location = New System.Drawing.Point(6, 127)
        Me.lbCourseFour.Name = "lbCourseFour"
        Me.lbCourseFour.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseFour.TabIndex = 12
        Me.lbCourseFour.Text = "Course &4:"
        Me.lbCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseFive
        '
        Me.lbCourseFive.Location = New System.Drawing.Point(6, 162)
        Me.lbCourseFive.Name = "lbCourseFive"
        Me.lbCourseFive.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseFive.TabIndex = 13
        Me.lbCourseFive.Text = "Course &5:"
        Me.lbCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseSix
        '
        Me.lbCourseSix.Location = New System.Drawing.Point(6, 198)
        Me.lbCourseSix.Name = "lbCourseSix"
        Me.lbCourseSix.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseSix.TabIndex = 14
        Me.lbCourseSix.Text = "Course &6:"
        Me.lbCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSemesterAverage
        '
        Me.lbSemesterAverage.Location = New System.Drawing.Point(4, 247)
        Me.lbSemesterAverage.Name = "lbSemesterAverage"
        Me.lbSemesterAverage.Size = New System.Drawing.Size(54, 13)
        Me.lbSemesterAverage.TabIndex = 15
        Me.lbSemesterAverage.Text = "&Semester:"
        Me.lbSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeOne
        '
        Me.lbLetterGradeOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeOne.Location = New System.Drawing.Point(173, 12)
        Me.lbLetterGradeOne.Name = "lbLetterGradeOne"
        Me.lbLetterGradeOne.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterGradeOne.TabIndex = 18
        Me.lbLetterGradeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterGradeOne, "Displays letter grade")
        '
        'lbErrorOutput
        '
        Me.lbErrorOutput.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbErrorOutput.Location = New System.Drawing.Point(3, 276)
        Me.lbErrorOutput.Name = "lbErrorOutput"
        Me.lbErrorOutput.Size = New System.Drawing.Size(273, 152)
        Me.lbErrorOutput.TabIndex = 24
        Me.lbErrorOutput.Text = "Error(s)"
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbErrorOutput, "Shows any error that occured when entering grades")
        '
        'lbLetterGradeTwo
        '
        Me.lbLetterGradeTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeTwo.Location = New System.Drawing.Point(173, 48)
        Me.lbLetterGradeTwo.Name = "lbLetterGradeTwo"
        Me.lbLetterGradeTwo.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterGradeTwo.TabIndex = 25
        Me.lbLetterGradeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterGradeTwo, "Displays letter grade")
        '
        'lbLetterGradeThree
        '
        Me.lbLetterGradeThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeThree.Location = New System.Drawing.Point(173, 84)
        Me.lbLetterGradeThree.Name = "lbLetterGradeThree"
        Me.lbLetterGradeThree.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterGradeThree.TabIndex = 26
        Me.lbLetterGradeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterGradeThree, "Displays letter grade")
        '
        'lbLetterGradeFour
        '
        Me.lbLetterGradeFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeFour.Location = New System.Drawing.Point(173, 119)
        Me.lbLetterGradeFour.Name = "lbLetterGradeFour"
        Me.lbLetterGradeFour.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterGradeFour.TabIndex = 27
        Me.lbLetterGradeFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterGradeFour, "Displays letter grade")
        '
        'lbLetterGradeFive
        '
        Me.lbLetterGradeFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeFive.Location = New System.Drawing.Point(173, 155)
        Me.lbLetterGradeFive.Name = "lbLetterGradeFive"
        Me.lbLetterGradeFive.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterGradeFive.TabIndex = 28
        Me.lbLetterGradeFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterGradeFive, "Displays letter grade")
        '
        'lbLetterGradeSix
        '
        Me.lbLetterGradeSix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeSix.Location = New System.Drawing.Point(173, 191)
        Me.lbLetterGradeSix.Name = "lbLetterGradeSix"
        Me.lbLetterGradeSix.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterGradeSix.TabIndex = 29
        Me.lbLetterGradeSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterGradeSix, "Displays letter grade")
        '
        'lbNumericAverageOutput
        '
        Me.lbNumericAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNumericAverageOutput.Location = New System.Drawing.Point(64, 240)
        Me.lbNumericAverageOutput.Name = "lbNumericAverageOutput"
        Me.lbNumericAverageOutput.Size = New System.Drawing.Size(103, 21)
        Me.lbNumericAverageOutput.TabIndex = 30
        Me.lbNumericAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbNumericAverageOutput, "Displays semester numeric average")
        '
        'lbLetterAverageOutput
        '
        Me.lbLetterAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterAverageOutput.Location = New System.Drawing.Point(173, 240)
        Me.lbLetterAverageOutput.Name = "lbLetterAverageOutput"
        Me.lbLetterAverageOutput.Size = New System.Drawing.Size(103, 20)
        Me.lbLetterAverageOutput.TabIndex = 31
        Me.lbLetterAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipSemesterGrades.SetToolTip(Me.lbLetterAverageOutput, "Displays semester letter average")
        '
        'frmMariscalLabTwo
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 466)
        Me.Controls.Add(Me.lbLetterAverageOutput)
        Me.Controls.Add(Me.lbNumericAverageOutput)
        Me.Controls.Add(Me.lbLetterGradeSix)
        Me.Controls.Add(Me.lbLetterGradeFive)
        Me.Controls.Add(Me.lbLetterGradeFour)
        Me.Controls.Add(Me.lbLetterGradeThree)
        Me.Controls.Add(Me.lbLetterGradeTwo)
        Me.Controls.Add(Me.lbErrorOutput)
        Me.Controls.Add(Me.lbLetterGradeOne)
        Me.Controls.Add(Me.lbSemesterAverage)
        Me.Controls.Add(Me.lbCourseSix)
        Me.Controls.Add(Me.lbCourseFive)
        Me.Controls.Add(Me.lbCourseFour)
        Me.Controls.Add(Me.lbCourseThree)
        Me.Controls.Add(Me.lbCourseTwo)
        Me.Controls.Add(Me.lbCourseOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbInputSix)
        Me.Controls.Add(Me.tbInputFive)
        Me.Controls.Add(Me.tbInputFour)
        Me.Controls.Add(Me.tbInputThree)
        Me.Controls.Add(Me.tbInputTwo)
        Me.Controls.Add(Me.tbInputOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMariscalLabTwo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbInputOne As TextBox
    Friend WithEvents tbInputTwo As TextBox
    Friend WithEvents tbInputThree As TextBox
    Friend WithEvents tbInputFour As TextBox
    Friend WithEvents tbInputFive As TextBox
    Friend WithEvents tbInputSix As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbCourseOne As Label
    Friend WithEvents lbCourseTwo As Label
    Friend WithEvents lbCourseThree As Label
    Friend WithEvents lbCourseFour As Label
    Friend WithEvents lbCourseFive As Label
    Friend WithEvents lbCourseSix As Label
    Friend WithEvents lbSemesterAverage As Label
    Friend WithEvents lbLetterGradeOne As Label
    Friend WithEvents lbErrorOutput As Label
    Friend WithEvents ToolTipSemesterGrades As ToolTip
    Friend WithEvents lbLetterGradeTwo As Label
    Friend WithEvents lbLetterGradeThree As Label
    Friend WithEvents lbLetterGradeFour As Label
    Friend WithEvents lbLetterGradeFive As Label
    Friend WithEvents lbLetterGradeSix As Label
    Friend WithEvents lbNumericAverageOutput As Label
    Friend WithEvents lbLetterAverageOutput As Label
End Class
