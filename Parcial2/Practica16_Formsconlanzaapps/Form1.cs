using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica15_NavegacionForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FORM10_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void FIRMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("FIRMA.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
    }
}
