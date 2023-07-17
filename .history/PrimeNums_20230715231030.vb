Imports System
Public Class Prime
    Shared Sub Main()
        Dim number As Integer
        For number = 2 To 100
            For x As Integer = 2 To number
                If(number MOD x = 0) Then
                    nonPrime = true
                    Exit For
                End If
            Next x
            If(nonPrime = false) Then
                Console.Write("{0} ",number)
            End If
        Next number
    End Sub
End Class


