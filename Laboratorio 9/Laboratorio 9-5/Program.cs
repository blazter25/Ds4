using System.Linq;

// ... (resto de tu código)

// Crear un objeto de la clase Aleatorios
Aleatorios generador = new Aleatorios();

// Obtener un arreglo de números aleatorios sin repeticiones
int[] arregloSinRepeticiones = ObtenerArregloSinRepeticiones(10, 1, 50); // Ejemplo con 10 números entre 1 y 50

// Función para obtener un arreglo de números aleatorios sin repeticiones
int[] ObtenerArregloSinRepeticiones(int tamaño, int minimo, int maximo)
{
    HashSet<int> numerosUnicos = new HashSet<int>();
    while (numerosUnicos.Count < tamaño)
    {
        int numeroAleatorio = generador.ObtenerNumeroAleatorio(minimo, maximo);
        numerosUnicos.Add(numeroAleatorio);
    }

    return numerosUnicos.ToArray();
}