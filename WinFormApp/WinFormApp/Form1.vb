Imports HtmlAgilityPack

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

#Region "D&D Player"
#Region "Character Instantiate"
    Public Class Character

        Public Name As String
        Public Attributes As String
        Public Strength As Integer
        Public Dexterity As Integer
        Public Constitution As Integer
        Public Intelligence As Integer
        Public Wisdom As Integer
        Public Charisma As Integer

    End Class

    'Store player objects
    Dim Character1 As Character
    Dim Character2 As Character
    Dim Character3 As Character
    Dim Index As Integer = 0

    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        'Create Character instances

        Character1 = New Character()
        Character2 = New Character()
        Character3 = New Character()

    End Sub

#End Region
#Region "Buttons"
    Private Sub ButtonCreateCharacter_Click() Handles ButtonCreateCharacter.Click
        'Creates and displays character. When character is unspecified, goes 1, 2, 3. Or can create a specified character

        If WhichCharacter() Is Nothing Then


            Call SetCharacter(Nothing, Index)
            Index += 1
            If Index = 3 Then

                Index = 0

            End If

        Else

            Call SetCharacter(WhichCharacter, Nothing)

        End If

        Call DisplaysCharacters()
        Call ClearForm()

    End Sub

    Private Sub ButtonResetCharacter_Click() Handles ButtonResetCharacter.Click

        'resets specified character
        Call CharacterResetter(WhichCharacter)

    End Sub

    Private Sub ButtonClear_Click() Handles ButtonClear.Click

        'Clear ListBox
        ListBox1.Items.Clear()
        ListBox1.Text = ""

    End Sub

    Private Sub ButtonDisplayAllCharacters_Click(sender As Object, e As EventArgs) Handles ButtonDisplayAllCharacters.Click, ButtonCreateCharacter.Click

        'clears listbox then displays character based on each buttons Tag property
        ListBox1.Items.Clear()
        ListBox1.Text = ""

        Dim btn As Button = CType(sender, Button)
        Call DisplaysCharacters()

    End Sub

    Private Sub ButtonSkillRoller_click(sender As Object, e As EventArgs) Handles ButtonSkillRoll.Click

        'takes initial input of the radiobutton checked and combines it with the Tag of the skill button clicked
        Dim Roll20 = AddD20(SkillOfSelectedCharacter(WhichCharacter))
        RichTextBox1.Text = Roll20.ToString

    End Sub

    Private Sub ButtonUpdateStats_Click(sender As Object, e As EventArgs) Handles ButtonUpdateStats.Click

        ListBox1.Items.Clear()
        ListBox1.Text = ""
        'Call UpdateCharacter(SkillOfSelectedCharacter(WhichCharacter))
        Call DisplaysCharacters()

    End Sub

#End Region
#Region "Functions"

    Private Sub SetCharacter(Optional SelectedCharacter As Character = Nothing, Optional Index As Integer = 0)

        'index counts characters entered
        Try

            If SelectedCharacter IsNot Nothing Then

                SelectedCharacter.Name = NameBox.Text
                SelectedCharacter.Attributes = AttributeBox.Text
                SelectedCharacter.Strength = CInt(StrTicker.Value)
                SelectedCharacter.Dexterity = CInt(DexTicker.Value)
                SelectedCharacter.Constitution = CInt(ConTicker.Value)
                SelectedCharacter.Intelligence = CInt(IntTicker.Value)
                SelectedCharacter.Wisdom = CInt(WisTicker.Value)
                SelectedCharacter.Charisma = CInt(ChrTicker.Value)

            Else

                If Index = 0 Then

                    Character1.Name = NameBox.Text
                    Character1.Attributes = AttributeBox.Text
                    Character1.Strength = CInt(StrTicker.Value)
                    Character1.Dexterity = CInt(DexTicker.Value)
                    Character1.Constitution = CInt(ConTicker.Value)
                    Character1.Intelligence = CInt(IntTicker.Value)
                    Character1.Wisdom = CInt(WisTicker.Value)
                    Character1.Charisma = CInt(ChrTicker.Value)

                ElseIf Index = 1 Then

                    Character2.Name = NameBox.Text
                    Character2.Attributes = AttributeBox.Text
                    Character2.Strength = CInt(StrTicker.Value)
                    Character2.Dexterity = CInt(DexTicker.Value)
                    Character2.Constitution = CInt(ConTicker.Value)
                    Character2.Intelligence = CInt(IntTicker.Value)
                    Character2.Wisdom = CInt(WisTicker.Value)
                    Character2.Charisma = CInt(ChrTicker.Value)

                Else

                    Character3.Name = NameBox.Text
                    Character3.Attributes = AttributeBox.Text
                    Character3.Strength = CInt(StrTicker.Value)
                    Character3.Dexterity = CInt(DexTicker.Value)
                    Character3.Constitution = CInt(ConTicker.Value)
                    Character3.Intelligence = CInt(IntTicker.Value)
                    Character3.Wisdom = CInt(WisTicker.Value)
                    Character3.Charisma = CInt(ChrTicker.Value)

                End If

            End If

        Catch ex As NullReferenceException

        End Try

    End Sub

    Private Sub CharacterResetter(SelectedCharacter As Character)

        'finds what character is selected then resets it

        SelectedCharacter.Name = ""
        SelectedCharacter.Attributes = ""
        SelectedCharacter.Strength = 0
        SelectedCharacter.Dexterity = 0
        SelectedCharacter.Constitution = 0
        SelectedCharacter.Intelligence = 0
        SelectedCharacter.Wisdom = 0
        SelectedCharacter.Charisma = 0

    End Sub

    Private Sub DisplaysCharacters()

        'create string to display character info
        Dim StrToString1 As String
        Dim StrToString2 As String
        Dim StrToString3 As String
        Dim StrToString4 As String
        Dim StrToString5 As String
        Dim StrToString6 As String

        'string 1 is top row of name and attributes, 2 is second row of your stats
        Try


            StrToString1 = "1. " & Character1.Name & ":  " _
                    & Character1.Attributes
            StrToString2 = "   STR: " & Character1.Strength _
                    & "  DEX: " & Character1.Dexterity _
                    & "  CON: " & Character1.Constitution _
                    & "  INT: " & Character1.Intelligence _
                    & "  WIS: " & Character1.Wisdom _
                    & "  CHR: " & Character1.Charisma

            ListBox1.Items.Add(StrToString1)
            ListBox1.Items.Add(StrToString2)



            StrToString3 = "2. " & Character2.Name & ":  " _
                    & Character2.Attributes
            StrToString4 = "   STR: " & Character2.Strength _
                & "  DEX: " & Character2.Dexterity _
                & "  CON: " & Character2.Constitution _
                & "  INT: " & Character2.Intelligence _
                & "  WIS: " & Character2.Wisdom _
                & "  CHR: " & Character2.Charisma

            ListBox1.Items.Add(StrToString3)
            ListBox1.Items.Add(StrToString4)


            StrToString5 = "3. " & Character3.Name & ":  " _
                    & Character3.Attributes
            StrToString6 = "   STR: " & Character3.Strength _
                    & "  DEX: " & Character3.Dexterity _
                    & "  CON: " & Character3.Constitution _
                    & "  INT: " & Character3.Intelligence _
                    & "  WIS: " & Character3.Wisdom _
                    & "  CHR: " & Character3.Charisma

            ListBox1.Items.Add(StrToString5)
            ListBox1.Items.Add(StrToString6)


        Catch ex As ArgumentNullException

        End Try

    End Sub

    Private Function WhichCharacter()

        'Checks for which character is selected

        Dim SelectedCharacter As Character

        Try
            If Character1Radio.Checked = True Then

                SelectedCharacter = Character1
                Return SelectedCharacter

            ElseIf Character2Radio.Checked = True Then

                SelectedCharacter = Character2
                Return SelectedCharacter

            ElseIf Character3Radio.Checked = True Then

                SelectedCharacter = Character3

                Return SelectedCharacter

            Else

                Return Nothing

            End If

            Exit Try

        Catch ex As NullReferenceException

        End Try

    End Function



    Private Function SkillOfSelectedCharacter(SelectedCharacter As Character) As Integer

        Try

            Dim CharacterAndSkillSelected As Integer


            If StrengthRadio.Checked Then

                CharacterAndSkillSelected = SelectedCharacter.Strength

            ElseIf DexterityRadio.Checked Then

                CharacterAndSkillSelected = SelectedCharacter.Dexterity

            ElseIf ConstitutionRadio.Checked Then

                CharacterAndSkillSelected = SelectedCharacter.Constitution

            ElseIf IntelligenceRadio.Checked Then

                CharacterAndSkillSelected = SelectedCharacter.Intelligence

            ElseIf WisdomRadio.Checked Then

                CharacterAndSkillSelected = SelectedCharacter.Wisdom

            ElseIf CharismaRadio.Checked Then

                CharacterAndSkillSelected = SelectedCharacter.Charisma

            End If

            Return CharacterAndSkillSelected

        Catch ex As NullReferenceException

        End Try

    End Function

    Private Function UpdateCharacter(SelectedCharacter As Character)

        'index counts characters entered
        Dim OriginalCharacter As Character
        OriginalCharacter.Name = WhichCharacter.Name
        OriginalCharacter.Attributes = WhichCharacter.Attributes


        Call CharacterResetter(SelectedCharacter)

        'Dim UpdatedCharacter = OriginalCharacter + SkillOfSelectedCharacter(WhichCharacter)

        Return OriginalCharacter

    End Function

    Private Function AddD20(SelectedCharacterAndSkill) As Integer
        ' le dice
        Dim DiceResult As Integer = New Random().Next(0, 21) + SkillOfSelectedCharacter(WhichCharacter)
        Return DiceResult

    End Function

    Private Sub ClearForm()

        NameBox.Text = ""
        AttributeBox.Text = ""
        StrTicker.Value = 10
        DexTicker.Value = 10
        ConTicker.Value = 10
        IntTicker.Value = 10
        WisTicker.Value = 10
        ChrTicker.Value = 10

    End Sub

#End Region
#End Region

#Region "Web Scraper"
#Region "Buttons"
    Private Sub DaiToEthPrices_Click() Handles DaiToEthPrices.Click

        RichTextBox1.Text = "Via https://coinranking.com" & vbCrLf & vbCrLf _
        & "Uniswap: " & ScrapeDaiToEthPriceCoinranking("https://coinranking.com/market/7C9zn0pFo6+dai-eth-uniswap") & vbCrLf _
        & "Shushiswap: " & ScrapeDaiToEthPriceCoinranking("https://coinranking.com/market/HzStwO_SYA+dai-eth-sushiswap") & vbCrLf _
        & "1inch: " & ScrapeDaiToEthPriceCoinranking("https://coinranking.com/market/e4eXYeWe4lo%2Bdai-eth-1inch") & vbCrLf _
        & "Kyber Network: " & ScrapeDaiToEthPriceCoinranking("https://coinranking.com/market/tclz4I8eFR%2Bdai-eth-kyber-network") & vbCrLf _
        & "LinTax: " & ScrapeDaiToEthPriceCoinranking("https://coinranking.com/market/ReIMxQiTdz%2Bdai-eth-lintax")


    End Sub

    Private Sub WebBrowserScraper_Click() Handles WebBrowserScraper.Click

        RichTextBox1.Text = WebScrapeForTitle(WebScrape1TextBox.Text)
        Call WebBrowserNavigate("https://www." & WebScrape1TextBox.Text)

    End Sub

    Private Sub ButtonManUTopPlayers_Click(sender As Object, e As EventArgs) Handles ButtonManUTopPlayers.Click

        RichTextBox1.Text = ScrapeManUTopPlayersRating("https://www.whoscored.com/Teams/32/Show/England-Manchester-United")

    End Sub

#End Region

#Region "Functions"

    Private Function WebScrapeForTitle(URL As String)

        Dim Web = New HtmlWeb
        Dim Doc = Web.Load(URL)
        Dim TitleNode = Doc.DocumentNode.SelectSingleNode("/html/head/title")
        Dim Title As String
        If TitleNode IsNot Nothing Then
            Title = TitleNode.InnerText
            Return Title
        End If

        Return "Title not found"

    End Function

    Private Sub WebBrowserNavigate(URL As String)

        WebBrowser1.Navigate(URL)

    End Sub

    Private Function ScrapeDaiToEthPriceCoinranking(URL As String)

        Dim GivenURL = URL
        Dim Web = New HtmlWeb
        Dim Doc = Web.Load(GivenURL)
        Dim TitleNode = Doc.DocumentNode.SelectSingleNode("//*[@id='__layout']/div/div[3]/section/div[3]/div/div[1]/div/table/tbody/tr[2]/td[2]")
        Dim Title As String
        If TitleNode IsNot Nothing Then
            Title = TitleNode.InnerText
            Return Title
        End If

        Return "No data for this exchange"

    End Function

    Private Function ScrapeManUTopPlayersRating(URL As String)

        Dim GivenURL = URL
        Dim Web = New HtmlWeb
        Dim Doc = Web.Load(GivenURL)
        Dim TitleNode = Doc.DocumentNode.SelectSingleNode("//*[@id='player-table-statistics-body']/tr[1]/td[2]")
        Dim Title As String
        If TitleNode IsNot Nothing Then
            Title = TitleNode.InnerHtml
            Return Title
        End If

        Return "Error, guess they just suck?"

    End Function

#End Region

#End Region

End Class