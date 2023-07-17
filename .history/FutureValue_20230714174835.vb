Imports System
Public Class FutureValue
    Private PresentValue, InterestRate, Period, Futurevalue As Double
    Public Sub GetDimensions()
        Console.WriteLine("Enter the Present value")
        PresentValue = Console.ReadLine
        Console.WriteLine("Enter the Interest Rate")
        InterestRate = Console.ReadLine
        Console.WriteLine("How long is the investment ")