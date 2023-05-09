Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome, " & SystemInformation.UserName
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Add.Show()
    End Sub

    Private Sub SubtractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtractToolStripMenuItem.Click
        Subtract.Show()
    End Sub

    Private Sub MultiplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplyToolStripMenuItem.Click
        Multiply.Show()
    End Sub
    Private Sub DivideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivideToolStripMenuItem.Click
        Divide.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://sites.google.com/site/jgveedu/jcalc")
    End Sub

    Private Sub AdvancedViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedViewToolStripMenuItem.Click
        Advanced.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "add" Then
            Add.Show()
        ElseIf TextBox1.Text = "subtract" Then
            Subtract.Show()
        End If
        If TextBox1.Text = "multiply" Then
                Multiply.Show()
            End If
        If TextBox1.Text = "divide" Then
            Divide.Show()
        End If
        If TextBox1.Text = "settings" Then
            Settings.Show()
            Me.Hide()
        End If
        If TextBox1.Text = "Add" Then
            Add.Show()
        End If
        If TextBox1.Text = "Subtract" Then
            Subtract.Show()
        End If
        If TextBox1.Text = "Multiply" Then
            Multiply.Show()
        End If
        If TextBox1.Text = "Divide" Then
            Divide.Show()
        End If
        If TextBox1.Text = "Settings" Then
            Settings.Show()
            Me.Hide()
        End If
        If TextBox1.Text = "Advanced" Then
            Advanced.Show()
        End If
    End Sub

    Private Sub OpenAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAppToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RestartAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartAppToolStripMenuItem.Click
        Restart.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        NotifyMenu.Show()
    End Sub

    Private Sub SettingsMenu_Click(sender As Object, e As EventArgs) Handles SettingsMenu.Click
        Settings.Show()
        Me.Hide()
    End Sub
    Private Sub Home_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon.Visible = False
        Application.Exit()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Restart.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
        Me.Hide()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem1.Click
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfolwmV1Jqt7FbcRfRQoIvInngdhEnIP_sjJ6LVBplJBK8a9w/viewform")
    End Sub
End Class