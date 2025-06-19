using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de la Frecuencia de una Onda Electromagnética");

            // Velocidad de la luz en el vacío en metros por segundo
            double velocidadLuz = 299792458.0;

            // Longitud de onda en metros
            double longitudOnda = 0.5; // Ejemplo: 0.5 metros

            // Calcular la frecuencia usando la ecuación de velocidad de la luz
            double frecuencia = velocidadLuz / longitudOnda;

            Console.WriteLine($"La frecuencia de la onda electromagnética es aproximadamente {frecuencia} Hz");

            Console.ReadLine();
        }
    }
}
