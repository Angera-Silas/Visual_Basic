Imports System
Module OddNumbers
    Dim num,nonOdd As Integer 'Declare t
    Sub Main()
    num = 0
    Console.WriteLine("ODD NUMBERS BETWEEN 0 AND 100 DISPLAYED IN ASCENDING ORDER")
        Do
            num =  num + 1
            nonOdd = num/2
            If(nonOdd * 2 <> num) Then
                Console.Write("{0}  ",num)
            End If
        Loop While (num<110)
        Console.ReadLine()
    End Sub
End Module