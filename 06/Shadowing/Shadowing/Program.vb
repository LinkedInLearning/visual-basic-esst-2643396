Imports System.Console

Module Program


    Sub Main()

        Dim o1 As New Schatten1()
        Dim o2 As New Schatten2()
        o1.Methode()

        o2.Methode()

        Dim o3 As Schatten1
        Dim o4 As Schatten2

        o3 = New Schatten2()
        o4 = New Schatten2()
        o3.Methode()

        o4.Methode()

        ReadLine()
    End Sub

End Module
