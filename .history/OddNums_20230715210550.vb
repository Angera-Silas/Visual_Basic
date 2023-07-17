Imports System
Module OddNums
    Dim Odd As Integer = 0
    Sub Main()
    Console.WriteLine("ODD NUMBERS BETWEEN 0 AND 100 IN ASCENDING ORDER")
        Do
            Odd =  Odd + 1
            If((Odd/2)*2 = Odd) Then
                Console.Write("{0}  ",Odd)
            End If
        Loop While (Odd<110)
        Console.ReadLine()
    End Sub
End Module