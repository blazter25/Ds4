public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int ObtenerNumeroAleatorio(int minimo, int maximo)
    {
        return random.Next(minimo, maximo + 1);
    }

    public int[] ObtenerArregloAleatorio(int tamaño, int minimo, int maximo)
    {
        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] = ObtenerNumeroAleatorio(minimo, maximo);
        }
        return arreglo;
    }
}