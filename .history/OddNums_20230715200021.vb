Imports System
Module OddNums
    Dim Odd As Integer = 100
    Sub Main()
        Do
            Odd =  Odd - 1
            If(Odd MOD 2 <> 0) Then
                Console.Write("{0}  ",Odd)
            End If
        Loop While (Odd>0)
        Co
    End Sub
End Module