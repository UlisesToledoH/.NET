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
      

        
       
    }
}
