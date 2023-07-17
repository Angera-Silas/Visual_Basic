Imports System
Public Class EvenNums
    
    'Declare a variable that will be used to hold the even numbers
    Dim num As Integer
    Public Sub DisplayNumbers()
        Console.WriteLine("EVEN NUMBERS BETWEEN 0 AND 100 IN DESCENDING ORDER")
        Do While(num>=2)
            num = num-1
            If(num MOD 2 = 0) Then
                Console.Write("{0} ",num)
            End If
        Loop
    End Sub
    Shared Sub Main()   
        D
    End Sub
End Module