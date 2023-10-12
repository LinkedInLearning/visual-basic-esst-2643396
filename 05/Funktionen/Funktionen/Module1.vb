Module Module1
    Function GibWasZurueck() As Integer
        GibWasZurueck = 3
        Console.WriteLine("Danach")

    End Function
    Function GibAuchWasZurueck() As Integer
        Return 4
        Console.WriteLine("Auch danach")

    End Function

    Sub Main()
        Console.WriteLine(GibWasZurueck())
        Console.WriteLine(GibAuchWasZurueck())
        Console.ReadLine()
    End Sub

End Module
