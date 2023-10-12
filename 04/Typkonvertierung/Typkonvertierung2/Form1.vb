Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Label1.Text = TextBox1.Text + TextBox2.Text
        Label1.Text = CInt(TextBox1.Text) + CInt(TextBox2.Text)
    End Sub
End Class
