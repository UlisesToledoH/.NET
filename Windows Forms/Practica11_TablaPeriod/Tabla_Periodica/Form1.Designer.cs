namespace Tabla_Periodica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Documento = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Media1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.web1 = new AxSHDocVw.AxWebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.H = new System.Windows.Forms.Label();
            this.Helio = new System.Windows.Forms.Label();
            this.Mn = new System.Windows.Forms.Label();
            this.Documento.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.web1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Documento
            // 
            this.Documento.Controls.Add(this.tabPage1);
            this.Documento.Controls.Add(this.tabPage2);
            this.Documento.Controls.Add(this.tabPage3);
            this.Documento.Controls.Add(this.tabPage4);
            this.Documento.Controls.Add(this.tabPage5);
            this.Documento.Location = new System.Drawing.Point(428, 66);
            this.Documento.Name = "Documento";
            this.Documento.SelectedIndex = 0;
            this.Documento.Size = new System.Drawing.Size(853, 680);
            this.Documento.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PDF1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PDF1
            // 
            this.PDF1.Enabled = true;
            this.PDF1.Location = new System.Drawing.Point(131, 64);
            this.PDF1.Name = "PDF1";
            this.PDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF1.OcxState")));
            this.PDF1.Size = new System.Drawing.Size(461, 419);
            this.PDF1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Media1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Media";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Media1
            // 
            this.Media1.Enabled = true;
            this.Media1.Location = new System.Drawing.Point(16, 28);
            this.Media1.Name = "Media1";
            this.Media1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media1.OcxState")));
            this.Media1.Size = new System.Drawing.Size(388, 282);
            this.Media1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.web1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(718, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Web";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // web1
            // 
            this.web1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web1.Enabled = true;
            this.web1.Location = new System.Drawing.Point(3, 3);
            this.web1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("web1.OcxState")));
            this.web1.Size = new System.Drawing.Size(712, 517);
            this.web1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(718, 523);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nota";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(718, 523);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Otro";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.salidaToolStripMenuItem.Text = "Salir";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.BackColor = System.Drawing.Color.Transparent;
            this.H.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.H.Location = new System.Drawing.Point(32, 155);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(10, 16);
            this.H.TabIndex = 4;
            this.H.Text = ".";
            this.H.Click += new System.EventHandler(this.H_Click_1);
            // 
            // Helio
            // 
            this.Helio.AutoSize = true;
            this.Helio.BackColor = System.Drawing.Color.Transparent;
            this.Helio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Helio.Location = new System.Drawing.Point(384, 155);
            this.Helio.Name = "Helio";
            this.Helio.Size = new System.Drawing.Size(10, 16);
            this.Helio.TabIndex = 5;
            this.Helio.Text = ".";
            this.Helio.Click += new System.EventHandler(this.Helio_Click);
            // 
            // Mn
            // 
            this.Mn.AutoSize = true;
            this.Mn.BackColor = System.Drawing.Color.Transparent;
            this.Mn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mn.Location = new System.Drawing.Point(153, 240);
            this.Mn.Name = "Mn";
            this.Mn.Size = new System.Drawing.Size(10, 16);
            this.Mn.TabIndex = 6;
            this.Mn.Text = ".";
            this.Mn.Click += new System.EventHandler(this.Mn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1293, 758);
            this.Controls.Add(this.Mn);
            this.Controls.Add(this.Helio);
            this.Controls.Add(this.H);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Documento);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Documento.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Media1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.web1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl Documento;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label H;
        private AxAcroPDFLib.AxAcroPDF PDF1;
        private AxWMPLib.AxWindowsMediaPlayer Media1;
        private AxSHDocVw.AxWebBrowser web1;
        private System.Windows.Forms.Label Helio;
        private System.Windows.Forms.Label Mn;
    }
}

