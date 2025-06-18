using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de hosts disponibles en una red");
            Console.Write("Ingrese la máscara de subred (en formato CIDR, por ejemplo, 24): ");

            if (int.TryParse(Console.ReadLine(), out int cidr))
            {
                int hosts = (int)Math.Pow(2, 32 - cidr) - 2; // Restamos 2 para excluir la dirección de red y la de broadcast
                Console.WriteLine($"La red tiene {hosts} hosts disponibles.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero (CIDR).");
            }
            Console.ReadLine();
        }
    }
}
