using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Matrices
    {
        private int m, n;
        private double[ , ]elem;
        public Matrices(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.elem = new double[m,n];
        }

        public void Leer()
        {
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    elem[i,j]=double.Parse(Console.ReadLine());
                }
            }
        }
        public void Pon()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(elem[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public double SumaElem()//Suma de elementos de la matriz
        {
            double s = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s = s + elem[i, j];
                }

            }
            return (s);
        }

        
    }
}
