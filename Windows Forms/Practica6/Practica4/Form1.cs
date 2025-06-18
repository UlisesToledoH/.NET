using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("FIRMA.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btoper_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Exp(x);
            lbsalida.Items.Add(r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Sin(x);
            lbsalida.Items.Add(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Cos(x);
            lbsalida.Items.Add(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Tan(x);
            lbsalida.Items.Add(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Asin(x);
            lbsalida.Items.Add(r);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Acos(x);
            lbsalida.Items.Add(r);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Atan(x);
            lbsalida.Items.Add(r);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Sinh(x);
            lbsalida.Items.Add(r);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Cosh(x);
            lbsalida.Items.Add(r);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Tanh(x);
            lbsalida.Items.Add(r);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double x, r;
            x = double.Parse(tBx.Text);
            r = Math.Log(x);
            lbsalida.Items.Add(r);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double x, r,y;
            x = double.Parse(tBx.Text);
            y= double.Parse(textBox1.Text);
            r = Math.Pow(x,y);
            lbsalida.Items.Add(r);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double x, r, y;
            x = double.Parse(tBx.Text);
            y = double.Parse(textBox1.Text);
            r = x+y;
            lbsalida.Items.Add(r);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double x, r, y;
            x = double.Parse(tBx.Text);
            y = double.Parse(textBox1.Text);
            r = x - y;
            lbsalida.Items.Add(r);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double x, r, y;
            x = double.Parse(tBx.Text);
            y = double.Parse(textBox1.Text);
            r = x * y;
            lbsalida.Items.Add(r);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double x, r, y;
            x = double.Parse(tBx.Text);
            y = double.Parse(textBox1.Text);
            r = x / y;
            lbsalida.Items.Add(r);
        }

        private void Residuo_Click(object sender, EventArgs e)
        {
            double x, r, y;
            x = double.Parse(tBx.Text);
            y = double.Parse(textBox1.Text);
            r = x % y;
            lbsalida.Items.Add(r);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
