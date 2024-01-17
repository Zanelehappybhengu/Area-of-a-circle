Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Const PI As Double = 3.14
        Dim R As Double

        R = Val(TextBox1.Text)
        A = PI * R ^ 2
        TextBox2.Text = A
    End Sub
End Class
