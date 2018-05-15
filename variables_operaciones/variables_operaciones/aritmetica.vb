Module aritmetica
    Sub Main()
        Dim numero1 As Integer = 25
        Dim numero2 As Single = 50.8
        Dim numero3 As Integer = 37
        Dim numero4 As Single = 18.2

        Console.WriteLine("Operaciones Aritmeticas: ")

        Console.WriteLine()
        Console.WriteLine("Suma:")
        Console.WriteLine()

        Console.WriteLine("Suma de numeros enteros:")
        Console.WriteLine("numero1 + numero3 = " & numero1 + numero3)
        Console.WriteLine("Suma de un numero entero con un numero de punto flotante:")
        Console.WriteLine("numero1 + numero2 = " & numero1 + numero2)
        Console.WriteLine("Suma de numeros de punto flotante:")
        Console.WriteLine("numero2 + numero4 = " & numero2 + numero4)
        Console.WriteLine("Suma de un numero de punto flotante con un numero entero:")
        Console.WriteLine("numero4 + numero3 = " & numero4 + numero3)

        Console.WriteLine()
        Console.WriteLine("Resta:")
        Console.WriteLine()

        Console.WriteLine("Resta de numeros enteros:")
        Console.WriteLine("numero1 - numero3 = " & numero1 - numero3)
        Console.WriteLine("Resta de un numero entero con un numero de punto flotante:")
        Console.WriteLine("numero1 - numero2 = " & numero1 - numero2)
        Console.WriteLine("Resta de numeros de punto flotante:")
        Console.WriteLine("numero2 - numero4 = " & numero2 - numero4)
        Console.WriteLine("Resta de un numero de punto flotante con un numero entero:")
        Console.WriteLine("numero4 - numero3 = " & numero4 - numero3)

        Console.WriteLine()
        Console.WriteLine("Multiplicacion:")
        Console.WriteLine()

        Console.WriteLine("Multiplicacion de numeros enteros:")
        Console.WriteLine("numero1 * numero3 = " & numero1 * numero3)
        Console.WriteLine("Multiplicacion de un numero entero con un numero de punto flotante:")
        Console.WriteLine("numero1 * numero2 = " & numero1 * numero2)
        Console.WriteLine("Multiplicacion de numeros de punto flotante:")
        Console.WriteLine("numero2 * numero4 = " & numero2 * numero4)
        Console.WriteLine("Multiplicacion de un numero de punto flotante con un numero entero:")
        Console.WriteLine("numero4 * numero3 = " & numero4 * numero3)

        Console.WriteLine()
        Console.WriteLine("Division:")
        Console.WriteLine()

        Console.WriteLine("Division de numeros enteros:")
        Console.WriteLine("numero1 / numero3 = " & numero1 / numero3)
        Console.WriteLine("Division de un numero entero con un numero de punto flotante:")
        Console.WriteLine("numero1 / numero2 = " & numero1 / numero2)
        Console.WriteLine("Division de numeros de punto flotante:")
        Console.WriteLine("numero2 / numero4 = " & numero2 / numero4)
        Console.WriteLine("Division de un numero de punto flotante con un numero entero:")
        Console.WriteLine("numero4 / numero3 = " & numero4 / numero3)

        Console.ReadKey()
    End Sub
End Module