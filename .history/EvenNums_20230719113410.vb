Imports System
Public Class EvenNumbers
    'Declare a variable that will be used to hold the even numbers
    Private num As Integer
    'Declare a constant txt that will hold the display text
    Const txt = "Even Numbers Between 0 and 100 displayed in Descending Order"
    Public Sub DisplayNumbers()
        Console.WriteLine(txt.Toau())
        num = 100
        Do While(num>=2)
            num = num-1
            If(num MOD 2 = 0) Then
                Console.Write("{0} ",num)
            End If
        Loop
    End Sub
    Shared Sub Main()   
        Dim Obj1 As New EvenNumbers() 'Lets create an Object for our class
        Obj1.DisplayNumbers()'instantiating a method we formed using a class object obj1
        Console.ReadLine()
    End Sub
End Class