Public Class Form1

    Public Sub New()
        InitializeComponent()
        EightBallLabel.Text = "Magic 8 Ball: " + vbNewLine + "Ask Me A Question"

    End Sub

    Public Sub backwardsButton_Click(sender As Object, e As EventArgs) Handles backwardsButton.Click
        Dim response As String = makeItBackwards(productTextbox.Text)
        RichTextBox1.Text = response
    End Sub

    Private Function makeItBackwards(ByVal str As String)
        Dim ss As String = str.Substring(str.Length - 1, 1)

        Dim backwards As String = ""
        Dim i As Integer = -1
        While i > ((str.Length + 1) * -1)
            backwards = backwards + str.Substring(str.Length + i, 1)
            i = i - 1
        End While


        Return backwards
    End Function

    ' start of magic 8 ball ' 
    ' set random number generator 0-4, then assign each integer to a response string that will display into results. '
    Private Sub Magic8Ball_Click(sender As Object, e As EventArgs) Handles Magic8BallButton.Click
        Dim fortune As String = getEightBallResponse(productTextbox.Text)
        RichTextBox1.Text = fortune
    End Sub
    ' math random should be set to a variable then assigned to strings '
    Private Function getEightBallResponse(ByVal str As String) As String
        Dim whichResponse As Integer = New Random().Next(0, 4)
        If whichResponse = 0 Then
            Return "This will never happen"
        ElseIf whichResponse = 1 Then
            Return "This will happen soon."
        ElseIf whichResponse = 2 Then
            Return "You are not capable."
        ElseIf whichResponse = 3 Then
            Return "Aha no."
        ElseIf whichResponse = 4 Then
            Return "Perhaps"
        Else
            Return "whoever changed my code.... you SUCK"
        End If
    End Function

End Class


