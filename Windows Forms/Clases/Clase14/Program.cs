using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de la Potencia Aparente en un Circuito Trifásico");

            // Solicitar al usuario las tensiones de línea (en voltios) y las corrientes de fase (en amperios)
            Console.Write("Ingrese la tensión de línea (VL) en voltios: ");
            double tensionLinea = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la corriente de fase (IL) en amperios: ");
            double corrienteFase = double.Parse(Console.ReadLine());

            // Calcular la potencia aparente (S) en el circuito trifásico
            double potenciaAparente = Math.Sqrt(3) * tensionLinea * corrienteFase;

            Console.WriteLine($"La potencia aparente en el circuito es aproximadamente {potenciaAparente} voltamperios (VA).");

            Console.ReadLine();
        }
    }
}
