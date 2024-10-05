using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos al usuario que ingrese el tamaño de la matriz (N)
        Console.Write("Ingrese el tamaño de la matriz (N, debe ser par): ");
        int N = int.Parse(Console.ReadLine());

        // Validar que N sea par (si no es par, muestra un mensaje y termina el programa)
        if (N % 2 != 0)
        {
            Console.WriteLine("N debe ser un número par.");
            return;
        }

        // Creamos la matriz de tamaño N
        int[,] matriz = new int[N, N];

        // Ponemos los numero aleatoriamente en la diagonal excepto en el 1 y el ultimo
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            if (i == 0 || i == N - 1)
            {
                matriz[i, i] = 0;
            }
            else
            {
                matriz[i, i] = random.Next(101, 201);
            }
        }

        // Mostrar la matriz principal
        Console.WriteLine("Matriz creada:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Aqui realizamos la suma de los valores de la diagonal de la matriz
        int sumaDiagonal = 0;
        for (int i = 0; i < N; i++)
        {
            sumaDiagonal += matriz[i, i];
        }

        // Mostrar la suma de la diagonal
        Console.WriteLine("Suma de los valores de la diagonal de la matriz: " + sumaDiagonal);
    }
}
