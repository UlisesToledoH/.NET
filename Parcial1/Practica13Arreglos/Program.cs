using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            double s;
            Console.WriteLine("Valor de m : ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de n : ");
            n = int.Parse(Console.ReadLine());
            Matrices A = new Matrices(m, n);
            A.Leer();
            A.Pon();
            s = A.SumaElem();
            Console.WriteLine("s= " + s);
            Console.ReadKey();
        }
    }
}
