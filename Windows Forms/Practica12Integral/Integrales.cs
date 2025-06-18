using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Integrales
    {
        private double Xo, Xn;
        public Integrales(double xo, double xn)
        {
            this.Xo = xo;
            this.Xn = xn;
        }
        public double Fn(double x)
        {
            double y;
            y=Math.Exp(-x*x);
            return y;
        }
        public double Trapecio(int n)
        {
            double h, yo, yn,S,At,X,y;
            h = (Xn - Xo) / n;
            yo = Fn(Xo);
            yn = Fn(Xn);
            S = 0;
            for(int k = 1; k < n; k++)
            {
                X=Xo+k*h;
                y = Fn(X);
                S = S + y;
            }
            At = h * ((yo + yn) / 2 + S);
                return At;
        }
    }
}
