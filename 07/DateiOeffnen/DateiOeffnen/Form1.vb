Public Class Form1
    Private Datei As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Datei = OpenFileDialog1.FileName

            If Datei.EndsWith(".rtf") Then
                Try
                    RichTextBox1.LoadFile(Datei, RichTextBoxStreamType.RichText)
                Catch Ausnahme As Exception
                    Dim s = "Die Datei konnte nicht im rtf-Format geladen werden!"
                    MessageBox.Show(s, "Editor", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    RichTextBox1.LoadFile(Datei, RichTextBoxStreamType.PlainText)
                End Try
            Else
                RichTextBox1.LoadFile(Datei, RichTextBoxStreamType.PlainText)
            End If

            RichTextBox1.Modified = False
            Text = Datei
        End If
    End Sub
End Class
