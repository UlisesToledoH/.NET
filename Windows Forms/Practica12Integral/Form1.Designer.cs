namespace Integral
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
            this.Entrada = new System.Windows.Forms.GroupBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.Proceso = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Salida = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Entrada.SuspendLayout();
            this.Proceso.SuspendLayout();
            this.Salida.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.Controls.Add(this.tbx2);
            this.Entrada.Controls.Add(this.tbx1);
            this.Entrada.Location = new System.Drawing.Point(40, 79);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(125, 300);
            this.Entrada.TabIndex = 0;
            this.Entrada.TabStop = false;
            this.Entrada.Text = "Entrada";
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(6, 65);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 22);
            this.tbx2.TabIndex = 4;
            this.tbx2.TextChanged += new System.EventHandler(this.Xn_TextChanged);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(6, 37);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 22);
            this.tbx1.TabIndex = 3;
            this.tbx1.TextChanged += new System.EventHandler(this.Xo_TextChanged);
            // 
            // Proceso
            // 
            this.Proceso.Controls.Add(this.button1);
            this.Proceso.Location = new System.Drawing.Point(182, 79);
            this.Proceso.Name = "Proceso";
            this.Proceso.Size = new System.Drawing.Size(152, 300);
            this.Proceso.TabIndex = 1;
            this.Proceso.TabStop = false;
            this.Proceso.Text = "Proceso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc Integral";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Integral_click);
            // 
            // Salida
            // 
            this.Salida.Controls.Add(this.listBox1);
            this.Salida.Location = new System.Drawing.Point(340, 79);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(152, 300);
            this.Salida.TabIndex = 2;
            this.Salida.TabStop = false;
            this.Salida.Text = "Salida";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.Proceso);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Entrada.ResumeLayout(false);
            this.Entrada.PerformLayout();
            this.Proceso.ResumeLayout(false);
            this.Salida.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Entrada;
        private System.Windows.Forms.GroupBox Proceso;
        private System.Windows.Forms.GroupBox Salida;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

