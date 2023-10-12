Imports System.Console
Imports Namensraum.de.rjs

Module Program
    Sub Main()
        WriteLine("Mehrere Module in einer Datei sowie verschiedene Namensräume.")
        WriteLine("Geben Sie Ihren Namen an")
        name = ReadLine()
        WriteLine("Hallo {0}. Viel Spass bei der Arbeit!", name)
        ReadLine()


    End Sub

End Module
Namespace de.rjs
    Module Module2
        Public name As String


    End Module

End Namespace


