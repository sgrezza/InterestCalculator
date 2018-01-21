Option Strict On
Public Class Form1
    Private Function PresentValue(futureValue As Integer, years As Integer, rate As Double) As Integer
        Return CInt(futureValue / ((1 + (rate / 100)) ^ years))  'Math
    End Function
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Here we clear the listbox, validate input, and calculate
        'the present value the user would have to invest to acheive their future value.

        'Clear out the listbox
        listRequiredInvestment.Items.Clear()
        'Declare variables
        Dim dblGoldRate As Double = 0.03         'Interest rate from Gold membership
        Dim dblSilverRate As Double = 0.02       'Interest rate from Silver membership
        Dim dblBronzeRate As Double = 0.01       'Interest rate from Bronze membership
        Dim intFutureValue, intYears As Integer  'Future value and years
        Dim dblInterestRate As Double            'Interest rate

        'First, we make sure the user has entered something in the input fields
        If (txtFutureValue.Text IsNot "") Then
            If (txtInterestRate.Text IsNot "") Then
                If (cmbYears.Text IsNot "") Then
                    'Then we make sure the user entered numbers and not strings
                    If Integer.TryParse(txtFutureValue.Text, intFutureValue) Then
                        If Double.TryParse(txtInterestRate.Text, dblInterestRate) Then
                            If Integer.TryParse(cmbYears.Text, intYears) Then
                                'Calculate the user's interest rate based on intFutureValue
                                Select Case intFutureValue
                                    Case Is >= 50000
                                        dblInterestRate += 1.0
                                    Case 30000 To 49999
                                        dblInterestRate += 0.5
                                    Case 10000 To 29999
                                        dblInterestRate += 0.02
                                End Select
                                'Alrighty, everything except membership is validated.
                                'Add column labels to listbox.
                                listRequiredInvestment.Items.Add(
                                    "Years" + vbTab + " " + "Required Investment")
                                'Check user's membership.
                                If (radGold.Checked) Then
                                    dblInterestRate += dblGoldRate
                                    'If membership is validated, go ahead and crunch the numbers
                                    For years = 5 To intYears Step 5  'List out values for every 5 years
                                        listRequiredInvestment.Items.Add(                       'Use two vbTabs because the assignment calls for
                                            years.ToString + vbTab + vbTab + "  " + PresentValue('ten spaces and 1 tab is 4 spaces
                                                intFutureValue, years, dblInterestRate).ToString("C")
                                           )
                                    Next
                                    'I realize I could encapsulate this loop into a function
                                    'but the assignment specified to put the For loop inside the calculate button.
                                ElseIf (radSilver.Checked) Then
                                    dblInterestRate += dblSilverRate
                                    For years = 5 To intYears Step 5
                                        listRequiredInvestment.Items.Add(
                                           years.ToString + vbTab + vbTab + "  " + PresentValue(
                                                intFutureValue, years, dblInterestRate).ToString
                                           )
                                    Next

                                ElseIf (radBronze.Checked) Then
                                    dblInterestRate += dblBronzeRate
                                    For years = 5 To intYears Step 5
                                        listRequiredInvestment.Items.Add(
                                           years.ToString + vbTab + vbTab + "  " + PresentValue(
                                                intFutureValue, years, dblInterestRate).ToString
                                           )
                                    Next

                                Else
                                    MessageBox.Show("Please select a membership", "Select a membership", MessageBoxButtons.OK)
                                End If
                            Else
                                MessageBox.Show("Please enter a number in the year field", "Enter a value", MessageBoxButtons.OK)
                            End If
                        Else
                            MessageBox.Show("Please enter a number in the interest rate field", "Enter a value", MessageBoxButtons.OK)

                        End If


                    ElseIf (txtFutureValue.Text.Contains(",")) Then 'If the user put a comma in the future value field
                        MessageBox.Show("Take that comma out of the future value field, please", "We don't need the comma", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Please enter a number for a future value", "Enter a  value", MessageBoxButtons.OK)
                    End If





                Else 'Elses for empty field validation
                    MessageBox.Show("Please enter a year amount", "Enter a value", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Please enter an interest rate", "Enter a value", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Please enter a future value", "Enter a value", MessageBoxButtons.OK)

        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears everything
        listRequiredInvestment.Items.Clear()
        txtFutureValue.Clear()
        txtInterestRate.Clear()
        radGold.Checked = False
        radBronze.Checked = False
        radSilver.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes form
        My.Forms.Form1.Close()
    End Sub
End Class
