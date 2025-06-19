using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Matrices
    {
        private int m, n;
        private double[,]elem;
        

        

        public Matrices(int m, int n)
        {
            this.m = m;//filas
            this.n = n;//columnas
            this.elem = new double[m, n];
        }

        public Matrices()
        {
        }

        public void Leer()//Lee Matriz
        {
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Digite el valor {elem[i,j]}: ");
                    elem[i,j]=double.Parse(Console.ReadLine());
                }
            }
        }
        public void Pon()//Despliega la matriz
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(elem[i, j] + " ");
                }
                Console.WriteLine();
            }
            
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

        public void SumaAB(Matrices A, Matrices B, Matrices C)//Suma de Matrices
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C.elem[i, j] = A.elem[i, j] + B.elem[i, j];
                }
            }
        }
    }
}
