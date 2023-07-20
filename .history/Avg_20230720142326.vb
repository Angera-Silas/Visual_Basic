Imports System
Public Class Form1
    Private Shared a,b,av As Integer
    Shared Sub Main()
        Dim num1,num2 As String
        Console.WriteLine("Enter the first value")
        num1 = Console.ReadLine
        Console.WriteLine("Enter the second value")
        num2 = Console.ReadLine
        If(Integer.TryParse(num1,a) And Integer.TryParse(num2,b)) Then
            av = (a+b)/2
            Console.WriteLine("The average is {0}",av)
        Else
            Console.WriteLine("Sorry only numbers allowed")
        End If
        Console.ReadLine
    End Sub
End Class
