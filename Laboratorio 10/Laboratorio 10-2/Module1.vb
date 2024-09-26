Module Area

    Sub Main()
        ' Declaración de variables
        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const pi As Single = 3.1415926

        ' Solicitar el radio al usuario
        Console.Write("Ingrese el radio: ")
        radio = Convert.ToSingle(Console.ReadLine())

        ' Calcular el área y la circunferencia
        area = pi * radio * radio
        circunferencia = 2 * pi * radio

        ' Mostrar los resultados
        Console.WriteLine("El área es: {0}", area)
        Console.WriteLine("La circunferencia es: {0}", circunferencia)

        ' Pausar la consola para ver los resultados
        Console.ReadKey()
    End Sub

End Module