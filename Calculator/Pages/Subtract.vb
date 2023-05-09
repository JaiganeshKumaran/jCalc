Public Class Subtract
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no1 As Integer
        Dim no2 As Integer
        Dim ans As Integer
        Label4.Visible = True
        If TextBox1.Text = "" Then
            Label4.Visible = False
            MessageBox.Show("Sorry cannot be empty.")
            TextBox1.Focus()
        End If
        no1 = Val(TextBox1.Text)
        no2 = Val(TextBox2.Text)
        ans = no1 - no2
        Label4.Text = ans
    End Sub
End Class