Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        Label1.Text = c
    End Sub
End Class
