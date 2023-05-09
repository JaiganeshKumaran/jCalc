Public Class Advanced
    Dim flag As Boolean = True
    Dim op As String
    Dim opr As Double
    Dim opr2 As Double
    Dim result As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flag Then
            TextBox1.Text = Button1.Text
            flag = False
        Else
            TextBox1.Text += Button1.Text
        End If
    End Sub

    Private Sub Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If flag Then
            TextBox1.Text = Button2.Text
            flag = False
        Else
            TextBox1.Text += Button2.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If flag Then
            TextBox1.Text = Button3.Text
            flag = False
        Else
            TextBox1.Text += Button3.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If flag Then
            TextBox1.Text = Button4.Text
            flag = False
        Else
            TextBox1.Text += Button4.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If flag Then
            TextBox1.Text = Button5.Text
            flag = False
        Else
            TextBox1.Text += Button5.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If flag Then
            TextBox1.Text = Button6.Text
            flag = False
        Else
            TextBox1.Text += Button6.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If flag Then
            TextBox1.Text = Button7.Text
            flag = False
        Else
            TextBox1.Text += Button7.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If flag Then
            TextBox1.Text = Button8.Text
            flag = False
        Else
            TextBox1.Text += Button8.Text
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If flag Then
            TextBox1.Text = Button9.Text
            flag = False
        Else
            TextBox1.Text += Button9.Text
        End If
    End Sub
End Class