<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubtractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineSupportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.NotifyMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.SubtractToolStripMenuItem, Me.MultiplyToolStripMenuItem, Me.DivideToolStripMenuItem, Me.AdvancedViewToolStripMenuItem, Me.AboutToolStripMenuItem, Me.RestartToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(943, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SubtractToolStripMenuItem
        '
        Me.SubtractToolStripMenuItem.Name = "SubtractToolStripMenuItem"
        Me.SubtractToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SubtractToolStripMenuItem.Text = "Subtract"
        '
        'MultiplyToolStripMenuItem
        '
        Me.MultiplyToolStripMenuItem.Name = "MultiplyToolStripMenuItem"
        Me.MultiplyToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MultiplyToolStripMenuItem.Text = "Multiply"
        '
        'DivideToolStripMenuItem
        '
        Me.DivideToolStripMenuItem.Name = "DivideToolStripMenuItem"
        Me.DivideToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DivideToolStripMenuItem.Text = "Divide"
        '
        'AdvancedViewToolStripMenuItem
        '
        Me.AdvancedViewToolStripMenuItem.Name = "AdvancedViewToolStripMenuItem"
        Me.AdvancedViewToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdvancedViewToolStripMenuItem.Text = "Advanced View"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeedbackToolStripMenuItem1, Me.OnlineSupportToolStripMenuItem1, Me.SettingsMenu})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'FeedbackToolStripMenuItem1
        '
        Me.FeedbackToolStripMenuItem1.Name = "FeedbackToolStripMenuItem1"
        Me.FeedbackToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.FeedbackToolStripMenuItem1.Text = "Feedback"
        '
        'OnlineSupportToolStripMenuItem1
        '
        Me.OnlineSupportToolStripMenuItem1.Name = "OnlineSupportToolStripMenuItem1"
        Me.OnlineSupportToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.OnlineSupportToolStripMenuItem1.Text = "Online Support"
        '
        'SettingsMenu
        '
        Me.SettingsMenu.Image = Global.Calculator.My.Resources.Resources.Windows_Settings_app_icon
        Me.SettingsMenu.Name = "SettingsMenu"
        Me.SettingsMenu.Size = New System.Drawing.Size(154, 22)
        Me.SettingsMenu.Text = "Settings"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome, "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(840, 177)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "jCalc Online Support"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(676, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Calculator.My.Resources.Resources.icons8_search_32_MGF_icon
        Me.Button1.Location = New System.Drawing.Point(856, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "jCalc App"
        Me.NotifyIcon.Visible = True
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAppToolStripMenuItem, Me.RestartAppToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NotifyMenu.Name = "NotifyMenu"
        Me.NotifyMenu.Size = New System.Drawing.Size(117, 92)
        '
        'OpenAppToolStripMenuItem
        '
        Me.OpenAppToolStripMenuItem.Name = "OpenAppToolStripMenuItem"
        Me.OpenAppToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OpenAppToolStripMenuItem.Text = "Open "
        '
        'RestartAppToolStripMenuItem
        '
        Me.RestartAppToolStripMenuItem.Name = "RestartAppToolStripMenuItem"
        Me.RestartAppToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RestartAppToolStripMenuItem.Text = "Restart "
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(919, 160)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "This is a simple calculator app by Jg's House. It can add, subtract mutilply and " &
    "divide." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enjoy using this app." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thanks, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jg's House Technology Ministry " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Calculator.My.Resources.Resources.icons8_contacts_32
        Me.PictureBox1.Location = New System.Drawing.Point(12, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(943, 548)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "jCalc Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.NotifyMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubtractToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents NotifyMenu As ContextMenuStrip
    Friend WithEvents OpenAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OnlineSupportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SettingsMenu As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
