Public Class Form1
    Dim h As Double
    Dim w As Double
    Dim t As Double
    Dim Result As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = txt1.Text
        h = txt2.Text
        t = w / (h * h)

        If t <= 18.5 Then
            Result = "Underweight"

        ElseIf t >= 18.5 And t <= 24.9 Then
            Result = "Normal weight"
        ElseIf t >= 25 And t <= 29.9 Then
            Result = "Overwight"
        ElseIf t > 30 Then
            Result = "Obesity"
        Else
            Result = "Please Insert Number only"
        End If
        lblResult.Text = Format(t, "0.00")
        lblResult2.Text = Result

    End Sub
End Class
