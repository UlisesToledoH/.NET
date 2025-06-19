using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Xo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Integral_click(object sender, EventArgs e)
        {
            double Xo, Xn, Vi;
            int n;
            n = 10000;
            Xo=double.Parse(tbx1.Text);
            Xn=double.Parse(tbx2.Text);
            Integrales integral=new Integrales(Xo,Xn);
            Vi = integral.Trapecio(n);
            listBox1.Items.Add(Vi);
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("FIRMA.exe");
        }
    }
}
