using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8_IGU_CON_CSHARE
{
    public partial class Form1 : Form
    {
        GroupBox gb1;
        GroupBox gb2;
        GroupBox gb3;
        TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            Genera();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void Genera()
        {
            gb1 = new GroupBox();
            gb1.Text = "Entrada";
            gb1.Width = 300;
            gb1.Height = 400;
            gb1.Location = new Point(40, 50);
            this.Controls.Add(gb1);

            tb1= new TextBox();
            tb1.Width = 80;
            tb1.Height = 30;
            tb1.Location = new Point(30, 50);
            gb1.Controls.Add(tb1);
            ////
            gb2 = new GroupBox();
            gb2.Text = "Proceso";
            gb2.Width = 300;
            gb2.Height = 400;
            gb2.Location = new Point(360, 50);
            this.Controls.Add(gb2);
            ///////////
            gb3 = new GroupBox();
            gb3.Text = "Salida";
            gb3.Width = 300;
            gb3.Height = 400;
            gb3.Location = new Point(680, 50);
            this.Controls.Add(gb3);

        }
    }
}
