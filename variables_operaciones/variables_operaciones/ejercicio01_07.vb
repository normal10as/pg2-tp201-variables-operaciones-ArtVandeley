Module ejercicio01_07
    Sub Main()
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim numero3 As Integer
        Dim numero4 As Integer
        Dim sumatoria As Integer
        Dim promedio As Integer

        Console.WriteLine("Ingresar el primer valor entero:")
        numero1 = Console.ReadLine()

        Console.WriteLine("Ingresar el segundo valor entero:")
        numero2 = Console.ReadLine()

        Console.WriteLine("Ingresar el tercer valor entero:")
        numero3 = Console.ReadLine()

        Console.WriteLine("Ingresar el cuarto valor entero:")
        numero4 = Console.ReadLine()

        sumatoria = numero1 + numero2 + numero3 + numero4
        promedio = sumatoria / 4

        Console.WriteLine("sumatoria = " & sumatoria)
        Console.WriteLine("promedio = " & promedio)

        Console.ReadKey()
    End Sub
End Module