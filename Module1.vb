Module Module1

    Sub Main()
        Dim N As Integer = 0
        Dim sum As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 1
        Console.Write("enter febonacci range: ")
        N = Console.ReadLine()
        Console.Write(Str(x) & ", " & Str(y) & ", ")
        While sum <= N
            sum = x + y

            Console.Write(Str(sum) & ", ")
            x = y
            y = sum

        End While
        Console.ReadKey()
    End Sub

End Module
