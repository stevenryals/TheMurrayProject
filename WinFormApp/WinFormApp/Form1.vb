﻿Public Class Form1

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
    Private Sub ButtonCreateCharacter_Click(sender As Object, e As EventArgs) Handles ButtonCreateCharacter.Click
        'Creates and displays character. When character is unspecified, goes 1, 2, 3. Or can create a specified character

        If WhichCharacter() = False Then

            Call SetCharacter(Index)
            NameBox.Text = ""
            AttributeBox.Text = ""
            Call DisplayCharacter(Index, 0, 0)
            Index += 1

        Else

            Call SetCharacter(WhichCharacter)
            NameBox.Text = ""
            AttributeBox.Text = ""
            Call DisplayCharacter(WhichCharacter, 0, 0)

        End If

    End Sub

    Private Sub ButtonResetCharacter_Click(sender As Object, e As EventArgs) Handles ButtonResetCharacter.Click
        'resets specified character
        Call CharacterResetter(WhichCharacter)

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        'Clear ListBox
        ListBox1.Items.Clear()
        ListBox1.Text = ""

    End Sub

    Private Sub ButtonDisplayAllCharacters_Click(sender As Object, e As EventArgs) Handles ButtonDisplayAllCharacters.Click, ButtonCreateCharacter.Click
        'clears listbox then displays character based on each buttons Tag property
        ListBox1.Items.Clear()
        ListBox1.Text = ""

        Dim btn As Button = CType(sender, Button)
        Call DisplayCharacter(0, 1, 2)

    End Sub

    Private Sub ButtonSkillRoller_click(sender As Object, e As EventArgs) Handles ButtonSkillRoll.Click
        'takes initial input of the radiobutton checked and combines it with the Tag of the skill button clicked
        Dim Roll20 = AddD20(WhichCharacterAndSkill(WhichCharacter, WhichSkill))
        RichTextBox1.Text = Roll20.ToString

    End Sub

    Private Sub ButtonUpdateStats_Click(sender As Object, e As EventArgs) Handles ButtonUpdateStats.Click

        ListBox1.Items.Clear()
        ListBox1.Text = ""
        Call UpdateCharacter(WhichCharacterAndSkill(WhichCharacter, WhichSkill)) 
        Call DisplayCharacter(0, 1, 2)

    End Sub

#End Region
#Region "Functions"

    Private Sub SetCharacter(i As Integer)
        'index counts characters entered
        Try
            If i = 0 Then
                Character1.Name = NameBox.Text
                Character1.Attributes = AttributeBox.Text
                Character1.Strength = CInt(StrTicker.Value)
                Character1.Dexterity = CInt(DexTicker.Value)
                Character1.Constitution = CInt(ConTicker.Value)
                Character1.Intelligence = CInt(IntTicker.Value)
                Character1.Wisdom = CInt(WisTicker.Value)
                Character1.Charisma = CInt(ChrTicker.Value)

            ElseIf i = 1 Then
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
        Catch ex As NullReferenceException
        End Try
    End Sub

    Private Sub CharacterResetter(i As Integer)

        'finds what character is selected then resets it
        If i = 0 Then
            Character1.Name = ""
            Character1.Attributes = ""
            Character1.Strength = 0
            Character1.Dexterity = 0
            Character1.Constitution = 0
            Character1.Intelligence = 0
            Character1.Wisdom = 0
            Character1.Charisma = 0
        ElseIf i = 1 Then
            Character2.Name = ""
            Character2.Attributes = ""
            Character2.Strength = 0
            Character2.Dexterity = 0
            Character2.Constitution = 0
            Character2.Intelligence = 0
            Character2.Wisdom = 0
            Character2.Charisma = 0
        Else
            Character3.Name = ""
            Character3.Attributes = ""
            Character3.Strength = 0
            Character3.Dexterity = 0
            Character3.Constitution = 0
            Character3.Intelligence = 0
            Character3.Wisdom = 0
            Character3.Charisma = 0
        End If

    End Sub

    Private Sub DisplayCharacter(i As Integer, Optional j As Integer = 0, Optional l As Integer = 0)
        'create string to display character info
        Dim StrToString1 As String
        Dim StrToString2 As String
        Dim StrToString3 As String
        Dim StrToString4 As String
        Dim StrToString5 As String
        Dim StrToString6 As String

        'string 1 is top row of name and attributes, 2 is second row of your stats
        Try
            If i = 0 Then

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
            End If
            If i = 1 Or j = 1 Then

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
            End If
            If i = 2 Or l = 2 Then

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
            End If

        Catch ex As ArgumentNullException

        End Try

    End Sub

    Private Function WhichCharacter() Handles Character1Radio.CheckedChanged, Character2Radio.CheckedChanged, Character3Radio.CheckedChanged
        'Checks for which character is selected
        Dim radio As Integer
        If Character1Radio.Checked = True Or Character2Radio.Checked = True Or Character3Radio.Checked = True Then
            Try
                If Character1Radio.Checked = True Then
                    radio = 0
                ElseIf Character2Radio.Checked = True Then
                    radio = 1
                Else
                    radio = 2
                End If
                Exit Try
            Catch ex As InvalidCastException
            End Try
            Return True And radio
        Else
            Return False
        End If
    End Function

    Private Function WhichSkill() Handles StrengthRadio.CheckedChanged, DexterityRadio.CheckedChanged, ConstitutionRadio.CheckedChanged, IntelligenceRadio.CheckedChanged, WisdomRadio.CheckedChanged, CharismaRadio.CheckedChanged
        ' Checks which skill is selected
        Dim button As Integer
        Try
            If StrengthRadio.Checked = True Then
                button = 0
            ElseIf DexterityRadio.Checked = True Then
                button = 1
            ElseIf ConstitutionRadio.Checked = True Then
                button = 2
            ElseIf IntelligenceRadio.Checked = True Then
                button = 3
            ElseIf WisdomRadio.Checked = True Then
                button = 4
            Else
                button = 5
            End If
            Exit Try
        Catch ex As InvalidCastException
        End Try
        Return button

    End Function

    Private Function WhichCharacterAndSkill(i As Integer, j As Integer) As Integer

        Try
            Dim Selected As Integer
            If i = 0 Then
                If j = 0 Then
                    Selected = Character1.Strength
                ElseIf j = 1 Then
                    Selected = Character1.Dexterity
                ElseIf j = 2 Then
                    Selected = Character1.Constitution
                ElseIf j = 3 Then
                    Selected = Character1.Intelligence
                ElseIf j = 4 Then
                    Selected = Character1.Wisdom
                ElseIf j = 5 Then
                    Selected = Character1.Charisma
                End If
            ElseIf i = 1 Then
                If j = 0 Then
                    Selected = Character2.Strength
                ElseIf j = 1 Then
                    Selected = Character2.Dexterity
                ElseIf j = 2 Then
                    Selected = Character2.Constitution
                ElseIf j = 3 Then
                    Selected = Character2.Intelligence
                ElseIf j = 4 Then
                    Selected = Character2.Wisdom
                ElseIf j = 5 Then
                    Selected = Character2.Charisma
                End If
            Else
                If j = 0 Then
                    Selected = Character3.Strength
                ElseIf j = 1 Then
                    Selected = Character3.Dexterity
                ElseIf j = 2 Then
                    Selected = Character3.Constitution
                ElseIf j = 3 Then
                    Selected = Character3.Intelligence
                ElseIf j = 4 Then
                    Selected = Character3.Wisdom
                ElseIf j = 5 Then
                    Selected = Character3.Charisma
                End If
            End If

            Return Selected
        Catch ex As NullReferenceException
        End Try


    End Function

    Private Function UpdateCharacter(ByRef Selected)

        'index counts characters entered
        Dim OriginalCharacter As Character = WhichCharacter.Name And WhichCharacter.Attributes And WhichSkill.Value

        Call CharacterResetter(Selected)

        Dim UpdatedCharacter = OriginalCharacter + WhichSkill.Value

        Return UpdatedCharacter

    End Function

    Private Function AddD20(SelectedCharacterAndSkill) As Integer
        ' le dice
        Dim DiceResult As Integer = New Random().Next(0, 21) + SelectedCharacterAndSkill
        Return DiceResult

    End Function

#End Region
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