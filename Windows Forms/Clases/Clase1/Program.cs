using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double voltaje, resistencia, corriente;
            Console.WriteLine("Calculadora de la Ley de Ohm");
            Console.WriteLine("------------------------------");

            // Solicitar al usuario que ingrese el valor de la tensión eléctrica (V) en voltios.
            Console.Write("Ingrese el valor de la tensión eléctrica (V) en voltios: ");
            voltaje = double.Parse(Console.ReadLine());

            // Solicitar al usuario que ingrese el valor de la resistencia eléctrica (R) en ohmios.
            Console.Write("Ingrese el valor de la resistencia eléctrica (R) en ohmios: ");
            resistencia = double.Parse(Console.ReadLine());

            // Calcular la corriente eléctrica (I) utilizando la Ley de Ohm.
            corriente = voltaje / resistencia;

            // Mostrar el resultado.
            Console.WriteLine($"La corriente eléctrica (I) es "+corriente+" amperios.");

            Console.ReadLine();
        }
    }
}
