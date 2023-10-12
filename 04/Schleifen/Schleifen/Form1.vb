Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = 0
        Do
            i = i + 1
            Label1.Text = i

            System.Threading.Thread.Sleep(200)
            Application.DoEvents()


        Loop While i < 3

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = 0
        Do Until i > 2
            i = i + 1
            Label1.Text = i

            System.Threading.Thread.Sleep(200)
            Application.DoEvents()


        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 1 To 3
            Label1.Text = i

            System.Threading.Thread.Sleep(200)
            Application.DoEvents()


        Next
    End Sub
End Class
