Imports System.Console

Module Program
    Sub Main()
        WriteLine("Mehrere Module in einer Datei.")
        WriteLine("Geben Sie Ihren Namen an")
        name = ReadLine()
        WriteLine("Hallo {0}. Viel Spass bei der Arbeit!", name)
        ReadLine()


    End Sub

End Module
Module Module2
    Public name As String


End Module


