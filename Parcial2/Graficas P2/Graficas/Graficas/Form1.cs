using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Graficas
{
    public partial class Form1 : Form
    {
        //PRACTICA 2
        int n;
        public Form1()
        {
            InitializeComponent();
            n = chart1.Width;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGraficar_Click(object sender, EventArgs e)
        {
            double xi=double.Parse(textBox1.Text);
            double xf = double.Parse(textBox2.Text);
            Graficas gr1 = new Graficas(n);
            gr1.Graficador(xi, xf);
            for(int k=0; k < n; k++)
            {
                chart1.Series["Series1"].Points.AddXY(gr1.X[k], gr1.Y[k]);
                lbsalida.Items.Add(gr1.X[k] + "\t" + gr1.Y[k]);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbsalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
