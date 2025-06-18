using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de la derivada de la función f(x) = x^2");
            double x = 2.0;
            double h = 0.0001;
            double derivative = CalculateDerivative(x, h);

            Console.WriteLine($"La derivada de f(x) en x = {x} es aproximadamente {derivative}");

            Console.ReadLine();
        }
        static double CalculateDerivative(double x, double h)
        {
            double derivative = (Function(x + h) - Function(x)) / h;
            return derivative;
        }

        static double Function(double x)
        {
            return x * x;
        }
    }

}
