using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de hosts disponibles en una red");

            Console.Write("Ingrese el tamaño de la subred (en bits): ");
            int bitsSubred = int.Parse(Console.ReadLine());

            // Calcula el número de hosts disponibles
            int hostsDisponibles = (int)Math.Pow(2, 32 - bitsSubred) - 2;

            Console.WriteLine($"Número de hosts disponibles en la subred: {hostsDisponibles}");
            Console.ReadLine();
        }
    }
}
