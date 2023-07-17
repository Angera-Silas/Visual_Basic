Public class Area
    Private radius As Double
    #Const PI = 3.142
    Public Sub GetRadius()
        Console.WriteLine("ENTER THE RADIUS OF THE CIRCLE")
        radius = Console.ReadLine
    End Sub
    Public Function GetArea() As Double
        GetArea = PI * (Math.Pow(radius,2))
    End Function
    Shared Sub Main()
        Dim obj1 = New Area()