Module SumOdd
    Sub Main()
        Dim sum As Integer = 0
        Dim count As Integer = 1
        While count<15
            If count MOD 2 <> 0 Then
                Console.
                sum = sum + count
            End If
            count = count + 1
        End While
        Console.WriteLine("Sum of Odd numbers between 1 and 15 is {0}",sum)
        Console.ReadLine()
    End Sub
End Module
