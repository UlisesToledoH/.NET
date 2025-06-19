using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class MATC:MATB
    {
        protected int mc, nc;
        protected double[,] c;

        public MATC(int ma, int na, int mb, int nb,int mc,int nc) : base(ma, na,mb,nb)
        {
            this.mc = mc;
            this.nc = nc;
            c = new double[mc, nc];
        }
        public void SumaAB()
        {
            for (int i = 0; i < mc; i++)
            {
                for (int j = 0; j < nc; j++)
                {

                    c[i,j]=(a[i,j]+b[i, j]);

                }
                
            }
        }
        public void PonC()
        {
            for (int i = 0; i < mc; i++)
            {
                for (int j = 0; j < nc; j++)
                {

                    Console.Write(c[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
