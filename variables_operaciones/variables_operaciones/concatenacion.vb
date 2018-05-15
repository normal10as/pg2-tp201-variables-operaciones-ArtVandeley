Module concatenacion
    Sub Main()
        Dim nombre_de_la_empresa As String = "Vandelay Industries"
        Dim nombre_de_la_calle As String = "Siempreviva"
        Dim altura_de_la_calle As Short = 742
        Dim fecha_de_inicio_de_actividades As Date = #05/10/2018#

        'Console.Write("Ingrese el nombre de la empresa: ")
        'nombre_de_la_empresa = Console.ReadLine()

        'Console.Write("Ingrese el nombre de la calle: ")
        'nombre_de_la_calle = Console.ReadLine()

        'Console.Write("Ingrese la altura de la calle: ")
        'altura_de_la_calle = Console.ReadLine()

        'Console.Write("Ingrese la fecha de inicio de actividades: ")
        'fecha_de_inicio_de_actividades = Console.ReadLine()

        Console.WriteLine(nombre_de_la_empresa & " " & nombre_de_la_calle & " " & Convert.ToString(altura_de_la_calle) & " " & Convert.ToString(fecha_de_inicio_de_actividades)) 'Conversion explicita'
        Console.WriteLine(nombre_de_la_empresa & " " & nombre_de_la_calle & " " & altura_de_la_calle & " " & fecha_de_inicio_de_actividades) 'Conversion implicita'

        Console.ReadKey()
    End Sub

End Module
