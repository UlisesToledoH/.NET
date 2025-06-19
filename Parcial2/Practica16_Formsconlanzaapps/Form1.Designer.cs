namespace Practica15_NavegacionForms
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
            this.FORM10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FIRMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FORM10
            // 
            this.FORM10.Location = new System.Drawing.Point(335, 177);
            this.FORM10.Name = "FORM10";
            this.FORM10.Size = new System.Drawing.Size(139, 37);
            this.FORM10.TabIndex = 0;
            this.FORM10.Text = "A FORM10";
            this.FORM10.UseVisualStyleBackColor = true;
            this.FORM10.Click += new System.EventHandler(this.FORM10_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "B FORM11";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FIRMA
            // 
            this.FIRMA.Location = new System.Drawing.Point(335, 352);
            this.FIRMA.Name = "FIRMA";
            this.FIRMA.Size = new System.Drawing.Size(139, 35);
            this.FIRMA.TabIndex = 2;
            this.FIRMA.Text = "FIRMA";
            this.FIRMA.UseVisualStyleBackColor = true;
            this.FIRMA.Click += new System.EventHandler(this.FIRMA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "LANZA APP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FIRMA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FORM10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FORM10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FIRMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

