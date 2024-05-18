Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Doforloop(22)
        Console.WriteLine($"Hello {Math.Sin(22)}")
        Console.Beep(550, 1000)
    End Sub
    Sub Doforloop(endnum As Integer)
        Dim x As Integer
        For x = 1 To endnum
            Console.WriteLine($"x = {x}")
        Next
    End Sub
End Module
