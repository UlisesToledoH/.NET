namespace MatricesApp
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
            this.Proceso = new System.Windows.Forms.GroupBox();
            this.Salida = new System.Windows.Forms.GroupBox();
            this.Filas = new System.Windows.Forms.TextBox();
            this.Columnas = new System.Windows.Forms.TextBox();
            this.dGmat = new System.Windows.Forms.DataGridView();
            this.bttamaño = new System.Windows.Forms.Button();
            this.Leer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Entrada.SuspendLayout();
            this.Proceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGmat)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.Controls.Add(this.bttamaño);
            this.Entrada.Controls.Add(this.dGmat);
            this.Entrada.Controls.Add(this.Columnas);
            this.Entrada.Controls.Add(this.Filas);
            this.Entrada.Location = new System.Drawing.Point(40, 71);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(293, 608);
            this.Entrada.TabIndex = 0;
            this.Entrada.TabStop = false;
            this.Entrada.Text = "Entrada";
            // 
            // Proceso
            // 
            this.Proceso.Controls.Add(this.button4);
            this.Proceso.Controls.Add(this.button3);
            this.Proceso.Controls.Add(this.Leer);
            this.Proceso.Location = new System.Drawing.Point(339, 71);
            this.Proceso.Name = "Proceso";
            this.Proceso.Size = new System.Drawing.Size(255, 608);
            this.Proceso.TabIndex = 1;
            this.Proceso.TabStop = false;
            this.Proceso.Text = "Proceso";
            // 
            // Salida
            // 
            this.Salida.Location = new System.Drawing.Point(876, 71);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(255, 608);
            this.Salida.TabIndex = 2;
            this.Salida.TabStop = false;
            this.Salida.Text = "Salida";
            // 
            // Filas
            // 
            this.Filas.Location = new System.Drawing.Point(6, 404);
            this.Filas.Name = "Filas";
            this.Filas.Size = new System.Drawing.Size(100, 22);
            this.Filas.TabIndex = 0;
            this.Filas.Text = "m=";
            // 
            // Columnas
            // 
            this.Columnas.Location = new System.Drawing.Point(6, 432);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(100, 22);
            this.Columnas.TabIndex = 1;
            this.Columnas.Text = "n=";
            // 
            // dGmat
            // 
            this.dGmat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGmat.Location = new System.Drawing.Point(21, 56);
            this.dGmat.Name = "dGmat";
            this.dGmat.RowHeadersWidth = 51;
            this.dGmat.RowTemplate.Height = 24;
            this.dGmat.Size = new System.Drawing.Size(240, 150);
            this.dGmat.TabIndex = 2;
            // 
            // bttamaño
            // 
            this.bttamaño.Location = new System.Drawing.Point(104, 513);
            this.bttamaño.Name = "bttamaño";
            this.bttamaño.Size = new System.Drawing.Size(75, 23);
            this.bttamaño.TabIndex = 3;
            this.bttamaño.Text = "Tamaño";
            this.bttamaño.UseVisualStyleBackColor = true;
            this.bttamaño.Click += new System.EventHandler(this.bttamaño_Click);
            // 
            // Leer
            // 
            this.Leer.Location = new System.Drawing.Point(74, 172);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(75, 23);
            this.Leer.TabIndex = 4;
            this.Leer.Text = "Leer";
            this.Leer.UseVisualStyleBackColor = true;
            this.Leer.Click += new System.EventHandler(this.Leer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 721);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.Proceso);
            this.Controls.Add(this.Entrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Entrada.ResumeLayout(false);
            this.Entrada.PerformLayout();
            this.Proceso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGmat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Entrada;
        private System.Windows.Forms.TextBox Columnas;
        private System.Windows.Forms.TextBox Filas;
        private System.Windows.Forms.GroupBox Proceso;
        private System.Windows.Forms.GroupBox Salida;
        private System.Windows.Forms.DataGridView dGmat;
        private System.Windows.Forms.Button bttamaño;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Leer;
    }
}

