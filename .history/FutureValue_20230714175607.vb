Imports System
Public Class FutureValue
    Private PresentValue, InterestRate, Period As Double
    Public Sub GetDimensions()
        Console.WriteLine("Enter the Present value")
        PresentValue = Console.ReadLine
        Console.WriteLine("Whats the Interest Rate?")
        InterestRate = Console.ReadLine
        Console.WriteLine("How long is the investment taking?")
        Period = Console.ReadLine
    End Sub
    Public Function GetFutureValue() As Double
        InterestRate = InterestRate/100
        GetFutureValue = PresentValue * (Math.Pow(1+InterestRate),Period)
    End Sub
    Public Sub Display()
        Console.WriteLine("Prese : {0}",length)
        Console.WriteLine("Width : {0}",width)
        Console.WriteLine("Area : {0}",GetArea())
    End Sub