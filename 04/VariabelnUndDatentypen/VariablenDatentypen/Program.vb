Imports System.Console


Module Program
    Sub Main(args As String())
        Dim a = 1 ' Datentypbestimmung durch Duck Typing über Wertzuweisung
        Dim b As Integer ' Datentypfestlegung
        Console.WriteLine("Wert von a ist {0} und der Datentyp {1} ", a, a.GetType())
        Console.WriteLine("Wert von b ist {0} und der Datentyp {1} ", b, b.GetType())
        a = 3.14
        b = 2.71
        Console.WriteLine("Wert von a ist {0} und der Datentyp {1} ", a, a.GetType())
        Console.WriteLine("Wert von b ist {0} und der Datentyp {1} ", b, b.GetType())

        Console.ReadLine()



    End Sub
End Module
