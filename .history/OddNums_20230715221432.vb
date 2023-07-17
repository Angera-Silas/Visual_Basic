Imports System
Module OddNums
    Dim Odd As Integer
    Sub Main()
    Odd = 0
    Console.WriteLine("ODD NUMBERS BETWEEN 0 AND 100 IN ASCENDING ORDER")
        Do
            Odd =  Odd + 1
            If(Odd MOD 2 <> 0) Then
                Console.Write("{0}  ",Odd)
            End If
        Loop While (Odd<110)
        Console.ReadLine()
    End Sub
End Module