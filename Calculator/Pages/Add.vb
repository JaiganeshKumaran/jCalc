Public Class Add
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim sum As Integer
        Dim a As Integer
        Dim b As Integer
        Label4.Visible = True
        If TextBox1.Text = "" Then
            Label4.Visible = False
            MessageBox.Show("Sorry cannot be empty.")
            TextBox1.Focus()
        End If
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        sum = (a + b)
        Label4.Text = sum
    End Sub

#Disable Warning BC40014 ' Member conflicts with a member implicitly declared for property or event in the base type
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Enable Warning BC40014 ' Member conflicts with a member implicitly declared for property or event in the base type
        Label4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
End Class