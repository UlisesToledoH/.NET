using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesApp
{
    internal class Matrices
    {
        private int m, n;
        public double[,] elem;

        private double[,] Elem
        {
            set { elem = value; }
            get { return (elem); }
        }
        public double Matrices(int m,int n) { 
            this.m = m;
            this.n = n;
            Elem=new double[m,n];
        }

    }
}
