namespace triangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLadoA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.picLine = new System.Windows.Forms.PictureBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.picTriangulo = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoA.Location = new System.Drawing.Point(112, 122);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(71, 17);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Lado A:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(189, 120);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(115, 22);
            this.txtA.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(383, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Teste para identificar triângulos";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(107, 50);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(214, 20);
            this.lblSubTitulo.TabIndex = 3;
            this.lblSubTitulo.Text = "Insira três valores para testar";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoB.Location = new System.Drawing.Point(112, 152);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(71, 17);
            this.lblLadoB.TabIndex = 0;
            this.lblLadoB.Text = "Lado B:";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoC.Location = new System.Drawing.Point(112, 180);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(71, 17);
            this.lblLadoC.TabIndex = 0;
            this.lblLadoC.Text = "Lado C:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(189, 150);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(115, 22);
            this.txtB.TabIndex = 2;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(189, 180);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(115, 22);
            this.txtC.TabIndex = 3;
            // 
            // picLine
            // 
            this.picLine.Image = ((System.Drawing.Image)(resources.GetObject("picLine.Image")));
            this.picLine.Location = new System.Drawing.Point(37, 223);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(378, 84);
            this.picLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLine.TabIndex = 4;
            this.picLine.TabStop = false;
            this.picLine.Visible = false;
            // 
            // btnTestar
            // 
            this.btnTestar.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.Location = new System.Drawing.Point(166, 214);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(118, 41);
            this.btnTestar.TabIndex = 4;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // picTriangulo
            // 
            this.picTriangulo.Location = new System.Drawing.Point(111, 348);
            this.picTriangulo.Name = "picTriangulo";
            this.picTriangulo.Size = new System.Drawing.Size(221, 161);
            this.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTriangulo.TabIndex = 6;
            this.picTriangulo.TabStop = false;
            this.picTriangulo.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(37, 296);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(378, 40);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 536);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.picTriangulo);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.picLine);
            this.Name = "Form1";
            this.Text = "Teste Triângulo";
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.PictureBox picLine;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.PictureBox picTriangulo;
        private System.Windows.Forms.Label lblResultado;
    }
}

