Option Strict On

''' <summary>
''' Author: Hector Mariscal
''' Project Name: Lab Two - Semester Grades
''' Date: 20-feb-2018
''' Description: This Application allows the user to input grades for 6 courses and then showing the 
''' letter grade after each one, after all 6 grades are inputted the user can then calculate the
''' average grade and its corresponding letter grade.
''' </summary>
Public Class frmMariscalLabTwo

    ''Constants for the letter grades ranges
    Private Const gradeAP As String = "A+"
    Private Const gradeA As String = "A"
    Private Const gradeAM As String = "A-"

    Private Const gradeBP As String = "B+"
    Private Const gradeB As String = "B"
    Private Const gradeBM As String = "B-"

    Private Const gradeCP As String = "C+"
    Private Const gradeC As String = "C"
    Private Const gradeCM As String = "C-"

    Private Const gradeDP As String = "D+"
    Private Const gradeD As String = "D"
    Private Const gradeDM As String = "D-"

    Private Const gradeF As String = "F"

    Private counter As Integer = 0  ''counter to keep track of which course the loop is at

    Private letterGradesArray(12) As String ''Array that holds the letter grades at form load
    Public gradesArray(6) As Double ''Array that holds the user inputted grades after validation

    ''' <summary>
    '''Handles the leave event for this textbox, processes the number when the textbox loses focus.
    '''The number is then stored in an array, to be used in the calculation loop. If the input is invalid
    '''then there is an error message, and the textbox is focused and highlighted for efficiency.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles tbInputOne.Leave
        Dim userInput As String = String.Empty  ''stores user input from the textbox
        Dim validGrade As Double = 0.0          ''stores validated grade
        Dim letterGrade As String = String.Empty    ''stores letter grade

        userInput = tbInputOne.Text ''makes what is typed into the textbox be put into the userInput variable

        If InputValidation(userInput, validGrade) Then  ''sends input to validation function and if valid returns as validGrade
            LetterGradeFunction(validGrade, letterGrade)    ''letter grade function that determines the corresponding letter grade
            lbLetterGradeOne.Text = letterGrade             ''outputs letter grade
            gradesArray(0) = validGrade                      ''Stores the validated grade into the corresponding index
            CalculateButtonEnabled(counter)     ''Function that enables the calculate button only after all grades are inputted
        Else    ''happens if input is not valid
            tbInputOne.Focus()  ''focuses on the textbox
            tbInputOne.SelectAll()  ''highlights the input in the textbox


        End If



    End Sub
    ''' <summary>
    ''' Function that handles the validation of the user input. Checks for a numeric value within the stated ranges.
    ''' Outputs error messages if there is an issue with validation and specifies which course grade is invalid. 
    ''' </summary>
    Private Function InputValidation(ByVal userInput As String, ByRef validGrade As Double) As Boolean
        Const minGrade As Integer = 0   ''range constant
        Const maxGrade As Integer = 100     ''range constant

        Dim validatingUserInput As Double = 0.0 ''stores input as its being validated
        Dim returnValue As Boolean = True   ''
        Dim output As String = String.Empty ''variable that holds the error message



        If (Double.TryParse(userInput, validatingUserInput) AndAlso ''takes user input and checks if it is a number(double)
        validatingUserInput >= minGrade And validatingUserInput <= maxGrade) Then   ''checks if that number is within the range
            validGrade = validatingUserInput    ''puts that validated number into the validGrade variable for clarity.

            returnValue = True  ''returns the value of true if valid
            output = String.Empty

        Else

            output = vbCrLf & "The grade must be a NUMBER between " & minGrade.ToString & " and " & maxGrade.ToString & " Your input for Course " & counter + 1 & " was " & userInput.ToString
            validGrade = 0
            returnValue = False ''returns the value of false if invalid
            counter -= 1    ''if invalid the counter goes back one
        End If

        If returnValue = False Then
            lbErrorOutput.Text += output
            output = String.Empty


        End If
        counter += 1
        Return returnValue  ''returns if the number was valid or not

    End Function
    ''' <summary>
    '''Handles the leave event for this textbox, processes the number when the textbox loses focus.
    '''The number is then stored in an array, to be used in the calculation loop. If the input is invalid
    '''then there is an error message, and the textbox is focused and highlighted for efficiency.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbInputTwo_Leave(sender As Object, e As EventArgs) Handles tbInputTwo.Leave
        Dim userInput As String = String.Empty
        Dim validGrade As Double = 0.0
        Dim letterGrade As String = String.Empty

        userInput = tbInputTwo.Text

        If InputValidation(userInput, validGrade) Then
            LetterGradeFunction(validGrade, letterGrade)
            lbLetterGradeTwo.Text = letterGrade
            gradesArray(1) = validGrade
            CalculateButtonEnabled(counter)
        Else
            tbInputTwo.Focus()
            tbInputTwo.SelectAll()

        End If

    End Sub
    ''' <summary>
    '''Handles the leave event for this textbox, processes the number when the textbox loses focus.
    '''The number is then stored in an array, to be used in the calculation loop. If the input is invalid
    '''then there is an error message, and the textbox is focused and highlighted for efficiency.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbInputThree_Leave(sender As Object, e As EventArgs) Handles tbInputThree.Leave
        Dim userInput As String = String.Empty
        Dim validGrade As Double = 0.0
        Dim letterGrade As String = String.Empty

        userInput = tbInputThree.Text

        If InputValidation(userInput, validGrade) Then
            LetterGradeFunction(validGrade, letterGrade)
            lbLetterGradeThree.Text = letterGrade
            gradesArray(2) = validGrade
            CalculateButtonEnabled(counter)
        Else
            tbInputThree.Focus()
            tbInputThree.SelectAll()

        End If

    End Sub
    ''' <summary>
    '''Handles the leave event for this textbox, processes the number when the textbox loses focus.
    '''The number is then stored in an array, to be used in the calculation loop. If the input is invalid
    '''then there is an error message, and the textbox is focused and highlighted for efficiency.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbInputFour_Leave(sender As Object, e As EventArgs) Handles tbInputFour.Leave
        Dim userInput As String = String.Empty
        Dim output As String = String.Empty
        Dim validGrade As Double = 0.0
        Dim letterGrade As String = String.Empty

        userInput = tbInputFour.Text

        If InputValidation(userInput, validGrade) Then
            LetterGradeFunction(validGrade, letterGrade)
            lbLetterGradeFour.Text = letterGrade
            gradesArray(3) = validGrade
            CalculateButtonEnabled(counter)
        Else
            '' tbInputFour.Focus()
            tbInputFour.SelectAll()

        End If

    End Sub
    ''' <summary>
    '''Handles the leave event for this textbox, processes the number when the textbox loses focus.
    '''The number is then stored in an array, to be used in the calculation loop. If the input is invalid
    '''then there is an error message, and the textbox is focused and highlighted for efficiency.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbInputFive_Leave(sender As Object, e As EventArgs) Handles tbInputFive.Leave
        Dim userInput As String = String.Empty
        Dim validGrade As Double = 0.0
        Dim letterGrade As String = String.Empty

        userInput = tbInputFive.Text

        If InputValidation(userInput, validGrade) Then
            LetterGradeFunction(validGrade, letterGrade)
            lbLetterGradeFive.Text = letterGrade
            gradesArray(4) = validGrade
            CalculateButtonEnabled(counter)
        Else
            tbInputFive.Focus()
            tbInputFive.SelectAll()
        End If

    End Sub
    ''' <summary>
    '''Handles the leave event for this textbox, processes the number when the textbox loses focus.
    '''The number is then stored in an array, to be used in the calculation loop. If the input is invalid
    '''then there is an error message, and the textbox is focused and highlighted for efficiency.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbInputSix_Leave(sender As Object, e As EventArgs) Handles tbInputSix.Leave
        Dim userInput As String = String.Empty
        Dim validGrade As Double = 0.0
        Dim letterGrade As String = String.Empty

        userInput = tbInputSix.Text

        If InputValidation(userInput, validGrade) Then
            LetterGradeFunction(validGrade, letterGrade)
            lbLetterGradeSix.Text = letterGrade
            gradesArray(5) = validGrade
            CalculateButtonEnabled(counter)
        Else
            tbInputSix.Focus()
            tbInputSix.SelectAll()
        End If

    End Sub
    ''' <summary>
    ''' This is the event handler for the calculate button.
    ''' This button calculates the average of all the grades in the array and then outputs it along with the 
    ''' corresponding letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gradeSum As Double = 0.0    ''stores the sum of all the numbers in the array
        Dim semesterAverage As Double = 0.0 ''stores the calculated average of all the numbers in the array
        Dim letterGrade As String = String.Empty    ''stores the letter grade corresponding to the average

        ''disables calculate button and disables the input textboxes
        tbInputOne.Enabled = False
        tbInputTwo.Enabled = False
        tbInputThree.Enabled = False
        tbInputFour.Enabled = False
        tbInputFive.Enabled = False
        tbInputSix.Enabled = False
        btnCalculate.Enabled = False

        For index As Integer = 0 To gradesArray.Length - 1
            gradeSum = (gradeSum + gradesArray(index))  ''for loop that adds up the numbers in the array

        Next
        semesterAverage = Math.Round(gradeSum / (gradesArray.Length - 1), 2)    ''average calculation
        LetterGradeFunction(semesterAverage, letterGrade)   ''function to assign a letter grade to the average
        lbLetterAverageOutput.Text = letterGrade    ''outputs the letter grade
        lbNumericAverageOutput.Text = semesterAverage.ToString  ''outputs the calculated semester average
    End Sub
    ''' <summary>
    ''' This Is an event wiring for btnReset
    ''' It resets everything on the form back to the default state.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        Array.Clear(gradesArray, 0, gradesArray.Length)

        tbInputOne.Enabled = True
        tbInputTwo.Enabled = True
        tbInputThree.Enabled = True
        tbInputFour.Enabled = True
        tbInputFive.Enabled = True
        tbInputSix.Enabled = True
        btnCalculate.Enabled = False

        tbInputOne.Text = ""
        tbInputTwo.Text = ""
        tbInputThree.Text = ""
        tbInputFour.Text = ""
        tbInputFive.Text = ""
        tbInputSix.Text = ""

        lbLetterGradeOne.Text = ""
        lbLetterGradeTwo.Text = ""
        lbLetterGradeThree.Text = ""
        lbLetterGradeFour.Text = ""
        lbLetterGradeFive.Text = ""
        lbLetterGradeSix.Text = ""

        lbNumericAverageOutput.Text = ""
        lbLetterAverageOutput.Text = ""
        lbErrorOutput.Text = "Error(s)" & vbCrLf
        counter = 0 ''resets counter back to 0
        tbInputOne.Focus()  ''focuses back on textbox one for efficiency
    End Sub
    ''' <summary>
    '''Function that puts all of the letter grades into an array when the form loads.
    ''' </summary>
    Private Sub frmMariscalLabTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        letterGradesArray(0) = gradeF
        letterGradesArray(1) = gradeDM
        letterGradesArray(2) = gradeD
        letterGradesArray(3) = gradeDP
        letterGradesArray(4) = gradeCM
        letterGradesArray(5) = gradeC
        letterGradesArray(6) = gradeCP
        letterGradesArray(7) = gradeBM
        letterGradesArray(8) = gradeB
        letterGradesArray(9) = gradeBP
        letterGradesArray(10) = gradeAM
        letterGradesArray(11) = gradeA
        letterGradesArray(12) = gradeAP
    End Sub
    ''' <summary>
    '''Function that determines the corresponding letter grades of the validated input based on the ranges.
    ''' </summary>
    Private Function LetterGradeFunction(ByRef validGrade As Double, ByRef letterGrade As String) As String
        If validGrade >= 0 And validGrade <= 49 Then
            letterGrade = letterGradesArray(0)
        ElseIf validGrade >= 50 And validGrade <= 52 Then
            letterGrade = letterGradesArray(1)
        ElseIf validGrade >= 53 And validGrade <= 56 Then
            letterGrade = letterGradesArray(2)
        ElseIf validGrade >= 57 And validGrade <= 59 Then
            letterGrade = letterGradesArray(3)
        ElseIf validGrade >= 60 And validGrade <= 62 Then
            letterGrade = letterGradesArray(4)
        ElseIf validGrade >= 63 And validGrade <= 66 Then
            letterGrade = letterGradesArray(5)
        ElseIf validGrade >= 67 And validGrade <= 69 Then
            letterGrade = letterGradesArray(6)
        ElseIf validGrade >= 70 And validGrade <= 72 Then
            letterGrade = letterGradesArray(7)
        ElseIf validGrade >= 73 And validGrade <= 76 Then
            letterGrade = letterGradesArray(8)
        ElseIf validGrade >= 77 And validGrade <= 79 Then
            letterGrade = letterGradesArray(9)
        ElseIf validGrade >= 80 And validGrade <= 84 Then
            letterGrade = letterGradesArray(10)
        ElseIf validGrade >= 85 And validGrade <= 89 Then
            letterGrade = letterGradesArray(11)
        ElseIf validGrade >= 90 And validGrade <= 100 Then
            letterGrade = letterGradesArray(12)

        End If

        Return letterGrade
    End Function
    ''' <summary>
    ''' Function that determines whether the calculate button is enabled based on the number of valid inputs
    ''' </summary>
    Private Function CalculateButtonEnabled(ByVal counter As Integer) As Boolean

        If counter = (gradesArray.Length - 1) Then
            btnCalculate.Enabled = True
            btnCalculate.Focus()
        End If
        Return True
    End Function
    ''' <summary>
    ''' Closes the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
