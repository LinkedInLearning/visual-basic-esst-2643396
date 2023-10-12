Module Program

    Sub Main()
        Dim z1 As Byte
        Dim z2 As Short
        Dim z3 As Short
        z2 = 255
        z3 = 300
        'z1 = z2
        ' z2 = 256 ' Overflow
        'z1 = CByte(z2)
        'Console.WriteLine(z1)
        z1 = CByte(z3)
        Console.WriteLine(z1)

        Console.ReadLine()

    End Sub

End Module
