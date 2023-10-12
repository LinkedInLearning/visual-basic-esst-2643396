Imports System.Console
Module Module1
    Sub Ausgabe()
        WriteLine("Vorgabetext in der Prozedur.")



    End Sub
    Sub Ausgabe(a As String, Optional i As Integer = 42)
        WriteLine(a)
        WriteLine(i)



    End Sub

    Sub Main()
        Ausgabe()
        Ausgabe("Nur Text an die Prozedur übergeben.")
        Ausgabe("Text und eine Zahl an die Prozedur übergeben.", 8)
        ReadLine()
    End Sub

End Module
