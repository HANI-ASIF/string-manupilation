Module Module1

    Sub Main()
        Dim find, replace As Char
        Dim str1 As String
        Dim charaddress As Integer
        Dim count As Integer
        Dim mychar As Char

        str1 = ""
        mychar = ""
        find = ""
        replace = ""
        charaddress = 0
        count = 0

        Console.Write("write the string you want to be edited: ")
        str1 = Console.ReadLine
        Console.Write("write the character you want to be replaced: ")
        find = Console.ReadLine
        Console.Write("write the character you want to be substituted: ")
        replace = Console.ReadLine
        For count = 1 To Len(str1)
            mychar = Mid(str1, count, 1)
            If mychar = find Then
                Mid(str1, count, 1) = replace

            End If
        Next
        Console.WriteLine("string with replaced character: " & str1)
        Console.ReadKey()

    End Sub

End Module
