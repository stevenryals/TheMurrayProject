Public Class Form1

    Public resultBuilder As String = ""

#Region "Random Functions"
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

#End Region

#Region "D&D Characters and dice"

    Public Class character
        Public strength As Integer
        Public dexterity As Integer
        Public constitution As Integer
        Public intelligence As Integer
        Public wisdom As Integer
        Public charisma As Integer
    End Class

    Private Sub Character1Stats()
        Dim MattCharacter As character
        MattCharacter = New character With {
            .strength = 6,
            .dexterity = 6,
            .constitution = 10,
            .intelligence = 17,
            .wisdom = 17,
            .charisma = 17
            }
        Dim Trait1 As String = "Animal Handling - Int - can command animals"
        Dim Trait2 As String = "Perception - Wis - See in dim rooms, see far away objects, and see hidden items."
    End Sub

    Private Sub Character2Stats()
        Dim RachelCharacter As character
        RachelCharacter = New character With {
            .strength = 10,
            .dexterity = 15,
            .constitution = 18,
            .intelligence = 10,
            .wisdom = 12,
            .charisma = 8
        }
        Dim Trait1 As String = "Acrobatics - Dex - Scale obstacles, evade in combat"
        Dim Trait2 As String = "Performance - Chr - Persuade groups of people"
    End Sub

    Private Sub Character3Stats()
        Dim MarissaCharacter As character
        MarissaCharacter = New character With {
            .strength = 18,
            .dexterity = 13,
            .constitution = 15,
            .intelligence = 9,
            .wisdom = 9,
            .charisma = 9
        }
        Dim Trait1 As String = "Stealth - Dex - Can move or perform actions undetectable"
        Dim Trait2 As String = "Athletics - Str - Can use heavy objects and focus strength to hit harder"
        Dim Trait3 As String = "Intimidation - Con - Can command and extort people"
    End Sub

    Public Sub Skill_TextboxChanged(sender As Object, e As EventArgs) Handles Skill.TextChanged
        Try
            Dim response As String = AddDice(Skill.Text)
            RichTextBox1.Text = response
            Exit Try
        Catch ex As InvalidCastException
            Exit Try
        End Try
    End Sub



    Public Sub TwentyDice_Click(sender As Object, e As EventArgs) Handles TwentyDice.Click
        resultBuilder = AddDice(New Random().Next(0, 21)) + CInt(Skill.Text)
        RichTextBox1.Text = resultBuilder
    End Sub

    Public Sub SixDice_Click(sender As Object, e As EventArgs) Handles SixDice.Click
        resultBuilder = AddDice(New Random().Next(2, 13)) + CInt(Skill.Text)
        RichTextBox1.Text = resultBuilder
    End Sub



    Private Function AddDice(Optional ByVal TwentyDice As Integer = 0, Optional ByVal SixDie As Integer = 0) As Integer
        Dim TotalAmount As Integer =TwentyDice + SixDie
        Return TotalAmount
    End Function

#End Region

#Region "Web Scraper"

    'Private Sub Uniswap_Click(Object) Handles Uniswap.Click
    '    Dim getPrice = WebBrowser1_Navigate("https://coinranking.com/market/7C9zn0pFo6+dai-eth-uniswap")
    '    resultBuilder = getPrice
    'End Sub

    'Private Sub Sushiswap_Click() Handles Sushiswap.Click
    '    resultBuilder = WebBrowser1_Navigate("https://coinranking.com/market/HzStwO_SYA+dai-eth-sushiswap")
    '    RichTextBox1 = resultBuilder
    'End Sub

    'Private Sub OneInch_Click(sender As Object, e As EventArgs) Handles OneInch.Click
    '    resultBuilder = Call WebBrowser1_Navigate("https://coinranking.com/market/e4eXYeWe4lo+dai-eth-1inch")
    '    RichTextBox1 = resultBuilder
    'End Sub

    'Public Function WebBrowser1_Navigate(URL)
    '    WebBrowser1.Navigate(URL)
    '    Dim html As String = WebBrowser1.DocumentText
    '    Dim htmldoc As HtmlDocument = New HtmlDocument()
    '    htmldoc.LoadHtml(html)
    '    Dim root As HtmlNode = htmldoc.DocumentNode
    '    Dim tst = root.SelectNodes("//a")  'gets all the links nodes
    '    Dim tst1 As HtmlNode = root.SelectSingleNode("//*[@id='__layout']/div/div[3]/section/div[3]/div/div[1]/div/table/tbody/tr[2]/td[2]")
    '    Return tst1.InnerText
    'End Function

#End Region

End Class