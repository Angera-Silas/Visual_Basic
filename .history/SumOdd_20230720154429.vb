Module SumOdd
    Sub Main()
        Dim sum As Integer = 0
        Dim count As Integer = 1
        While count<=15
            If count MOD 2 <> 0 Then
                sum = sum + count
            End If
            count = count + 1
        End While
        
    End Sub
End Module