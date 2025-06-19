using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class MATA
    {
        protected int ma, na;
        protected double[,] a;
        
        public MATA(int ma, int na)
        {
            this.ma = ma;
            this.na = na;
            a= new double[ma, na]; 
        }
        public void LeeA() { 
            for (int i = 0; i < ma; i++)
            {
                for(int j = 0; j < na; j++)
                {
                    Console.WriteLine($"Digite el valor [{i},{j}]: ");
                    a[i, j] = double.Parse(Console.ReadLine());

                }
            }
        }
        public void PonA()
        {
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {

                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

    }
   
}
