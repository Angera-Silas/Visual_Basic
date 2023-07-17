Imports System
Module OddNumbers
    Dim num,nonOdd As Integer
    Sub Main()
    Odd = 0
    Console.WriteLine("ODD NUMBERS BETWEEN 0 AND 100 DISPLAYED IN ASCENDING ORDER")
        Do
            num =  num + 1
            nonOdd = num/2
            If(num MOD 2 <> 0) Then
                Console.Write("{0}  ",Odd)
            End If
        Loop While (Odd<110)
        Console.ReadLine()
    End Sub
End Module