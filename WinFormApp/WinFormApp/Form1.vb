Imports HtmlAgilityPack

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
    Private Sub Magic8BallButton_Click(sender As Object, e As EventArgs) Handles Magic8BallButton.Click
        Dim fortune As String = getEightBallResponse(productTextbox.Text)
        RichTextBox1.Text = fortune
    End Sub



    ' math random should be set to a variable then assigned to strings '
    Private Function getEightBallResponse(ByVal str As String) As String
        Dim options() As String = {"This will Never Happen", "This will happen soon", "Your are not capable", "aha no", "perhaps"}
        Return RichTextBox1.Text = options(New Random().Next(0, 4))
    End Function









    Public resultBuilder As String = ""
    Private Sub Uniswap_Click(sender As Object, e As EventArgs) Handles Uniswap.Click
        Dim URL As String = "https://www.google.com/search?q=uniswap+dai+to+eth+price&oq=uniswap+dai+to+eth+price&&uact=5"
        WebBrowser1.Navigate(URL)
    End Sub

    Private Sub Sushiswap_Click(sender As Object, e As EventArgs) Handles Sushiswap.Click
        Dim URL As String = "https://www.google.com/search?q=sushiswap+dai+to+eth+price"
        WebBrowser1.Navigate(URL)
    End Sub

    Private Sub OneInch_Click(sender As Object, e As EventArgs) Handles OneInch.Click
        Dim URL As String = "https://www.google.com/search?q=uniswap+dai+to+eth+price&oq=uniswap+dai+to+eth+price&&uact=5"
        WebBrowser1.Navigate(URL)
    End Sub

    Private Sub Curve_Click(sender As Object, e As EventArgs) Handles Curve.Click
        Dim URL As String = "https://www.google.com/search?q=uniswap+dai+to+eth+price&oq=uniswap+dai+to+eth+price&&uact=5"
        WebBrowser1.Navigate(URL)
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(Sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        Dim html As String = WebBrowser1.DocumentText
        Dim htmldoc As HtmlDocument = New HtmlDocument()
        htmldoc.LoadHtml(html)
        Dim root As HtmlNode = htmldoc.DocumentNode
        Dim tst = root.SelectNodes("//a")  'gets all the links nodes
        Dim tst1 As HtmlNode = root.SelectSingleNode("//html/head/title")
        Dim tst2 As HtmlNode = root.SelectSingleNode("//*[@id='rso']/div[1]/div/div[1]/div/div[1]/div/div[1]/div/div[2]/table/tbody/tr[2]/td[2]")
        resultBuilder = tst2.InnerText
        RichTextBox1.Text = resultBuilder

    End Sub

End Class

