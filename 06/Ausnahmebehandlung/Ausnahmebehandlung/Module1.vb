Imports System.Console

Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As String
        a = 4
        b = "Drei"
        Try
            WriteLine(a / b)
        Catch Ausnahme As Exception
            WriteLine("Das ist nicht sinnvoll")
        End Try

        ReadLine()



    End Sub

End Module
