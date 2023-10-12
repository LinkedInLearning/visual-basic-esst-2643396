Imports System.Console

Module Module1
    Dim i As Integer = 42
    Sub Aendern1(ByVal i As Integer)
        WriteLine("Wert von i in Aendern1() nach Übergabe mit Call-by-value: {0}", i)
        i = 12
        WriteLine("Wert von i in Aendern1() nach lokaler Neuzuweisung: {0}", i)


    End Sub
    Sub Aendern2(ByRef i As Integer)
        WriteLine("Wert von i in Aendern2() nach Übergabe mit Call-by-reference: {0}", i)
        i = 21
        WriteLine("Wert von i in Aendern2() nach lokaler Neuzuweisung: {0}", i)
    End Sub

    Sub Main()
        WriteLine("Wert von globalem i bei Beginn: {0}", i)
        Aendern1(i)
        WriteLine("Wert von globalem i nach ByVal: {0}", i)
        Aendern2(i)
        WriteLine("Wert von globalem i nach ByRef: {0}", i)
        ReadLine()


    End Sub

End Module
