using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Resistencias en Serie y Paralelo");
            Console.WriteLine("------------------------------------------------");

            while (true)
            {
                Console.WriteLine("\t");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Calcular en serie");
                Console.WriteLine("2. Calcular en paralelo");
                Console.WriteLine("3. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    CalcularSerie();
                }
                else if (opcion == 2)
                {
                    CalcularParalelo();
                }
                else if (opcion == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                }
            }
        }

        static void CalcularSerie()
        {
            Console.WriteLine("Ingrese la cantidad de resistencias en serie:");
            int n = int.Parse(Console.ReadLine());

            double resistenciaTotal = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese el valor de la resistencia {i} (en ohmios): ");
                double resistencia = double.Parse(Console.ReadLine());
                resistenciaTotal += resistencia;
            }

            Console.WriteLine($"La resistencia total en serie es {resistenciaTotal} ohmios.");
        }

        static void CalcularParalelo()
        {
            Console.WriteLine("Ingrese la cantidad de resistencias en paralelo:");
            int n = int.Parse(Console.ReadLine());

            double resistenciaTotal = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese el valor de la resistencia {i} (en ohmios): ");
                double resistencia = double.Parse(Console.ReadLine());
                resistenciaTotal += 1.0 / resistencia;
            }

            resistenciaTotal = 1.0 / resistenciaTotal;
            Console.WriteLine($"La resistencia total en paralelo es {resistenciaTotal} ohmios.");
        }
    }
}
