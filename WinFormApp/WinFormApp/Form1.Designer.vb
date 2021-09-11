<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.productTextbox = New System.Windows.Forms.TextBox()
        Me.backwardsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.firstNumberToAddTextBox = New System.Windows.Forms.TextBox()
        Me.secondNumberToAddTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EightBallLabel = New System.Windows.Forms.Label()
        Me.Magic8BallButton = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.DaiToEthPrices = New System.Windows.Forms.Button()
        Me.WebScrape1TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.AttributeBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButtonCreateCharacter = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDisplayAllCharacters = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Character3Radio = New System.Windows.Forms.RadioButton()
        Me.Character2Radio = New System.Windows.Forms.RadioButton()
        Me.Character1Radio = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CharismaRadio = New System.Windows.Forms.RadioButton()
        Me.WisdomRadio = New System.Windows.Forms.RadioButton()
        Me.IntelligenceRadio = New System.Windows.Forms.RadioButton()
        Me.ConstitutionRadio = New System.Windows.Forms.RadioButton()
        Me.DexterityRadio = New System.Windows.Forms.RadioButton()
        Me.StrengthRadio = New System.Windows.Forms.RadioButton()
        Me.ButtonSkillRoll = New System.Windows.Forms.Button()
        Me.StrTicker = New System.Windows.Forms.NumericUpDown()
        Me.ChrTicker = New System.Windows.Forms.NumericUpDown()
        Me.WisTicker = New System.Windows.Forms.NumericUpDown()
        Me.IntTicker = New System.Windows.Forms.NumericUpDown()
        Me.ConTicker = New System.Windows.Forms.NumericUpDown()
        Me.DexTicker = New System.Windows.Forms.NumericUpDown()
        Me.ButtonResetCharacter = New System.Windows.Forms.Button()
        Me.ButtonUpdateStats = New System.Windows.Forms.Button()
        Me.WebBrowserScraper = New System.Windows.Forms.Button()
        Me.Character5Radio = New System.Windows.Forms.RadioButton()
        Me.Character4Radio = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StrTicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrTicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WisTicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntTicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConTicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DexTicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'productTextbox
        '
        Me.productTextbox.Location = New System.Drawing.Point(128, 21)
        Me.productTextbox.Name = "productTextbox"
        Me.productTextbox.Size = New System.Drawing.Size(111, 20)
        Me.productTextbox.TabIndex = 0
        '
        'backwardsButton
        '
        Me.backwardsButton.Location = New System.Drawing.Point(245, 19)
        Me.backwardsButton.Name = "backwardsButton"
        Me.backwardsButton.Size = New System.Drawing.Size(134, 23)
        Me.backwardsButton.TabIndex = 1
        Me.backwardsButton.Text = "Make it Backwards"
        Me.backwardsButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "String to Reverse"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(705, 403)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(264, 236)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(702, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Results Go Here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "numbers to add"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add the numbers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'firstNumberToAddTextBox
        '
        Me.firstNumberToAddTextBox.Location = New System.Drawing.Point(128, 58)
        Me.firstNumberToAddTextBox.Name = "firstNumberToAddTextBox"
        Me.firstNumberToAddTextBox.Size = New System.Drawing.Size(26, 20)
        Me.firstNumberToAddTextBox.TabIndex = 5
        '
        'secondNumberToAddTextBox
        '
        Me.secondNumberToAddTextBox.Location = New System.Drawing.Point(184, 58)
        Me.secondNumberToAddTextBox.Name = "secondNumberToAddTextBox"
        Me.secondNumberToAddTextBox.Size = New System.Drawing.Size(26, 20)
        Me.secondNumberToAddTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "+"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 114)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 57)
        Me.TextBox1.TabIndex = 10
        '
        'EightBallLabel
        '
        Me.EightBallLabel.AutoSize = True
        Me.EightBallLabel.Location = New System.Drawing.Point(29, 117)
        Me.EightBallLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EightBallLabel.Name = "EightBallLabel"
        Me.EightBallLabel.Size = New System.Drawing.Size(71, 13)
        Me.EightBallLabel.TabIndex = 11
        Me.EightBallLabel.Text = "Magic 8 Ball: "
        '
        'Magic8BallButton
        '
        Me.Magic8BallButton.Location = New System.Drawing.Point(245, 117)
        Me.Magic8BallButton.Margin = New System.Windows.Forms.Padding(2)
        Me.Magic8BallButton.Name = "Magic8BallButton"
        Me.Magic8BallButton.Size = New System.Drawing.Size(134, 21)
        Me.Magic8BallButton.TabIndex = 12
        Me.Magic8BallButton.Text = "Get Your Answer"
        Me.Magic8BallButton.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(9, 224)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(15, 16)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(400, 417)
        Me.WebBrowser1.TabIndex = 13
        '
        'DaiToEthPrices
        '
        Me.DaiToEthPrices.Location = New System.Drawing.Point(419, 224)
        Me.DaiToEthPrices.Margin = New System.Windows.Forms.Padding(2)
        Me.DaiToEthPrices.Name = "DaiToEthPrices"
        Me.DaiToEthPrices.Size = New System.Drawing.Size(89, 20)
        Me.DaiToEthPrices.TabIndex = 14
        Me.DaiToEthPrices.Text = "Dai - Eth Prices"
        Me.DaiToEthPrices.UseVisualStyleBackColor = True
        '
        'WebScrape1TextBox
        '
        Me.WebScrape1TextBox.Location = New System.Drawing.Point(123, 191)
        Me.WebScrape1TextBox.Name = "WebScrape1TextBox"
        Me.WebScrape1TextBox.Size = New System.Drawing.Size(290, 20)
        Me.WebScrape1TextBox.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Enter Web Site URL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Name"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(162, 55)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(76, 20)
        Me.NameBox.TabIndex = 42
        '
        'AttributeBox
        '
        Me.AttributeBox.Location = New System.Drawing.Point(162, 79)
        Me.AttributeBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AttributeBox.Name = "AttributeBox"
        Me.AttributeBox.Size = New System.Drawing.Size(76, 20)
        Me.AttributeBox.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 30)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Attribute"
        '
        'ButtonCreateCharacter
        '
        Me.ButtonCreateCharacter.Location = New System.Drawing.Point(243, 79)
        Me.ButtonCreateCharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCreateCharacter.Name = "ButtonCreateCharacter"
        Me.ButtonCreateCharacter.Size = New System.Drawing.Size(80, 43)
        Me.ButtonCreateCharacter.TabIndex = 45
        Me.ButtonCreateCharacter.Text = "Create Character"
        Me.ButtonCreateCharacter.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(1278, 528)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(175, 19)
        Me.ButtonClear.TabIndex = 46
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonDisplayAllCharacters
        '
        Me.ButtonDisplayAllCharacters.Location = New System.Drawing.Point(1093, 528)
        Me.ButtonDisplayAllCharacters.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDisplayAllCharacters.Name = "ButtonDisplayAllCharacters"
        Me.ButtonDisplayAllCharacters.Size = New System.Drawing.Size(175, 19)
        Me.ButtonDisplayAllCharacters.TabIndex = 47
        Me.ButtonDisplayAllCharacters.Tag = "0"
        Me.ButtonDisplayAllCharacters.Text = "Display Characters"
        Me.ButtonDisplayAllCharacters.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1093, 328)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(360, 196)
        Me.ListBox1.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Character5Radio)
        Me.GroupBox1.Controls.Add(Me.Character4Radio)
        Me.GroupBox1.Controls.Add(Me.Character3Radio)
        Me.GroupBox1.Controls.Add(Me.Character2Radio)
        Me.GroupBox1.Controls.Add(Me.Character1Radio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 129)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'Character3Radio
        '
        Me.Character3Radio.AutoSize = True
        Me.Character3Radio.Location = New System.Drawing.Point(0, 65)
        Me.Character3Radio.Name = "Character3Radio"
        Me.Character3Radio.Size = New System.Drawing.Size(80, 17)
        Me.Character3Radio.TabIndex = 2
        Me.Character3Radio.TabStop = True
        Me.Character3Radio.Tag = "2"
        Me.Character3Radio.Text = "Character 3"
        Me.Character3Radio.UseVisualStyleBackColor = True
        '
        'Character2Radio
        '
        Me.Character2Radio.AutoSize = True
        Me.Character2Radio.Location = New System.Drawing.Point(0, 42)
        Me.Character2Radio.Name = "Character2Radio"
        Me.Character2Radio.Size = New System.Drawing.Size(80, 17)
        Me.Character2Radio.TabIndex = 1
        Me.Character2Radio.TabStop = True
        Me.Character2Radio.Tag = "1"
        Me.Character2Radio.Text = "Character 2"
        Me.Character2Radio.UseVisualStyleBackColor = True
        '
        'Character1Radio
        '
        Me.Character1Radio.AutoSize = True
        Me.Character1Radio.Location = New System.Drawing.Point(0, 19)
        Me.Character1Radio.Name = "Character1Radio"
        Me.Character1Radio.Size = New System.Drawing.Size(80, 17)
        Me.Character1Radio.TabIndex = 0
        Me.Character1Radio.TabStop = True
        Me.Character1Radio.Tag = "0"
        Me.Character1Radio.Text = "Character 1"
        Me.Character1Radio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CharismaRadio)
        Me.GroupBox2.Controls.Add(Me.WisdomRadio)
        Me.GroupBox2.Controls.Add(Me.IntelligenceRadio)
        Me.GroupBox2.Controls.Add(Me.ConstitutionRadio)
        Me.GroupBox2.Controls.Add(Me.DexterityRadio)
        Me.GroupBox2.Controls.Add(Me.StrengthRadio)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(105, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(52, 180)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'CharismaRadio
        '
        Me.CharismaRadio.AutoSize = True
        Me.CharismaRadio.Location = New System.Drawing.Point(10, 164)
        Me.CharismaRadio.Name = "CharismaRadio"
        Me.CharismaRadio.Size = New System.Drawing.Size(41, 17)
        Me.CharismaRadio.TabIndex = 5
        Me.CharismaRadio.TabStop = True
        Me.CharismaRadio.Tag = "1"
        Me.CharismaRadio.Text = "Chr"
        Me.CharismaRadio.UseVisualStyleBackColor = True
        '
        'WisdomRadio
        '
        Me.WisdomRadio.AutoSize = True
        Me.WisdomRadio.Location = New System.Drawing.Point(10, 140)
        Me.WisdomRadio.Name = "WisdomRadio"
        Me.WisdomRadio.Size = New System.Drawing.Size(43, 17)
        Me.WisdomRadio.TabIndex = 4
        Me.WisdomRadio.TabStop = True
        Me.WisdomRadio.Tag = "1"
        Me.WisdomRadio.Text = "Wis"
        Me.WisdomRadio.UseVisualStyleBackColor = True
        '
        'IntelligenceRadio
        '
        Me.IntelligenceRadio.AutoSize = True
        Me.IntelligenceRadio.Location = New System.Drawing.Point(10, 117)
        Me.IntelligenceRadio.Name = "IntelligenceRadio"
        Me.IntelligenceRadio.Size = New System.Drawing.Size(37, 17)
        Me.IntelligenceRadio.TabIndex = 3
        Me.IntelligenceRadio.TabStop = True
        Me.IntelligenceRadio.Tag = "1"
        Me.IntelligenceRadio.Text = "Int"
        Me.IntelligenceRadio.UseVisualStyleBackColor = True
        '
        'ConstitutionRadio
        '
        Me.ConstitutionRadio.AutoSize = True
        Me.ConstitutionRadio.Location = New System.Drawing.Point(10, 95)
        Me.ConstitutionRadio.Name = "ConstitutionRadio"
        Me.ConstitutionRadio.Size = New System.Drawing.Size(44, 17)
        Me.ConstitutionRadio.TabIndex = 2
        Me.ConstitutionRadio.TabStop = True
        Me.ConstitutionRadio.Tag = "2"
        Me.ConstitutionRadio.Text = "Con"
        Me.ConstitutionRadio.UseVisualStyleBackColor = True
        '
        'DexterityRadio
        '
        Me.DexterityRadio.AutoSize = True
        Me.DexterityRadio.Location = New System.Drawing.Point(10, 73)
        Me.DexterityRadio.Name = "DexterityRadio"
        Me.DexterityRadio.Size = New System.Drawing.Size(44, 17)
        Me.DexterityRadio.TabIndex = 1
        Me.DexterityRadio.TabStop = True
        Me.DexterityRadio.Tag = "1"
        Me.DexterityRadio.Text = "Dex"
        Me.DexterityRadio.UseVisualStyleBackColor = True
        '
        'StrengthRadio
        '
        Me.StrengthRadio.AutoSize = True
        Me.StrengthRadio.Location = New System.Drawing.Point(10, 51)
        Me.StrengthRadio.Name = "StrengthRadio"
        Me.StrengthRadio.Size = New System.Drawing.Size(38, 17)
        Me.StrengthRadio.TabIndex = 0
        Me.StrengthRadio.TabStop = True
        Me.StrengthRadio.Tag = "0"
        Me.StrengthRadio.Text = "Str"
        Me.StrengthRadio.UseVisualStyleBackColor = True
        '
        'ButtonSkillRoll
        '
        Me.ButtonSkillRoll.Location = New System.Drawing.Point(243, 11)
        Me.ButtonSkillRoll.Name = "ButtonSkillRoll"
        Me.ButtonSkillRoll.Size = New System.Drawing.Size(80, 64)
        Me.ButtonSkillRoll.TabIndex = 59
        Me.ButtonSkillRoll.Text = "d20 Skill Roll"
        Me.ButtonSkillRoll.UseVisualStyleBackColor = True
        '
        'StrTicker
        '
        Me.StrTicker.Location = New System.Drawing.Point(163, 103)
        Me.StrTicker.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.StrTicker.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StrTicker.Name = "StrTicker"
        Me.StrTicker.Size = New System.Drawing.Size(51, 20)
        Me.StrTicker.TabIndex = 60
        Me.StrTicker.Tag = "0"
        Me.StrTicker.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ChrTicker
        '
        Me.ChrTicker.Location = New System.Drawing.Point(162, 215)
        Me.ChrTicker.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ChrTicker.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ChrTicker.Name = "ChrTicker"
        Me.ChrTicker.Size = New System.Drawing.Size(51, 20)
        Me.ChrTicker.TabIndex = 61
        Me.ChrTicker.Tag = "5"
        Me.ChrTicker.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'WisTicker
        '
        Me.WisTicker.Location = New System.Drawing.Point(162, 192)
        Me.WisTicker.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.WisTicker.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WisTicker.Name = "WisTicker"
        Me.WisTicker.Size = New System.Drawing.Size(51, 20)
        Me.WisTicker.TabIndex = 62
        Me.WisTicker.Tag = "4"
        Me.WisTicker.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'IntTicker
        '
        Me.IntTicker.Location = New System.Drawing.Point(162, 169)
        Me.IntTicker.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.IntTicker.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.IntTicker.Name = "IntTicker"
        Me.IntTicker.Size = New System.Drawing.Size(51, 20)
        Me.IntTicker.TabIndex = 63
        Me.IntTicker.Tag = "3"
        Me.IntTicker.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ConTicker
        '
        Me.ConTicker.Location = New System.Drawing.Point(162, 147)
        Me.ConTicker.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ConTicker.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ConTicker.Name = "ConTicker"
        Me.ConTicker.Size = New System.Drawing.Size(51, 20)
        Me.ConTicker.TabIndex = 64
        Me.ConTicker.Tag = "2"
        Me.ConTicker.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'DexTicker
        '
        Me.DexTicker.Location = New System.Drawing.Point(162, 125)
        Me.DexTicker.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.DexTicker.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DexTicker.Name = "DexTicker"
        Me.DexTicker.Size = New System.Drawing.Size(51, 20)
        Me.DexTicker.TabIndex = 65
        Me.DexTicker.Tag = "1"
        Me.DexTicker.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ButtonResetCharacter
        '
        Me.ButtonResetCharacter.Location = New System.Drawing.Point(243, 181)
        Me.ButtonResetCharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonResetCharacter.Name = "ButtonResetCharacter"
        Me.ButtonResetCharacter.Size = New System.Drawing.Size(80, 52)
        Me.ButtonResetCharacter.TabIndex = 66
        Me.ButtonResetCharacter.Tag = "1"
        Me.ButtonResetCharacter.Text = "Reset Character"
        Me.ButtonResetCharacter.UseVisualStyleBackColor = True
        '
        'ButtonUpdateStats
        '
        Me.ButtonUpdateStats.Location = New System.Drawing.Point(243, 126)
        Me.ButtonUpdateStats.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUpdateStats.Name = "ButtonUpdateStats"
        Me.ButtonUpdateStats.Size = New System.Drawing.Size(80, 51)
        Me.ButtonUpdateStats.TabIndex = 67
        Me.ButtonUpdateStats.Text = "Update Stats"
        Me.ButtonUpdateStats.UseVisualStyleBackColor = True
        '
        'WebBrowserScraper
        '
        Me.WebBrowserScraper.Location = New System.Drawing.Point(419, 191)
        Me.WebBrowserScraper.Name = "WebBrowserScraper"
        Me.WebBrowserScraper.Size = New System.Drawing.Size(89, 20)
        Me.WebBrowserScraper.TabIndex = 68
        Me.WebBrowserScraper.Text = "Scrape"
        Me.WebBrowserScraper.UseVisualStyleBackColor = True
        '
        'Character5Radio
        '
        Me.Character5Radio.AutoSize = True
        Me.Character5Radio.Location = New System.Drawing.Point(0, 111)
        Me.Character5Radio.Name = "Character5Radio"
        Me.Character5Radio.Size = New System.Drawing.Size(80, 17)
        Me.Character5Radio.TabIndex = 69
        Me.Character5Radio.TabStop = True
        Me.Character5Radio.Tag = "0"
        Me.Character5Radio.Text = "Character 5"
        Me.Character5Radio.UseVisualStyleBackColor = True
        '
        'Character4Radio
        '
        Me.Character4Radio.AutoSize = True
        Me.Character4Radio.Location = New System.Drawing.Point(0, 88)
        Me.Character4Radio.Name = "Character4Radio"
        Me.Character4Radio.Size = New System.Drawing.Size(80, 17)
        Me.Character4Radio.TabIndex = 70
        Me.Character4Radio.TabStop = True
        Me.Character4Radio.Tag = "0"
        Me.Character4Radio.Text = "Character 4"
        Me.Character4Radio.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.NameBox)
        Me.GroupBox3.Controls.Add(Me.AttributeBox)
        Me.GroupBox3.Controls.Add(Me.ButtonResetCharacter)
        Me.GroupBox3.Controls.Add(Me.ButtonUpdateStats)
        Me.GroupBox3.Controls.Add(Me.StrTicker)
        Me.GroupBox3.Controls.Add(Me.DexTicker)
        Me.GroupBox3.Controls.Add(Me.ButtonSkillRoll)
        Me.GroupBox3.Controls.Add(Me.ChrTicker)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.ButtonCreateCharacter)
        Me.GroupBox3.Controls.Add(Me.WisTicker)
        Me.GroupBox3.Controls.Add(Me.IntTicker)
        Me.GroupBox3.Controls.Add(Me.ConTicker)
        Me.GroupBox3.Location = New System.Drawing.Point(1093, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 238)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1521, 651)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.WebBrowserScraper)
        Me.Controls.Add(Me.DaiToEthPrices)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonDisplayAllCharacters)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WebScrape1TextBox)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Magic8BallButton)
        Me.Controls.Add(Me.EightBallLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.secondNumberToAddTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.firstNumberToAddTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backwardsButton)
        Me.Controls.Add(Me.productTextbox)
        Me.Name = "Form1"
        Me.Tag = ""
        Me.Text = "Murray Project"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.StrTicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrTicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WisTicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntTicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConTicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DexTicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents productTextbox As TextBox
    Friend WithEvents backwardsButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents firstNumberToAddTextBox As TextBox
    Friend WithEvents secondNumberToAddTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EightBallLabel As Label
    Friend WithEvents Magic8BallButton As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents DaiToEthPrices As Button
    Friend WithEvents WebScrape1TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents AttributeBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ButtonCreateCharacter As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDisplayAllCharacters As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Character2Radio As RadioButton
    Friend WithEvents Character1Radio As RadioButton
    Friend WithEvents Character3Radio As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CharismaRadio As RadioButton
    Friend WithEvents WisdomRadio As RadioButton
    Friend WithEvents IntelligenceRadio As RadioButton
    Friend WithEvents ConstitutionRadio As RadioButton
    Friend WithEvents DexterityRadio As RadioButton
    Friend WithEvents StrengthRadio As RadioButton
    Friend WithEvents ButtonSkillRoll As Button
    Friend WithEvents StrTicker As NumericUpDown
    Friend WithEvents ChrTicker As NumericUpDown
    Friend WithEvents WisTicker As NumericUpDown
    Friend WithEvents IntTicker As NumericUpDown
    Friend WithEvents ConTicker As NumericUpDown
    Friend WithEvents DexTicker As NumericUpDown
    Friend WithEvents ButtonResetCharacter As Button
    Friend WithEvents ButtonUpdateStats As Button
    Friend WithEvents WebBrowserScraper As Button
    Friend WithEvents Character5Radio As RadioButton
    Friend WithEvents Character4Radio As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
End Class
