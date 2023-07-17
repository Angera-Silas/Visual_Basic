Imports System
Public Class EvenNumbers
    
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
        'Lets create an Object for our class
        Dim Obj1 As New EvenNumbers()
        'Finally lets instantiate the method we formed
        Obj1.DisplayNumbers()
    End Sub
End 