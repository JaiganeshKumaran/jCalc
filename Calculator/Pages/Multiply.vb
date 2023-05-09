Public Class Multiply
    Dim no1 As Integer
    Dim no2 As Integer
    Dim product As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Visible = True
        If TextBox1.Text = "" Then
            Label4.Visible = False
            MessageBox.Show("Sorry cannot be empty.")
            TextBox1.Focus()
        End If
        product = no1 * no2
        Label4.Text = product
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = (" ")
        TextBox2.Text = (" ")
        Label4.Text = (" ")
    End Sub
End Class