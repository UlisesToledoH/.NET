using Practica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class Operaciones
    {
        private double y;
        private double x;
        private double r;

        public double X { get => x; set => x = value; }
        public double R { get => r; set => r = value; }
        public double Y { get => y; set => y = value; }

        public double exponencial(double X)
        {
            R = Math.Exp(X);
            return R;
        }
        public double Sen(double X)
        {
            R =Math.Sin(X);
            return R;
        }
        public double Cos(double X)
        {
            R = Math.Cos(X);
            return R;
        }
        public double tan(double X) {
            R = Math.Tan(X);
            return R;
        }
        public double asen(double X) {
            R = Math.Asin(X);
            return R;
        }
        public double acos(double X) {
            R = Math.Acos(X);
            return R;
        }
        public double atan(double X)
        {
            R = Math.Atan(X);
            return R;
        }
        public double sinh(double X) {
            R = Math.Sinh(X);
            return R;
        }
        public double cosh(double X)
        {
            R = Math.Cosh(X);
            return R;
        }
        public double tanh(double X)
        {
            R = Math.Tanh(X);
            return R;
        }
        public double ln(double X)
        {
            R = Math.Log(X);
            return R;
        }
        public double potencia(double X, double Y)
        {
            R = Math.Pow(X,Y);
            return R;
        }
        public double suma(double X, double Y)
        {
            R = X+Y;
            return R;
        }
        public double resta(double X, double Y)
        {
            R = X - Y;
            return R;
        }
        public double mult(double X, double Y)
        {
            R = X * Y;
            return R;
        }
        public double div(double X, double Y)
        {
            R = X / Y;
            return R;
        }
        public double residuo(double X, double Y)
        {
            R = X % Y;
            return R;
        }

    }
}
