using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nota La (A) de referencia con una frecuencia de 440 Hz.
            double referencia = 440.0;

            Console.WriteLine("Calculadora de Frecuencias Musicales");
            Console.WriteLine("-----------------------------------");

            while (true)
            {
                Console.Write("Ingrese una nota (Do, Re, Mi, Fa, Sol, La, Si) o 'Salir' para finalizar: ");
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "salir")
                    break;

                double frecuencia = CalcularFrecuencia(entrada, referencia);

                if (frecuencia > 0)
                    Console.WriteLine($"La frecuencia de {entrada} es {frecuencia:F2} Hz");
                else
                    Console.WriteLine("Nota no válida. Asegúrese de ingresar una nota válida.");
            }
        }

        static double CalcularFrecuencia(string nota, double referencia)
        {
            switch (nota)
            {
                case "do":
                    return referencia * Math.Pow(2.0, -9.0 / 12.0);
                case "re":
                    return referencia * Math.Pow(2.0, -7.0 / 12.0);
                case "mi":
                    return referencia * Math.Pow(2.0, -5.0 / 12.0);
                case "fa":
                    return referencia * Math.Pow(2.0, -4.0 / 12.0);
                case "sol":
                    return referencia * Math.Pow(2.0, -2.0 / 12.0);
                case "la":
                    return referencia;
                case "si":
                    return referencia * Math.Pow(2.0, 2.0 / 12.0);
                default:
                    return -1; // Nota no válida
            }
        }
    }
}
