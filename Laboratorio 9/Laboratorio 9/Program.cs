using System;

namespace ProgramaPrecioProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario el precio del producto
            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Validar que el precio sea positivo
            while (precio <= 0)
            {
                Console.WriteLine("El precio debe ser un valor positivo.");
                Console.Write("Ingrese el precio del producto: ");
                precio = Convert.ToDouble(Console.ReadLine());
            }

            // Pedir al usuario la forma de pago
            Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
            string formaPago = Console.ReadLine().ToLower();

            // Validar la forma de pago
            while (formaPago != "efectivo" && formaPago != "tarjeta")
            {
                Console.WriteLine("La forma de pago debe ser 'efectivo' o 'tarjeta'.");
                Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
                formaPago = Console.ReadLine().ToLower();
            }

            // Si la forma de pago es tarjeta, pedir el número de cuenta
            if (formaPago == "tarjeta")
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                string numeroCuenta = Console.ReadLine();

                // Validar el número de cuenta
                while (numeroCuenta.Length != 16)
                {
                    Console.WriteLine("El número de cuenta debe tener 16 dígitos.");
                    Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                    numeroCuenta = Console.ReadLine();
                }

                Console.WriteLine("Pago con tarjeta realizado correctamente.");
            }
            else
            {
                Console.WriteLine("Pago en efectivo realizado correctamente.");
            }

            Console.WriteLine("Precio total: $" + precio);
        }
    }
}