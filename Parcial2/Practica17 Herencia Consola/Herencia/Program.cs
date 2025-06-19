using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ma, na, mb, nb, mc, nc;
            na=3; ma=2; 
            nb=3; mb=2; 
            nc=3; mc=2;

            MATC C = new MATC(ma, na, mb, nb, mc, nc);

            C.LeeA();
            C.PonA();
            C.LeeB();
            C.PonB();
            C.SumaAB();
            Console.WriteLine(" ");
            C.PonC();

        }
    }
}
