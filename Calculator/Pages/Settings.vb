Public Class Settings
    Private Sub GoBackToHomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToHomeToolStripMenuItem.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = SystemInformation.UserName
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://sites.google.com/site/jgveedu")
    End Sub
    Private Sub Settings_close() Handles MyBase.Closed
        Home.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://1drv.ms/w/s!Ar-5iBbnXJ8guyDt66RLc7pryDZ0")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfolwmV1Jqt7FbcRfRQoIvInngdhEnIP_sjJ6LVBplJBK8a9w")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Process.Start("ms-settings:yourinfo")
    End Sub
End Class