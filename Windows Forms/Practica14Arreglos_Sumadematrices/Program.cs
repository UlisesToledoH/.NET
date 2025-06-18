using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        private object C;

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

            Matrices B = new Matrices(m, n);
            B.Leer();
            B.Pon();

            s = A.SumaElem();
            Console.WriteLine("s= " + s);
            Console.ReadKey();
            Matrices C = new Matrices(m, n);
            C.SumaAB(A,B,C);
            C.Pon();
            Console.ReadLine();

        }
       
    }
}
