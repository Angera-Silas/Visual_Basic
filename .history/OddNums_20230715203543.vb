Imports System
Module OddNums
    Dim Odd As Integer = 0
    Sub Main()
    Console.WriteLine("ODD NUMBERS BETWEEN 0 AND 100 IN ASCENDING ORDER")
        Do
            Odd =  Odd + 1
            If(Odd MOD 2 <> 0) Then
                Console.Write("{0}  ",Odd)
            End If
        Loop While (Odd>0)
        Console.ReadLine()
    End Sub
End Module