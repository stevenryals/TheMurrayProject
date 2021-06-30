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
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'productTextbox
        '
        Me.productTextbox.Location = New System.Drawing.Point(174, 35)
        Me.productTextbox.Name = "productTextbox"
        Me.productTextbox.Size = New System.Drawing.Size(150, 20)
        Me.productTextbox.TabIndex = 0
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(330, 33)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product to Search"
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(34, 61)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.Size = New System.Drawing.Size(564, 368)
        Me.resultTextBox.TabIndex = 3
        Me.resultTextBox.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 451)
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.productTextbox)
        Me.Name = "Form1"
        Me.Text = "Product Lister Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents productTextbox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resultTextBox As RichTextBox
End Class
