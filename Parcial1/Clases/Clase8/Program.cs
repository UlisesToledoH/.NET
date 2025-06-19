using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parámetros de la señal senoidal
            double amplitud = 2.0;
            double frecuencia = 5.0;
            double fase = Math.PI / 4.0; // 45 grados en radianes
            double tiempo = 2.0; // Tiempo en segundos

            // Calcular la señal senoidal
            double valor = amplitud * Math.Sin(2 * Math.PI * frecuencia * tiempo + fase);

            // Mostrar el resultado
            Console.WriteLine($"Para un tiempo {tiempo}s, frecuencia {frecuencia}Hz, amplitud {amplitud} V \t");
            Console.WriteLine($"El valor de la señal senoidal en t = {tiempo} segundos es {valor}");

            Console.ReadLine();
        }
    }
}
