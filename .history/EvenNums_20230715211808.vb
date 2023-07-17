Imports System
Module Even
    Sub Main()
        Dim num As Integer
        Console.WriteLine("EVEN NUMBERS BETWEEN 0 AND 100 IN DESCENDING ORDER")
        Do While(num>=2)
            num = num-1
            If(num MOD 2 = 0) Then
                Console.Write("{0} ",num)
            End If
        Loop
        Console.ReadLine()
    End Sub
End Module