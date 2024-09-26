using System;

namespace ClasificadorDeTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud de los tres lados del triángulo:");

            Console.Write("Lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Verificar si se puede formar un triángulo
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                // Verificar el tipo de triángulo
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Es un triángulo equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Es un triángulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Es un triángulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("No se puede formar un triángulo con esas medidas.");
            }
        }
    }
}