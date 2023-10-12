Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer
        i = 0

        Do Until i > 10
            i = i + 1
            Console.WriteLine(i)
            If i = 3 Then
                Exit Do
            End If



        Loop

    End Sub
End Module
