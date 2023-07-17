Imports System
Public Class Prime
    Dim number As Integer
    Dim nonPrime As Boolean = false
    Shared Sub Main()
        For number = 2 To 100
            For x As Integer = 2 To number
                If(number MOD x = 0) Then
                    nonPrime = true
                    Exit For
                End If
            Next x
            If(nonPrime = true) Then
                Console.Write("{0} ",number)
            End If
        Next
    End Sub
End Class


