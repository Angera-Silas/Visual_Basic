Imports System
Public Class FutureValue
    Private PresentValue, InterestRate, Period As Double
    Dim m As Integer
    Dim op As String
    Public Sub GetDimensions()
        Console.WriteLine("Enter the Present value")
        PresentValue = Console.ReadLine
        Console.WriteLine("Whats the Interest Rate?")
        InterestRate = Console.ReadLine
        Console.WriteLine("How long is the investment taking?")
        Period = Console.ReadLine
        Console.WriteLine("How the investment compounded? i.e anually...")
        op = Console.ReadLine
        If(op = "annualy") Then
            m = 1
        ElseIf(op = "semi-annually") Then
            m = 2
        ElseIf(op = "quaterly") Then
            m = 4
        ElseIf(op = "monthly") Then
            m = 12
        ElseIf(op = "weekly") Then
            m = 52
        ElseIf(op = "daily") Then
            m = 365
        Else
            Console.WriteLine("Invalid Choice try again")
        End If
    End Sub
    Public Function GetFutureValue() As Double
        InterestRate = InterestRate/100
        GetFutureValue = PresentValue * (Math.Pow((1+(InterestRate/m)),(Period*m)))
    End Function
    Public Sub Display()
        Console.WriteLine("Present Value : {0}",PresentValue)
        Console.WriteLine("Interst Rate  : {0}",InterestRate)
        Console.WriteLine("Compunded     : {0}",Period)
        Console.WriteLine("For Period     : {0}",Period)
        Console.WriteLine("Future Value  : {0}",GetFutureValue())
    End Sub
    Shared Sub Main()
        Dim obj1 As New FutureValue()
        obj1.GetDimensions()
        obj1.Display()
        Console.ReadLine()
    End Sub
End Class