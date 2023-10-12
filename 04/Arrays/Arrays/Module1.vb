Module Module1

    Sub Main()
        Dim a(4) As Integer
        Dim i As Integer
        a(0) = 2
        a(1) = 3
        a(2) = 5
        a(3) = 7
        a(4) = 11


        For i = 0 To 4

            Console.WriteLine("Index {0}, Wert {1}", i, a(i))
        Next
        Console.ReadLine()


    End Sub

End Module
