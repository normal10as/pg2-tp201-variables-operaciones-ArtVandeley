Module semanas
    Sub Main()
        Const dias_del_año As Integer = 365
        Const dias_laborables As Integer = 250
        Const dias_de_la_semana As Integer = 7
        Dim semanas As Integer
        Dim semanas_laborables As Integer

        semanas = dias_del_año / 7
        semanas_laborables = dias_laborables / 7

        Console.WriteLine("El año tiene " & semanas & " semanas. " & semanas_laborables & " de ellas son laborables.")

        Console.ReadKey()
    End Sub
End Module
