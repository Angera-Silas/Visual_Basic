Imports System
Public Class Rectangle
    Private length As Double
    Private width As Double
    'public methods
    Public Sub AcceptDetails()
        length = 10.5
        width = 9.5
    End Sub
    Public Function GetArea() As Double
        GetArea = lenght * width
    End Function
    Public Sub Display()
        Console.WriteLine()