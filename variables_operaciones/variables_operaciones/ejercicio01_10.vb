Module ejercicio01_10
    Sub Main()
        Dim monto As Integer
        Dim interes As Single
        Dim tiempo As UShort
        Dim intereses_producidos As Single
        Dim capital_acumulado As Single

        Console.WriteLine("Ingrese el monto: ")
        monto = Console.ReadLine()
        Console.WriteLine("Ingrese el interes: ")
        interes = Console.ReadLine()
        Console.WriteLine("Ingrese el tiempo: ")
        tiempo = Console.ReadLine()

        intereses_producidos = (monto * interes * tiempo) / (360 * 100)

        Console.WriteLine("Los intereses producidos son: " & intereses_producidos)

        capital_acumulado = monto + intereses_producidos
        Console.WriteLine("El capital acumulado es: " & capital_acumulado)

        Console.ReadKey()
    End Sub
End Module