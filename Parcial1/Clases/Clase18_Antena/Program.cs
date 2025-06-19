using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18_Antena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Impedancia de una Antena Dipolo de Media Onda");

            // Longitud de onda en metros
            double longitudDeOnda = 1.0; // Ejemplo: 1 metro

            // Calcular la impedancia de la antena
            double impedancia = CalculateDipoleImpedance(longitudDeOnda);

            Console.WriteLine($"La impedancia de la antena dipolo de media onda es: {impedancia} ohmios");

            Console.ReadLine();
        }

        static double CalculateDipoleImpedance(double longitudDeOnda)
        {
            // Fórmula para calcular la impedancia de una antena dipolo de media onda
            double impedancia = 73.0 * Math.Log(2.0 * longitudDeOnda);

            return impedancia;
        }
    }
    
}
