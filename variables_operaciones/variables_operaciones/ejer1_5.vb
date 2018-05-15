'Crear un programa que resuelva la siguiente ecuacion x = (b**2 - 4*a*C)/(2*a)'

Module ejer1_5
    Sub Main()
        Dim a As Byte = 1
        Dim b As Byte = 5
        Dim c As Byte = 2

        Console.WriteLine("x = " & (Math.Pow(b, 2) - 4 * a * c) / (2 * a))
        Console.ReadKey()
    End Sub
End Module
