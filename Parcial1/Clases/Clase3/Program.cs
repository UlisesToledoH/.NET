﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double po = 1.21; // Densidad del aire en kg/m^3
            double c = 343.0; // Velocidad del sonido en m/s

            // ingrese la presión acústica (Po)
            Console.Write("Ingrese la presión acústica (Po) en Pa: ");
            double presionAcustica = Convert.ToDouble(Console.ReadLine());

            // Calcular la intensidad acústica
            double intensidadAcustica = (presionAcustica * presionAcustica) / (2.0 * po * c);

            // resultado
            Console.WriteLine($"La intensidad acústica es: {intensidadAcustica} W/m^2");

            Console.ReadLine();
        }
    }
}
