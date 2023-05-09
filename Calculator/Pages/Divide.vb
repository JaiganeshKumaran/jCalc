Public Class Divide
    Dim num1, num2, q As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Visible = True
        If TextBox1.Text = "" Then
            Label4.Visible = False
            MessageBox.Show("Sorry cannot be empty.")
            TextBox1.Focus()
        End If
        q = (num1 / num2)
        Label4.Text = q
    End Sub
End Class