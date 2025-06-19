using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15_Capacitancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Capacitancia Total de Capacitores");

            Console.Write("Ingrese el número de capacitores: ");
            int numCapacitores = int.Parse(Console.ReadLine());

            Console.Write("¿Están los capacitores en serie o en paralelo? (serie/paralelo): ");
            string tipoConexion = Console.ReadLine();

            double capacitanciaTotal = 0;

            for (int i = 1; i <= numCapacitores; i++)
            {
                Console.Write($"Ingrese la capacitancia del capacitor {i} en Faradios (F): ");
                double capacitancia = double.Parse(Console.ReadLine());

                if (tipoConexion.ToLower() == "serie")
                {
                    capacitanciaTotal += 1.0 / capacitancia;
                }
                else if (tipoConexion.ToLower() == "paralelo")
                {
                    capacitanciaTotal += capacitancia;
                }
                else
                {
                    Console.WriteLine("Tipo de conexión no válido. Use 'serie' o 'paralelo'.");
                    return;
                }
            }

            if (tipoConexion.ToLower() == "serie")
            {
                capacitanciaTotal = 1.0 / capacitanciaTotal;
            }

            Console.WriteLine($"La capacitancia total es {capacitanciaTotal} Faradios (F).");

            Console.ReadLine();
        }
    }
}
