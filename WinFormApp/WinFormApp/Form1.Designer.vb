<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.RichTextBox1.Location = New System.Drawing.Point(431, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(152, 98)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 5)
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
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Magic8BallButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Magic8BallButton.Name = "Magic8BallButton"
        Me.Magic8BallButton.Size = New System.Drawing.Size(134, 21)
        Me.Magic8BallButton.TabIndex = 12
        Me.Magic8BallButton.Text = "Get Your Answer"
        Me.Magic8BallButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 451)
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
        Me.Text = "Product Lister Test"
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
End Class
