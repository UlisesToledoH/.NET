using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using info.lundin.math;

namespace Graficas
{
    internal class Graficas
    {
        //Practica 2
        private double xi, xf;
        private int n;
        private double[] x;
        private double[] y;

        public Graficas(int n)
        {
            this.n = n;
            x = new double[n];
            y = new double[n];
        }
        public double[] X
        {
            set { x = value; }
            get { return (x); }
        }
        public double[]     Y
        {
            set { y = value; }
            get { return (y); }
        }
        public double fn(double x,string fx)
        {
            double r;
            r = Math.Cos(x);
            ExpressionParser p1 = new ExpressionParser();
            p1.Values.Add("y",x);
            r = p1.Parse(fx);
            return r;
        }
        public void Graficador(double xi,double xf,string fx)
        {
            double h;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++)
            {
                x[k] = xi + k * h;
                y[k] = fn(x[k]);
            }
        }
    }
}
