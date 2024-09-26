

namespace Laboratorio_9_4
{
    internal class Aleatorios
    {
    }
}
// Crear un objeto de la clase Aleatorios
Aleatorios generador = new Aleatorios();

// Generar un número aleatorio entre 1 y 10
int numeroAleatorio = generador.GenerarNumeroAleatorio(1, 10);
Console.WriteLine("Número aleatorio: " + numeroAleatorio);

// Generar un arreglo de 5 números aleatorios entre 5 y 15
int[] arregloAleatorio = generador.GenerarArregloAleatorio(5, 5, 15);
Console.WriteLine("Arreglo aleatorio: " + string.Join(", ", arregloAleatorio));
