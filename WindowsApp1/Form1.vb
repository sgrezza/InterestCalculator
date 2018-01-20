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


    End Sub
End Class
