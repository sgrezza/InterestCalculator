Public Class Form1
    Private Function PresentValue(futureValue As Integer, years As Integer, rate As Decimal) As Integer
        Dim intPresentValue As Integer
        intPresentValue = futureValue / ((1 + (rate / 100)) ^ years)   'Math
        Return intPresentValue
    End Function
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables
        Dim decGoldRate As Decimal = 0.03         'Rate from Gold membership
        Dim decSilverRate As Decimal = 0.02       'Rate from Silver membership
        Dim decBronzeRate As Decimal = 0.01       'Rate from Bronze membership
        Dim intFutureValue, intYears As Integer   'Future value and years
        Dim decInterestRate As Decimal = 0            'Interest rate

        'First, we make sure the user entered anything at all in the input fields
        If (txtFutureValue.Text IsNot "") Then
            If (txtInterestRate.Text IsNot "") Then
                If (cmbYears.Text IsNot "") Then
                    'Then we make sure the user put in a number and not a string
                    If Integer.TryParse(txtFutureValue.Text, intFutureValue) Then
                        If Decimal.TryParse(txtInterestRate.Text, decInterestRate) Then
                            If Integer.TryParse(cmbYears.Text, intYears) Then
                                'Calculate the user's interest rate based on their future value input
                                Select Case decInterestRate
                                    Case intFutureValue >= 50000
                                        decInterestRate += 1.0
                                    Case intFutureValue >= 30000 AndAlso intFutureValue <= 49999
                                        decInterestRate += 0.5
                                    Case intFutureValue >= 10000 AndAlso intFutureValue <= 29999
                                        decInterestRate += 0.02
                                End Select
                                'Check user's membership
                                If (radGold.Checked) Then
                                    decInterestRate += decGoldRate
                                    MessageBox.Show(PresentValue(intFutureValue, intYears, decInterestRate))
                                ElseIf (radSilver.Checked) Then
                                    decInterestRate += decSilverRate
                                    MessageBox.Show(PresentValue(intFutureValue, intYears, decInterestRate))
                                ElseIf (radBronze.Checked) Then
                                    decInterestRate += decBronzeRate
                                    MessageBox.Show(PresentValue(intFutureValue, intYears, decInterestRate))





                                Else
                                    MessageBox.Show("Please select a membership", "Select a membership", MessageBoxButtons.OK)
                                End If
                            Else
                                MessageBox.Show("Please enter a number in the year field", "Enter a value", MessageBoxButtons.OK)
                            End If
                        Else
                            MessageBox.Show("Please enter a number in the interest rate field", "Enter a value", MessageBoxButtons.OK)

                        End If
                        'In case the user puts a comma in the future value field
                    ElseIf (txtFutureValue.Text.Contains(",")) Then
                        MessageBox.Show("Take that comma out of the future value field, please", "We don't need the comma", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Please enter a number for a future value", "Enter a  value", MessageBoxButtons.OK)
                    End If




                    'Elses for empty field validation
                Else
                    MessageBox.Show("Please enter a year amount", "Enter a value", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Please enter an interest rate", "Enter a value", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Please enter a future value", "Enter a value", MessageBoxButtons.OK)

        End If


    End Sub
End Class
