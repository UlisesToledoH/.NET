using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8
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

        private void pBcal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\WINWORD.EXE\"");
        }

        private void PowerP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\POWERPNT.EXE\"");
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE\"");
        }

        private void Video_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\VLC\\vlc.exe");
        }

        private void WMplayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Windows Media Player\\wmplayer.exe");
        }

        private void Blocnotas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\Notepad.lnk");
        }

        private void Publisher_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\MSPUB.EXE");
        }

        private void Access_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\MSACCESS.EXE");
        }

        private void Adobe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Adobe\\Acrobat DC\\Acrobat\\Acrobat.exe");
        }
        //ARCHIVOS PARA PROGRAMAS
        private void DocExc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Tabla-Ejercicio-LIsta-Subtotal.xlsx");
        }

        private void DocWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Lista de lugares donde quisiera hacer servicio social.docx");
        }

        private void DocPP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("1  EMPRESA Empresario Emprende 1.pptx");
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Sociedad Humanidades IV_230906_172348.pdf");
        }

        private void VideoVLC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Waterfall.mp4");
        }

        private void DocWMplayer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Only the Braves - FiftySounds.mp3");
        }

        private void Blocnotasarchivo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Bloc.txt");
        }

        private void DocPublisher_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("DocPublisher.pub");
        }

        private void DocAccess_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("DocAccess.accdb");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("GatoVentana.jpg");
        }
        //Propias
        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("FIRMA.exe");
        }

       
    }
}
