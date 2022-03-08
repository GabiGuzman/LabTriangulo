Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        d = c / 2
        TextBox3.Text = d

    End Sub
End Class
