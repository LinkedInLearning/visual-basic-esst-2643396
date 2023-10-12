Imports System


Module Program
    Dim i As Integer
    Sub Main(args As String())

        i = 0
        Do
            i = i + 1
            Console.WriteLine(i)





        Loop While i < 3
        Console.WriteLine("--------------------------")
        i = 0
        Do Until i > 2
            i = i + 1
            Console.WriteLine(i)



        Loop
        Console.WriteLine("--------------------------")
        For i = 1 To 3
            Console.WriteLine(i)




        Next
        Console.ReadLine()

    End Sub
End Module
