using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class MATB:MATA
    {
        protected int mb, nb;
        protected double[,] b;

        public MATB(int ma, int na,int mb, int nb):base(ma,na)
        {
            this.mb = mb;
            this.nb = nb;
            b = new double[mb, nb];
        }
        public void LeeB()
        {
            for (int i = 0; i < mb; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    Console.WriteLine($"Digite el valor [{i},{j}]: ");
                    b[i, j] = double.Parse(Console.ReadLine());

                }
            }
        }
        public void PonB()
        {
            for (int i = 0; i < mb; i++)
            {
                for (int j = 0; j < nb; j++)
                {

                    Console.Write(b[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
