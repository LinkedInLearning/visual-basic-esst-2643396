Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        If a > 18 Or a < 2 Then
            Label1.Text = "Willkommen"
        Else
            Label1.Text = "Passt nicht"
        End If
    End Sub
End Class
