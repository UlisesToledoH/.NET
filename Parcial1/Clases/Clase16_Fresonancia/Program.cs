﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_Fresonancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Frecuencia de Resonancia en un Circuito LC");

            // Solicitar al usuario el valor de la inductancia en henrios (H)
            Console.Write("Ingrese el valor de la inductancia en henrios (H): ");
            double inductancia = double.Parse(Console.ReadLine());

            // Solicitar al usuario el valor de la capacitancia en faradios (F)
            Console.Write("Ingrese el valor de la capacitancia en faradios (F): ");
            double capacitancia = double.Parse(Console.ReadLine());

            // Calcular la frecuencia de resonancia en hercios (Hz)
            double frecuenciaResonancia = 1 / (2 * Math.PI * Math.Sqrt(inductancia * capacitancia));

            Console.WriteLine($"La frecuencia de resonancia del circuito LC es aproximadamente {frecuenciaResonancia} Hz.");

            Console.ReadLine();
        }
    }
}
