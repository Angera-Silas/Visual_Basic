Imports System
Module OddNums
    Dim Odd As Integer = 100
    Sub Main()
        Do
            Odd =  Odd - 1
            If((Odd/!= Odd) Then
                Console.WriteLine("{0}  ",Odd)
            End If
        Loop While (Odd>0)
    End Sub
End Module