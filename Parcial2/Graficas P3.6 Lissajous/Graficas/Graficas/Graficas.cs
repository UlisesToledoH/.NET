﻿using System;
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
        //Practica 3
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
        public double fu(double x)
        {
            double r;
            r = Math.Cos(x);
            return r;
        }
        public double g(double x, string fx)
        {
            double r;
            r = Math.Cos(x);
            ExpressionParser p1 = new ExpressionParser();
            p1.Values.Add("x", x);
            r = p1.Parse(fx);
            return r;
        }

        public void Graficador(double xi,double xf)
        {
            double h;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++)
            {
                x[k] = xi + k * h;
                y[k] = fu(x[k]);
            }
        }
        public void GrafPolar(double xi,double xf,string ga){
            double h, ang, r;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++)
            {
                ang= xi + k * h;
                r = g(ang, ga);
                x[k] = r*Math.Cos(ang);
                y[k] = r*Math.Sin(ang);
            }
           

        }

        public void GrafPara(double xi,double xf,string gt,string ft) {
            double h, t;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++)
            {
                t= xi + k * h;
                x[k] = fu2(t,ft);
                y[k] = g(t, gt);
            }

        }
        public double fu2(double x,string ft)
        {
            double r;
            r = Math.Cos(x);
            ExpressionParser p1 = new ExpressionParser();
            p1.Values.Add("x", x);
            r = p1.Parse(ft);
            return r;
        }

    }
}
