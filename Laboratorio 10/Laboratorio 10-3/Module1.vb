Module peso

    Sub Main()
        ' Declaración de variables
        Dim M As Double ' Masa del objeto
        Dim G As Double = 9.8 ' Aceleración de la gravedad (constante)
        Dim P As Double ' Peso del objeto

        ' Ingresar el valor de la masa
        Console.Write("Ingrese la masa del objeto: ")
        M = Convert.ToDouble(Console.ReadLine())

        ' Calcular el peso
        P = M * G

        ' Mostrar el resultado
        Console.WriteLine("El peso del objeto es: {0}", P)

        ' Pausar la consola para ver el resultado
        Console.ReadKey()
    End Sub

End Module