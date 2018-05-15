Module ejercicio01_09
    Sub Main()
        Dim v As Boolean = True
        Dim f As Boolean = False

        Console.WriteLine("#==================#")
        Console.WriteLine("#| Exp1 | NO Exp1 |#")
        Console.WriteLine("#==================#")
        Console.WriteLine("#|  V   |    " & (Not v) & "    |#")
        Console.WriteLine("#|------|---------|#")
        Console.WriteLine("#|  F   |    " & (Not f) & "    |#")
        Console.WriteLine("#==================#")

        Console.WriteLine("")

        Console.WriteLine("#=============================#")
        Console.WriteLine("#| Exp1 | Exp2 | Exp1 Y Exp2 |#")
        Console.WriteLine("#=============================#")
        Console.WriteLine("#|  V   |  V   |      " & (v And v) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  V   |  F   |      " & (v And f) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  F   |  V   |      " & (f And v) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  F   |  F   |      " & (f And f) & "      |#")
        Console.WriteLine("#=============================#")

        Console.WriteLine("")

        Console.WriteLine("#=============================#")
        Console.WriteLine("#| Exp1 | Exp2 | Exp1 O Exp2 |#")
        Console.WriteLine("#=============================#")
        Console.WriteLine("#|  V   |  V   |      " & (v Or v) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  V   |  F   |      " & (v Or f) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  F   |  V   |      " & (f Or v) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  F   |  F   |      " & (f Or f) & "      |#")
        Console.WriteLine("#=============================#")

        Console.WriteLine("")

        Console.WriteLine("#=============================#")
        Console.WriteLine("#| Exp1 | Exp2 | Exp1 O Exp2 |#")
        Console.WriteLine("#=============================#")
        Console.WriteLine("#|  V   |  V   |      " & (v Xor v) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  V   |  F   |      " & (v Xor f) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  F   |  V   |      " & (f Xor v) & "      |#")
        Console.WriteLine("#|------|------|--------------#")
        Console.WriteLine("#|  F   |  F   |      " & (f Xor f) & "      |#")
        Console.WriteLine("#=============================#")

        Console.WriteLine("")

        Console.ReadKey()
    End Sub
End Module