using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo del Ancho de Banda Mínimo (Teorema de Nyquist)");

            // Frecuencia de la señal modulada (en Hz)
            double frecuenciaSenal = 5000;

            // Número de niveles de amplitud (para una modulación PAM)
            int nivelesAmplitud = 16;

            // Calcular el ancho de banda mínimo utilizando el teorema de Nyquist
            double anchoBandaMinimo = CalcularAnchoBandaNyquist(frecuenciaSenal, nivelesAmplitud);

            Console.WriteLine($"El ancho de banda mínimo requerido es de {anchoBandaMinimo} Hz.");

            Console.ReadLine();
        }
        static double CalcularAnchoBandaNyquist(double frecuenciaSenal, int nivelesAmplitud)
        {
            // Utilizamos el teorema de Nyquist para calcular el ancho de banda mínimo
            double anchoBandaMinimo = frecuenciaSenal * Math.Log(2, nivelesAmplitud);
            return anchoBandaMinimo;
        }
    }
}
