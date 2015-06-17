<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.UserNameTextbox = New System.Windows.Forms.TextBox()
        Me.StaticSaltLabel = New System.Windows.Forms.Label()
        Me.StaticSaltTextBox = New System.Windows.Forms.TextBox()
        Me.DynSaltedPasswordHashButton = New System.Windows.Forms.Button()
        Me.PasswordHashButton = New System.Windows.Forms.Button()
        Me.PasswordSaltedHashButton = New System.Windows.Forms.Button()
        Me.AccountCreationDateLabel = New System.Windows.Forms.Label()
        Me.AccountCreationDateTextbox = New System.Windows.Forms.TextBox()
        Me.ResultsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaltedHashLabel = New System.Windows.Forms.Label()
        Me.SaltedRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DynSaltedHashLabel = New System.Windows.Forms.Label()
        Me.DynSaltRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dc401Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 29)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(118, 30)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(0, 178)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(238, 26)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.Text = "MyPassword"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(-4, 155)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(186, 20)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Enter Example Password"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(-4, 77)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(193, 20)
        Me.UserNameLabel.TabIndex = 4
        Me.UserNameLabel.Text = "Enter Example UserName"
        '
        'UserNameTextbox
        '
        Me.UserNameTextbox.Location = New System.Drawing.Point(0, 100)
        Me.UserNameTextbox.Name = "UserNameTextbox"
        Me.UserNameTextbox.Size = New System.Drawing.Size(238, 26)
        Me.UserNameTextbox.TabIndex = 3
        Me.UserNameTextbox.Text = "MyUserName"
        '
        'StaticSaltLabel
        '
        Me.StaticSaltLabel.AutoSize = True
        Me.StaticSaltLabel.Location = New System.Drawing.Point(325, 155)
        Me.StaticSaltLabel.Name = "StaticSaltLabel"
        Me.StaticSaltLabel.Size = New System.Drawing.Size(190, 20)
        Me.StaticSaltLabel.TabIndex = 6
        Me.StaticSaltLabel.Text = "Enter Example Static Salt"
        '
        'StaticSaltTextBox
        '
        Me.StaticSaltTextBox.Location = New System.Drawing.Point(329, 178)
        Me.StaticSaltTextBox.Name = "StaticSaltTextBox"
        Me.StaticSaltTextBox.Size = New System.Drawing.Size(238, 26)
        Me.StaticSaltTextBox.TabIndex = 5
        Me.StaticSaltTextBox.Text = "RandomSaltText"
        '
        'DynSaltedPasswordHashButton
        '
        Me.DynSaltedPasswordHashButton.Location = New System.Drawing.Point(12, 512)
        Me.DynSaltedPasswordHashButton.Name = "DynSaltedPasswordHashButton"
        Me.DynSaltedPasswordHashButton.Size = New System.Drawing.Size(193, 74)
        Me.DynSaltedPasswordHashButton.TabIndex = 7
        Me.DynSaltedPasswordHashButton.Text = "Dynamically Salted Password Hash"
        Me.DynSaltedPasswordHashButton.UseVisualStyleBackColor = True
        '
        'PasswordHashButton
        '
        Me.PasswordHashButton.Location = New System.Drawing.Point(12, 328)
        Me.PasswordHashButton.Name = "PasswordHashButton"
        Me.PasswordHashButton.Size = New System.Drawing.Size(193, 74)
        Me.PasswordHashButton.TabIndex = 8
        Me.PasswordHashButton.Text = "Password Hash"
        Me.PasswordHashButton.UseVisualStyleBackColor = True
        '
        'PasswordSaltedHashButton
        '
        Me.PasswordSaltedHashButton.Location = New System.Drawing.Point(12, 418)
        Me.PasswordSaltedHashButton.Name = "PasswordSaltedHashButton"
        Me.PasswordSaltedHashButton.Size = New System.Drawing.Size(193, 74)
        Me.PasswordSaltedHashButton.TabIndex = 9
        Me.PasswordSaltedHashButton.Text = "Salted Password Hash"
        Me.PasswordSaltedHashButton.UseVisualStyleBackColor = True
        '
        'AccountCreationDateLabel
        '
        Me.AccountCreationDateLabel.AutoSize = True
        Me.AccountCreationDateLabel.Location = New System.Drawing.Point(325, 77)
        Me.AccountCreationDateLabel.Name = "AccountCreationDateLabel"
        Me.AccountCreationDateLabel.Size = New System.Drawing.Size(279, 20)
        Me.AccountCreationDateLabel.TabIndex = 11
        Me.AccountCreationDateLabel.Text = "Enter Example Account Creation Date"
        '
        'AccountCreationDateTextbox
        '
        Me.AccountCreationDateTextbox.Location = New System.Drawing.Point(329, 100)
        Me.AccountCreationDateTextbox.Name = "AccountCreationDateTextbox"
        Me.AccountCreationDateTextbox.Size = New System.Drawing.Size(238, 26)
        Me.AccountCreationDateTextbox.TabIndex = 10
        Me.AccountCreationDateTextbox.Text = "01/01/1970"
        '
        'ResultsRichTextBox
        '
        Me.ResultsRichTextBox.ForeColor = System.Drawing.Color.Red
        Me.ResultsRichTextBox.Location = New System.Drawing.Point(255, 352)
        Me.ResultsRichTextBox.Name = "ResultsRichTextBox"
        Me.ResultsRichTextBox.Size = New System.Drawing.Size(349, 34)
        Me.ResultsRichTextBox.TabIndex = 13
        Me.ResultsRichTextBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Hash (no salt)"
        '
        'SaltedHashLabel
        '
        Me.SaltedHashLabel.AutoSize = True
        Me.SaltedHashLabel.Location = New System.Drawing.Point(251, 434)
        Me.SaltedHashLabel.Name = "SaltedHashLabel"
        Me.SaltedHashLabel.Size = New System.Drawing.Size(97, 20)
        Me.SaltedHashLabel.TabIndex = 16
        Me.SaltedHashLabel.Text = "Salted Hash"
        '
        'SaltedRichTextBox
        '
        Me.SaltedRichTextBox.BackColor = System.Drawing.Color.Black
        Me.SaltedRichTextBox.ForeColor = System.Drawing.Color.Yellow
        Me.SaltedRichTextBox.Location = New System.Drawing.Point(255, 458)
        Me.SaltedRichTextBox.Name = "SaltedRichTextBox"
        Me.SaltedRichTextBox.Size = New System.Drawing.Size(349, 34)
        Me.SaltedRichTextBox.TabIndex = 15
        Me.SaltedRichTextBox.Text = ""
        '
        'DynSaltedHashLabel
        '
        Me.DynSaltedHashLabel.AutoSize = True
        Me.DynSaltedHashLabel.Location = New System.Drawing.Point(251, 528)
        Me.DynSaltedHashLabel.Name = "DynSaltedHashLabel"
        Me.DynSaltedHashLabel.Size = New System.Drawing.Size(162, 20)
        Me.DynSaltedHashLabel.TabIndex = 18
        Me.DynSaltedHashLabel.Text = "Dynamic Salted Hash"
        '
        'DynSaltRichTextBox
        '
        Me.DynSaltRichTextBox.BackColor = System.Drawing.Color.Black
        Me.DynSaltRichTextBox.ForeColor = System.Drawing.Color.GreenYellow
        Me.DynSaltRichTextBox.Location = New System.Drawing.Point(255, 552)
        Me.DynSaltRichTextBox.Name = "DynSaltRichTextBox"
        Me.DynSaltRichTextBox.Size = New System.Drawing.Size(349, 34)
        Me.DynSaltRichTextBox.TabIndex = 17
        Me.DynSaltRichTextBox.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(641, 77)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(390, 530)
        Me.RichTextBox1.TabIndex = 19
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(637, 54)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(90, 20)
        Me.InfoLabel.TabIndex = 20
        Me.InfoLabel.Text = "Information"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
        Me.HowToUseToolStripMenuItem.Text = "How to Use"
        '
        'dc401Label
        '
        Me.dc401Label.AutoSize = True
        Me.dc401Label.Location = New System.Drawing.Point(8, 651)
        Me.dc401Label.Name = "dc401Label"
        Me.dc401Label.Size = New System.Drawing.Size(183, 20)
        Me.dc401Label.TabIndex = 21
        Me.dc401Label.Text = "https://github.com/dc401"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 750)
        Me.Controls.Add(Me.dc401Label)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DynSaltedHashLabel)
        Me.Controls.Add(Me.DynSaltRichTextBox)
        Me.Controls.Add(Me.SaltedHashLabel)
        Me.Controls.Add(Me.SaltedRichTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResultsRichTextBox)
        Me.Controls.Add(Me.AccountCreationDateLabel)
        Me.Controls.Add(Me.AccountCreationDateTextbox)
        Me.Controls.Add(Me.PasswordSaltedHashButton)
        Me.Controls.Add(Me.PasswordHashButton)
        Me.Controls.Add(Me.DynSaltedPasswordHashButton)
        Me.Controls.Add(Me.StaticSaltLabel)
        Me.Controls.Add(Me.StaticSaltTextBox)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.UserNameTextbox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Dynamic Salting Example"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents StaticSaltLabel As System.Windows.Forms.Label
    Friend WithEvents StaticSaltTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DynSaltedPasswordHashButton As System.Windows.Forms.Button
    Friend WithEvents PasswordHashButton As System.Windows.Forms.Button
    Friend WithEvents PasswordSaltedHashButton As System.Windows.Forms.Button
    Friend WithEvents AccountCreationDateLabel As System.Windows.Forms.Label
    Friend WithEvents AccountCreationDateTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ResultsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaltedHashLabel As System.Windows.Forms.Label
    Friend WithEvents SaltedRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DynSaltedHashLabel As System.Windows.Forms.Label
    Friend WithEvents DynSaltRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents InfoLabel As System.Windows.Forms.Label
    Friend WithEvents HowToUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dc401Label As System.Windows.Forms.Label

End Class
