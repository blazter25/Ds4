private int[,] mat;

public void Ingresar()

{
    Mat = new int[3, 4];
    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 4; c++)
        {
            Console.Write("Ingrese componente:");
            string linea;
            linea = Console.ReadLine();
            Mat[f, c] = int.Parse(linea);
        }
    }
}
public void Imprimir()
{
    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 4; c++)
        {
            Console.Write(Mat[f, c] + " ");
        }
        Console.WriteLine();
    }
    Console.ReadKey();
}

static void Main(string[] args)
{
    Matriz ma = new ();
    ma.Ingresar();
    ma.Imprimir();
}