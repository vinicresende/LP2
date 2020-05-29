namespace Menu
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnInsereP1 = new System.Windows.Forms.Button();
            this.btnInsereAsterisco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(70, 62);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(55, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1:";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(70, 92);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(58, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2: ";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(146, 54);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(318, 20);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(146, 84);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(318, 20);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(73, 171);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(112, 45);
            this.btnCompara.TabIndex = 4;
            this.btnCompara.Text = "Testar se são iguais";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnInsereP1
            // 
            this.btnInsereP1.Location = new System.Drawing.Point(211, 171);
            this.btnInsereP1.Name = "btnInsereP1";
            this.btnInsereP1.Size = new System.Drawing.Size(112, 45);
            this.btnInsereP1.TabIndex = 5;
            this.btnInsereP1.Text = "Inserir Palavra1 no meio da Palavra 2";
            this.btnInsereP1.UseVisualStyleBackColor = true;
            this.btnInsereP1.Click += new System.EventHandler(this.btnInsereP1_Click);
            // 
            // btnInsereAsterisco
            // 
            this.btnInsereAsterisco.Location = new System.Drawing.Point(352, 171);
            this.btnInsereAsterisco.Name = "btnInsereAsterisco";
            this.btnInsereAsterisco.Size = new System.Drawing.Size(112, 45);
            this.btnInsereAsterisco.TabIndex = 6;
            this.btnInsereAsterisco.Text = "Inserir * no meio da palavra 2";
            this.btnInsereAsterisco.UseVisualStyleBackColor = true;
            this.btnInsereAsterisco.Click += new System.EventHandler(this.btnInsereAsterisco_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 391);
            this.Controls.Add(this.btnInsereAsterisco);
            this.Controls.Add(this.btnInsereP1);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnInsereP1;
        private System.Windows.Forms.Button btnInsereAsterisco;
    }
}