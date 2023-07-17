Imports System
Public Class FutureValue
    Private PresentValue, InterestRate, Period, Futurevalue As Double
    Public Sub GetDimensions()
        Console.WriteLine("Enter the First value")
        a = Console.ReadLine