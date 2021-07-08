Public Class Form1

    Public Sub New()
        InitializeComponent()
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

    Private Sub firstNumberToAddTextBox_TextChanged(sender As Object, e As EventArgs) Handles firstNumberToAddTextBox.TextChanged

    End Sub


    ' start of magic 8 ball ' 
    ' set random number generator 0-4, then assign each integer to a response string that will display into results. '
    Private Sub Magic8Ball_Click(sender As Object, e As EventArgs) Handles Magic8BallButton.Click
        Dim getFortune As String = getResponse(productTextbox.Text)
        RichTextBox1.Text = getFortune
    End Sub
    ' math random should be set to a variable then assigned to strings '
    Private Function getResponse(ByVal str As String) As String
        Dim randomizer As New Random()
        Dim whichResponse As Integer = randomizer.Next(0, 4)
        Dim response As String
        If whichResponse = 0 Then
            response = "This will never happen"
        ElseIf whichResponse = 1 Then
            response = "This will happen soon."
        ElseIf whichResponse = 2 Then
            response = "You are not capable."
        ElseIf whichResponse = 3 Then
            response = "Aha no."
        ElseIf whichResponse = 4 Then
            response = "Perhaps"
        End If
        Return response
    End Function

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class


