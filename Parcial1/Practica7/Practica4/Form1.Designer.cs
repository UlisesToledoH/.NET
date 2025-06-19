namespace Practica4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Residuo = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.Cosh = new System.Windows.Forms.Button();
            this.Senh = new System.Windows.Forms.Button();
            this.Atan = new System.Windows.Forms.Button();
            this.Acos = new System.Windows.Forms.Button();
            this.Asen = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Sen = new System.Windows.Forms.Button();
            this.btoper = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbsalida = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tBx);
            this.groupBox1.Location = new System.Drawing.Point(39, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 1;
            // 
            // tBx
            // 
            this.tBx.Location = new System.Drawing.Point(88, 34);
            this.tBx.Name = "tBx";
            this.tBx.Size = new System.Drawing.Size(112, 22);
            this.tBx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Residuo);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.Potencia);
            this.groupBox2.Controls.Add(this.Ln);
            this.groupBox2.Controls.Add(this.Tanh);
            this.groupBox2.Controls.Add(this.Cosh);
            this.groupBox2.Controls.Add(this.Senh);
            this.groupBox2.Controls.Add(this.Atan);
            this.groupBox2.Controls.Add(this.Acos);
            this.groupBox2.Controls.Add(this.Asen);
            this.groupBox2.Controls.Add(this.Tan);
            this.groupBox2.Controls.Add(this.Cos);
            this.groupBox2.Controls.Add(this.Sen);
            this.groupBox2.Controls.Add(this.btoper);
            this.groupBox2.Location = new System.Drawing.Point(292, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 313);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // Residuo
            // 
            this.Residuo.Location = new System.Drawing.Point(364, 226);
            this.Residuo.Name = "Residuo";
            this.Residuo.Size = new System.Drawing.Size(112, 23);
            this.Residuo.TabIndex = 17;
            this.Residuo.Text = "Residuo";
            this.Residuo.UseVisualStyleBackColor = true;
            this.Residuo.Click += new System.EventHandler(this.Residuo_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(364, 197);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 23);
            this.button15.TabIndex = 16;
            this.button15.Text = "Division";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Division_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(245, 197);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 23);
            this.button14.TabIndex = 15;
            this.button14.Text = "Multiplicacion";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(126, 197);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 23);
            this.button13.TabIndex = 14;
            this.button13.Text = "Resta";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Resta_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(7, 197);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Suma";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Potencia
            // 
            this.Potencia.Location = new System.Drawing.Point(126, 158);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(112, 23);
            this.Potencia.TabIndex = 12;
            this.Potencia.Text = "Potencia";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(7, 158);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(112, 23);
            this.Ln.TabIndex = 11;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.Log_Click);
            // 
            // Tanh
            // 
            this.Tanh.Location = new System.Drawing.Point(245, 129);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(112, 23);
            this.Tanh.TabIndex = 10;
            this.Tanh.Text = "Tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // Cosh
            // 
            this.Cosh.Location = new System.Drawing.Point(126, 129);
            this.Cosh.Name = "Cosh";
            this.Cosh.Size = new System.Drawing.Size(112, 23);
            this.Cosh.TabIndex = 9;
            this.Cosh.Text = "Cosh";
            this.Cosh.UseVisualStyleBackColor = true;
            this.Cosh.Click += new System.EventHandler(this.Cosh_Click);
            // 
            // Senh
            // 
            this.Senh.Location = new System.Drawing.Point(7, 129);
            this.Senh.Name = "Senh";
            this.Senh.Size = new System.Drawing.Size(112, 23);
            this.Senh.TabIndex = 8;
            this.Senh.Text = "Senh";
            this.Senh.UseVisualStyleBackColor = true;
            this.Senh.Click += new System.EventHandler(this.Sinh_Click);
            // 
            // Atan
            // 
            this.Atan.Location = new System.Drawing.Point(245, 100);
            this.Atan.Name = "Atan";
            this.Atan.Size = new System.Drawing.Size(112, 23);
            this.Atan.TabIndex = 7;
            this.Atan.Text = "ATan";
            this.Atan.UseVisualStyleBackColor = true;
            this.Atan.Click += new System.EventHandler(this.Atan_Click);
            // 
            // Acos
            // 
            this.Acos.Location = new System.Drawing.Point(126, 100);
            this.Acos.Name = "Acos";
            this.Acos.Size = new System.Drawing.Size(112, 23);
            this.Acos.TabIndex = 6;
            this.Acos.Text = "ACos";
            this.Acos.UseVisualStyleBackColor = true;
            this.Acos.Click += new System.EventHandler(this.Acos_Click);
            // 
            // Asen
            // 
            this.Asen.Location = new System.Drawing.Point(7, 100);
            this.Asen.Name = "Asen";
            this.Asen.Size = new System.Drawing.Size(112, 23);
            this.Asen.TabIndex = 5;
            this.Asen.Text = "ASen";
            this.Asen.UseVisualStyleBackColor = true;
            this.Asen.Click += new System.EventHandler(this.Asin_Click);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(245, 71);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(112, 23);
            this.Tan.TabIndex = 4;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(126, 71);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(112, 23);
            this.Cos.TabIndex = 3;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Sen
            // 
            this.Sen.Location = new System.Drawing.Point(7, 71);
            this.Sen.Name = "Sen";
            this.Sen.Size = new System.Drawing.Size(112, 23);
            this.Sen.TabIndex = 2;
            this.Sen.Text = "Sen";
            this.Sen.UseVisualStyleBackColor = true;
            this.Sen.Click += new System.EventHandler(this.Sen_Click);
            // 
            // btoper
            // 
            this.btoper.Location = new System.Drawing.Point(7, 33);
            this.btoper.Name = "btoper";
            this.btoper.Size = new System.Drawing.Size(112, 23);
            this.btoper.TabIndex = 1;
            this.btoper.Text = "Exp";
            this.btoper.UseVisualStyleBackColor = true;
            this.btoper.Click += new System.EventHandler(this.btoper_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbsalida);
            this.groupBox3.Location = new System.Drawing.Point(847, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 313);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // lbsalida
            // 
            this.lbsalida.BackColor = System.Drawing.Color.AliceBlue;
            this.lbsalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbsalida.FormattingEnabled = true;
            this.lbsalida.ItemHeight = 16;
            this.lbsalida.Location = new System.Drawing.Point(7, 33);
            this.lbsalida.Name = "lbsalida";
            this.lbsalida.Size = new System.Drawing.Size(212, 256);
            this.lbsalida.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1099, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btoper;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbsalida;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sen;
        private System.Windows.Forms.Button Asen;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button Cosh;
        private System.Windows.Forms.Button Senh;
        private System.Windows.Forms.Button Atan;
        private System.Windows.Forms.Button Acos;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Residuo;
    }
}

