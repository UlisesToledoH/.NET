using System;
using System.IO;
using System.Windows.Forms;

namespace Tabla_Periodica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opcional: cualquier código de inicialización
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("FIRMA.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir FIRMA.exe: " + ex.Message);
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarElemento(string pdfPath, string videoPath, string webUrl)
        {
            try
            {
                // Cargar PDF
                if (File.Exists(pdfPath))
                    PDF1.LoadFile(pdfPath);
                else
                    MessageBox.Show("Archivo PDF no encontrado: " + pdfPath);

                // Reproducir video
                if (File.Exists(videoPath))
                {
                    Media1.URL = videoPath;
                    Media1.Ctlcontrols.play();
                }
                else
                    MessageBox.Show("Archivo de video no encontrado: " + videoPath);

                // Navegar web
                web1.Navigate(webUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el contenido: " + ex.Message);
            }
        }

        private void H_Click_1(object sender, EventArgs e)
        {
            CargarElemento("Hidrogeno.pdf", "Video_Hidrogeno.mp4", "https://www.google.com/search?q=hidrogeno+pdf");
        }

        private void Helio_Click(object sender, EventArgs e)
        {
            CargarElemento("Helio.pdf", "Video_Helio.mp4", "https://www.google.com/search?q=helio+pdf");
        }

        private void Mn_Click(object sender, EventArgs e)
        {
            CargarElemento("Manganeso.pdf", "Video_Manganeso.mp4", "https://www.google.com/search?q=manganeso+pdf");
        }
    }
}
