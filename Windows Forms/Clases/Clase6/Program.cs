using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Longitud de Antenas");
            Console.WriteLine("-------------------------------");

            Console.Write("Ingrese la frecuencia de la antena (en MHz): ");
            double frecuenciaMHz = double.Parse(Console.ReadLine());

            // Calculamos la longitud de onda usando la fórmula c = λf, donde c es la velocidad de la luz en metros/segundo (aproximadamente 3x10^8 m/s)
            double velocidadLuz = 3e8; // Velocidad de la luz en metros/segundo
            double frecuenciaHz = frecuenciaMHz * 1e6; // Convertir MHz a Hz
            double longitudOnda = velocidadLuz / frecuenciaHz;

            Console.WriteLine($"La longitud de onda es aproximadamente {longitudOnda} metros.");
            Console.ReadLine();
        }
    }
}
