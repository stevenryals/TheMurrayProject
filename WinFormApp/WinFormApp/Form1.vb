Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim response As String = transform(productTextbox.Text)
        resultTextBox.Text = response
    End Sub

    Private Function transform(ByVal str As String)
        Dim ss As String = str.Substring(str.Length - 1, 1)

        Dim backwards As String = ""
        Dim i As Integer = -1
        While i > ((str.Length + 1) * -1)
            backwards = backwards + str.Substring(str.Length + i, 1)
            i = i - 1
        End While

        Return backwards
    End Function
End Class


