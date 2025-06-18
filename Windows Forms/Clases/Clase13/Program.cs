using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de la Longitud de Onda de una Señal Electromagnética");

            // Solicitar al usuario la frecuencia en Hertz (Hz)
            Console.Write("Ingrese la frecuencia en Hertz (Hz): ");
            double frecuencia = double.Parse(Console.ReadLine());

            // Calcular la velocidad de la luz en metros por segundo (m/s)
            double velocidadDeLaLuz = 299792458.0;

            // Calcular la longitud de onda en metros (m)
            double longitudDeOnda = velocidadDeLaLuz / frecuencia;

            Console.WriteLine($"La longitud de onda de la señal electromagnética es aproximadamente {longitudDeOnda} metros.");

            Console.ReadLine();
        }
    }
}
