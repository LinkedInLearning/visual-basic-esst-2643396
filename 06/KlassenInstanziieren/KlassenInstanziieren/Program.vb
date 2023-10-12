Imports System

Module Program
    Sub Main()
        Dim f As New Fahrzeug()
        f.Farbe = "Rot"
        f.Sitzplaetze = 5
        Console.WriteLine(f.Sitzplaetze)
        f.Beschleunigen(50)
        f.Bremsen(20)
        f.Beschleunigen(35)









    End Sub
End Module
