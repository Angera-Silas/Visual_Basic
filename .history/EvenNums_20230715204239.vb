Imports System
Module Even
    Sub Main()
        Dim num As Integer = 100
        Console.WriteLine("EVEN NUMBERS BETWEEN 0 AND 100 IN DESCENDING ORDER")
        Do While num>0
            num=-1
            If(num MOD 2 = 0) Then
                Console.Write("{0} ",num)
            End 
        Loop
    End Sub
End Module