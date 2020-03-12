namespace Volume
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_Raio = new System.Windows.Forms.TextBox();
            this.tx_Altura = new System.Windows.Forms.TextBox();
            this.tx_Volume = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_r = new System.Windows.Forms.Label();
            this.lb_h = new System.Windows.Forms.Label();
            this.lb_Vol = new System.Windows.Forms.Label();
            this.bt_Calc = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume: ";
            // 
            // tx_Raio
            // 
            this.tx_Raio.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Raio.Location = new System.Drawing.Point(123, 59);
            this.tx_Raio.Name = "tx_Raio";
            this.tx_Raio.Size = new System.Drawing.Size(142, 21);
            this.tx_Raio.TabIndex = 3;
            // 
            // tx_Altura
            // 
            this.tx_Altura.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Altura.Location = new System.Drawing.Point(123, 87);
            this.tx_Altura.Name = "tx_Altura";
            this.tx_Altura.Size = new System.Drawing.Size(142, 21);
            this.tx_Altura.TabIndex = 4;
            // 
            // tx_Volume
            // 
            this.tx_Volume.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Volume.Location = new System.Drawing.Point(123, 213);
            this.tx_Volume.Name = "tx_Volume";
            this.tx_Volume.ReadOnly = true;
            this.tx_Volume.Size = new System.Drawing.Size(142, 21);
            this.tx_Volume.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Volume.Properties.Resources.cilindro;
            this.pictureBox1.Location = new System.Drawing.Point(283, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lb_r
            // 
            this.lb_r.AutoSize = true;
            this.lb_r.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_r.Location = new System.Drawing.Point(324, 100);
            this.lb_r.Name = "lb_r";
            this.lb_r.Size = new System.Drawing.Size(44, 17);
            this.lb_r.TabIndex = 7;
            this.lb_r.Text = "r = ";
            // 
            // lb_h
            // 
            this.lb_h.AutoSize = true;
            this.lb_h.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_h.Location = new System.Drawing.Point(473, 160);
            this.lb_h.Name = "lb_h";
            this.lb_h.Size = new System.Drawing.Size(44, 17);
            this.lb_h.TabIndex = 8;
            this.lb_h.Text = "h = ";
            // 
            // lb_Vol
            // 
            this.lb_Vol.AutoSize = true;
            this.lb_Vol.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Vol.Location = new System.Drawing.Point(324, 262);
            this.lb_Vol.Name = "lb_Vol";
            this.lb_Vol.Size = new System.Drawing.Size(53, 17);
            this.lb_Vol.TabIndex = 9;
            this.lb_Vol.Text = "Vol =";
            // 
            // bt_Calc
            // 
            this.bt_Calc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calc.Location = new System.Drawing.Point(156, 145);
            this.bt_Calc.Name = "bt_Calc";
            this.bt_Calc.Size = new System.Drawing.Size(109, 32);
            this.bt_Calc.TabIndex = 10;
            this.bt_Calc.Text = "Calcular";
            this.bt_Calc.UseVisualStyleBackColor = true;
            this.bt_Calc.Click += new System.EventHandler(this.bt_Calc_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.Salmon;
            this.bt_Sair.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(156, 254);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(109, 32);
            this.bt_Sair.TabIndex = 11;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(41, 254);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(109, 32);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 350);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Calc);
            this.Controls.Add(this.lb_Vol);
            this.Controls.Add(this.lb_h);
            this.Controls.Add(this.lb_r);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_Volume);
            this.Controls.Add(this.tx_Altura);
            this.Controls.Add(this.tx_Raio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_Raio;
        private System.Windows.Forms.TextBox tx_Altura;
        private System.Windows.Forms.TextBox tx_Volume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_r;
        private System.Windows.Forms.Label lb_h;
        private System.Windows.Forms.Label lb_Vol;
        private System.Windows.Forms.Button bt_Calc;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Limpar;
    }
}

