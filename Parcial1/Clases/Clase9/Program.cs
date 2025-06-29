﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir los parámetros de la señal cuadrada
            int frecuencia = 1; // Frecuencia en Hz
            double amplitud = 5.0; // Amplitud de la señal

            // Calcular el período de la señal cuadrada
            double periodo = 1.0 / frecuencia;

            // Calcular el valor promedio de la señal cuadrada en un período
            double valorPromedio = amplitud / 2.0;

            // Mostrar los resultados
            Console.WriteLine("Parámetros de la señal cuadrada:");
            Console.WriteLine("Frecuencia: " + frecuencia + " Hz");
            Console.WriteLine("Amplitud: " + amplitud);
            Console.WriteLine("Periodo: " + periodo + " segundos");
            Console.WriteLine("Valor promedio en un período: " + valorPromedio);

            Console.ReadLine();
        }
    }
}
