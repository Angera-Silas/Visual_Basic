Module SwitchCase
    Sub Main()
        Dim Num As Integer
        Console.WriteLine("Enter a digit")
        Num = Console.ReadLine
        Select Case Num
            Case 1
                Console.WriteLine("Sunday")
            Case 2
                Console.WriteLine("Monday")
            Case 3
                Console.WriteLine("Tuesday")
            Case 4
                Console.WriteLine("Wednesday")
            Case 5
                Console.WriteLine("Thursday")
            Case 6
                Console.WriteLine("Friday")
            Case 7
                Console.WriteLine("Saturday")
            Case Else
                Console.WriteLine("Kindly use number 1 to 7")