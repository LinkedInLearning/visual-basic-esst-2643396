Imports System.Console
Module Module1
    Dim i As Integer = 42
    Sub A()
        Dim i As Double = 3.14
        WriteLine("Die Antwort ist {0}.", i)


    End Sub
    Sub B()
        WriteLine("Die Antwort ist {0}.", i)

    End Sub

    Sub Main()
        A()
        B()
        ReadLine()

    End Sub

End Module
