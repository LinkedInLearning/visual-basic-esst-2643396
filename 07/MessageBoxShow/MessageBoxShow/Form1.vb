Imports System.Windows.Forms
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Ganz wichtig", "Meine Mitteilung", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then

        End If
    End Sub
End Class
