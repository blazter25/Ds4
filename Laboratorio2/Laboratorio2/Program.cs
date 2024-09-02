using System;
using System.Net.Http;
using System.Xml.Linq;

namespasce Laboratorio2
{
    class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        //Ejemplo utilizando las variables de instancia de clase.
        client.FirtsName = "Angel";
        client.LastName = "Martinez";
        client.age = 29;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }
}