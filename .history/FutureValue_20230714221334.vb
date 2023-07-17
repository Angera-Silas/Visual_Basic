Imports System
Public Class FutureValue
    Private PresentValue, InterestRate, Period As Double
    Dim m As Integer
    Public Sub GetDimensions()
        Console.WriteLine("Enter the Present value")
        PresentValue = Console.ReadLine
        Console.WriteLine("Whats the Interest Rate?")
        InterestRate = Console.ReadLine
        Console.WriteLine("How long is the investment taking?")
        Period = Console.ReadLine
        Console.WriteLine("How the investment compounded? \n1. Annually \n2. Semi-Annually \n3. Quaterly \n4. Monthly \n5. Weekly \n.6 Daily")
        Dim option As Integer = Console.ReadLine
        If option = 1 Then
            m = 1
        ElseIf option = 2 Then
            m = 2
        ElseIf option = 3 Then
            m = 4
        ElseIf option = 4 Then
            m = 12
        ElseIf option = 5 Then
            m = 52
        ElseIf option = 6 Then
            m = 365
        Else
            Console.Wr
    End Sub
    Public Function GetFutureValue() As Double
        InterestRate = InterestRate/100
        GetFutureValue = PresentValue * (Math.Pow((1+InterestRate),Period))
    End Function
    Public Sub Display()
        Console.WriteLine("Present Value : {0}",PresentValue)
        Console.WriteLine("Interst Rate  : {0}",InterestRate)
        Console.WriteLine("Period        : {0}",Period)
        Console.WriteLine("Future Value  : {0}",GetFutureValue())
    End Sub
    Shared Sub Main()
        Dim obj1 As New FutureValue()
        obj1.GetDimensions()
        obj1.Display()
        Console.ReadLine()
    End Sub
End Class