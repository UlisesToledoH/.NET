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
        Button btn1;
        ListBox tb2;

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

            tb1 = new TextBox();
            tb1.Width = 80;
            tb1.Height = 30;
            tb1.Location = new Point(30, 50);
            gb1.Controls.Add(tb1);

            gb2 = new GroupBox();
            gb2.Text = "Proceso";
            gb2.Width = 300;
            gb2.Height = 400;
            gb2.Location = new Point(360, 50);
            this.Controls.Add(gb2);

            btn1 = new Button();
            btn1.Text = "Calc";
            btn1.Width = 80;
            btn1.Height = 30;
            btn1.Location = new Point(30, 50);
            btn1.Click += Btn1_Click; // Manejador de evento para el botón
            gb2.Controls.Add(btn1);

            gb3 = new GroupBox();
            gb3.Text = "Salida";
            gb3.Width = 300;
            gb3.Height = 400;
            gb3.Location = new Point(680, 50);
            this.Controls.Add(gb3);

            tb2 = new ListBox();
            tb2.Width = 200; // Aumenta el ancho para mostrar el contenido
            tb2.Height = 300; // Aumenta la altura para mostrar varios elementos
            tb2.Location = new Point(30, 50);
            gb3.Controls.Add(tb2);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {   
    
                double x, r;
                x = double.Parse(tb1.Text);
                r = Math.Exp(x);
                tb2.Items.Add(r);
            
        }
    }
}
