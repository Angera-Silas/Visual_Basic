Imports System
Module OddNumbers
    Dim num,d As Integer 'Declare two variables 
    Sub Main()
    num = 0 'initialize num to 0
    Console.WriteLine("ODD NUMBERS BETWEEN 0 AND 100 DISPLAYED IN ASCENDING ORDER")
        Do
            num = num + 1  'increement num by 1
            d = num/2 'Divide num by 2 and give the result to Odd
            If(d * 2 <> num) Then 'check if Odd is an odd number
                Console.Write("{0}  ",num)
            End If
        Loop While (num<110)
        Console.ReadLine()
    End Sub
End Module