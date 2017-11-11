namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butsuma = new System.Windows.Forms.Button();
            this.butresta = new System.Windows.Forms.Button();
            this.butdivicion = new System.Windows.Forms.Button();
            this.butprom = new System.Windows.Forms.Button();
            this.butmayor = new System.Windows.Forms.Button();
            this.butmenor = new System.Windows.Forms.Button();
            this.butequiva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.butmultipli = new System.Windows.Forms.Button();
            this.butcerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources._14753820_1197649496939981_2991313192955501940_o;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saul Montaño";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido a mi practica favorita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // butsuma
            // 
            this.butsuma.Location = new System.Drawing.Point(13, 225);
            this.butsuma.Name = "butsuma";
            this.butsuma.Size = new System.Drawing.Size(75, 23);
            this.butsuma.TabIndex = 7;
            this.butsuma.Text = "+";
            this.butsuma.UseVisualStyleBackColor = true;
            this.butsuma.Click += new System.EventHandler(this.butsuma_Click);
            // 
            // butresta
            // 
            this.butresta.Location = new System.Drawing.Point(94, 225);
            this.butresta.Name = "butresta";
            this.butresta.Size = new System.Drawing.Size(75, 23);
            this.butresta.TabIndex = 8;
            this.butresta.Text = "-";
            this.butresta.UseVisualStyleBackColor = true;
            this.butresta.Click += new System.EventHandler(this.butresta_Click);
            // 
            // butdivicion
            // 
            this.butdivicion.Location = new System.Drawing.Point(175, 225);
            this.butdivicion.Name = "butdivicion";
            this.butdivicion.Size = new System.Drawing.Size(75, 23);
            this.butdivicion.TabIndex = 9;
            this.butdivicion.Text = "/";
            this.butdivicion.UseVisualStyleBackColor = true;
            this.butdivicion.Click += new System.EventHandler(this.butdivicion_Click);
            // 
            // butprom
            // 
            this.butprom.Location = new System.Drawing.Point(12, 254);
            this.butprom.Name = "butprom";
            this.butprom.Size = new System.Drawing.Size(75, 23);
            this.butprom.TabIndex = 10;
            this.butprom.Text = "Promedio";
            this.butprom.UseVisualStyleBackColor = true;
            this.butprom.Click += new System.EventHandler(this.butprom_Click);
            // 
            // butmayor
            // 
            this.butmayor.Location = new System.Drawing.Point(94, 254);
            this.butmayor.Name = "butmayor";
            this.butmayor.Size = new System.Drawing.Size(75, 23);
            this.butmayor.TabIndex = 11;
            this.butmayor.Text = "Mayor";
            this.butmayor.UseVisualStyleBackColor = true;
            this.butmayor.Click += new System.EventHandler(this.butmayor_Click);
            // 
            // butmenor
            // 
            this.butmenor.Location = new System.Drawing.Point(175, 254);
            this.butmenor.Name = "butmenor";
            this.butmenor.Size = new System.Drawing.Size(75, 23);
            this.butmenor.TabIndex = 12;
            this.butmenor.Text = "Menor";
            this.butmenor.UseVisualStyleBackColor = true;
            this.butmenor.Click += new System.EventHandler(this.butmenor_Click);
            // 
            // butequiva
            // 
            this.butequiva.Location = new System.Drawing.Point(256, 254);
            this.butequiva.Name = "butequiva";
            this.butequiva.Size = new System.Drawing.Size(124, 23);
            this.butequiva.TabIndex = 13;
            this.butequiva.Text = "Equivalente literal";
            this.butequiva.UseVisualStyleBackColor = true;
            this.butequiva.Click += new System.EventHandler(this.butequiva_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resultado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 15;
            // 
            // butmultipli
            // 
            this.butmultipli.Location = new System.Drawing.Point(256, 225);
            this.butmultipli.Name = "butmultipli";
            this.butmultipli.Size = new System.Drawing.Size(75, 23);
            this.butmultipli.TabIndex = 16;
            this.butmultipli.Text = "*";
            this.butmultipli.UseVisualStyleBackColor = true;
            this.butmultipli.Click += new System.EventHandler(this.button1_Click);
            // 
            // butcerrar
            // 
            this.butcerrar.Location = new System.Drawing.Point(279, 317);
            this.butcerrar.Name = "butcerrar";
            this.butcerrar.Size = new System.Drawing.Size(75, 23);
            this.butcerrar.TabIndex = 17;
            this.butcerrar.Text = "Cerrar";
            this.butcerrar.UseVisualStyleBackColor = true;
            this.butcerrar.Click += new System.EventHandler(this.butcerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 358);
            this.Controls.Add(this.butcerrar);
            this.Controls.Add(this.butmultipli);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butequiva);
            this.Controls.Add(this.butmenor);
            this.Controls.Add(this.butmayor);
            this.Controls.Add(this.butprom);
            this.Controls.Add(this.butdivicion);
            this.Controls.Add(this.butresta);
            this.Controls.Add(this.butsuma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butsuma;
        private System.Windows.Forms.Button butresta;
        private System.Windows.Forms.Button butdivicion;
        private System.Windows.Forms.Button butprom;
        private System.Windows.Forms.Button butmayor;
        private System.Windows.Forms.Button butmenor;
        private System.Windows.Forms.Button butequiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button butmultipli;
        private System.Windows.Forms.Button butcerrar;
    }
}

