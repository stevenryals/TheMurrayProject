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

    ' This adds 2 numbers together '
    Private Sub addNumbnersButton_Click(sender As Object, e As EventArgs) Handles addNumbersButton.Click
        Dim a As Integer = firstNumberToAddTextBox.Text
        Dim b As Integer = secondNumberToAddTextBox.Text
        Dim c As Integer = a + b
        RichTextBox1.Text = c

        'RichTextBox1.Text = (CInt(firstNumberToAddTextBox.Text) + CInt(secondNumberToAddTextBox.Text)).ToString
        'If firstNumberToAddTextBox.Text.is Then 
    End Sub

    'Check if Int is even or odd, need to print to Answer box (RichTextBox1)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oddOrEvenBtn.Click
        Dim Mynumber As Integer
        Dim isEven As Boolean
        Mynumber = Val(TextBox1.Text)
        Dim oddOrEvenAnswer As String = Mynumber
        RichTextBox1.Text = oddOrEvenAnswer
        If Mynumber Mod 2 = 0 Then
            isEven = True
            MsgBox("The number " & " " & Mynumber & " is an Even number")
        Else
            MsgBox(Mynumber & " " & "is an Odd number")
        End If

    End Sub


End Class


