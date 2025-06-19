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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 f22 = new Form22();
            f22.ShowDialog();
        }
    }
}
