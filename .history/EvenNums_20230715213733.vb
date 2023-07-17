Imports System
Public Class EvenNumbers
    'Declare a variable that will be used to hold the even numbers
    Private num As Integer
    'Declare a constant txt that will hold the display text
    Const txt = "Even Numbers Between 0 and 100 displayed in Descending Order"
    Public Sub DisplayNumbers()
        Console.WriteLine(txt.ToUpper())
        num = 100
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
        'Finally lets instantiate method we formed
        Obj1.DisplayNumbers()
        Console.ReadLine()
    End Sub
End Class