Imports System

Module Program
    Sub Main(args As String())
        Dim o1 As New Superklasse()
        Dim o2 As New Subklasse()
        o1.Methode()

        o2.Methode()

        Dim o3 As Superklasse
        Dim o4 As Subklasse

        o3 = New Subklasse()
        o4 = New Subklasse()
        o3.Methode()

        o4.Methode()


    End Sub
End Module
