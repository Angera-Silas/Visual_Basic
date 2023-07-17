Imports System
Public Class Prime
    Shared Sub Main()
        Dim number As Integer
        For number = 2 To 100
            For x As Integer = 2 To number
                If(number MOD x = 0) Then
                    Exit For
                End If
            Next x
            If(x>(number)) Then
                Console.Write("{0} ",number)
            End If
        Next number
        Console.ReadLine()
    End Sub
End Class


