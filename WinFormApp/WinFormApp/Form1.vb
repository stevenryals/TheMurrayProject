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

    'Store player objects
    Dim Character1 As Character
    Dim Character2 As Character
    Dim Character3 As Character
    Dim Index As Integer = 1

    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        'Create Character instances
        Character1 = New Character()
        Character2 = New Character()
        Character3 = New Character()

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
        Dim TotalAmount As Integer = TwentyDice + SixDie
        Return TotalAmount
    End Function

    Private Sub ButtonCreateCharacter_Click(sender As Object, e As EventArgs) Handles ButtonCreateCharacter.Click
        Call SetCharacter()
        'clear form
        NameBox.Text = ""
        AttributeBox.Text = ""
        StrengthBox.Text = ""
        DexterityBox.Text = ""
        ConstitutionBox.Text = ""
        IntelligenceBox.Text = ""
        WisdomBox.Text = ""
        CharismaBox.Text = ""

        Index += 1
    End Sub

    Private Sub SetCharacter()
        'index counts characters entered
        If Index = 1 Then
            Character1.Name = NameBox.Text
            Character1.Attributes = AttributeBox.Text
            Character1.Strength = CInt(StrengthBox.Text)
            Character1.Dexterity = CInt(DexterityBox.Text)
            Character1.Constitution = CInt(ConstitutionBox.Text)
            Character1.Intelligence = CInt(IntelligenceBox.Text)
            Character1.Wisdom = CInt(WisdomBox.Text)
            Character1.Charisma = CInt(CharismaBox.Text)

        ElseIf Index = 2 Then
            Character2.Name = NameBox.Text
            Character2.Attributes = AttributeBox.Text
            Character2.Strength = CInt(StrengthBox.Text)
            Character2.Dexterity = CInt(DexterityBox.Text)
            Character2.Constitution = CInt(ConstitutionBox.Text)
            Character2.Intelligence = CInt(IntelligenceBox.Text)
            Character2.Wisdom = CInt(WisdomBox.Text)
            Character2.Charisma = CInt(CharismaBox.Text)

        Else
            Character3.Name = NameBox.Text
            Character3.Attributes = AttributeBox.Text
            Character3.Strength = CInt(StrengthBox.Text)
            Character3.Dexterity = CInt(DexterityBox.Text)
            Character3.Constitution = CInt(ConstitutionBox.Text)
            Character3.Intelligence = CInt(IntelligenceBox.Text)
            Character3.Wisdom = CInt(WisdomBox.Text)
            Character3.Charisma = CInt(CharismaBox.Text)
        End If
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged

    End Sub

    Private Sub AttributeBox_TextChanged(sender As Object, e As EventArgs) Handles AttributeBox.TextChanged

    End Sub

    Private Sub StrengthBox_TextChanged(sender As Object, e As EventArgs) Handles StrengthBox.TextChanged

    End Sub

    Private Sub DexterityBox_TextChanged(sender As Object, e As EventArgs) Handles DexterityBox.TextChanged

    End Sub

    Private Sub ConstitutionBox_TextChanged(sender As Object, e As EventArgs) Handles ConstitutionBox.TextChanged

    End Sub

    Private Sub IntelligenceBox_TextChanged(sender As Object, e As EventArgs) Handles IntelligenceBox.TextChanged

    End Sub

    Private Sub WisdomBox_TextChanged(sender As Object, e As EventArgs) Handles WisdomBox.TextChanged

    End Sub

    Private Sub CharismaBox_TextChanged(sender As Object, e As EventArgs) Handles CharismaBox.TextChanged

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        'Clear ListBox
        ListBox1.Items.Clear()
        ListBox1.Text = ""
    End Sub

    Private Sub ButtonDisplayCharacter_Click(sender As Object, e As EventArgs) Handles ButtonDisplayCharacter1.Click, ButtonDisplayCharacter2.Click, ButtonDisplayCharacter3.Click

        Dim btn As Button = CType(sender, Button)
        Call DisplayCharacter(btn.Tag)

    End Sub

    Private Sub DisplayCharacter(i As Integer)
        'create string to display character info
        Dim StrToString As String = ""

        'set string to desired output
        If i = 0 Then
            StrToString = Character1.Name & " " _
                & Character1.Attributes _
                & " STR: " & Character1.Strength _
                & " DEX: " & Character1.Dexterity _
                & " CON: " & Character1.Constitution _
                & " INT: " & Character1.Intelligence _
                & " WIS: " & Character1.Wisdom _
                & " CHR: " & Character1.Charisma
        ElseIf i = 1 Then
            StrToString = Character3.Name & " " _
                & Character2.Attributes _
                & " STR: " & Character2.Strength _
                & " DEX: " & Character2.Dexterity _
                & " CON: " & Character2.Constitution _
                & " INT: " & Character2.Intelligence _
                & " WIS: " & Character2.Wisdom _
                & " CHR: " & Character2.Charisma
        Else
            StrToString = Character3.Name & " " _
                & Character3.Attributes _
                & " STR: " & Character3.Strength _
                & " DEX: " & Character3.Dexterity _
                & " CON: " & Character3.Constitution _
                & " INT: " & Character3.Intelligence _
                & " WIS: " & Character3.Wisdom _
                & " CHR: " & Character3.Charisma
        End If

        ListBox1.Items.Add(StrToString)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

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