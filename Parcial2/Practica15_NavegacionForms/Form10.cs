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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
