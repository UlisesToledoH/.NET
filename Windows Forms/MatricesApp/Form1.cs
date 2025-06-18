using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttamaño_Click(object sender, EventArgs e)
        {
            
             m=int.Parse(Filas.Text);
             n=int.Parse(Columnas.Text);
            dGmat.RowCount = m;
            dGmat.ColumnCount = n;
            Matrices A = new Matrices(m,n);
        }

        private void Leer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                  A
                }
            }
        }
    }
}
